using System;
using UnityEngine;

public class BombChallengeTarget : MonoBehaviour
{
	public Action<BombChallengeTarget> onBombed;

	private bool _isBombed;

	private ExplosionBarrel _barrel;

	private void Start()
	{
	}

	private void BarrelOnOnExplode(Collider arg1, ExplosionBarrel arg2)
	{
	}
}
