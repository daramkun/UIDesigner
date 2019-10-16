using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Drawing.Imaging;
using System.Xml;

namespace UIDesigner
{
	public partial class Main : Form
	{
		ObjectBank objBank = new ObjectBank ();
		UndoManager undoManager = new UndoManager ();

		Brush whiteBrush = new SolidBrush ( Color.White );
		Brush grayBrush = new SolidBrush ( Color.DarkGray );
		Pen grayPen = new Pen ( Color.LightGray );
		Font guide = new Font ( "Terminal", 7 );

		bool isSaveOK = true;
		string savePath = "";

		public Main ()
		{
			InitializeComponent ();
		}

		public Main ( string arg )
		{
			InitializeComponent ();

			using ( FileStream fs = new FileStream ( arg, FileMode.Open ) )
			{
				BinaryFormatter bf = new BinaryFormatter ();
				objBank = bf.Deserialize ( fs ) as ObjectBank;
			}

			undoManager = new UndoManager ();

			isSaveOK = true;
			savePath = arg;

			ResizeChange ();

			Text = GetFileName ( savePath ) + " - Team Alchemist UI Designer";
		}

		bool IsSaved
		{
			get
			{
				if ( !isSaveOK )
				{
					DialogResult dr = MessageBox.Show ( "Do you want save this file?", "UI Designer", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question );
					switch ( dr )
					{ 
						case DialogResult.Yes:
							return SaveFile ();
						case DialogResult.No:
							return true;
						case DialogResult.Cancel:
							return false;
					}
				}

				return true;
			}
		}

		string GetFileName ( string path )
		{
			string [] temp = path.Split ( '\\' );
			string [] temp2 = temp[temp.Length - 1].Split ( '/' );
			return temp2 [ temp2.Length - 1 ];
		}

		void NewFile ()
		{
			if ( !IsSaved ) return;

			objBank = new ObjectBank ();
			undoManager = new UndoManager ();

			isSaveOK = true;
			savePath = "";

			ResizeChange ();

			Text = "Untitled.uid - Team Alchemist UI Designer";
		}

		void OpenFile ()
		{
			if ( !IsSaved ) return;

			if ( ofDialog.ShowDialog () == DialogResult.Cancel ) return;

			using ( FileStream fs = new FileStream ( ofDialog.FileName, FileMode.Open ) )
			{
				BinaryFormatter bf = new BinaryFormatter ();
				objBank = bf.Deserialize ( fs ) as ObjectBank;
			}

			undoManager = new UndoManager ();

			isSaveOK = true;
			savePath = ofDialog.FileName;

			ResizeChange ();

			Text = GetFileName ( savePath ) + " - Team Alchemist UI Designer";
		}

		bool SaveFile ()
		{
			if ( savePath == "" ) return SaveAsFile ();

			using ( FileStream fs = new FileStream ( savePath, FileMode.OpenOrCreate ) )
			{
				BinaryFormatter bf = new BinaryFormatter ();
				bf.Serialize ( fs, objBank );
			}

			isSaveOK = true;

			return true;
		}

		bool SaveAsFile ()
		{
			if ( sfDialog.ShowDialog () == DialogResult.Cancel ) return false;

			using ( FileStream fs = new FileStream ( sfDialog.FileName, FileMode.OpenOrCreate ) )
			{
				BinaryFormatter bf = new BinaryFormatter ();
				bf.Serialize ( fs, objBank );
			}

			isSaveOK = true;
			savePath = sfDialog.FileName;

			Text = GetFileName ( savePath ) + " - Team Alchemist UI Designer";

			return true;
		}

		void Undo ()
		{
			ObjectBank temp = undoManager.Undo ();
			if ( temp == null ) return;
			isSaveOK = false;
			objBank = temp;
			editBox.Refresh ();
		}

		void Redo ()
		{
			ObjectBank temp = undoManager.Redo ();
			if ( temp == null ) return;
			isSaveOK = false;
			objBank = temp;
			editBox.Refresh ();
		}

		void AddObject ()
		{
			undoManager.Action ( objBank );
			isSaveOK = false;
			objBank.AddObject ( 0, 0 );
			editBox.Refresh ();
		}

		void RemoveObject ()
		{
			undoManager.Action ( objBank );
			objBank.DeleteSelectedObject ();
			editBox.Refresh ();
		}

		void Cut ()
		{
			undoManager.Action ( objBank );
			Clipboard.SetData ( "UIObject", objBank.CurrentObject );
			objBank.DeleteSelectedObject ();
			isSaveOK = false;
			editBox.Refresh ();
		}

		void Copy ()
		{
			Clipboard.SetData ( "UIObject", objBank.CurrentObject );
		}

