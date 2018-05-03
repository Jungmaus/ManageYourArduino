using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArduinoLedYonetimi.Models;


namespace ArduinoLedYonetimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        IletisimClass csiletisim = new IletisimClass();
        Form2 frm2 = new Form2();

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtKadi.Text != "" && txtKadi.Text != " " && txtSifre.Text != "" && txtSifre.Text != " ")
            {

                int control = csiletisim.UserLogin(txtKadi.Text, txtSifre.Text);
                if(control == 1)
                {
                    frm2.Show();
                    frm2.lblUsername.Text = txtKadi.Text + " " + txtSifre.Text;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adınız veya şifreniz hatalıdır. Lütfen tekrar deneyiniz.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtKadi.Clear();
                    txtSifre.Clear();
                    txtKadi.Focus();
                }
            }
            else
            {
                MessageBox.Show("Tüm alanların eksiksiz bir şekilde doldurulması zorunludur.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKadi.Focus();
            }
        }
    }
}
