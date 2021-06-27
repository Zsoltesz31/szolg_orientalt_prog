using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KonyvtarKliens.SR;

namespace KonyvtarKliens
{
    public partial class Form1 : Form
    {
        List<Konyv> konyvek;
        User currUser;
        List<KolcsonzottKonyv> kolcsonzottek;
        KolcsonzottKonyv kolcsonzott;

        
        
        public Form1()
        {
            currUser = LoginForm.user;
            InitializeComponent();
            this.MaximumSize = new Size(this.Width, this.Height);
            this.MinimumSize = new Size(this.Width, this.Height);
            InitLoggedUsers();
            InitComboBoxKonyvek();
            InitComboBoxKolcsonzott();


           
            if (currUser.Jogkor==1)
            {
                admin_btn.Visible = true;
            }
            else
            {
                admin_btn.Visible = false;
            }
            
        }

        private void InitLoggedUsers()
        {
            try
            {
                Service1Client client = new Service1Client();
                loggedusers_Listbox.BeginUpdate();
                loggedusers_Listbox.Items.Clear();
                List<User> users = new List<User>();
                users = client.getUsers(currUser.Fnev).ToList<User>();
                foreach (User user in users)
                {
                    loggedusers_Listbox.Items.Add(user.Fnev);
                }
                loggedusers_Listbox.EndUpdate();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }
        private void InitComboBoxKonyvek()
        {
            try
            {
                Service1Client client = new Service1Client();
                konyvek = client.ListKonyvek(currUser.Fnev).ToList<Konyv>();


                konyv_listBox.BeginUpdate();
                konyv_listBox.Items.Clear();

                foreach (Konyv konyv in konyvek)
                {
                    konyv_listBox.Items.Add(konyv.StringFormatum);

                }

                konyv_listBox.EndUpdate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void InitComboBoxKolcsonzott()
        {
            try
            {
                Service1Client client = new Service1Client();
                kolcsonzottek = client.listToUser(currUser, currUser.Fnev).ToList<KolcsonzottKonyv>();


                kolcsonzott_listbox.BeginUpdate();
                kolcsonzott_listbox.Items.Clear();

                foreach (KolcsonzottKonyv kolcsonzott in kolcsonzottek)
                {
                    kolcsonzott_listbox.Items.Add(kolcsonzott.KolcsonzottFormatum);

                }

                kolcsonzott_listbox.EndUpdate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void update_konyvBtn_Click(object sender, EventArgs e)
        {
            InitComboBoxKonyvek();
           
        }

        

        private void konyv_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (konyv_listBox.SelectedIndex==-1)
                {
                    return;
                }
                Konyv konyv;
                string s = konyv_listBox.SelectedItem.ToString();
                konyv = konyvek.Find((k) => k.StringFormatum == s);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void admin_btn_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(currUser);
            form.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Service1Client client = new Service1Client();
                client.Logout(currUser);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void kolcsonoz_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                
                Service1Client client = new Service1Client();
                Konyv konyv;
                if (konyv_listBox.SelectedItem==null)
                {
                    MessageBox.Show("Nincs kiválasztva könyv!");
                    return;
                }
                string s = konyv_listBox.SelectedItem.ToString();
                konyv = konyvek.Find((k) => k.StringFormatum == s);
                client.Kolcsonoz(konyv, currUser, currUser.Fnev);
                InitComboBoxKolcsonzott();
                InitComboBoxKonyvek();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                InitComboBoxKonyvek();
            }
        }

        private void visszavisz_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Service1Client client = new Service1Client();
                if (kolcsonzott_listbox.SelectedItem==null)
                {
                    MessageBox.Show("Nincs kiválasztva könyv!");
                    return;
                }
                string s = kolcsonzott_listbox.SelectedItem.ToString();
                kolcsonzott = kolcsonzottek.Find((k) => k.KolcsonzottFormatum == s);
                client.Visszavisz(kolcsonzott, currUser.Fnev);
                InitComboBoxKonyvek();
                InitComboBoxKolcsonzott();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt a visszavétel során!");
            }
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Service1Client client = new Service1Client();
                client.Logout(currUser);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void update_userlist_Click(object sender, EventArgs e)
        {
            InitLoggedUsers();
            
        }
        private void CheckIfLoggedIn()
        {
            try
            {
                Service1Client client = new Service1Client();
                if (client.LoggedIn(currUser.Fnev) == false)
                {
                    timer1.Enabled = false;
                    MessageBox.Show("Lekapcsolódtál a szerverről!");
                    LoginForm nextForm = new LoginForm();
                    this.Hide();
                    nextForm.ShowDialog();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            CheckIfLoggedIn();
        }
    }
}
