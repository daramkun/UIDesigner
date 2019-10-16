namespace UIDesigner
{
	partial class SetScreenSize
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose ( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose ();
			}
			base.Dispose ( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent ()
		{
			this.label1 = new System.Windows.Forms.Label ();
			this.numWidth = new System.Windows.Forms.NumericUpDown ();
			this.numHeight = new System.Windows.Forms.NumericUpDown ();
			this.label2 = new System.Windows.Forms.Label ();
			this.btnOK = new System.Windows.Forms.Button ();
			( ( System.ComponentModel.ISupportInitialize ) ( this.numWidth ) ).BeginInit ();
			( ( System.ComponentModel.ISupportInitialize ) ( this.numHeight ) ).BeginInit ();
			this.SuspendLayout ();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point ( 32, 35 );
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size ( 43, 13 );
			this.label1.TabIndex = 0;
			this.label1.Text = "Width :";
			// 
			// numWidth
			// 
			this.numWidth.Location = new System.Drawing.Point ( 81, 33 );
			this.numWidth.Maximum = new decimal ( new int [] {
            2048,
            0,
            0,
            0} );
			this.numWidth.Name = "numWidth";
			this.numWidth.Size = new System.Drawing.Size ( 120, 22 );
			this.numWidth.TabIndex = 1;
			// 
			// numHeight
			// 
			this.numHeight.Location = new System.Drawing.Point ( 286, 33 );
			this.numHeight.Maximum = new decimal ( new int [] {
            2048,
            0,
            0,
            0} );
			this.numHeight.Name = "numHeight";
			this.numHeight.Size = new System.Drawing.Size ( 120, 22 );
			this.numHeight.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point ( 232, 35 );
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size ( 47, 13 );
			this.label2.TabIndex = 2;
			this.label2.Text = "Height :";
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point ( 184, 78 );
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size ( 75, 23 );
			this.btnOK.TabIndex = 4;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler ( this.btnOK_Click );
			// 
			// SetScreenSize
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size ( 445, 129 );
			this.Controls.Add ( this.btnOK );
			this.Controls.Add ( this.numHeight );
			this.Controls.Add ( this.label2 );
			this.Controls.Add ( this.numWidth );
			this.Controls.Add ( this.label1 );
			this.Font = new System.Drawing.Font ( "Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 129 ) ) );
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SetScreenSize";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Set Screen Size";
			( ( System.ComponentModel.ISupportInitialize ) ( this.numWidth ) ).EndInit ();
			( ( System.ComponentModel.ISupportInitialize ) ( this.numHeight ) ).EndInit ();
			this.ResumeLayout ( false );
			this.PerformLayout ();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numWidth;
		private System.Windows.Forms.NumericUpDown numHeight;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnOK;
	}
}