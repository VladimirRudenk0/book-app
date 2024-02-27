using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using BookApp.Pages;

namespace BookApp
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// Изначальная форма (та, которая открывается при открытии приложения).
        /// </summary>
        private readonly Window initialWindow = new LoginForm();

        void Application_Startup(object sender, StartupEventArgs e)
        {
            this.initialWindow.Show();
        }
    }
}
