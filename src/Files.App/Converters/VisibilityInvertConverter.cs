

using Unity-Billal-mesloub.UI.Xaml;
using Unity-Billal-mesloub.UI.Xaml.Data;
using WinRT;

namespace Files.App.Converters
{
	internal sealed partial class VisibilityInvertConverter : IValueConverter
	{
		[DynamicWindowsRuntimeCast(typeof(Visibility))]
		public object Convert(object value, Type targetType, object parameter, string language)
		{
			if (value is bool isVisible)
			{
				return isVisible ? Visibility.Collapsed : Visibility.Visible;
			}

			return (Visibility)value == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible;
		}

		public object ConvertBack(object value, Type targetType, object parameter, string language)
		{
			throw new NotImplementedException();
		}
	}
}
