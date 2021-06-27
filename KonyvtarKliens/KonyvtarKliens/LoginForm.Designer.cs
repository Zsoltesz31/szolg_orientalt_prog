
namespace KonyvtarKliens
{
    partial class LoginForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lgn_button = new System.Windows.Forms.Button();
            this.lgn_passwordTextbox = new System.Windows.Forms.TextBox();
            this.lgn_usernameTxtbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lgn_button);
            this.groupBox2.Controls.Add(this.lgn_passwordTextbox);
            this.groupBox2.Controls.Add(this.lgn_usernameTxtbox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(40, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(254, 327);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bejelentkezés";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(50, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nincs fiókja? Regisztráljon!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // lgn_button
            // 
            this.lgn_button.Location = new System.Drawing.Point(82, 180);
            this.lgn_button.Name = "lgn_button";
            this.lgn_button.Size = new System.Drawing.Size(93, 23);
            this.lgn_button.TabIndex = 9;
            this.lgn_button.Text = "Bejelentkezés";
            this.lgn_button.UseVisualStyleBackColor = true;
            this.lgn_button.Click += new System.EventHandler(this.lgn_button_Click);
            // 
            // lgn_passwordTextbox
            // 
            this.lgn_passwordTextbox.Location = new System.Drawing.Point(28, 139);
            this.lgn_passwordTextbox.Name = "lgn_passwordTextbox";
            this.lgn_passwordTextbox.PasswordChar = '*';
            this.lgn_passwordTextbox.Size = new System.Drawing.Size(192, 20);
            this.lgn_passwordTextbox.TabIndex = 8;
            // 
            // lgn_usernameTxtbox
            // 
            this.lgn_usernameTxtbox.Location = new System.Drawing.Point(28, 57);
            this.lgn_usernameTxtbox.Name = "lgn_usernameTxtbox";
            this.lgn_usernameTxtbox.Size = new System.Drawing.Size(192, 20);
            this.lgn_usernameTxtbox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(97, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Jelszó";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(70, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Felhasználónév";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 385);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Text = "Bejelentkezés";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button lgn_button;
        private System.Windows.Forms.TextBox lgn_passwordTextbox;
        private System.Windows.Forms.TextBox lgn_usernameTxtbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}