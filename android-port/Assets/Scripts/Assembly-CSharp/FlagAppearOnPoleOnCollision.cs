using System;
using UnityEngine;

public class FlagAppearOnPoleOnCollision : MonoBehaviour
{
	public LayerMask HitLayers;

	public Animator FlagAnimator;

	public Action<FlagAppearOnPoleOnCollision> OnFlagAppeared;

	private bool hasAppeared;

	private void OnCollisionEnter(Collision other)
	{
	}
}
