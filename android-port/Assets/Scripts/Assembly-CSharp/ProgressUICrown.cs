using UnityEngine;

public class ProgressUICrown : MonoBehaviour
{
	[SerializeField]
	private SVGImage Shrine;

	[SerializeField]
	private SVGImage Coin;

	[SerializeField]
	private float ClaimedCrownAlpha;

	public Animator anim;

	public void Claim(Color color)
	{
	}

	public void Reclaim()
	{
	}

	public void SetLastPoint(bool value)
	{
	}

	public void Unclaim()
	{
	}

	public void ResetCrown()
	{
	}

	public bool IsClaimed()
	{
		return false;
	}
}
