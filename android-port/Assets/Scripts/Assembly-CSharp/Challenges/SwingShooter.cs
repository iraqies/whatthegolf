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

		public Vector2 AngleRange = new Vector2(0f, 90f);

		public RagdollOnSwing swingObject;

		public float minVelocity;

		public float FullVelocity;

		public float SwingPullBackForce = 200f;

		public float SuccessDistanceToSwing = 20f;

		public RagdollOnSwing[] ammunition;

		public UnityEvent NoAmmunitionOnReloadEvent;

		public ClipSettingsCollection shootSFX;

		public ClipSettingsCollection creakSFX;

		private bool hasShot;

		private float releaseAngle;

		private CBFollow followCam;

		private Vector3 shotBoost;

		private int currentSwing;

		public float toVel = 2.5f;

		public float maxVel = 15f;

		public float gain = 5f;

		private void Start()
		{
			if (CameraManager.Instance != null)
				followCam = CameraManager.Instance.gameObject.GetComponent<CBFollow>();
			if (Swings != null && currentSwing >= 0 && currentSwing < Swings.Count && Swings[currentSwing] != null)
				rigidbodyC = Swings[currentSwing].SwingRigidbody;
		}

		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
			if (onlyAimArrow || (GolfBallController != null && GolfBallController.BlockShooting))
				return;
			if (Swings == null || currentSwing < 0 || currentSwing >= Swings.Count)
				return;
			var sw = Swings[currentSwing];
			if (sw == null)
				return;

			if (sw.SwingPivot != null)
			{
				float angle = Mathf.LerpAngle(AngleRange.x, AngleRange.y, boost.magnitude);
				sw.SwingPivot.transform.rotation = Quaternion.Euler(angle, 0f, 0f);
			}

			if (sw.SwingTarget != null && sw.SwingRigidbody != null)
			{
				Vector3 targetVel = Vector3.ClampMagnitude((sw.SwingTarget.position - transform.position) * toVel, maxVel);
				Vector3 force = Vector3.ClampMagnitude((targetVel - sw.SwingRigidbody.velocity) * gain, SwingPullBackForce);
				sw.SwingRigidbody.AddForce(force);
			}
		}

		public override void OnShoot(Vector3 boost)
		{
			if (GolfBallController != null && GolfBallController.BlockShooting)
				return;
			if (shootSFX != null)
				shootSFX.Play(transform.position, 1f, 1f);
			if (swingObject != null && swingObject.sfxOnShoot != null)
				swingObject.sfxOnShoot.Play(transform.position, 1f, 1f);

			if (Swings != null && currentSwing >= 0 && currentSwing < Swings.Count && Swings[currentSwing] != null)
			{
				var sw = Swings[currentSwing];
				if (sw.SwingPivot != null)
				{
					sw.SwingPivot.transform.rotation = Quaternion.identity;
					releaseAngle = Vector3.SignedAngle(sw.SwingPivot.transform.up, transform.up, transform.right);
				}
			}

			base.OnShoot(boost);
			Vector3 worldBoost = transform.TransformVector(boost);
			StandardShoot(worldBoost, 0f, minVelocity, FullVelocity, 0f);
			shotBoost = boost;
			hasShot = true;
			if (GolfBallController != null)
				GolfBallController.BlockShooting = true;
		}

		private void Update()
		{
			if (!hasShot || Swings == null || currentSwing < 0 || currentSwing >= Swings.Count)
				return;
			var sw = Swings[currentSwing];
			if (sw == null || sw.SwingPivot == null)
				return;

			float curAngle = Vector3.SignedAngle(sw.SwingPivot.transform.up, transform.up, transform.right);
			if (curAngle < -releaseAngle)
			{
				Vector3 parentFwd = transform.parent != null ? transform.parent.forward : transform.forward;
				Vector3 dir = Vector3.Lerp(parentFwd, transform.forward, Mathf.Clamp01(0.6f)).normalized;
				if (swingObject != null)
				{
					swingObject.LaunchKid(dir + shotBoost, ObjectHitGround);
					if (followCam != null && swingObject.RootBone != null)
						followCam.FollowTarget = swingObject.RootBone;
					if (swingObject.Root != null)
						swingObject.Root.transform.SetParent(null);
				}
				hasShot = false;
			}
		}

		private void ObjectHitGround(GameObject currentObject)
		{
			transform.localPosition = Vector3.zero;
			transform.localRotation = Quaternion.identity;
			if (Swings != null && currentSwing >= 0 && currentSwing < Swings.Count && Swings[currentSwing] != null)
			{
				var sw = Swings[currentSwing];
				if (sw.SwingRigidbody != null)
				{
					sw.SwingRigidbody.velocity = Vector3.zero;
					sw.SwingRigidbody.angularVelocity = Vector3.zero;
				}
				if (followCam != null && sw.SwingPivot != null)
					followCam.FollowTarget = sw.SwingPivot;
			}
			if (GolfBallController != null)
				GolfBallController.BlockShooting = false;
			Reload();
		}

		private void Reload()
		{
			if (ammunition != null && ammunition.Length > 0 && Swings != null && currentSwing >= 0 && currentSwing < Swings.Count)
			{
				int idx = UnityEngine.Random.Range(0, ammunition.Length);
				var prefab = ammunition[idx];
				var sw = Swings[currentSwing];
				if (prefab != null && sw != null)
				{
					swingObject = Instantiate(prefab, sw.Swing);
					if (swingObject != null && sw.SwingSeat != null)
						swingObject.transform.position = sw.SwingSeat.position;
				}
			}
			else
			{
				NoAmmunitionOnReloadEvent?.Invoke();
			}
		}

		private void OnDrawGizmosSelected()
		{
		}
	}
}
