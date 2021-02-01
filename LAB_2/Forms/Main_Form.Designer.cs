namespace LAB_2
{
    partial class Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.login_2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sign_in = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // login_2
            // 
            this.login_2.BackColor = System.Drawing.Color.PaleGreen;
            this.login_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.login_2.Location = new System.Drawing.Point(141, 303);
            this.login_2.Name = "login_2";
            this.login_2.Size = new System.Drawing.Size(236, 40);
            this.login_2.TabIndex = 6;
            this.login_2.Text = "Log in";
            this.login_2.UseVisualStyleBackColor = false;
            this.login_2.Click += new System.EventHandler(this.login_2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F);
            this.label1.Location = new System.Drawing.Point(48, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 53);
            this.label1.TabIndex = 8;
            this.label1.Text = "Your Favourite Note!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(137, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "We are  glad to see u again";
            // 
            // sign_in
            // 
            this.sign_in.BackColor = System.Drawing.Color.PaleGreen;
            this.sign_in.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sign_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.sign_in.Location = new System.Drawing.Point(141, 398);
            this.sign_in.Name = "sign_in";
            this.sign_in.Size = new System.Drawing.Size(236, 40);
            this.sign_in.TabIndex = 10;
            this.sign_in.Text = "Sign in";
            this.sign_in.UseVisualStyleBackColor = false;
            this.sign_in.Click += new System.EventHandler(this.sign_in_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(527, 503);
            this.Controls.Add(this.sign_in);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login_2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sign_in;
    }
}