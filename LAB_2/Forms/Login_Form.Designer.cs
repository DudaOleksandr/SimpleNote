namespace LAB_2
{
    partial class Notes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notes));
            this.login_2 = new System.Windows.Forms.Button();
            this.Loginfield = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Passfield = new System.Windows.Forms.TextBox();
            this.sign_in = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // login_2
            // 
            this.login_2.BackColor = System.Drawing.Color.PaleGreen;
            this.login_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.login_2.Location = new System.Drawing.Point(164, 291);
            this.login_2.Name = "login_2";
            this.login_2.Size = new System.Drawing.Size(227, 40);
            this.login_2.TabIndex = 0;
            this.login_2.Text = "Log in";
            this.login_2.UseVisualStyleBackColor = false;
            this.login_2.Click += new System.EventHandler(this.button1_Click);
            // 
            // Loginfield
            // 
            this.Loginfield.BackColor = System.Drawing.Color.LightCyan;
            this.Loginfield.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Loginfield.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.Loginfield.Location = new System.Drawing.Point(164, 162);
            this.Loginfield.Name = "Loginfield";
            this.Loginfield.Size = new System.Drawing.Size(228, 44);
            this.Loginfield.TabIndex = 2;
            this.Loginfield.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(161, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login";
            
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(160, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // Passfield
            // 
            this.Passfield.BackColor = System.Drawing.Color.LightCyan;
            this.Passfield.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Passfield.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.Passfield.Location = new System.Drawing.Point(165, 232);
            this.Passfield.Name = "Passfield";
            this.Passfield.Size = new System.Drawing.Size(228, 44);
            this.Passfield.TabIndex = 5;
            this.Passfield.UseSystemPasswordChar = true;
            this.Passfield.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // sign_in
            // 
            this.sign_in.BackColor = System.Drawing.Color.PaleGreen;
            this.sign_in.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sign_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.sign_in.Location = new System.Drawing.Point(166, 360);
            this.sign_in.Name = "sign_in";
            this.sign_in.Size = new System.Drawing.Size(227, 40);
            this.sign_in.TabIndex = 6;
            this.sign_in.Text = "Sign in";
            this.sign_in.UseVisualStyleBackColor = false;
            this.sign_in.Click += new System.EventHandler(this.sign_in_Click);
            // 
            // Notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(527, 493);
            this.Controls.Add(this.sign_in);
            this.Controls.Add(this.Passfield);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Loginfield);
            this.Controls.Add(this.login_2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Notes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notes";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_2;
        private System.Windows.Forms.TextBox Loginfield;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Passfield;
        private System.Windows.Forms.Button sign_in;
    }
}

