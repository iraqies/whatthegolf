using Il2CppDummyDll;

[Token(Token = "0x2000466")]
public abstract class AnalyticsConsentPopupRequest : ConsentPopupRequest
{
	[Token(Token = "0x17000241")]
	protected override ConsentRequestTypes RequestType
	{
		[Token(Token = "0x6001482")]
		[Address(RVA = "0x141521C", Offset = "0x141521C", VA = "0x141521C", Slot = "5")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x6001483")]
	[Address(RVA = "0x1415224", Offset = "0x1415224", VA = "0x1415224", Slot = "8")]
	protected override bool IsFeatureEnabled()
	{
		return default;
	}

	[Token(Token = "0x6001484")]
	[Address(RVA = "0x14152D4", Offset = "0x14152D4", VA = "0x14152D4")]
	protected AnalyticsConsentPopupRequest()
	{
	}
}
