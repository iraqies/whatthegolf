using System.Collections;
using UnityEngine;

public class HoloObject : GolfBehaviour
{
	public SpriteRenderer sprite;

	private bool isAnimating;

	public override void OnPrePlayOrPreCompile()
	{
		base.OnPrePlayOrPreCompile();
		sprite = GetComponent<SpriteRenderer>();
		sprite.enabled = false;
	}

	private void Awake()
	{
		sprite.enabled = false;
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (!isAnimating)
		{
			StartCoroutine(HoloBlink());
		}
	}

	private IEnumerator HoloBlink()
	{
		isAnimating = true;
		sprite.enabled = true;
		yield return new WaitForSeconds(0.15f);
		sprite.enabled = false;
		yield return new WaitForSeconds(0.1f);
		int count = 5;
		for (int i = 0; i < count; i++)
		{
			yield return new WaitForSeconds(0.06f);
			sprite.enabled = !sprite.enabled;
		}
		sprite.enabled = false;
		isAnimating = false;
	}
}
