//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="none">
//     Copyright (c) Sprocket Enterprises. All rights reserved.
// </copyright>
// <author>Tong Yujie</author>
//-----------------------------------------------------------------------

namespace Calculate
{
    using System;
    using System.Windows.Forms;

    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new 计算器());
        }
    }
}