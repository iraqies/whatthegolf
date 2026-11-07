using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000028")]
	public class AccountRecoverySettingType
	{
		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x10")]
		private List<RecoveryOptionType> _recoveryMechanisms;

		[Token(Token = "0x17000005")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1ABFC", Offset = "0x1ABFC")]
		public List<RecoveryOptionType> RecoveryMechanisms
		{
			[Token(Token = "0x60001CD")]
			[Address(RVA = "0x109764C", Offset = "0x109764C", VA = "0x109764C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001CE")]
			[Address(RVA = "0x1097654", Offset = "0x1097654", VA = "0x1097654")]
			set
			{
			}
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x109765C", Offset = "0x109765C", VA = "0x109765C")]
		internal bool IsSetRecoveryMechanisms()
		{
			return default;
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x10976B4", Offset = "0x10976B4", VA = "0x10976B4")]
		public AccountRecoverySettingType()
		{
		}
	}
}
