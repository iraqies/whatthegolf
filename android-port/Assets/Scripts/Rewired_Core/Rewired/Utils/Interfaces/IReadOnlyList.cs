namespace Rewired.Utils.Interfaces
{
	internal interface IReadOnlyList
	{
		int Count { get; }

		// C# has no syntax for parameterized property 'Item'.
		object get_Item(int index);
	}
}
