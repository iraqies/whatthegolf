using System;
using System.Collections.Generic;
using Audio;
using CameraStack;
using Core;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace Challenges
{
	[Token(Token = "0x20010FA")]
	public class SwingShooter : GolfBallShooterBase
	{
		[Serializable]
		[Token(Token = "0x20010FB")]
		public class SwingData
		{
			[Token(Token = "0x400598A")]
			[FieldOffset(Offset = "0x10")]
			public Transform Swing;

			[Token(Token = "0x400598B")]
			[FieldOffset(Offset = "0x18")]
			public Transform SwingPivot;

			[Token(Token = "0x400598C")]
			[FieldOffset(Offset = "0x20")]
			public Transform SwingTarget;

			[Token(Token = "0x400598D")]
			[FieldOffset(Offset = "0x28")]
			public Transform SwingSeat;

			[Token(Token = "0x400598E")]
			[FieldOffset(Offset = "0x30")]
			public Rigidbody SwingRigidbody;

			[Token(Token = "0x6004C01")]
			[Address(RVA = "0x1860834", Offset = "0x1860834", VA = "0x1860834")]
			public SwingData()
			{
			}
		}

		[Token(Token = "0x4005977")]
		[FieldOffset(Offset = "0x60")]
		public List<SwingData> Swings;

		[Token(Token = "0x4005978")]
		[FieldOffset(Offset = "0x68")]
		public Vector2 AngleRange;

		[Token(Token = "0x4005979")]
		[FieldOffset(Offset = "0x70")]
		public RagdollOnSwing swingObject;

		[Token(Token = "0x400597A")]
		[FieldOffset(Offset = "0x78")]
		public float minVelocity;

		[Token(Token = "0x400597B")]
		[FieldOffset(Offset = "0x7C")]
		public float FullVelocity;

		[Token(Token = "0x400597C")]
		[FieldOffset(Offset = "0x80")]
		public float SwingPullBackForce;

		[Token(Token = "0x400597D")]
		[FieldOffset(Offset = "0x84")]
		public float SuccessDistanceToSwing;

		[Token(Token = "0x400597E")]
		[FieldOffset(Offset = "0x88")]
		public RagdollOnSwing[] ammunition;

		[Token(Token = "0x400597F")]
		[FieldOffset(Offset = "0x90")]
		public UnityEvent NoAmmunitionOnReloadEvent;

		[Token(Token = "0x4005980")]
		[FieldOffset(Offset = "0x98")]
		public ClipSettingsCollection shootSFX;

		[Token(Token = "0x4005981")]
		[FieldOffset(Offset = "0xA0")]
		public ClipSettingsCollection creakSFX;

		[Token(Token = "0x4005982")]
		[FieldOffset(Offset = "0xA8")]
		private bool hasShot;

		[Token(Token = "0x4005983")]
		[FieldOffset(Offset = "0xAC")]
		private float releaseAngle;

		[Token(Token = "0x4005984")]
		[FieldOffset(Offset = "0xB0")]
		private CBFollow followCam;

		[Token(Token = "0x4005985")]
		[FieldOffset(Offset = "0xB8")]
		private Vector3 shotBoost;

		[Token(Token = "0x4005986")]
		[FieldOffset(Offset = "0xC4")]
		private int currentSwing;

		[Token(Token = "0x4005987")]
		[FieldOffset(Offset = "0xC8")]
		public float toVel;

		[Token(Token = "0x4005988")]
		[FieldOffset(Offset = "0xCC")]
		public float maxVel;

		[Token(Token = "0x4005989")]
		[FieldOffset(Offset = "0xD0")]
		public float gain;

		[Token(Token = "0x6004BF9")]
		[Address(RVA = "0x16F4014", Offset = "0x16F4014", VA = "0x16F4014")]
		private void Start()
		{
		}

		[Token(Token = "0x6004BFA")]
		[Address(RVA = "0x16F40CC", Offset = "0x16F40CC", VA = "0x16F40CC", Slot = "6")]
		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
		}

		[Token(Token = "0x6004BFB")]
		[Address(RVA = "0x16F432C", Offset = "0x16F432C", VA = "0x16F432C", Slot = "7")]
		public override void OnShoot(Vector3 boost)
		{
		}

		[Token(Token = "0x6004BFC")]
		[Address(RVA = "0x16F462C", Offset = "0x16F462C", VA = "0x16F462C")]
		private void Update()
		{
		}

		[Token(Token = "0x6004BFD")]
		[Address(RVA = "0x16F48EC", Offset = "0x16F48EC", VA = "0x16F48EC")]
		private void ObjectHitGround(GameObject currentObject)
		{
		}

		[Token(Token = "0x6004BFE")]
		[Address(RVA = "0x16F4A74", Offset = "0x16F4A74", VA = "0x16F4A74")]
		private void Reload()
		{
		}

		[Token(Token = "0x6004BFF")]
		[Address(RVA = "0x16F4BFC", Offset = "0x16F4BFC", VA = "0x16F4BFC")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6004C00")]
		[Address(RVA = "0x16F4D8C", Offset = "0x16F4D8C", VA = "0x16F4D8C")]
		public SwingShooter()
		{
		}
	}
}
