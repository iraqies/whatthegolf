namespace PlayFab
{
	public interface ISerializerPlugin : IPlayFabPlugin
	{
		T DeserializeObject<T>(string serialized);

		string SerializeObject(object obj);
	}
}
