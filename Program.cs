using System;
using System.Windows.Forms;
using System.Globalization;
using System.Diagnostics;
using System.Data;
using DatabaseClassLibrary;

namespace UserInfo
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new UserInfoMain());
        }
    }
}