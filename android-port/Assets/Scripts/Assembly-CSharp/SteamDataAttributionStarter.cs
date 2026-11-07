using System.Text.RegularExpressions;
using UnityEngine;

public class SteamDataAttributionStarter : MonoBehaviour
{
	private const string PLAYER_PREF_KEY = "SteamDataSuite_NonOrganicInstall";

	private const int MIN_PLAYTIME_FOR_THANK_YOU_PAGE = 5;

	private const string THANK_YOU_PAGE_URL = "https://whatthegolf.com/thanks/";

	private const int NON_ORGANIC_THANKLESS = 1;

	private const int NON_ORGANIC_THANKFUL = 2;

	[SerializeField]
	private SteamDataSuiteConfig dataSuiteConfig;

	private const string organicResponseRegexPattern = "^(.*\"content\": \"o-.*\".*)|(.*\"medium\": \"organic\".*)$";

	private const string promotedResponseRegexPattern = "^.*\"content\": \"p-.*\".*$";

	private Regex organicResponseRegex;

	private Regex promotedResponseRegex;

	private void Start()
	{
	}

	private void HandleSteamDataSuiteResponse(string response)
	{
	}

	private bool IsPromoted(string response)
	{
		return false;
	}

	private bool IsOrganic(string response)
	{
		return false;
	}

	private void HandleApplicationQuit()
	{
	}
}
