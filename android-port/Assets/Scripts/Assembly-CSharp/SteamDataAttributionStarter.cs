using System.Text.RegularExpressions;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000CE0")]
public class SteamDataAttributionStarter : MonoBehaviour
{
	[Token(Token = "0x40045F2")]
	private const string PLAYER_PREF_KEY = "SteamDataSuite_NonOrganicInstall";

	[Token(Token = "0x40045F3")]
	private const int MIN_PLAYTIME_FOR_THANK_YOU_PAGE = 5;

	[Token(Token = "0x40045F4")]
	private const string THANK_YOU_PAGE_URL = "https://whatthegolf.com/thanks/";

	[Token(Token = "0x40045F5")]
	private const int NON_ORGANIC_THANKLESS = 1;

	[Token(Token = "0x40045F6")]
	private const int NON_ORGANIC_THANKFUL = 2;

	[Token(Token = "0x40045F7")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private SteamDataSuiteConfig dataSuiteConfig;

	[Token(Token = "0x40045F8")]
	private const string organicResponseRegexPattern = "^(.*\"content\": \"o-.*\".*)|(.*\"medium\": \"organic\".*)$";

	[Token(Token = "0x40045F9")]
	private const string promotedResponseRegexPattern = "^.*\"content\": \"p-.*\".*$";

	[Token(Token = "0x40045FA")]
	[FieldOffset(Offset = "0x20")]
	private Regex organicResponseRegex;

	[Token(Token = "0x40045FB")]
	[FieldOffset(Offset = "0x28")]
	private Regex promotedResponseRegex;

	[Token(Token = "0x6003CE8")]
	[Address(RVA = "0x16DDEA4", Offset = "0x16DDEA4", VA = "0x16DDEA4")]
	private void Start()
	{
	}

	[Token(Token = "0x6003CE9")]
	[Address(RVA = "0x16DE230", Offset = "0x16DE230", VA = "0x16DE230")]
	private void HandleSteamDataSuiteResponse(string response)
	{
	}

	[Token(Token = "0x6003CEA")]
	[Address(RVA = "0x16DE2E4", Offset = "0x16DE2E4", VA = "0x16DE2E4")]
	private bool IsPromoted(string response)
	{
		return default;
	}

	[Token(Token = "0x6003CEB")]
	[Address(RVA = "0x16DE338", Offset = "0x16DE338", VA = "0x16DE338")]
	private bool IsOrganic(string response)
	{
		return default;
	}

	[Token(Token = "0x6003CEC")]
	[Address(RVA = "0x16DE3A4", Offset = "0x16DE3A4", VA = "0x16DE3A4")]
	private void HandleApplicationQuit()
	{
	}

	[Token(Token = "0x6003CED")]
	[Address(RVA = "0x16DE548", Offset = "0x16DE548", VA = "0x16DE548")]
	public SteamDataAttributionStarter()
	{
	}
}
