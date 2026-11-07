using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000071")]
	public class CompromisedCredentialsActionsType
	{
		[Token(Token = "0x400011E")]
		[FieldOffset(Offset = "0x10")]
		private CompromisedCredentialsEventActionType _eventAction;

		[Token(Token = "0x170000AB")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1C824", Offset = "0x1C824")]
		public CompromisedCredentialsEventActionType EventAction
		{
			[Token(Token = "0x6000415")]
			[Address(RVA = "0x10E3904", Offset = "0x10E3904", VA = "0x10E3904")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000416")]
			[Address(RVA = "0x10E390C", Offset = "0x10E390C", VA = "0x10E390C")]
			set
			{
			}
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x10E3914", Offset = "0x10E3914", VA = "0x10E3914")]
		internal bool IsSetEventAction()
		{
			return default;
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x10E3990", Offset = "0x10E3990", VA = "0x10E3990")]
		public CompromisedCredentialsActionsType()
		{
		}
	}
}
