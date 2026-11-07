using Il2CppDummyDll;
using UnityEngine.ResourceManagement.ResourceLocations;

namespace UnityEngine.ResourceManagement.ResourceProviders
{
	[Token(Token = "0x2000058")]
	[Attribute(Name = "DisplayNameAttribute", RVA = "0x1B7BD8", Offset = "0x1B7BD8")]
	public class LegacyResourcesProvider : ResourceProviderBase
	{
		[Token(Token = "0x2000059")]
		internal class InternalOp
		{
			[Token(Token = "0x40000E4")]
			[FieldOffset(Offset = "0x10")]
			private ResourceRequest m_RequestOperation;

			[Token(Token = "0x40000E5")]
			[FieldOffset(Offset = "0x18")]
			private ProvideHandle m_ProvideHandle;

			[Token(Token = "0x6000201")]
			[Address(RVA = "0x2A69568", Offset = "0x2A69568", VA = "0x2A69568")]
			public void Start(ProvideHandle provideHandle)
			{
			}

			[Token(Token = "0x6000202")]
			[Address(RVA = "0x2A77194", Offset = "0x2A77194", VA = "0x2A77194")]
			private bool WaitForCompletionHandler()
			{
				return default;
			}

			[Token(Token = "0x6000203")]
			[Address(RVA = "0x2A772A4", Offset = "0x2A772A4", VA = "0x2A772A4")]
			private void AsyncOperationCompleted(AsyncOperation op)
			{
			}

			[Token(Token = "0x6000204")]
			[Address(RVA = "0x2A77438", Offset = "0x2A77438", VA = "0x2A77438")]
			public float PercentComplete()
			{
				return default;
			}

			[Token(Token = "0x6000205")]
			[Address(RVA = "0x2A69560", Offset = "0x2A69560", VA = "0x2A69560")]
			public InternalOp()
			{
			}
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x2A68CA8", Offset = "0x2A68CA8", VA = "0x2A68CA8", Slot = "17")]
		public override void Provide(ProvideHandle pi)
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x2A69740", Offset = "0x2A69740", VA = "0x2A69740", Slot = "15")]
		public override void Release(IResourceLocation location, object asset)
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x2A69884", Offset = "0x2A69884", VA = "0x2A69884")]
		public LegacyResourcesProvider()
		{
		}
	}
}
