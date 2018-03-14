using System;
using System.Drawing;
public class Converters
{
    public static byte[] convertImageToByte(Image Img)
    {
        byte[] b;
        System.IO.MemoryStream MS = new System.IO.MemoryStream();
        try
        {
            Img.Save(MS, System.Drawing.Imaging.ImageFormat.Png);
        }
        catch (Exception ex1)
        {
            try
            {
                Img.Save(MS, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            catch (Exception ex2)
            {
                try
                {
                    Img.Save(MS, System.Drawing.Imaging.ImageFormat.Bmp);
                }
                catch (Exception ex3)
                {
                    try
                    {
                        Img.Save(MS, System.Drawing.Imaging.ImageFormat.Gif);
                    }
                    catch (Exception ex4)
                    {
                        try
                        {
                            Img.Save(MS, System.Drawing.Imaging.ImageFormat.Icon);
                        }
                        catch (Exception ex5)
                        {
                            try
                            {
                                Img.Save(MS, System.Drawing.Imaging.ImageFormat.Exif);
                            }
                            catch (Exception ex6)
                            {
                                try
                                {
                                    Img.Save(MS, System.Drawing.Imaging.ImageFormat.MemoryBmp);
                                }
                                catch (Exception ex7)
                                {
                                    throw ex7;
                                }
                                throw ex6;
                            }
                            throw ex5;
                        }
                        throw ex4;
                    }
                    throw ex3;
                }
                throw ex2;
            }
            throw ex1;
        }
        b = MS.GetBuffer();
        return b;
    }
    public static Image ConvertByteToImage(byte[] b)
    {
        Image img;
        System.IO.MemoryStream st = new System.IO.MemoryStream(b);
        img = Image.FromStream(st);
        return img;
    }
    internal static Bitmap CropImage2(double w, double h, Image OriginalImage)
    {
        try
        {
            double x;
            double i;
            double j;
            if (OriginalImage.Width < OriginalImage.Height)
            {
                x = OriginalImage.Width / w;
                i = 0;
                j = 0;
            }
            else if (OriginalImage.Width > OriginalImage.Height)
            {
                x = (OriginalImage.Width / w);
                j = 0;
                i = 0;
            }
            else
            {
                x = (OriginalImage.Width / w);
                i = 0;
                j = 0;
            }
            Rectangle croprect = new Rectangle((int)i, (int)j, (int)w, (int)h);
            Size newsize = new Size((int)(OriginalImage.Width / x), (int)(OriginalImage.Height / x));
            OriginalImage = new Bitmap(OriginalImage, newsize);
            Bitmap cropimage = new Bitmap(croprect.Width, croprect.Height);
            Graphics grp = Graphics.FromImage(cropimage);
            grp.DrawImage(OriginalImage, new Rectangle(0, 0, croprect.Width, croprect.Height), croprect, GraphicsUnit.Pixel);
            OriginalImage.Dispose();
            return cropimage;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public static Bitmap ResizeImage(Image SourceImage, Int32 TargetWidth, Int32 TargetHeight)
    {
        Bitmap bmSource = new Bitmap(SourceImage);
        return ResizeImage(bmSource, TargetWidth, TargetHeight);
    }


    public static Bitmap ResizeImage(Bitmap bmSource, Int32 TargetWidth, Int32 TargetHeight)
    {
        Bitmap bmDest = new Bitmap(TargetWidth, TargetHeight, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
        double nSourceAspectRatio = (bmSource.Width / bmSource.Height);
        double nDestAspectRatio = (bmDest.Width / bmDest.Height);
        int NewX = 0;
        int NewY = 0;
        int NewWidth = bmDest.Width;
        int NewHeight = bmDest.Height;
        if ((nDestAspectRatio == nSourceAspectRatio))
        {
            // same ratio
        }
        else if ((nDestAspectRatio > nSourceAspectRatio))
        {
            // Source is taller
            NewWidth = Convert.ToInt32(Math.Floor((nSourceAspectRatio * NewHeight)));
            NewX = Convert.ToInt32(Math.Floor(((decimal)(bmDest.Width - NewWidth) / 2)));
        }
        else
        {
            // Source is wider
            NewHeight = Convert.ToInt32(Math.Floor(((1 / nSourceAspectRatio) * NewWidth)));
            NewY = Convert.ToInt32(Math.Floor(((decimal)(bmDest.Height - NewHeight) / 2)));
        }
        Graphics grDest = Graphics.FromImage(bmDest);
        grDest.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
        grDest.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
        grDest.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
        grDest.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        grDest.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;
        grDest.DrawImage(bmSource, NewX, NewY, NewWidth, NewHeight);
        return bmDest;
    }
    internal static Bitmap CropImg(double w, double h, Image originalimage)
    {
        try
        {
            double x;
            double j;
            double i;
            if ((originalimage.Width < originalimage.Height))
            {
                x = (originalimage.Width / w);
                i = 0;
                j = 0;
            }
            else if ((originalimage.Width > originalimage.Height))
            {
                x = (originalimage.Height / h);
                j = 0;
                i = (originalimage.Width
                            / (x * 8));
            }
            else
            {
                x = (originalimage.Width / w);
                i = 0;
                j = 0;
            }

            Rectangle croprect = new Rectangle((int)i, (int)j, (int)w, (int)h);
            Size newsize = new Size((int)(originalimage.Width / x), (int)(originalimage.Height / x));
            originalimage = new Bitmap(originalimage, newsize);
            Bitmap cropimage = new Bitmap(croprect.Width, croprect.Height);
            Graphics grp = Graphics.FromImage(cropimage);
            grp.DrawImage(originalimage, new Rectangle(0, 0, croprect.Width, croprect.Height), croprect, GraphicsUnit.Pixel);
            originalimage.Dispose();
            return cropimage;
        }
        catch (Exception ex) { return null; throw ex; }
    }
    static internal string FCCY(double Amt)
    {
        return (string.Format("#,##0.00", Amt));
    }
    public static string toEngLetter(int num)
    {
        if (num <= 26)
        {
            return char.ConvertFromUtf32(num + 64);
        }
        else
        {
            return toEngLetter(num / 26) + char.ConvertFromUtf32(num - 26 + 64);
        }
    }
    public static char toEngNumber(char ch)
    {
        switch (ch)
        {
            case '០':
                return '0';
            case '១':
                return '1';
            case '២':
                return '2';
            case '៣':
                return '3';
            case '៤':
                return '4';
            case '៥':
                return '5';
            case '៦':
                return '6';
            case '៧':
                return '7';
            case '៨':
                return '8';
            case '៩':
                return '9';
            case '។':
                return '.';
            default:
                return ch;
        }
    }
    public static char toKhmerNumber(char ch)
    {
        switch (ch)
        {
            case '0':
                return '០';
            case '1':
                return '១';
            case '2':
                return '២';
            case '3':
                return '៣';
            case '4':
                return '៤';
            case '5':
                return '៥';
            case '6':
                return '៦';
            case '7':
                return '៧';
            case '8':
                return '៨';
            case '9':
                return '៩';
            case '.':
                return '។';
            default:
                return ch;
        }
    }
    public static string toKhmerNumber(int Number)
    {
        string st = Number.ToString();
        char[] chr = st.ToCharArray();
        string stResult = "";
        for (int i = 0; i <= chr.Length; i++)
        {
            stResult = stResult + toKhmerNumber(chr[i]);
        }
        return stResult;
    }
    public static string ToKhmerDate(System.DateTime KhmerDate)
    {
        return "ថ្ងៃ " + ToKhmerDay(KhmerDate.DayOfWeek.ToString()) + " ទី " + toKhmerNumber(KhmerDate.Day) + " ខែ " + ToKhmerMonth(KhmerDate.Month) + " ឆ្នាំ " + toKhmerNumber(KhmerDate.Year);
    }
    public static string ToKhmerDay(string EngDate)
    {
        string st = EngDate.Substring(0, 2);
        switch (st)
        {
            case "Mo":
                return "ច័ន្ទ";
            case "Tu":
                return "អង្គារ";
            case "We":
                return "ពុធ";
            case "Th":
                return "ព្រហ";
            case "Fr":
                return "សុក្រ";
            case "Sa":
                return "សៅរ៍";
            case "Su":
                return "អាទិត្យ";
        }
        return "";
    }
    public static string ToKhmerDay(int EngDate)
    {
        switch (EngDate)
        {
            case 1:
                return "ច័ន្ទ";
            case 2:
                return "អង្គារ";
            case 3:
                return "ពុធ";
            case 4:
                return "ព្រហ";
            case 5:
                return "សុក្រ";
            case 6:
                return "សៅរ៍";
            case 7:
                return "អាទិត្យ";
        }
        return "";
    }
    public static string ToKhmerMonth(string EngDate)
    {
        string st = EngDate.Substring(0, 3);
        switch (st)
        {
            case "Jan":
                return "មករា";
            case "Feb":
                return "កុម្ភៈ";
            case "Mar":
                return "មិនា";
            case "Apr":
                return "មេសា";
            case "May":
                return "ឧសភា";
            case "Jun":
                return "មិថុនា";
            case "Jul":
                return "កក្កដា";
            case "Aug":
                return "សីហា";
            case "Sep":
                return "កញ្ញា";
            case "Oct":
                return "តុលា";
            case "Nov":
                return "វិច្ឆិកា";
            case "Dec":
                return "ធ្នូ";
        }
        return "";
    }
    public static string ToKhmerMonth(int EngDate)
    {
        switch (EngDate)
        {
            case 1:
                return "មករា";
            case 2:
                return "កុម្ភៈ";
            case 3:
                return "មិនា";
            case 4:
                return "មេសា";
            case 5:
                return "ឧសភា";
            case 6:
                return "មិថុនា";
            case 7:
                return "កក្កដា";
            case 8:
                return "សីហា";
            case 9:
                return "កញ្ញា";
            case 10:
                return "តុលា";
            case 11:
                return "វិច្ឆិកា";
            case 12:
                return "ធ្នូ";
        }
        return "";
    }
    ///'''''''''''''''''''''''
    ///'Read  Khmer
    ///'''''''''''''''''''''''
    private static string[] Place = new string[10];
    public static string ConvertKHMER(string MyNumber)
    {
        string KHR = "";
        string Temp = "";
        dynamic DecimalPlace = null;
        dynamic Count = null;
        Place = new string[10];
        Place[2] = "ពាន់ ";
        Place[3] = "សែន";
        Place[4] = "លាន ";
        Place[5] = "កោត ";
        MyNumber = (MyNumber).Trim();
        DecimalPlace = (MyNumber.IndexOf(".") + 1);
        Count = 1;
        while ((MyNumber != ""))
        {
            Temp = GetHundredsKHR(MyNumber.Substring((MyNumber.Length - 3)));
            if ((Temp != ""))
            {
                KHR = (Temp
                            + (Place[Count] + KHR));
            }

            if ((MyNumber.Length > 3))
            {
                MyNumber = MyNumber.Substring(0, (MyNumber.Length - 3));
            }
            else
            {
                MyNumber = "";
            }

            Count = (Count + 1);
        }
        switch (KHR)
        {
            case "":
                KHR = "No Dollars";
                break;
            case "One":
                KHR = "រៀល";
                break;
            default:
                KHR = KHR + "រៀល";
                break;
        }
        return KHR + "គត់";
    }
    private static string GetHundredsKHR(string MyNumber)
    {
        string Result = "";
        MyNumber = ("000" + MyNumber).Substring((("000" + MyNumber).Length - 3));
        if ((MyNumber.Substring(0, 1) != "0"))
        {
            Result = (GetDigitKHR(MyNumber.Substring(0, 1)) + "រយ");
        }

        if ((MyNumber.Substring(1, 1) != "0"))
        {
            Result = (Result + GetTensKHR(MyNumber.Substring(1)));
        }
        else
        {
            Result = (Result + GetDigitKHR(MyNumber.Substring(2)));
        }
        return Result;
    }
    private static object GetDigitKHR(string Digit)
    {
        object functionReturnValue = null;
        int d = int.Parse(Digit);
        switch (d)
        {
            case 1:
                functionReturnValue = "មួយ";
                break;
            case 2:
                functionReturnValue = "ពីរ";
                break;
            case 3:
                functionReturnValue = "បី";
                break;
            case 4:
                functionReturnValue = "បួន";
                break;
            case 5:
                functionReturnValue = "ប្រាំ";
                break;
            case 6:
                functionReturnValue = "ប្រាំមួយ";
                break;
            case 7:
                functionReturnValue = "ប្រាំពីរ";
                break;
            case 8:
                functionReturnValue = "ប្រាំបី";
                break;
            case 9:
                functionReturnValue = "ប្រាំបួន";
                break;
            default:
                functionReturnValue = "";
                break;
        }
        return functionReturnValue;
    }
    private static object GetTensKHR(string TensText)
    {
        string Result = null;
        Result = "";
        if ((double.Parse(TensText.Substring(0, 1)) == 1))
        {
            switch (int.Parse(TensText))
            {
                case 10:
                    Result = "ដប់";
                    break;
                case 11:
                    Result = "ដប់មួយ";
                    break;
                case 12:
                    Result = "ដប់ពីរ";
                    break;
                case 13:
                    Result = "ដប់បី";
                    break;
                case 14:
                    Result = "ដប់បូន";
                    break;
                case 15:
                    Result = "ដប់ប្រាំ";
                    break;
                case 16:
                    Result = "ដប់ប្រាំមួយ";
                    break;
                case 17:
                    Result = "ដប់ប្រាំពីរ";
                    break;
                case 18:
                    Result = "ដប់ប្រាំបី";
                    break;
                case 19:
                    Result = "ដប់ប្រាំបួន";
                    break;
                default:
                    break;
            }
        }
        else
        {
            switch (int.Parse(TensText.Substring(0, 1)))
            {
                case 2:
                    Result = "ម្ភីសិប ";
                    break;
                case 3:
                    Result = "សាមសិប ";
                    break;
                case 4:
                    Result = "សែរសិប";
                    break;
                case 5:
                    Result = "ហារសិប ";
                    break;
                case 6:
                    Result = "ហុកសិប ";
                    break;
                case 7:
                    Result = "ចិតសិប ";
                    break;
                case 8:
                    Result = "ប៉េតសិប ";
                    break;
                case 9:
                    Result = "កៅសិប ";
                    break;
                default:
                    break;
            }
        }
        return Result;
    }
    public static DateTime GetFirstDayOfMonth(DateTime dtDate)
    {
        DateTime dtFrom = dtDate;
        dtFrom = dtFrom.AddDays(-(dtFrom.Day - 1));
        return dtFrom;
    }

    public static DateTime GetLastDayOfMonth(DateTime dtDate)
    {
        DateTime dtTo = new DateTime(dtDate.Year, dtDate.Month, 1);
        dtTo = dtTo.AddMonths(1);
        dtTo = dtTo.AddDays(-(dtTo.Day));
        return dtTo;
    }

    public static int IDtoInt(string strID)
    {
        return (Convert.ToInt32(strID.Substring(strID.Length - 6, 6)));
    }
    public static string NumberToWordsEng(int number)
    {
        if (number == 0)
            return "zero";

        if (number < 0)
            return "minus " + NumberToWordsEng(Math.Abs(number));

        string words = "";

        if ((number / 1000000) > 0)
        {
            words += NumberToWordsEng(number / 1000000) + " million ";
            number %= 1000000;
        }

        if ((number / 1000) > 0)
        {
            words += NumberToWordsEng(number / 1000) + " thousand ";
            number %= 1000;
        }

        if ((number / 100) > 0)
        {
            words += NumberToWordsEng(number / 100) + " hundred ";
            number %= 100;
        }

        if (number > 0)
        {
            if (words != "")
                words += "and ";

            var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            if (number < 20)
                words += unitsMap[number];
            else
            {
                words += tensMap[number / 10];
                if ((number % 10) > 0)
                    words += "-" + unitsMap[number % 10];
            }
        }

        return words;
    }

}

