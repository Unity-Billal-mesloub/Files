

using Unity-Billal-mesloub.UI.Xaml.Data;

namespace Files.App.Converters
{
	internal sealed partial class EnumToBoolConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, string language)
		{
			if (value == null)
				return false;

			return value.ToString() == parameter.ToString();
		}

		public object ConvertBack(object value, Type targetType, object parameter, string language)
		{
			throw new NotImplementedException();
		}
	}
}
