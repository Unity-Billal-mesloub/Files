

namespace Files.App.Services.DateTimeFormatter
{
	public interface IDateTimeFormatterFactory
	{
		IDateTimeFormatter GetDateTimeFormatter(DateTimeFormats dateTimeFormat);
	}
}
