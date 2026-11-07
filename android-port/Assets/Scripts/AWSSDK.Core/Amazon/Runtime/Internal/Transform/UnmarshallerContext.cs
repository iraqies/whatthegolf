using System;
using System.IO;
using Amazon.Runtime.Internal.Util;
using Il2CppDummyDll;
using ThirdParty.Ionic.Zlib;

namespace Amazon.Runtime.Internal.Transform
{
	[Token(Token = "0x2000236")]
	public abstract class UnmarshallerContext : IDisposable
	{
		[Token(Token = "0x40007DE")]
		[FieldOffset(Offset = "0x10")]
		private bool disposed;

		[Token(Token = "0x40007DF")]
		[FieldOffset(Offset = "0x11")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x27BD8", Offset = "0x27BD8")]
		private bool MaintainResponseBody__BackingField;

		[Token(Token = "0x40007E0")]
		[FieldOffset(Offset = "0x12")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x27BE8", Offset = "0x27BE8")]
		private bool IsException__BackingField;

		[Token(Token = "0x40007E1")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x27BF8", Offset = "0x27BF8")]
		private CrcCalculatorStream CrcStream__BackingField;

		[Token(Token = "0x40007E2")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x27C08", Offset = "0x27C08")]
		private int Crc32Result__BackingField;

		[Token(Token = "0x40007E3")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x27C18", Offset = "0x27C18")]
		private IWebResponseData WebResponseData__BackingField;

		[Token(Token = "0x40007E4")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x27C28", Offset = "0x27C28")]
		private CachingWrapperStream WrappingStream__BackingField;

		[Token(Token = "0x17000426")]
		protected bool MaintainResponseBody
		{
			[Token(Token = "0x60010B8")]
			[Address(RVA = "0x12807B8", Offset = "0x12807B8", VA = "0x12807B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BDA0", Offset = "0x2BDA0")]
			get
			{
				return default;
			}
			[Token(Token = "0x60010B9")]
			[Address(RVA = "0x12807C0", Offset = "0x12807C0", VA = "0x12807C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BDB0", Offset = "0x2BDB0")]
			set
			{
			}
		}

		[Token(Token = "0x17000427")]
		protected bool IsException
		{
			[Token(Token = "0x60010BA")]
			[Address(RVA = "0x12807C8", Offset = "0x12807C8", VA = "0x12807C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BDC0", Offset = "0x2BDC0")]
			get
			{
				return default;
			}
			[Token(Token = "0x60010BB")]
			[Address(RVA = "0x12807D0", Offset = "0x12807D0", VA = "0x12807D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BDD0", Offset = "0x2BDD0")]
			set
			{
			}
		}

		[Token(Token = "0x17000428")]
		protected CrcCalculatorStream CrcStream
		{
			[Token(Token = "0x60010BC")]
			[Address(RVA = "0x12807D8", Offset = "0x12807D8", VA = "0x12807D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BDE0", Offset = "0x2BDE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60010BD")]
			[Address(RVA = "0x12807E0", Offset = "0x12807E0", VA = "0x12807E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BDF0", Offset = "0x2BDF0")]
			set
			{
			}
		}

		[Token(Token = "0x17000429")]
		protected int Crc32Result
		{
			[Token(Token = "0x60010BE")]
			[Address(RVA = "0x12807E8", Offset = "0x12807E8", VA = "0x12807E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BE00", Offset = "0x2BE00")]
			get
			{
				return default;
			}
			[Token(Token = "0x60010BF")]
			[Address(RVA = "0x12807F0", Offset = "0x12807F0", VA = "0x12807F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BE10", Offset = "0x2BE10")]
			set
			{
			}
		}

		[Token(Token = "0x1700042A")]
		protected IWebResponseData WebResponseData
		{
			[Token(Token = "0x60010C0")]
			[Address(RVA = "0x12807F8", Offset = "0x12807F8", VA = "0x12807F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BE20", Offset = "0x2BE20")]
			get
			{
				return null;
			}
			[Token(Token = "0x60010C1")]
			[Address(RVA = "0x1280800", Offset = "0x1280800", VA = "0x1280800")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BE30", Offset = "0x2BE30")]
			set
			{
			}
		}

		[Token(Token = "0x1700042B")]
		protected CachingWrapperStream WrappingStream
		{
			[Token(Token = "0x60010C2")]
			[Address(RVA = "0x1280808", Offset = "0x1280808", VA = "0x1280808")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BE40", Offset = "0x2BE40")]
			get
			{
				return null;
			}
			[Token(Token = "0x60010C3")]
			[Address(RVA = "0x1280810", Offset = "0x1280810", VA = "0x1280810")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BE50", Offset = "0x2BE50")]
			set
			{
			}
		}

		[Token(Token = "0x1700042C")]
		public string ResponseBody
		{
			[Token(Token = "0x60010C4")]
			[Address(RVA = "0x1280460", Offset = "0x1280460", VA = "0x1280460")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700042D")]
		public IWebResponseData ResponseData
		{
			[Token(Token = "0x60010C6")]
			[Address(RVA = "0x1260470", Offset = "0x1260470", VA = "0x1260470")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700042E")]
		public abstract string CurrentPath
		{
			[Token(Token = "0x60010CE")]
			get;
		}

		[Token(Token = "0x1700042F")]
		public abstract int CurrentDepth
		{
			[Token(Token = "0x60010CF")]
			get;
		}

		[Token(Token = "0x17000430")]
		public abstract bool IsStartElement
		{
			[Token(Token = "0x60010D2")]
			get;
		}

		[Token(Token = "0x17000431")]
		public abstract bool IsEndElement
		{
			[Token(Token = "0x60010D3")]
			get;
		}

		[Token(Token = "0x17000432")]
		public abstract bool IsStartOfDocument
		{
			[Token(Token = "0x60010D4")]
			get;
		}

		[Token(Token = "0x60010C5")]
		[Address(RVA = "0x1280818", Offset = "0x1280818", VA = "0x1280818")]
		public byte[] GetResponseBodyBytes()
		{
			return null;
		}

		[Token(Token = "0x60010C7")]
		[Address(RVA = "0x1280594", Offset = "0x1280594", VA = "0x1280594")]
		internal void ValidateCRC32IfAvailable()
		{
		}

		[Token(Token = "0x60010C8")]
		[Address(RVA = "0x12808CC", Offset = "0x12808CC", VA = "0x12808CC")]
		protected void SetupCRCStream(IWebResponseData responseData, Stream responseStream, long contentLength)
		{
		}

		[Token(Token = "0x60010C9")]
		[Address(RVA = "0x125FE08", Offset = "0x125FE08", VA = "0x125FE08")]
		public bool TestExpression(string expression)
		{
			return default;
		}

		[Token(Token = "0x60010CA")]
		[Address(RVA = "0x1280AA8", Offset = "0x1280AA8", VA = "0x1280AA8")]
		public bool TestExpression(string expression, int startingStackDepth)
		{
			return default;
		}

		[Token(Token = "0x60010CB")]
		[Address(RVA = "0x1280C54", Offset = "0x1280C54", VA = "0x1280C54")]
		public bool ReadAtDepth(int targetDepth)
		{
			return default;
		}

		[Token(Token = "0x60010CC")]
		[Address(RVA = "0x1280A14", Offset = "0x1280A14", VA = "0x1280A14")]
		private static bool TestExpression(string expression, string currentPath)
		{
			return default;
		}

		[Token(Token = "0x60010CD")]
		[Address(RVA = "0x1280B04", Offset = "0x1280B04", VA = "0x1280B04")]
		private static bool TestExpression(string expression, int startingStackDepth, string currentPath, int currentDepth)
		{
			return default;
		}

		[Token(Token = "0x60010D0")]
		public abstract bool Read();

		[Token(Token = "0x60010D1")]
		public abstract string ReadText();

		[Token(Token = "0x60010D5")]
		[Address(RVA = "0x1280C9C", Offset = "0x1280C9C", VA = "0x1280C9C", Slot = "12")]
		protected virtual void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x60010D6")]
		[Address(RVA = "0x1280D08", Offset = "0x1280D08", VA = "0x1280D08", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60010D7")]
		[Address(RVA = "0x1280D88", Offset = "0x1280D88", VA = "0x1280D88")]
		protected UnmarshallerContext()
		{
		}
	}
}
