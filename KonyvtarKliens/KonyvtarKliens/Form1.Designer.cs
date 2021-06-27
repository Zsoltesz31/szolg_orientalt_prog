
namespace KonyvtarKliens
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
            this.components = new System.ComponentModel.Container();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.admin_btn = new System.Windows.Forms.Button();
            this.kolcsonoz_Btn = new System.Windows.Forms.Button();
            this.update_konyvBtn = new System.Windows.Forms.Button();
            this.konyv_listBox = new System.Windows.Forms.ListBox();
            this.kolcsonzes_grpBox = new System.Windows.Forms.GroupBox();
            this.visszavisz_btn = new System.Windows.Forms.Button();
            this.kolcsonzott_listbox = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.loggedusers_Listbox = new System.Windows.Forms.ListBox();
            this.logout_btn = new System.Windows.Forms.Button();
            this.update_userlist = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox3.SuspendLayout();
            this.kolcsonzes_grpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.admin_btn);
            this.groupBox3.Controls.Add(this.kolcsonoz_Btn);
            this.groupBox3.Controls.Add(this.update_konyvBtn);
            this.groupBox3.Controls.Add(this.konyv_listBox);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(474, 303);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Könyvtár";
            // 
            // admin_btn
            // 
            this.admin_btn.Location = new System.Drawing.Point(310, 193);
            this.admin_btn.Name = "admin_btn";
            this.admin_btn.Size = new System.Drawing.Size(139, 76);
            this.admin_btn.TabIndex = 17;
            this.admin_btn.Text = "Admin interfész";
            this.admin_btn.UseVisualStyleBackColor = true;
            this.admin_btn.Click += new System.EventHandler(this.admin_btn_Click);
            // 
            // kolcsonoz_Btn
            // 
            this.kolcsonoz_Btn.Location = new System.Drawing.Point(310, 111);
            this.kolcsonoz_Btn.Name = "kolcsonoz_Btn";
            this.kolcsonoz_Btn.Size = new System.Drawing.Size(139, 76);
            this.kolcsonoz_Btn.TabIndex = 10;
            this.kolcsonoz_Btn.Text = "Kölcsönöz";
            this.kolcsonoz_Btn.UseVisualStyleBackColor = true;
            this.kolcsonoz_Btn.Click += new System.EventHandler(this.kolcsonoz_Btn_Click);
            // 
            // update_konyvBtn
            // 
            this.update_konyvBtn.Location = new System.Drawing.Point(310, 29);
            this.update_konyvBtn.Name = "update_konyvBtn";
            this.update_konyvBtn.Size = new System.Drawing.Size(139, 76);
            this.update_konyvBtn.TabIndex = 9;
            this.update_konyvBtn.Text = "Frissít";
            this.update_konyvBtn.UseVisualStyleBackColor = true;
            this.update_konyvBtn.Click += new System.EventHandler(this.update_konyvBtn_Click);
            // 
            // konyv_listBox
            // 
            this.konyv_listBox.FormattingEnabled = true;
            this.konyv_listBox.Location = new System.Drawing.Point(6, 19);
            this.konyv_listBox.Name = "konyv_listBox";
            this.konyv_listBox.Size = new System.Drawing.Size(268, 277);
            this.konyv_listBox.TabIndex = 0;
            this.konyv_listBox.SelectedIndexChanged += new System.EventHandler(this.konyv_listBox_SelectedIndexChanged);
            // 
            // kolcsonzes_grpBox
            // 
            this.kolcsonzes_grpBox.Controls.Add(this.visszavisz_btn);
            this.kolcsonzes_grpBox.Controls.Add(this.kolcsonzott_listbox);
            this.kolcsonzes_grpBox.Location = new System.Drawing.Point(505, 12);
            this.kolcsonzes_grpBox.Name = "kolcsonzes_grpBox";
            this.kolcsonzes_grpBox.Size = new System.Drawing.Size(474, 303);
            this.kolcsonzes_grpBox.TabIndex = 3;
            this.kolcsonzes_grpBox.TabStop = false;
            this.kolcsonzes_grpBox.Text = "Kölcsönzés";
            // 
            // visszavisz_btn
            // 
            this.visszavisz_btn.Location = new System.Drawing.Point(311, 106);
            this.visszavisz_btn.Name = "visszavisz_btn";
            this.visszavisz_btn.Size = new System.Drawing.Size(139, 76);
            this.visszavisz_btn.TabIndex = 1;
            this.visszavisz_btn.Text = "Visszavisz";
            this.visszavisz_btn.UseVisualStyleBackColor = true;
            this.visszavisz_btn.Click += new System.EventHandler(this.visszavisz_btn_Click);
            // 
            // kolcsonzott_listbox
            // 
            this.kolcsonzott_listbox.FormattingEnabled = true;
            this.kolcsonzott_listbox.Location = new System.Drawing.Point(7, 20);
            this.kolcsonzott_listbox.Name = "kolcsonzott_listbox";
            this.kolcsonzott_listbox.Size = new System.Drawing.Size(268, 277);
            this.kolcsonzott_listbox.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(424, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Online felhasználók";
            // 
            // loggedusers_Listbox
            // 
            this.loggedusers_Listbox.FormattingEnabled = true;
            this.loggedusers_Listbox.Location = new System.Drawing.Point(355, 373);
            this.loggedusers_Listbox.Name = "loggedusers_Listbox";
            this.loggedusers_Listbox.Size = new System.Drawing.Size(307, 212);
            this.loggedusers_Listbox.TabIndex = 5;
            // 
            // logout_btn
            // 
            this.logout_btn.Location = new System.Drawing.Point(569, 591);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(93, 23);
            this.logout_btn.TabIndex = 10;
            this.logout_btn.Text = "Kijelentkezés";
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // update_userlist
            // 
            this.update_userlist.Location = new System.Drawing.Point(355, 591);
            this.update_userlist.Name = "update_userlist";
            this.update_userlist.Size = new System.Drawing.Size(93, 23);
            this.update_userlist.TabIndex = 11;
            this.update_userlist.Text = "Frissít";
            this.update_userlist.UseVisualStyleBackColor = true;
            this.update_userlist.Click += new System.EventHandler(this.update_userlist_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 626);
            this.Controls.Add(this.update_userlist);
            this.Controls.Add(this.logout_btn);
            this.Controls.Add(this.loggedusers_Listbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.kolcsonzes_grpBox);
            this.Controls.Add(this.groupBox3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Könyvtár";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox3.ResumeLayout(false);
            this.kolcsonzes_grpBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button kolcsonoz_Btn;
        private System.Windows.Forms.Button update_konyvBtn;
        private System.Windows.Forms.ListBox konyv_listBox;
        private System.Windows.Forms.Button admin_btn;
        private System.Windows.Forms.GroupBox kolcsonzes_grpBox;
        private System.Windows.Forms.Button visszavisz_btn;
        private System.Windows.Forms.ListBox kolcsonzott_listbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox loggedusers_Listbox;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Button update_userlist;
        private System.Windows.Forms.Timer timer1;
    }
}

