using EmployeesAPP.ViewModels;
using EmployeesAPP.Views;
using Microsoft.Extensions.Logging;
using Syncfusion.Maui.Toolkit.Hosting;

namespace EmployeesAPP
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder.UseMauiApp<App>()
                .ConfigureSyncfusionToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            #if DEBUG
    		    builder.Logging.AddDebug();
            #endif

            //Views
            builder.Services.AddSingleton<LoginPage>();
            builder.Services.AddSingleton<HomePage>();
            builder.Services.AddTransient<LogoutPage>();
            builder.Services.AddTransient<LeaveApplicationListPage>();
            builder.Services.AddTransient<AddNewLeaveApplicationPage>();
            


            //View Models
            builder.Services.AddSingleton<LoginPageViewModel>();
            builder.Services.AddTransient<EmployeesListPageViewModel>();
            builder.Services.AddTransient<HomePageViewModel>();
            builder.Services.AddTransient<LeaveApplicationListPageViewModel>();
            builder.Services.AddTransient<AddNewLeaveApplicationPageViewModel>();
            

            return builder.Build();
        }
    }
}
