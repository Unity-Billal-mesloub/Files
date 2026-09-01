

using Files.App.ViewModels.Properties;
using Unity-Billal-mesloub.UI.Xaml.Media;
using Unity-Billal-mesloub.UI.Xaml.Media.Imaging;
using Windows.Storage;
using Windows.Storage.Streams;

namespace Files.App.ViewModels.Previews
{
	public sealed partial class ImagePreviewViewModel : BasePreviewModel
	{
		private ImageSource? imageSource;
		public ImageSource? ImageSource
		{
			get => imageSource;
			private set => SetProperty(ref imageSource, value);
		}

		public ImagePreviewViewModel(ListedItem item)
			: base(item)
		{
		}

		public override async Task<List<FileProperty>> LoadPreviewAndDetailsAsync()
		{
			using IRandomAccessStream stream = await PreviewFile.OpenAsync(FileAccessMode.Read);

			await MainWindow.Instance.DispatcherQueue.EnqueueOrInvokeAsync(async () =>
			{
				BitmapImage bitmap = new();
				await bitmap.SetSourceAsync(stream);
				ImageSource = bitmap;
			});

			return [];
		}
	}
}
