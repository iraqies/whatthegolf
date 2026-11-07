using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.AddressableAssets.Utility;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.ResourceManagement.Util;

namespace UnityEngine.AddressableAssets.Initialization
{
	[Token(Token = "0x200005A")]
	internal class InitializationOperation : AsyncOperationBase<IResourceLocator>
	{
		[Serializable]
		[Token(Token = "0x200005B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B120C", Offset = "0x1B120C")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x400012D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x400012E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<IResourceProvider, bool> _003C_003E9__13_0;

			[Token(Token = "0x6000285")]
			[Address(RVA = "0x2A3CFC0", Offset = "0x2A3CFC0", VA = "0x2A3CFC0")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6000286")]
			[Address(RVA = "0x2A3CFC8", Offset = "0x2A3CFC8", VA = "0x2A3CFC8")]
			internal bool _003CExecute_003Eb__13_0(IResourceProvider rp)
			{
				return default;
			}
		}

		[Token(Token = "0x200005C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B121C", Offset = "0x1B121C")]
		private sealed class _003C_003Ec__DisplayClass16_0
		{
			[Token(Token = "0x400012F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AddressablesImpl addressables;

			[Token(Token = "0x4000130")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string providerSuffix;

			[Token(Token = "0x4000131")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public IResourceLocation remoteHashLocation;

			[Token(Token = "0x6000287")]
			[Address(RVA = "0x2A3D07C", Offset = "0x2A3D07C", VA = "0x2A3D07C")]
			public _003C_003Ec__DisplayClass16_0()
			{
			}

			[Token(Token = "0x6000288")]
			[Address(RVA = "0x2A3D084", Offset = "0x2A3D084", VA = "0x2A3D084")]
			internal AsyncOperationHandle<IResourceLocator> _003CLoadContentCatalog_003Eb__0(AsyncOperationHandle<ContentCatalogData> res)
			{
				return default;
			}
		}

		[Token(Token = "0x200005D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B122C", Offset = "0x1B122C")]
		private sealed class _003C_003Ec__DisplayClass18_0
		{
			[Token(Token = "0x4000132")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public InitializationOperation _003C_003E4__this;

			[Token(Token = "0x4000133")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public IList<IResourceLocation> catalogs;

			[Token(Token = "0x4000134")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ResourceLocationMap locMap;

			[Token(Token = "0x4000135")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int index;

			[Token(Token = "0x4000136")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public IResourceLocation remoteHashLocation;

			[Token(Token = "0x6000289")]
			[Address(RVA = "0x2A3D0BC", Offset = "0x2A3D0BC", VA = "0x2A3D0BC")]
			public _003C_003Ec__DisplayClass18_0()
			{
			}

			[Token(Token = "0x600028A")]
			[Address(RVA = "0x2A3D0C4", Offset = "0x2A3D0C4", VA = "0x2A3D0C4")]
			internal void _003CLoadContentCatalogInternal_003Eb__0(AsyncOperationHandle<IResourceLocator> op)
			{
			}
		}

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private AsyncOperationHandle<ResourceManagerRuntimeData> m_rtdOp;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private AsyncOperationHandle<IResourceLocator> m_loadCatalogOp;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private string m_ProviderSuffix;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private AddressablesImpl m_Addressables;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private ResourceManagerDiagnostics m_Diagnostics;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private InitalizationObjectsOperation m_InitGroupOps;

		[Token(Token = "0x17000062")]
		protected override float Progress
		{
			[Token(Token = "0x6000279")]
			[Address(RVA = "0x2A304F4", Offset = "0x2A304F4", VA = "0x2A304F4", Slot = "30")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000063")]
		protected override string DebugName
		{
			[Token(Token = "0x600027A")]
			[Address(RVA = "0x2A30580", Offset = "0x2A30580", VA = "0x2A30580", Slot = "31")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x2A30348", Offset = "0x2A30348", VA = "0x2A30348")]
		public InitializationOperation(AddressablesImpl aa)
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x2A20898", Offset = "0x2A20898", VA = "0x2A20898")]
		internal static AsyncOperationHandle<IResourceLocator> CreateInitializationOperation(AddressablesImpl aa, string playerSettingsLocation, string providerSuffix)
		{
			return default;
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x2A305C4", Offset = "0x2A305C4", VA = "0x2A305C4", Slot = "33")]
		protected override bool InvokeWaitForCompletion()
		{
			return default;
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x2A30788", Offset = "0x2A30788", VA = "0x2A30788", Slot = "28")]
		protected override void Execute()
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x2A32490", Offset = "0x2A32490", VA = "0x2A32490")]
		private static void LoadProvider(AddressablesImpl addressables, ObjectInitializationData providerData, string providerSuffix)
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x2A32974", Offset = "0x2A32974", VA = "0x2A32974")]
		private static AsyncOperationHandle<IResourceLocator> OnCatalogDataLoaded(AddressablesImpl addressables, AsyncOperationHandle<ContentCatalogData> op, string providerSuffix, IResourceLocation remoteHashLocation)
		{
			return default;
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x2A20EF4", Offset = "0x2A20EF4", VA = "0x2A20EF4")]
		public static AsyncOperationHandle<IResourceLocator> LoadContentCatalog(AddressablesImpl addressables, IResourceLocation loc, string providerSuffix, [Optional] IResourceLocation remoteHashLocation)
		{
			return default;
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x2A33010", Offset = "0x2A33010", VA = "0x2A33010")]
		public AsyncOperationHandle<IResourceLocator> LoadContentCatalog(IResourceLocation loc, string providerSuffix, IResourceLocation remoteHashLocation)
		{
			return default;
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x2A32284", Offset = "0x2A32284", VA = "0x2A32284")]
		internal AsyncOperationHandle<IResourceLocator> LoadContentCatalogInternal(IList<IResourceLocation> catalogs, int index, ResourceLocationMap locMap, IResourceLocation remoteHashLocation)
		{
			return default;
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x2A33018", Offset = "0x2A33018", VA = "0x2A33018")]
		private void LoadOpComplete(AsyncOperationHandle<IResourceLocator> op, IList<IResourceLocation> catalogs, ResourceLocationMap locMap, int index, IResourceLocation remoteHashLocation)
		{
		}
	}
}
