using System;
using Amazon.Runtime.Internal.Auth;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal
{
	[Token(Token = "0x2000178")]
	public class AsyncRequestContext : RequestContext, IAsyncRequestContext, IRequestContext
	{
		[Token(Token = "0x40005BB")]
		[FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x27398", Offset = "0x27398")]
		private AsyncCallback Callback__BackingField;

		[Token(Token = "0x40005BC")]
		[FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x273A8", Offset = "0x273A8")]
		private object State__BackingField;

		[Token(Token = "0x17000330")]
		public AsyncCallback Callback
		{
			[Token(Token = "0x6000BEB")]
			[Address(RVA = "0x11D3580", Offset = "0x11D3580", VA = "0x11D3580", Slot = "34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A5D4", Offset = "0x2A5D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BEC")]
			[Address(RVA = "0x11D3588", Offset = "0x11D3588", VA = "0x11D3588")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A5E4", Offset = "0x2A5E4")]
			set
			{
			}
		}

		[Token(Token = "0x17000331")]
		public object State
		{
			[Token(Token = "0x6000BED")]
			[Address(RVA = "0x11D3590", Offset = "0x11D3590", VA = "0x11D3590", Slot = "35")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A5F4", Offset = "0x2A5F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BEE")]
			[Address(RVA = "0x11D3598", Offset = "0x11D3598", VA = "0x11D3598")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A604", Offset = "0x2A604")]
			set
			{
			}
		}

		[Token(Token = "0x6000BEA")]
		[Address(RVA = "0x11D337C", Offset = "0x11D337C", VA = "0x11D337C")]
		public AsyncRequestContext(bool enableMetrics, AbstractAWSSigner clientSigner)
		{
		}
	}
}
