namespace ArduinoLedYonetimi
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblKirmizi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblYesil = new System.Windows.Forms.Label();
            this.btnKirmiziAktif = new System.Windows.Forms.Button();
            this.btnKirmiziDeaktif = new System.Windows.Forms.Button();
            this.btnYesilAktif = new System.Windows.Forms.Button();
            this.btnYesilDeaktif = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblBaglantiStatu = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.txtPortName = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hoşgeldiniz:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(75, 13);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(0, 13);
            this.lblUsername.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ArduinoLedYonetimi.Properties.Resources._5mm_flashing_green_led;
            this.pictureBox2.Location = new System.Drawing.Point(402, 70);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(208, 175);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ArduinoLedYonetimi.Properties.Resources._10mm_red_led;
            this.pictureBox1.Location = new System.Drawing.Point(134, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kırmızı Led Durumu:";
            // 
            // lblKirmizi
            // 
            this.lblKirmizi.AutoSize = true;
            this.lblKirmizi.Location = new System.Drawing.Point(265, 252);
            this.lblKirmizi.Name = "lblKirmizi";
            this.lblKirmizi.Size = new System.Drawing.Size(29, 13);
            this.lblKirmizi.TabIndex = 4;
            this.lblKirmizi.Text = "YOK";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(436, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Yeşil Led Durumu:";
            // 
            // lblYesil
            // 
            this.lblYesil.AutoSize = true;
            this.lblYesil.Location = new System.Drawing.Point(535, 252);
            this.lblYesil.Name = "lblYesil";
            this.lblYesil.Size = new System.Drawing.Size(29, 13);
            this.lblYesil.TabIndex = 4;
            this.lblYesil.Text = "YOK";
            // 
            // btnKirmiziAktif
            // 
            this.btnKirmiziAktif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKirmiziAktif.Location = new System.Drawing.Point(146, 285);
            this.btnKirmiziAktif.Name = "btnKirmiziAktif";
            this.btnKirmiziAktif.Size = new System.Drawing.Size(81, 34);
            this.btnKirmiziAktif.TabIndex = 5;
            this.btnKirmiziAktif.Text = "Aktif";
            this.btnKirmiziAktif.UseVisualStyleBackColor = true;
            this.btnKirmiziAktif.Click += new System.EventHandler(this.btnKirmiziAktif_Click);
            // 
            // btnKirmiziDeaktif
            // 
            this.btnKirmiziDeaktif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKirmiziDeaktif.Location = new System.Drawing.Point(233, 285);
            this.btnKirmiziDeaktif.Name = "btnKirmiziDeaktif";
            this.btnKirmiziDeaktif.Size = new System.Drawing.Size(85, 34);
            this.btnKirmiziDeaktif.TabIndex = 5;
            this.btnKirmiziDeaktif.Text = "DeAktif";
            this.btnKirmiziDeaktif.UseVisualStyleBackColor = true;
            this.btnKirmiziDeaktif.Click += new System.EventHandler(this.btnKirmiziDeaktif_Click);
            // 
            // btnYesilAktif
            // 
            this.btnYesilAktif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYesilAktif.Location = new System.Drawing.Point(418, 285);
            this.btnYesilAktif.Name = "btnYesilAktif";
            this.btnYesilAktif.Size = new System.Drawing.Size(81, 34);
            this.btnYesilAktif.TabIndex = 5;
            this.btnYesilAktif.Text = "Aktif";
            this.btnYesilAktif.UseVisualStyleBackColor = true;
            this.btnYesilAktif.Click += new System.EventHandler(this.btnYesilAktif_Click);
            // 
            // btnYesilDeaktif
            // 
            this.btnYesilDeaktif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYesilDeaktif.Location = new System.Drawing.Point(505, 285);
            this.btnYesilDeaktif.Name = "btnYesilDeaktif";
            this.btnYesilDeaktif.Size = new System.Drawing.Size(85, 34);
            this.btnYesilDeaktif.TabIndex = 5;
            this.btnYesilDeaktif.Text = "DeAktif";
            this.btnYesilDeaktif.UseVisualStyleBackColor = true;
            this.btnYesilDeaktif.Click += new System.EventHandler(this.btnYesilDeaktif_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(91, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 21);
            this.button1.TabIndex = 6;
            this.button1.Text = "Bağlan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "PORT:";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(68, 366);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(150, 20);
            this.txtPort.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 418);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Bağlantı Durumu:";
            // 
            // lblBaglantiStatu
            // 
            this.lblBaglantiStatu.AutoSize = true;
            this.lblBaglantiStatu.ForeColor = System.Drawing.Color.Red;
            this.lblBaglantiStatu.Location = new System.Drawing.Point(151, 419);
            this.lblBaglantiStatu.Name = "lblBaglantiStatu";
            this.lblBaglantiStatu.Size = new System.Drawing.Size(62, 13);
            this.lblBaglantiStatu.TabIndex = 4;
            this.lblBaglantiStatu.Text = "Bağlanmadı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Port Name:";
            // 
            // txtPortName
            // 
            this.txtPortName.Location = new System.Drawing.Point(68, 340);
            this.txtPortName.Name = "txtPortName";
            this.txtPortName.Size = new System.Drawing.Size(150, 20);
            this.txtPortName.TabIndex = 8;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 441);
            this.Controls.Add(this.txtPortName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnYesilDeaktif);
            this.Controls.Add(this.btnYesilAktif);
            this.Controls.Add(this.btnKirmiziDeaktif);
            this.Controls.Add(this.btnKirmiziAktif);
            this.Controls.Add(this.lblYesil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblBaglantiStatu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblKirmizi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Yönetim Paneli";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblKirmizi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblYesil;
        private System.Windows.Forms.Button btnKirmiziAktif;
        private System.Windows.Forms.Button btnKirmiziDeaktif;
        private System.Windows.Forms.Button btnYesilAktif;
        private System.Windows.Forms.Button btnYesilDeaktif;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblBaglantiStatu;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPortName;
        private System.Windows.Forms.Timer timer1;
    }
}