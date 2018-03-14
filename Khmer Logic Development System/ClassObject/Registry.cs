using Microsoft.Win32;
using System;
using System.Runtime.CompilerServices;
public class Registry
{
    internal static void DeleteRegKey(string name)
    {
        RegistryKey key = null;
        try
        {
            Microsoft.Win32.Registry.CurrentUser.DeleteSubKey(Setting.registryPath + @"\" + name, false);
        }
        finally
        {
            if (key != null)
            {
                key.Close();
            }
        }
    }

    internal static void DeleteRegKey(string name, string subkey)
    {
        RegistryKey key = null;
        try
        {
            Microsoft.Win32.Registry.CurrentUser.DeleteSubKey(Setting.registryPath + subkey + @"\" + name, false);
        }
        finally
        {
            if (key != null)
            {
                key.Close();
            }
        }
    }

    internal static void DeleteRegKeyAll()
    {
        RegistryKey key = null;
        try
        {
            Microsoft.Win32.Registry.CurrentUser.DeleteSubKeyTree(Setting.registryPath);
        }
        catch (ArgumentException exception1)
        {
            throw exception1;
        }
        finally
        {
            if (key != null)
            {
                key.Close();
            }
        }
    }

    internal static string GetRegKey(string name)
    {
        RegistryKey key = null;
        try
        {
            key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(Setting.registryPath);
            if (key != null)
            {
                return Convert.ToString(RuntimeHelpers.GetObjectValue(key.GetValue(name)));
            }
        }
        finally
        {
            if (key != null)
            {
                key.Close();
            }
        }
        return null;
    }

    internal static string GetRegKey(string name, string subkey)
    {
        RegistryKey key = null;
        try
        {
            key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(Setting.registryPath + @"\" + subkey);
            if (key != null)
            {
                return Convert.ToString(RuntimeHelpers.GetObjectValue(key.GetValue(name)));
            }
        }
        finally
        {
            if (key != null)
            {
                key.Close();
            }
        }
        return null;
    }

    internal static void SetRegKey(string name, string value)
    {
        RegistryKey key = null;
        try
        {
            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(Setting.registryPath);
            key.SetValue(name, value);
        }
        finally
        {
            if (key != null)
            {
                key.Close();
            }
        }
    }

    internal static void SetRegKey(string name, string value, string subkey)
    {
        RegistryKey key = null;
        try
        {
            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(Setting.registryPath + @"\" + subkey);
            key.SetValue(name, value);
        }
        finally
        {
            if (key != null)
            {
                key.Close();
            }
        }
    }

}