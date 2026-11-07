using System;
using Il2CppDummyDll;

namespace UnityEngine.ResourceManagement.ResourceProviders
{
	[Serializable]
	[Token(Token = "0x200005D")]
	public class ProviderLoadRequestOptions
	{
		[Token(Token = "0x40000EC")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private bool m_IgnoreFailures;

		[Token(Token = "0x40000ED")]
		[FieldOffset(Offset = "0x14")]
		private int m_WebRequestTimeout;

		[Token(Token = "0x17000059")]
		public bool IgnoreFailures
		{
			[Token(Token = "0x6000217")]
			[Address(RVA = "0x2A6B430", Offset = "0x2A6B430", VA = "0x2A6B430")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000218")]
			[Address(RVA = "0x2A6B438", Offset = "0x2A6B438", VA = "0x2A6B438")]
			set
			{
			}
		}

		[Token(Token = "0x1700005A")]
		public int WebRequestTimeout
		{
			[Token(Token = "0x6000219")]
			[Address(RVA = "0x2A6B440", Offset = "0x2A6B440", VA = "0x2A6B440")]
			get
			{
				return default;
			}
			[Token(Token = "0x600021A")]
			[Address(RVA = "0x2A6B448", Offset = "0x2A6B448", VA = "0x2A6B448")]
			set
			{
			}
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x2A6B390", Offset = "0x2A6B390", VA = "0x2A6B390")]
		public ProviderLoadRequestOptions Copy()
		{
			return null;
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x2A6B450", Offset = "0x2A6B450", VA = "0x2A6B450")]
		public ProviderLoadRequestOptions()
		{
		}
	}
}