		void Paste ()
		{
			undoManager.Action ( objBank );
			objBank.AddObject ( Clipboard.GetData ( "UIObject" ) as UIObject );
			isSaveOK = false;
			editBox.Refresh ();
		}

		void ResizeChange ()
		{
			if ( ( editBox.Width - objBank.Width - 17 ) > 0 )
			{
				horizontalScroll.Maximum = 0;
				horizontalScroll.Enabled = false;
			}
			else
			{
				horizontalScroll.Maximum = ( editBox.Width - objBank.Width - 17 ) * -1;
				horizontalScroll.Enabled = true;
			}

			if ( ( editBox.Height - objBank.Height - 17 ) > 0 )
			{
				verticalScroll.Maximum = 0;
				verticalScroll.Enabled = false;
			}
			else
			{
				verticalScroll.Maximum = ( editBox.Height - objBank.Height - 17 ) * -1;
				verticalScroll.Enabled = true;
			}

			editBox.Refresh ();
		}

		private void mnuAdd_Click ( object sender, EventArgs e )
		{
			AddObject ();
		}

		private void mnuRemove_Click ( object sender, EventArgs e )
		{
			RemoveObject ();
		}

		private void mnuCut_Click ( object sender, EventArgs e )
		{
			Cut ();
		}

		private void mnuCopy_Click ( object sender, EventArgs e )
		{
			Copy ();
		}

		private void mnuPaste_Click ( object sender, EventArgs e )
		{
			Paste ();
		}

		private void editBox_Paint ( object sender, PaintEventArgs e )
		{
			e.Graphics.CompositingQuality = CompositingQuality.HighSpeed;
			e.Graphics.SmoothingMode = SmoothingMode.HighSpeed;
			e.Graphics.TextRenderingHint = TextRenderingHint.SingleBitPerPixelGridFit;

			Rectangle screen = new Rectangle ( 0, 0, editBox.Width, editBox.Height );

			e.Graphics.FillRectangle ( whiteBrush, screen );

			for ( int i = 10; i < objBank.Width; i += 10 )
			{
				e.Graphics.DrawLine ( grayPen, i - horizontalScroll.Value, 0, i - horizontalScroll.Value, objBank.Height );
				if ( i % 50 == 0 ) e.Graphics.DrawString ( i.ToString (), guide, grayBrush, i - horizontalScroll.Value, 0 );
			}
			for ( int i = 10; i < objBank.Height; i += 10 )
			{
				e.Graphics.DrawLine ( grayPen, 0, i - verticalScroll.Value, objBank.Width, i - verticalScroll.Value );
				if ( i % 50 == 0 ) e.Graphics.DrawString ( i.ToString (), guide, grayBrush, 0, i - verticalScroll.Value );
			}

			objBank.Draw ( e.Graphics, horizontalScroll.Value, verticalScroll.Value );

			e.Graphics.Clip = new Region ( screen );

			e.Graphics.FillRectangle ( grayBrush, new Rectangle ( objBank.Width + 1 - horizontalScroll.Value, -verticalScroll.Value,
				editBox.Width - objBank.Width + horizontalScroll.Value, editBox.Height + verticalScroll.Value ) );
			e.Graphics.FillRectangle ( grayBrush, new Rectangle ( -horizontalScroll.Value, objBank.Height + 1 - verticalScroll.Value,
				editBox.Width + horizontalScroll.Value, editBox.Height - objBank.Height + verticalScroll.Value ) );
		}

		private void editBox_MouseDown ( object sender, MouseEventArgs e )
		{
			undoManager.Action ( objBank );
			isSaveOK = false;
			objBank.MouseDown ( e.X + horizontalScroll.Value, e.Y + verticalScroll.Value );
			editBox.Refresh ();
		}

		private void editBox_MouseMove ( object sender, MouseEventArgs e )
		{
			objBank.MouseMove ( e.X + horizontalScroll.Value, e.Y + verticalScroll.Value );
			editBox.Refresh ();
		}

		private void editBox_MouseUp ( object sender, MouseEventArgs e )
		{
			objBank.MouseUp ( e.X + horizontalScroll.Value, e.Y + verticalScroll.Value );
			editBox.Refresh ();
		}

		private void editBox_DoubleClick ( object sender, EventArgs e )
		{
			UIObject o = objBank.CurrentObject;
			if ( o == null ) return;

			undoManager.Action ( objBank );
			new EditObject ( o ).ShowDialog ();
			editBox.Refresh ();
		}

		private void mnuUndo_Click ( object sender, EventArgs e )
		{
			Undo ();
		}

		private void mnuRedo_Click ( object sender, EventArgs e )
		{
			Redo ();
		}

