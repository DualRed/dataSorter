namespace dataSorter
{
    partial class DocForm
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
            this.lvDoc = new System.Windows.Forms.ListView();
            this.Extension = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btAdd = new System.Windows.Forms.Button();
            this.btDel = new System.Windows.Forms.Button();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lvDoc
            // 
            this.lvDoc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Extension});
            this.lvDoc.FullRowSelect = true;
            this.lvDoc.GridLines = true;
            this.lvDoc.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvDoc.Location = new System.Drawing.Point(12, 33);
            this.lvDoc.Name = "lvDoc";
            this.lvDoc.Size = new System.Drawing.Size(179, 236);
            this.lvDoc.TabIndex = 0;
            this.lvDoc.UseCompatibleStateImageBehavior = false;
            // 
            // Extension
            // 
            this.Extension.Text = "Extension";
            this.Extension.Width = 175;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(197, 5);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 1;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            // 
            // btDel
            // 
            this.btDel.Location = new System.Drawing.Point(197, 33);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(75, 23);
            this.btDel.TabIndex = 2;
            this.btDel.Text = "Delete";
            this.btDel.UseVisualStyleBackColor = true;
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(12, 7);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(179, 20);
            this.txtAdd.TabIndex = 3;
            // 
            // DocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 281);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.lvDoc);
            this.Name = "DocForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Document...";
            this.Load += new System.EventHandler(this.DocForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvDoc;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.ColumnHeader Extension;
        private System.Windows.Forms.TextBox txtAdd;
    }
}