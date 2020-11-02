using Microsoft.Extensions.DependencyInjection;
using Mphil.Fifteenfriends.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mphil.FifteenFriends.UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ConfigureServices();

            var _gameService = new DeckersMeeting();
            Application.Run(new Form1(_gameService));
        }

        static void ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddScoped<IDeckersMeeting, DeckersMeeting>();
        }
    }
}
