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
            this.button2 = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.lvDocument = new System.Windows.Forms.ListView();
            this.tabMusic = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lvMusic = new System.Windows.Forms.ListView();
            this.tabPicture = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.lvPicture = new System.Windows.Forms.ListView();
            this.tabProgram = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.lvProgram = new System.Windows.Forms.ListView();
            this.tabVideo = new System.Windows.Forms.TabPage();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.lvVideo = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.tabDocument.Controls.Add(this.button2);
            this.tabDocument.Controls.Add(this.btAdd);
            this.tabDocument.Controls.Add(this.lvDocument);
            this.tabDocument.Location = new System.Drawing.Point(4, 22);
            this.tabDocument.Name = "tabDocument";
            this.tabDocument.Padding = new System.Windows.Forms.Padding(3);
            this.tabDocument.Size = new System.Drawing.Size(302, 261);
            this.tabDocument.TabIndex = 0;
            this.tabDocument.Text = "Documents";
            this.tabDocument.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(221, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(221, 6);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 1;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            // 
            // lvDocument
            // 
            this.lvDocument.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvDocument.FullRowSelect = true;
            this.lvDocument.GridLines = true;
            this.lvDocument.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvDocument.Location = new System.Drawing.Point(6, 6);
            this.lvDocument.Name = "lvDocument";
            this.lvDocument.Size = new System.Drawing.Size(209, 249);
            this.lvDocument.TabIndex = 0;
            this.lvDocument.UseCompatibleStateImageBehavior = false;
            // 
            // tabMusic
            // 
            this.tabMusic.Controls.Add(this.button1);
            this.tabMusic.Controls.Add(this.button3);
            this.tabMusic.Controls.Add(this.lvMusic);
            this.tabMusic.Location = new System.Drawing.Point(4, 22);
            this.tabMusic.Name = "tabMusic";
            this.tabMusic.Padding = new System.Windows.Forms.Padding(3);
            this.tabMusic.Size = new System.Drawing.Size(302, 261);
            this.tabMusic.TabIndex = 1;
            this.tabMusic.Text = "Musics";
            this.tabMusic.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(221, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(221, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // lvMusic
            // 
            this.lvMusic.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.lvMusic.FullRowSelect = true;
            this.lvMusic.GridLines = true;
            this.lvMusic.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvMusic.Location = new System.Drawing.Point(6, 6);
            this.lvMusic.Name = "lvMusic";
            this.lvMusic.Size = new System.Drawing.Size(209, 249);
            this.lvMusic.TabIndex = 1;
            this.lvMusic.UseCompatibleStateImageBehavior = false;
            // 
            // tabPicture
            // 
            this.tabPicture.Controls.Add(this.button4);
            this.tabPicture.Controls.Add(this.button5);
            this.tabPicture.Controls.Add(this.lvPicture);
            this.tabPicture.Location = new System.Drawing.Point(4, 22);
            this.tabPicture.Name = "tabPicture";
            this.tabPicture.Padding = new System.Windows.Forms.Padding(3);
            this.tabPicture.Size = new System.Drawing.Size(302, 261);
            this.tabPicture.TabIndex = 2;
            this.tabPicture.Text = "Pictures";
            this.tabPicture.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(221, 35);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(221, 6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "Add";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // lvPicture
            // 
            this.lvPicture.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
            this.lvPicture.FullRowSelect = true;
            this.lvPicture.GridLines = true;
            this.lvPicture.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvPicture.Location = new System.Drawing.Point(6, 6);
            this.lvPicture.Name = "lvPicture";
            this.lvPicture.Size = new System.Drawing.Size(209, 249);
            this.lvPicture.TabIndex = 2;
            this.lvPicture.UseCompatibleStateImageBehavior = false;
            // 
            // tabProgram
            // 
            this.tabProgram.Controls.Add(this.button6);
            this.tabProgram.Controls.Add(this.button7);
            this.tabProgram.Controls.Add(this.lvProgram);
            this.tabProgram.Location = new System.Drawing.Point(4, 22);
            this.tabProgram.Name = "tabProgram";
            this.tabProgram.Padding = new System.Windows.Forms.Padding(3);
            this.tabProgram.Size = new System.Drawing.Size(302, 261);
            this.tabProgram.TabIndex = 3;
            this.tabProgram.Text = "Programs";
            this.tabProgram.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(221, 35);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "Delete";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(221, 6);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 5;
            this.button7.Text = "Add";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // lvProgram
            // 
            this.lvProgram.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4});
            this.lvProgram.FullRowSelect = true;
            this.lvProgram.GridLines = true;
            this.lvProgram.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvProgram.Location = new System.Drawing.Point(6, 6);
            this.lvProgram.Name = "lvProgram";
            this.lvProgram.Size = new System.Drawing.Size(209, 249);
            this.lvProgram.TabIndex = 2;
            this.lvProgram.UseCompatibleStateImageBehavior = false;
            // 
            // tabVideo
            // 
            this.tabVideo.Controls.Add(this.button8);
            this.tabVideo.Controls.Add(this.button9);
            this.tabVideo.Controls.Add(this.lvVideo);
            this.tabVideo.Location = new System.Drawing.Point(4, 22);
            this.tabVideo.Name = "tabVideo";
            this.tabVideo.Padding = new System.Windows.Forms.Padding(3);
            this.tabVideo.Size = new System.Drawing.Size(302, 261);
            this.tabVideo.TabIndex = 4;
            this.tabVideo.Text = "Videos";
            this.tabVideo.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(221, 35);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 6;
            this.button8.Text = "Delete";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(221, 6);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 5;
            this.button9.Text = "Add";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // lvVideo
            // 
            this.lvVideo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5});
            this.lvVideo.FullRowSelect = true;
            this.lvVideo.GridLines = true;
            this.lvVideo.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvVideo.Location = new System.Drawing.Point(6, 6);
            this.lvVideo.Name = "lvVideo";
            this.lvVideo.Size = new System.Drawing.Size(209, 249);
            this.lvVideo.TabIndex = 2;
            this.lvVideo.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Extension";
            this.columnHeader1.Width = 205;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Extension";
            this.columnHeader2.Width = 205;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Extension";
            this.columnHeader3.Width = 205;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Extension";
            this.columnHeader4.Width = 205;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Extension";
            this.columnHeader5.Width = 205;
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
            this.tabMusic.ResumeLayout(false);
            this.tabPicture.ResumeLayout(false);
            this.tabProgram.ResumeLayout(false);
            this.tabVideo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDocument;
        private System.Windows.Forms.TabPage tabMusic;
        private System.Windows.Forms.TabPage tabPicture;
        private System.Windows.Forms.TabPage tabProgram;
        private System.Windows.Forms.TabPage tabVideo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.ListView lvDocument;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView lvMusic;
        private System.Windows.Forms.ListView lvPicture;
        private System.Windows.Forms.ListView lvProgram;
        private System.Windows.Forms.ListView lvVideo;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;

    }
}