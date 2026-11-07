using Il2CppDummyDll;

namespace UnityEngine.ResourceManagement.ResourceLocations
{
	[Token(Token = "0x2000063")]
	public interface ILocationSizeData
	{
		[Token(Token = "0x6000243")]
		long ComputeSize(IResourceLocation location, ResourceManager resourceManager);
	}
}
