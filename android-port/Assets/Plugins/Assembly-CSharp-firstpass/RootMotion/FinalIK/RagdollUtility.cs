using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Token(Token = "0x20001A7")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x338C4", Offset = "0x338C4")]
	public class RagdollUtility : MonoBehaviour
	{
		[Token(Token = "0x20001A8")]
		public class Rigidbone
		{
			[Token(Token = "0x4000B6A")]
			[FieldOffset(Offset = "0x10")]
			public Rigidbody r;

			[Token(Token = "0x4000B6B")]
			[FieldOffset(Offset = "0x18")]
			public Transform t;

			[Token(Token = "0x4000B6C")]
			[FieldOffset(Offset = "0x20")]
			public Collider collider;

			[Token(Token = "0x4000B6D")]
			[FieldOffset(Offset = "0x28")]
			public Joint joint;

			[Token(Token = "0x4000B6E")]
			[FieldOffset(Offset = "0x30")]
			public Rigidbody c;

			[Token(Token = "0x4000B6F")]
			[FieldOffset(Offset = "0x38")]
			public bool updateAnchor;

			[Token(Token = "0x4000B70")]
			[FieldOffset(Offset = "0x3C")]
			public Vector3 deltaPosition;

			[Token(Token = "0x4000B71")]
			[FieldOffset(Offset = "0x48")]
			public Quaternion deltaRotation;

			[Token(Token = "0x4000B72")]
			[FieldOffset(Offset = "0x58")]
			public float deltaTime;

			[Token(Token = "0x4000B73")]
			[FieldOffset(Offset = "0x5C")]
			public Vector3 lastPosition;

			[Token(Token = "0x4000B74")]
			[FieldOffset(Offset = "0x68")]
			public Quaternion lastRotation;

			[Token(Token = "0x6000C89")]
			[Address(RVA = "0x1354370", Offset = "0x1354370", VA = "0x1354370")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x6000C8A")]
			[Address(RVA = "0x13544E4", Offset = "0x13544E4", VA = "0x13544E4")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x6000C8B")]
			[Address(RVA = "0x13545C4", Offset = "0x13545C4", VA = "0x13545C4")]
			public void WakeUp(float velocityWeight, float angularVelocityWeight)
			{
			}
		}

		[Token(Token = "0x20001A9")]
		public class Child
		{
			[Token(Token = "0x4000B75")]
			[FieldOffset(Offset = "0x10")]
			public Transform t;

			[Token(Token = "0x4000B76")]
			[FieldOffset(Offset = "0x18")]
			public Vector3 localPosition;

			[Token(Token = "0x4000B77")]
			[FieldOffset(Offset = "0x24")]
			public Quaternion localRotation;

			[Token(Token = "0x6000C8C")]
			[Address(RVA = "0x135417C", Offset = "0x135417C", VA = "0x135417C")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x6000C8D")]
			[Address(RVA = "0x13541DC", Offset = "0x13541DC", VA = "0x13541DC")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x6000C8E")]
			[Address(RVA = "0x1354320", Offset = "0x1354320", VA = "0x1354320")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x20001AA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3392C", Offset = "0x3392C")]
		private sealed class _003CDisableRagdollSmooth_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000B78")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000B79")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000B7A")]
			[FieldOffset(Offset = "0x20")]
			public RagdollUtility _003C_003E4__this;

			[Token(Token = "0x17000196")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6000C92")]
				[Address(RVA = "0x135412C", Offset = "0x135412C", VA = "0x135412C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000197")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6000C94")]
				[Address(RVA = "0x1354174", Offset = "0x1354174", VA = "0x1354174", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000C8F")]
			[Address(RVA = "0x1353F10", Offset = "0x1353F10", VA = "0x1353F10")]
			[DebuggerHidden]
			public _003CDisableRagdollSmooth_003Ed__21(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000C90")]
			[Address(RVA = "0x1353F3C", Offset = "0x1353F3C", VA = "0x1353F3C", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6000C91")]
			[Address(RVA = "0x1353F40", Offset = "0x1353F40", VA = "0x1353F40", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000C92")]
			[Address(RVA = "0x135412C", Offset = "0x135412C", VA = "0x135412C", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000C93")]
			[Address(RVA = "0x1354134", Offset = "0x1354134", VA = "0x1354134", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6000C94")]
			[Address(RVA = "0x1354174", Offset = "0x1354174", VA = "0x1354174", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4000B5A")]
		[FieldOffset(Offset = "0x18")]
		public IK ik;

		[Token(Token = "0x4000B5B")]
		[FieldOffset(Offset = "0x20")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x4000B5C")]
		[FieldOffset(Offset = "0x24")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x4000B5D")]
		[FieldOffset(Offset = "0x28")]
		public float applyVelocity;

		[Token(Token = "0x4000B5E")]
		[FieldOffset(Offset = "0x2C")]
		public float applyAngularVelocity;

		[Token(Token = "0x4000B5F")]
		[FieldOffset(Offset = "0x30")]
		private Animator animator;

		[Token(Token = "0x4000B60")]
		[FieldOffset(Offset = "0x38")]
		private Rigidbone[] rigidbones;

		[Token(Token = "0x4000B61")]
		[FieldOffset(Offset = "0x40")]
		private Child[] children;

		[Token(Token = "0x4000B62")]
		[FieldOffset(Offset = "0x48")]
		private bool enableRagdollFlag;

		[Token(Token = "0x4000B63")]
		[FieldOffset(Offset = "0x4C")]
		private AnimatorUpdateMode animatorUpdateMode;

		[Token(Token = "0x4000B64")]
		[FieldOffset(Offset = "0x50")]
		private IK[] allIKComponents;

		[Token(Token = "0x4000B65")]
		[FieldOffset(Offset = "0x58")]
		private bool[] fixTransforms;

		[Token(Token = "0x4000B66")]
		[FieldOffset(Offset = "0x60")]
		private float ragdollWeight;

		[Token(Token = "0x4000B67")]
		[FieldOffset(Offset = "0x64")]
		private float ragdollWeightV;

		[Token(Token = "0x4000B68")]
		[FieldOffset(Offset = "0x68")]
		private bool fixedFrame;

		[Token(Token = "0x4000B69")]
		[FieldOffset(Offset = "0x70")]
		private bool[] disabledIKComponents;

		[Token(Token = "0x17000194")]
		private bool isRagdoll
		{
			[Token(Token = "0x6000C82")]
			[Address(RVA = "0x13D7AA8", Offset = "0x13D7AA8", VA = "0x13D7AA8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000195")]
		private bool ikUsed
		{
			[Token(Token = "0x6000C84")]
			[Address(RVA = "0x13D85E8", Offset = "0x13D85E8", VA = "0x13D85E8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000C77")]
		[Address(RVA = "0x13D7A70", Offset = "0x13D7A70", VA = "0x13D7A70")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x6000C78")]
		[Address(RVA = "0x13D7B1C", Offset = "0x13D7B1C", VA = "0x13D7B1C")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x6000C79")]
		[Address(RVA = "0x13D7CF8", Offset = "0x13D7CF8", VA = "0x13D7CF8")]
		public void Start()
		{
		}

		[Token(Token = "0x6000C7A")]
		[Address(RVA = "0x13D7C84", Offset = "0x13D7C84", VA = "0x13D7C84")]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x6000C7B")]
		[Address(RVA = "0x13D8114", Offset = "0x13D8114", VA = "0x13D8114")]
		private void Update()
		{
		}

		[Token(Token = "0x6000C7C")]
		[Address(RVA = "0x13D8364", Offset = "0x13D8364", VA = "0x13D8364")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000C7D")]
		[Address(RVA = "0x13D8484", Offset = "0x13D8484", VA = "0x13D8484")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000C7E")]
		[Address(RVA = "0x13D87D4", Offset = "0x13D87D4", VA = "0x13D87D4")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x6000C7F")]
		[Address(RVA = "0x13D8508", Offset = "0x13D8508", VA = "0x13D8508")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x6000C80")]
		[Address(RVA = "0x13D8730", Offset = "0x13D8730", VA = "0x13D8730")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x6000C81")]
		[Address(RVA = "0x13D887C", Offset = "0x13D887C", VA = "0x13D887C")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x6000C83")]
		[Address(RVA = "0x13D8808", Offset = "0x13D8808", VA = "0x13D8808")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x6000C85")]
		[Address(RVA = "0x13D7C10", Offset = "0x13D7C10", VA = "0x13D7C10")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x6000C86")]
		[Address(RVA = "0x13D8400", Offset = "0x13D8400", VA = "0x13D8400")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x6000C87")]
		[Address(RVA = "0x13D8AC8", Offset = "0x13D8AC8", VA = "0x13D8AC8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000C88")]
		[Address(RVA = "0x13D8BF0", Offset = "0x13D8BF0", VA = "0x13D8BF0")]
		public RagdollUtility()
		{
		}
	}
}
