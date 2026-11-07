using Il2CppDummyDll;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.ResourceManagement.ResourceProviders
{
	[Token(Token = "0x200004E")]
	public interface IInstanceProvider
	{
		[Token(Token = "0x60001D9")]
		GameObject ProvideInstance(ResourceManager resourceManager, AsyncOperationHandle<GameObject> prefabHandle, InstantiationParameters instantiateParameters);

		[Token(Token = "0x60001DA")]
		void ReleaseInstance(ResourceManager resourceManager, GameObject instance);
	}
}
