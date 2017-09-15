using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;

using System.Net;
using System.Text;

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
            hiddenLinks();


        }

        public void hiddenLinks()
        {
            lnkCX.Visible = false;
            linkAdmx.Visible = false;
            linkAX.Visible = false;
            linkBP.Visible = false;
            linkDCX.Visible = false;
            linkWex.Visible = false;
            linkCPX.Visible = false;
           
        }

        public void showLinks()
        {
            lnkCX.Visible = true;
            linkAdmx.Visible = true;
            linkAX.Visible = true;
            linkBP.Visible = true;
            linkDCX.Visible = true;
            linkWex.Visible = true;
            linkCPX.Visible = true;

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


            if (chkNotUsed.Checked == false || chkSoap.Checked == false || chkTns.Checked == false)
            {

                if (!(nomeFileVariable[nomeFileVariable.Length - 1] == "variables.py" && nomeFileTsnName[nomeFileTsnName.Length - 1] == "tnsnames.ora" && nomeFileSoap[nomeFileSoap.Length - 1] == "soapui.properties"))
                {
                    errorProvider1.SetError(textBox1, "Must be variables.py path");
                    errorProvider1.SetError(txtTnsName, "Must be tnsnames.ora path");
                    errorProvider1.SetError(txtSoapUi, "Must be soapui.properties path");

                    MessageBox.Show("File name wrong, please to check file name choosen (variable,tsnames and soapui)  !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (textBox1.Text != string.Empty && txtTnsName.Text != string.Empty && txtSoapUi.Text != string.Empty && textBox4.Text != string.Empty &&
                    txtSoapUiPath.Text != string.Empty && txtOnlinePath.Text != string.Empty)
                {
                    errorProvider1.Clear();
                    FileConfig oFiles = new FileConfig();

                    oFiles.fileNameVariable = variable;
                    oFiles.filePathVariable = textBox1.Text;

                    oFiles.fileNameTsn = tsnName;
                    oFiles.filePathTsn = txtTnsName.Text;

                    oFiles.fileNameSoap = soapUI;
                    oFiles.filePathSoap = txtSoapUi.Text;

                    bool validaReplace = false;



                    validaReplace = oConfiguraFile.ReplaceAllFiles(oFiles, textBox4.Text.Trim(), txtSoapUiPath.Text.Trim(), txtOnlinePath.Text.Trim(),chkSoap.Checked,chkNotUsed.Checked,chkTns.Checked);



                    if (validaReplace)
                    {
                        MessageBox.Show("All file were replaced successuflly!!!", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showLinks();
                    }

                }
                else
                {
                    errorProvider1.SetError(textBox1, string.Empty);
                    errorProvider1.SetError(txtTnsName, string.Empty);
                    errorProvider1.SetError(txtSoapUi, string.Empty);
                    if (textBox4.Text == string.Empty)
                    {
                        errorProvider1.SetError(textBox4, "Please fill the required field");
                    }
                    MessageBox.Show("All file path must be filled", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                }
            }
            else
            {
                MessageBox.Show("Please choose at least one file for replace!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            hiddenLinks();
            
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

        private void lnkCX_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        
            // Navigate to a URL.
            System.Diagnostics.Process.Start(Variable.CX_URL);

        }

        private void linkBP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            // Navigate to a URL.
            System.Diagnostics.Process.Start(Variable.BP_URL);
        }

        private void linkAX_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
          
            // Navigate to a URL.
            System.Diagnostics.Process.Start(Variable.AX_URL);
        }

        private void linkDCX_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
         

            // Navigate to a URL.
            System.Diagnostics.Process.Start(Variable.DCX_URL);
        }

        private void linkCPX_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
         
            // Navigate to a URL.
            System.Diagnostics.Process.Start(Variable.CPX_URL);
        }

        private void linkAdmx_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            // Navigate to a URL.
            System.Diagnostics.Process.Start(Variable.ADMX_URL);
        }

        private void linkWex_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          

            // Navigate to a URL.
            System.Diagnostics.Process.Start(Variable.WEX_URL);
        }
    }
}
