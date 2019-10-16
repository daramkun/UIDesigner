using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace UIDesigner
{
	[Serializable]
	public class UIObject
	{
		[NonSerialized]
		static Pen frame;
		[NonSerialized]
		static Font font;
		[NonSerialized]
		static Brush fontColor;
		[NonSerialized]
		static Pen resizeBox;
		[NonSerialized]
		static Font info;

		Rectangle rect;
		Color color;
		Image image;
		string text;

		void CreateNonSerializableObject ()
		{
			if ( frame == null )
				frame = new Pen ( Color.Black );
			if ( font == null )
				font = new Font ( "Consolas", 8 );
			if ( info == null )
				info = new Font ( "Consolas", 7 );
			if ( fontColor == null )
				fontColor = new SolidBrush ( Color.Black );
			if ( resizeBox == null )
				resizeBox = new Pen ( Color.Gray );
		}

		public UIObject ( int x, int y ) 
		{
			CreateNonSerializableObject ();

			rect = new Rectangle ( x, y, 100, 100 );
			color = Color.YellowGreen;
			image = null;
			text = "Created Object";
		}

		public int X { get { return rect.X; } set { rect.X = value; } }
		public int Y { get { return rect.Y; } set { rect.Y = value; } }
		public int Width { get { return rect.Width; } set { rect.Width = value; } }
		public int Height { get { return rect.Height; } set { rect.Height = value; } }
		public Rectangle Rectangle { get { return rect; } }
		public string Text { get { return text; } set { text = value; } }
		public Image Image { get { return image; } set { image = value; } }

		public Color Color
		{
			get { return color; }
			set { color = value; }
		}

		public void DrawObject ( Graphics g, bool isSelected, int mx, int my )
		{
			CreateNonSerializableObject ();

			g.Clip = new Region ( new Rectangle ( rect.X - mx, rect.Y - my, rect.Width + 1, rect.Height + 1 ) );

			SolidBrush brush = new SolidBrush ( color );
			g.FillRectangle ( brush, new Rectangle ( rect.X - mx, rect.Y - my, rect.Width, rect.Height ) );
			brush.Dispose ();
			if ( image != null )
				g.DrawImage ( image, new Rectangle ( rect.X - mx, rect.Y - my, rect.Width, rect.Height ) );
			g.DrawLine ( resizeBox, rect.X + rect.Width - mx, rect.Y + rect.Height - 10 - my,
				rect.X + rect.Width - 10 - mx, rect.Y + rect.Height - my );
			g.DrawLine ( resizeBox, rect.X + rect.Width - mx, rect.Y + rect.Height - 5 - my,
				rect.X + rect.Width - 5 - mx, rect.Y + rect.Height - my );
			if ( isSelected )
			{
				frame.Color = Color.DeepSkyBlue;
			}
			else
				frame.Color = Color.Black;
			g.DrawRectangle ( frame, new Rectangle ( rect.X - mx, rect.Y - my, rect.Width, rect.Height ) );

			SizeF size = g.MeasureString ( text, font );
			g.DrawString ( text, font, fontColor, new PointF ( rect.X + rect.Width / 2 - size.Width / 2 - mx, 
																rect.Y + rect.Height / 2 - size.Height / 2 - my ) );

			string temp = String.Format ( "({0}, {1}, {2}, {3})", rect.X, rect.Y, rect.Width, rect.Height );
			g.DrawString ( temp, info, fontColor, new Rectangle ( rect.X + 2 - mx, rect.Y + 2 - my, rect.Width - 4, 12 ) );
		}
	}
}