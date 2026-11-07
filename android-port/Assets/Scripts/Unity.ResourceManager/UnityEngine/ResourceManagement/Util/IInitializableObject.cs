using Il2CppDummyDll;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.ResourceManagement.Util
{
	[Token(Token = "0x2000032")]
	public interface IInitializableObject
	{
		[Token(Token = "0x6000138")]
		bool Initialize(string id, string data);

		[Token(Token = "0x6000139")]
		AsyncOperationHandle<bool> InitializeAsync(ResourceManager rm, string id, string data);
	}
}
