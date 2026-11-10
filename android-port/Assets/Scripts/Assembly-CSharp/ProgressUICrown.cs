using UnityEngine;

public class ProgressUICrown : MonoBehaviour
{
	[SerializeField]
	private SVGImage Shrine;

	[SerializeField]
	private SVGImage Coin;

	[SerializeField]
	private float ClaimedCrownAlpha = 1f;

	public Animator anim;

	private bool isClaimed;

	public void Claim(Color color)
	{
		isClaimed = true;
		if (Coin != null)
		{
			Color c = color;
			c.a = ClaimedCrownAlpha;
			Coin.color = c;
			Coin.enabled = true;
		}
		if (anim != null)
		{
			anim.SetTrigger("Claim");
		}
	}

	public void Reclaim()
	{
		isClaimed = true;
		if (Coin != null)
		{
			Coin.enabled = true;
		}
	}

	public void SetLastPoint(bool value)
	{
		if (anim != null)
		{
			anim.SetBool("LastPoint", value);
		}
	}

	public void Unclaim()
	{
		isClaimed = false;
		if (Coin != null)
		{
			Coin.enabled = false;
		}
	}

	public void ResetCrown()
	{
		Unclaim();
	}

	public bool IsClaimed()
	{
		return isClaimed;
	}
}
