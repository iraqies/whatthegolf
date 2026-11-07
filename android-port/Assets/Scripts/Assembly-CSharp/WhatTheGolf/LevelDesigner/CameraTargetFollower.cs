using Il2CppDummyDll;
using UnityEngine;
using WhatTheGolf.LevelDesigner.Selectables;

namespace WhatTheGolf.LevelDesigner
{
	[Token(Token = "0x200122B")]
	public class CameraTargetFollower : MonoBehaviour
	{
		[Token(Token = "0x400623E")]
		private const float startupSmoothTime = 1.2f;

		[Token(Token = "0x400623F")]
		private const float continuousSmoothTime = 0.4f;

		[Token(Token = "0x4006240")]
		private const float continuousTrackingDelay = 0.4f;

		[Token(Token = "0x4006241")]
		[FieldOffset(Offset = "0x18")]
		private float timeUntilContinuousTracking;

		[Token(Token = "0x4006242")]
		[FieldOffset(Offset = "0x20")]
		private Transform target;

		[Token(Token = "0x4006243")]
		[FieldOffset(Offset = "0x28")]
		private WhatTheGolf.LevelDesigner.Selectables.Ball ball;

		[Token(Token = "0x4006244")]
		[FieldOffset(Offset = "0x30")]
		private Vector3 currentVel;

		[Token(Token = "0x60053BF")]
		[Address(RVA = "0x18849BC", Offset = "0x18849BC", VA = "0x18849BC")]
		public void SetTarget(WhatTheGolf.LevelDesigner.Selectables.Ball ball, Transform target)
		{
		}

		[Token(Token = "0x60053C0")]
		[Address(RVA = "0x1884AF4", Offset = "0x1884AF4", VA = "0x1884AF4")]
		private void Controller_OnShoot(Vector3 obj)
		{
		}

		[Token(Token = "0x60053C1")]
		[Address(RVA = "0x1884B04", Offset = "0x1884B04", VA = "0x1884B04")]
		private void HandleReset()
		{
		}

		[Token(Token = "0x60053C2")]
		[Address(RVA = "0x1884B60", Offset = "0x1884B60", VA = "0x1884B60")]
		private void Update()
		{
		}

		[Token(Token = "0x60053C3")]
		[Address(RVA = "0x1884CBC", Offset = "0x1884CBC", VA = "0x1884CBC")]
		public CameraTargetFollower()
		{
		}
	}
}
