using System.Collections.Generic;

public class CampaignDef
{
	public ECampaignType type;

	public string savePrefix;

	public Transition.TransitionEffect transition;

	public string packID;

	private static readonly Dictionary<ECampaignType, CampaignDef> CAMPAIGN_DEFS;

	public static Dictionary<ECampaignType, CampaignDef> GetAllDefs()
	{
		return null;
	}

	public static CampaignDef GetDef(ECampaignType type)
	{
		return null;
	}
}
