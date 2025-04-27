namespace CustomAttributeApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblAd = new Label();
            lblSoyad = new Label();
            lblBolum = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtBolum = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.BackColor = SystemColors.Highlight;
            lblAd.Location = new Point(284, 87);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(93, 20);
            lblAd.TabIndex = 0;
            lblAd.Text = "Öğrenci adı: ";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.BackColor = SystemColors.Highlight;
            lblSoyad.Location = new Point(262, 130);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(115, 20);
            lblSoyad.TabIndex = 1;
            lblSoyad.Text = "Öğrenci soyadı: ";
            // 
            // lblBolum
            // 
            lblBolum.AutoSize = true;
            lblBolum.BackColor = SystemColors.Highlight;
            lblBolum.Location = new Point(254, 184);
            lblBolum.Name = "lblBolum";
            lblBolum.Size = new Size(123, 20);
            lblBolum.TabIndex = 2;
            lblBolum.Text = "Öğrenci bölümü: ";
            // 
            // txtAd
            // 
            txtAd.BackColor = SystemColors.Info;
            txtAd.Location = new Point(384, 87);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(125, 27);
            txtAd.TabIndex = 3;
            // 
            // txtSoyad
            // 
            txtSoyad.BackColor = SystemColors.Info;
            txtSoyad.Location = new Point(384, 130);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(125, 27);
            txtSoyad.TabIndex = 4;
            // 
            // txtBolum
            // 
            txtBolum.BackColor = SystemColors.Info;
            txtBolum.Location = new Point(383, 184);
            txtBolum.Name = "txtBolum";
            txtBolum.Size = new Size(125, 27);
            txtBolum.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.LimeGreen;
            button1.Location = new Point(326, 271);
            button1.Name = "button1";
            button1.Size = new Size(138, 63);
            button1.TabIndex = 6;
            button1.Text = "Bilgileri doğrula";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtBolum);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(lblBolum);
            Controls.Add(lblSoyad);
            Controls.Add(lblAd);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAd;
        private Label lblSoyad;
        private Label lblBolum;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtBolum;
        private Button button1;
    }
}
