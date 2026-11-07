using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace TennisGolf
{
	[Token(Token = "0x200109C")]
	public class TennisBall : MonoBehaviour
	{
		[Token(Token = "0x200109D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47A74", Offset = "0x47A74")]
		private sealed class _003C_003Ec__DisplayClass32_0
		{
			[Token(Token = "0x4005772")]
			[FieldOffset(Offset = "0x10")]
			public TennisBall _003C_003E4__this;

			[Token(Token = "0x4005773")]
			[FieldOffset(Offset = "0x18")]
			public Vector3 v;

			[Token(Token = "0x6004A78")]
			[Address(RVA = "0x1862330", Offset = "0x1862330", VA = "0x1862330")]
			public _003C_003Ec__DisplayClass32_0()
			{
			}

			[Token(Token = "0x6004A79")]
			[Address(RVA = "0x1862338", Offset = "0x1862338", VA = "0x1862338")]
			internal void _003CStretch_003Eb__0(float t)
			{
			}

			[Token(Token = "0x6004A7A")]
			[Address(RVA = "0x18623F0", Offset = "0x18623F0", VA = "0x18623F0")]
			internal void _003CStretch_003Eb__1(float t)
			{
			}
		}

		[Token(Token = "0x200109E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47A84", Offset = "0x47A84")]
		private sealed class _003CStretch_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4005774")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4005775")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4005776")]
			[FieldOffset(Offset = "0x20")]
			public TennisBall _003C_003E4__this;

			[Token(Token = "0x4005777")]
			[FieldOffset(Offset = "0x28")]
			public Vector3 normal;

			[Token(Token = "0x4005778")]
			[FieldOffset(Offset = "0x38")]
			private _003C_003Ec__DisplayClass32_0 _003C_003E8__1;

			[Token(Token = "0x170007DA")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6004A7E")]
				[Address(RVA = "0x18626FC", Offset = "0x18626FC", VA = "0x18626FC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170007DB")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6004A80")]
				[Address(RVA = "0x1862744", Offset = "0x1862744", VA = "0x1862744", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6004A7B")]
			[Address(RVA = "0x18624A8", Offset = "0x18624A8", VA = "0x18624A8")]
			[DebuggerHidden]
			public _003CStretch_003Ed__32(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6004A7C")]
			[Address(RVA = "0x18624D4", Offset = "0x18624D4", VA = "0x18624D4", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6004A7D")]
			[Address(RVA = "0x18624D8", Offset = "0x18624D8", VA = "0x18624D8", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6004A7E")]
			[Address(RVA = "0x18626FC", Offset = "0x18626FC", VA = "0x18626FC", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6004A7F")]
			[Address(RVA = "0x1862704", Offset = "0x1862704", VA = "0x1862704", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6004A80")]
			[Address(RVA = "0x1862744", Offset = "0x1862744", VA = "0x1862744", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x400575D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject player;

		[Token(Token = "0x400575E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject opponent;

		[Token(Token = "0x400575F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int numberOfBounces;

		[Token(Token = "0x4005760")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject lastHitter;

		[Token(Token = "0x4005761")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private LayerMask groundMask;

		[Token(Token = "0x4005762")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform model;

		[Token(Token = "0x4005763")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float stretchAmount;

		[Token(Token = "0x4005764")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float stretchTime;

		[Token(Token = "0x4005765")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject playerCourt;

		[Token(Token = "0x4005766")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject opponentCourt;

		[Token(Token = "0x4005767")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private List<AudioClip> hitSounds;

		[Token(Token = "0x4005768")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private List<AudioClip> gruntSounds;

		[Token(Token = "0x4005769")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private bool useGruntSounds;

		[Token(Token = "0x400576A")]
		[FieldOffset(Offset = "0x71")]
		public bool GameOver;

		[Token(Token = "0x400576B")]
		[FieldOffset(Offset = "0x78")]
		public Action OnPlayerWon;

		[Token(Token = "0x400576C")]
		[FieldOffset(Offset = "0x80")]
		public Action OnOpponentWon;

		[Token(Token = "0x400576D")]
		[FieldOffset(Offset = "0x88")]
		private float delay;

		[Token(Token = "0x400576E")]
		[FieldOffset(Offset = "0x90")]
		private Coroutine stretchRoutine;

		[Token(Token = "0x400576F")]
		[FieldOffset(Offset = "0x98")]
		private Vector3 currentTarget;

		[Token(Token = "0x4005770")]
		[FieldOffset(Offset = "0xA4")]
		private float LoseTimer;

		[Token(Token = "0x4005771")]
		[FieldOffset(Offset = "0xA8")]
		public bool DontUpdate;

		[Token(Token = "0x6004A68")]
		[Address(RVA = "0x16F857C", Offset = "0x16F857C", VA = "0x16F857C")]
		private void Update()
		{
		}

		[Token(Token = "0x6004A69")]
		[Address(RVA = "0x16F869C", Offset = "0x16F869C", VA = "0x16F869C")]
		private void OnCollisionEnter(Collision other)
		{
		}

		[Token(Token = "0x6004A6A")]
		[Address(RVA = "0x16F8784", Offset = "0x16F8784", VA = "0x16F8784")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6004A6B")]
		[Address(RVA = "0x16F8808", Offset = "0x16F8808", VA = "0x16F8808", Slot = "4")]
		public virtual void CheckCollision(string collidingTag, GameObject hit)
		{
		}

		[Token(Token = "0x6004A6C")]
		[Address(RVA = "0x16F8BEC", Offset = "0x16F8BEC", VA = "0x16F8BEC")]
		private void Win()
		{
		}

		[Token(Token = "0x6004A6D")]
		[Address(RVA = "0x16F8630", Offset = "0x16F8630", VA = "0x16F8630")]
		private void Lose()
		{
		}

		[Token(Token = "0x6004A6E")]
		[Address(RVA = "0x16F8DB4", Offset = "0x16F8DB4", VA = "0x16F8DB4")]
		public void SetLastHitter(GameObject go)
		{
		}

		[Token(Token = "0x6004A6F")]
		[Address(RVA = "0x16F8E38", Offset = "0x16F8E38", VA = "0x16F8E38")]
		public GameObject GetLastHitter()
		{
			return null;
		}

		[Token(Token = "0x6004A70")]
		[Address(RVA = "0x16F8E40", Offset = "0x16F8E40", VA = "0x16F8E40")]
		public Vector3 GetCurrentTarget()
		{
			return default;
		}

		[Token(Token = "0x6004A71")]
		[Address(RVA = "0x16F8C88", Offset = "0x16F8C88", VA = "0x16F8C88")]
		public void ResetBounces()
		{
		}

		[Token(Token = "0x6004A72")]
		[Address(RVA = "0x16F8C90", Offset = "0x16F8C90", VA = "0x16F8C90")]
		private void SetDelay()
		{
		}

		[Token(Token = "0x6004A73")]
		[Address(RVA = "0x16F8E4C", Offset = "0x16F8E4C", VA = "0x16F8E4C")]
		private IEnumerator Stretch(Vector3 normal)
		{
			return null;
		}

		[Token(Token = "0x6004A74")]
		[Address(RVA = "0x16F8EE4", Offset = "0x16F8EE4", VA = "0x16F8EE4")]
		public Vector3 CalculateVelocityForTarget(Vector3 startPosition, Vector3 target, float initialAngle)
		{
			return default;
		}

		[Token(Token = "0x6004A75")]
		[Address(RVA = "0x16F9060", Offset = "0x16F9060", VA = "0x16F9060")]
		public TennisBall()
		{
		}

		[Token(Token = "0x6004A76")]
		[Address(RVA = "0x16F9078", Offset = "0x16F9078", VA = "0x16F9078")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F5A4", Offset = "0x6F5A4")]
		private void _003CSetDelay_003Eb__31_0(float t)
		{
		}

		[Token(Token = "0x6004A77")]
		[Address(RVA = "0x16F9080", Offset = "0x16F9080", VA = "0x16F9080")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F5B4", Offset = "0x6F5B4")]
		private void _003CSetDelay_003Eb__31_1()
		{
		}
	}
}
