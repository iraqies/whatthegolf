using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Chronos;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000140")]
public class MultiplayerTimeScaleChangeEffect : MonoBehaviour
{
	[Token(Token = "0x2000141")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DC30", Offset = "0x3DC30")]
	private sealed class _003CStart_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400059B")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400059C")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400059D")]
		[FieldOffset(Offset = "0x20")]
		public MultiplayerTimeScaleChangeEffect _003C_003E4__this;

		[Token(Token = "0x170000B5")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000572")]
			[Address(RVA = "0x1804120", Offset = "0x1804120", VA = "0x1804120", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170000B6")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000574")]
			[Address(RVA = "0x1804168", Offset = "0x1804168", VA = "0x1804168", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x1804020", Offset = "0x1804020", VA = "0x1804020")]
		[DebuggerHidden]
		public _003CStart_003Ed__10(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x180404C", Offset = "0x180404C", VA = "0x180404C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x1804050", Offset = "0x1804050", VA = "0x1804050", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x1804120", Offset = "0x1804120", VA = "0x1804120", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x1804128", Offset = "0x1804128", VA = "0x1804128", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x1804168", Offset = "0x1804168", VA = "0x1804168", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4000591")]
	[FieldOffset(Offset = "0x18")]
	public Vector2 AlphaRange;

	[Token(Token = "0x4000592")]
	[FieldOffset(Offset = "0x20")]
	public float ChangeSpeed;

	[Token(Token = "0x4000593")]
	[FieldOffset(Offset = "0x24")]
	public float FovChange;

	[Token(Token = "0x4000594")]
	[FieldOffset(Offset = "0x28")]
	public float OrthoSizeChange;

	[Token(Token = "0x4000595")]
	[FieldOffset(Offset = "0x30")]
	public Clock Clock;

	[Token(Token = "0x4000596")]
	[FieldOffset(Offset = "0x38")]
	public GolfBallController Controller;

	[Token(Token = "0x4000597")]
	[FieldOffset(Offset = "0x40")]
	private float target;

	[Token(Token = "0x4000598")]
	[FieldOffset(Offset = "0x48")]
	private CameraFilterPack_Color_Sepia sepia;

	[Token(Token = "0x4000599")]
	[FieldOffset(Offset = "0x50")]
	private Camera camera;

	[Token(Token = "0x400059A")]
	[FieldOffset(Offset = "0x58")]
	private bool initialized;

	[Token(Token = "0x600056C")]
	[Address(RVA = "0x1584A08", Offset = "0x1584A08", VA = "0x1584A08")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x600056D")]
	[Address(RVA = "0x1584A7C", Offset = "0x1584A7C", VA = "0x1584A7C")]
	private void Update()
	{
	}

	[Token(Token = "0x600056E")]
	[Address(RVA = "0x1584C6C", Offset = "0x1584C6C", VA = "0x1584C6C")]
	public MultiplayerTimeScaleChangeEffect()
	{
	}
}
