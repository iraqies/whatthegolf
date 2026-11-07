using Il2CppDummyDll;

[Token(Token = "0x200047D")]
public abstract class NotificationConsentPopupRequest : ConsentPopupRequest
{
	[Token(Token = "0x1700024C")]
	protected override ConsentRequestTypes RequestType
	{
		[Token(Token = "0x60014E3")]
		[Address(RVA = "0x158E2EC", Offset = "0x158E2EC", VA = "0x158E2EC", Slot = "5")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x60014E4")]
	[Address(RVA = "0x158E2F4", Offset = "0x158E2F4", VA = "0x158E2F4", Slot = "8")]
	protected override bool IsFeatureEnabled()
	{
		return default;
	}

	[Token(Token = "0x60014E5")]
	[Address(RVA = "0x158E36C", Offset = "0x158E36C", VA = "0x158E36C")]
	protected NotificationConsentPopupRequest()
	{
	}
}
