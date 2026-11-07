using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Transform
{
	[Token(Token = "0x2000213")]
	public abstract class MarshallerContext
	{
		[Token(Token = "0x40007B7")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27B88", Offset = "0x27B88")]
		private IRequest Request__BackingField;

		[Token(Token = "0x17000403")]
		public IRequest Request
		{
			[Token(Token = "0x600100C")]
			[Address(RVA = "0x123E058", Offset = "0x123E058", VA = "0x123E058")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BCF0", Offset = "0x2BCF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600100D")]
			[Address(RVA = "0x123E060", Offset = "0x123E060", VA = "0x123E060")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BD00", Offset = "0x2BD00")]
			private set
			{
			}
		}

		[Token(Token = "0x600100E")]
		[Address(RVA = "0x123E068", Offset = "0x123E068", VA = "0x123E068")]
		protected MarshallerContext(IRequest request)
		{
		}
	}
}
