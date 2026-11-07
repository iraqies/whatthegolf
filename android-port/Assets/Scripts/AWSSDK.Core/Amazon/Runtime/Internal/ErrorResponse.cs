using System;
using System.Net;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal
{
	[Token(Token = "0x2000158")]
	public class ErrorResponse
	{
		[Token(Token = "0x400055F")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x271B8", Offset = "0x271B8")]
		private ErrorType Type__BackingField;

		[Token(Token = "0x4000560")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x271C8", Offset = "0x271C8")]
		private string Code__BackingField;

		[Token(Token = "0x4000561")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x271D8", Offset = "0x271D8")]
		private string Message__BackingField;

		[Token(Token = "0x4000562")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x271E8", Offset = "0x271E8")]
		private string RequestId__BackingField;

		[Token(Token = "0x4000563")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x271F8", Offset = "0x271F8")]
		private Exception InnerException__BackingField;

		[Token(Token = "0x4000564")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x27208", Offset = "0x27208")]
		private HttpStatusCode StatusCode__BackingField;

		[Token(Token = "0x170002DA")]
		public ErrorType Type
		{
			[Token(Token = "0x6000AF3")]
			[Address(RVA = "0x1201514", Offset = "0x1201514", VA = "0x1201514")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A174", Offset = "0x2A174")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000AF4")]
			[Address(RVA = "0x120151C", Offset = "0x120151C", VA = "0x120151C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A184", Offset = "0x2A184")]
			set
			{
			}
		}

		[Token(Token = "0x170002DB")]
		public string Code
		{
			[Token(Token = "0x6000AF5")]
			[Address(RVA = "0x1201524", Offset = "0x1201524", VA = "0x1201524")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A194", Offset = "0x2A194")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AF6")]
			[Address(RVA = "0x120152C", Offset = "0x120152C", VA = "0x120152C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A1A4", Offset = "0x2A1A4")]
			set
			{
			}
		}

		[Token(Token = "0x170002DC")]
		public string Message
		{
			[Token(Token = "0x6000AF7")]
			[Address(RVA = "0x1201534", Offset = "0x1201534", VA = "0x1201534")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A1B4", Offset = "0x2A1B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AF8")]
			[Address(RVA = "0x120153C", Offset = "0x120153C", VA = "0x120153C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A1C4", Offset = "0x2A1C4")]
			set
			{
			}
		}

		[Token(Token = "0x170002DD")]
		public string RequestId
		{
			[Token(Token = "0x6000AF9")]
			[Address(RVA = "0x1201544", Offset = "0x1201544", VA = "0x1201544")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A1D4", Offset = "0x2A1D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AFA")]
			[Address(RVA = "0x120154C", Offset = "0x120154C", VA = "0x120154C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A1E4", Offset = "0x2A1E4")]
			set
			{
			}
		}

		[Token(Token = "0x170002DE")]
		public Exception InnerException
		{
			[Token(Token = "0x6000AFB")]
			[Address(RVA = "0x1201554", Offset = "0x1201554", VA = "0x1201554")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A1F4", Offset = "0x2A1F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AFC")]
			[Address(RVA = "0x120155C", Offset = "0x120155C", VA = "0x120155C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A204", Offset = "0x2A204")]
			set
			{
			}
		}

		[Token(Token = "0x170002DF")]
		public HttpStatusCode StatusCode
		{
			[Token(Token = "0x6000AFD")]
			[Address(RVA = "0x1201564", Offset = "0x1201564", VA = "0x1201564")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A214", Offset = "0x2A214")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000AFE")]
			[Address(RVA = "0x120156C", Offset = "0x120156C", VA = "0x120156C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A224", Offset = "0x2A224")]
			set
			{
			}
		}

		[Token(Token = "0x6000AFF")]
		[Address(RVA = "0x1201574", Offset = "0x1201574", VA = "0x1201574")]
		public ErrorResponse()
		{
		}
	}
}
