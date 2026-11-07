using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.Dynamics
{
	[Token(Token = "0x20000FB")]
	public class BehaviourFall : BehaviourBase
	{
		[Token(Token = "0x20000FC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x33864", Offset = "0x33864")]
		private sealed class _003CSmoothActivate_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400056D")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400056E")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400056F")]
			[FieldOffset(Offset = "0x20")]
			public BehaviourFall _003C_003E4__this;

			[Token(Token = "0x4000570")]
			[FieldOffset(Offset = "0x28")]
			private float _003Cfader_003E5__2;

			[Token(Token = "0x170000D9")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x600067B")]
				[Address(RVA = "0x1338654", Offset = "0x1338654", VA = "0x1338654", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170000DA")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600067D")]
				[Address(RVA = "0x133869C", Offset = "0x133869C", VA = "0x133869C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000678")]
			[Address(RVA = "0x1338450", Offset = "0x1338450", VA = "0x1338450")]
			[DebuggerHidden]
			public _003CSmoothActivate_003Ed__21(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000679")]
			[Address(RVA = "0x133847C", Offset = "0x133847C", VA = "0x133847C", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600067A")]
			[Address(RVA = "0x1338480", Offset = "0x1338480", VA = "0x1338480", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x600067B")]
			[Address(RVA = "0x1338654", Offset = "0x1338654", VA = "0x1338654", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600067C")]
			[Address(RVA = "0x133865C", Offset = "0x133865C", VA = "0x133865C", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x600067D")]
			[Address(RVA = "0x133869C", Offset = "0x133869C", VA = "0x133869C", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x400055D")]
		[FieldOffset(Offset = "0xF8")]
		public string stateName;

		[Token(Token = "0x400055E")]
		[FieldOffset(Offset = "0x100")]
		public float transitionDuration;

		[Token(Token = "0x400055F")]
		[FieldOffset(Offset = "0x104")]
		public int layer;

		[Token(Token = "0x4000560")]
		[FieldOffset(Offset = "0x108")]
		public float fixedTime;

		[Token(Token = "0x4000561")]
		[FieldOffset(Offset = "0x10C")]
		public LayerMask raycastLayers;

		[Token(Token = "0x4000562")]
		[FieldOffset(Offset = "0x110")]
		public string blendParameter;

		[Token(Token = "0x4000563")]
		[FieldOffset(Offset = "0x118")]
		public float writheHeight;

		[Token(Token = "0x4000564")]
		[FieldOffset(Offset = "0x11C")]
		public float writheYVelocity;

		[Token(Token = "0x4000565")]
		[FieldOffset(Offset = "0x120")]
		public float blendSpeed;

		[Token(Token = "0x4000566")]
		[FieldOffset(Offset = "0x124")]
		public float blendMappingSpeed;

		[Token(Token = "0x4000567")]
		[FieldOffset(Offset = "0x128")]
		public bool canEnd;

		[Token(Token = "0x4000568")]
		[FieldOffset(Offset = "0x12C")]
		public float minTime;

		[Token(Token = "0x4000569")]
		[FieldOffset(Offset = "0x130")]
		public float maxEndVelocity;

		[Token(Token = "0x400056A")]
		[FieldOffset(Offset = "0x138")]
		public PuppetEvent onEnd;

		[Token(Token = "0x400056B")]
		[FieldOffset(Offset = "0x150")]
		private float timer;

		[Token(Token = "0x400056C")]
		[FieldOffset(Offset = "0x154")]
		private bool endTriggered;

		[Token(Token = "0x600066B")]
		[Address(RVA = "0x12FC5B0", Offset = "0x12FC5B0", VA = "0x12FC5B0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x38344", Offset = "0x38344")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0x12FC5F8", Offset = "0x12FC5F8", VA = "0x12FC5F8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3837C", Offset = "0x3837C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0x12FC640", Offset = "0x12FC640", VA = "0x12FC640", Slot = "15")]
		protected override void OnActivate()
		{
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0x12FC73C", Offset = "0x12FC73C", VA = "0x12FC73C", Slot = "16")]
		protected override void OnDeactivate()
		{
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0x12FC744", Offset = "0x12FC744", VA = "0x12FC744", Slot = "4")]
		public override void OnReactivate()
		{
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x12FC6C8", Offset = "0x12FC6C8", VA = "0x12FC6C8")]
		private IEnumerator SmoothActivate()
		{
			return null;
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0x12FC750", Offset = "0x12FC750", VA = "0x12FC750", Slot = "18")]
		protected override void OnFixedUpdate()
		{
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0x12FCB94", Offset = "0x12FCB94", VA = "0x12FCB94", Slot = "20")]
		protected override void OnLateUpdate()
		{
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0x12FCCA4", Offset = "0x12FCCA4", VA = "0x12FCCA4", Slot = "5")]
		public override void Resurrect()
		{
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0x12FCA50", Offset = "0x12FCA50", VA = "0x12FCA50")]
		private float GetBlendTarget(float groundHeight)
		{
			return default;
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0x12FC940", Offset = "0x12FC940", VA = "0x12FC940")]
		private float GetGroundHeight()
		{
			return default;
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0x12FCD0C", Offset = "0x12FCD0C", VA = "0x12FCD0C", Slot = "12")]
		public override void OnMuscleReconnected(Muscle m)
		{
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0x12FCD30", Offset = "0x12FCD30", VA = "0x12FCD30")]
		public BehaviourFall()
		{
		}
	}
}
