namespace dataSorter
{
    partial class SettingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDocument = new System.Windows.Forms.TabPage();
            this.btDelDoc = new System.Windows.Forms.Button();
            this.btAddDoc = new System.Windows.Forms.Button();
            this.lvDocument = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabMusic = new System.Windows.Forms.TabPage();
            this.btDelMusic = new System.Windows.Forms.Button();
            this.btAddMusic = new System.Windows.Forms.Button();
            this.lvMusic = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPicture = new System.Windows.Forms.TabPage();
            this.btDelPic = new System.Windows.Forms.Button();
            this.btAddPic = new System.Windows.Forms.Button();
            this.lvPicture = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabProgram = new System.Windows.Forms.TabPage();
            this.btDelApp = new System.Windows.Forms.Button();
            this.btAddApp = new System.Windows.Forms.Button();
            this.lvProgram = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabVideo = new System.Windows.Forms.TabPage();
            this.btDelVid = new System.Windows.Forms.Button();
            this.btAddVid = new System.Windows.Forms.Button();
            this.lvVideo = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtAddDoc = new System.Windows.Forms.TextBox();
            this.txtAddMusic = new System.Windows.Forms.TextBox();
            this.txtAddPic = new System.Windows.Forms.TextBox();
            this.txtAddApp = new System.Windows.Forms.TextBox();
            this.txtAddVid = new System.Windows.Forms.TextBox();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabDocument.SuspendLayout();
            this.tabMusic.SuspendLayout();
            this.tabPicture.SuspendLayout();
            this.tabProgram.SuspendLayout();
            this.tabVideo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDocument);
            this.tabControl1.Controls.Add(this.tabMusic);
            this.tabControl1.Controls.Add(this.tabPicture);
            this.tabControl1.Controls.Add(this.tabProgram);
            this.tabControl1.Controls.Add(this.tabVideo);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(310, 287);
            this.tabControl1.TabIndex = 0;
            // 
            // tabDocument
            // 
            this.tabDocument.Controls.Add(this.txtAddDoc);
            this.tabDocument.Controls.Add(this.btDelDoc);
            this.tabDocument.Controls.Add(this.btAddDoc);
            this.tabDocument.Controls.Add(this.lvDocument);
            this.tabDocument.Location = new System.Drawing.Point(4, 22);
            this.tabDocument.Name = "tabDocument";
            this.tabDocument.Padding = new System.Windows.Forms.Padding(3);
            this.tabDocument.Size = new System.Drawing.Size(302, 261);
            this.tabDocument.TabIndex = 0;
            this.tabDocument.Text = "Documents";
            this.tabDocument.UseVisualStyleBackColor = true;
            // 
            // btDelDoc
            // 
            this.btDelDoc.Location = new System.Drawing.Point(221, 35);
            this.btDelDoc.Name = "btDelDoc";
            this.btDelDoc.Size = new System.Drawing.Size(75, 23);
            this.btDelDoc.TabIndex = 2;
            this.btDelDoc.Text = "Delete";
            this.btDelDoc.UseVisualStyleBackColor = true;
            this.btDelDoc.Click += new System.EventHandler(this.btDelDoc_Click);
            // 
            // btAddDoc
            // 
            this.btAddDoc.Location = new System.Drawing.Point(221, 6);
            this.btAddDoc.Name = "btAddDoc";
            this.btAddDoc.Size = new System.Drawing.Size(75, 23);
            this.btAddDoc.TabIndex = 1;
            this.btAddDoc.Text = "Add";
            this.btAddDoc.UseVisualStyleBackColor = true;
            this.btAddDoc.Click += new System.EventHandler(this.btAddDoc_Click);
            // 
            // lvDocument
            // 
            this.lvDocument.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader1});
            this.lvDocument.FullRowSelect = true;
            this.lvDocument.GridLines = true;
            this.lvDocument.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvDocument.Location = new System.Drawing.Point(6, 35);
            this.lvDocument.Name = "lvDocument";
            this.lvDocument.Size = new System.Drawing.Size(209, 220);
            this.lvDocument.TabIndex = 0;
            this.lvDocument.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Extension";
            this.columnHeader1.Width = 205;
            // 
            // tabMusic
            // 
            this.tabMusic.Controls.Add(this.txtAddMusic);
            this.tabMusic.Controls.Add(this.btDelMusic);
            this.tabMusic.Controls.Add(this.btAddMusic);
            this.tabMusic.Controls.Add(this.lvMusic);
            this.tabMusic.Location = new System.Drawing.Point(4, 22);
            this.tabMusic.Name = "tabMusic";
            this.tabMusic.Padding = new System.Windows.Forms.Padding(3);
            this.tabMusic.Size = new System.Drawing.Size(302, 261);
            this.tabMusic.TabIndex = 1;
            this.tabMusic.Text = "Musics";
            this.tabMusic.UseVisualStyleBackColor = true;
            // 
            // btDelMusic
            // 
            this.btDelMusic.Location = new System.Drawing.Point(221, 35);
            this.btDelMusic.Name = "btDelMusic";
            this.btDelMusic.Size = new System.Drawing.Size(75, 23);
            this.btDelMusic.TabIndex = 4;
            this.btDelMusic.Text = "Delete";
            this.btDelMusic.UseVisualStyleBackColor = true;
            this.btDelMusic.Click += new System.EventHandler(this.btDelMusic_Click);
            // 
            // btAddMusic
            // 
            this.btAddMusic.Location = new System.Drawing.Point(221, 6);
            this.btAddMusic.Name = "btAddMusic";
            this.btAddMusic.Size = new System.Drawing.Size(75, 23);
            this.btAddMusic.TabIndex = 3;
            this.btAddMusic.Text = "Add";
            this.btAddMusic.UseVisualStyleBackColor = true;
            this.btAddMusic.Click += new System.EventHandler(this.btAddMusic_Click);
            // 
            // lvMusic
            // 
            this.lvMusic.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader2});
            this.lvMusic.FullRowSelect = true;
            this.lvMusic.GridLines = true;
            this.lvMusic.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvMusic.Location = new System.Drawing.Point(6, 35);
            this.lvMusic.Name = "lvMusic";
            this.lvMusic.Size = new System.Drawing.Size(209, 220);
            this.lvMusic.TabIndex = 1;
            this.lvMusic.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Extension";
            this.columnHeader2.Width = 205;
            // 
            // tabPicture
            // 
            this.tabPicture.Controls.Add(this.txtAddPic);
            this.tabPicture.Controls.Add(this.btDelPic);
            this.tabPicture.Controls.Add(this.btAddPic);
            this.tabPicture.Controls.Add(this.lvPicture);
            this.tabPicture.Location = new System.Drawing.Point(4, 22);
            this.tabPicture.Name = "tabPicture";
            this.tabPicture.Padding = new System.Windows.Forms.Padding(3);
            this.tabPicture.Size = new System.Drawing.Size(302, 261);
            this.tabPicture.TabIndex = 2;
            this.tabPicture.Text = "Pictures";
            this.tabPicture.UseVisualStyleBackColor = true;
            // 
            // btDelPic
            // 
            this.btDelPic.Location = new System.Drawing.Point(221, 35);
            this.btDelPic.Name = "btDelPic";
            this.btDelPic.Size = new System.Drawing.Size(75, 23);
            this.btDelPic.TabIndex = 6;
            this.btDelPic.Text = "Delete";
            this.btDelPic.UseVisualStyleBackColor = true;
            this.btDelPic.Click += new System.EventHandler(this.btDelPic_Click);
            // 
            // btAddPic
            // 
            this.btAddPic.Location = new System.Drawing.Point(221, 6);
            this.btAddPic.Name = "btAddPic";
            this.btAddPic.Size = new System.Drawing.Size(75, 23);
            this.btAddPic.TabIndex = 5;
            this.btAddPic.Text = "Add";
            this.btAddPic.UseVisualStyleBackColor = true;
            this.btAddPic.Click += new System.EventHandler(this.btAddPic_Click);
            // 
            // lvPicture
            // 
            this.lvPicture.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader3});
            this.lvPicture.FullRowSelect = true;
            this.lvPicture.GridLines = true;
            this.lvPicture.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvPicture.Location = new System.Drawing.Point(6, 35);
            this.lvPicture.Name = "lvPicture";
            this.lvPicture.Size = new System.Drawing.Size(209, 220);
            this.lvPicture.TabIndex = 2;
            this.lvPicture.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Extension";
            this.columnHeader3.Width = 205;
            // 
            // tabProgram
            // 
            this.tabProgram.Controls.Add(this.txtAddApp);
            this.tabProgram.Controls.Add(this.btDelApp);
            this.tabProgram.Controls.Add(this.btAddApp);
            this.tabProgram.Controls.Add(this.lvProgram);
            this.tabProgram.Location = new System.Drawing.Point(4, 22);
            this.tabProgram.Name = "tabProgram";
            this.tabProgram.Padding = new System.Windows.Forms.Padding(3);
            this.tabProgram.Size = new System.Drawing.Size(302, 261);
            this.tabProgram.TabIndex = 3;
            this.tabProgram.Text = "Programs";
            this.tabProgram.UseVisualStyleBackColor = true;
            // 
            // btDelApp
            // 
            this.btDelApp.Location = new System.Drawing.Point(221, 35);
            this.btDelApp.Name = "btDelApp";
            this.btDelApp.Size = new System.Drawing.Size(75, 23);
            this.btDelApp.TabIndex = 6;
            this.btDelApp.Text = "Delete";
            this.btDelApp.UseVisualStyleBackColor = true;
            this.btDelApp.Click += new System.EventHandler(this.btDelApp_Click);
            // 
            // btAddApp
            // 
            this.btAddApp.Location = new System.Drawing.Point(221, 6);
            this.btAddApp.Name = "btAddApp";
            this.btAddApp.Size = new System.Drawing.Size(75, 23);
            this.btAddApp.TabIndex = 5;
            this.btAddApp.Text = "Add";
            this.btAddApp.UseVisualStyleBackColor = true;
            this.btAddApp.Click += new System.EventHandler(this.btAddApp_Click);
            // 
            // lvProgram
            // 
            this.lvProgram.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader4});
            this.lvProgram.FullRowSelect = true;
            this.lvProgram.GridLines = true;
            this.lvProgram.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvProgram.Location = new System.Drawing.Point(6, 35);
            this.lvProgram.Name = "lvProgram";
            this.lvProgram.Size = new System.Drawing.Size(209, 220);
            this.lvProgram.TabIndex = 2;
            this.lvProgram.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Extension";
            this.columnHeader4.Width = 205;
            // 
            // tabVideo
            // 
            this.tabVideo.Controls.Add(this.txtAddVid);
            this.tabVideo.Controls.Add(this.btDelVid);
            this.tabVideo.Controls.Add(this.btAddVid);
            this.tabVideo.Controls.Add(this.lvVideo);
            this.tabVideo.Location = new System.Drawing.Point(4, 22);
            this.tabVideo.Name = "tabVideo";
            this.tabVideo.Padding = new System.Windows.Forms.Padding(3);
            this.tabVideo.Size = new System.Drawing.Size(302, 261);
            this.tabVideo.TabIndex = 4;
            this.tabVideo.Text = "Videos";
            this.tabVideo.UseVisualStyleBackColor = true;
            // 
            // btDelVid
            // 
            this.btDelVid.Location = new System.Drawing.Point(221, 35);
            this.btDelVid.Name = "btDelVid";
            this.btDelVid.Size = new System.Drawing.Size(75, 23);
            this.btDelVid.TabIndex = 6;
            this.btDelVid.Text = "Delete";
            this.btDelVid.UseVisualStyleBackColor = true;
            this.btDelVid.Click += new System.EventHandler(this.btDelVid_Click);
            // 
            // btAddVid
            // 
            this.btAddVid.Location = new System.Drawing.Point(221, 6);
            this.btAddVid.Name = "btAddVid";
            this.btAddVid.Size = new System.Drawing.Size(75, 23);
            this.btAddVid.TabIndex = 5;
            this.btAddVid.Text = "Add";
            this.btAddVid.UseVisualStyleBackColor = true;
            this.btAddVid.Click += new System.EventHandler(this.btAddVid_Click);
            // 
            // lvVideo
            // 
            this.lvVideo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader5});
            this.lvVideo.FullRowSelect = true;
            this.lvVideo.GridLines = true;
            this.lvVideo.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvVideo.Location = new System.Drawing.Point(6, 35);
            this.lvVideo.Name = "lvVideo";
            this.lvVideo.Size = new System.Drawing.Size(209, 220);
            this.lvVideo.TabIndex = 2;
            this.lvVideo.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Extension";
            this.columnHeader5.Width = 205;
            // 
            // txtAddDoc
            // 
            this.txtAddDoc.Location = new System.Drawing.Point(6, 8);
            this.txtAddDoc.Name = "txtAddDoc";
            this.txtAddDoc.Size = new System.Drawing.Size(209, 20);
            this.txtAddDoc.TabIndex = 3;
            // 
            // txtAddMusic
            // 
            this.txtAddMusic.Location = new System.Drawing.Point(6, 8);
            this.txtAddMusic.Name = "txtAddMusic";
            this.txtAddMusic.Size = new System.Drawing.Size(209, 20);
            this.txtAddMusic.TabIndex = 5;
            // 
            // txtAddPic
            // 
            this.txtAddPic.Location = new System.Drawing.Point(6, 8);
            this.txtAddPic.Name = "txtAddPic";
            this.txtAddPic.Size = new System.Drawing.Size(209, 20);
            this.txtAddPic.TabIndex = 7;
            // 
            // txtAddApp
            // 
            this.txtAddApp.Location = new System.Drawing.Point(6, 8);
            this.txtAddApp.Name = "txtAddApp";
            this.txtAddApp.Size = new System.Drawing.Size(209, 20);
            this.txtAddApp.TabIndex = 7;
            // 
            // txtAddVid
            // 
            this.txtAddVid.Location = new System.Drawing.Point(6, 8);
            this.txtAddVid.Name = "txtAddVid";
            this.txtAddVid.Size = new System.Drawing.Size(209, 20);
            this.txtAddVid.TabIndex = 7;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ID";
            this.columnHeader6.Width = 0;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "ID";
            this.columnHeader7.Width = 0;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "ID";
            this.columnHeader8.Width = 0;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "ID";
            this.columnHeader9.Width = 0;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "ID";
            this.columnHeader10.Width = 0;
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabDocument.ResumeLayout(false);
            this.tabDocument.PerformLayout();
            this.tabMusic.ResumeLayout(false);
            this.tabMusic.PerformLayout();
            this.tabPicture.ResumeLayout(false);
            this.tabPicture.PerformLayout();
            this.tabProgram.ResumeLayout(false);
            this.tabProgram.PerformLayout();
            this.tabVideo.ResumeLayout(false);
            this.tabVideo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDocument;
        private System.Windows.Forms.TabPage tabMusic;
        private System.Windows.Forms.TabPage tabPicture;
        private System.Windows.Forms.TabPage tabProgram;
        private System.Windows.Forms.TabPage tabVideo;
        private System.Windows.Forms.Button btDelDoc;
        private System.Windows.Forms.Button btAddDoc;
        private System.Windows.Forms.ListView lvDocument;
        private System.Windows.Forms.Button btDelMusic;
        private System.Windows.Forms.Button btAddMusic;
        private System.Windows.Forms.ListView lvMusic;
        private System.Windows.Forms.ListView lvPicture;
        private System.Windows.Forms.ListView lvProgram;
        private System.Windows.Forms.ListView lvVideo;
        private System.Windows.Forms.Button btDelPic;
        private System.Windows.Forms.Button btAddPic;
        private System.Windows.Forms.Button btDelApp;
        private System.Windows.Forms.Button btAddApp;
        private System.Windows.Forms.Button btDelVid;
        private System.Windows.Forms.Button btAddVid;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TextBox txtAddDoc;
        private System.Windows.Forms.TextBox txtAddMusic;
        private System.Windows.Forms.TextBox txtAddPic;
        private System.Windows.Forms.TextBox txtAddApp;
        private System.Windows.Forms.TextBox txtAddVid;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;

    }
}