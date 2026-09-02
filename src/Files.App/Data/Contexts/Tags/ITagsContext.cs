

namespace Files.App.Data.Contexts
{
	interface ITagsContext : INotifyPropertyChanged
	{
		IEnumerable<(string path, bool isFolder)> TaggedItems { get; }
	}
}
