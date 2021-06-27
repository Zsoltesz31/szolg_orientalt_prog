
namespace KonyvtarKliens
{
    partial class Form2
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.kolcsonzott_update = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.delete_btn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.konyv_listBox = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.updateoldalszam_Txtbox = new System.Windows.Forms.TextBox();
            this.updatemufaj_Txtbox = new System.Windows.Forms.TextBox();
            this.updatecim_Txtbox = new System.Windows.Forms.TextBox();
            this.update_btn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.hozzaad_Btn = new System.Windows.Forms.Button();
            this.oldalszamadd_textBoxx = new System.Windows.Forms.TextBox();
            this.mufajadd_txtBox = new System.Windows.Forms.TextBox();
            this.cimadd_txtBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.user_listbox = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.kolcsonzott_listbox = new System.Windows.Forms.ListBox();
            this.user_update = new System.Windows.Forms.Button();
            this.update_konyv = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.update_konyv);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.delete_btn);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.konyv_listBox);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.updateoldalszam_Txtbox);
            this.groupBox4.Controls.Add(this.updatemufaj_Txtbox);
            this.groupBox4.Controls.Add(this.updatecim_Txtbox);
            this.groupBox4.Controls.Add(this.update_btn);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.hozzaad_Btn);
            this.groupBox4.Controls.Add(this.oldalszamadd_textBoxx);
            this.groupBox4.Controls.Add(this.mufajadd_txtBox);
            this.groupBox4.Controls.Add(this.cimadd_txtBox);
            this.groupBox4.Location = new System.Drawing.Point(18, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(800, 333);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Könyvtár";
            // 
            // kolcsonzott_update
            // 
            this.kolcsonzott_update.Location = new System.Drawing.Point(156, 219);
            this.kolcsonzott_update.Name = "kolcsonzott_update";
            this.kolcsonzott_update.Size = new System.Drawing.Size(93, 23);
            this.kolcsonzott_update.TabIndex = 24;
            this.kolcsonzott_update.Text = "Frissít";
            this.kolcsonzott_update.UseVisualStyleBackColor = true;
            this.kolcsonzott_update.Click += new System.EventHandler(this.kolcsonzott_update_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 194);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Oldalszám:";
            this.label11.UseMnemonic = false;
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(467, 302);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(93, 23);
            this.delete_btn.TabIndex = 23;
            this.delete_btn.Text = "Törlés";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Műfaj:";
            this.label10.UseMnemonic = false;
            // 
            // konyv_listBox
            // 
            this.konyv_listBox.FormattingEnabled = true;
            this.konyv_listBox.Location = new System.Drawing.Point(467, 19);
            this.konyv_listBox.Name = "konyv_listBox";
            this.konyv_listBox.Size = new System.Drawing.Size(268, 277);
            this.konyv_listBox.TabIndex = 22;
            this.konyv_listBox.SelectedIndexChanged += new System.EventHandler(this.konyv_listBox_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Cím:";
            this.label9.UseMnemonic = false;
            // 
            // updateoldalszam_Txtbox
            // 
            this.updateoldalszam_Txtbox.Location = new System.Drawing.Point(106, 187);
            this.updateoldalszam_Txtbox.Name = "updateoldalszam_Txtbox";
            this.updateoldalszam_Txtbox.Size = new System.Drawing.Size(177, 20);
            this.updateoldalszam_Txtbox.TabIndex = 18;
            // 
            // updatemufaj_Txtbox
            // 
            this.updatemufaj_Txtbox.Location = new System.Drawing.Point(106, 161);
            this.updatemufaj_Txtbox.Name = "updatemufaj_Txtbox";
            this.updatemufaj_Txtbox.Size = new System.Drawing.Size(177, 20);
            this.updatemufaj_Txtbox.TabIndex = 17;
            // 
            // updatecim_Txtbox
            // 
            this.updatecim_Txtbox.Location = new System.Drawing.Point(106, 135);
            this.updatecim_Txtbox.Name = "updatecim_Txtbox";
            this.updatecim_Txtbox.Size = new System.Drawing.Size(177, 20);
            this.updatecim_Txtbox.TabIndex = 16;
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(148, 213);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(93, 23);
            this.update_btn.TabIndex = 15;
            this.update_btn.Text = "Módosít";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Oldalszám:";
            this.label8.UseMnemonic = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Műfaj:";
            this.label7.UseMnemonic = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cím:";
            this.label6.UseMnemonic = false;
            // 
            // hozzaad_Btn
            // 
            this.hozzaad_Btn.Location = new System.Drawing.Point(148, 106);
            this.hozzaad_Btn.Name = "hozzaad_Btn";
            this.hozzaad_Btn.Size = new System.Drawing.Size(93, 23);
            this.hozzaad_Btn.TabIndex = 10;
            this.hozzaad_Btn.Text = "Hozzáad";
            this.hozzaad_Btn.UseVisualStyleBackColor = true;
            this.hozzaad_Btn.Click += new System.EventHandler(this.hozzaad_Btn_Click);
            // 
            // oldalszamadd_textBoxx
            // 
            this.oldalszamadd_textBoxx.Location = new System.Drawing.Point(106, 80);
            this.oldalszamadd_textBoxx.Name = "oldalszamadd_textBoxx";
            this.oldalszamadd_textBoxx.Size = new System.Drawing.Size(177, 20);
            this.oldalszamadd_textBoxx.TabIndex = 12;
            // 
            // mufajadd_txtBox
            // 
            this.mufajadd_txtBox.Location = new System.Drawing.Point(106, 51);
            this.mufajadd_txtBox.Name = "mufajadd_txtBox";
            this.mufajadd_txtBox.Size = new System.Drawing.Size(177, 20);
            this.mufajadd_txtBox.TabIndex = 11;
            // 
            // cimadd_txtBox
            // 
            this.cimadd_txtBox.Location = new System.Drawing.Point(106, 25);
            this.cimadd_txtBox.Name = "cimadd_txtBox";
            this.cimadd_txtBox.Size = new System.Drawing.Size(177, 20);
            this.cimadd_txtBox.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.user_update);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.user_listbox);
            this.groupBox1.Location = new System.Drawing.Point(18, 351);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 248);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Felhasználók";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(280, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Kirúg";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // user_listbox
            // 
            this.user_listbox.FormattingEnabled = true;
            this.user_listbox.Location = new System.Drawing.Point(6, 31);
            this.user_listbox.Name = "user_listbox";
            this.user_listbox.Size = new System.Drawing.Size(268, 186);
            this.user_listbox.TabIndex = 25;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.kolcsonzott_update);
            this.groupBox2.Controls.Add(this.kolcsonzott_listbox);
            this.groupBox2.Location = new System.Drawing.Point(418, 351);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 248);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kölcsönzött könyvek";
            // 
            // kolcsonzott_listbox
            // 
            this.kolcsonzott_listbox.FormattingEnabled = true;
            this.kolcsonzott_listbox.Location = new System.Drawing.Point(67, 31);
            this.kolcsonzott_listbox.Name = "kolcsonzott_listbox";
            this.kolcsonzott_listbox.Size = new System.Drawing.Size(268, 186);
            this.kolcsonzott_listbox.TabIndex = 26;
            // 
            // user_update
            // 
            this.user_update.Location = new System.Drawing.Point(280, 140);
            this.user_update.Name = "user_update";
            this.user_update.Size = new System.Drawing.Size(93, 23);
            this.user_update.TabIndex = 25;
            this.user_update.Text = "Frissít";
            this.user_update.UseVisualStyleBackColor = true;
            this.user_update.Click += new System.EventHandler(this.user_update_Click);
            // 
            // update_konyv
            // 
            this.update_konyv.Location = new System.Drawing.Point(642, 302);
            this.update_konyv.Name = "update_konyv";
            this.update_konyv.Size = new System.Drawing.Size(93, 23);
            this.update_konyv.TabIndex = 26;
            this.update_konyv.Text = "Frissít";
            this.update_konyv.UseVisualStyleBackColor = true;
            this.update_konyv.Click += new System.EventHandler(this.update_konyv_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 611);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Admin interfész";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox updateoldalszam_Txtbox;
        private System.Windows.Forms.TextBox updatemufaj_Txtbox;
        private System.Windows.Forms.TextBox updatecim_Txtbox;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button hozzaad_Btn;
        private System.Windows.Forms.TextBox oldalszamadd_textBoxx;
        private System.Windows.Forms.TextBox mufajadd_txtBox;
        private System.Windows.Forms.TextBox cimadd_txtBox;
        private System.Windows.Forms.ListBox konyv_listBox;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button kolcsonzott_update;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox user_listbox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox kolcsonzott_listbox;
        private System.Windows.Forms.Button user_update;
        private System.Windows.Forms.Button update_konyv;
    }
}