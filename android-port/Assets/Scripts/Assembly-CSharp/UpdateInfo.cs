using UnityEngine;

public class UpdateInfo : ScriptableObject
{
	public string updateID;

	public string headerTextID;

	public string titleID;

	public string taglineID;

	public string descriptionID;

	public Sprite banner;

	public ContentPack contentPack;

	public int MinMainCampaignCompletionPct;

	public int daysUntilActive;
}
