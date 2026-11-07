using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace Core
{
	[Token(Token = "0x2001422")]
	public class PodRacerEngine : MonoBehaviour
	{
		[Token(Token = "0x2001423")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4904C", Offset = "0x4904C")]
		private sealed class _003CBoom_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4006C9C")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4006C9D")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4006C9E")]
			[FieldOffset(Offset = "0x20")]
			public PodRacerEngine _003C_003E4__this;

			[Token(Token = "0x4006C9F")]
			[FieldOffset(Offset = "0x28")]
			public GameObject hitObject;

			[Token(Token = "0x17000A9F")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6005DAE")]
				[Address(RVA = "0x1829C6C", Offset = "0x1829C6C", VA = "0x1829C6C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000AA0")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6005DB0")]
				[Address(RVA = "0x1829CB4", Offset = "0x1829CB4", VA = "0x1829CB4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6005DAB")]
			[Address(RVA = "0x1829950", Offset = "0x1829950", VA = "0x1829950")]
			[DebuggerHidden]
			public _003CBoom_003Ed__14(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6005DAC")]
			[Address(RVA = "0x182997C", Offset = "0x182997C", VA = "0x182997C", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6005DAD")]
			[Address(RVA = "0x1829980", Offset = "0x1829980", VA = "0x1829980", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6005DAE")]
			[Address(RVA = "0x1829C6C", Offset = "0x1829C6C", VA = "0x1829C6C", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6005DAF")]
			[Address(RVA = "0x1829C74", Offset = "0x1829C74", VA = "0x1829C74", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6005DB0")]
			[Address(RVA = "0x1829CB4", Offset = "0x1829CB4", VA = "0x1829CB4", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4006C91")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public ParticleSystem thrusterParticles;

		[Token(Token = "0x4006C92")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LayerMask collisionBlackListLayer;

		[Token(Token = "0x4006C93")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		public bool useGravity;

		[Token(Token = "0x4006C94")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GolfBallController golfBallController;

		[Token(Token = "0x4006C95")]
		[FieldOffset(Offset = "0x30")]
		private bool didExplode;

		[Token(Token = "0x4006C96")]
		[FieldOffset(Offset = "0x38")]
		private ExplosionBarrel barrel;

		[Token(Token = "0x4006C97")]
		[FieldOffset(Offset = "0x40")]
		public bool didAim;

		[Token(Token = "0x4006C98")]
		[FieldOffset(Offset = "0x44")]
		public float firstAimTime;

		[Token(Token = "0x4006C99")]
		[FieldOffset(Offset = "0x48")]
		public bool failLevelOnExplode;

		[Token(Token = "0x4006C9A")]
		[FieldOffset(Offset = "0x50")]
		public Action<GameObject> onExplode;

		[Token(Token = "0x4006C9B")]
		[FieldOffset(Offset = "0x58")]
		public Rigidbody rigidbodyC;

		[Token(Token = "0x6005DA6")]
		[Address(RVA = "0x16034F4", Offset = "0x16034F4", VA = "0x16034F4")]
		public void Awake()
		{
		}

		[Token(Token = "0x6005DA7")]
		[Address(RVA = "0x1603550", Offset = "0x1603550", VA = "0x1603550")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x6005DA8")]
		[Address(RVA = "0x16035E4", Offset = "0x16035E4", VA = "0x16035E4")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6005DA9")]
		[Address(RVA = "0x1603734", Offset = "0x1603734", VA = "0x1603734")]
		private IEnumerator Boom(GameObject hitObject)
		{
			return null;
		}

		[Token(Token = "0x6005DAA")]
		[Address(RVA = "0x16037AC", Offset = "0x16037AC", VA = "0x16037AC")]
		public PodRacerEngine()
		{
		}
	}
}
