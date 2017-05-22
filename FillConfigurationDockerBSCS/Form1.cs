using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FillConfigurationDockerBSCS
{
    public partial class Form1 : Form
    {

        public const string variable = "variable";
        public const string tsnName = "tsnName";
        public const string soapUI = "soapUI";
        public Form1()
        {
            InitializeComponent();
            lblUserRede.Text = "UserName: " + Environment.UserName;
            lblHostname.Text = "HostName  " + Environment.MachineName;
            textBox1.TabStop = false;
        }


        public void lerHtmlDocker()
        {
            WebRequest request = WebRequest.Create("https://www.youtube.com/results?search_query=123");
            request.Credentials = CredentialCache.DefaultCredentials;
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);

            // Read the content.
            string responseFromServer = reader.ReadToEnd();


            lblVariable.Text = responseFromServer;
            // Display the content.
           // Console.WriteLine(responseFromServer);
            response.Close();
        }

        private void btnVariable_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                String pathVariable = dialog.FileName;
                textBox1.Text = pathVariable;

            }
            else
            {
                MessageBox.Show("Choose file Variables.py path", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void lblVariable_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                String pathVariable = dialog.FileName;
                txtTnsName.Text = pathVariable;

            }
            else
            {
                MessageBox.Show("Choose file tnsName.ora path", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string urlAddress = "http://bolaoguaty.somee.com";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlAddress);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                Stream receiveStream = response.GetResponseStream();
                StreamReader readStream = null;

                if (response.CharacterSet == null)
                {
                    readStream = new StreamReader(receiveStream);
                }
                else
                {
                    readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
                }

                string data = readStream.ReadToEnd();

                response.Close();
                readStream.Close();
            }



        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnSoapUI_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                String pathVariable = dialog.FileName;
                txtSoapUi.Text = pathVariable;

            }
            else
            {
                MessageBox.Show("Choose file SOAPUI.properties path", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtWatch.Text = DateTime.Now.ToLongTimeString();
        }

        private void lblUserRede_Click(object sender, EventArgs e)
        {

        }

        private void btnReplaceFiles_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty && txtTnsName.Text != string.Empty && txtSoapUi.Text != string.Empty)
            {
                FileConfig oFiles = new FileConfig();
                Variable oConfiguraFile = new Variable();
                oFiles.fileNameVariable = variable;
                oFiles.filePathVariable = textBox1.Text;

                oFiles.fileNameTsn = tsnName;
                oFiles.filePathTsn = txtTnsName.Text;

                oFiles.fileNameSoap = soapUI;
                oFiles.filePathSoap = txtSoapUi.Text;




                oConfiguraFile.ReplaceAllFiles(oFiles);

            }
            else
            {
                MessageBox.Show("All file path must be filled", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnClearData_Click(object sender, EventArgs e)
        {

        }
    }
}
