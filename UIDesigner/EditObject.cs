using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UIDesigner
{
	public partial class EditObject : Form
	{
		UIObject obj;

		public EditObject ( UIObject o )
		{
			InitializeComponent ();
			obj = o;

			numX.Value = obj.X; numY.Value = obj.Y;
			numWidth.Value = obj.Width; numHeight.Value = obj.Height;
			picColor.BackColor = obj.Color;
			txtText.Text = obj.Text;
			picImage.Image = obj.Image;
		}

		private void button2_Click ( object sender, EventArgs e )
		{
			DialogResult = DialogResult.Cancel;
		}

		private void button1_Click ( object sender, EventArgs e )
		{
			obj.X = ( int ) numX.Value; obj.Y = ( int ) numY.Value;
			obj.Width = ( int ) numWidth.Value; obj.Height = ( int ) numHeight.Value;
			obj.Color = picColor.BackColor;
			obj.Text = txtText.Text;
			obj.Image = picImage.Image;

			DialogResult = DialogResult.OK;
		}

		private void picColor_DoubleClick ( object sender, EventArgs e )
		{
			ColorDialog cd = new ColorDialog ();
			cd.Color = picColor.BackColor;
			if ( cd.ShowDialog () == DialogResult.Cancel ) return;
			picColor.BackColor = cd.Color;
		}

		private void picImage_DoubleClick ( object sender, EventArgs e )
		{
			OpenFileDialog ofd = new OpenFileDialog ();
			ofd.FileName = "";
			ofd.Filter = "Portable Network Graphics File Format(*.png)|*.png|Jpeg Format(*.jpg;*.jpeg)|*.jpg;*.jpeg|" + 
				"Graphics Interchange Format(*.gif)|*.gif|Tagged Image File Format(*.tiff)|*.tiff|Bitmap File Format(*.bmp)|*.bmp";
			if ( ofd.ShowDialog () == DialogResult.Cancel ) return;
			picImage.Image = Image.FromFile ( ofd.FileName );
		}
	}
}
