namespace DogusCase1
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
            lblOdemeTipi = new Label();
            lblTutar = new Label();
            lblSonuc = new Label();
            btnOdemeYap = new Button();
            cmbOdemeTipi = new ComboBox();
            txtTutar = new TextBox();
            SuspendLayout();
            // 
            // lblOdemeTipi
            // 
            lblOdemeTipi.AutoSize = true;
            lblOdemeTipi.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblOdemeTipi.Location = new Point(145, 68);
            lblOdemeTipi.Name = "lblOdemeTipi";
            lblOdemeTipi.Size = new Size(124, 25);
            lblOdemeTipi.TabIndex = 0;
            lblOdemeTipi.Text = "Ödeme Tipi :";
            // 
            // lblTutar
            // 
            lblTutar.AutoSize = true;
            lblTutar.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTutar.Location = new Point(145, 131);
            lblTutar.Name = "lblTutar";
            lblTutar.Size = new Size(70, 25);
            lblTutar.TabIndex = 1;
            lblTutar.Text = "Tutar :";
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSonuc.Location = new Point(320, 357);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(63, 25);
            lblSonuc.TabIndex = 2;
            lblSonuc.Text = "Sonuç";
            // 
            // btnOdemeYap
            // 
            btnOdemeYap.BackColor = Color.FromArgb(224, 224, 224);
            btnOdemeYap.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnOdemeYap.Location = new Point(401, 210);
            btnOdemeYap.Name = "btnOdemeYap";
            btnOdemeYap.Size = new Size(243, 55);
            btnOdemeYap.TabIndex = 3;
            btnOdemeYap.Text = "Ödeme Yap";
            btnOdemeYap.UseVisualStyleBackColor = false;
            btnOdemeYap.Click += btnOdemeYap_Click;
            // 
            // cmbOdemeTipi
            // 
            cmbOdemeTipi.FormattingEnabled = true;
            cmbOdemeTipi.Items.AddRange(new object[] { "Seçiniz", "Kredi", "PayPal", "ApplePay" });
            cmbOdemeTipi.Location = new Point(401, 65);
            cmbOdemeTipi.Name = "cmbOdemeTipi";
            cmbOdemeTipi.Size = new Size(243, 28);
            cmbOdemeTipi.TabIndex = 4;
            cmbOdemeTipi.SelectedIndexChanged += cmbOdemeTipi_SelectedIndexChanged;
            // 
            // txtTutar
            // 
            txtTutar.Location = new Point(401, 131);
            txtTutar.Name = "txtTutar";
            txtTutar.Size = new Size(243, 27);
            txtTutar.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(743, 505);
            Controls.Add(txtTutar);
            Controls.Add(cmbOdemeTipi);
            Controls.Add(btnOdemeYap);
            Controls.Add(lblSonuc);
            Controls.Add(lblTutar);
            Controls.Add(lblOdemeTipi);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOdemeTipi;
        private Label lblTutar;
        private Label lblSonuc;
        private Button btnOdemeYap;
        private ComboBox cmbOdemeTipi;
        private TextBox txtTutar;
    }
}
