using System;


class RefreshTypes
{
    [System.Runtime.InteropServices.DllImport("shell32.dll")]
    private static extern int SHChangeNotify(int wEventId, int uFlags, IntPtr dwItem1, IntPtr dwItem2);

    public RefreshTypes()
    { SHChangeNotify(0x8000000, 0x1000, IntPtr.Zero, IntPtr.Zero); }
}