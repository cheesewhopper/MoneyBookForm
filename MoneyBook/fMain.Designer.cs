namespace MoneyBook
{
    partial class fMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btIN = new System.Windows.Forms.ToolStripButton();
            this.btOut = new System.Windows.Forms.ToolStripButton();
            this.btLogin = new System.Windows.Forms.ToolStripButton();
            this.BtEdit = new System.Windows.Forms.ToolStripButton();
            this.BtDelete = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sbUserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.lv1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btIN,
            this.btOut,
            this.btLogin,
            this.BtEdit,
            this.BtDelete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(622, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btIN
            // 
            this.btIN.Image = ((System.Drawing.Image)(resources.GetObject("btIN.Image")));
            this.btIN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btIN.Name = "btIN";
            this.btIN.Size = new System.Drawing.Size(51, 22);
            this.btIN.Text = "입금";
            this.btIN.Click += new System.EventHandler(this.btIN_Click);
            // 
            // btOut
            // 
            this.btOut.Image = ((System.Drawing.Image)(resources.GetObject("btOut.Image")));
            this.btOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btOut.Name = "btOut";
            this.btOut.Size = new System.Drawing.Size(51, 22);
            this.btOut.Text = "출금";
            this.btOut.Click += new System.EventHandler(this.btOut_Click);
            // 
            // btLogin
            // 
            this.btLogin.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btLogin.Image = ((System.Drawing.Image)(resources.GetObject("btLogin.Image")));
            this.btLogin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(63, 22);
            this.btLogin.Text = "로그인";
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // BtEdit
            // 
            this.BtEdit.Image = ((System.Drawing.Image)(resources.GetObject("BtEdit.Image")));
            this.BtEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtEdit.Name = "BtEdit";
            this.BtEdit.Size = new System.Drawing.Size(51, 22);
            this.BtEdit.Text = "편집";
            this.BtEdit.Click += new System.EventHandler(this.BtEdit_Click);
            // 
            // BtDelete
            // 
            this.BtDelete.Image = ((System.Drawing.Image)(resources.GetObject("BtDelete.Image")));
            this.BtDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtDelete.Name = "BtDelete";
            this.BtDelete.Size = new System.Drawing.Size(51, 22);
            this.BtDelete.Text = "삭제";
            this.BtDelete.Click += new System.EventHandler(this.BtDelete_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.sbUserName});
            this.statusStrip1.Location = new System.Drawing.Point(0, 440);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(622, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(43, 17);
            this.toolStripStatusLabel1.Text = "사용자";
            // 
            // sbUserName
            // 
            this.sbUserName.Name = "sbUserName";
            this.sbUserName.Size = new System.Drawing.Size(16, 17);
            this.sbUserName.Text = "...";
            // 
            // lv1
            // 
            this.lv1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv1.FullRowSelect = true;
            this.lv1.GridLines = true;
            this.lv1.Location = new System.Drawing.Point(0, 25);
            this.lv1.MultiSelect = false;
            this.lv1.Name = "lv1";
            this.lv1.Size = new System.Drawing.Size(622, 415);
            this.lv1.TabIndex = 2;
            this.lv1.UseCompatibleStateImageBehavior = false;
            this.lv1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "날짜";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "분류";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "입금";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "출금";
            this.columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "비고";
            this.columnHeader5.Width = 90;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 462);
            this.Controls.Add(this.lv1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "가계부";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btIN;
        private ToolStripButton btOut;
        private ToolStripButton btLogin;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel sbUserName;
        private ListView lv1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ToolStripButton BtEdit;
        private ToolStripButton BtDelete;
    }
}