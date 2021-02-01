namespace LAB_2
{
    partial class Registration_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration_Form));
            this.Passfield = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Loginfield = new System.Windows.Forms.TextBox();
            this.register = new System.Windows.Forms.Button();
            this.Passfield2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.log_in = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Passfield
            // 
            this.Passfield.BackColor = System.Drawing.Color.LightCyan;
            this.Passfield.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Passfield.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.Passfield.Location = new System.Drawing.Point(287, 142);
            this.Passfield.Name = "Passfield";
            this.Passfield.Size = new System.Drawing.Size(228, 44);
            this.Passfield.TabIndex = 10;
            this.Passfield.UseSystemPasswordChar = true;
            
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(283, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Enter Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(12, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Create Login";
           
            // 
            // Loginfield
            // 
            this.Loginfield.BackColor = System.Drawing.Color.LightCyan;
            this.Loginfield.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Loginfield.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.Loginfield.Location = new System.Drawing.Point(16, 188);
            this.Loginfield.Name = "Loginfield";
            this.Loginfield.Size = new System.Drawing.Size(228, 44);
            this.Loginfield.TabIndex = 7;
           
            // 
            // register
            // 
            this.register.BackColor = System.Drawing.Color.PaleGreen;
            this.register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.register.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.register.Location = new System.Drawing.Point(143, 318);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(227, 40);
            this.register.TabIndex = 6;
            this.register.Text = "Register";
            this.register.UseVisualStyleBackColor = false;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // Passfield2
            // 
            this.Passfield2.BackColor = System.Drawing.Color.LightCyan;
            this.Passfield2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Passfield2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.Passfield2.Location = new System.Drawing.Point(287, 235);
            this.Passfield2.Name = "Passfield2";
            this.Passfield2.Size = new System.Drawing.Size(228, 44);
            this.Passfield2.TabIndex = 12;
            this.Passfield2.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(283, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Confirm your Password";
            // 
            // log_in
            // 
            this.log_in.BackColor = System.Drawing.Color.PaleGreen;
            this.log_in.Cursor = System.Windows.Forms.Cursors.Hand;
            this.log_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.log_in.Location = new System.Drawing.Point(143, 386);
            this.log_in.Name = "log_in";
            this.log_in.Size = new System.Drawing.Size(227, 40);
            this.log_in.TabIndex = 13;
            this.log_in.Text = "Log in";
            this.log_in.UseVisualStyleBackColor = false;
            this.log_in.Click += new System.EventHandler(this.log_in_Click);
            // 
            // Registration_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(527, 493);
            this.Controls.Add(this.log_in);
            this.Controls.Add(this.Passfield2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Passfield);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Loginfield);
            this.Controls.Add(this.register);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registration_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Passfield;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Loginfield;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.TextBox Passfield2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button log_in;
    }
}