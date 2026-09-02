
using Unity-Billal-mesloub.UI.Xaml;
using Unity-Billal-mesloub.UI.Xaml.Controls;
using WinRT;

namespace Files.App.Dialogs
{
	public sealed partial class CloneRepoDialog : ContentDialog, IDialog<CloneRepoDialogViewModel>
	{
		private FrameworkElement RootAppElement
		{
			[DynamicWindowsRuntimeCast(typeof(FrameworkElement))]
			get => (FrameworkElement)MainWindow.Instance.Content;
		}

		public CloneRepoDialogViewModel ViewModel
		{
			get => (CloneRepoDialogViewModel)DataContext;
			set => DataContext = value;
		}

		public CloneRepoDialog()
		{
			InitializeComponent();
		}

		public new async Task<DialogResult> ShowAsync()
		{
			return (DialogResult)await base.ShowAsync();
		}
	}
}
