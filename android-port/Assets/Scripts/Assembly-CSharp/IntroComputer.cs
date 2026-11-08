using System.Collections;
using UnityEngine;

public class IntroComputer : MonoBehaviour
{
	public SpriteRenderer darkScreen;
	public Animator anim;
	private float nextHitAnim;

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (Time.time > nextHitAnim)
		{
			nextHitAnim = Time.time + 0.35f;
			StartCoroutine(PlayHitAnimRoutine());
		}
	}

	private IEnumerator PlayHitAnimRoutine()
	{
		if (anim != null)
			anim.SetBool("Scanlines", true);
		if (darkScreen != null)
			darkScreen.enabled = false;
		yield return new WaitForSeconds(0.3f);
		if (darkScreen != null)
			darkScreen.enabled = true;
		if (anim != null)
			anim.SetBool("Scanlines", false);
	}
}
