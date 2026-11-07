namespace Rewired.Utils.Interfaces
{
	internal interface IAddKeyValue<TKey, TValue>
	{
		void Add(TKey key, TValue value);
	}
}
