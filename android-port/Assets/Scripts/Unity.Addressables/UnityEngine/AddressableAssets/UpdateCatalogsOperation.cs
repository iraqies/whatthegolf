using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;

namespace UnityEngine.AddressableAssets
{
	[Token(Token = "0x200003E")]
	internal class UpdateCatalogsOperation : AsyncOperationBase<List<IResourceLocator>>
	{
		[Serializable]
		[Token(Token = "0x200003F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B1194", Offset = "0x1B1194")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x40000A9")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x40000AA")]
			[FieldOffset(Offset = "0x8")]
			public static Func<IResourceProvider, bool> _003C_003E9__6_0;

			[Token(Token = "0x60001D9")]
			[Address(RVA = "0x2A3D178", Offset = "0x2A3D178", VA = "0x2A3D178")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x60001DA")]
			[Address(RVA = "0x2A3D180", Offset = "0x2A3D180", VA = "0x2A3D180")]
			internal bool _003CStart_003Eb__6_0(IResourceProvider rp)
			{
				return default;
			}
		}

		[Token(Token = "0x2000040")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B11A4", Offset = "0x1B11A4")]
		private sealed class _003C_003Ec__DisplayClass11_0
		{
			[Token(Token = "0x40000AB")]
			[FieldOffset(Offset = "0x10")]
			public UpdateCatalogsOperation _003C_003E4__this;

			[Token(Token = "0x40000AC")]
			[FieldOffset(Offset = "0x18")]
			public List<IResourceLocator> catalogs;

			[Token(Token = "0x60001DB")]
			[Address(RVA = "0x2A3D234", Offset = "0x2A3D234", VA = "0x2A3D234")]
			public _003C_003Ec__DisplayClass11_0()
			{
			}

			[Token(Token = "0x60001DC")]
			[Address(RVA = "0x2A3D23C", Offset = "0x2A3D23C", VA = "0x2A3D23C")]
			internal void _003COnCleanCacheCompleted_003Eb__0(AsyncOperationHandle<bool> obj)
			{
			}
		}

		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x98")]
		private AddressablesImpl m_Addressables;

		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0xA0")]
		private List<ResourceLocatorInfo> m_LocatorInfos;

		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0xA8")]
		internal AsyncOperationHandle<IList<AsyncOperationHandle>> m_DepOp;

		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0xC8")]
		private AsyncOperationHandle<bool> m_CleanCacheOp;

		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0xE8")]
		private bool m_AutoCleanBundleCache;

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x2A25AEC", Offset = "0x2A25AEC", VA = "0x2A25AEC")]
		public UpdateCatalogsOperation(AddressablesImpl aa)
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x2A25B4C", Offset = "0x2A25B4C", VA = "0x2A25B4C")]
		public AsyncOperationHandle<List<IResourceLocator>> Start(IEnumerable<string> catalogIds, bool autoCleanBundleCache)
		{
			return default;
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x2A39058", Offset = "0x2A39058", VA = "0x2A39058", Slot = "33")]
		protected override bool InvokeWaitForCompletion()
		{
			return default;
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x2A39210", Offset = "0x2A39210", VA = "0x2A39210", Slot = "29")]
		protected override void Destroy()
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x2A39280", Offset = "0x2A39280", VA = "0x2A39280", Slot = "32")]
		public override void GetDependencies(List<AsyncOperationHandle> dependencies)
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x2A39330", Offset = "0x2A39330", VA = "0x2A39330", Slot = "28")]
		protected override void Execute()
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x2A39A0C", Offset = "0x2A39A0C", VA = "0x2A39A0C")]
		private void OnCleanCacheCompleted(AsyncOperationHandle<bool> handle, List<IResourceLocator> catalogs)
		{
		}
	}
}
