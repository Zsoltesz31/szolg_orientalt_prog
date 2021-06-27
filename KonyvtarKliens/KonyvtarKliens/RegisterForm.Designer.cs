
namespace KonyvtarKliens
{
    partial class RegisterForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.reg_btn = new System.Windows.Forms.Button();
            this.reg_pswTextbox2 = new System.Windows.Forms.TextBox();
            this.reg_pswTextbox = new System.Windows.Forms.TextBox();
            this.reg_usernameTxtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.reg_btn);
            this.groupBox1.Controls.Add(this.reg_pswTextbox2);
            this.groupBox1.Controls.Add(this.reg_pswTextbox);
            this.groupBox1.Controls.Add(this.reg_usernameTxtbox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(53, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 309);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Regisztráció";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(24, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Már van fiókja? Jelentkezzen be!";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            this.label4.MouseEnter += new System.EventHandler(this.label4_MouseEnter);
            this.label4.MouseLeave += new System.EventHandler(this.label4_MouseLeave);
            // 
            // reg_btn
            // 
            this.reg_btn.Location = new System.Drawing.Point(76, 222);
            this.reg_btn.Name = "reg_btn";
            this.reg_btn.Size = new System.Drawing.Size(93, 23);
            this.reg_btn.TabIndex = 2;
            this.reg_btn.Text = "Regisztráció";
            this.reg_btn.UseVisualStyleBackColor = true;
            this.reg_btn.Click += new System.EventHandler(this.reg_btn_Click);
            // 
            // reg_pswTextbox2
            // 
            this.reg_pswTextbox2.Location = new System.Drawing.Point(27, 183);
            this.reg_pswTextbox2.Name = "reg_pswTextbox2";
            this.reg_pswTextbox2.PasswordChar = '*';
            this.reg_pswTextbox2.Size = new System.Drawing.Size(177, 20);
            this.reg_pswTextbox2.TabIndex = 7;
            // 
            // reg_pswTextbox
            // 
            this.reg_pswTextbox.Location = new System.Drawing.Point(27, 122);
            this.reg_pswTextbox.Name = "reg_pswTextbox";
            this.reg_pswTextbox.PasswordChar = '*';
            this.reg_pswTextbox.Size = new System.Drawing.Size(177, 20);
            this.reg_pswTextbox.TabIndex = 6;
            // 
            // reg_usernameTxtbox
            // 
            this.reg_usernameTxtbox.Location = new System.Drawing.Point(27, 57);
            this.reg_usernameTxtbox.Name = "reg_usernameTxtbox";
            this.reg_usernameTxtbox.Size = new System.Drawing.Size(177, 20);
            this.reg_usernameTxtbox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(73, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Jelszó újra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(87, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Jelszó";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(61, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Felhasználónév";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 369);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "RegisterForm";
            this.Text = "Regisztráció";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button reg_btn;
        private System.Windows.Forms.TextBox reg_pswTextbox2;
        private System.Windows.Forms.TextBox reg_pswTextbox;
        private System.Windows.Forms.TextBox reg_usernameTxtbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}