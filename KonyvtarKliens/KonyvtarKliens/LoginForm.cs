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
    public partial class LoginForm : Form
    {
        public static User user;
        public LoginForm()
        {
            InitializeComponent();
            this.MaximumSize = new Size(this.Width, this.Height);
            this.MinimumSize = new Size(this.Width, this.Height);
            User user = new User();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            RegisterForm nextForm = new RegisterForm();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
            label1.ForeColor = Color.Blue;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
        }

        private void lgn_button_Click(object sender, EventArgs e)
        {
            
            Service1Client client = new Service1Client();
            
            try
            {
                
              
                if (client.LoggedIn(lgn_usernameTxtbox.Text))
                {
                    MessageBox.Show("A felhasználó már bejelentkezett!");
                }
                else
                {


                    user = client.Login(lgn_usernameTxtbox.Text, lgn_passwordTextbox.Text);
                    MessageBox.Show("Sikeres bejelentkezés!");
                    Form1 nextForm = new Form1();
                    this.Hide();
                    nextForm.ShowDialog();
                    this.Close();
                   
                }
                    
               
            }
            catch (Exception ex )
            {
                
                MessageBox.Show(ex.Message);
            }
            
       
        }
    }
}
