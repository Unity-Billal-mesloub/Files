

using Unity-Billal-mesloubToolkit.WinUI.Helpers;
using Unity-Billal-mesloub.UI;
using Unity-Billal-mesloub.UI.Xaml.Data;
using Unity-Billal-mesloub.UI.Xaml.Media;

namespace Files.App.Converters
{
	internal sealed partial class StringToBrushConverter : IValueConverter
	{
		public object? Convert(object value, Type targetType, object parameter, string language)
		{
			if (value is not string strValue)
				return null;

			try
			{
				return new SolidColorBrush(strValue.ToColor());
			}
			catch (FormatException)
			{
				return new SolidColorBrush(Colors.Transparent);
			}
		}

		public object ConvertBack(object value, Type targetType, object parameter, string language)
		{
			throw new NotImplementedException();
		}
	}
}
