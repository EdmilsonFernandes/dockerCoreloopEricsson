using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FillConfigurationDockerBSCS
{
    public class Variable
    {
        private string variablesPath { get; set; }
        private string soapPath { get; set; }
        private string tnsnamesPath { get; set; }
        private string urlDocker { get; set; }
        private string dbHost { get; set; }
        private string hostUrl { get; set; }
        private string dbUser { get; set; }
        private string dbName { get; set; }
        private string dbPassword { get; set; }
        private string dbPort { get; set; }
        private string unixUser { get; set; }
        private string unixPass { get; set; }
        private string sshPort { get; set; }
        private string webClientsPort { get; set; }
        private string webServicesPort { get; set; }
        private string binSoapUiPath { get; set; }
        private string onlineWin32Path { get; set; }


        public const string variableTemplate = "variables_template.txt";
        public const string soapui_template = "soapui_template.txt";
        public const string tnsnames_template = "tnsnames_template.txt";


        public void ReplaceAllFiles(FileConfig oFile)
        {

            WebRequest request = WebRequest.Create("https://www.youtube.com/results?search_query=123");
            request.Credentials = CredentialCache.DefaultCredentials;
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
           
            response.Close();
            string str = "";
            string finalString = "";
            while (str != null)
            {
                finalString = finalString + str;
                str = reader.ReadLine();
            }

            this.dbName = finalString.Split(',')[2].Split(':')[1];
            this.dbHost = finalString.Split(',')[3].Replace(' ',' ');
            this.dbUser = "SYSADM";
            this.dbPassword = "SYSADM";
            finalString = finalString.Split(',')[4];
            //this.dbPort = finalString.Split('Server name: ')[0].Replace(' ', ' ');
            //finalString = finalString.Split('Server name: ')[1];
            //this.hostUrl = finalString.Split('Web services port:')[0];
            //finalString = finalString.Split('Web services port: ')[1];
            //this.webServicesPort = finalString.Split('Web clients port: ')[0];
            //finalString = finalString.Split('Web clients port: ')[1];
            //this.webClientsPort = finalString.Split('Web clients port: ')[0].Split('SSH access to CBIO container ')[0];
            //finalString = finalString.Split('Web clients port: ')[0].Split('SSH access to CBIO container ')[1].Split('=')[1];
            //this.unixPass = finalString.Substring(0, finalString.IndexOf(')'));
            //finalString = finalString.Split('ssh ')[1];
            //this.unixUser = finalString.Split('@')[0];
            //finalString = finalString.Split(' -p ')[1];
            this.sshPort = finalString.Split('<')[0];

            replaceByFile(oFile.filePathVariable, variableTemplate);
            replaceByFile(oFile.filePathSoap, soapui_template);
            replaceByFile(oFile.filePathTsn, tnsnames_template);
            
        }

        public bool replaceByFile(string filePath, string fileTemplatePath)
        {

            try
            {
                using (var input = File.OpenText(fileTemplatePath))
                using (var output = new StreamWriter(filePath))
                {
                    string line;
                    while (null != (line = input.ReadLine()))
                    {

                        line =  line.Replace("<hostUrl>", this.hostUrl).Replace("<dbHost>", this.dbHost).Replace("<dbUser>", this.dbUser).Replace("<dbName>", this.dbName).Replace("<dbPassword>", this.dbPassword).Replace("<dbPort>", this.dbPort).Replace("<unixUser>", this.unixUser).Replace("<unixPass>", this.unixPass).Replace("<sshPort>", this.sshPort).Replace("<webClientsPort>", this.webClientsPort).Replace("<webServicesPort>", webServicesPort).Replace("<binSoapUiPath>", this.binSoapUiPath).Replace("<onlineWin32Path>", this.onlineWin32Path);
                    }
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }


        }
    }

    
    public class ListVariables:List<Variable>
    {

    }
}
