using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace UIDesigner
{
	public class UndoManager
	{
		Stack<byte []> undo = new Stack<byte []> ();
		Stack<byte []> redo = new Stack<byte []> ();
		BinaryFormatter bf = new BinaryFormatter ();
		MemoryStream mem = null;

		public ObjectBank Undo ()
		{
			if ( undo.Count == 0 ) return null;
			byte[] u = undo.Pop();
			redo.Push ( u );
			if ( mem != null ) mem.Close ();
			mem = new MemoryStream ( u );
			//mem.Write ( u, 0, u.Length );
			return bf.Deserialize ( mem ) as ObjectBank;
		}

		public ObjectBank Redo ()
		{
			if ( redo.Count == 0 ) return null;
			byte [] u = redo.Pop ();
			undo.Push ( u );
			if ( mem != null ) mem.Close ();
			mem = new MemoryStream ( u );
			//mem.Write ( u, 0, u.Length );
			return bf.Deserialize ( mem ) as ObjectBank;
		}

		public void Action ( ObjectBank obj )
		{
			if ( mem != null ) mem.Close ();
			mem = new MemoryStream ();
			bf.Serialize ( mem, obj );
			byte [] data = new byte [ mem.Length ];
			//mem.Read ( data, 0, data.Length );
			data = mem.ToArray ();
			undo.Push ( data );
		}
	}
}
