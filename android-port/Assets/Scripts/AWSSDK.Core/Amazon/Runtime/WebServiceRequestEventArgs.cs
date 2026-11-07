using System;
using System.Collections.Generic;
using Amazon.Runtime.Internal;
using Il2CppDummyDll;

namespace Amazon.Runtime
{
	[Token(Token = "0x20000FA")]
	public class WebServiceRequestEventArgs : RequestEventArgs
	{
		[Token(Token = "0x40003E6")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26C88", Offset = "0x26C88")]
		private IDictionary<string, string> Headers__BackingField;

		[Token(Token = "0x40003E7")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26C98", Offset = "0x26C98")]
		private IDictionary<string, string> Parameters__BackingField;

		[Token(Token = "0x40003E8")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26CA8", Offset = "0x26CA8")]
		private ParameterCollection ParameterCollection__BackingField;

		[Token(Token = "0x40003E9")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26CB8", Offset = "0x26CB8")]
		private string ServiceName__BackingField;

		[Token(Token = "0x40003EA")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26CC8", Offset = "0x26CC8")]
		private Uri Endpoint__BackingField;

		[Token(Token = "0x40003EB")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26CD8", Offset = "0x26CD8")]
		private AmazonWebServiceRequest Request__BackingField;

		[Token(Token = "0x17000248")]
		public IDictionary<string, string> Headers
		{
			[Token(Token = "0x6000893")]
			[Address(RVA = "0x1281E74", Offset = "0x1281E74", VA = "0x1281E74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2963C", Offset = "0x2963C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000894")]
			[Address(RVA = "0x1281E7C", Offset = "0x1281E7C", VA = "0x1281E7C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2964C", Offset = "0x2964C")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000249")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x2C520", Offset = "0x2C520")]
		public IDictionary<string, string> Parameters
		{
			[Token(Token = "0x6000895")]
			[Address(RVA = "0x1281E84", Offset = "0x1281E84", VA = "0x1281E84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2965C", Offset = "0x2965C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000896")]
			[Address(RVA = "0x1281E8C", Offset = "0x1281E8C", VA = "0x1281E8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2966C", Offset = "0x2966C")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700024A")]
		public ParameterCollection ParameterCollection
		{
			[Token(Token = "0x6000897")]
			[Address(RVA = "0x1281E94", Offset = "0x1281E94", VA = "0x1281E94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2967C", Offset = "0x2967C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000898")]
			[Address(RVA = "0x1281E9C", Offset = "0x1281E9C", VA = "0x1281E9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2968C", Offset = "0x2968C")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700024B")]
		public string ServiceName
		{
			[Token(Token = "0x6000899")]
			[Address(RVA = "0x1281EA4", Offset = "0x1281EA4", VA = "0x1281EA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2969C", Offset = "0x2969C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600089A")]
			[Address(RVA = "0x1281EAC", Offset = "0x1281EAC", VA = "0x1281EAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x296AC", Offset = "0x296AC")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700024C")]
		public Uri Endpoint
		{
			[Token(Token = "0x600089B")]
			[Address(RVA = "0x1281EB4", Offset = "0x1281EB4", VA = "0x1281EB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x296BC", Offset = "0x296BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600089C")]
			[Address(RVA = "0x1281EBC", Offset = "0x1281EBC", VA = "0x1281EBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x296CC", Offset = "0x296CC")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700024D")]
		public AmazonWebServiceRequest Request
		{
			[Token(Token = "0x600089D")]
			[Address(RVA = "0x1281EC4", Offset = "0x1281EC4", VA = "0x1281EC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x296DC", Offset = "0x296DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600089E")]
			[Address(RVA = "0x1281ECC", Offset = "0x1281ECC", VA = "0x1281ECC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x296EC", Offset = "0x296EC")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700024E")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x2C558", Offset = "0x2C558")]
		public AmazonWebServiceRequest OriginalRequest
		{
			[Token(Token = "0x600089F")]
			[Address(RVA = "0x1281ED4", Offset = "0x1281ED4", VA = "0x1281ED4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000892")]
		[Address(RVA = "0x1281E6C", Offset = "0x1281E6C", VA = "0x1281E6C")]
		protected WebServiceRequestEventArgs()
		{
		}

		[Token(Token = "0x60008A0")]
		[Address(RVA = "0x1281EDC", Offset = "0x1281EDC", VA = "0x1281EDC")]
		internal static WebServiceRequestEventArgs Create(IRequest request)
		{
			return null;
		}
	}
}
