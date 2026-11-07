using Core;
using TMPro;
using UnityEngine;

public class CreditsInLevel : MonoBehaviour
{
	public TextMeshPro Headline;

	public TextMeshPro Subline;

	public GolfBallController ball;

	public CreditsData creditsData;

	public float minTimeForCreditToShow;

	public float maxTimeForCreditToShow;

	public bool localizeHeadline;

	private int index;

	private float nextCreditTime;

	private float nextForcedCreditTime;

	private void Start()
	{
	}

	private void Ball_OnAimUpdate(Vector3 arg1, bool arg2)
	{
	}

	private void Ball_OnShoot(Vector3 obj)
	{
	}
}
