
using Unity-Billal-mesloub.UI.Xaml;
using Unity-Billal-mesloub.UI.Xaml.Controls;
using WinRT;

namespace Files.App.Dialogs
{
	public sealed partial class BulkRenameDialog : ContentDialog, IDialog<BulkRenameDialogViewModel>
	{
		private FrameworkElement RootAppElement
		{
			[DynamicWindowsRuntimeCast(typeof(FrameworkElement))]
			get => (FrameworkElement)MainWindow.Instance.Content;
		}

		public BulkRenameDialogViewModel ViewModel
		{
			get => (BulkRenameDialogViewModel)DataContext;
			set => DataContext = value;
		}

		public BulkRenameDialog()
		{
			InitializeComponent();
		}

		public new async Task<DialogResult> ShowAsync()
		{
			return (DialogResult)await base.ShowAsync();
		}
	}
}
