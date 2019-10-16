namespace UIDesigner
{
	partial class EditObject
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
			this.numX = new System.Windows.Forms.NumericUpDown ();
			this.numY = new System.Windows.Forms.NumericUpDown ();
			this.label2 = new System.Windows.Forms.Label ();
			this.numHeight = new System.Windows.Forms.NumericUpDown ();
			this.label3 = new System.Windows.Forms.Label ();
			this.numWidth = new System.Windows.Forms.NumericUpDown ();
			this.label4 = new System.Windows.Forms.Label ();
			this.label5 = new System.Windows.Forms.Label ();
			this.picColor = new System.Windows.Forms.PictureBox ();
			this.label6 = new System.Windows.Forms.Label ();
			this.txtText = new System.Windows.Forms.TextBox ();
			this.label7 = new System.Windows.Forms.Label ();
			this.picImage = new System.Windows.Forms.PictureBox ();
			this.button1 = new System.Windows.Forms.Button ();
			this.button2 = new System.Windows.Forms.Button ();
			( ( System.ComponentModel.ISupportInitialize ) ( this.numX ) ).BeginInit ();
			( ( System.ComponentModel.ISupportInitialize ) ( this.numY ) ).BeginInit ();
			( ( System.ComponentModel.ISupportInitialize ) ( this.numHeight ) ).BeginInit ();
			( ( System.ComponentModel.ISupportInitialize ) ( this.numWidth ) ).BeginInit ();
			( ( System.ComponentModel.ISupportInitialize ) ( this.picColor ) ).BeginInit ();
			( ( System.ComponentModel.ISupportInitialize ) ( this.picImage ) ).BeginInit ();
			this.SuspendLayout ();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point ( 52, 25 );
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size ( 20, 13 );
			this.label1.TabIndex = 0;
			this.label1.Text = "X :";
			// 
			// numX
			// 
			this.numX.Location = new System.Drawing.Point ( 78, 23 );
			this.numX.Maximum = new decimal ( new int [] {
            4096,
            0,
            0,
            0} );
			this.numX.Name = "numX";
			this.numX.Size = new System.Drawing.Size ( 110, 20 );
			this.numX.TabIndex = 1;
			this.numX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// numY
			// 
			this.numY.Location = new System.Drawing.Point ( 248, 23 );
			this.numY.Maximum = new decimal ( new int [] {
            4096,
            0,
            0,
            0} );
			this.numY.Name = "numY";
			this.numY.Size = new System.Drawing.Size ( 110, 20 );
			this.numY.TabIndex = 3;
			this.numY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point ( 222, 25 );
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size ( 20, 13 );
			this.label2.TabIndex = 2;
			this.label2.Text = "Y :";
			// 
			// numHeight
			// 
			this.numHeight.Location = new System.Drawing.Point ( 248, 50 );
			this.numHeight.Maximum = new decimal ( new int [] {
            4096,
            0,
            0,
            0} );
			this.numHeight.Name = "numHeight";
			this.numHeight.Size = new System.Drawing.Size ( 110, 20 );
			this.numHeight.TabIndex = 7;
			this.numHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point ( 194, 52 );
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size ( 48, 13 );
			this.label3.TabIndex = 6;
			this.label3.Text = "Height :";
			// 
			// numWidth
			// 
			this.numWidth.Location = new System.Drawing.Point ( 78, 50 );
			this.numWidth.Maximum = new decimal ( new int [] {
            4096,
            0,
            0,
            0} );
			this.numWidth.Name = "numWidth";
			this.numWidth.Size = new System.Drawing.Size ( 110, 20 );
			this.numWidth.TabIndex = 5;
			this.numWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point ( 27, 52 );
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size ( 45, 13 );
			this.label4.TabIndex = 4;
			this.label4.Text = "Width :";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point ( 31, 81 );
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size ( 41, 13 );
			this.label5.TabIndex = 8;
			this.label5.Text = "Color :";
			// 
			// picColor
			// 
			this.picColor.BackColor = System.Drawing.Color.White;
			this.picColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picColor.Location = new System.Drawing.Point ( 78, 77 );
			this.picColor.Name = "picColor";
			this.picColor.Size = new System.Drawing.Size ( 280, 21 );
			this.picColor.TabIndex = 9;
			this.picColor.TabStop = false;
			this.picColor.DoubleClick += new System.EventHandler ( this.picColor_DoubleClick );
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point ( 37, 107 );
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size ( 35, 13 );
			this.label6.TabIndex = 10;
			this.label6.Text = "Text :";
			// 
			// txtText
			// 
			this.txtText.Location = new System.Drawing.Point ( 78, 104 );
			this.txtText.Name = "txtText";
			this.txtText.Size = new System.Drawing.Size ( 280, 20 );
			this.txtText.TabIndex = 11;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point ( 27, 137 );
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size ( 45, 13 );
			this.label7.TabIndex = 12;
			this.label7.Text = "Image :";
			// 
			// picImage
			// 
			this.picImage.BackColor = System.Drawing.Color.White;
			this.picImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picImage.Location = new System.Drawing.Point ( 78, 131 );
			this.picImage.Name = "picImage";
			this.picImage.Size = new System.Drawing.Size ( 280, 202 );
			this.picImage.TabIndex = 13;
			this.picImage.TabStop = false;
			this.picImage.DoubleClick += new System.EventHandler ( this.picImage_DoubleClick );
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point ( 374, 23 );
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size ( 75, 23 );
			this.button1.TabIndex = 14;
			this.button1.Text = "Apply";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler ( this.button1_Click );
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point ( 374, 52 );
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size ( 75, 23 );
			this.button2.TabIndex = 15;
			this.button2.Text = "Cancel";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler ( this.button2_Click );
			// 
			// EditObject
			// 
			this.AcceptButton = this.button1;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size ( 482, 355 );
			this.Controls.Add ( this.button2 );
			this.Controls.Add ( this.button1 );
			this.Controls.Add ( this.picImage );
			this.Controls.Add ( this.label7 );
			this.Controls.Add ( this.txtText );
			this.Controls.Add ( this.label6 );
			this.Controls.Add ( this.picColor );
			this.Controls.Add ( this.label5 );
			this.Controls.Add ( this.numHeight );
			this.Controls.Add ( this.label3 );
			this.Controls.Add ( this.numWidth );
			this.Controls.Add ( this.label4 );
			this.Controls.Add ( this.numY );
			this.Controls.Add ( this.label2 );
			this.Controls.Add ( this.numX );
			this.Controls.Add ( this.label1 );
			this.Font = new System.Drawing.Font ( "NanumGothic", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 129 ) ) );
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "EditObject";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Edit UI Object";
			( ( System.ComponentModel.ISupportInitialize ) ( this.numX ) ).EndInit ();
			( ( System.ComponentModel.ISupportInitialize ) ( this.numY ) ).EndInit ();
			( ( System.ComponentModel.ISupportInitialize ) ( this.numHeight ) ).EndInit ();
			( ( System.ComponentModel.ISupportInitialize ) ( this.numWidth ) ).EndInit ();
			( ( System.ComponentModel.ISupportInitialize ) ( this.picColor ) ).EndInit ();
			( ( System.ComponentModel.ISupportInitialize ) ( this.picImage ) ).EndInit ();
			this.ResumeLayout ( false );
			this.PerformLayout ();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numX;
		private System.Windows.Forms.NumericUpDown numY;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown numHeight;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown numWidth;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.PictureBox picColor;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtText;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.PictureBox picImage;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
	}
}