using Microsoft.Win32;


class RegistryHelper
{
    private const string MAIN_KEY = @"Directory\Background\shell\Refresh types";


    static public bool IsKeyExists()
    { return Registry.ClassesRoot.OpenSubKey(MAIN_KEY) != null; }


    static public void Integrate(string appPath)
    {
        RegistryKey key = Registry.ClassesRoot.CreateSubKey(MAIN_KEY);
        Registry.SetValue(key.Name, "Icon", "\"" + appPath + "\",1");
        Registry.SetValue(key.Name, "Position", "Top");
        Registry.SetValue(key.Name, "SeparatorAfter", "Last use: " + System.DateTime.Now.ToString());
        Registry.SetValue(key.Name + "\\command", null, "\"" + appPath + "\" -refresh");
    }


    static public void DisIntegrate()
    {
        if (IsKeyExists())
            Registry.ClassesRoot.DeleteSubKeyTree(MAIN_KEY);
    }
}

