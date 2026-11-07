using System.Collections;
using UnityEngine;

public class DemoEndLoader : MonoBehaviour
{
	public enum EDemoEnded
	{
		InMainCampaign = 0,
		InPartyMode = 1
	}

	public static EDemoEnded lastDemoEndType;

	[SerializeField]
	private EDemoEnded _endType;

	private bool _loading;

	public void LoadEnd()
	{
	}

	private IEnumerator LoadEndCR()
	{
		return null;
	}

	public void OnCollisionEnter2D(Collision2D collision)
	{
	}
}
