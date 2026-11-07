using Il2CppDummyDll;

[Token(Token = "0x2000487")]
public abstract class ReviewConsentPopupRequest : ConsentPopupRequest
{
	[Token(Token = "0x17000252")]
	protected override ConsentRequestTypes RequestType
	{
		[Token(Token = "0x6001507")]
		[Address(RVA = "0x164DA1C", Offset = "0x164DA1C", VA = "0x164DA1C", Slot = "5")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x6001508")]
	[Address(RVA = "0x164DA24", Offset = "0x164DA24", VA = "0x164DA24", Slot = "8")]
	protected override bool IsFeatureEnabled()
	{
		return default;
	}

	[Token(Token = "0x6001509")]
	[Address(RVA = "0x164DAD4", Offset = "0x164DAD4", VA = "0x164DAD4")]
	protected ReviewConsentPopupRequest()
	{
	}
}
