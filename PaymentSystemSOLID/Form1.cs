using PaymentSystemSOLID.SOLID;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaymentSystemSOLID
{
    public partial class Form1 : Form
    {
        string secilenOdemeTipi;
        ILog iLog;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOdemeYap_Click(object sender, EventArgs e)
        {
            LogFactory factory = new LogFactory();
            iLog = factory.yeniNesneOlustur(secilenOdemeTipi);
            Logger logger = new Logger(iLog);
            lblSonuc.Text = logger.LogKaydet(txtTutar.Text);
        }

        private void cmbOdemeTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilenOdemeTipi = cmbOdemeTipi.SelectedItem.ToString();
        }
    }
}
