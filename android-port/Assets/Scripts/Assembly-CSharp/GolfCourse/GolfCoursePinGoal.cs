using System;
using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;

namespace GolfCourse
{
	[Token(Token = "0x2001209")]
	public class GolfCoursePinGoal : MonoBehaviour
	{
		[Token(Token = "0x200120A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x484A4", Offset = "0x484A4")]
		private sealed class _003C_003Ec__DisplayClass22_0
		{
			[Token(Token = "0x4006166")]
			[FieldOffset(Offset = "0x10")]
			public WinnableGolfBall winnableGolfBall;

			[Token(Token = "0x60052FB")]
			[Address(RVA = "0x17B561C", Offset = "0x17B561C", VA = "0x17B561C")]
			public _003C_003Ec__DisplayClass22_0()
			{
			}

			[Token(Token = "0x60052FC")]
			[Address(RVA = "0x17B5624", Offset = "0x17B5624", VA = "0x17B5624")]
			internal bool _003CCheckObject_003Eb__0(GolfBallController g)
			{
				return default;
			}
		}

		[Token(Token = "0x200120B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x484B4", Offset = "0x484B4")]
		private sealed class _003C_003Ec__DisplayClass24_0
		{
			[Token(Token = "0x4006167")]
			[FieldOffset(Offset = "0x10")]
			public GolfCoursePinGoal _003C_003E4__this;

			[Token(Token = "0x4006168")]
			[FieldOffset(Offset = "0x18")]
			public Quaternion start;

			[Token(Token = "0x4006169")]
			[FieldOffset(Offset = "0x28")]
			public Quaternion end;

			[Token(Token = "0x60052FD")]
			[Address(RVA = "0x17B56C0", Offset = "0x17B56C0", VA = "0x17B56C0")]
			public _003C_003Ec__DisplayClass24_0()
			{
			}

			[Token(Token = "0x60052FE")]
			[Address(RVA = "0x17B56C8", Offset = "0x17B56C8", VA = "0x17B56C8")]
			internal void _003CPlayFlagAnimation_003Eb__0(float t)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200120C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x484C4", Offset = "0x484C4")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x400616A")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x400616B")]
			[FieldOffset(Offset = "0x8")]
			public static Action<float> _003C_003E9__25_0;

			[Token(Token = "0x6005300")]
			[Address(RVA = "0x17B5610", Offset = "0x17B5610", VA = "0x17B5610")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6005301")]
			[Address(RVA = "0x17B5618", Offset = "0x17B5618", VA = "0x17B5618")]
			internal void _003CComplete_003Eb__25_0(float t)
			{
			}
		}

		[Token(Token = "0x4006154")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool useTrigger;

		[Token(Token = "0x4006155")]
		[FieldOffset(Offset = "0x19")]
		[SerializeField]
		private bool useOtherTriggers;

		[Token(Token = "0x4006156")]
		[FieldOffset(Offset = "0x1A")]
		[SerializeField]
		private bool useCustomWinDelay;

		[Token(Token = "0x4006157")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float winDelay;

		[Token(Token = "0x4006158")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float preWinDelay;

		[Token(Token = "0x4006159")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool checkRootForController;

		[Token(Token = "0x400615A")]
		[FieldOffset(Offset = "0x25")]
		[SerializeField]
		private bool bendFlagOnHit;

		[Token(Token = "0x400615B")]
		[FieldOffset(Offset = "0x26")]
		[SerializeField]
		private bool emitParticles;

		[Token(Token = "0x400615C")]
		[FieldOffset(Offset = "0x28")]
		public int RequiredBallsInGoal;

		[Token(Token = "0x400615D")]
		[FieldOffset(Offset = "0x2C")]
		public bool DontAcceptController;

		[Token(Token = "0x400615E")]
		[FieldOffset(Offset = "0x30")]
		public List<Collider> goalObject;

		[Token(Token = "0x400615F")]
		[FieldOffset(Offset = "0x38")]
		private List<Transform> golfBallsInGoal;

		[Token(Token = "0x4006160")]
		[FieldOffset(Offset = "0x40")]
		private List<GolfBallController> controllersInGoal;

		[Token(Token = "0x4006161")]
		[FieldOffset(Offset = "0x48")]
		private int ballsInGoal;

		[Token(Token = "0x4006162")]
		[FieldOffset(Offset = "0x50")]
		private GolfGoal golfGoal;

		[Token(Token = "0x4006163")]
		[FieldOffset(Offset = "0x58")]
		private ParticleSystem particles;

		[Token(Token = "0x4006164")]
		[FieldOffset(Offset = "0x60")]
		private bool didBend;

		[Token(Token = "0x4006165")]
		[FieldOffset(Offset = "0x61")]
		private bool didPlayParticles;

		[Token(Token = "0x60052F1")]
		[Address(RVA = "0x149E3FC", Offset = "0x149E3FC", VA = "0x149E3FC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60052F2")]
		[Address(RVA = "0x149E50C", Offset = "0x149E50C", VA = "0x149E50C")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60052F3")]
		[Address(RVA = "0x149EC24", Offset = "0x149EC24", VA = "0x149EC24")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60052F4")]
		[Address(RVA = "0x149EC9C", Offset = "0x149EC9C", VA = "0x149EC9C")]
		public void AddBall()
		{
		}

		[Token(Token = "0x60052F5")]
		[Address(RVA = "0x149E548", Offset = "0x149E548", VA = "0x149E548")]
		public void CheckObject(Transform trans, bool fromCollision = false)
		{
		}

		[Token(Token = "0x60052F6")]
		[Address(RVA = "0x149EECC", Offset = "0x149EECC", VA = "0x149EECC")]
		private Vector3 GetHitDir(Transform ballTrans)
		{
			return default;
		}

		[Token(Token = "0x60052F7")]
		[Address(RVA = "0x149EFB8", Offset = "0x149EFB8", VA = "0x149EFB8")]
		private void PlayFlagAnimation(Vector3 hitDir)
		{
		}

		[Token(Token = "0x60052F8")]
		[Address(RVA = "0x149ECBC", Offset = "0x149ECBC", VA = "0x149ECBC")]
		private void Complete()
		{
		}

		[Token(Token = "0x60052F9")]
		[Address(RVA = "0x149F144", Offset = "0x149F144", VA = "0x149F144")]
		public GolfCoursePinGoal()
		{
		}

		[Token(Token = "0x60052FA")]
		[Address(RVA = "0x149F160", Offset = "0x149F160", VA = "0x149F160")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70CB8", Offset = "0x70CB8")]
		private void _003CComplete_003Eb__25_1()
		{
		}
	}
}
