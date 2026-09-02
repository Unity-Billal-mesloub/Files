
using Unity-Billal-mesloub.UI.Xaml;
using Unity-Billal-mesloub.UI.Xaml.Controls;
using Unity-Billal-mesloub.UI.Xaml.Data;
using WinRT;

namespace Files.App.Dialogs
{
	public sealed partial class CreateShortcutDialog : ContentDialog, IDialog<CreateShortcutDialogViewModel>
	{
		private FrameworkElement RootAppElement
		{
			[DynamicWindowsRuntimeCast(typeof(FrameworkElement))]
			get => (FrameworkElement)MainWindow.Instance.Content;
		}

		public CreateShortcutDialogViewModel ViewModel
		{
			get => (CreateShortcutDialogViewModel)DataContext;
			set => DataContext = value;
		}

		public CreateShortcutDialog()
		{
			InitializeComponent();
			this.Closing += CreateShortcutDialog_Closing;

			InvalidPathWarning.SetBinding(TeachingTip.TargetProperty, new Binding()
			{
				Source = ShortcutTarget
			});
		}

		private void CreateShortcutDialog_Closing(ContentDialog sender, ContentDialogClosingEventArgs args)
		{
			this.Closing -= CreateShortcutDialog_Closing;
			InvalidPathWarning.IsOpen = false;
		}

		public new async Task<DialogResult> ShowAsync()
		{
			return (DialogResult)await base.ShowAsync();
		}
	}
}
