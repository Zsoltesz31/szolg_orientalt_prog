using KonyvtarKliens.SR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KonyvtarKliens
{
    public partial class Form2 : Form
    {
        Form form1;
        List<Konyv> konyvek;
        User currUser;
        List<KolcsonzottKonyv> kolcsonzottek;
        KolcsonzottKonyv kolcsonzott;
        public Form2(User u)
        {
            currUser = u;
            
            
            InitializeComponent();
            this.MaximumSize = new Size(this.Width, this.Height);
            this.MinimumSize = new Size(this.Width, this.Height);
            InitComboBoxKonyvek();
            InitComboBoxKolcsonzott();
            InitLoggedUsers();
            updatecim_Txtbox.Enabled = false;
            updatemufaj_Txtbox.Enabled = false;
            updateoldalszam_Txtbox.Enabled = false;
        }

        private void InitLoggedUsers()
        {
            try
            {
                Service1Client client = new Service1Client();
                user_listbox.BeginUpdate();
                user_listbox.Items.Clear();
                List<User> users = new List<User>();
                users = client.getUsers(currUser.Fnev).ToList<User>();
                foreach (User user in users)
                {
                    user_listbox.Items.Add(user.Fnev);
                }
                user_listbox.EndUpdate();
            }
            catch (Exception ex)
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
                kolcsonzottek = client.kolcsonzott(currUser.Fnev).ToList<KolcsonzottKonyv>();


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

        private void hozzaad_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                Service1Client client = new Service1Client();
                Konyv konyv = new Konyv();
                if (cimadd_txtBox.Text=="" || mufajadd_txtBox.Text=="" || oldalszamadd_textBoxx.Text=="")
                {
                    MessageBox.Show("Töltsd ki a könyv mezőit hogy feltölthess egy új könyvet!");
                    return;
                }
                konyv.k_Cim = cimadd_txtBox.Text;
                konyv.k_Mufaj = mufajadd_txtBox.Text;
                konyv.k_Oldalszam = int.Parse(oldalszamadd_textBoxx.Text);
                client.InsertKonyv(konyv, currUser.Fnev);
                MessageBox.Show("Sikeresen hozzá adtuk a könyvet!");
                InitComboBoxKonyvek();
                cimadd_txtBox.Text="";
                mufajadd_txtBox.Text="";
                oldalszamadd_textBoxx.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Service1Client client = new Service1Client();
                if (konyv_listBox.SelectedItem==null)
                {
                    MessageBox.Show("Nincs könyv amelyet módosíthatnál!");
                    return;
                }
                string s = konyv_listBox.SelectedItem.ToString();
                Konyv konyv;
                konyv = konyvek.Find((k) => k.StringFormatum == s);
                konyv.k_Id = konyv.k_Id;
                konyv.k_Cim = updatecim_Txtbox.Text;
                konyv.k_Mufaj = updatemufaj_Txtbox.Text;
                konyv.k_Oldalszam = int.Parse(updateoldalszam_Txtbox.Text);
                client.UpdateKonyv(konyv, currUser.Fnev);
                MessageBox.Show("Sikeresen módosítottuk a könyv adatait!");
                InitComboBoxKonyvek();
                updatecim_Txtbox.Text = "";
                updatemufaj_Txtbox.Text="";
                updateoldalszam_Txtbox.Text = "";
                updatecim_Txtbox.Enabled = false;
                updatemufaj_Txtbox.Enabled = false;
                updateoldalszam_Txtbox.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void konyv_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (konyv_listBox.SelectedIndex==-1)
            {
                return;
            }
            updatecim_Txtbox.Enabled = true;
            updatemufaj_Txtbox.Enabled = true;
            updateoldalszam_Txtbox.Enabled = true;
            Konyv konyv;
            string s = konyv_listBox.SelectedItem.ToString();
            konyv = konyvek.Find((k) => k.StringFormatum == s);
            updatecim_Txtbox.Text = konyv.k_Cim.ToString();
            updatemufaj_Txtbox.Text = konyv.k_Mufaj.ToString();
            updateoldalszam_Txtbox.Text = konyv.k_Oldalszam.ToString();

        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Konyv konyv;
                Konyv k2 = new Konyv();
                Service1Client client = new Service1Client();
                string s = konyv_listBox.SelectedItem.ToString();
                konyv = konyvek.Find((k) => k.StringFormatum == s);
                client.DeleteKonyv(konyv, currUser.Fnev);
                InitComboBoxKonyvek();
                updatecim_Txtbox.Text = "";
                updatemufaj_Txtbox.Text = "";
                updateoldalszam_Txtbox.Text = "";
                updatecim_Txtbox.Enabled = false;
                updatemufaj_Txtbox.Enabled = false;
                updateoldalszam_Txtbox.Enabled = false;
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (user_listbox.SelectedItem==null)
                {
                    return;
                }
                string fnev = user_listbox.SelectedItem.ToString();
                
                Service1Client client = new Service1Client();
                if (currUser.Fnev==fnev)
                {
                    MessageBox.Show("Önmagad nem rúghatod ki!");
                }
                else
                {
                    client.Logout(new User() { Fnev = fnev });
                }
               
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void user_update_Click(object sender, EventArgs e)
        {
            InitLoggedUsers();
        }

        private void kolcsonzott_update_Click(object sender, EventArgs e)
        {
            InitComboBoxKolcsonzott();
            InitComboBoxKonyvek();
        }

        private void update_konyv_Click(object sender, EventArgs e)
        {
            InitComboBoxKonyvek();
            InitComboBoxKolcsonzott();
        }
    }
}
