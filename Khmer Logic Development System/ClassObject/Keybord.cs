using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class Keybord
{

    internal static void ChangeKhmer()
    {
        foreach (InputLanguage Lng in InputLanguage.InstalledInputLanguages)
        {
            if ((Lng.Culture.DisplayName.StartsWith("KHMER")
                        || (Lng.Culture.DisplayName.StartsWith("KM") || Lng.Culture.DisplayName.StartsWith("Catalan"))))
            {
                InputLanguage.CurrentInputLanguage = Lng;
                break;
            }

        }

    }

    internal static void ChangeEnglish()
    {
        foreach (InputLanguage Lng in InputLanguage.InstalledInputLanguages)
        {
            if ((Lng.Culture.DisplayName.StartsWith("English")
                        || (Lng.Culture.DisplayName.StartsWith("En") || Lng.Culture.DisplayName.StartsWith("Catalan"))))
            {
                InputLanguage.CurrentInputLanguage = Lng;
                break;
            }

        }

    }

    internal static void ChangeKey(string str)
    {
        foreach (InputLanguage ln in InputLanguage.InstalledInputLanguages)
        {
            if (ln.Culture.Name.ToString().ToUpper().StartsWith(str.ToUpper()))
            {
                InputLanguage.CurrentInputLanguage = ln;
                break;
            }

        }
    }

    internal static void NumberOnlyInteger(ref object sender, ref System.Windows.Forms.KeyPressEventArgs e)
    {
        string allowedChars = "0123456789";
        if (char.IsControl(e.KeyChar))
        {
            return;
        }

        if ((allowedChars.IndexOf(e.KeyChar) == -1))
        {
            e.Handled = true;
        }

    }

    internal static void NumberOnly(ref object sender, ref System.Windows.Forms.KeyPressEventArgs e)
    {
        if (sender == typeof(TextBox))
        {
            TextBox txt = (TextBox)sender;
            if ((".".IndexOf(e.KeyChar) >= 0))
            {
                if ((txt.Text.IndexOf(".") >= 0))
                {
                    e.Handled = true;
                }

            }

            if (("-".IndexOf(e.KeyChar) >= 0))
            {
                if ((txt.Text.IndexOf("-") >= 0))
                {
                    e.Handled = true;
                }

            }

            e.KeyChar = Converters.toEngNumber(e.KeyChar);
            string allowedChars = "0123456789.-";
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            if ((allowedChars.IndexOf(e.KeyChar) == -1))
            {
                e.Handled = true;
            }

            //     if ((txtBox.Text.IndexOf('.') > -1 && txtBox.Text.Length >= 1) && e.KeyChar == '.')
            //     {
            //         e.Handled = true;
            //     }
            //     if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            //     {
            //         e.Handled = true;
            //     }
            //     Else
            //     {
            //         e.KeyChar = main.NumberContvert(e.KeyChar);
            //     }
        }


    }

    public static void AcceptCode(KeyEventArgs e)
    {
        e.Handled = "!@#$$%^&*()?\';:<>`~\\|".Contains(((char)(((char)(e.KeyCode)))).ToString());
    }

    public static void AcceptCode(KeyPressEventArgs e)
    {
        e.Handled = "!@#$$%^&*()?\';:<>`~\\|".Contains(e.KeyChar.ToString());
    }
}
