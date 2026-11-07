using Il2CppDummyDll;

namespace Amazon.Runtime
{
	[Token(Token = "0x20000A1")]
	public abstract class AWSRegion
	{
		[Token(Token = "0x40002C1")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x267D8", Offset = "0x267D8")]
		private RegionEndpoint Region__BackingField;

		[Token(Token = "0x17000177")]
		public RegionEndpoint Region
		{
			[Token(Token = "0x60005F0")]
			[Address(RVA = "0x11C2D9C", Offset = "0x11C2D9C", VA = "0x11C2D9C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x28C8C", Offset = "0x28C8C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005F1")]
			[Address(RVA = "0x11C2DA4", Offset = "0x11C2DA4", VA = "0x11C2DA4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x28C9C", Offset = "0x28C9C")]
			protected set
			{
			}
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x11C2DAC", Offset = "0x11C2DAC", VA = "0x11C2DAC")]
		protected void SetRegionFromName(string regionSystemName)
		{
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x11C2E24", Offset = "0x11C2E24", VA = "0x11C2E24")]
		protected AWSRegion()
		{
		}
	}
}
