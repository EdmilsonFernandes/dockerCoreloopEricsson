#General
DELAY = 0
SOIVERSION="CIL_7"
#Web
BROWSER = "ff"
WEBSERVER = "rocker.lhs-systems.com" 
WEBPORT = "33416"
CXAPPNAME = "custcare_cu"
LOGINURL_CX  = WEBSERVER + ":" + WEBPORT + "/" + CXAPPNAME
USER = "AUT"
PASSWORD = "AUT"
BP_URL = "http://rocker.lhs-systems.com:33416/custcare_bp/login"
BP_USER = "AUT"
BP_PASSWORD = "AUT"
CX_URL = "http://rocker.lhs-systems.com:33416/custcare_cu/login"
CX_USER = "AUT"
CX_PASSWORD = "AUT"
CPX_URL = "http://rocker.lhs-systems.com:33416/cpx/login"
CPX_USER = "AUT"
CPX_PASSWORD = "AUT"
AX_URL = "http://rocker.lhs-systems.com:33416/ax_full/login"
AX_USER = "AUT"
AX_PASSWORD = "AUT"
ADMX_URL = "http://rocker.lhs-systems.com:33416/admx_full/login"
ADMX_USER = "AUT"
ADMX_PASSWORD = "AUT"
WEX_URL = "http://rocker.lhs-systems.com:33416/wex/login"
WEX_USER = "AUT"
WEX_PASSWORD = "AUT"
POS_URL = "http://rocker.lhs-systems.com:33416/custcare_pos/login"
POS_USER = "AUT"
POS_PASSWORD = "AUT"
DCX_URL="http://rocker.lhs-systems.com:33416/dcx/login"
DCX_USER="AUT"
DCX_PASSWORD="AUT"
#WebService
TESTLIB = "C:/Data/gitViews/fullstack/GIT_main/lhsj_main/bscs/tests/CBIO/webservice/funlib"
FUNLIB = TESTLIB + "/funLib.xml"
ENDPOINT = "rocker.lhs-systems.com:33415"
SOAPUI_HOME = "H:\AMX Online\bin\win32"
#Online
ONLINEPATH="H:/SoapUI5/bin/"
DATABASE_NAME="bscsdb"
EI_USER="AUT"
EI_PASSWORD="AUT"
ER_USER="AUT"
ER_PASSWORD="AUT"
GL_USER="AUT"
GL_PASSWORD="AUT"
MI_USER="AUT"
MI_PASSWORD="AUT"
PX_USER="AUT"
PX_PASSWORD="AUT"
RA_USER="AUT"
RA_PASSWORD="AUT"
RD_USER="AUT"
RD_PASSWORD="AUT"
TA_USER="AUT"
TA_PASSWORD="AUT"
TR_USER="AUT"
TR_PASSWORD="AUT"
#Batch
UNIX_HOST = "rocker.lhs-systems.com"
UNIX_USERNAME = "root@rocker.lhs-systems.com"
UNIX_PASSWORD = "test"
SHIPMENT_PATH = "/cbio"
TEST_PATH = "/cbio/Automation"
UNIX_PROMPT = "robotssh$"
ENV_FILE = "/cbio/start-env.sh"
SSH_PORT = 33417
#Database
DBUSERNAME = "SYSADM"
DBPASSWORD = "SYSADM"
DBHOST = "rocker.lhs-systems.com"
DBPORT = 33414
DBSID = "bscsdb"

#Variables for KW Compatibility: Not used on TMO
MX_URL = "http://mx_dummy.com:18081/dummy/login"
