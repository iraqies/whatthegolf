using Il2CppDummyDll;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.SceneManagement;

namespace UnityEngine.ResourceManagement.ResourceProviders
{
	[Token(Token = "0x2000055")]
	internal static class SceneProviderExtensions
	{
		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x2A712E0", Offset = "0x2A712E0", VA = "0x2A712E0")]
		public static AsyncOperationHandle<SceneInstance> ReleaseScene(this ISceneProvider provider, ResourceManager resourceManager, AsyncOperationHandle<SceneInstance> sceneLoadHandle, UnloadSceneOptions unloadOptions)
		{
			return default;
		}
	}
}
