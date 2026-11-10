using System;
using UnityEngine;

[Serializable]
public struct LocalizationData
{
	[SerializeField]
	public NotificationSystemType type;

	[SerializeField]
	public string localizationID;

	[SerializeField]
	public string localizationTitleID;

	[SerializeField]
	public Sprite image;

	public LocalizationData(NotificationSystemType type, string locId, string locTitleId, Sprite img)
	{
		this.type = type;
		localizationID = locId;
		localizationTitleID = locTitleId;
		image = img;
	}
}