		private void mnuDelete_Click ( object sender, EventArgs e )
		{
			undoManager.Action ( objBank );
			objBank.DeleteSelectedObject ();
			isSaveOK = false;
			editBox.Refresh ();
		}

		private void mnuExit_Click ( object sender, EventArgs e )
		{
			this.Close ();
		}

		private void mnuSetScreenSize_Click ( object sender, EventArgs e )
		{
			undoManager.Action ( objBank );
			if ( new SetScreenSize ( objBank ).ShowDialog () != DialogResult.Cancel )
				isSaveOK = false;
			ResizeChange ();
			editBox.Refresh ();
		}

		private void mnuNew_Click ( object sender, EventArgs e )
		{
			NewFile ();
		}

		private void mnuOpen_Click ( object sender, EventArgs e )
		{
			OpenFile ();
		}

		private void mnuSave_Click ( object sender, EventArgs e )
		{
			SaveFile ();
		}

		private void mnuSaveAs_Click ( object sender, EventArgs e )
		{
			SaveAsFile ();
		}

		private void tsUndo_Click ( object sender, EventArgs e )
		{
			Undo ();
		}

		private void tsRedo_Click ( object sender, EventArgs e )
		{
			Redo ();
		}

		private void tsCut_Click ( object sender, EventArgs e )
		{
			Cut ();
		}

		private void tsCopy_Click ( object sender, EventArgs e )
		{
			Copy ();
		}

		private void tsPaste_Click ( object sender, EventArgs e )
		{
			Paste ();
		}

		private void tsAddObj_Click ( object sender, EventArgs e )
		{
			AddObject ();
		}

		private void tsRemoveObj_Click ( object sender, EventArgs e )
		{
			RemoveObject ();
		}

		private void tsHelp_Click ( object sender, EventArgs e )
		{
			new About ().ShowDialog ();
		}

		private void tsNew_Click ( object sender, EventArgs e )
		{
			NewFile ();
		}

		private void tsOpen_Click ( object sender, EventArgs e )
		{
			OpenFile ();
		}

		private void tsSave_Click ( object sender, EventArgs e )
		{
			SaveFile ();
		}

		private void Main_Resize ( object sender, EventArgs e )
		{
			ResizeChange ();
		}

		private void horizontalScroll_Scroll ( object sender, ScrollEventArgs e )
		{
			editBox.Refresh ();
		}

		private void mnuAbout_Click ( object sender, EventArgs e )
		{
			new About ().ShowDialog ();
		}

		private void mnuExportXML_Click ( object sender, EventArgs e )
		{
			SaveFileDialog sfd = new SaveFileDialog ();
			sfd.Filter = "eXtended Markup Language File Format(*.xml)|*.xml";

			if ( sfd.ShowDialog () == DialogResult.Cancel ) return;

			using ( XmlTextWriter xw = new XmlTextWriter ( sfd.FileName, Encoding.UTF8 ) )
			{ 

			}
		}

		private void mnuExportPNG_Click ( object sender, EventArgs e )
		{
			SaveFileDialog sfd = new SaveFileDialog ();
			sfd.Filter = "Portable Network Graphics File Format(*.png)|*.png|Jpeg Format(*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
				"Graphics Interchange Format(*.gif)|*.gif|Tagged Image File Format(*.tiff)|*.tiff|Bitmap File Format(*.bmp)|*.bmp";

			if ( sfd.ShowDialog () == DialogResult.Cancel ) return;

			Bitmap backBuffer = new Bitmap ( objBank.Width, objBank.Height );
			Graphics backGraphics = Graphics.FromImage ( backBuffer );

			backGraphics.CompositingQuality = CompositingQuality.HighSpeed;
			backGraphics.SmoothingMode = SmoothingMode.HighSpeed;
			backGraphics.TextRenderingHint = TextRenderingHint.SingleBitPerPixelGridFit;

			Rectangle screen = new Rectangle ( 0, 0, objBank.Width, objBank.Height );

			backGraphics.FillRectangle ( whiteBrush, screen );

			for ( int i = 10; i < objBank.Width; i += 10 )
			{
				backGraphics.DrawLine ( grayPen, i, 0, i, objBank.Height );
				if ( i % 50 == 0 ) backGraphics.DrawString ( i.ToString (), guide, grayBrush, i, 0 );
			}
			for ( int i = 10; i < objBank.Height; i += 10 )
			{
				backGraphics.DrawLine ( grayPen, 0, i, objBank.Width, i );
				if ( i % 50 == 0 ) backGraphics.DrawString ( i.ToString (), guide, grayBrush, 0, i );
			}

			objBank.Draw ( backGraphics, 0, 0 );

			backBuffer.Save ( sfd.FileName );
		}

		private void Main_Load ( object sender, EventArgs e )
		{
			ResizeChange ();
		}
	}
}
