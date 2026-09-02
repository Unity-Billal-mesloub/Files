
using Unity-Billal-mesloub.UI.Xaml;

namespace Files.App.UITests
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();
		}

		protected override void OnLaunched(LaunchActivatedEventArgs args)
		{
			MainWindow.Instance.Activate();
		}
	}
}
