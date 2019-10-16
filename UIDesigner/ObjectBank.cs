using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace UIDesigner
{
	[Serializable]
	public class ObjectBank
	{
		[NonSerialized]
		UIObject selectedObject = null;
		[NonSerialized]
		int lastX, lastY;
		[NonSerialized]
		bool isClicked = false;
		[NonSerialized]
		bool isSize = false;
		[NonSerialized]
		bool isMoved = false;

		List<UIObject> objs = new List<UIObject> ();
		int width = 640, height = 480;

		public int Width { get { return width; } set { width = value; } }
		public int Height { get { return height; } set { height = value; } }

		public UIObject CurrentObject { get { return selectedObject; } }

		public void AddObject ( int x, int y )
		{
			objs.Add ( new UIObject ( x, y ) );
		}

		public void AddObject ( UIObject obj )
		{
			objs.Add ( obj );
		}

		public void RemoveObject ( UIObject obj )
		{
			objs.Remove ( obj );
		}

		public void Draw ( Graphics g, int mx, int my )
		{
			foreach ( UIObject o in objs )
				o.DrawObject ( g, ( o == selectedObject ), mx, my );
		}

		public void MouseDown ( int x, int y )
		{
			List<UIObject> temp = new List<UIObject> ( objs );
			temp.Reverse ();
			selectedObject = null;
			foreach ( UIObject u in temp )
			{
				if ( IsCrashed ( u.Rectangle, x, y ) )
				{
					selectedObject = u;
					isClicked = true;
					lastX = x; lastY = y;
					if ( IsSizeBoxCrashed ( u.Rectangle, x, y ) )
						isSize = true;
					break;
				}
			}
		}

		public bool MouseMove ( int x, int y )
		{
			if ( !isClicked ) return false;
			if ( isSize )
			{
				selectedObject.Width += x - lastX;
				selectedObject.Height += y - lastY;
			}
			else
			{
				selectedObject.X += x - lastX;
				selectedObject.Y += y - lastY;
			}
			lastX = x; lastY = y;
			isMoved = true;
			return true;
		}

		public bool MouseUp ( int x, int y )
		{
			if ( isClicked || isSize )
			{
				isClicked = false;
				isSize = false;
				if ( isMoved )
				{
					isMoved = false;
					return true;
				}
			}

			return false;
		}

		public bool IsCrashed ( Rectangle r, int x, int y )
		{
			return ( r.X <= x && x <= r.X + r.Width && r.Y <= y && y <= r.Y + r.Height );
		}

		public bool IsSizeBoxCrashed ( Rectangle r, int x, int y )
		{
			return ( r.X + r.Width - 10 <= x && x <= r.X + r.Width && r.Y + r.Height - 10 <= y && y <= r.Y + r.Height );
		}

		public void DeleteSelectedObject ()
		{
			if ( selectedObject == null ) return;
			objs.Remove ( selectedObject );
			selectedObject = null;
		}
	}
}