
namespace Files.App.ViewModels.Dialogs
{
	[WinRT.GeneratedBindableCustomProperty([nameof(IsNameInvalid)], [])]
	partial class CreateItemDialogViewModel : ObservableObject
	{
		private bool isNameInvalid;
		public bool IsNameInvalid
		{
			get => isNameInvalid;
			set => SetProperty(ref isNameInvalid, value);
		}
	}
}
