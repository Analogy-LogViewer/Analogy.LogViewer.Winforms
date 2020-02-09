﻿using System;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Windows.Forms;

namespace Analogy
{
    public class Program
    {
        private static UserSettingsManager Settings => UserSettingsManager.UserSettings;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.ThreadException += Application_ThreadException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            AppDomain.CurrentDomain.FirstChanceException += CurrentDomain_FirstChanceException;
            Application.EnableVisualStyles();
            Settings.IncreaseNumberOfLaunches();
            //if (!string.IsNullOrEmpty(Settings.ApplicationSkinName))
            //{
            //    UserLookAndFeel.Default.SkinName = Settings.ApplicationSkinName;
            //}
            //UserLookAndFeel.Default.StyleChanged += (s, e) =>
            //{
            //    Settings.ApplicationSkinName = ((UserLookAndFeel)s).ActiveSkinName;
            //};

            LoadStartupExtensions();
            Application.Run(new Form1());

        }

        private static void LoadStartupExtensions()
        {
            if (Settings.LoadExtensionsOnStartup && Settings.StartupExtensions.Any())
            {
                var manager = ExtensionsManager.Instance;
                var extensions = manager.GetExtensions().ToList();
                foreach (Guid guid in Settings.StartupExtensions)
                {
                    manager.RegisterExtension(extensions.SingleOrDefault(m => m.ExtensionID == guid));
                }

            }
        }
        private static void CurrentDomain_FirstChanceException(object sender, FirstChanceExceptionEventArgs e)
        {
            AnalogyLogger.Intance.LogException(e.Exception, nameof(CurrentDomain_FirstChanceException), "Error: " + e);
        }
        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            AnalogyLogger.Intance.LogException(e.ExceptionObject as Exception, nameof(CurrentDomain_UnhandledException), "Error: " + e.ExceptionObject);
            MessageBox.Show("Error: " + e.ExceptionObject, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            AnalogyLogger.Intance.LogException(e.Exception, nameof(Application_ThreadException), "Error: " + e.Exception);
            MessageBox.Show("Error: " + e.Exception, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
