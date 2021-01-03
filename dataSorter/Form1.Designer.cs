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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.gbPath = new System.Windows.Forms.GroupBox();
            this.btBrowse = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btSort = new System.Windows.Forms.Button();
            this.gbLogic = new System.Windows.Forms.GroupBox();
            this.lvStatus = new System.Windows.Forms.ListView();
            this.statusHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btSetting = new System.Windows.Forms.Button();
            this.btAbout = new System.Windows.Forms.Button();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.logo = new System.Windows.Forms.PictureBox();
            this.gbPath.SuspendLayout();
            this.gbLogic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPath
            // 
            this.gbPath.Controls.Add(this.btBrowse);
            this.gbPath.Controls.Add(this.txtPath);
            this.gbPath.Controls.Add(this.btSort);
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
            this.btBrowse.Location = new System.Drawing.Point(298, 17);
            this.btBrowse.Name = "btBrowse";
            this.btBrowse.Size = new System.Drawing.Size(75, 23);
            this.btBrowse.TabIndex = 1;
            this.btBrowse.Text = "Browse";
            this.btBrowse.UseVisualStyleBackColor = true;
            this.btBrowse.Click += new System.EventHandler(this.btBrowse_Click);
            // 
            // txtPath
            // 
            this.txtPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.Location = new System.Drawing.Point(6, 18);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(286, 21);
            this.txtPath.TabIndex = 0;
            this.txtPath.Text = "C:\\";
            // 
            // btSort
            // 
            this.btSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSort.Location = new System.Drawing.Point(379, 17);
            this.btSort.Name = "btSort";
            this.btSort.Size = new System.Drawing.Size(75, 23);
            this.btSort.TabIndex = 2;
            this.btSort.Text = "Sort";
            this.btSort.UseVisualStyleBackColor = true;
            this.btSort.Click += new System.EventHandler(this.btSort_Click);
            // 
            // gbLogic
            // 
            this.gbLogic.Controls.Add(this.lvStatus);
            this.gbLogic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLogic.Location = new System.Drawing.Point(12, 175);
            this.gbLogic.Name = "gbLogic";
            this.gbLogic.Size = new System.Drawing.Size(460, 224);
            this.gbLogic.TabIndex = 4;
            this.gbLogic.TabStop = false;
            // 
            // lvStatus
            // 
            this.lvStatus.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.statusHeader});
            this.lvStatus.FullRowSelect = true;
            this.lvStatus.GridLines = true;
            this.lvStatus.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvStatus.HideSelection = false;
            this.lvStatus.Location = new System.Drawing.Point(6, 20);
            this.lvStatus.Name = "lvStatus";
            this.lvStatus.Size = new System.Drawing.Size(448, 198);
            this.lvStatus.TabIndex = 11;
            this.lvStatus.UseCompatibleStateImageBehavior = false;
            // 
            // statusHeader
            // 
            this.statusHeader.Text = "Status";
            this.statusHeader.Width = 443;
            // 
            // btSetting
            // 
            this.btSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSetting.Location = new System.Drawing.Point(391, 12);
            this.btSetting.Name = "btSetting";
            this.btSetting.Size = new System.Drawing.Size(75, 23);
            this.btSetting.TabIndex = 4;
            this.btSetting.Text = "Settings";
            this.btSetting.UseVisualStyleBackColor = true;
            this.btSetting.Click += new System.EventHandler(this.btSetting_Click);
            // 
            // btAbout
            // 
            this.btAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAbout.Location = new System.Drawing.Point(310, 12);
            this.btAbout.Name = "btAbout";
            this.btAbout.Size = new System.Drawing.Size(75, 23);
            this.btAbout.TabIndex = 3;
            this.btAbout.Text = "About";
            this.btAbout.UseVisualStyleBackColor = true;
            this.btAbout.Click += new System.EventHandler(this.btAbout_Click);
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
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 411);
            this.Controls.Add(this.btAbout);
            this.Controls.Add(this.btSetting);
            this.Controls.Add(this.gbLogic);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.gbPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 450);
            this.MinimumSize = new System.Drawing.Size(500, 450);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Sorter";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.gbPath.ResumeLayout(false);
            this.gbPath.PerformLayout();
            this.gbLogic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPath;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btBrowse;
        private System.Windows.Forms.Button btSort;
        private System.Windows.Forms.GroupBox gbLogic;
        private System.Windows.Forms.ListView lvStatus;
        private System.Windows.Forms.ColumnHeader statusHeader;
        private System.Windows.Forms.Button btSetting;
        private System.Windows.Forms.Button btAbout;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
    }
}

