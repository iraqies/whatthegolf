public static class PackConstants
{
	public static string CampaignTypeToPackConstant(ECampaignType type)
	{
		return CampaignDef.GetDef(type)?.packID;
	}
}
