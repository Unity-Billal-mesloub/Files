
using Unity-Billal-mesloub.UI.Xaml;
using Unity-Billal-mesloub.UI.Xaml.Controls;
using Windows.ApplicationModel.DataTransfer;
using WinRT;

namespace Files.App.Dialogs
{
	public sealed partial class GitHubLoginDialog : ContentDialog, IDialog<GitHubLoginDialogViewModel>
	{
		private FrameworkElement RootAppElement
		{
			[DynamicWindowsRuntimeCast(typeof(FrameworkElement))]
			get => (FrameworkElement)MainWindow.Instance.Content;
		}

		public GitHubLoginDialogViewModel ViewModel
		{
			get => (GitHubLoginDialogViewModel)DataContext;
			set
			{
				if (ViewModel is not null)
					ViewModel.PropertyChanged -= ViewModel_PropertyChanged;

				DataContext = value;
				if (value is not null)
					value.PropertyChanged += ViewModel_PropertyChanged;
			}
		}

		public GitHubLoginDialog()
		{
			InitializeComponent();
		}

		public new async Task<DialogResult> ShowAsync()
		{
			return (DialogResult)await base.ShowAsync();
		}

		private void ContentDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
		{
			args.Cancel = true;

			SafetyExtensions.IgnoreExceptions(() =>
			{
				var data = new DataPackage();
				data.SetText(ViewModel.UserCode);

				Clipboard.SetContent(data);
				Clipboard.Flush();
			});
		}

		private void ViewModel_PropertyChanged(object? sender, PropertyChangedEventArgs e)
		{
			if (e.PropertyName == nameof(GitHubLoginDialogViewModel.LoginConfirmed) && ViewModel.LoginConfirmed)
				PrimaryButtonText = null;
		}
	}
}
