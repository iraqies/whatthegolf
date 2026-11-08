using UnityEngine;

public class SaveSpot : MonoBehaviour
{
	protected OverworldID saveID;

	public string ID
	{
		get
		{
			if (saveID == null) saveID = GetComponent<OverworldID>();
			return saveID != null ? saveID.ID : name;
		}
	}

	public void Init()
	{
		if (saveID == null) saveID = GetComponent<OverworldID>();
	}
}
