
using Unity-Billal-mesloub.UI.Xaml.Markup;

namespace Files.App.Helpers
{
	public sealed partial class SystemTypeToXaml : MarkupExtension
	{
		#region Private Members

		private object? parameter;

		#endregion Private Members

		#region Public Properties

		public int Int { set => parameter = value; }

		public double Double { set => parameter = value; }

		public float Float { set => parameter = value; }

		public bool Bool { set => parameter = value; }

		#endregion Public Properties

		protected override object ProvideValue()
		{
			return parameter
				?? throw new InvalidOperationException("A value must be supplied to the markup extension.");
		}
	}
}
