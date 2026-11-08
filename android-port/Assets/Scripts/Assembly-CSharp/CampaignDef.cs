using System.Collections.Generic;

public class CampaignDef
{
	public ECampaignType type;
	public ECampaignType campaignType => type;
	public string savePrefix;
	public Transition.TransitionEffect transition;
	public string packID;

	private static readonly Dictionary<ECampaignType, CampaignDef> CAMPAIGN_DEFS = new Dictionary<ECampaignType, CampaignDef>
	{
		{ ECampaignType.Main, new CampaignDef { type = ECampaignType.Main, savePrefix = "", transition = Transition.TransitionEffect.Random, packID = "CP_MAIN_CAMPAIGN" } },
		{ ECampaignType.Olympics, new CampaignDef { type = ECampaignType.Olympics, savePrefix = "Olympics_", transition = Transition.TransitionEffect.Random, packID = "CP_SPORTY_SPORTS" } },
		{ ECampaignType.Snow, new CampaignDef { type = ECampaignType.Snow, savePrefix = "Snow_", transition = Transition.TransitionEffect.Random, packID = "CP_SNOWY_SNOW" } },
		{ ECampaignType.Hotdog, new CampaignDef { type = ECampaignType.Hotdog, savePrefix = "Hotdog_", transition = Transition.TransitionEffect.Random, packID = "CP_HOTDOG" } },
		{ ECampaignType.Hub, new CampaignDef { type = ECampaignType.Hub, savePrefix = "Hub_", transition = Transition.TransitionEffect.Random, packID = "CP_HUB" } },
		{ ECampaignType.Alive, new CampaignDef { type = ECampaignType.Alive, savePrefix = "Alive_", transition = Transition.TransitionEffect.Random, packID = "CP_ALIVE" } },
		{ ECampaignType.Amongus, new CampaignDef { type = ECampaignType.Amongus, savePrefix = "Amongus_", transition = Transition.TransitionEffect.Random, packID = "CP_AMONGUS" } }
	};

	public static Dictionary<ECampaignType, CampaignDef> GetAllDefs() => CAMPAIGN_DEFS;

	public static CampaignDef GetDef(ECampaignType type)
	{
		if (CAMPAIGN_DEFS.TryGetValue(type, out var def))
			return def;
		return new CampaignDef { type = type, savePrefix = type + "_", transition = Transition.TransitionEffect.Random, packID = "" };
	}
}
