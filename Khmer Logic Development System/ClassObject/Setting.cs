using System;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
public class Setting
{
    public static bool resetMode;
    public static bool adminMode;
    public static Color mainColor = Color.FromArgb(0, 204, 204);
    public static Color subColor = Color.FromArgb(255, 255, 255);
    internal static string InvoiceType = "1";
    public static DateTime sessionDate;
    public static string registryPath = "Software\\KHMERLOGIC\\BlokBlok2018";
    internal static string SecurityKey = "KHMERLOGIC";
    internal static string CompanyName = "ខ្មែរលោហ្សិច អភិវឌ្ឍន៍ប្រព័ន្ធ គ្រប់ប្រភេទ";
    internal static string CompanyEngName = "KHMER LOGIC DEVELOPMENT SYSTEM";
    internal static string CompanyTelephone = "0966064907";
    internal static string CompaneyEmail = "vannsunheng123@gmail.com";
    internal static Image CompanyLogo = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + "\\" + "Logo.png");
    internal static string DatabaseName = "ALLSYSTEM";
    internal static string CompanyAddress = "";
    internal static string CompanySlogan = "";
    internal static string License = "KHMERLOGIC";
    internal static string DisplayLicese = "KHMERLOGIC";
    internal static bool isAllDayWork = false;
    internal static bool isNoSaving = false;
    internal static bool isWorkOnStaturday = false;
    internal static string Version = "1";
    internal static string HomeCurrencyID = "1";
    internal static string HomeCurrencySign = "$";
    internal static string HomeCurrencyDecimal = "2";

    public static string FormatNumber(double Number)
    {
        return (String.Format(Number.ToString(), ("N" + HomeCurrencyDecimal)) + (" " + HomeCurrencySign));
    }

    public static string FormatNumber(string Num)
    {
        if ((Num == ""))
        {
            Num = "0";
        }

        double number;
        number = double.Parse(Num.Replace(Setting.HomeCurrencySign, ""));
        return (String.Format(number.ToString(), ("N" + HomeCurrencyDecimal)) + (" " + HomeCurrencySign));
    }

    public static double getNumber(string Number)
    {
        if ((Number.Replace(HomeCurrencySign, "").Replace(",", "") == ""))
        {
            Number = "0";
        }

        if ((Number == ""))
        {
            Number = "0";
        }

        return double.Parse(Number.Replace(HomeCurrencySign, "").Replace(",", ""));
    }
    public static string Encrypt(string clearText)
    {
        string EncryptionKey = "KHMERLOGIC2018";
        byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
        using (Aes encryptor = Aes.Create())
        {
            Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
            encryptor.Key = pdb.GetBytes(32);
            encryptor.IV = pdb.GetBytes(16);
            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(clearBytes, 0, clearBytes.Length);
                    cs.Close();
                }
                clearText = Convert.ToBase64String(ms.ToArray());
            }
        }
        return clearText;
    }

    public static string Decrypt(string cipherText)
    {
        string EncryptionKey = "KHMERLOGIC2018";
        byte[] cipherBytes = Convert.FromBase64String(cipherText);
        using (Aes encryptor = Aes.Create())
        {
            Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
            encryptor.Key = pdb.GetBytes(32);
            encryptor.IV = pdb.GetBytes(16);
            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(cipherBytes, 0, cipherBytes.Length);
                    cs.Close();
                }
                cipherText = Encoding.Unicode.GetString(ms.ToArray());
            }
        }
        return cipherText;
    }
}
