﻿namespace FillConfigurationDockerBSCS
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblVariable = new System.Windows.Forms.Label();
            this.btnTsnName = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTnsName = new System.Windows.Forms.TextBox();
            this.btnSoapUI = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoapUi = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnVariable = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClearData = new System.Windows.Forms.Button();
            this.btnReplaceFiles = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtWebServicePort = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtOnlinePath = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtWbClientPort = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtSoapUiPath = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtDbPwd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDbUser = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDbPort = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDbName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDatabaseHost = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSshPort = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUnixPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUnixUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHostUnix = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtWatch = new System.Windows.Forms.TextBox();
            this.lblUserRede = new System.Windows.Forms.Label();
            this.lblHostname = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lnkCX = new System.Windows.Forms.LinkLabel();
            this.linkBP = new System.Windows.Forms.LinkLabel();
            this.linkAX = new System.Windows.Forms.LinkLabel();
            this.linkDCX = new System.Windows.Forms.LinkLabel();
            this.linkCPX = new System.Windows.Forms.LinkLabel();
            this.linkAdmx = new System.Windows.Forms.LinkLabel();
            this.linkWex = new System.Windows.Forms.LinkLabel();
            this.chkNotUsed = new System.Windows.Forms.CheckBox();
            this.chkTns = new System.Windows.Forms.CheckBox();
            this.chkSoap = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(16, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(748, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "C:\\Data\\gitViews\\fullstack\\GIT_main\\lhsj_main\\bscs\\tests\\robotScripts\\src\\main\\te" +
    "stcases\\variables.py";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblVariable
            // 
            this.lblVariable.AutoSize = true;
            this.lblVariable.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVariable.Location = new System.Drawing.Point(12, 30);
            this.lblVariable.Name = "lblVariable";
            this.lblVariable.Size = new System.Drawing.Size(177, 22);
            this.lblVariable.TabIndex = 1;
            this.lblVariable.Text = "Variables.py file path";
            this.lblVariable.Click += new System.EventHandler(this.lblVariable_Click);
            // 
            // btnTsnName
            // 
            this.btnTsnName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTsnName.Location = new System.Drawing.Point(781, 110);
            this.btnTsnName.Name = "btnTsnName";
            this.btnTsnName.Size = new System.Drawing.Size(184, 34);
            this.btnTsnName.TabIndex = 5;
            this.btnTsnName.Text = "search file tnsname.ora";
            this.btnTsnName.UseVisualStyleBackColor = true;
            this.btnTsnName.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tsname.ora file path";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTnsName
            // 
            this.txtTnsName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTnsName.Location = new System.Drawing.Point(16, 118);
            this.txtTnsName.Name = "txtTnsName";
            this.txtTnsName.Size = new System.Drawing.Size(748, 23);
            this.txtTnsName.TabIndex = 3;
            this.txtTnsName.Text = "C:\\Robot\\TNS_ADMIN\\tnsnames.ora";
            this.txtTnsName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnSoapUI
            // 
            this.btnSoapUI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoapUI.Location = new System.Drawing.Point(781, 169);
            this.btnSoapUI.Name = "btnSoapUI";
            this.btnSoapUI.Size = new System.Drawing.Size(184, 36);
            this.btnSoapUI.TabIndex = 8;
            this.btnSoapUI.Text = "search file soapui";
            this.btnSoapUI.UseVisualStyleBackColor = true;
            this.btnSoapUI.Click += new System.EventHandler(this.btnSoapUI_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Soapui.properties file path";
            // 
            // txtSoapUi
            // 
            this.txtSoapUi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoapUi.Location = new System.Drawing.Point(16, 178);
            this.txtSoapUi.Name = "txtSoapUi";
            this.txtSoapUi.Size = new System.Drawing.Size(748, 23);
            this.txtSoapUi.TabIndex = 6;
            this.txtSoapUi.Text = "H:\\SoapUI5\\bin\\soapui.properties";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.chkSoap);
            this.groupBox1.Controls.Add(this.chkNotUsed);
            this.groupBox1.Controls.Add(this.chkTns);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.btnSoapUI);
            this.groupBox1.Controls.Add(this.lblVariable);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnVariable);
            this.groupBox1.Controls.Add(this.txtSoapUi);
            this.groupBox1.Controls.Add(this.txtTnsName);
            this.groupBox1.Controls.Add(this.btnTsnName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1103, 229);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1º - Configure File path to the Robot";
            // 
            // btnVariable
            // 
            this.btnVariable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVariable.Location = new System.Drawing.Point(781, 51);
            this.btnVariable.Name = "btnVariable";
            this.btnVariable.Size = new System.Drawing.Size(184, 37);
            this.btnVariable.TabIndex = 2;
            this.btnVariable.Text = "search file variable.py";
            this.btnVariable.UseVisualStyleBackColor = true;
            this.btnVariable.Click += new System.EventHandler(this.btnVariable_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.btnClearData);
            this.groupBox2.Controls.Add(this.btnReplaceFiles);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 247);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1103, 446);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2º - Coreloop URL - Enviromment";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnClearData
            // 
            this.btnClearData.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnClearData.Location = new System.Drawing.Point(795, 264);
            this.btnClearData.Name = "btnClearData";
            this.btnClearData.Size = new System.Drawing.Size(221, 31);
            this.btnClearData.TabIndex = 31;
            this.btnClearData.Text = "Clear all data";
            this.btnClearData.UseVisualStyleBackColor = false;
            this.btnClearData.Click += new System.EventHandler(this.btnClearData_Click);
            // 
            // btnReplaceFiles
            // 
            this.btnReplaceFiles.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnReplaceFiles.Location = new System.Drawing.Point(795, 181);
            this.btnReplaceFiles.Name = "btnReplaceFiles";
            this.btnReplaceFiles.Size = new System.Drawing.Size(229, 56);
            this.btnReplaceFiles.TabIndex = 30;
            this.btnReplaceFiles.Text = "3º - Set up environment";
            this.btnReplaceFiles.UseVisualStyleBackColor = false;
            this.btnReplaceFiles.Click += new System.EventHandler(this.btnReplaceFiles_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.txtWebServicePort);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.txtOnlinePath);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.txtWbClientPort);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.txtSoapUiPath);
            this.groupBox5.Location = new System.Drawing.Point(6, 276);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(451, 161);
            this.groupBox5.TabIndex = 25;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Info - Geral";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(319, 86);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 15);
            this.label13.TabIndex = 29;
            this.label13.Text = "Web Services Port";
            // 
            // txtWebServicePort
            // 
            this.txtWebServicePort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWebServicePort.Enabled = false;
            this.txtWebServicePort.Location = new System.Drawing.Point(328, 104);
            this.txtWebServicePort.Name = "txtWebServicePort";
            this.txtWebServicePort.ReadOnly = true;
            this.txtWebServicePort.Size = new System.Drawing.Size(80, 26);
            this.txtWebServicePort.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 86);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 15);
            this.label14.TabIndex = 27;
            this.label14.Text = "Online Bin Path";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // txtOnlinePath
            // 
            this.txtOnlinePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOnlinePath.Location = new System.Drawing.Point(6, 104);
            this.txtOnlinePath.Name = "txtOnlinePath";
            this.txtOnlinePath.Size = new System.Drawing.Size(287, 26);
            this.txtOnlinePath.TabIndex = 26;
            this.txtOnlinePath.Text = "H:\\AMX Online\\bin\\win32";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(319, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 15);
            this.label12.TabIndex = 25;
            this.label12.Text = "Web Clients Port";
            // 
            // txtWbClientPort
            // 
            this.txtWbClientPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWbClientPort.Enabled = false;
            this.txtWbClientPort.Location = new System.Drawing.Point(328, 49);
            this.txtWbClientPort.Name = "txtWbClientPort";
            this.txtWbClientPort.ReadOnly = true;
            this.txtWbClientPort.Size = new System.Drawing.Size(81, 26);
            this.txtWbClientPort.TabIndex = 24;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(6, 31);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(112, 15);
            this.label16.TabIndex = 17;
            this.label16.Text = "SoapUI Bin Path";
            // 
            // txtSoapUiPath
            // 
            this.txtSoapUiPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoapUiPath.Location = new System.Drawing.Point(6, 49);
            this.txtSoapUiPath.Name = "txtSoapUiPath";
            this.txtSoapUiPath.Size = new System.Drawing.Size(287, 26);
            this.txtSoapUiPath.TabIndex = 16;
            this.txtSoapUiPath.Text = "H:/SoapUI5/bin/";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.TxtDbPwd);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtDbUser);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtDbPort);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txtDbName);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txtDatabaseHost);
            this.groupBox4.Location = new System.Drawing.Point(6, 170);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(648, 100);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Info - Database Server";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(545, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 15);
            this.label11.TabIndex = 25;
            this.label11.Text = "DB Password";
            // 
            // TxtDbPwd
            // 
            this.TxtDbPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtDbPwd.Enabled = false;
            this.TxtDbPwd.Location = new System.Drawing.Point(543, 49);
            this.TxtDbPwd.Name = "TxtDbPwd";
            this.TxtDbPwd.ReadOnly = true;
            this.TxtDbPwd.Size = new System.Drawing.Size(94, 26);
            this.TxtDbPwd.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(447, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "DB User";
            // 
            // txtDbUser
            // 
            this.txtDbUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDbUser.Enabled = false;
            this.txtDbUser.Location = new System.Drawing.Point(445, 49);
            this.txtDbUser.Name = "txtDbUser";
            this.txtDbUser.ReadOnly = true;
            this.txtDbUser.Size = new System.Drawing.Size(81, 26);
            this.txtDbUser.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(306, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "DB Port";
            // 
            // txtDbPort
            // 
            this.txtDbPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDbPort.Enabled = false;
            this.txtDbPort.Location = new System.Drawing.Point(309, 49);
            this.txtDbPort.Name = "txtDbPort";
            this.txtDbPort.ReadOnly = true;
            this.txtDbPort.Size = new System.Drawing.Size(126, 26);
            this.txtDbPort.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(211, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 15);
            this.label9.TabIndex = 19;
            this.label9.Text = "DB Name";
            // 
            // txtDbName
            // 
            this.txtDbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDbName.Enabled = false;
            this.txtDbName.Location = new System.Drawing.Point(214, 49);
            this.txtDbName.Name = "txtDbName";
            this.txtDbName.ReadOnly = true;
            this.txtDbName.Size = new System.Drawing.Size(77, 26);
            this.txtDbName.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 15);
            this.label10.TabIndex = 17;
            this.label10.Text = "Database Host";
            // 
            // txtDatabaseHost
            // 
            this.txtDatabaseHost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDatabaseHost.Enabled = false;
            this.txtDatabaseHost.Location = new System.Drawing.Point(6, 49);
            this.txtDatabaseHost.Name = "txtDatabaseHost";
            this.txtDatabaseHost.ReadOnly = true;
            this.txtDatabaseHost.Size = new System.Drawing.Size(202, 26);
            this.txtDatabaseHost.TabIndex = 16;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtSshPort);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtUnixPassword);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtUnixUser);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtHostUnix);
            this.groupBox3.Location = new System.Drawing.Point(6, 64);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(648, 100);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Info - Unix Server";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(428, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "SSH Port";
            // 
            // txtSshPort
            // 
            this.txtSshPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSshPort.Enabled = false;
            this.txtSshPort.Location = new System.Drawing.Point(431, 49);
            this.txtSshPort.Name = "txtSshPort";
            this.txtSshPort.ReadOnly = true;
            this.txtSshPort.Size = new System.Drawing.Size(62, 26);
            this.txtSshPort.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(306, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "Unix Password";
            // 
            // txtUnixPassword
            // 
            this.txtUnixPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUnixPassword.Enabled = false;
            this.txtUnixPassword.Location = new System.Drawing.Point(309, 49);
            this.txtUnixPassword.Name = "txtUnixPassword";
            this.txtUnixPassword.ReadOnly = true;
            this.txtUnixPassword.Size = new System.Drawing.Size(99, 26);
            this.txtUnixPassword.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(211, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Unix User";
            // 
            // txtUnixUser
            // 
            this.txtUnixUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUnixUser.Enabled = false;
            this.txtUnixUser.Location = new System.Drawing.Point(214, 49);
            this.txtUnixUser.Name = "txtUnixUser";
            this.txtUnixUser.ReadOnly = true;
            this.txtUnixUser.Size = new System.Drawing.Size(65, 26);
            this.txtUnixUser.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Host Unix";
            // 
            // txtHostUnix
            // 
            this.txtHostUnix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHostUnix.Enabled = false;
            this.txtHostUnix.Location = new System.Drawing.Point(6, 49);
            this.txtHostUnix.Name = "txtHostUnix";
            this.txtHostUnix.ReadOnly = true;
            this.txtHostUnix.Size = new System.Drawing.Size(202, 26);
            this.txtHostUnix.TabIndex = 16;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(6, 35);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(859, 26);
            this.textBox4.TabIndex = 0;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.textBox4.Leave += new System.EventHandler(this.textBox4_Leave);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtWatch
            // 
            this.txtWatch.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtWatch.Location = new System.Drawing.Point(1124, 21);
            this.txtWatch.Name = "txtWatch";
            this.txtWatch.ReadOnly = true;
            this.txtWatch.Size = new System.Drawing.Size(57, 20);
            this.txtWatch.TabIndex = 32;
            // 
            // lblUserRede
            // 
            this.lblUserRede.AutoSize = true;
            this.lblUserRede.Location = new System.Drawing.Point(1121, 51);
            this.lblUserRede.Name = "lblUserRede";
            this.lblUserRede.Size = new System.Drawing.Size(39, 13);
            this.lblUserRede.TabIndex = 33;
            this.lblUserRede.Text = "lblUser";
            this.lblUserRede.Click += new System.EventHandler(this.lblUserRede_Click);
            // 
            // lblHostname
            // 
            this.lblHostname.AutoSize = true;
            this.lblHostname.Location = new System.Drawing.Point(1121, 76);
            this.lblHostname.Name = "lblHostname";
            this.lblHostname.Size = new System.Drawing.Size(37, 13);
            this.lblHostname.TabIndex = 34;
            this.lblHostname.Text = "lblhost";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lnkCX
            // 
            this.lnkCX.AutoSize = true;
            this.lnkCX.Location = new System.Drawing.Point(1121, 123);
            this.lnkCX.Name = "lnkCX";
            this.lnkCX.Size = new System.Drawing.Size(76, 13);
            this.lnkCX.TabIndex = 36;
            this.lnkCX.TabStop = true;
            this.lnkCX.Text = "Open CX Web";
            this.lnkCX.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCX_LinkClicked);
            // 
            // linkBP
            // 
            this.linkBP.AutoSize = true;
            this.linkBP.Location = new System.Drawing.Point(1121, 152);
            this.linkBP.Name = "linkBP";
            this.linkBP.Size = new System.Drawing.Size(76, 13);
            this.linkBP.TabIndex = 37;
            this.linkBP.TabStop = true;
            this.linkBP.Text = "Open BP Web";
            this.linkBP.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkBP_LinkClicked);
            // 
            // linkAX
            // 
            this.linkAX.AutoSize = true;
            this.linkAX.Location = new System.Drawing.Point(1121, 178);
            this.linkAX.Name = "linkAX";
            this.linkAX.Size = new System.Drawing.Size(76, 13);
            this.linkAX.TabIndex = 38;
            this.linkAX.TabStop = true;
            this.linkAX.Text = "Open AX Web";
            this.linkAX.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAX_LinkClicked);
            // 
            // linkDCX
            // 
            this.linkDCX.AutoSize = true;
            this.linkDCX.Location = new System.Drawing.Point(1121, 205);
            this.linkDCX.Name = "linkDCX";
            this.linkDCX.Size = new System.Drawing.Size(84, 13);
            this.linkDCX.TabIndex = 39;
            this.linkDCX.TabStop = true;
            this.linkDCX.Text = "Open DCX Web";
            this.linkDCX.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDCX_LinkClicked);
            // 
            // linkCPX
            // 
            this.linkCPX.AutoSize = true;
            this.linkCPX.Location = new System.Drawing.Point(1121, 232);
            this.linkCPX.Name = "linkCPX";
            this.linkCPX.Size = new System.Drawing.Size(83, 13);
            this.linkCPX.TabIndex = 40;
            this.linkCPX.TabStop = true;
            this.linkCPX.Text = "Open CPX Web";
            this.linkCPX.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCPX_LinkClicked);
            // 
            // linkAdmx
            // 
            this.linkAdmx.AutoSize = true;
            this.linkAdmx.Location = new System.Drawing.Point(1121, 255);
            this.linkAdmx.Name = "linkAdmx";
            this.linkAdmx.Size = new System.Drawing.Size(93, 13);
            this.linkAdmx.TabIndex = 41;
            this.linkAdmx.TabStop = true;
            this.linkAdmx.Text = "Open ADMX Web";
            this.linkAdmx.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAdmx_LinkClicked);
            // 
            // linkWex
            // 
            this.linkWex.AutoSize = true;
            this.linkWex.Location = new System.Drawing.Point(1121, 284);
            this.linkWex.Name = "linkWex";
            this.linkWex.Size = new System.Drawing.Size(87, 13);
            this.linkWex.TabIndex = 42;
            this.linkWex.TabStop = true;
            this.linkWex.Text = "Open WEX Web";
            this.linkWex.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkWex_LinkClicked);
            // 
            // chkNotUsed
            // 
            this.chkNotUsed.AutoSize = true;
            this.chkNotUsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNotUsed.Location = new System.Drawing.Point(971, 55);
            this.chkNotUsed.Name = "chkNotUsed";
            this.chkNotUsed.Size = new System.Drawing.Size(92, 24);
            this.chkNotUsed.TabIndex = 9;
            this.chkNotUsed.Text = "Not used";
            this.chkNotUsed.UseVisualStyleBackColor = true;
            // 
            // chkTns
            // 
            this.chkTns.AutoSize = true;
            this.chkTns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTns.Location = new System.Drawing.Point(971, 117);
            this.chkTns.Name = "chkTns";
            this.chkTns.Size = new System.Drawing.Size(92, 24);
            this.chkTns.TabIndex = 10;
            this.chkTns.Text = "Not used";
            this.chkTns.UseVisualStyleBackColor = true;
            // 
            // chkSoap
            // 
            this.chkSoap.AutoSize = true;
            this.chkSoap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSoap.Location = new System.Drawing.Point(971, 178);
            this.chkSoap.Name = "chkSoap";
            this.chkSoap.Size = new System.Drawing.Size(92, 24);
            this.chkSoap.TabIndex = 10;
            this.chkSoap.Text = "Not used";
            this.chkSoap.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1269, 689);
            this.Controls.Add(this.linkWex);
            this.Controls.Add(this.linkAdmx);
            this.Controls.Add(this.linkCPX);
            this.Controls.Add(this.linkDCX);
            this.Controls.Add(this.linkAX);
            this.Controls.Add(this.linkBP);
            this.Controls.Add(this.lnkCX);
            this.Controls.Add(this.lblHostname);
            this.Controls.Add(this.lblUserRede);
            this.Controls.Add(this.txtWatch);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "FormSetUpDocker";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblVariable;
        private System.Windows.Forms.Button btnVariable;
        private System.Windows.Forms.Button btnTsnName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTnsName;
        private System.Windows.Forms.Button btnSoapUI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoapUi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSshPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUnixPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUnixUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHostUnix;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDbUser;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDbPort;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDbName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDatabaseHost;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtDbPwd;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtWbClientPort;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtSoapUiPath;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtWebServicePort;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtOnlinePath;
        private System.Windows.Forms.Button btnClearData;
        private System.Windows.Forms.Button btnReplaceFiles;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtWatch;
        private System.Windows.Forms.Label lblUserRede;
        private System.Windows.Forms.Label lblHostname;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.LinkLabel linkCPX;
        private System.Windows.Forms.LinkLabel linkDCX;
        private System.Windows.Forms.LinkLabel linkAX;
        private System.Windows.Forms.LinkLabel linkBP;
        private System.Windows.Forms.LinkLabel lnkCX;
        private System.Windows.Forms.LinkLabel linkWex;
        private System.Windows.Forms.LinkLabel linkAdmx;
        private System.Windows.Forms.CheckBox chkNotUsed;
        private System.Windows.Forms.CheckBox chkTns;
        private System.Windows.Forms.CheckBox chkSoap;
    }
}

