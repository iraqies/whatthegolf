using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using TMPro;
using UnityEngine;

public class CreditsInLevel : MonoBehaviour
{
	public TextMeshPro Headline;

	public TextMeshPro Subline;

	public GolfBallController ball;

	public CreditsData creditsData;

	public float minTimeForCreditToShow = 1f;

	public float maxTimeForCreditToShow = 1f;

	public bool localizeHeadline;

	private int index;

	private float nextCreditTime;

	private float nextForcedCreditTime;

	private void Start()
	{
		ball.OnShoot += Ball_OnShoot;
		nextCreditTime = Time.time;
		Headline.text = "";
		Subline.text = "";
		nextForcedCreditTime = maxTimeForCreditToShow + 5f;
		ball.OnAimUpdate += Ball_OnAimUpdate;
	}

	private void Ball_OnAimUpdate(Vector3 arg1, bool arg2)
	{
		nextForcedCreditTime -= Time.deltaTime;
		if (nextForcedCreditTime < 0f)
		{
			Ball_OnShoot(Vector3.zero);
			nextForcedCreditTime = maxTimeForCreditToShow;
		}
	}

	private void Ball_OnShoot(Vector3 obj)
	{
		if (Time.time > nextCreditTime)
		{
			index = (index + 1) % creditsData.credits.Count;
			nextCreditTime = Time.time + minTimeForCreditToShow;
			nextForcedCreditTime = maxTimeForCreditToShow;
		}
		CreditsData.Credit credit = creditsData.credits[index];
		if (localizeHeadline && credit.title.Length >= 1)
		{
			Headline.SetLocalizedText(credit.title);
		}
		else
		{
			Headline.text = credit.title;
		}
		List<string> list = credit.names;
		if (list.Count == 1)
		{
			Subline.text = list[0];
			return;
		}
		if (list.Count < 2)
		{
			Subline.text = "";
			return;
		}
		if (credit.isRandomizingNames)
		{
			list = list.OrderBy((string x) => Guid.NewGuid()).ToList();
		}
		string text = "";
		for (int i = 0; i < list.Count; i++)
		{
			text += list[i];
			if (i < list.Count - 1)
			{
				text += "    ";
			}
		}
		Subline.text = text;
	}
}
