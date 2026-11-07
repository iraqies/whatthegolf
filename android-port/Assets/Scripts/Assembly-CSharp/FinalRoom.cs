using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000AA7")]
public class FinalRoom : GolfBehaviour
{
	[Token(Token = "0x2000AA8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42F10", Offset = "0x42F10")]
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		[Token(Token = "0x4003B4C")]
		[FieldOffset(Offset = "0x10")]
		public FinalRoom _003C_003E4__this;

		[Token(Token = "0x4003B4D")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 endScale;

		[Token(Token = "0x60032E4")]
		[Address(RVA = "0x17A6758", Offset = "0x17A6758", VA = "0x17A6758")]
		public _003C_003Ec__DisplayClass14_0()
		{
		}

		[Token(Token = "0x60032E5")]
		[Address(RVA = "0x17A6760", Offset = "0x17A6760", VA = "0x17A6760")]
		internal void _003CEndRoutine_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x2000AA9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42F20", Offset = "0x42F20")]
	private sealed class _003CEndRoutine_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4003B4E")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4003B4F")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4003B50")]
		[FieldOffset(Offset = "0x20")]
		public FinalRoom _003C_003E4__this;

		[Token(Token = "0x4003B51")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass14_0 _003C_003E8__1;

		[Token(Token = "0x4003B52")]
		[FieldOffset(Offset = "0x30")]
		private OverworldBall2D _003Cball_003E5__2;

		[Token(Token = "0x4003B53")]
		[FieldOffset(Offset = "0x38")]
		private float _003CnextConfetti_003E5__3;

		[Token(Token = "0x4003B54")]
		[FieldOffset(Offset = "0x3C")]
		private int _003Cindex_003E5__4;

		[Token(Token = "0x4003B55")]
		[FieldOffset(Offset = "0x40")]
		private List<Transform>.Enumerator _003C_003E7__wrap4;

		[Token(Token = "0x4003B56")]
		[FieldOffset(Offset = "0x58")]
		private Transform _003Ctarget_003E5__6;

		[Token(Token = "0x17000543")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60032EA")]
			[Address(RVA = "0x17A726C", Offset = "0x17A726C", VA = "0x17A726C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000544")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60032EC")]
			[Address(RVA = "0x17A72B4", Offset = "0x17A72B4", VA = "0x17A72B4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60032E6")]
		[Address(RVA = "0x17A6820", Offset = "0x17A6820", VA = "0x17A6820")]
		[DebuggerHidden]
		public _003CEndRoutine_003Ed__14(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60032E7")]
		[Address(RVA = "0x17A684C", Offset = "0x17A684C", VA = "0x17A684C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60032E8")]
		[Address(RVA = "0x17A6920", Offset = "0x17A6920", VA = "0x17A6920", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60032E9")]
		[Address(RVA = "0x17A68C4", Offset = "0x17A68C4", VA = "0x17A68C4")]
		private void _003C_003Em__Finally1()
		{
		}

		[Token(Token = "0x60032EA")]
		[Address(RVA = "0x17A726C", Offset = "0x17A726C", VA = "0x17A726C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60032EB")]
		[Address(RVA = "0x17A7274", Offset = "0x17A7274", VA = "0x17A7274", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60032EC")]
		[Address(RVA = "0x17A72B4", Offset = "0x17A72B4", VA = "0x17A72B4", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4003B41")]
	[FieldOffset(Offset = "0x20")]
	public OverworldGoal goal;

	[Token(Token = "0x4003B42")]
	[FieldOffset(Offset = "0x28")]
	public GameObject evilContainer;

	[Token(Token = "0x4003B43")]
	[FieldOffset(Offset = "0x30")]
	public SpriteMask mask;

	[Token(Token = "0x4003B44")]
	[FieldOffset(Offset = "0x38")]
	public List<Transform> exitPath;

	[Token(Token = "0x4003B45")]
	[FieldOffset(Offset = "0x40")]
	public ConfettiSpawner confetti;

	[Token(Token = "0x4003B46")]
	[FieldOffset(Offset = "0x48")]
	public OverworldMusicData triumpOverworldMusicData;

	[Token(Token = "0x4003B47")]
	[FieldOffset(Offset = "0x50")]
	public OverworldMusic overworldMusicManager;

	[Token(Token = "0x4003B48")]
	[FieldOffset(Offset = "0x58")]
	public float ballMoveSpeed;

	[Token(Token = "0x4003B49")]
	[FieldOffset(Offset = "0x5C")]
	public float shootoutSpeed;

	[Token(Token = "0x4003B4A")]
	[FieldOffset(Offset = "0x60")]
	private bool completed;

	[Token(Token = "0x4003B4B")]
	[FieldOffset(Offset = "0x68")]
	public UnlockAchievement bossAchievement;

	[Token(Token = "0x60032DE")]
	[Address(RVA = "0x14657D8", Offset = "0x14657D8", VA = "0x14657D8")]
	private void Start()
	{
	}

	[Token(Token = "0x60032DF")]
	[Address(RVA = "0x146591C", Offset = "0x146591C", VA = "0x146591C")]
	private void Goal_Completed_OnUpdateData(OverworldGoal obj)
	{
	}

	[Token(Token = "0x60032E0")]
	[Address(RVA = "0x1465954", Offset = "0x1465954", VA = "0x1465954")]
	private void Goal_OnUpdateData(OverworldGoal flag)
	{
	}

	[Token(Token = "0x60032E1")]
	[Address(RVA = "0x1465B00", Offset = "0x1465B00", VA = "0x1465B00")]
	private IEnumerator EndRoutine()
	{
		return null;
	}

	[Token(Token = "0x60032E2")]
	[Address(RVA = "0x14658F4", Offset = "0x14658F4", VA = "0x14658F4")]
	private void SetCompletedState()
	{
	}

	[Token(Token = "0x60032E3")]
	[Address(RVA = "0x1465B74", Offset = "0x1465B74", VA = "0x1465B74")]
	public FinalRoom()
	{
	}
}
