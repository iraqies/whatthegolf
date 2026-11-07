using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;

namespace UnityEngine.ResourceManagement.ResourceProviders
{
	[Token(Token = "0x2000050")]
	public struct ProvideHandle
	{
		[Token(Token = "0x40000DE")]
		[FieldOffset(Offset = "0x0")]
		private int m_Version;

		[Token(Token = "0x40000DF")]
		[FieldOffset(Offset = "0x8")]
		private IGenericProviderOperation m_InternalOp;

		[Token(Token = "0x40000E0")]
		[FieldOffset(Offset = "0x10")]
		private ResourceManager m_ResourceManager;

		[Token(Token = "0x1700004E")]
		internal bool IsValid
		{
			[Token(Token = "0x60001DC")]
			[Address(RVA = "0x2A5DEEC", Offset = "0x2A5DEEC", VA = "0x2A5DEEC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700004F")]
		internal IGenericProviderOperation InternalOp
		{
			[Token(Token = "0x60001DD")]
			[Address(RVA = "0x2A6B044", Offset = "0x2A6B044", VA = "0x2A6B044")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000050")]
		public ResourceManager ResourceManager
		{
			[Token(Token = "0x60001DE")]
			[Address(RVA = "0x2A6B158", Offset = "0x2A6B158", VA = "0x2A6B158")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000051")]
		public Type Type
		{
			[Token(Token = "0x60001DF")]
			[Address(RVA = "0x2A690D0", Offset = "0x2A690D0", VA = "0x2A690D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000052")]
		public IResourceLocation Location
		{
			[Token(Token = "0x60001E0")]
			[Address(RVA = "0x2A5D688", Offset = "0x2A5D688", VA = "0x2A5D688")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000053")]
		public int DependencyCount
		{
			[Token(Token = "0x60001E1")]
			[Address(RVA = "0x2A6B160", Offset = "0x2A6B160", VA = "0x2A6B160")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x2A6AF74", Offset = "0x2A6AF74", VA = "0x2A6AF74")]
		internal ProvideHandle(ResourceManager rm, IGenericProviderOperation op)
		{
		}

		[Token(Token = "0x60001E2")]
		public TDepObject GetDependency<TDepObject>(int index)
		{
			return (TDepObject)null;
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x2A6B220", Offset = "0x2A6B220", VA = "0x2A6B220")]
		public void GetDependencies(IList<object> list)
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x2A5DFB8", Offset = "0x2A5DFB8", VA = "0x2A5DFB8")]
		public void SetProgressCallback(Func<float> callback)
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x2A5E088", Offset = "0x2A5E088", VA = "0x2A5E088")]
		public void SetDownloadProgressCallbacks(Func<DownloadStatus> callback)
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x2A5E158", Offset = "0x2A5E158", VA = "0x2A5E158")]
		public void SetWaitForCompletionCallback(Func<bool> callback)
		{
		}

		[Token(Token = "0x60001E7")]
		public void Complete<T>(T result, bool status, Exception exception)
		{
		}
	}
}
