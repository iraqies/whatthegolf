using System.Collections.Generic;
using Core;
using UnityEngine;

namespace BustAMoveGolf
{
	public class BustAMoveGolfShooter : GolfBallShooterBase
	{
		[SerializeField]
		private GameObject ballPrefab;

		[SerializeField]
		private float speed;

		public List<AudioClip> ShootSounds;

		private BustAMoveColor nextColor;

		private SimplexGridManager simplexGridManager;

		private Renderer renderer;

		protected override void Awake()
		{
		base.Awake();
	}

		public override void OnShoot(Vector3 boost)
		{
		base.OnShoot(boost);
		StandardShoot(boost, 15f, 5f, 22f, 5f);
	}

		private void SetNextColor()
		{
		}
	}
}
