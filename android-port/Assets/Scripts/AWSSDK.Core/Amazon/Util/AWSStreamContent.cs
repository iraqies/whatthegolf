using System;
using System.IO;
using System.Net.Http;
using Il2CppDummyDll;

namespace Amazon.Util
{
	[Token(Token = "0x2000077")]
	public class AWSStreamContent : IDisposable
	{
		[Token(Token = "0x4000256")]
		[FieldOffset(Offset = "0x10")]
		private bool disposed;

		[Token(Token = "0x4000257")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26568", Offset = "0x26568")]
		private StreamContent StreamContent__BackingField;

		[Token(Token = "0x17000102")]
		internal StreamContent StreamContent
		{
			[Token(Token = "0x6000463")]
			[Address(RVA = "0x11C80B0", Offset = "0x11C80B0", VA = "0x11C80B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x286AC", Offset = "0x286AC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000464")]
			[Address(RVA = "0x11C80B8", Offset = "0x11C80B8", VA = "0x11C80B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x286BC", Offset = "0x286BC")]
			set
			{
			}
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x11C80C0", Offset = "0x11C80C0", VA = "0x11C80C0")]
		public AWSStreamContent(Stream content)
		{
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x11C8138", Offset = "0x11C8138", VA = "0x11C8138")]
		public AWSStreamContent(Stream content, int bufferSize)
		{
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x11C81C0", Offset = "0x11C81C0", VA = "0x11C81C0")]
		public bool RemoveHttpContentHeader(string name)
		{
			return default;
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x11C81FC", Offset = "0x11C81FC", VA = "0x11C81FC")]
		public void AddHttpContentHeader(string name, string value)
		{
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x11C8240", Offset = "0x11C8240", VA = "0x11C8240", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x11C82C0", Offset = "0x11C82C0", VA = "0x11C82C0", Slot = "5")]
		protected virtual void Dispose(bool disposing)
		{
		}
	}
}
