using System;
using UnityEngine;

public class AmongUsEpisodeButtonUpdate : MonoBehaviour
{
	public Sprite amongUsSprite;

	public Sprite defaultSprite;

	public GameObject eyes;

	public SVGImage image;

	private void Awake()
	{
		bool flag = Application.version != null && Application.version.StartsWith("12.0");
		DateTime utcNow = DateTime.UtcNow;
		if (utcNow.Year == 2023)
		{
			if (utcNow.DayOfYear >= 114)
			{
				flag = false;
			}
		}
		else
		{
			flag = false;
		}
		if (image != null)
		{
			image.sprite = (flag ? amongUsSprite : defaultSprite);
		}
		if (eyes != null)
		{
			eyes.gameObject.SetActive(!flag);
		}
	}
}
