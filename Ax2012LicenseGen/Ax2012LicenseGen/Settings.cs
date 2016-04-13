using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Ax2012LicenseGen
{
    [Serializable]
    public class Settings
    {
        public string CertificatePath { get; set; }
        public string AxUtilLocation { get; set; }
        public string OutfilePrefix { get; set; }
        public string DefaultOutPath { get; set; }
        public string CertificatePassword { get; set; }

        private static Settings _settings;

        private Settings() { }

        public static Settings GetInstance()
        {
            if (_settings == null)
            {
                _settings = Serializer.Deserialize<Settings>();
                if (_settings == null)
                    _settings = new Settings() { OutfilePrefix = "LIC" };
                
            }
            return _settings;
        }

        public static void Save()
        {
            Serializer.Serialize(_settings);
        }

        public void SetPassword(string password)
        {
            _settings.CertificatePassword = Serializer.Base64Encode(password);
        }
        public void SetCertificatePath(string path)
        {
            _settings.CertificatePath = Serializer.Base64Encode(path);
        }

        public string GetCertificatePassword()
        {
            return Serializer.Base64Decode(_settings.CertificatePassword);
        }
        public string GetCerificatePath()
        {
            return Serializer.Base64Decode(_settings.CertificatePath);
        }

    }

    public static class Serializer
    {
        public static void Serialize<T>(T obj)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            StreamWriter writer = new StreamWriter(typeof(T).Name + ".xml");
            serializer.Serialize(writer, obj);
            writer.Close();
        }

        public static T Deserialize<T>()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                StreamReader reader = new StreamReader(typeof(T).Name + ".xml");
                var obj = (T)serializer.Deserialize(reader);
                reader.Close();
                return obj;
            }
            catch
            {
                return default(T);
            }
        }

        // http://stackoverflow.com/questions/11743160/how-do-i-encode-and-decode-a-base64-string
        public static string Base64Encode(string plainText)
        {
            if (string.IsNullOrEmpty(plainText))
            {
                return string.Empty;
            }

            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
        public static string Base64Decode(string base64EncodedData)
        {
            if (string.IsNullOrEmpty(base64EncodedData))
            {
                return string.Empty;
            }
            else
            {
                var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
                return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
            }
        }
    }
}
