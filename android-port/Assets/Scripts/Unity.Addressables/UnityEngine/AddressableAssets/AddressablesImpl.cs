using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.Networking;
using UnityEngine.ResourceManagement;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.ResourceManagement.Util;
using UnityEngine.SceneManagement;

namespace UnityEngine.AddressableAssets
{
	[Token(Token = "0x2000010")]
	internal class AddressablesImpl : IEqualityComparer<IResourceLocation>
	{
		[Token(Token = "0x2000011")]
		private class LoadResourceLocationKeyOp : AsyncOperationBase<IList<IResourceLocation>>
		{
			[Token(Token = "0x400002F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private object m_Keys;

			[Token(Token = "0x4000030")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private IList<IResourceLocation> m_locations;

			[Token(Token = "0x4000031")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private AddressablesImpl m_Addressables;

			[Token(Token = "0x4000032")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Type m_ResourceType;

			[Token(Token = "0x17000029")]
			protected override string DebugName
			{
				[Token(Token = "0x600013F")]
				[Address(RVA = "0x2A3A5D0", Offset = "0x2A3A5D0", VA = "0x2A3A5D0", Slot = "31")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000140")]
			[Address(RVA = "0x2A3A5F0", Offset = "0x2A3A5F0", VA = "0x2A3A5F0")]
			public void Init(AddressablesImpl aa, Type t, object keys)
			{
			}

			[Token(Token = "0x6000141")]
			[Address(RVA = "0x2A3A5FC", Offset = "0x2A3A5FC", VA = "0x2A3A5FC", Slot = "33")]
			protected override bool InvokeWaitForCompletion()
			{
				return default;
			}

			[Token(Token = "0x6000142")]
			[Address(RVA = "0x2A3A674", Offset = "0x2A3A674", VA = "0x2A3A674", Slot = "28")]
			protected override void Execute()
			{
			}

			[Token(Token = "0x6000143")]
			[Address(RVA = "0x2A3A758", Offset = "0x2A3A758", VA = "0x2A3A758")]
			public LoadResourceLocationKeyOp()
			{
			}
		}

		[Token(Token = "0x2000012")]
		private class LoadResourceLocationKeysOp : AsyncOperationBase<IList<IResourceLocation>>
		{
			[Token(Token = "0x4000033")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private IEnumerable m_Key;

			[Token(Token = "0x4000034")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private Addressables.MergeMode m_MergeMode;

			[Token(Token = "0x4000035")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private IList<IResourceLocation> m_locations;

			[Token(Token = "0x4000036")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private AddressablesImpl m_Addressables;

			[Token(Token = "0x4000037")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private Type m_ResourceType;

			[Token(Token = "0x1700002A")]
			protected override string DebugName
			{
				[Token(Token = "0x6000144")]
				[Address(RVA = "0x2A3A7B0", Offset = "0x2A3A7B0", VA = "0x2A3A7B0", Slot = "31")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000145")]
			[Address(RVA = "0x2A3A7F4", Offset = "0x2A3A7F4", VA = "0x2A3A7F4")]
			public void Init(AddressablesImpl aa, Type t, IEnumerable key, Addressables.MergeMode mergeMode)
			{
			}

			[Token(Token = "0x6000146")]
			[Address(RVA = "0x2A3A804", Offset = "0x2A3A804", VA = "0x2A3A804", Slot = "28")]
			protected override void Execute()
			{
			}

			[Token(Token = "0x6000147")]
			[Address(RVA = "0x2A3A8EC", Offset = "0x2A3A8EC", VA = "0x2A3A8EC", Slot = "33")]
			protected override bool InvokeWaitForCompletion()
			{
				return default;
			}

			[Token(Token = "0x6000148")]
			[Address(RVA = "0x2A3A964", Offset = "0x2A3A964", VA = "0x2A3A964")]
			public LoadResourceLocationKeysOp()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000013")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B0FA4", Offset = "0x1B0FA4")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4000038")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4000039")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<ResourceLocatorInfo, IResourceLocator> _003C_003E9__59_0;

			[Token(Token = "0x400003A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<ResourceLocatorInfo, bool> _003C_003E9__149_0;

			[Token(Token = "0x400003B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Func<ResourceLocatorInfo, string> _003C_003E9__149_1;

			[Token(Token = "0x400003C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Func<ResourceLocatorInfo, string> _003C_003E9__153_0;

			[Token(Token = "0x600014A")]
			[Address(RVA = "0x2A39B68", Offset = "0x2A39B68", VA = "0x2A39B68")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x600014B")]
			[Address(RVA = "0x2A39B70", Offset = "0x2A39B70", VA = "0x2A39B70")]
			internal IResourceLocator _003Cget_ResourceLocators_003Eb__59_0(ResourceLocatorInfo l)
			{
				return null;
			}

			[Token(Token = "0x600014C")]
			[Address(RVA = "0x2A39B88", Offset = "0x2A39B88", VA = "0x2A39B88")]
			internal bool _003Cget_CatalogsWithAvailableUpdates_003Eb__149_0(ResourceLocatorInfo s)
			{
				return default;
			}

			[Token(Token = "0x600014D")]
			[Address(RVA = "0x2A39BA0", Offset = "0x2A39BA0", VA = "0x2A39BA0")]
			internal string _003Cget_CatalogsWithAvailableUpdates_003Eb__149_1(ResourceLocatorInfo s)
			{
				return null;
			}

			[Token(Token = "0x600014E")]
			[Address(RVA = "0x2A39C58", Offset = "0x2A39C58", VA = "0x2A39C58")]
			internal string _003CCleanBundleCache_003Eb__153_0(ResourceLocatorInfo s)
			{
				return null;
			}
		}

		[Token(Token = "0x2000014")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B0FB4", Offset = "0x1B0FB4")]
		private sealed class _003C_003Ec__DisplayClass61_0
		{
			[Token(Token = "0x400003D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public IResourceLocator loc;

			[Token(Token = "0x600014F")]
			[Address(RVA = "0x2A3A4E4", Offset = "0x2A3A4E4", VA = "0x2A3A4E4")]
			public _003C_003Ec__DisplayClass61_0()
			{
			}

			[Token(Token = "0x6000150")]
			[Address(RVA = "0x2A3A4EC", Offset = "0x2A3A4EC", VA = "0x2A3A4EC")]
			internal bool _003CRemoveResourceLocator_003Eb__0(ResourceLocatorInfo l)
			{
				return default;
			}
		}

		[Token(Token = "0x2000015")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B0FC4", Offset = "0x1B0FC4")]
		private sealed class _003C_003Ec__DisplayClass72_0
		{
			[Token(Token = "0x400003E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AddressablesImpl _003C_003E4__this;

			[Token(Token = "0x400003F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string catalogPath;

			[Token(Token = "0x4000040")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool autoReleaseHandle;

			[Token(Token = "0x4000041")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string providerSuffix;

			[Token(Token = "0x6000151")]
			[Address(RVA = "0x2A3A510", Offset = "0x2A3A510", VA = "0x2A3A510")]
			public _003C_003Ec__DisplayClass72_0()
			{
			}

			[Token(Token = "0x6000152")]
			[Address(RVA = "0x2A3A518", Offset = "0x2A3A518", VA = "0x2A3A518")]
			internal AsyncOperationHandle<IResourceLocator> _003CLoadContentCatalogAsync_003Eb__0(AsyncOperationHandle op)
			{
				return default;
			}
		}

		[Token(Token = "0x2000016")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B0FD4", Offset = "0x1B0FD4")]
		private sealed class _003C_003Ec__DisplayClass78_0<TObject>
		{
			[Token(Token = "0x4000042")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public AddressablesImpl _003C_003E4__this;

			[Token(Token = "0x4000043")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IResourceLocation loc;

			[Token(Token = "0x6000153")]
			public _003C_003Ec__DisplayClass78_0()
			{
			}

			[Token(Token = "0x6000154")]
			internal AsyncOperationHandle<TObject> _003CLoadAssetWithChain_003Eb__0(AsyncOperationHandle op)
			{
				return default;
			}
		}

		[Token(Token = "0x2000017")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B0FE4", Offset = "0x1B0FE4")]
		private sealed class _003C_003Ec__DisplayClass79_0<TObject>
		{
			[Token(Token = "0x4000044")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public AddressablesImpl _003C_003E4__this;

			[Token(Token = "0x4000045")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public object key;

			[Token(Token = "0x6000155")]
			public _003C_003Ec__DisplayClass79_0()
			{
			}

			[Token(Token = "0x6000156")]
			internal AsyncOperationHandle<TObject> _003CLoadAssetWithChain_003Eb__0(AsyncOperationHandle op)
			{
				return default;
			}
		}

		[Token(Token = "0x2000018")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B0FF4", Offset = "0x1B0FF4")]
		private sealed class _003C_003Ec__DisplayClass83_0
		{
			[Token(Token = "0x4000046")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AddressablesImpl _003C_003E4__this;

			[Token(Token = "0x4000047")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public IEnumerable keys;

			[Token(Token = "0x4000048")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Addressables.MergeMode mode;

			[Token(Token = "0x4000049")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Type type;

			[Token(Token = "0x6000157")]
			[Address(RVA = "0x2A3A544", Offset = "0x2A3A544", VA = "0x2A3A544")]
			public _003C_003Ec__DisplayClass83_0()
			{
			}

			[Token(Token = "0x6000158")]
			[Address(RVA = "0x2A3A54C", Offset = "0x2A3A54C", VA = "0x2A3A54C")]
			internal AsyncOperationHandle<IList<IResourceLocation>> _003CLoadResourceLocationsWithChain_003Eb__0(AsyncOperationHandle op)
			{
				return default;
			}
		}

		[Token(Token = "0x2000019")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B1004", Offset = "0x1B1004")]
		private sealed class _003C_003Ec__DisplayClass85_0
		{
			[Token(Token = "0x400004A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AddressablesImpl _003C_003E4__this;

			[Token(Token = "0x400004B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public object key;

			[Token(Token = "0x400004C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Type type;

			[Token(Token = "0x6000159")]
			[Address(RVA = "0x2A3A578", Offset = "0x2A3A578", VA = "0x2A3A578")]
			public _003C_003Ec__DisplayClass85_0()
			{
			}

			[Token(Token = "0x600015A")]
			[Address(RVA = "0x2A3A580", Offset = "0x2A3A580", VA = "0x2A3A580")]
			internal AsyncOperationHandle<IList<IResourceLocation>> _003CLoadResourceLocationsWithChain_003Eb__0(AsyncOperationHandle op)
			{
				return default;
			}
		}

		[Token(Token = "0x200001A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B1014", Offset = "0x1B1014")]
		private sealed class _003C_003Ec__DisplayClass88_0<TObject>
		{
			[Token(Token = "0x400004D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public AddressablesImpl _003C_003E4__this;

			[Token(Token = "0x400004E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IList<IResourceLocation> locations;

			[Token(Token = "0x400004F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<TObject> callback;

			[Token(Token = "0x4000050")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool releaseDependenciesOnFailure;

			[Token(Token = "0x600015B")]
			public _003C_003Ec__DisplayClass88_0()
			{
			}

			[Token(Token = "0x600015C")]
			internal AsyncOperationHandle<IList<TObject>> _003CLoadAssetsWithChain_003Eb__0(AsyncOperationHandle op)
			{
				return default;
			}
		}

		[Token(Token = "0x200001B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B1024", Offset = "0x1B1024")]
		private sealed class _003C_003Ec__DisplayClass89_0<TObject>
		{
			[Token(Token = "0x4000051")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public AddressablesImpl _003C_003E4__this;

			[Token(Token = "0x4000052")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IEnumerable keys;

			[Token(Token = "0x4000053")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<TObject> callback;

			[Token(Token = "0x4000054")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Addressables.MergeMode mode;

			[Token(Token = "0x4000055")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool releaseDependenciesOnFailure;

			[Token(Token = "0x600015D")]
			public _003C_003Ec__DisplayClass89_0()
			{
			}

			[Token(Token = "0x600015E")]
			internal AsyncOperationHandle<IList<TObject>> _003CLoadAssetsWithChain_003Eb__0(AsyncOperationHandle op)
			{
				return default;
			}
		}

		[Token(Token = "0x200001C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B1034", Offset = "0x1B1034")]
		private sealed class _003C_003Ec__DisplayClass91_0<TObject>
		{
			[Token(Token = "0x4000056")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public AddressablesImpl _003C_003E4__this;

			[Token(Token = "0x4000057")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public object key;

			[Token(Token = "0x4000058")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<TObject> callback;

			[Token(Token = "0x4000059")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool releaseDependenciesOnFailure;

			[Token(Token = "0x600015F")]
			public _003C_003Ec__DisplayClass91_0()
			{
			}

			[Token(Token = "0x6000160")]
			internal AsyncOperationHandle<IList<TObject>> _003CLoadAssetsWithChain_003Eb__0(AsyncOperationHandle op2)
			{
				return default;
			}
		}

		[Token(Token = "0x200001D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B1044", Offset = "0x1B1044")]
		private sealed class _003C_003Ec__DisplayClass99_0
		{
			[Token(Token = "0x400005A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AddressablesImpl _003C_003E4__this;

			[Token(Token = "0x400005B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public object key;

			[Token(Token = "0x6000161")]
			[Address(RVA = "0x2A3A5A4", Offset = "0x2A3A5A4", VA = "0x2A3A5A4")]
			public _003C_003Ec__DisplayClass99_0()
			{
			}

			[Token(Token = "0x6000162")]
			[Address(RVA = "0x2A3A5AC", Offset = "0x2A3A5AC", VA = "0x2A3A5AC")]
			internal AsyncOperationHandle<long> _003CGetDownloadSizeWithChain_003Eb__0(AsyncOperationHandle op)
			{
				return default;
			}
		}

		[Token(Token = "0x200001E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B1054", Offset = "0x1B1054")]
		private sealed class _003C_003Ec__DisplayClass100_0
		{
			[Token(Token = "0x400005C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AddressablesImpl _003C_003E4__this;

			[Token(Token = "0x400005D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public IResourceLocation catalogLoc;

			[Token(Token = "0x6000163")]
			[Address(RVA = "0x2A39D10", Offset = "0x2A39D10", VA = "0x2A39D10")]
			public _003C_003Ec__DisplayClass100_0()
			{
			}

			[Token(Token = "0x6000164")]
			[Address(RVA = "0x2A39D18", Offset = "0x2A39D18", VA = "0x2A39D18")]
			internal AsyncOperationHandle<long> _003CComputeCatalogSizeWithChain_003Eb__0(AsyncOperationHandle op)
			{
				return default;
			}
		}

		[Token(Token = "0x200001F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B1064", Offset = "0x1B1064")]
		private sealed class _003C_003Ec__DisplayClass103_0
		{
			[Token(Token = "0x400005E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AddressablesImpl _003C_003E4__this;

			[Token(Token = "0x400005F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public IEnumerable keys;

			[Token(Token = "0x6000165")]
			[Address(RVA = "0x2A39F40", Offset = "0x2A39F40", VA = "0x2A39F40")]
			public _003C_003Ec__DisplayClass103_0()
			{
			}

			[Token(Token = "0x6000166")]
			[Address(RVA = "0x2A39F48", Offset = "0x2A39F48", VA = "0x2A39F48")]
			internal AsyncOperationHandle<long> _003CGetDownloadSizeWithChain_003Eb__0(AsyncOperationHandle op)
			{
				return default;
			}
		}

		[Token(Token = "0x2000020")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B1074", Offset = "0x1B1074")]
		private sealed class _003C_003Ec__DisplayClass106_0
		{
			[Token(Token = "0x4000060")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AddressablesImpl _003C_003E4__this;

			[Token(Token = "0x4000061")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public object key;

			[Token(Token = "0x6000167")]
			[Address(RVA = "0x2A39F6C", Offset = "0x2A39F6C", VA = "0x2A39F6C")]
			public _003C_003Ec__DisplayClass106_0()
			{
			}

			[Token(Token = "0x6000168")]
			[Address(RVA = "0x2A39F74", Offset = "0x2A39F74", VA = "0x2A39F74")]
			internal AsyncOperationHandle<IList<IAssetBundleResource>> _003CDownloadDependenciesAsyncWithChain_003Eb__0(AsyncOperationHandle op)
			{
				return default;
			}
		}

		[Token(Token = "0x2000021")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B1084", Offset = "0x1B1084")]
		private sealed class _003C_003Ec__DisplayClass110_0
		{
			[Token(Token = "0x4000062")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AddressablesImpl _003C_003E4__this;

			[Token(Token = "0x4000063")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public IList<IResourceLocation> locations;

			[Token(Token = "0x6000169")]
			[Address(RVA = "0x2A3A004", Offset = "0x2A3A004", VA = "0x2A3A004")]
			public _003C_003Ec__DisplayClass110_0()
			{
			}

			[Token(Token = "0x600016A")]
			[Address(RVA = "0x2A3A00C", Offset = "0x2A3A00C", VA = "0x2A3A00C")]
			internal AsyncOperationHandle<IList<IAssetBundleResource>> _003CDownloadDependenciesAsyncWithChain_003Eb__0(AsyncOperationHandle op)
			{
				return default;
			}
		}

		[Token(Token = "0x2000022")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B1094", Offset = "0x1B1094")]
		private sealed class _003C_003Ec__DisplayClass112_0
		{
			[Token(Token = "0x4000064")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AddressablesImpl _003C_003E4__this;

			[Token(Token = "0x4000065")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public IEnumerable keys;

			[Token(Token = "0x4000066")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Addressables.MergeMode mode;

			[Token(Token = "0x600016B")]
			[Address(RVA = "0x2A3A09C", Offset = "0x2A3A09C", VA = "0x2A3A09C")]
			public _003C_003Ec__DisplayClass112_0()
			{
			}

			[Token(Token = "0x600016C")]
			[Address(RVA = "0x2A3A0A4", Offset = "0x2A3A0A4", VA = "0x2A3A0A4")]
			internal AsyncOperationHandle<IList<IAssetBundleResource>> _003CDownloadDependenciesAsyncWithChain_003Eb__0(AsyncOperationHandle op)
			{
				return default;
			}
		}

		[Token(Token = "0x2000023")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B10A4", Offset = "0x1B10A4")]
		private sealed class _003C_003Ec__DisplayClass117_0<TObject>
		{
			[Token(Token = "0x4000067")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool unloadSceneOpExcludeReleaseCallback;

			[Token(Token = "0x4000068")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public AddressablesImpl _003C_003E4__this;

			[Token(Token = "0x600016D")]
			public _003C_003Ec__DisplayClass117_0()
			{
			}

			[Token(Token = "0x600016E")]
			internal void _003CAutoReleaseHandleOnCompletion_003Eb__0(AsyncOperationHandle<TObject> op)
			{
			}
		}

		[Token(Token = "0x2000024")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B10B4", Offset = "0x1B10B4")]
		private sealed class _003C_003Ec__DisplayClass119_0
		{
			[Token(Token = "0x4000069")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AddressablesImpl _003C_003E4__this;

			[Token(Token = "0x400006A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public object key;

			[Token(Token = "0x400006B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool autoReleaseHandle;

			[Token(Token = "0x600016F")]
			[Address(RVA = "0x2A3A138", Offset = "0x2A3A138", VA = "0x2A3A138")]
			public _003C_003Ec__DisplayClass119_0()
			{
			}

			[Token(Token = "0x6000170")]
			[Address(RVA = "0x2A3A140", Offset = "0x2A3A140", VA = "0x2A3A140")]
			internal AsyncOperationHandle<bool> _003CClearDependencyCacheAsync_003Eb__0(AsyncOperationHandle op)
			{
				return default;
			}
		}

		[Token(Token = "0x2000025")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B10C4", Offset = "0x1B10C4")]
		private sealed class _003C_003Ec__DisplayClass120_0
		{
			[Token(Token = "0x400006C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AddressablesImpl _003C_003E4__this;

			[Token(Token = "0x400006D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public IList<IResourceLocation> locations;

			[Token(Token = "0x400006E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool autoReleaseHandle;

			[Token(Token = "0x6000171")]
			[Address(RVA = "0x2A3A168", Offset = "0x2A3A168", VA = "0x2A3A168")]
			public _003C_003Ec__DisplayClass120_0()
			{
			}

			[Token(Token = "0x6000172")]
			[Address(RVA = "0x2A3A170", Offset = "0x2A3A170", VA = "0x2A3A170")]
			internal AsyncOperationHandle<bool> _003CClearDependencyCacheAsync_003Eb__0(AsyncOperationHandle op)
			{
				return default;
			}
		}

		[Token(Token = "0x2000026")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B10D4", Offset = "0x1B10D4")]
		private sealed class _003C_003Ec__DisplayClass121_0
		{
			[Token(Token = "0x400006F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AddressablesImpl _003C_003E4__this;

			[Token(Token = "0x4000070")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public IEnumerable keys;

			[Token(Token = "0x4000071")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool autoReleaseHandle;

			[Token(Token = "0x6000173")]
			[Address(RVA = "0x2A3A198", Offset = "0x2A3A198", VA = "0x2A3A198")]
			public _003C_003Ec__DisplayClass121_0()
			{
			}

			[Token(Token = "0x6000174")]
			[Address(RVA = "0x2A3A1A0", Offset = "0x2A3A1A0", VA = "0x2A3A1A0")]
			internal AsyncOperationHandle<bool> _003CClearDependencyCacheAsync_003Eb__0(AsyncOperationHandle op)
			{
				return default;
			}
		}

		[Token(Token = "0x2000027")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B10E4", Offset = "0x1B10E4")]
		private sealed class _003C_003Ec__DisplayClass126_0
		{
			[Token(Token = "0x4000072")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AddressablesImpl _003C_003E4__this;

			[Token(Token = "0x4000073")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public object key;

			[Token(Token = "0x4000074")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public InstantiationParameters instantiateParameters;

			[Token(Token = "0x6000175")]
			[Address(RVA = "0x2A3A1C8", Offset = "0x2A3A1C8", VA = "0x2A3A1C8")]
			public _003C_003Ec__DisplayClass126_0()
			{
			}

			[Token(Token = "0x6000176")]
			[Address(RVA = "0x2A3A1D0", Offset = "0x2A3A1D0", VA = "0x2A3A1D0")]
			internal AsyncOperationHandle<GameObject> _003CInstantiateWithChain_003Eb__0(AsyncOperationHandle op)
			{
				return default;
			}
		}

		[Token(Token = "0x2000028")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B10F4", Offset = "0x1B10F4")]
		private sealed class _003C_003Ec__DisplayClass128_0
		{
			[Token(Token = "0x4000075")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AddressablesImpl _003C_003E4__this;

			[Token(Token = "0x4000076")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public IResourceLocation location;

			[Token(Token = "0x4000077")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public InstantiationParameters instantiateParameters;

			[Token(Token = "0x6000177")]
			[Address(RVA = "0x2A3A21C", Offset = "0x2A3A21C", VA = "0x2A3A21C")]
			public _003C_003Ec__DisplayClass128_0()
			{
			}

			[Token(Token = "0x6000178")]
			[Address(RVA = "0x2A3A224", Offset = "0x2A3A224", VA = "0x2A3A224")]
			internal AsyncOperationHandle<GameObject> _003CInstantiateWithChain_003Eb__0(AsyncOperationHandle op)
			{
				return default;
			}
		}

		[Token(Token = "0x2000029")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B1104", Offset = "0x1B1104")]
		private sealed class _003C_003Ec__DisplayClass131_0
		{
			[Token(Token = "0x4000078")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AddressablesImpl _003C_003E4__this;

			[Token(Token = "0x4000079")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public object key;

			[Token(Token = "0x400007A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LoadSceneParameters loadSceneParameters;

			[Token(Token = "0x400007B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool activateOnLoad;

			[Token(Token = "0x400007C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public int priority;

			[Token(Token = "0x6000179")]
			[Address(RVA = "0x2A3A270", Offset = "0x2A3A270", VA = "0x2A3A270")]
			public _003C_003Ec__DisplayClass131_0()
			{
			}

			[Token(Token = "0x600017A")]
			[Address(RVA = "0x2A3A278", Offset = "0x2A3A278", VA = "0x2A3A278")]
			internal AsyncOperationHandle<SceneInstance> _003CLoadSceneWithChain_003Eb__0(AsyncOperationHandle op)
			{
				return default;
			}
		}

		[Token(Token = "0x200002A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B1114", Offset = "0x1B1114")]
		private sealed class _003C_003Ec__DisplayClass132_0
		{
			[Token(Token = "0x400007D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AddressablesImpl _003C_003E4__this;

			[Token(Token = "0x400007E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public IResourceLocation key;

			[Token(Token = "0x400007F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LoadSceneMode loadMode;

			[Token(Token = "0x4000080")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public bool activateOnLoad;

			[Token(Token = "0x4000081")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int priority;

			[Token(Token = "0x600017B")]
			[Address(RVA = "0x2A3A2A8", Offset = "0x2A3A2A8", VA = "0x2A3A2A8")]
			public _003C_003Ec__DisplayClass132_0()
			{
			}

			[Token(Token = "0x600017C")]
			[Address(RVA = "0x2A3A2B0", Offset = "0x2A3A2B0", VA = "0x2A3A2B0")]
			internal AsyncOperationHandle<SceneInstance> _003CLoadSceneWithChain_003Eb__0(AsyncOperationHandle op)
			{
				return default;
			}
		}

		[Token(Token = "0x200002B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B1124", Offset = "0x1B1124")]
		private sealed class _003C_003Ec__DisplayClass141_0
		{
			[Token(Token = "0x4000082")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AddressablesImpl _003C_003E4__this;

			[Token(Token = "0x4000083")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UnloadSceneOptions unloadOptions;

			[Token(Token = "0x4000084")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool autoReleaseHandle;

			[Token(Token = "0x600017D")]
			[Address(RVA = "0x2A3A2E4", Offset = "0x2A3A2E4", VA = "0x2A3A2E4")]
			public _003C_003Ec__DisplayClass141_0()
			{
			}

			[Token(Token = "0x600017E")]
			[Address(RVA = "0x2A3A2EC", Offset = "0x2A3A2EC", VA = "0x2A3A2EC")]
			internal AsyncOperationHandle<SceneInstance> _003CCreateUnloadSceneWithChain_003Eb__0(AsyncOperationHandle completedHandle)
			{
				return default;
			}
		}

		[Token(Token = "0x200002C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B1134", Offset = "0x1B1134")]
		private sealed class _003C_003Ec__DisplayClass142_0
		{
			[Token(Token = "0x4000085")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AddressablesImpl _003C_003E4__this;

			[Token(Token = "0x4000086")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UnloadSceneOptions unloadOptions;

			[Token(Token = "0x4000087")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool autoReleaseHandle;

			[Token(Token = "0x600017F")]
			[Address(RVA = "0x2A3A390", Offset = "0x2A3A390", VA = "0x2A3A390")]
			public _003C_003Ec__DisplayClass142_0()
			{
			}

			[Token(Token = "0x6000180")]
			[Address(RVA = "0x2A3A398", Offset = "0x2A3A398", VA = "0x2A3A398")]
			internal AsyncOperationHandle<SceneInstance> _003CCreateUnloadSceneWithChain_003Eb__0(AsyncOperationHandle<SceneInstance> completedHandle)
			{
				return default;
			}
		}

		[Token(Token = "0x200002D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B1144", Offset = "0x1B1144")]
		private sealed class _003C_003Ec__DisplayClass146_0
		{
			[Token(Token = "0x4000088")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AddressablesImpl _003C_003E4__this;

			[Token(Token = "0x4000089")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool autoReleaseHandle;

			[Token(Token = "0x6000181")]
			[Address(RVA = "0x2A3A3DC", Offset = "0x2A3A3DC", VA = "0x2A3A3DC")]
			public _003C_003Ec__DisplayClass146_0()
			{
			}

			[Token(Token = "0x6000182")]
			[Address(RVA = "0x2A3A3E4", Offset = "0x2A3A3E4", VA = "0x2A3A3E4")]
			internal AsyncOperationHandle<List<string>> _003CCheckForCatalogUpdatesWithChain_003Eb__0(AsyncOperationHandle op)
			{
				return default;
			}
		}

		[Token(Token = "0x200002E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B1154", Offset = "0x1B1154")]
		private sealed class _003C_003Ec__DisplayClass150_0
		{
			[Token(Token = "0x400008A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AddressablesImpl _003C_003E4__this;

			[Token(Token = "0x400008B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool autoReleaseHandle;

			[Token(Token = "0x400008C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			public bool autoCleanBundleCache;

			[Token(Token = "0x6000183")]
			[Address(RVA = "0x2A3A408", Offset = "0x2A3A408", VA = "0x2A3A408")]
			public _003C_003Ec__DisplayClass150_0()
			{
			}

			[Token(Token = "0x6000184")]
			[Address(RVA = "0x2A3A410", Offset = "0x2A3A410", VA = "0x2A3A410")]
			internal AsyncOperationHandle<List<IResourceLocator>> _003CUpdateCatalogs_003Eb__0(AsyncOperationHandle<List<string>> depOp)
			{
				return default;
			}
		}

		[Token(Token = "0x200002F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B1164", Offset = "0x1B1164")]
		private sealed class _003C_003Ec__DisplayClass155_0
		{
			[Token(Token = "0x400008D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AddressablesImpl _003C_003E4__this;

			[Token(Token = "0x400008E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public AsyncOperationHandle<IList<AsyncOperationHandle>> depOp;

			[Token(Token = "0x400008F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool forceSingleThreading;

			[Token(Token = "0x6000185")]
			[Address(RVA = "0x2A3A468", Offset = "0x2A3A468", VA = "0x2A3A468")]
			public _003C_003Ec__DisplayClass155_0()
			{
			}

			[Token(Token = "0x6000186")]
			[Address(RVA = "0x2A3A470", Offset = "0x2A3A470", VA = "0x2A3A470")]
			internal AsyncOperationHandle<bool> _003CCleanBundleCacheWithChain_003Eb__0(AsyncOperationHandle op)
			{
				return default;
			}
		}

		[Token(Token = "0x2000030")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B1174", Offset = "0x1B1174")]
		private sealed class _003C_003Ec__DisplayClass156_0
		{
			[Token(Token = "0x4000090")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AddressablesImpl _003C_003E4__this;

			[Token(Token = "0x4000091")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public IEnumerable<string> catalogIds;

			[Token(Token = "0x4000092")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool forceSingleThreading;

			[Token(Token = "0x6000187")]
			[Address(RVA = "0x2A3A4B4", Offset = "0x2A3A4B4", VA = "0x2A3A4B4")]
			public _003C_003Ec__DisplayClass156_0()
			{
			}

			[Token(Token = "0x6000188")]
			[Address(RVA = "0x2A3A4BC", Offset = "0x2A3A4BC", VA = "0x2A3A4BC")]
			internal AsyncOperationHandle<bool> _003CCleanBundleCacheWithChain_003Eb__0(AsyncOperationHandle op)
			{
				return default;
			}
		}

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private ResourceManager m_ResourceManager;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IInstanceProvider m_InstanceProvider;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int m_CatalogRequestsTimeout;

		[Token(Token = "0x4000022")]
		internal const string kCacheDataFolder = "{UnityEngine.Application.persistentDataPath}/com.unity.addressables/";

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ISceneProvider SceneProvider;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal List<ResourceLocatorInfo> m_ResourceLocators;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private AsyncOperationHandle<IResourceLocator> m_InitializationOperation;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private AsyncOperationHandle<List<string>> m_ActiveCheckUpdateOperation;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		internal AsyncOperationHandle<List<IResourceLocator>> m_ActiveUpdateOperation;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Action<AsyncOperationHandle> m_OnHandleCompleteAction;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Action<AsyncOperationHandle> m_OnSceneHandleCompleteAction;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Action<AsyncOperationHandle> m_OnHandleDestroyedAction;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Dictionary<object, AsyncOperationHandle> m_resultToHandle;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		internal HashSet<AsyncOperationHandle> m_SceneInstances;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private AsyncOperationHandle<bool> m_ActiveCleanBundleCacheOperation;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		internal bool hasStartedInitialization;

		[Token(Token = "0x1700001A")]
		public IInstanceProvider InstanceProvider
		{
			[Token(Token = "0x60000BE")]
			[Address(RVA = "0x2A1ED5C", Offset = "0x2A1ED5C", VA = "0x2A1ED5C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000BF")]
			[Address(RVA = "0x2A1ED64", Offset = "0x2A1ED64", VA = "0x2A1ED64")]
			set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public ResourceManager ResourceManager
		{
			[Token(Token = "0x60000C0")]
			[Address(RVA = "0x2A147D0", Offset = "0x2A147D0", VA = "0x2A147D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001C")]
		public int CatalogRequestsTimeout
		{
			[Token(Token = "0x60000C1")]
			[Address(RVA = "0x2A1EDEC", Offset = "0x2A1EDEC", VA = "0x2A1EDEC")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000C2")]
			[Address(RVA = "0x2A1EDF4", Offset = "0x2A1EDF4", VA = "0x2A1EDF4")]
			set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		internal int SceneOperationCount
		{
			[Token(Token = "0x60000C3")]
			[Address(RVA = "0x2A1EDFC", Offset = "0x2A1EDFC", VA = "0x2A1EDFC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700001E")]
		internal int TrackedHandleCount
		{
			[Token(Token = "0x60000C4")]
			[Address(RVA = "0x2A1EE48", Offset = "0x2A1EE48", VA = "0x2A1EE48")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700001F")]
		public Func<IResourceLocation, string> InternalIdTransformFunc
		{
			[Token(Token = "0x60000C7")]
			[Address(RVA = "0x2A14BBC", Offset = "0x2A14BBC", VA = "0x2A14BBC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000C8")]
			[Address(RVA = "0x2A14C98", Offset = "0x2A14C98", VA = "0x2A14C98")]
			set
			{
			}
		}

		[Token(Token = "0x17000020")]
		public Action<UnityWebRequest> WebRequestOverride
		{
			[Token(Token = "0x60000C9")]
			[Address(RVA = "0x2A14D74", Offset = "0x2A14D74", VA = "0x2A14D74")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000CA")]
			[Address(RVA = "0x2A14E50", Offset = "0x2A14E50", VA = "0x2A14E50")]
			set
			{
			}
		}

		[Token(Token = "0x17000021")]
		public AsyncOperationHandle ChainOperation
		{
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0x2A1EF68", Offset = "0x2A1EF68", VA = "0x2A1EF68")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000022")]
		internal bool ShouldChainRequest
		{
			[Token(Token = "0x60000CC")]
			[Address(RVA = "0x2A1F104", Offset = "0x2A1F104", VA = "0x2A1F104")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000023")]
		public string StreamingAssetsSubFolder
		{
			[Token(Token = "0x60000CE")]
			[Address(RVA = "0x2A14F4C", Offset = "0x2A14F4C", VA = "0x2A14F4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000024")]
		public string BuildPath
		{
			[Token(Token = "0x60000CF")]
			[Address(RVA = "0x2A15034", Offset = "0x2A15034", VA = "0x2A15034")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000025")]
		public string PlayerBuildDataPath
		{
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0x2A1528C", Offset = "0x2A1528C", VA = "0x2A1528C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000026")]
		public string RuntimePath
		{
			[Token(Token = "0x60000D1")]
			[Address(RVA = "0x2A15438", Offset = "0x2A15438", VA = "0x2A15438")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000027")]
		public IEnumerable<IResourceLocator> ResourceLocators
		{
			[Token(Token = "0x60000DB")]
			[Address(RVA = "0x2A1556C", Offset = "0x2A1556C", VA = "0x2A1556C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000028")]
		internal IEnumerable<string> CatalogsWithAvailableUpdates
		{
			[Token(Token = "0x6000132")]
			[Address(RVA = "0x2A258C4", Offset = "0x2A258C4", VA = "0x2A258C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x2A1EB80", Offset = "0x2A1EB80", VA = "0x2A1EB80")]
		public AddressablesImpl(IAllocationStrategy alloc)
		{
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x2A1EE9C", Offset = "0x2A1EE9C", VA = "0x2A1EE9C")]
		internal void ReleaseSceneManagerOperation()
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x2A1F1D8", Offset = "0x2A1F1D8", VA = "0x2A1F1D8")]
		internal void OnSceneUnloaded(Scene scene)
		{
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x2A15990", Offset = "0x2A15990", VA = "0x2A15990")]
		public void Log(string msg)
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x2A15D20", Offset = "0x2A15D20", VA = "0x2A15D20")]
		public void LogFormat(string format, params object[] args)
		{
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x2A158B8", Offset = "0x2A158B8", VA = "0x2A158B8")]
		public void LogWarning(string msg)
		{
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x2A15C38", Offset = "0x2A15C38", VA = "0x2A15C38")]
		public void LogWarningFormat(string format, params object[] args)
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x2A15924", Offset = "0x2A15924", VA = "0x2A15924")]
		public void LogError(string msg)
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x2A16354", Offset = "0x2A16354", VA = "0x2A16354")]
		public void LogException(AsyncOperationHandle op, Exception ex)
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x2A164AC", Offset = "0x2A164AC", VA = "0x2A164AC")]
		public void LogException(Exception ex)
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x2A15CAC", Offset = "0x2A15CAC", VA = "0x2A15CAC")]
		public void LogErrorFormat(string format, params object[] args)
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x2A14AA4", Offset = "0x2A14AA4", VA = "0x2A14AA4")]
		public string ResolveInternalId(string id)
		{
			return null;
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x2A1E0C4", Offset = "0x2A1E0C4", VA = "0x2A1E0C4")]
		public void AddResourceLocator(IResourceLocator loc, [Optional] string localCatalogHash, [Optional] IResourceLocation remoteCatalogLocation)
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x2A1E220", Offset = "0x2A1E220", VA = "0x2A1E220")]
		public void RemoveResourceLocator(IResourceLocator loc)
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x2A1E3F0", Offset = "0x2A1E3F0", VA = "0x2A1E3F0")]
		public void ClearResourceLocators()
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x2A1F744", Offset = "0x2A1F744", VA = "0x2A1F744")]
		internal bool GetResourceLocations(object key, Type type, out IList<IResourceLocation> locations)
		{
			return default;
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x2A1FEFC", Offset = "0x2A1FEFC", VA = "0x2A1FEFC")]
		internal bool GetResourceLocations(IEnumerable keys, Type type, Addressables.MergeMode merge, out IList<IResourceLocation> locations)
		{
			return default;
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x2A2040C", Offset = "0x2A2040C", VA = "0x2A2040C")]
		public AsyncOperationHandle<IResourceLocator> InitializeAsync(string runtimeDataPath, [Optional] string providerSuffix, bool autoReleaseHandle = true)
		{
			return default;
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x2A166D4", Offset = "0x2A166D4", VA = "0x2A166D4")]
		public AsyncOperationHandle<IResourceLocator> InitializeAsync()
		{
			return default;
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x2A168E0", Offset = "0x2A168E0", VA = "0x2A168E0")]
		public AsyncOperationHandle<IResourceLocator> InitializeAsync(bool autoReleaseHandle)
		{
			return default;
		}

		[Token(Token = "0x60000E4")]
		public ResourceLocationBase CreateCatalogLocationWithHashDependencies<T>(IResourceLocation catalogLocation) where T : IResourceProvider
		{
			return null;
		}

		[Token(Token = "0x60000E5")]
		public ResourceLocationBase CreateCatalogLocationWithHashDependencies<T>(string catalogLocation) where T : IResourceProvider
		{
			return null;
		}

		[Token(Token = "0x60000E6")]
		public ResourceLocationBase CreateCatalogLocationWithHashDependencies<T>(string catalogPath, string hashFilePath) where T : IResourceProvider
		{
			return null;
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x2A20EF0", Offset = "0x2A20EF0", VA = "0x2A20EF0")]
		private void QueueEditorUpdateIfNeeded()
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x2A16BA4", Offset = "0x2A16BA4", VA = "0x2A16BA4")]
		public AsyncOperationHandle<IResourceLocator> LoadContentCatalogAsync(string catalogPath, [Optional][DefaultParameterValue(true)] bool autoReleaseHandle, [Optional] string providerSuffix)
		{
			return default;
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x2A215C4", Offset = "0x2A215C4", VA = "0x2A215C4")]
		private AsyncOperationHandle<SceneInstance> TrackHandle(AsyncOperationHandle<SceneInstance> handle)
		{
			return default;
		}

		[Token(Token = "0x60000EA")]
		private AsyncOperationHandle<TObject> TrackHandle<TObject>(AsyncOperationHandle<TObject> handle)
		{
			return default;
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x2A21698", Offset = "0x2A21698", VA = "0x2A21698")]
		private AsyncOperationHandle TrackHandle(AsyncOperationHandle handle)
		{
			return default;
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x2A216D8", Offset = "0x2A216D8", VA = "0x2A216D8")]
		internal void ClearTrackHandles()
		{
		}

		[Token(Token = "0x60000ED")]
		public AsyncOperationHandle<TObject> LoadAssetAsync<TObject>(IResourceLocation location)
		{
			return default;
		}

		[Token(Token = "0x60000EE")]
		private AsyncOperationHandle<TObject> LoadAssetWithChain<TObject>(AsyncOperationHandle dep, IResourceLocation loc)
		{
			return default;
		}

		[Token(Token = "0x60000EF")]
		private AsyncOperationHandle<TObject> LoadAssetWithChain<TObject>(AsyncOperationHandle dep, object key)
		{
			return default;
		}

		[Token(Token = "0x60000F0")]
		public AsyncOperationHandle<TObject> LoadAssetAsync<TObject>(object key)
		{
			return default;
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x2A2172C", Offset = "0x2A2172C", VA = "0x2A2172C")]
		public AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocationsWithChain(AsyncOperationHandle dep, IEnumerable keys, Addressables.MergeMode mode, Type type)
		{
			return default;
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x2A16FEC", Offset = "0x2A16FEC", VA = "0x2A16FEC")]
		public AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocationsAsync(IEnumerable keys, Addressables.MergeMode mode, [Optional] Type type)
		{
			return default;
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x2A21888", Offset = "0x2A21888", VA = "0x2A21888")]
		public AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocationsWithChain(AsyncOperationHandle dep, object key, Type type)
		{
			return default;
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x2A17374", Offset = "0x2A17374", VA = "0x2A17374")]
		public AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocationsAsync(object key, [Optional] Type type)
		{
			return default;
		}

		[Token(Token = "0x60000F5")]
		public AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(IList<IResourceLocation> locations, Action<TObject> callback, bool releaseDependenciesOnFailure)
		{
			return default;
		}

		[Token(Token = "0x60000F6")]
		private AsyncOperationHandle<IList<TObject>> LoadAssetsWithChain<TObject>(AsyncOperationHandle dep, IList<IResourceLocation> locations, Action<TObject> callback, bool releaseDependenciesOnFailure)
		{
			return default;
		}

		[Token(Token = "0x60000F7")]
		private AsyncOperationHandle<IList<TObject>> LoadAssetsWithChain<TObject>(AsyncOperationHandle dep, IEnumerable keys, Action<TObject> callback, Addressables.MergeMode mode, bool releaseDependenciesOnFailure)
		{
			return default;
		}

		[Token(Token = "0x60000F8")]
		public AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(IEnumerable keys, Action<TObject> callback, Addressables.MergeMode mode, bool releaseDependenciesOnFailure)
		{
			return default;
		}

		[Token(Token = "0x60000F9")]
		private AsyncOperationHandle<IList<TObject>> LoadAssetsWithChain<TObject>(AsyncOperationHandle dep, object key, Action<TObject> callback, bool releaseDependenciesOnFailure)
		{
			return default;
		}

		[Token(Token = "0x60000FA")]
		public AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(object key, Action<TObject> callback, bool releaseDependenciesOnFailure)
		{
			return default;
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x2A219DC", Offset = "0x2A219DC", VA = "0x2A219DC")]
		private void OnHandleDestroyed(AsyncOperationHandle handle)
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x2A21A74", Offset = "0x2A21A74", VA = "0x2A21A74")]
		private void OnSceneHandleCompleted(AsyncOperationHandle handle)
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x2A21BA0", Offset = "0x2A21BA0", VA = "0x2A21BA0")]
		private void OnHandleCompleted(AsyncOperationHandle handle)
		{
		}

		[Token(Token = "0x60000FE")]
		public void Release<TObject>(TObject obj)
		{
		}

		[Token(Token = "0x60000FF")]
		public void Release<TObject>(AsyncOperationHandle<TObject> handle)
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x2A17584", Offset = "0x2A17584", VA = "0x2A17584")]
		public void Release(AsyncOperationHandle handle)
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x2A21C94", Offset = "0x2A21C94", VA = "0x2A21C94")]
		private AsyncOperationHandle<long> GetDownloadSizeWithChain(AsyncOperationHandle dep, object key)
		{
			return default;
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x2A21DD8", Offset = "0x2A21DD8", VA = "0x2A21DD8")]
		private AsyncOperationHandle<long> ComputeCatalogSizeWithChain(IResourceLocation catalogLoc)
		{
			return default;
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x2A221E0", Offset = "0x2A221E0", VA = "0x2A221E0")]
		internal bool IsCatalogCached(IResourceLocation catalogLoc, Hash128 remoteHash)
		{
			return default;
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x2A2268C", Offset = "0x2A2268C", VA = "0x2A2268C")]
		internal AsyncOperationHandle<long> GetRemoteCatalogHeaderSize(IResourceLocation catalogLoc)
		{
			return default;
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x2A22B40", Offset = "0x2A22B40", VA = "0x2A22B40")]
		private AsyncOperationHandle<long> GetDownloadSizeWithChain(AsyncOperationHandle dep, IEnumerable keys)
		{
			return default;
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x2A17AD4", Offset = "0x2A17AD4", VA = "0x2A17AD4")]
		public AsyncOperationHandle<long> GetDownloadSizeAsync(object key)
		{
			return default;
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x2A17D08", Offset = "0x2A17D08", VA = "0x2A17D08")]
		public AsyncOperationHandle<long> GetDownloadSizeAsync(IEnumerable keys)
		{
			return default;
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x2A22D10", Offset = "0x2A22D10", VA = "0x2A22D10")]
		private AsyncOperationHandle DownloadDependenciesAsyncWithChain(AsyncOperationHandle dep, object key, bool autoReleaseHandle)
		{
			return default;
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x2A22EC4", Offset = "0x2A22EC4", VA = "0x2A22EC4")]
		internal static void WrapAsDownloadLocations(List<IResourceLocation> locations)
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x2A22FBC", Offset = "0x2A22FBC", VA = "0x2A22FBC")]
		private static List<IResourceLocation> GatherDependenciesFromLocations(IList<IResourceLocation> locations)
		{
			return null;
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x2A18E98", Offset = "0x2A18E98", VA = "0x2A18E98")]
		public AsyncOperationHandle DownloadDependenciesAsync(object key, bool autoReleaseHandle = false)
		{
			return default;
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x2A2390C", Offset = "0x2A2390C", VA = "0x2A2390C")]
		private AsyncOperationHandle DownloadDependenciesAsyncWithChain(AsyncOperationHandle dep, IList<IResourceLocation> locations, bool autoReleaseHandle)
		{
			return default;
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x2A1922C", Offset = "0x2A1922C", VA = "0x2A1922C")]
		public AsyncOperationHandle DownloadDependenciesAsync(IList<IResourceLocation> locations, bool autoReleaseHandle = false)
		{
			return default;
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x2A23AC0", Offset = "0x2A23AC0", VA = "0x2A23AC0")]
		private AsyncOperationHandle DownloadDependenciesAsyncWithChain(AsyncOperationHandle dep, IEnumerable keys, Addressables.MergeMode mode, bool autoReleaseHandle)
		{
			return default;
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x2A1942C", Offset = "0x2A1942C", VA = "0x2A1942C")]
		public AsyncOperationHandle DownloadDependenciesAsync(IEnumerable keys, Addressables.MergeMode mode, bool autoReleaseHandle = false)
		{
			return default;
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x2A23D48", Offset = "0x2A23D48", VA = "0x2A23D48")]
		internal bool ClearDependencyCacheForKey(object key)
		{
			return default;
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x2A2461C", Offset = "0x2A2461C", VA = "0x2A2461C")]
		internal void AutoReleaseHandleOnCompletion(AsyncOperationHandle handle)
		{
		}

		[Token(Token = "0x6000112")]
		internal void AutoReleaseHandleOnCompletion<TObject>(AsyncOperationHandle<TObject> handle)
		{
		}

		[Token(Token = "0x6000113")]
		internal void AutoReleaseHandleOnCompletion<TObject>(AsyncOperationHandle<TObject> handle, bool unloadSceneOpExcludeReleaseCallback)
		{
		}

		[Token(Token = "0x6000114")]
		internal void AutoReleaseHandleOnTypelessCompletion<TObject>(AsyncOperationHandle<TObject> handle)
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x2A19854", Offset = "0x2A19854", VA = "0x2A19854")]
		public AsyncOperationHandle<bool> ClearDependencyCacheAsync(object key, bool autoReleaseHandle)
		{
			return default;
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x2A19B6C", Offset = "0x2A19B6C", VA = "0x2A19B6C")]
		public AsyncOperationHandle<bool> ClearDependencyCacheAsync(IList<IResourceLocation> locations, bool autoReleaseHandle)
		{
			return default;
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x2A1A140", Offset = "0x2A1A140", VA = "0x2A1A140")]
		public AsyncOperationHandle<bool> ClearDependencyCacheAsync(IEnumerable keys, bool autoReleaseHandle)
		{
			return default;
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x2A246C4", Offset = "0x2A246C4", VA = "0x2A246C4")]
		public AsyncOperationHandle<GameObject> InstantiateAsync(IResourceLocation location, [Optional] Transform parent, bool instantiateInWorldSpace = false, bool trackHandle = true)
		{
			return default;
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x2A1BD90", Offset = "0x2A1BD90", VA = "0x2A1BD90")]
		public AsyncOperationHandle<GameObject> InstantiateAsync(IResourceLocation location, Vector3 position, Quaternion rotation, [Optional] Transform parent, bool trackHandle = true)
		{
			return default;
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x2A1BE0C", Offset = "0x2A1BE0C", VA = "0x2A1BE0C")]
		public AsyncOperationHandle<GameObject> InstantiateAsync(object key, [Optional] Transform parent, bool instantiateInWorldSpace = false, bool trackHandle = true)
		{
			return default;
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x2A1BE8C", Offset = "0x2A1BE8C", VA = "0x2A1BE8C")]
		public AsyncOperationHandle<GameObject> InstantiateAsync(object key, Vector3 position, Quaternion rotation, [Optional] Transform parent, bool trackHandle = true)
		{
			return default;
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x2A24744", Offset = "0x2A24744", VA = "0x2A24744")]
		private AsyncOperationHandle<GameObject> InstantiateWithChain(AsyncOperationHandle dep, object key, InstantiationParameters instantiateParameters, bool trackHandle = true)
		{
			return default;
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x2A1BF08", Offset = "0x2A1BF08", VA = "0x2A1BF08")]
		public AsyncOperationHandle<GameObject> InstantiateAsync(object key, InstantiationParameters instantiateParameters, bool trackHandle = true)
		{
			return default;
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x2A248E0", Offset = "0x2A248E0", VA = "0x2A248E0")]
		private AsyncOperationHandle<GameObject> InstantiateWithChain(AsyncOperationHandle dep, IResourceLocation location, InstantiationParameters instantiateParameters, bool trackHandle = true)
		{
			return default;
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x2A1BC80", Offset = "0x2A1BC80", VA = "0x2A1BC80")]
		public AsyncOperationHandle<GameObject> InstantiateAsync(IResourceLocation location, InstantiationParameters instantiateParameters, bool trackHandle = true)
		{
			return default;
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x2A17678", Offset = "0x2A17678", VA = "0x2A17678")]
		public bool ReleaseInstance(GameObject instance)
		{
			return default;
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x2A24A7C", Offset = "0x2A24A7C", VA = "0x2A24A7C")]
		internal AsyncOperationHandle<SceneInstance> LoadSceneWithChain(AsyncOperationHandle dep, object key, LoadSceneParameters loadSceneParameters, bool activateOnLoad = true, int priority = 100)
		{
			return default;
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x2A24BF0", Offset = "0x2A24BF0", VA = "0x2A24BF0")]
		internal AsyncOperationHandle<SceneInstance> LoadSceneWithChain(AsyncOperationHandle dep, IResourceLocation key, LoadSceneMode loadMode = LoadSceneMode.Single, bool activateOnLoad = true, int priority = 100)
		{
			return default;
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x2A24D64", Offset = "0x2A24D64", VA = "0x2A24D64")]
		public AsyncOperationHandle<SceneInstance> LoadSceneAsync(object key)
		{
			return default;
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x2A1C778", Offset = "0x2A1C778", VA = "0x2A1C778")]
		public AsyncOperationHandle<SceneInstance> LoadSceneAsync(object key, LoadSceneParameters loadSceneParameters, bool activateOnLoad = true, int priority = 100, bool trackHandle = true)
		{
			return default;
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x2A24DCC", Offset = "0x2A24DCC", VA = "0x2A24DCC")]
		public AsyncOperationHandle<SceneInstance> LoadSceneAsync(IResourceLocation location)
		{
			return default;
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x2A24E34", Offset = "0x2A24E34", VA = "0x2A24E34")]
		public AsyncOperationHandle<SceneInstance> LoadSceneAsync(IResourceLocation location, LoadSceneMode loadMode = LoadSceneMode.Single, bool activateOnLoad = true, int priority = 100, bool trackHandle = true)
		{
			return default;
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x2A1CB48", Offset = "0x2A1CB48", VA = "0x2A1CB48")]
		public AsyncOperationHandle<SceneInstance> LoadSceneAsync(IResourceLocation location, LoadSceneParameters loadSceneParameters, bool activateOnLoad = true, int priority = 100, bool trackHandle = true)
		{
			return default;
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x2A1D460", Offset = "0x2A1D460", VA = "0x2A1D460")]
		public AsyncOperationHandle<SceneInstance> UnloadSceneAsync(SceneInstance scene, UnloadSceneOptions unloadOptions = UnloadSceneOptions.None, bool autoReleaseHandle = true)
		{
			return default;
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x2A1D6C8", Offset = "0x2A1D6C8", VA = "0x2A1D6C8")]
		public AsyncOperationHandle<SceneInstance> UnloadSceneAsync(AsyncOperationHandle handle, UnloadSceneOptions unloadOptions = UnloadSceneOptions.None, bool autoReleaseHandle = true)
		{
			return default;
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x2A1D818", Offset = "0x2A1D818", VA = "0x2A1D818")]
		public AsyncOperationHandle<SceneInstance> UnloadSceneAsync(AsyncOperationHandle<SceneInstance> handle, UnloadSceneOptions unloadOptions = UnloadSceneOptions.None, bool autoReleaseHandle = true)
		{
			return default;
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x2A24EB0", Offset = "0x2A24EB0", VA = "0x2A24EB0")]
		internal AsyncOperationHandle<SceneInstance> CreateUnloadSceneWithChain(AsyncOperationHandle handle, UnloadSceneOptions unloadOptions, bool autoReleaseHandle)
		{
			return default;
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x2A24FF8", Offset = "0x2A24FF8", VA = "0x2A24FF8")]
		internal AsyncOperationHandle<SceneInstance> CreateUnloadSceneWithChain(AsyncOperationHandle<SceneInstance> handle, UnloadSceneOptions unloadOptions, bool autoReleaseHandle)
		{
			return default;
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x2A25130", Offset = "0x2A25130", VA = "0x2A25130")]
		internal AsyncOperationHandle<SceneInstance> InternalUnloadScene(AsyncOperationHandle<SceneInstance> handle, UnloadSceneOptions unloadOptions, bool autoReleaseHandle)
		{
			return default;
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x2A1FE04", Offset = "0x2A1FE04", VA = "0x2A1FE04")]
		private object EvaluateKey(object obj)
		{
			return null;
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x2A1D9FC", Offset = "0x2A1D9FC", VA = "0x2A1D9FC")]
		internal AsyncOperationHandle<List<string>> CheckForCatalogUpdates(bool autoReleaseHandle = true)
		{
			return default;
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x2A251F4", Offset = "0x2A251F4", VA = "0x2A251F4")]
		internal AsyncOperationHandle<List<string>> CheckForCatalogUpdatesWithChain(bool autoReleaseHandle)
		{
			return default;
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x2A1AC78", Offset = "0x2A1AC78", VA = "0x2A1AC78")]
		public ResourceLocatorInfo GetLocatorInfo(string c)
		{
			return null;
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x2A1DC5C", Offset = "0x2A1DC5C", VA = "0x2A1DC5C")]
		internal AsyncOperationHandle<List<IResourceLocator>> UpdateCatalogs([Optional] IEnumerable<string> catalogIds, bool autoReleaseHandle = true, bool autoCleanBundleCache = false)
		{
			return default;
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x2A26210", Offset = "0x2A26210", VA = "0x2A26210", Slot = "4")]
		public bool Equals(IResourceLocation x, IResourceLocation y)
		{
			return default;
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x2A26554", Offset = "0x2A26554", VA = "0x2A26554", Slot = "5")]
		public int GetHashCode(IResourceLocation loc)
		{
			return default;
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x2A1E504", Offset = "0x2A1E504", VA = "0x2A1E504")]
		internal AsyncOperationHandle<bool> CleanBundleCache(IEnumerable<string> catalogIds, bool forceSingleThreading)
		{
			return default;
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x2A267F0", Offset = "0x2A267F0", VA = "0x2A267F0")]
		internal AsyncOperationHandle<bool> CleanBundleCache(AsyncOperationHandle<IList<AsyncOperationHandle>> depOp, bool forceSingleThreading)
		{
			return default;
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x2A269D8", Offset = "0x2A269D8", VA = "0x2A269D8")]
		internal AsyncOperationHandle<bool> CleanBundleCacheWithChain(AsyncOperationHandle<IList<AsyncOperationHandle>> depOp, bool forceSingleThreading)
		{
			return default;
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x2A266AC", Offset = "0x2A266AC", VA = "0x2A266AC")]
		internal AsyncOperationHandle<bool> CleanBundleCacheWithChain(IEnumerable<string> catalogIds, bool forceSingleThreading)
		{
			return default;
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x2A26CC4", Offset = "0x2A26CC4", VA = "0x2A26CC4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B1DC4", Offset = "0x1B1DC4")]
		private void _003CTrackHandle_003Eb__73_0(AsyncOperationHandle<SceneInstance> sceneHandle)
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x2A26D74", Offset = "0x2A26D74", VA = "0x2A26D74")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B1DD4", Offset = "0x1B1DD4")]
		private AsyncOperationHandle<long> _003CGetRemoteCatalogHeaderSize_003Eb__102_0(AsyncOperationHandle<UnityWebRequest> getOp)
		{
			return default;
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x2A26EA0", Offset = "0x2A26EA0", VA = "0x2A26EA0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B1DE4", Offset = "0x1B1DE4")]
		private void _003CAutoReleaseHandleOnCompletion_003Eb__115_0(AsyncOperationHandle op)
		{
		}

		[Token(Token = "0x600013D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B1DF4", Offset = "0x1B1DF4")]
		private void _003CAutoReleaseHandleOnCompletion_003Eb__116_0<TObject>(AsyncOperationHandle<TObject> op)
		{
		}

		[Token(Token = "0x600013E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B1E04", Offset = "0x1B1E04")]
		private void _003CAutoReleaseHandleOnTypelessCompletion_003Eb__118_0<TObject>(AsyncOperationHandle op)
		{
		}
	}
}
