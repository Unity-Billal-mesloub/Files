
using Unity-Billal-mesloub.UI.Xaml;
using Unity-Billal-mesloub.UI.Xaml.Controls;
using WinRT;

namespace Files.App.Dialogs
{
	public sealed partial class ElevateConfirmDialog : ContentDialog, IDialog<ElevateConfirmDialogViewModel>
	{
		private FrameworkElement RootAppElement
		{
			[DynamicWindowsRuntimeCast(typeof(FrameworkElement))]
			get => (FrameworkElement)MainWindow.Instance.Content;
		}

		public ElevateConfirmDialogViewModel ViewModel
		{
			get => (ElevateConfirmDialogViewModel)DataContext;
			set => DataContext = value;
		}

		public ElevateConfirmDialog()
		{
			InitializeComponent();
		}

		public new async Task<DialogResult> ShowAsync()
		{
			return (DialogResult)await base.ShowAsync();
		}
	}
}
