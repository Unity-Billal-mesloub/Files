

namespace Files.App.ViewModels
{
	public sealed partial class ReleaseNotesViewModel : ObservableObject
	{
		public string BlogPostUrl =>
			Constants.ExternalUrl.ReleaseNotesUrl;

		public string SupportUsUrl =>
			Constants.ExternalUrl.SupportUsUrl;

		public ReleaseNotesViewModel()
		{
		}
	}
}
