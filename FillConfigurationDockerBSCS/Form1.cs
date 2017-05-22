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
        Variable oConfiguraFile = new Variable();
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
                if (textBox1.Text != string.Empty)
                {
                    //To do nothing here
                }
                else
                {
                    MessageBox.Show("Choose file Variables.py path", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
                if (txtTnsName.Text != string.Empty)
                {
                    //To do nothing here
                }
                else
                {
                    MessageBox.Show("Choose file tnsName.ora path", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
               
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
                if (txtSoapUi.Text != string.Empty)
                {
                    //To do nothing here
                }
                else
                {
                    MessageBox.Show("Choose file SOAPUI.properties path", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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

            string[] nomeFileVariable = textBox1.Text.Split('\\');
            string[] nomeFileTsnName = txtTnsName.Text.Split('\\');
            string[] nomeFileSoap = txtSoapUi.Text.Split('\\');

            if (!(nomeFileVariable[nomeFileVariable.Length -1] == "variables.py" && nomeFileTsnName[nomeFileTsnName.Length-1] == "tnsnames.ora" && nomeFileSoap[nomeFileSoap.Length-1] == "soapui.properties"))
            {

                MessageBox.Show("File name wrong, please to check file name choosen (variable,tsnames and soapui)  !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if(textBox1.Text != string.Empty && txtTnsName.Text != string.Empty && txtSoapUi.Text != string.Empty && textBox4.Text != string.Empty && 
                txtSoapUiPath.Text != string.Empty && txtOnlinePath.Text != string.Empty)
            {
                FileConfig oFiles = new FileConfig();
             
                oFiles.fileNameVariable = variable;
                oFiles.filePathVariable = textBox1.Text;

                oFiles.fileNameTsn = tsnName;
                oFiles.filePathTsn = txtTnsName.Text;

                oFiles.fileNameSoap = soapUI;
                oFiles.filePathSoap = txtSoapUi.Text;




               bool validaReplace =  oConfiguraFile.ReplaceAllFiles(oFiles, textBox4.Text.Trim(), txtSoapUiPath.Text.Trim(), txtOnlinePath.Text.Trim());

                if (validaReplace)
                {
                    MessageBox.Show("All file were replaced successuflly!!!", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("All file path must be filled", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnClearData_Click(object sender, EventArgs e)
        {
            txtHostUnix.Text = string.Empty;
            txtUnixUser.Text = string.Empty;
            txtUnixPassword.Text = string.Empty;
            txtSshPort.Text = string.Empty;
            txtDbUser.Text = string.Empty;
            txtDatabaseHost.Text = string.Empty;
            txtDbName.Text = string.Empty;
            txtDbPort.Text = string.Empty;
            TxtDbPwd.Text = string.Empty;
            textBox4.Text = string.Empty;
            txtTnsName.Text = string.Empty;
            txtSoapUi.Text = string.Empty;
            textBox1.Text = string.Empty;
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_Leave(object sender, EventArgs e)
        {

            try
            {
                oConfiguraFile = oConfiguraFile.loadInfoDocker(textBox4.Text.Trim());
                txtHostUnix.Text = oConfiguraFile.hostUrl;
                txtUnixUser.Text = oConfiguraFile.unixUser.Split('@')[0];
                txtUnixPassword.Text = oConfiguraFile.unixPass;
                txtSshPort.Text = oConfiguraFile.sshPort;
                txtDbUser.Text = oConfiguraFile.dbUser;
                txtDatabaseHost.Text = oConfiguraFile.dbHost;
                txtDbName.Text = oConfiguraFile.dbName;
                txtDbPort.Text = oConfiguraFile.dbPort;
                TxtDbPwd.Text = oConfiguraFile.dbPassword;


                txtWebServicePort.Text = oConfiguraFile.webServicesPort;
                txtWbClientPort.Text = oConfiguraFile.webClientsPort;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           


          
        }

        private void btnDownloadVariable_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                int count = 0;
                string[] FilenameName;
                foreach (string item in openFileDialog1.FileNames)
                {
                    FilenameName = item.Split('\\');
                    File.Copy(item, @"C:\Users\samer\Desktop\Files\" + FilenameName[FilenameName.Length - 1]);
                    count++;
                }
            }
        }
    }
}
