namespace UIDesigner
{
	partial class Main
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip ();
			this.mnuFile = new System.Windows.Forms.ToolStripMenuItem ();
			this.mnuNew = new System.Windows.Forms.ToolStripMenuItem ();
			this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem ();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator ();
			this.mnuSave = new System.Windows.Forms.ToolStripMenuItem ();
			this.mnuSaveAs = new System.Windows.Forms.ToolStripMenuItem ();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator ();
			this.mnuExportXML = new System.Windows.Forms.ToolStripMenuItem ();
			this.mnuExportPNG = new System.Windows.Forms.ToolStripMenuItem ();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator ();
			this.mnuExit = new System.Windows.Forms.ToolStripMenuItem ();
			this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem ();
			this.mnuUndo = new System.Windows.Forms.ToolStripMenuItem ();
			this.mnuRedo = new System.Windows.Forms.ToolStripMenuItem ();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator ();
			this.mnuCut = new System.Windows.Forms.ToolStripMenuItem ();
			this.mnuCopy = new System.Windows.Forms.ToolStripMenuItem ();
			this.mnuPaste = new System.Windows.Forms.ToolStripMenuItem ();
			this.mnuDelete = new System.Windows.Forms.ToolStripMenuItem ();
			this.mnuObject = new System.Windows.Forms.ToolStripMenuItem ();
			this.mnuAdd = new System.Windows.Forms.ToolStripMenuItem ();
			this.mnuRemove = new System.Windows.Forms.ToolStripMenuItem ();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator ();
			this.mnuSetScreenSize = new System.Windows.Forms.ToolStripMenuItem ();
			this.mnuTools = new System.Windows.Forms.ToolStripMenuItem ();
			this.mnuOptions = new System.Windows.Forms.ToolStripMenuItem ();
			this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem ();
			this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem ();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip ();
			this.tsNew = new System.Windows.Forms.ToolStripButton ();
			this.tsOpen = new System.Windows.Forms.ToolStripButton ();
			this.tsSave = new System.Windows.Forms.ToolStripButton ();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator ();
			this.tsUndo = new System.Windows.Forms.ToolStripButton ();
			this.tsRedo = new System.Windows.Forms.ToolStripButton ();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator ();
			this.tsCut = new System.Windows.Forms.ToolStripButton ();
			this.tsCopy = new System.Windows.Forms.ToolStripButton ();
			this.tsPaste = new System.Windows.Forms.ToolStripButton ();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator ();
			this.tsAddObj = new System.Windows.Forms.ToolStripButton ();
			this.tsRemoveObj = new System.Windows.Forms.ToolStripButton ();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator ();
			this.tsHelp = new System.Windows.Forms.ToolStripButton ();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip ();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel ();
			this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel ();
			this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel ();
			this.sfDialog = new System.Windows.Forms.SaveFileDialog ();
			this.ofDialog = new System.Windows.Forms.OpenFileDialog ();
			this.verticalScroll = new System.Windows.Forms.VScrollBar ();
			this.horizontalScroll = new System.Windows.Forms.HScrollBar ();
			this.pictureBox1 = new System.Windows.Forms.PictureBox ();
			this.editBox = new System.Windows.Forms.PictureBox ();
			this.menuStrip1.SuspendLayout ();
			this.toolStrip1.SuspendLayout ();
			this.statusStrip1.SuspendLayout ();
			( ( System.ComponentModel.ISupportInitialize ) ( this.pictureBox1 ) ).BeginInit ();
			( ( System.ComponentModel.ISupportInitialize ) ( this.editBox ) ).BeginInit ();
			this.SuspendLayout ();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Font = new System.Drawing.Font ( "Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 129 ) ) );
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size ( 14, 14 );
			this.menuStrip1.Items.AddRange ( new System.Windows.Forms.ToolStripItem [] {
            this.mnuFile,
            this.mnuEdit,
            this.mnuObject,
            this.mnuTools,
            this.mnuHelp} );
			this.menuStrip1.Location = new System.Drawing.Point ( 0, 0 );
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size ( 710, 24 );
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// mnuFile
			// 
			this.mnuFile.DropDownItems.AddRange ( new System.Windows.Forms.ToolStripItem [] {
            this.mnuNew,
            this.mnuOpen,
            this.toolStripMenuItem1,
            this.mnuSave,
            this.mnuSaveAs,
            this.toolStripMenuItem2,
            this.mnuExportXML,
            this.mnuExportPNG,
            this.toolStripMenuItem3,
            this.mnuExit} );
			this.mnuFile.Image = global::UIDesigner.Properties.Resources.application;
			this.mnuFile.Name = "mnuFile";
			this.mnuFile.Size = new System.Drawing.Size ( 50, 20 );
			this.mnuFile.Text = "&File";
			// 
			// mnuNew
			// 
			this.mnuNew.Image = global::UIDesigner.Properties.Resources.page;
			this.mnuNew.Name = "mnuNew";
			this.mnuNew.Size = new System.Drawing.Size ( 177, 22 );
			this.mnuNew.Text = "&New UI";
			this.mnuNew.Click += new System.EventHandler ( this.mnuNew_Click );
			// 
			// mnuOpen
			// 
			this.mnuOpen.Image = global::UIDesigner.Properties.Resources.folder;
			this.mnuOpen.Name = "mnuOpen";
			this.mnuOpen.Size = new System.Drawing.Size ( 177, 22 );
			this.mnuOpen.Text = "&Open";
			this.mnuOpen.Click += new System.EventHandler ( this.mnuOpen_Click );
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size ( 174, 6 );
			// 
			// mnuSave
			// 
			this.mnuSave.Image = global::UIDesigner.Properties.Resources.disk;
			this.mnuSave.Name = "mnuSave";
			this.mnuSave.Size = new System.Drawing.Size ( 177, 22 );
			this.mnuSave.Text = "&Save";
			this.mnuSave.Click += new System.EventHandler ( this.mnuSave_Click );
			// 
			// mnuSaveAs
			// 
			this.mnuSaveAs.Name = "mnuSaveAs";
			this.mnuSaveAs.Size = new System.Drawing.Size ( 177, 22 );
			this.mnuSaveAs.Text = "Save &as";
			this.mnuSaveAs.Click += new System.EventHandler ( this.mnuSaveAs_Click );
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size ( 174, 6 );
			// 
			// mnuExportXML
			// 
			this.mnuExportXML.Enabled = false;
			this.mnuExportXML.Name = "mnuExportXML";
			this.mnuExportXML.Size = new System.Drawing.Size ( 177, 22 );
			this.mnuExportXML.Text = "Export about XML";
			this.mnuExportXML.Click += new System.EventHandler ( this.mnuExportXML_Click );
			// 
			// mnuExportPNG
			// 
			this.mnuExportPNG.Name = "mnuExportPNG";
			this.mnuExportPNG.Size = new System.Drawing.Size ( 177, 22 );
			this.mnuExportPNG.Text = "Export about Image";
			this.mnuExportPNG.Click += new System.EventHandler ( this.mnuExportPNG_Click );
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size ( 174, 6 );
			// 
			// mnuExit
			// 
			this.mnuExit.Name = "mnuExit";
			this.mnuExit.Size = new System.Drawing.Size ( 177, 22 );
			this.mnuExit.Text = "E&xit";
			this.mnuExit.Click += new System.EventHandler ( this.mnuExit_Click );
			// 
			// mnuEdit
			// 
			this.mnuEdit.DropDownItems.AddRange ( new System.Windows.Forms.ToolStripItem [] {
            this.mnuUndo,
            this.mnuRedo,
            this.toolStripMenuItem4,
            this.mnuCut,
            this.mnuCopy,
            this.mnuPaste,
            this.mnuDelete} );
			this.mnuEdit.Image = global::UIDesigner.Properties.Resources.overlays;
			this.mnuEdit.Name = "mnuEdit";
			this.mnuEdit.Size = new System.Drawing.Size ( 53, 20 );
			this.mnuEdit.Text = "&Edit";
			// 
			// mnuUndo
			// 
			this.mnuUndo.Image = global::UIDesigner.Properties.Resources.arrow_undo;
			this.mnuUndo.Name = "mnuUndo";
			this.mnuUndo.ShortcutKeys = ( ( System.Windows.Forms.Keys ) ( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z ) ) );
			this.mnuUndo.Size = new System.Drawing.Size ( 141, 22 );
			this.mnuUndo.Text = "&Undo";
			this.mnuUndo.Click += new System.EventHandler ( this.mnuUndo_Click );
			// 
			// mnuRedo
			// 
			this.mnuRedo.Image = global::UIDesigner.Properties.Resources.arrow_redo;
			this.mnuRedo.Name = "mnuRedo";
			this.mnuRedo.ShortcutKeys = ( ( System.Windows.Forms.Keys ) ( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y ) ) );
			this.mnuRedo.Size = new System.Drawing.Size ( 141, 22 );
			this.mnuRedo.Text = "&Redo";
			this.mnuRedo.Click += new System.EventHandler ( this.mnuRedo_Click );
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new System.Drawing.Size ( 138, 6 );
			// 
			// mnuCut
			// 
			this.mnuCut.Image = global::UIDesigner.Properties.Resources.cut;
			this.mnuCut.Name = "mnuCut";
			this.mnuCut.ShortcutKeys = ( ( System.Windows.Forms.Keys ) ( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X ) ) );
			this.mnuCut.Size = new System.Drawing.Size ( 141, 22 );
			this.mnuCut.Text = "Cu&t";
			this.mnuCut.Click += new System.EventHandler ( this.mnuCut_Click );
			// 
			// mnuCopy
			// 
			this.mnuCopy.Image = global::UIDesigner.Properties.Resources.page_copy;
			this.mnuCopy.Name = "mnuCopy";
			this.mnuCopy.ShortcutKeys = ( ( System.Windows.Forms.Keys ) ( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C ) ) );
			this.mnuCopy.Size = new System.Drawing.Size ( 141, 22 );
			this.mnuCopy.Text = "&Copy";
			this.mnuCopy.Click += new System.EventHandler ( this.mnuCopy_Click );
			// 
			// mnuPaste
			// 
			this.mnuPaste.Image = global::UIDesigner.Properties.Resources.page_paste;
			this.mnuPaste.Name = "mnuPaste";
			this.mnuPaste.ShortcutKeys = ( ( System.Windows.Forms.Keys ) ( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V ) ) );
			this.mnuPaste.Size = new System.Drawing.Size ( 141, 22 );
			this.mnuPaste.Text = "&Paste";
			this.mnuPaste.Click += new System.EventHandler ( this.mnuPaste_Click );
			// 
			// mnuDelete
			// 
			this.mnuDelete.Name = "mnuDelete";
			this.mnuDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
			this.mnuDelete.Size = new System.Drawing.Size ( 141, 22 );
			this.mnuDelete.Text = "&Delete";
			this.mnuDelete.Click += new System.EventHandler ( this.mnuDelete_Click );
			// 
			// mnuObject
			// 
			this.mnuObject.DropDownItems.AddRange ( new System.Windows.Forms.ToolStripItem [] {
            this.mnuAdd,
            this.mnuRemove,
            this.toolStripSeparator6,
            this.mnuSetScreenSize} );
			this.mnuObject.Image = global::UIDesigner.Properties.Resources.package;
			this.mnuObject.Name = "mnuObject";
			this.mnuObject.Size = new System.Drawing.Size ( 67, 20 );
			this.mnuObject.Text = "&Object";
			// 
			// mnuAdd
			// 
			this.mnuAdd.Image = global::UIDesigner.Properties.Resources.brick_add;
			this.mnuAdd.Name = "mnuAdd";
			this.mnuAdd.Size = new System.Drawing.Size ( 153, 22 );
			this.mnuAdd.Text = "&Add Object";
			this.mnuAdd.Click += new System.EventHandler ( this.mnuAdd_Click );
			// 
			// mnuRemove
			// 
			this.mnuRemove.Image = global::UIDesigner.Properties.Resources.brick_delete;
			this.mnuRemove.Name = "mnuRemove";
			this.mnuRemove.Size = new System.Drawing.Size ( 153, 22 );
			this.mnuRemove.Text = "&Remove Object";
			this.mnuRemove.Click += new System.EventHandler ( this.mnuRemove_Click );
			// 
			// toolStripSeparator6
			// 
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new System.Drawing.Size ( 150, 6 );
			// 
			// mnuSetScreenSize
			// 
			this.mnuSetScreenSize.Name = "mnuSetScreenSize";
			this.mnuSetScreenSize.Size = new System.Drawing.Size ( 153, 22 );
			this.mnuSetScreenSize.Text = "&Set screen size";
			this.mnuSetScreenSize.Click += new System.EventHandler ( this.mnuSetScreenSize_Click );
			// 
			// mnuTools
			// 
			this.mnuTools.DropDownItems.AddRange ( new System.Windows.Forms.ToolStripItem [] {
            this.mnuOptions} );
			this.mnuTools.Image = global::UIDesigner.Properties.Resources.wrench;
			this.mnuTools.Name = "mnuTools";
			this.mnuTools.Size = new System.Drawing.Size ( 61, 20 );
			this.mnuTools.Text = "&Tools";
			// 
			// mnuOptions
			// 
			this.mnuOptions.Enabled = false;
			this.mnuOptions.Name = "mnuOptions";
			this.mnuOptions.Size = new System.Drawing.Size ( 115, 22 );
			this.mnuOptions.Text = "&Options";
			// 
			// mnuHelp
			// 
			this.mnuHelp.DropDownItems.AddRange ( new System.Windows.Forms.ToolStripItem [] {
            this.mnuAbout} );
			this.mnuHelp.Image = global::UIDesigner.Properties.Resources.help;
			this.mnuHelp.Name = "mnuHelp";
			this.mnuHelp.Size = new System.Drawing.Size ( 57, 20 );
			this.mnuHelp.Text = "&Help";
			// 
			// mnuAbout
			// 
			this.mnuAbout.Image = global::UIDesigner.Properties.Resources.help;
			this.mnuAbout.Name = "mnuAbout";
			this.mnuAbout.Size = new System.Drawing.Size ( 111, 22 );
			this.mnuAbout.Text = "&About...";
			this.mnuAbout.Click += new System.EventHandler ( this.mnuAbout_Click );
			// 
			// toolStrip1
			// 
			this.toolStrip1.Font = new System.Drawing.Font ( "Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 129 ) ) );
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size ( 14, 14 );
			this.toolStrip1.Items.AddRange ( new System.Windows.Forms.ToolStripItem [] {
            this.tsNew,
            this.tsOpen,
            this.tsSave,
            this.toolStripSeparator1,
            this.tsUndo,
            this.tsRedo,
            this.toolStripSeparator2,
            this.tsCut,
            this.tsCopy,
            this.tsPaste,
            this.toolStripSeparator3,
            this.tsAddObj,
            this.tsRemoveObj,
            this.toolStripSeparator4,
            this.tsHelp} );
			this.toolStrip1.Location = new System.Drawing.Point ( 0, 24 );
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size ( 710, 25 );
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// tsNew
			// 
			this.tsNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsNew.Image = global::UIDesigner.Properties.Resources.page;
			this.tsNew.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsNew.Name = "tsNew";
			this.tsNew.Size = new System.Drawing.Size ( 23, 22 );
			this.tsNew.Text = "toolStripButton1";
			this.tsNew.Click += new System.EventHandler ( this.tsNew_Click );
			// 
			// tsOpen
			// 
			this.tsOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsOpen.Image = global::UIDesigner.Properties.Resources.folder;
			this.tsOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsOpen.Name = "tsOpen";
			this.tsOpen.Size = new System.Drawing.Size ( 23, 22 );
			this.tsOpen.Text = "toolStripButton2";
			this.tsOpen.Click += new System.EventHandler ( this.tsOpen_Click );
			// 
			// tsSave
			// 
			this.tsSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsSave.Image = global::UIDesigner.Properties.Resources.disk;
			this.tsSave.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsSave.Name = "tsSave";
			this.tsSave.Size = new System.Drawing.Size ( 23, 22 );
			this.tsSave.Text = "toolStripButton3";
			this.tsSave.Click += new System.EventHandler ( this.tsSave_Click );
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size ( 6, 25 );
			// 
			// tsUndo
			// 
			this.tsUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsUndo.Image = global::UIDesigner.Properties.Resources.arrow_undo;
			this.tsUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsUndo.Name = "tsUndo";
			this.tsUndo.Size = new System.Drawing.Size ( 23, 22 );
			this.tsUndo.Text = "toolStripButton4";
			this.tsUndo.Click += new System.EventHandler ( this.tsUndo_Click );
			// 
			// tsRedo
			// 
			this.tsRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsRedo.Image = global::UIDesigner.Properties.Resources.arrow_redo;
			this.tsRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsRedo.Name = "tsRedo";
			this.tsRedo.Size = new System.Drawing.Size ( 23, 22 );
			this.tsRedo.Text = "toolStripButton5";
			this.tsRedo.Click += new System.EventHandler ( this.tsRedo_Click );
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size ( 6, 25 );
			// 
			// tsCut
			// 
			this.tsCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsCut.Image = global::UIDesigner.Properties.Resources.cut;
			this.tsCut.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsCut.Name = "tsCut";
			this.tsCut.Size = new System.Drawing.Size ( 23, 22 );
			this.tsCut.Text = "toolStripButton6";
			this.tsCut.Click += new System.EventHandler ( this.tsCut_Click );
			// 
			// tsCopy
			// 
			this.tsCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsCopy.Image = global::UIDesigner.Properties.Resources.page_copy;
			this.tsCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsCopy.Name = "tsCopy";
			this.tsCopy.Size = new System.Drawing.Size ( 23, 22 );
			this.tsCopy.Text = "toolStripButton7";
			this.tsCopy.Click += new System.EventHandler ( this.tsCopy_Click );
			// 
			// tsPaste
			// 
			this.tsPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsPaste.Image = global::UIDesigner.Properties.Resources.page_paste;
			this.tsPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsPaste.Name = "tsPaste";
			this.tsPaste.Size = new System.Drawing.Size ( 23, 22 );
			this.tsPaste.Text = "toolStripButton8";
			this.tsPaste.Click += new System.EventHandler ( this.tsPaste_Click );
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size ( 6, 25 );
			// 
			// tsAddObj
			// 
			this.tsAddObj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsAddObj.Image = global::UIDesigner.Properties.Resources.brick_add;
			this.tsAddObj.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsAddObj.Name = "tsAddObj";
			this.tsAddObj.Size = new System.Drawing.Size ( 23, 22 );
			this.tsAddObj.Text = "toolStripButton9";
			this.tsAddObj.Click += new System.EventHandler ( this.tsAddObj_Click );
			// 
			// tsRemoveObj
			// 
			this.tsRemoveObj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsRemoveObj.Image = global::UIDesigner.Properties.Resources.brick_delete;
			this.tsRemoveObj.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsRemoveObj.Name = "tsRemoveObj";
			this.tsRemoveObj.Size = new System.Drawing.Size ( 23, 22 );
			this.tsRemoveObj.Text = "toolStripButton10";
			this.tsRemoveObj.Click += new System.EventHandler ( this.tsRemoveObj_Click );
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size ( 6, 25 );
			// 
			// tsHelp
			// 
			this.tsHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsHelp.Image = global::UIDesigner.Properties.Resources.help;
			this.tsHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsHelp.Name = "tsHelp";
			this.tsHelp.Size = new System.Drawing.Size ( 23, 22 );
			this.tsHelp.Text = "toolStripButton13";
			this.tsHelp.Click += new System.EventHandler ( this.tsHelp_Click );
			// 
			// statusStrip1
			// 
			this.statusStrip1.Font = new System.Drawing.Font ( "Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 129 ) ) );
			this.statusStrip1.Items.AddRange ( new System.Windows.Forms.ToolStripItem [] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3} );
			this.statusStrip1.Location = new System.Drawing.Point ( 0, 536 );
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size ( 710, 22 );
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size ( 88, 17 );
			this.toolStripStatusLabel1.Text = "Team Alchemist";
			// 
			// toolStripStatusLabel2
			// 
			this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			this.toolStripStatusLabel2.Size = new System.Drawing.Size ( 67, 17 );
			this.toolStripStatusLabel2.Text = "UI Designer";
			// 
			// toolStripStatusLabel3
			// 
			this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
			this.toolStripStatusLabel3.Size = new System.Drawing.Size ( 34, 17 );
			this.toolStripStatusLabel3.Text = "v1.0.0";
			// 
			// sfDialog
			// 
			this.sfDialog.Filter = "UI Designer File(*.uid)|*.uid";
			// 
			// ofDialog
			// 
			this.ofDialog.Filter = "UI Designer File(*.uid)|*.uid";
			// 
			// verticalScroll
			// 
			this.verticalScroll.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
						| System.Windows.Forms.AnchorStyles.Right ) ) );
			this.verticalScroll.Enabled = false;
			this.verticalScroll.LargeChange = 1;
			this.verticalScroll.Location = new System.Drawing.Point ( 692, 50 );
			this.verticalScroll.Maximum = 0;
			this.verticalScroll.Name = "verticalScroll";
			this.verticalScroll.Size = new System.Drawing.Size ( 17, 467 );
			this.verticalScroll.TabIndex = 4;
			this.verticalScroll.Scroll += new System.Windows.Forms.ScrollEventHandler ( this.horizontalScroll_Scroll );
			// 
			// horizontalScroll
			// 
			this.horizontalScroll.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left )
						| System.Windows.Forms.AnchorStyles.Right ) ) );
			this.horizontalScroll.Enabled = false;
			this.horizontalScroll.LargeChange = 1;
			this.horizontalScroll.Location = new System.Drawing.Point ( 1, 518 );
			this.horizontalScroll.Maximum = 0;
			this.horizontalScroll.Name = "horizontalScroll";
			this.horizontalScroll.Size = new System.Drawing.Size ( 691, 17 );
			this.horizontalScroll.TabIndex = 5;
			this.horizontalScroll.Scroll += new System.Windows.Forms.ScrollEventHandler ( this.horizontalScroll_Scroll );
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
			this.pictureBox1.Location = new System.Drawing.Point ( 692, 518 );
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size ( 17, 17 );
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			// 
			// editBox
			// 
			this.editBox.BackColor = System.Drawing.Color.White;
			this.editBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.editBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.editBox.Location = new System.Drawing.Point ( 0, 49 );
			this.editBox.Name = "editBox";
			this.editBox.Size = new System.Drawing.Size ( 710, 487 );
			this.editBox.TabIndex = 3;
			this.editBox.TabStop = false;
			this.editBox.Paint += new System.Windows.Forms.PaintEventHandler ( this.editBox_Paint );
			this.editBox.DoubleClick += new System.EventHandler ( this.editBox_DoubleClick );
			this.editBox.MouseDown += new System.Windows.Forms.MouseEventHandler ( this.editBox_MouseDown );
			this.editBox.MouseMove += new System.Windows.Forms.MouseEventHandler ( this.editBox_MouseMove );
			this.editBox.MouseUp += new System.Windows.Forms.MouseEventHandler ( this.editBox_MouseUp );
			// 
			// Main
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size ( 710, 558 );
			this.Controls.Add ( this.pictureBox1 );
			this.Controls.Add ( this.horizontalScroll );
			this.Controls.Add ( this.verticalScroll );
			this.Controls.Add ( this.editBox );
			this.Controls.Add ( this.statusStrip1 );
			this.Controls.Add ( this.toolStrip1 );
			this.Controls.Add ( this.menuStrip1 );
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font ( "Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 129 ) ) );
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Main";
			this.Text = "Untitled.uid - Team Alchemist UI Designer";
			this.Load += new System.EventHandler ( this.Main_Load );
			this.Resize += new System.EventHandler ( this.Main_Resize );
			this.menuStrip1.ResumeLayout ( false );
			this.menuStrip1.PerformLayout ();
			this.toolStrip1.ResumeLayout ( false );
			this.toolStrip1.PerformLayout ();
			this.statusStrip1.ResumeLayout ( false );
			this.statusStrip1.PerformLayout ();
			( ( System.ComponentModel.ISupportInitialize ) ( this.pictureBox1 ) ).EndInit ();
			( ( System.ComponentModel.ISupportInitialize ) ( this.editBox ) ).EndInit ();
			this.ResumeLayout ( false );
			this.PerformLayout ();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem mnuFile;
		private System.Windows.Forms.ToolStripMenuItem mnuNew;
		private System.Windows.Forms.ToolStripMenuItem mnuOpen;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem mnuSave;
		private System.Windows.Forms.ToolStripMenuItem mnuSaveAs;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem mnuExportXML;
		private System.Windows.Forms.ToolStripMenuItem mnuExportPNG;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem mnuExit;
		private System.Windows.Forms.ToolStripMenuItem mnuEdit;
		private System.Windows.Forms.ToolStripMenuItem mnuUndo;
		private System.Windows.Forms.ToolStripMenuItem mnuRedo;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
		private System.Windows.Forms.ToolStripMenuItem mnuCut;
		private System.Windows.Forms.ToolStripMenuItem mnuCopy;
		private System.Windows.Forms.ToolStripMenuItem mnuPaste;
		private System.Windows.Forms.ToolStripMenuItem mnuDelete;
		private System.Windows.Forms.ToolStripMenuItem mnuObject;
		private System.Windows.Forms.ToolStripMenuItem mnuAdd;
		private System.Windows.Forms.ToolStripMenuItem mnuRemove;
		private System.Windows.Forms.ToolStripMenuItem mnuTools;
		private System.Windows.Forms.ToolStripMenuItem mnuOptions;
		private System.Windows.Forms.ToolStripMenuItem mnuHelp;
		private System.Windows.Forms.ToolStripMenuItem mnuAbout;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton tsNew;
		private System.Windows.Forms.ToolStripButton tsOpen;
		private System.Windows.Forms.ToolStripButton tsSave;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton tsUndo;
		private System.Windows.Forms.ToolStripButton tsRedo;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton tsCut;
		private System.Windows.Forms.ToolStripButton tsCopy;
		private System.Windows.Forms.ToolStripButton tsPaste;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripButton tsAddObj;
		private System.Windows.Forms.ToolStripButton tsRemoveObj;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripButton tsHelp;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		private System.Windows.Forms.ToolStripMenuItem mnuSetScreenSize;
		private System.Windows.Forms.PictureBox editBox;
		private System.Windows.Forms.SaveFileDialog sfDialog;
		private System.Windows.Forms.OpenFileDialog ofDialog;
		private System.Windows.Forms.VScrollBar verticalScroll;
		private System.Windows.Forms.HScrollBar horizontalScroll;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
	}
}

