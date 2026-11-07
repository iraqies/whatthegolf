using Amazon.Runtime.Internal.Auth;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal
{
	[Token(Token = "0x200017C")]
	public class AsyncExecutionContext : IAsyncExecutionContext
	{
		[Token(Token = "0x40005C1")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x273F8", Offset = "0x273F8")]
		private IAsyncResponseContext ResponseContext__BackingField;

		[Token(Token = "0x40005C2")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27408", Offset = "0x27408")]
		private IAsyncRequestContext RequestContext__BackingField;

		[Token(Token = "0x40005C3")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27418", Offset = "0x27418")]
		private object RuntimeState__BackingField;

		[Token(Token = "0x17000336")]
		public IAsyncResponseContext ResponseContext
		{
			[Token(Token = "0x6000BFC")]
			[Address(RVA = "0x11D3298", Offset = "0x11D3298", VA = "0x11D3298", Slot = "4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A694", Offset = "0x2A694")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BFD")]
			[Address(RVA = "0x11D32A0", Offset = "0x11D32A0", VA = "0x11D32A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A6A4", Offset = "0x2A6A4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000337")]
		public IAsyncRequestContext RequestContext
		{
			[Token(Token = "0x6000BFE")]
			[Address(RVA = "0x11D32A8", Offset = "0x11D32A8", VA = "0x11D32A8", Slot = "5")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A6B4", Offset = "0x2A6B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BFF")]
			[Address(RVA = "0x11D32B0", Offset = "0x11D32B0", VA = "0x11D32B0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A6C4", Offset = "0x2A6C4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000338")]
		public object RuntimeState
		{
			[Token(Token = "0x6000C00")]
			[Address(RVA = "0x11D32B8", Offset = "0x11D32B8", VA = "0x11D32B8", Slot = "6")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A6D4", Offset = "0x2A6D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C01")]
			[Address(RVA = "0x11D32C0", Offset = "0x11D32C0", VA = "0x11D32C0", Slot = "7")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A6E4", Offset = "0x2A6E4")]
			set
			{
			}
		}

		[Token(Token = "0x6000C02")]
		[Address(RVA = "0x11D32C8", Offset = "0x11D32C8", VA = "0x11D32C8")]
		public AsyncExecutionContext(bool enableMetrics, AbstractAWSSigner clientSigner)
		{
		}

		[Token(Token = "0x6000C03")]
		[Address(RVA = "0x11D338C", Offset = "0x11D338C", VA = "0x11D338C")]
		public AsyncExecutionContext(IAsyncRequestContext requestContext, IAsyncResponseContext responseContext)
		{
		}
	}
}
