using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000691")]
public class ThrowObjectWave : FrogKingBaseWave
{
	[Token(Token = "0x2000692")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40EC0", Offset = "0x40EC0")]
	private sealed class _003CWaveRoutine_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400223B")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400223C")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400223D")]
		[FieldOffset(Offset = "0x20")]
		public ThrowObjectWave _003C_003E4__this;

		[Token(Token = "0x400223E")]
		[FieldOffset(Offset = "0x28")]
		public SHMUPFrogKing frogKing;

		[Token(Token = "0x400223F")]
		[FieldOffset(Offset = "0x30")]
		private int _003Ci_003E5__2;

		[Token(Token = "0x17000367")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001E1C")]
			[Address(RVA = "0x1865CE8", Offset = "0x1865CE8", VA = "0x1865CE8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000368")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001E1E")]
			[Address(RVA = "0x1865D30", Offset = "0x1865D30", VA = "0x1865D30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001E19")]
		[Address(RVA = "0x186593C", Offset = "0x186593C", VA = "0x186593C")]
		[DebuggerHidden]
		public _003CWaveRoutine_003Ed__14(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001E1A")]
		[Address(RVA = "0x1865968", Offset = "0x1865968", VA = "0x1865968", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001E1B")]
		[Address(RVA = "0x186596C", Offset = "0x186596C", VA = "0x186596C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001E1C")]
		[Address(RVA = "0x1865CE8", Offset = "0x1865CE8", VA = "0x1865CE8", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001E1D")]
		[Address(RVA = "0x1865CF0", Offset = "0x1865CF0", VA = "0x1865CF0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001E1E")]
		[Address(RVA = "0x1865D30", Offset = "0x1865D30", VA = "0x1865D30", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000693")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40ED0", Offset = "0x40ED0")]
	private sealed class _003C_003Ec__DisplayClass16_0
	{
		[Token(Token = "0x4002240")]
		[FieldOffset(Offset = "0x10")]
		public Transform trans;

		[Token(Token = "0x4002241")]
		[FieldOffset(Offset = "0x18")]
		public ThrowObjectWave _003C_003E4__this;

		[Token(Token = "0x4002242")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 startPos;

		[Token(Token = "0x4002243")]
		[FieldOffset(Offset = "0x2C")]
		public Vector3 control;

		[Token(Token = "0x4002244")]
		[FieldOffset(Offset = "0x38")]
		public Vector3 endPos;

		[Token(Token = "0x4002245")]
		[FieldOffset(Offset = "0x48")]
		public Transform shadowTrans;

		[Token(Token = "0x4002246")]
		[FieldOffset(Offset = "0x50")]
		public Vector3 startShadowScale;

		[Token(Token = "0x6001E1F")]
		[Address(RVA = "0x186526C", Offset = "0x186526C", VA = "0x186526C")]
		public _003C_003Ec__DisplayClass16_0()
		{
		}

		[Token(Token = "0x6001E20")]
		[Address(RVA = "0x1865274", Offset = "0x1865274", VA = "0x1865274")]
		internal void _003CMoveObjectRoutine_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x2000694")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40EE0", Offset = "0x40EE0")]
	private sealed class _003CMoveObjectRoutine_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002247")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002248")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002249")]
		[FieldOffset(Offset = "0x20")]
		public Transform trans;

		[Token(Token = "0x400224A")]
		[FieldOffset(Offset = "0x28")]
		public ThrowObjectWave _003C_003E4__this;

		[Token(Token = "0x400224B")]
		[FieldOffset(Offset = "0x30")]
		public Transform shadowTrans;

		[Token(Token = "0x400224C")]
		[FieldOffset(Offset = "0x38")]
		private _003C_003Ec__DisplayClass16_0 _003C_003E8__1;

		[Token(Token = "0x17000369")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001E24")]
			[Address(RVA = "0x18658EC", Offset = "0x18658EC", VA = "0x18658EC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700036A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001E26")]
			[Address(RVA = "0x1865934", Offset = "0x1865934", VA = "0x1865934", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001E21")]
		[Address(RVA = "0x18653C0", Offset = "0x18653C0", VA = "0x18653C0")]
		[DebuggerHidden]
		public _003CMoveObjectRoutine_003Ed__16(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001E22")]
		[Address(RVA = "0x18653EC", Offset = "0x18653EC", VA = "0x18653EC", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001E23")]
		[Address(RVA = "0x18653F0", Offset = "0x18653F0", VA = "0x18653F0", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001E24")]
		[Address(RVA = "0x18658EC", Offset = "0x18658EC", VA = "0x18658EC", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001E25")]
		[Address(RVA = "0x18658F4", Offset = "0x18658F4", VA = "0x18658F4", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001E26")]
		[Address(RVA = "0x1865934", Offset = "0x1865934", VA = "0x1865934", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x400222D")]
	[FieldOffset(Offset = "0x48")]
	public Transform SpawnPosition;

	[Token(Token = "0x400222E")]
	[FieldOffset(Offset = "0x50")]
	public Vector3 EndOffsetFromBoat;

	[Token(Token = "0x400222F")]
	[FieldOffset(Offset = "0x60")]
	public List<Transform> ObjectPrefabs;

	[Token(Token = "0x4002230")]
	[FieldOffset(Offset = "0x68")]
	public Transform PlayerBoat;

	[Token(Token = "0x4002231")]
	[FieldOffset(Offset = "0x70")]
	public Transform ObjectShadow;

	[Token(Token = "0x4002232")]
	[FieldOffset(Offset = "0x78")]
	public int ObjectsToThrow;

	[Token(Token = "0x4002233")]
	[FieldOffset(Offset = "0x7C")]
	public float DelayBetweenThrows;

	[Token(Token = "0x4002234")]
	[FieldOffset(Offset = "0x80")]
	public float WaveDuration;

	[Token(Token = "0x4002235")]
	[FieldOffset(Offset = "0x84")]
	public float ObjectFlyTime;

	[Token(Token = "0x4002236")]
	[FieldOffset(Offset = "0x88")]
	public float ThrowHeight;

	[Token(Token = "0x4002237")]
	[FieldOffset(Offset = "0x8C")]
	public float InitialWaitTime;

	[Token(Token = "0x4002238")]
	[FieldOffset(Offset = "0x90")]
	public AnimationCurve ShadowScaleCurve;

	[Token(Token = "0x4002239")]
	[FieldOffset(Offset = "0x98")]
	private Transform frogKingTrans;

	[Token(Token = "0x400223A")]
	[FieldOffset(Offset = "0xA0")]
	private List<Transform> spawnedObjects;

	[Token(Token = "0x6001E14")]
	[Address(RVA = "0x1712E94", Offset = "0x1712E94", VA = "0x1712E94", Slot = "4")]
	public override IEnumerator WaveRoutine(SHMUPFrogKing frogKing)
	{
		return null;
	}

	[Token(Token = "0x6001E15")]
	[Address(RVA = "0x1712F0C", Offset = "0x1712F0C", VA = "0x1712F0C", Slot = "5")]
	public override void OnSinkReset()
	{
	}

	[Token(Token = "0x6001E16")]
	[Address(RVA = "0x1713098", Offset = "0x1713098", VA = "0x1713098")]
	private IEnumerator MoveObjectRoutine(Transform trans, Transform shadowTrans)
	{
		return null;
	}

	[Token(Token = "0x6001E17")]
	[Address(RVA = "0x1713120", Offset = "0x1713120", VA = "0x1713120")]
	public Vector3 CalculateVelocityForTarget(Vector3 startPosition, Vector3 target, float initialAngle)
	{
		return default;
	}

	[Token(Token = "0x6001E18")]
	[Address(RVA = "0x1713298", Offset = "0x1713298", VA = "0x1713298")]
	public ThrowObjectWave()
	{
	}
}
