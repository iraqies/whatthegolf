using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Token(Token = "0x20001CB")]
	public abstract class OffsetModifier : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20001CC")]
		public class OffsetLimits
		{
			[Token(Token = "0x4000C2A")]
			[FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000C2B")]
			[FieldOffset(Offset = "0x14")]
			public float spring;

			[Token(Token = "0x4000C2C")]
			[FieldOffset(Offset = "0x18")]
			public bool x;

			[Token(Token = "0x4000C2D")]
			[FieldOffset(Offset = "0x19")]
			public bool y;

			[Token(Token = "0x4000C2E")]
			[FieldOffset(Offset = "0x1A")]
			public bool z;

			[Token(Token = "0x4000C2F")]
			[FieldOffset(Offset = "0x1C")]
			public float minX;

			[Token(Token = "0x4000C30")]
			[FieldOffset(Offset = "0x20")]
			public float maxX;

			[Token(Token = "0x4000C31")]
			[FieldOffset(Offset = "0x24")]
			public float minY;

			[Token(Token = "0x4000C32")]
			[FieldOffset(Offset = "0x28")]
			public float maxY;

			[Token(Token = "0x4000C33")]
			[FieldOffset(Offset = "0x2C")]
			public float minZ;

			[Token(Token = "0x4000C34")]
			[FieldOffset(Offset = "0x30")]
			public float maxZ;

			[Token(Token = "0x6000D46")]
			[Address(RVA = "0x1350FE8", Offset = "0x1350FE8", VA = "0x1350FE8")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x6000D47")]
			[Address(RVA = "0x1351210", Offset = "0x1351210", VA = "0x1351210")]
			private float SpringAxis(float value, float min, float max)
			{
				return default;
			}

			[Token(Token = "0x6000D48")]
			[Address(RVA = "0x1351288", Offset = "0x1351288", VA = "0x1351288")]
			private float Spring(float value, float limit, bool negative)
			{
				return default;
			}

			[Token(Token = "0x6000D49")]
			[Address(RVA = "0x13512E0", Offset = "0x13512E0", VA = "0x13512E0")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x20001CD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3395C", Offset = "0x3395C")]
		private sealed class _003CInitiate_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000C35")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000C36")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000C37")]
			[FieldOffset(Offset = "0x20")]
			public OffsetModifier _003C_003E4__this;

			[Token(Token = "0x170001AE")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6000D4D")]
				[Address(RVA = "0x1350F98", Offset = "0x1350F98", VA = "0x1350F98", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170001AF")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6000D4F")]
				[Address(RVA = "0x1350FE0", Offset = "0x1350FE0", VA = "0x1350FE0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000D4A")]
			[Address(RVA = "0x1350E08", Offset = "0x1350E08", VA = "0x1350E08")]
			[DebuggerHidden]
			public _003CInitiate_003Ed__8(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000D4B")]
			[Address(RVA = "0x1350E34", Offset = "0x1350E34", VA = "0x1350E34", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6000D4C")]
			[Address(RVA = "0x1350E38", Offset = "0x1350E38", VA = "0x1350E38", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000D4D")]
			[Address(RVA = "0x1350F98", Offset = "0x1350F98", VA = "0x1350F98", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000D4E")]
			[Address(RVA = "0x1350FA0", Offset = "0x1350FA0", VA = "0x1350FA0", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6000D4F")]
			[Address(RVA = "0x1350FE0", Offset = "0x1350FE0", VA = "0x1350FE0", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4000C27")]
		[FieldOffset(Offset = "0x18")]
		public float weight;

		[Token(Token = "0x4000C28")]
		[FieldOffset(Offset = "0x20")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000C29")]
		[FieldOffset(Offset = "0x28")]
		protected float lastTime;

		[Token(Token = "0x170001AD")]
		protected float deltaTime
		{
			[Token(Token = "0x6000D3E")]
			[Address(RVA = "0x13BD10C", Offset = "0x13BD10C", VA = "0x13BD10C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000D3F")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000D40")]
		[Address(RVA = "0x13BCEB4", Offset = "0x13BCEB4", VA = "0x13BCEB4", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000D41")]
		[Address(RVA = "0x13BD138", Offset = "0x13BD138", VA = "0x13BD138")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x6000D42")]
		[Address(RVA = "0x13BD1AC", Offset = "0x13BD1AC", VA = "0x13BD1AC")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x6000D43")]
		[Address(RVA = "0x13BD290", Offset = "0x13BD290", VA = "0x13BD290")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x6000D44")]
		[Address(RVA = "0x13BD350", Offset = "0x13BD350", VA = "0x13BD350", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000D45")]
		[Address(RVA = "0x13BD0FC", Offset = "0x13BD0FC", VA = "0x13BD0FC")]
		protected OffsetModifier()
		{
		}
	}
}
