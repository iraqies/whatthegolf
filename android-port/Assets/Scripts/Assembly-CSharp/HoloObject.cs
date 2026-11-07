using System.Collections;
using UnityEngine;

public class HoloObject : GolfBehaviour
{
	public SpriteRenderer sprite;

	private bool isAnimating;

	public override void OnPrePlayOrPreCompile()
	{
	}

	private void Awake()
	{
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	private IEnumerator HoloBlink()
	{
		return null;
	}
}
