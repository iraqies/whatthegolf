using System.Collections;
using UnityEngine;

public class IntroComputer : MonoBehaviour
{
	public SpriteRenderer darkScreen;

	public Animator anim;

	private float nextHitAnim;

	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	private IEnumerator PlayHitAnimRoutine()
	{
		return null;
	}
}
