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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            this.MaximumSize = new Size(this.Width, this.Height);
            this.MinimumSize = new Size(this.Width, this.Height);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            LoginForm nextForm = new LoginForm();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

     

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
            label4.ForeColor = Color.Blue;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
            label4.ForeColor = Color.Black;
        }

        private void reg_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Service1Client client = new Service1Client();
                

                if (reg_usernameTxtbox.Text=="" || reg_pswTextbox2.Text=="" || reg_pswTextbox.Text=="")
                {
                    MessageBox.Show("Tölts ki minden mezőt!");
                }
                else if(reg_pswTextbox.Text!=reg_pswTextbox2.Text)
                {
                    MessageBox.Show("A jelszavak nem egyeznek!");
                }
                else
                {
                    if (client.CheckRegister(reg_usernameTxtbox.Text) == 0)
                    {
                        client.Register(reg_usernameTxtbox.Text, reg_pswTextbox.Text);
                        MessageBox.Show("Sikeres regisztráció!");
                        LoginForm nextForm = new LoginForm();
                        this.Hide();
                        nextForm.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Már van ilyen felhasználó!");
                    }
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Sikertelen regisztráció!");
            }
        }
    }
}
