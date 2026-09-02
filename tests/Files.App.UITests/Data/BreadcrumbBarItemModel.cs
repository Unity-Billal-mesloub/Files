
using System.Collections.ObjectModel;

namespace Files.App.UITests.Data
{
	internal record BreadcrumbBarItemModel(string Text, ObservableCollection<BreadcrumbBarItemModel>? Children = null);
}
