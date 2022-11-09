using AutomaticGenerator.Generators;
using Microsoft.Extensions.DependencyInjection;
using RandomNameGeneratorLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomaticGenerator
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();

            ConfigureServices(services);

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var form = serviceProvider.GetRequiredService<GeneratorForm>();
                Application.Run(form);
            }
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddScoped<GeneratorForm>()
                    .AddScoped<MemberGenerator>(x => new FaceBook(new TempMailService(), new PersonNameGenerator(), new Chrome()))
                    .AddScoped<JsonStream>(x => new JsonStream("D:\\AutomaticGenerator\\AutomaticGenerator\\Data\\UserInformation.json"));
        }
    }
}
