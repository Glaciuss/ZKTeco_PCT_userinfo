﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

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