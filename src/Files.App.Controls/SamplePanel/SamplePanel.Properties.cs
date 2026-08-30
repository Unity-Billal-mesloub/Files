
using Unity-Billal-mesloubToolkit.WinUI;

namespace Files.App.Controls
{
	public sealed partial class SamplePanel
	{
		[GeneratedDependencyProperty]
		public partial string? Header { get; set; }

		[GeneratedDependencyProperty]
		public partial UIElement? MainContent { get; set; }

		[GeneratedDependencyProperty]
		public partial UIElement? SideContent { get; set; }

		partial void OnSideContentChanged(UIElement? newValue)
		{
			UpdateVisualStates();
		}
	}
}
