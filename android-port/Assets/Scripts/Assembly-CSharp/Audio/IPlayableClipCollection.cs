namespace Audio
{
	public interface IPlayableClipCollection
	{
		CollectionPlayMode GetPlayMode { get; }

		int LastCollectionIndex { get; set; }

		int Count { get; }
	}
}
