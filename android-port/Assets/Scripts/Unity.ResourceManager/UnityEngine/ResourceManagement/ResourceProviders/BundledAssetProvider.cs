using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.ResourceManagement.ResourceProviders
{
	[Token(Token = "0x200004B")]
	[Attribute(Name = "DisplayNameAttribute", RVA = "0x1B7B58", Offset = "0x1B7B58")]
	public class BundledAssetProvider : ResourceProviderBase
	{
		[Token(Token = "0x200004C")]
		internal class InternalOp
		{
			[Token(Token = "0x40000D0")]
			[FieldOffset(Offset = "0x10")]
			private AssetBundle m_AssetBundle;

			[Token(Token = "0x40000D1")]
			[FieldOffset(Offset = "0x18")]
			private AssetBundleRequest m_PreloadRequest;

			[Token(Token = "0x40000D2")]
			[FieldOffset(Offset = "0x20")]
			private AssetBundleRequest m_RequestOperation;

			[Token(Token = "0x40000D3")]
			[FieldOffset(Offset = "0x28")]
			private object m_Result;

			[Token(Token = "0x40000D4")]
			[FieldOffset(Offset = "0x30")]
			private ProvideHandle m_ProvideHandle;

			[Token(Token = "0x40000D5")]
			[FieldOffset(Offset = "0x48")]
			private string subObjectName;

			[Token(Token = "0x60001C4")]
			internal static T LoadBundleFromDependecies<T>(IList<object> results) where T : class, IAssetBundleResource
			{
				return null;
			}

			[Token(Token = "0x60001C5")]
			[Address(RVA = "0x2A6378C", Offset = "0x2A6378C", VA = "0x2A6378C")]
			public void Start(ProvideHandle provideHandle)
			{
			}

			[Token(Token = "0x60001C6")]
			[Address(RVA = "0x2A75F8C", Offset = "0x2A75F8C", VA = "0x2A75F8C")]
			private void BeginAssetLoad()
			{
			}

			[Token(Token = "0x60001C7")]
			[Address(RVA = "0x2A76A8C", Offset = "0x2A76A8C", VA = "0x2A76A8C")]
			private bool WaitForCompletionHandler()
			{
				return default;
			}

			[Token(Token = "0x60001C8")]
			[Address(RVA = "0x2A768E4", Offset = "0x2A768E4", VA = "0x2A768E4")]
			private void ActionComplete(AsyncOperation obj)
			{
			}

			[Token(Token = "0x60001C9")]
			[Address(RVA = "0x2A765EC", Offset = "0x2A765EC", VA = "0x2A765EC")]
			private void GetArrayResult(Object[] allAssets)
			{
			}

			[Token(Token = "0x60001CA")]
			[Address(RVA = "0x2A76700", Offset = "0x2A76700", VA = "0x2A76700")]
			private void GetListResult(Object[] allAssets)
			{
			}

			[Token(Token = "0x60001CB")]
			[Address(RVA = "0x2A76808", Offset = "0x2A76808", VA = "0x2A76808")]
			private void GetAssetResult(Object asset)
			{
			}

			[Token(Token = "0x60001CC")]
			[Address(RVA = "0x2A76734", Offset = "0x2A76734", VA = "0x2A76734")]
			private void GetAssetSubObjectResult(Object[] allAssets)
			{
			}

			[Token(Token = "0x60001CD")]
			[Address(RVA = "0x2A76620", Offset = "0x2A76620", VA = "0x2A76620")]
			private void CompleteOperation()
			{
			}

			[Token(Token = "0x60001CE")]
			[Address(RVA = "0x2A76BA0", Offset = "0x2A76BA0", VA = "0x2A76BA0")]
			public float ProgressCallback()
			{
				return default;
			}

			[Token(Token = "0x60001CF")]
			[Address(RVA = "0x2A63784", Offset = "0x2A63784", VA = "0x2A63784")]
			public InternalOp()
			{
			}

			[Token(Token = "0x60001D0")]
			[Address(RVA = "0x2A76BB8", Offset = "0x2A76BB8", VA = "0x2A76BB8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B8554", Offset = "0x1B8554")]
			private void _003CStart_003Eb__7_0(AsyncOperation operation)
			{
			}
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x2A636F8", Offset = "0x2A636F8", VA = "0x2A636F8", Slot = "17")]
		public override void Provide(ProvideHandle provideHandle)
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x2A63BAC", Offset = "0x2A63BAC", VA = "0x2A63BAC")]
		public BundledAssetProvider()
		{
		}
	}
}
