using Il2CppDummyDll;

namespace Amazon.SecurityToken.Model
{
	[Token(Token = "0x2000016")]
	public class AssumedRoleUser
	{
		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x10")]
		private string _arn;

		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x18")]
		private string _assumedRoleId;

		[Token(Token = "0x17000011")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x30C78", Offset = "0x30C78")]
		public string Arn
		{
			[Token(Token = "0x600008B")]
			[Address(RVA = "0x12DD020", Offset = "0x12DD020", VA = "0x12DD020")]
			get
			{
				return null;
			}
			[Token(Token = "0x600008C")]
			[Address(RVA = "0x12DD028", Offset = "0x12DD028", VA = "0x12DD028")]
			set
			{
			}
		}

		[Token(Token = "0x17000012")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x30CC8", Offset = "0x30CC8")]
		public string AssumedRoleId
		{
			[Token(Token = "0x600008E")]
			[Address(RVA = "0x12DD040", Offset = "0x12DD040", VA = "0x12DD040")]
			get
			{
				return null;
			}
			[Token(Token = "0x600008F")]
			[Address(RVA = "0x12DD048", Offset = "0x12DD048", VA = "0x12DD048")]
			set
			{
			}
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x12DD030", Offset = "0x12DD030", VA = "0x12DD030")]
		internal bool IsSetArn()
		{
			return default;
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x12DD050", Offset = "0x12DD050", VA = "0x12DD050")]
		internal bool IsSetAssumedRoleId()
		{
			return default;
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x12DD060", Offset = "0x12DD060", VA = "0x12DD060")]
		public AssumedRoleUser()
		{
		}
	}
}
