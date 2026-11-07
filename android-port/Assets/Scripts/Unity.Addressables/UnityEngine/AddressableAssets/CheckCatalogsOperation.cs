using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;

namespace UnityEngine.AddressableAssets
{
	[Token(Token = "0x200003B")]
	internal class CheckCatalogsOperation : AsyncOperationBase<List<string>>
	{
		[Serializable]
		[Token(Token = "0x200003C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B1184", Offset = "0x1B1184")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x400009C")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x400009D")]
			[FieldOffset(Offset = "0x8")]
			public static Func<IResourceProvider, bool> _003C_003E9__5_0;

			[Token(Token = "0x60001C3")]
			[Address(RVA = "0x2A3ACC4", Offset = "0x2A3ACC4", VA = "0x2A3ACC4")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x60001C4")]
			[Address(RVA = "0x2A3ACCC", Offset = "0x2A3ACCC", VA = "0x2A3ACCC")]
			internal bool _003CStart_003Eb__5_0(IResourceProvider rp)
			{
				return default;
			}
		}

		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0x98")]
		private AddressablesImpl m_Addressables;

		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0xA0")]
		private List<string> m_LocalHashes;

		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0xA8")]
		private List<ResourceLocatorInfo> m_LocatorInfos;

		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0xB0")]
		private AsyncOperationHandle<IList<AsyncOperationHandle>> m_DepOp;

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x2A25334", Offset = "0x2A25334", VA = "0x2A25334")]
		public CheckCatalogsOperation(AddressablesImpl aa)
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x2A25394", Offset = "0x2A25394", VA = "0x2A25394")]
		public AsyncOperationHandle<List<string>> Start(List<ResourceLocatorInfo> locatorInfos)
		{
			return default;
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x2A29370", Offset = "0x2A29370", VA = "0x2A29370", Slot = "33")]
		protected override bool InvokeWaitForCompletion()
		{
			return default;
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x2A294B0", Offset = "0x2A294B0", VA = "0x2A294B0", Slot = "29")]
		protected override void Destroy()
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x2A2951C", Offset = "0x2A2951C", VA = "0x2A2951C", Slot = "32")]
		public override void GetDependencies(List<AsyncOperationHandle> dependencies)
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x2A295C8", Offset = "0x2A295C8", VA = "0x2A295C8")]
		internal static List<string> ProcessDependentOpResults(IList<AsyncOperationHandle> results, List<ResourceLocatorInfo> locatorInfos, List<string> localHashes, out string errorString, out bool success)
		{
			return null;
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x2A29B70", Offset = "0x2A29B70", VA = "0x2A29B70", Slot = "28")]
		protected override void Execute()
		{
		}
	}
}
