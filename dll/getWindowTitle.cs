
using System;
using System.Runtime.InteropServices;
using System.Text;



class Win32Api {
    [DllImport("user32.dll")]
    public static extern IntPtr GetForegroundWindow();

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    public static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    public static extern int GetWindowTextLength(IntPtr hWnd);
}





public class Hello{
    public static void Main(){
        int result;
        string _windowText;
        const int MaxLength = 500;

        IntPtr handle       = Win32Api.GetForegroundWindow();
        StringBuilder tsb   = new StringBuilder(MaxLength);
        result              = Win32Api.GetWindowText(handle, tsb, tsb.Capacity);


        if ( 0 < result ) {
            _windowText = tsb.ToString();
            _windowText = _windowText.Replace("'","");
            _windowText = _windowText.Replace("\"","");
            _windowText = _windowText.Replace("%","");
            _windowText = _windowText.Replace("\\","\\\\");

        }
        else {
            _windowText = "";
        }
        Console.WriteLine( _windowText );
    }
}










