namespace MoneyBook
{
    partial class fLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNM = new System.Windows.Forms.TextBox();
            this.tbPW = new System.Windows.Forms.TextBox();
            this.btOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "암호";
            // 
            // tbNM
            // 
            this.tbNM.Location = new System.Drawing.Point(52, 55);
            this.tbNM.Name = "tbNM";
            this.tbNM.Size = new System.Drawing.Size(174, 23);
            this.tbNM.TabIndex = 2;
            this.tbNM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbPW
            // 
            this.tbPW.Location = new System.Drawing.Point(52, 125);
            this.tbPW.Name = "tbPW";
            this.tbPW.PasswordChar = '*';
            this.tbPW.Size = new System.Drawing.Size(174, 23);
            this.tbPW.TabIndex = 3;
            this.tbPW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPW.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(52, 189);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(174, 23);
            this.btOK.TabIndex = 4;
            this.btOK.Text = "확인";
            this.btOK.UseVisualStyleBackColor = true;
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 255);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.tbPW);
            this.Controls.Add(this.tbNM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fLogin";
            this.Text = "로그인";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbNM;
        private TextBox tbPW;
        private Button btOK;
    }
}