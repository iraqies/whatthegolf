using System;
using System.Collections;
using Il2CppDummyDll;

namespace UnityEngine.ResourceManagement.Util
{
	[Token(Token = "0x200003C")]
	public static class ResourceManagerConfig
	{
		[Token(Token = "0x600015E")]
		[Address(RVA = "0x2A6273C", Offset = "0x2A6273C", VA = "0x2A6273C")]
		public static bool ExtractKeyAndSubKey(object keyObj, out string mainKey, out string subKey)
		{
			return default;
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x2A5D508", Offset = "0x2A5D508", VA = "0x2A5D508")]
		public static bool IsPathRemote(string path)
		{
			return default;
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x2A7029C", Offset = "0x2A7029C", VA = "0x2A7029C")]
		public static string StripQueryParameters(string path)
		{
			return null;
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x2A5F7E0", Offset = "0x2A5F7E0", VA = "0x2A5F7E0")]
		public static bool ShouldPathUseWebRequest(string path)
		{
			return default;
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x2A702E0", Offset = "0x2A702E0", VA = "0x2A702E0")]
		private static bool PlatformCanLoadLocallyFromUrlPath()
		{
			return default;
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x2A69190", Offset = "0x2A69190", VA = "0x2A69190")]
		public static Array CreateArrayResult(Type type, Object[] allAssets)
		{
			return null;
		}

		[Token(Token = "0x6000164")]
		public static TObject CreateArrayResult<TObject>(Object[] allAssets) where TObject : class
		{
			return null;
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x2A69358", Offset = "0x2A69358", VA = "0x2A69358")]
		public static IList CreateListResult(Type type, Object[] allAssets)
		{
			return null;
		}

		[Token(Token = "0x6000166")]
		public static TObject CreateListResult<TObject>(Object[] allAssets)
		{
			return (TObject)null;
		}

		[Token(Token = "0x6000167")]
		public static bool IsInstance<T1, T2>()
		{
			return default;
		}
	}
}
