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
	public partial class SetScreenSize : Form
	{
		ObjectBank objBank;

		public SetScreenSize ( ObjectBank _objBank )
		{
			InitializeComponent ();

			objBank = _objBank;

			numWidth.Value = objBank.Width;
			numHeight.Value = objBank.Height;
		}

		private void btnOK_Click ( object sender, EventArgs e )
		{
			objBank.Width = ( int ) numWidth.Value;
			objBank.Height = ( int ) numHeight.Value;
			DialogResult = DialogResult.OK;
		}
	}
}
