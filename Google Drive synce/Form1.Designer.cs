namespace Google_Drive_synce
{
    partial class Form1
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
            this.TB_savedataname = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.query = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TB_savedataname
            // 
            this.TB_savedataname.Location = new System.Drawing.Point(12, 6);
            this.TB_savedataname.Name = "TB_savedataname";
            this.TB_savedataname.Size = new System.Drawing.Size(100, 20);
            this.TB_savedataname.TabIndex = 0;
            this.TB_savedataname.Text = "save data prefix";
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(12, 32);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(88, 23);
            this.Login.TabIndex = 2;
            this.Login.Text = "login to google";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 116);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(260, 133);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // query
            // 
            this.query.Location = new System.Drawing.Point(12, 58);
            this.query.Name = "query";
            this.query.Size = new System.Drawing.Size(75, 23);
            this.query.TabIndex = 2;
            this.query.Text = "query";
            this.query.UseVisualStyleBackColor = true;
            this.query.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Log:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.query);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.TB_savedataname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_savedataname;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button query;
        private System.Windows.Forms.Label label1;
    }
}

