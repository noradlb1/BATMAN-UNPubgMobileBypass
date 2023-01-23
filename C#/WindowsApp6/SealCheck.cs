using System;
using System.IO;
using System.Security.Cryptography;

namespace WindowsApp6.Seal
{
    class SealCheck
    {
        public static bool isValidDLL = false;

        public static void HashChecks()
        {
            // If CalculateMD5("Newtonsoft.Json.dll") <> "ae683e40c544859083b2b99e623fc0a1" OrElse CalculateMD5(GetType(LOGIN.Seal).Assembly.Location) <> "ae683e40c544859083b2b99e623fc0a1" Then
            // MessageBox.Show("Hash check failed. Exiting...", "TrinitySeal", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            // Process.GetCurrentProcess().Kill()
            // Else
            isValidDLL = true;
            // End If
        }

        private static string CalculateMD5(string filename)
        {
            using (var md = MD5.Create())
            {

                using (var stream = File.OpenRead(filename))
                {
                    byte[] hash = md.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }
    }
}