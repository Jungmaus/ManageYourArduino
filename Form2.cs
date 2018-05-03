using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoLedYonetimi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        bool againCon = false;
        bool conStatu = false;

        private void Form2_Load(object sender, EventArgs e)
        {
            lblKirmizi.ForeColor = Color.Red;
            lblKirmizi.Text = "KAPALI";
            btnKirmiziAktif.Enabled = true;
            btnKirmiziDeaktif.Enabled = false;
            lblYesil.ForeColor = Color.Red;
            lblYesil.Text = "KAPALI";
            btnYesilAktif.Enabled = true;
            btnYesilDeaktif.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int port = Convert.ToInt32(txtPort.Text);
            string portName = txtPortName.Text;
            do
            {
                try
                {
                    serialPort1.PortName = portName;
                    serialPort1.BaudRate = port;
                    serialPort1.Open();
                    lblBaglantiStatu.ForeColor = Color.Green;
                    lblBaglantiStatu.Text = "Bağlandı";
                    conStatu = true;        
                }
                catch (Exception hata)
                {
                    conStatu = false;
                    lblBaglantiStatu.ForeColor = Color.Red;
                    lblBaglantiStatu.Text = "Bağlanmadı";
                    MessageBox.Show(hata.ToString());
                    DialogResult a = MessageBox.Show("PORT'a bağlanılamadı!", "Hata!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (a == DialogResult.Retry)
                    {
                        againCon = true;
                    }
                    else
                    {
                        againCon = false;
                    }
                }
            } while (againCon);
        }

        private void btnYesilDeaktif_Click(object sender, EventArgs e)
        {
            try
            {
                if (conStatu == true)
                {
                        serialPort1.Write("0");
                        lblYesil.Text = "KAPALI";
                        lblYesil.ForeColor = Color.Red;
                        btnYesilDeaktif.Enabled = false;
                        btnYesilAktif.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("İşlem tamamlanırken bir hata oluştu.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ConControl();
            }
        }

        private void btnYesilAktif_Click(object sender, EventArgs e)
        {
            try
            {
                if (conStatu == true)
                {
                    serialPort1.Write("1");
                    lblYesil.Text = "AKTIF";
                    lblYesil.ForeColor = Color.Green;
                    btnYesilAktif.Enabled = false;
                    btnYesilDeaktif.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("İşlem tamamlanırken bir hata oluştu.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ConControl();
            }
        }

        void ConControl()
        {
            if (conStatu == true)
            {
                MessageBox.Show("Port Bağlantısı Aktif.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Port Bağlantısı Kapalı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (conStatu == false)
            {
                lblBaglantiStatu.ForeColor = Color.Red;
                lblBaglantiStatu.Text = "Bağlanmadı";
                button1.Enabled = true;
            }
            else
            {
                if (lblBaglantiStatu.Text != "Bağlandı")
                {
                    lblBaglantiStatu.ForeColor = Color.Green;
                    lblBaglantiStatu.Text = "Bağlandı";
                    button1.Enabled = false;
                }
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnKirmiziAktif_Click(object sender, EventArgs e)
        {
            try
            {
                if (conStatu == true)
                {
                    serialPort1.Write("3");
                    lblKirmizi.Text = "AKTIF";
                    lblKirmizi.ForeColor = Color.Green;
                    btnKirmiziAktif.Enabled = false;
                    btnKirmiziDeaktif.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("İşlem tamamlanırken bir hata oluştu.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ConControl();
            }
        }

        private void btnKirmiziDeaktif_Click(object sender, EventArgs e)
        {
            try
            {
                if (conStatu == true)
                {
                    serialPort1.Write("2");
                    lblKirmizi.Text = "KAPALI";
                    lblKirmizi.ForeColor = Color.Red;
                    btnKirmiziDeaktif.Enabled = false;
                    btnKirmiziAktif.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("İşlem tamamlanırken bir hata oluştu.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ConControl();
            }
        }
    }
}
