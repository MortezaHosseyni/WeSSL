using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Net;

namespace WeSLL
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btn_Capture_Click(object sender, EventArgs e)
        {
            if (txt_Des.Text == "") { MessageBox.Show("Enter value"); return; }
            rtb_Log.Text = "";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(txt_Des.Text);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            response.Close();

            X509Certificate cert = request.ServicePoint.Certificate;

            //convert the X509Certificate to an X509Certificate2 object by passing it into the constructor
            X509Certificate2 cert2 = new X509Certificate2(cert);

            string cn = cert2.GetIssuerName();
            string cedate = cert2.GetExpirationDateString();
            string cpub = cert2.GetPublicKeyString();
            string c = cert2.GetRawCertData().ToString();

            //display the cert dialog box
            //X509Certificate2UI.DisplayCertificate(cert2);
            rtb_Log.Text = $"{c}";
        }
    }
}
