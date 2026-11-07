using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200084D")]
public class Snake2D : MonoBehaviour
{
	[Token(Token = "0x200084E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x419A8", Offset = "0x419A8")]
	private sealed class _003C_003Ec__DisplayClass10_0
	{
		[Token(Token = "0x4002D02")]
		[FieldOffset(Offset = "0x10")]
		public Snake2D _003C_003E4__this;

		[Token(Token = "0x4002D03")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 lastSegmentSize;

		[Token(Token = "0x6002651")]
		[Address(RVA = "0x1851184", Offset = "0x1851184", VA = "0x1851184")]
		public _003C_003Ec__DisplayClass10_0()
		{
		}

		[Token(Token = "0x6002652")]
		[Address(RVA = "0x185118C", Offset = "0x185118C", VA = "0x185118C")]
		internal void _003CAddSegmentRoutine_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x200084F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x419B8", Offset = "0x419B8")]
	private sealed class _003C_003Ec__DisplayClass10_1
	{
		[Token(Token = "0x4002D04")]
		[FieldOffset(Offset = "0x10")]
		public Transform segment;

		[Token(Token = "0x4002D05")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 origScale;

		[Token(Token = "0x4002D06")]
		[FieldOffset(Offset = "0x28")]
		public _003C_003Ec__DisplayClass10_0 CS_0024_003C_003E8__locals1;

		[Token(Token = "0x6002653")]
		[Address(RVA = "0x1851294", Offset = "0x1851294", VA = "0x1851294")]
		public _003C_003Ec__DisplayClass10_1()
		{
		}

		[Token(Token = "0x6002654")]
		[Address(RVA = "0x185129C", Offset = "0x185129C", VA = "0x185129C")]
		internal void _003CAddSegmentRoutine_003Eb__1(float t)
		{
		}
	}

	[Token(Token = "0x2000850")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x419C8", Offset = "0x419C8")]
	private sealed class _003CAddSegmentRoutine_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002D07")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002D08")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002D09")]
		[FieldOffset(Offset = "0x20")]
		public Snake2D _003C_003E4__this;

		[Token(Token = "0x4002D0A")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass10_0 _003C_003E8__1;

		[Token(Token = "0x4002D0B")]
		[FieldOffset(Offset = "0x30")]
		private int _003Ci_003E5__2;

		[Token(Token = "0x17000425")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002658")]
			[Address(RVA = "0x185176C", Offset = "0x185176C", VA = "0x185176C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000426")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600265A")]
			[Address(RVA = "0x18517B4", Offset = "0x18517B4", VA = "0x18517B4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002655")]
		[Address(RVA = "0x1851354", Offset = "0x1851354", VA = "0x1851354")]
		[DebuggerHidden]
		public _003CAddSegmentRoutine_003Ed__10(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002656")]
		[Address(RVA = "0x1851380", Offset = "0x1851380", VA = "0x1851380", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002657")]
		[Address(RVA = "0x1851384", Offset = "0x1851384", VA = "0x1851384", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6002658")]
		[Address(RVA = "0x185176C", Offset = "0x185176C", VA = "0x185176C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002659")]
		[Address(RVA = "0x1851774", Offset = "0x1851774", VA = "0x1851774", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600265A")]
		[Address(RVA = "0x18517B4", Offset = "0x18517B4", VA = "0x18517B4", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4002CFB")]
	[FieldOffset(Offset = "0x18")]
	public Transform head;

	[Token(Token = "0x4002CFC")]
	[FieldOffset(Offset = "0x20")]
	public List<Transform> segments;

	[Token(Token = "0x4002CFD")]
	[FieldOffset(Offset = "0x28")]
	public bool BodyCollision;

	[Token(Token = "0x4002CFE")]
	[FieldOffset(Offset = "0x30")]
	private List<Vector2> breadcrumbs;

	[Token(Token = "0x4002CFF")]
	[FieldOffset(Offset = "0x38")]
	public float segmentSpacing;

	[Token(Token = "0x4002D00")]
	[FieldOffset(Offset = "0x40")]
	public AnimationCurve EatRoutineCurve;

	[Token(Token = "0x4002D01")]
	[FieldOffset(Offset = "0x48")]
	public RandomAudioClips AddSegmentClips;

	[Token(Token = "0x600264C")]
	[Address(RVA = "0x16B8874", Offset = "0x16B8874", VA = "0x16B8874")]
	private void Start()
	{
	}

	[Token(Token = "0x600264D")]
	[Address(RVA = "0x16B8B0C", Offset = "0x16B8B0C", VA = "0x16B8B0C")]
	private void Update()
	{
	}

	[Token(Token = "0x600264E")]
	[Address(RVA = "0x16B9134", Offset = "0x16B9134", VA = "0x16B9134")]
	public void AddSegment()
	{
	}

	[Token(Token = "0x600264F")]
	[Address(RVA = "0x16B9374", Offset = "0x16B9374", VA = "0x16B9374")]
	private IEnumerator AddSegmentRoutine()
	{
		return null;
	}

	[Token(Token = "0x6002650")]
	[Address(RVA = "0x16B93E8", Offset = "0x16B93E8", VA = "0x16B93E8")]
	public Snake2D()
	{
	}
}
