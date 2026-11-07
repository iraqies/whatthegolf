using System;
using Il2CppDummyDll;
using UnityEngine.ResourceManagement.ResourceLocations;

namespace UnityEngine.ResourceManagement.ResourceProviders
{
	[Token(Token = "0x2000051")]
	public interface IResourceProvider
	{
		[Token(Token = "0x17000054")]
		string ProviderId
		{
			[Token(Token = "0x60001E8")]
			get;
		}

		[Token(Token = "0x17000055")]
		ProviderBehaviourFlags BehaviourFlags
		{
			[Token(Token = "0x60001ED")]
			get;
		}

		[Token(Token = "0x60001E9")]
		Type GetDefaultType(IResourceLocation location);

		[Token(Token = "0x60001EA")]
		bool CanProvide(Type type, IResourceLocation location);

		[Token(Token = "0x60001EB")]
		void Provide(ProvideHandle provideHandle);

		[Token(Token = "0x60001EC")]
		void Release(IResourceLocation location, object asset);
	}
}
