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
            if (txt_Des.Text == "") { MessageBox.Show("Check empty fields!", "WeSSL"); return; }
            rtb_Log.Text = "";

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(txt_Des.Text);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                response.Close();

                X509Certificate cert = request.ServicePoint.Certificate;

                //convert the X509Certificate to an X509Certificate2 object by passing it into the constructor
                X509Certificate2 cert2 = new X509Certificate2(cert);

                string cin = cert2.GetIssuerName();
                string cn = cert2.GetName();

                string cgdate = cert2.GetEffectiveDateString();
                string cedate = cert2.GetExpirationDateString();

                string cka = cert2.GetKeyAlgorithm();
                string ckap = cert2.GetKeyAlgorithmParametersString();

                var cPubKeyEncryptKey = cert2.GetPublicKeyString();

                // Public Key Decrypt


                rtb_Log.Text = $"========= Name =========\nName: {cn}\n{cin}\n\n" +
                    $"========= Date =========\n Effective date: {cgdate}\n Expire date: {cedate}\n\n" +
                    $"========= Key Algorithm =========\nKey Algorithm: {cka}\nAlgorithm Parameters: {ckap}\n\n" +
                    $"========= Encrypted Public Key =========\n {cPubKeyEncryptKey}\n\n" +
                    $"========= Decrypted Public Key =========\n {0}\n\n";
            }
            catch (Exception err)
            {
                MessageBox.Show($"{err.Message}", "WeSSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
