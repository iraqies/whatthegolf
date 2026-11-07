using System;
using System.Collections.Generic;
using Amazon.Runtime.Internal;
using Il2CppDummyDll;

namespace Amazon.Runtime
{
	[Token(Token = "0x20000DE")]
	public class WebServiceExceptionEventArgs : ExceptionEventArgs
	{
		[Token(Token = "0x40003B5")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26B78", Offset = "0x26B78")]
		private IDictionary<string, string> Headers__BackingField;

		[Token(Token = "0x40003B6")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26B88", Offset = "0x26B88")]
		private IDictionary<string, string> Parameters__BackingField;

		[Token(Token = "0x40003B7")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26B98", Offset = "0x26B98")]
		private string ServiceName__BackingField;

		[Token(Token = "0x40003B8")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26BA8", Offset = "0x26BA8")]
		private Uri Endpoint__BackingField;

		[Token(Token = "0x40003B9")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26BB8", Offset = "0x26BB8")]
		private AmazonWebServiceRequest Request__BackingField;

		[Token(Token = "0x40003BA")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26BC8", Offset = "0x26BC8")]
		private Exception Exception__BackingField;

		[Token(Token = "0x170001E7")]
		public IDictionary<string, string> Headers
		{
			[Token(Token = "0x60007B4")]
			[Address(RVA = "0x1281B48", Offset = "0x1281B48", VA = "0x1281B48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x293FC", Offset = "0x293FC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007B5")]
			[Address(RVA = "0x1281B50", Offset = "0x1281B50", VA = "0x1281B50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2940C", Offset = "0x2940C")]
			protected set
			{
			}
		}

		[Token(Token = "0x170001E8")]
		public IDictionary<string, string> Parameters
		{
			[Token(Token = "0x60007B6")]
			[Address(RVA = "0x1281B58", Offset = "0x1281B58", VA = "0x1281B58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2941C", Offset = "0x2941C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007B7")]
			[Address(RVA = "0x1281B60", Offset = "0x1281B60", VA = "0x1281B60")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2942C", Offset = "0x2942C")]
			protected set
			{
			}
		}

		[Token(Token = "0x170001E9")]
		public string ServiceName
		{
			[Token(Token = "0x60007B8")]
			[Address(RVA = "0x1281B68", Offset = "0x1281B68", VA = "0x1281B68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2943C", Offset = "0x2943C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007B9")]
			[Address(RVA = "0x1281B70", Offset = "0x1281B70", VA = "0x1281B70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2944C", Offset = "0x2944C")]
			protected set
			{
			}
		}

		[Token(Token = "0x170001EA")]
		public Uri Endpoint
		{
			[Token(Token = "0x60007BA")]
			[Address(RVA = "0x1281B78", Offset = "0x1281B78", VA = "0x1281B78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2945C", Offset = "0x2945C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007BB")]
			[Address(RVA = "0x1281B80", Offset = "0x1281B80", VA = "0x1281B80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2946C", Offset = "0x2946C")]
			protected set
			{
			}
		}

		[Token(Token = "0x170001EB")]
		public AmazonWebServiceRequest Request
		{
			[Token(Token = "0x60007BC")]
			[Address(RVA = "0x1281B88", Offset = "0x1281B88", VA = "0x1281B88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2947C", Offset = "0x2947C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007BD")]
			[Address(RVA = "0x1281B90", Offset = "0x1281B90", VA = "0x1281B90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2948C", Offset = "0x2948C")]
			protected set
			{
			}
		}

		[Token(Token = "0x170001EC")]
		public Exception Exception
		{
			[Token(Token = "0x60007BE")]
			[Address(RVA = "0x1281B98", Offset = "0x1281B98", VA = "0x1281B98")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2949C", Offset = "0x2949C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007BF")]
			[Address(RVA = "0x1281BA0", Offset = "0x1281BA0", VA = "0x1281BA0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x294AC", Offset = "0x294AC")]
			protected set
			{
			}
		}

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x1281B40", Offset = "0x1281B40", VA = "0x1281B40")]
		protected WebServiceExceptionEventArgs()
		{
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x1281BA8", Offset = "0x1281BA8", VA = "0x1281BA8")]
		internal static WebServiceExceptionEventArgs Create(Exception exception, IRequest request)
		{
			return null;
		}
	}
}
