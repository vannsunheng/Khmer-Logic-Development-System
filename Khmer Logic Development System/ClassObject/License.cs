using System;

public class License
{

    internal string mac_add;
    internal string company_name;
    internal string DisplayName;
    internal DateTime startdate;
    internal string note;
    public License(string mac, string company)
    {
        mac_add = mac;
        company_name = company;
    }
    public License(string mac, string company, string display_name)
    {
        mac_add = mac;
        company_name = company;
        DisplayName = display_name;
    }
}