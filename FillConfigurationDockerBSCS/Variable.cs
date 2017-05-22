using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FillConfigurationDockerBSCS
{
    public class Variable
    {
        public string variablesPath { get; set; }
        public string soapPath { get; set; }
        public string tnsnamesPath { get; set; }
        public string urlDocker { get; set; }
        public string dbHost { get; set; }
        public string hostUrl { get; set; }
        public string dbUser { get; set; }
        public string dbName { get; set; }
        public string dbPassword { get; set; }
        public string dbPort { get; set; }
        public string unixUser { get; set; }
        public string unixPass { get; set; }
        public string sshPort { get; set; }
        public string webClientsPort { get; set; }
        public string webServicesPort { get; set; }
        public string binSoapUiPath { get; set; }
        public string onlineWin32Path { get; set; }


        public const string variableTemplate = "variables_template.txt";
        public const string soapui_template = "soapui_template.txt";
        public const string tnsnames_template = "tnsnames_template.txt";

        public Variable loadInfoDocker(string urlDocker)
        {
            Variable oVariablesLoad = new Variable();
            try
            {
              
                WebRequest request = WebRequest.Create(string.Concat(urlDocker, "environment.html"));
                request.Credentials = CredentialCache.DefaultCredentials;
                WebResponse response = request.GetResponse();
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);

                string str = "";
                string finalString = "";
                while (str != null)
                {
                    finalString = finalString + str;
                    str = reader.ReadLine();
                }
                response.Close();
                RegexOptions options = RegexOptions.None;
                Regex regex = new Regex("[ ]{2,}", options);


                finalString = finalString.Replace("<pre>Runtime environment details---------------------------", "");
                finalString = finalString.Replace("Database name, server, port:", "").Replace("Server name:", "").Replace("Web services port:", "").Replace("Web clients port:", "");
                finalString = finalString.Replace("SSH access to CBIO container (password=test): ssh", "").Replace("</pre>", "").Replace("-p", "").Replace(",", "");
                finalString = regex.Replace(finalString, " ");

                string[] infoServerBySpace = finalString.Trim().Split(' ');

                oVariablesLoad.urlDocker = string.Concat(urlDocker, "environment.html");
                oVariablesLoad.dbName = infoServerBySpace[0];
                oVariablesLoad.dbHost = infoServerBySpace[1];
                oVariablesLoad.dbUser = "SYSADM";
                oVariablesLoad.dbPassword = "SYSADM";
                oVariablesLoad.dbPort = infoServerBySpace[2];
                oVariablesLoad.hostUrl = infoServerBySpace[3];
                oVariablesLoad.webServicesPort = infoServerBySpace[4];
                oVariablesLoad.webClientsPort = infoServerBySpace[5];
                oVariablesLoad.unixUser = infoServerBySpace[6];
                oVariablesLoad.sshPort = infoServerBySpace[7];
                oVariablesLoad.unixPass = "test";

                
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                MessageBox.Show(message);
            }
            return oVariablesLoad;


        }
        public bool ReplaceAllFiles(FileConfig oFile, string urlDocker, string onlinePath, string binSoapUiPAth)
        {
            bool checkVariable = false;
            bool checkSoap = false;
            bool checkTsn = false;
            try
            {
                Variable oVariablesLoad = new Variable();
                WebRequest request = WebRequest.Create(string.Concat(urlDocker, "environment.html"));
                request.Credentials = CredentialCache.DefaultCredentials;
                WebResponse response = request.GetResponse();
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string str = "";
                string finalString = "";
                while (str != null)
                {
                    finalString = finalString + str;
                    str = reader.ReadLine();
                }
                response.Close();
                RegexOptions options = RegexOptions.None;
                Regex regex = new Regex("[ ]{2,}", options);


                finalString = finalString.Replace("<pre>Runtime environment details---------------------------", "");
                finalString = finalString.Replace("Database name, server, port:", "").Replace("Server name:", "").Replace("Web services port:", "").Replace("Web clients port:", "");
                finalString = finalString.Replace("SSH access to CBIO container (password=test): ssh", "").Replace("</pre>", "").Replace("-p", "").Replace(",", "");
                finalString = regex.Replace(finalString, " ");

                string[] infoServerBySpace = finalString.Trim().Split(' ');

                oVariablesLoad.urlDocker = string.Concat(urlDocker, "environment.html");
                oVariablesLoad.dbName = infoServerBySpace[0];
                oVariablesLoad.dbHost = infoServerBySpace[1];
                oVariablesLoad.dbUser = "SYSADM";
                oVariablesLoad.dbPassword = "SYSADM";
                oVariablesLoad.dbPort = infoServerBySpace[2];
                oVariablesLoad.hostUrl = infoServerBySpace[3];
                oVariablesLoad.webServicesPort = infoServerBySpace[4];
                oVariablesLoad.webClientsPort = infoServerBySpace[5];
                oVariablesLoad.unixUser = infoServerBySpace[6].Split('@')[0];
                oVariablesLoad.sshPort = infoServerBySpace[7];
                oVariablesLoad.unixPass = "test";
                oVariablesLoad.onlineWin32Path = onlinePath;
                oVariablesLoad.binSoapUiPath = binSoapUiPAth;
                oVariablesLoad.variablesPath = oFile.filePathVariable;
                oVariablesLoad.tnsnamesPath = oFile.filePathTsn;
                oVariablesLoad.soapPath = oFile.filePathSoap;

                 checkVariable = replaceByFile(oFile.filePathVariable, variableTemplate, oVariablesLoad);
                 checkSoap = replaceByFile(oFile.filePathSoap, soapui_template, oVariablesLoad);
                 checkTsn = replaceByFile(oFile.filePathTsn, tnsnames_template, oVariablesLoad);

                
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                MessageBox.Show(message);
            }


            if (checkVariable && checkSoap && checkTsn)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
         
        public bool replaceByFile(string filePath, string fileTemplatePath, Variable oVariables)
        {

            string pathFileTemplate = AppDomain.CurrentDomain.BaseDirectory + fileTemplatePath;
            string message = "";
            try
            {
                using (var input = File.OpenText(pathFileTemplate))
                using (var output = new StreamWriter(filePath))
                {
                    string line;
                    while (null != (line = input.ReadLine()))
                    {

                        line = line.Replace("<hostUrl>", oVariables.hostUrl).Replace("<dbHost>", oVariables.dbHost)
                                   .Replace("<dbUser>", oVariables.dbUser).Replace("<dbName>", oVariables.dbName)
                                   .Replace("<dbPassword>", oVariables.dbPassword).Replace("<dbPort>", oVariables.dbPort)
                                   .Replace("<unixUser>", oVariables.unixUser).Replace("<unixPass>", oVariables.unixPass)
                                   .Replace("<sshPort>", oVariables.sshPort).Replace("<webClientsPort>", oVariables.webClientsPort)
                                   .Replace("<webServicesPort>", oVariables.webServicesPort).Replace("<binSoapUiPath>", oVariables.binSoapUiPath)
                                   .Replace("<onlineWin32Path>", oVariables.onlineWin32Path);

                        output.WriteLine(line);
                    }

                   
                }
             
            }
            catch (Exception e)
            {
               
                message = e.Message;
                MessageBox.Show(message);
                return false;
            }
            return true;

        }
    }

    
   
}
