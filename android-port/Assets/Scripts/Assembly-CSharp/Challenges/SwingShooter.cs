using System;
using System.Collections.Generic;
using Audio;
using CameraStack;
using Core;
using UnityEngine;
using UnityEngine.Events;

namespace Challenges
{
	public class SwingShooter : GolfBallShooterBase
	{
		[Serializable]
		public class SwingData
		{
			public Transform Swing;

			public Transform SwingPivot;

			public Transform SwingTarget;

			public Transform SwingSeat;

			public Rigidbody SwingRigidbody;
		}

		public List<SwingData> Swings;

		public Vector2 AngleRange;

		public RagdollOnSwing swingObject;

		public float minVelocity;

		public float FullVelocity;

		public float SwingPullBackForce;

		public float SuccessDistanceToSwing;

		public RagdollOnSwing[] ammunition;

		public UnityEvent NoAmmunitionOnReloadEvent;

		public ClipSettingsCollection shootSFX;

		public ClipSettingsCollection creakSFX;

		private bool hasShot;

		private float releaseAngle;

		private CBFollow followCam;

		private Vector3 shotBoost;

		private int currentSwing;

		public float toVel;

		public float maxVel;

		public float gain;

		private void Start()
		{
		}

		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
		}

		public override void OnShoot(Vector3 boost)
		{
		}

		private void Update()
		{
		}

		private void ObjectHitGround(GameObject currentObject)
		{
		}

		private void Reload()
		{
		}

		private void OnDrawGizmosSelected()
		{
		}
	}
}
