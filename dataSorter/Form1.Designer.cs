namespace dataSorter
{
    partial class mainForm
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
            this.gbPath = new System.Windows.Forms.GroupBox();
            this.btBrowse = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.btSort = new System.Windows.Forms.Button();
            this.gbLogic = new System.Windows.Forms.GroupBox();
            this.btVideo = new System.Windows.Forms.Button();
            this.lbVideo = new System.Windows.Forms.Label();
            this.btPicture = new System.Windows.Forms.Button();
            this.lbPicture = new System.Windows.Forms.Label();
            this.btMusic = new System.Windows.Forms.Button();
            this.lbMusic = new System.Windows.Forms.Label();
            this.btDocument = new System.Windows.Forms.Button();
            this.lbDocument = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.gbPath.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.gbLogic.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPath
            // 
            this.gbPath.Controls.Add(this.btBrowse);
            this.gbPath.Controls.Add(this.txtPath);
            this.gbPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPath.Location = new System.Drawing.Point(12, 114);
            this.gbPath.Name = "gbPath";
            this.gbPath.Size = new System.Drawing.Size(460, 55);
            this.gbPath.TabIndex = 0;
            this.gbPath.TabStop = false;
            this.gbPath.Text = "Path";
            // 
            // btBrowse
            // 
            this.btBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBrowse.Location = new System.Drawing.Point(379, 17);
            this.btBrowse.Name = "btBrowse";
            this.btBrowse.Size = new System.Drawing.Size(75, 23);
            this.btBrowse.TabIndex = 2;
            this.btBrowse.Text = "Browse";
            this.btBrowse.UseVisualStyleBackColor = true;
            this.btBrowse.Click += new System.EventHandler(this.btBrowse_Click);
            // 
            // txtPath
            // 
            this.txtPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.Location = new System.Drawing.Point(6, 18);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(367, 21);
            this.txtPath.TabIndex = 0;
            this.txtPath.Text = "F:\\dataSorter-test";
            // 
            // logo
            // 
            this.logo.Image = global::dataSorter.Properties.Resources.logo;
            this.logo.Location = new System.Drawing.Point(12, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(209, 96);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            // 
            // btSort
            // 
            this.btSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSort.Location = new System.Drawing.Point(391, 85);
            this.btSort.Name = "btSort";
            this.btSort.Size = new System.Drawing.Size(75, 23);
            this.btSort.TabIndex = 3;
            this.btSort.Text = "Sort";
            this.btSort.UseVisualStyleBackColor = true;
            this.btSort.Click += new System.EventHandler(this.btSort_Click);
            // 
            // gbLogic
            // 
            this.gbLogic.Controls.Add(this.listView1);
            this.gbLogic.Controls.Add(this.btVideo);
            this.gbLogic.Controls.Add(this.lbVideo);
            this.gbLogic.Controls.Add(this.btPicture);
            this.gbLogic.Controls.Add(this.lbPicture);
            this.gbLogic.Controls.Add(this.btMusic);
            this.gbLogic.Controls.Add(this.lbMusic);
            this.gbLogic.Controls.Add(this.btDocument);
            this.gbLogic.Controls.Add(this.lbDocument);
            this.gbLogic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLogic.Location = new System.Drawing.Point(12, 175);
            this.gbLogic.Name = "gbLogic";
            this.gbLogic.Size = new System.Drawing.Size(460, 224);
            this.gbLogic.TabIndex = 4;
            this.gbLogic.TabStop = false;
            this.gbLogic.Text = "Custom Sorter";
            // 
            // btVideo
            // 
            this.btVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVideo.Location = new System.Drawing.Point(339, 77);
            this.btVideo.Name = "btVideo";
            this.btVideo.Size = new System.Drawing.Size(75, 23);
            this.btVideo.TabIndex = 10;
            this.btVideo.Text = "Edit";
            this.btVideo.UseVisualStyleBackColor = true;
            this.btVideo.Click += new System.EventHandler(this.btVideo_Click);
            // 
            // lbVideo
            // 
            this.lbVideo.AutoSize = true;
            this.lbVideo.Location = new System.Drawing.Point(260, 81);
            this.lbVideo.Name = "lbVideo";
            this.lbVideo.Size = new System.Drawing.Size(47, 15);
            this.lbVideo.TabIndex = 9;
            this.lbVideo.Text = "Videos:";
            // 
            // btPicture
            // 
            this.btPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPicture.Location = new System.Drawing.Point(339, 38);
            this.btPicture.Name = "btPicture";
            this.btPicture.Size = new System.Drawing.Size(75, 23);
            this.btPicture.TabIndex = 8;
            this.btPicture.Text = "Edit";
            this.btPicture.UseVisualStyleBackColor = true;
            this.btPicture.Click += new System.EventHandler(this.btPicture_Click);
            // 
            // lbPicture
            // 
            this.lbPicture.AutoSize = true;
            this.lbPicture.Location = new System.Drawing.Point(260, 42);
            this.lbPicture.Name = "lbPicture";
            this.lbPicture.Size = new System.Drawing.Size(54, 15);
            this.lbPicture.TabIndex = 7;
            this.lbPicture.Text = "Pictures:";
            // 
            // btMusic
            // 
            this.btMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMusic.Location = new System.Drawing.Point(109, 77);
            this.btMusic.Name = "btMusic";
            this.btMusic.Size = new System.Drawing.Size(75, 23);
            this.btMusic.TabIndex = 6;
            this.btMusic.Text = "Edit";
            this.btMusic.UseVisualStyleBackColor = true;
            this.btMusic.Click += new System.EventHandler(this.btMusic_Click);
            // 
            // lbMusic
            // 
            this.lbMusic.AutoSize = true;
            this.lbMusic.Location = new System.Drawing.Point(30, 81);
            this.lbMusic.Name = "lbMusic";
            this.lbMusic.Size = new System.Drawing.Size(43, 15);
            this.lbMusic.TabIndex = 5;
            this.lbMusic.Text = "Music:";
            // 
            // btDocument
            // 
            this.btDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDocument.Location = new System.Drawing.Point(109, 38);
            this.btDocument.Name = "btDocument";
            this.btDocument.Size = new System.Drawing.Size(75, 23);
            this.btDocument.TabIndex = 4;
            this.btDocument.Text = "Edit";
            this.btDocument.UseVisualStyleBackColor = true;
            this.btDocument.Click += new System.EventHandler(this.btDocument_Click);
            // 
            // lbDocument
            // 
            this.lbDocument.AutoSize = true;
            this.lbDocument.Location = new System.Drawing.Point(30, 42);
            this.lbDocument.Name = "lbDocument";
            this.lbDocument.Size = new System.Drawing.Size(73, 15);
            this.lbDocument.TabIndex = 0;
            this.lbDocument.Text = "Documents:";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(33, 121);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(381, 97);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 411);
            this.Controls.Add(this.gbLogic);
            this.Controls.Add(this.btSort);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.gbPath);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 450);
            this.MinimumSize = new System.Drawing.Size(500, 450);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Sorter";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.gbPath.ResumeLayout(false);
            this.gbPath.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.gbLogic.ResumeLayout(false);
            this.gbLogic.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPath;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btBrowse;
        private System.Windows.Forms.Button btSort;
        private System.Windows.Forms.GroupBox gbLogic;
        private System.Windows.Forms.Label lbDocument;
        private System.Windows.Forms.Button btVideo;
        private System.Windows.Forms.Label lbVideo;
        private System.Windows.Forms.Button btPicture;
        private System.Windows.Forms.Label lbPicture;
        private System.Windows.Forms.Button btMusic;
        private System.Windows.Forms.Label lbMusic;
        private System.Windows.Forms.Button btDocument;
        private System.Windows.Forms.ListView listView1;
    }
}

