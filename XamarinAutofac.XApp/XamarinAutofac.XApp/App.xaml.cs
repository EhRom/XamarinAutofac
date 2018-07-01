using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinAutofac.XApp.Business.Cqrs;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XamarinAutofac.XApp
{
    public partial class App : Application
	{
		public App ()
		{
            var startupConfiguration = new StartupConfiguration();

			InitializeComponent();

			MainPage = new MainPage();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
