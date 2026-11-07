using Amazon.Runtime.Internal.Auth;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal
{
	[Token(Token = "0x200017B")]
	public class ExecutionContext : IExecutionContext
	{
		[Token(Token = "0x40005BF")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x273D8", Offset = "0x273D8")]
		private IRequestContext RequestContext__BackingField;

		[Token(Token = "0x40005C0")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x273E8", Offset = "0x273E8")]
		private IResponseContext ResponseContext__BackingField;

		[Token(Token = "0x17000334")]
		public IRequestContext RequestContext
		{
			[Token(Token = "0x6000BF5")]
			[Address(RVA = "0x1206A20", Offset = "0x1206A20", VA = "0x1206A20", Slot = "5")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A654", Offset = "0x2A654")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BF6")]
			[Address(RVA = "0x1206A28", Offset = "0x1206A28", VA = "0x1206A28")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A664", Offset = "0x2A664")]
			private set
			{
			}
		}

		[Token(Token = "0x17000335")]
		public IResponseContext ResponseContext
		{
			[Token(Token = "0x6000BF7")]
			[Address(RVA = "0x1206A30", Offset = "0x1206A30", VA = "0x1206A30", Slot = "4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A674", Offset = "0x2A674")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BF8")]
			[Address(RVA = "0x1206A38", Offset = "0x1206A38", VA = "0x1206A38")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A684", Offset = "0x2A684")]
			private set
			{
			}
		}

		[Token(Token = "0x6000BF9")]
		[Address(RVA = "0x1206A40", Offset = "0x1206A40", VA = "0x1206A40")]
		public ExecutionContext(bool enableMetrics, AbstractAWSSigner clientSigner)
		{
		}

		[Token(Token = "0x6000BFA")]
		[Address(RVA = "0x1206AF4", Offset = "0x1206AF4", VA = "0x1206AF4")]
		public ExecutionContext(IRequestContext requestContext, IResponseContext responseContext)
		{
		}

		[Token(Token = "0x6000BFB")]
		[Address(RVA = "0x1206B2C", Offset = "0x1206B2C", VA = "0x1206B2C")]
		public static IExecutionContext CreateFromAsyncContext(IAsyncExecutionContext asyncContext)
		{
			return null;
		}
	}
}
