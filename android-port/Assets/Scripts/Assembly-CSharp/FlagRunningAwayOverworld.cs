using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Cinemachine;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D79")]
public class FlagRunningAwayOverworld : MonoBehaviour
{
	[Token(Token = "0x2000D7A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x449F0", Offset = "0x449F0")]
	private sealed class _003CMoveToNextPoint_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400494E")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400494F")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004950")]
		[FieldOffset(Offset = "0x20")]
		public FlagRunningAwayOverworld _003C_003E4__this;

		[Token(Token = "0x4004951")]
		[FieldOffset(Offset = "0x28")]
		private float _003CnextPoint_003E5__2;

		[Token(Token = "0x17000675")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003F63")]
			[Address(RVA = "0x17A8B90", Offset = "0x17A8B90", VA = "0x17A8B90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000676")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003F65")]
			[Address(RVA = "0x17A8BD8", Offset = "0x17A8BD8", VA = "0x17A8BD8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003F60")]
		[Address(RVA = "0x17A897C", Offset = "0x17A897C", VA = "0x17A897C")]
		[DebuggerHidden]
		public _003CMoveToNextPoint_003Ed__11(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003F61")]
		[Address(RVA = "0x17A89A8", Offset = "0x17A89A8", VA = "0x17A89A8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003F62")]
		[Address(RVA = "0x17A89AC", Offset = "0x17A89AC", VA = "0x17A89AC", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003F63")]
		[Address(RVA = "0x17A8B90", Offset = "0x17A8B90", VA = "0x17A8B90", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003F64")]
		[Address(RVA = "0x17A8B98", Offset = "0x17A8B98", VA = "0x17A8B98", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003F65")]
		[Address(RVA = "0x17A8BD8", Offset = "0x17A8BD8", VA = "0x17A8BD8", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4004946")]
	[FieldOffset(Offset = "0x18")]
	public CinemachinePathBase m_Path;

	[Token(Token = "0x4004947")]
	[FieldOffset(Offset = "0x20")]
	public Animator m_Animator;

	[Token(Token = "0x4004948")]
	[FieldOffset(Offset = "0x28")]
	public float m_Speed;

	[Token(Token = "0x4004949")]
	[FieldOffset(Offset = "0x2C")]
	private float m_Position;

	[Token(Token = "0x400494A")]
	[FieldOffset(Offset = "0x30")]
	private CinemachinePathBase.PositionUnits m_PositionUnits;

	[Token(Token = "0x400494B")]
	[FieldOffset(Offset = "0x34")]
	private int m_pathPointIndex;

	[Token(Token = "0x400494C")]
	[FieldOffset(Offset = "0x38")]
	private float m_currentPathIndex;

	[Token(Token = "0x400494D")]
	[FieldOffset(Offset = "0x40")]
	private Coroutine m_currentMovement;

	[Token(Token = "0x6003F5B")]
	[Address(RVA = "0x146B6A8", Offset = "0x146B6A8", VA = "0x146B6A8")]
	private void Update()
	{
	}

	[Token(Token = "0x6003F5C")]
	[Address(RVA = "0x146B6AC", Offset = "0x146B6AC", VA = "0x146B6AC")]
	private void SetCartPosition(float distanceAlongPath)
	{
	}

	[Token(Token = "0x6003F5D")]
	[Address(RVA = "0x146B7E0", Offset = "0x146B7E0", VA = "0x146B7E0")]
	private void OnTriggerStay2D(Collider2D collision)
	{
	}

	[Token(Token = "0x6003F5E")]
	[Address(RVA = "0x146B8EC", Offset = "0x146B8EC", VA = "0x146B8EC")]
	private IEnumerator MoveToNextPoint()
	{
		return null;
	}

	[Token(Token = "0x6003F5F")]
	[Address(RVA = "0x146B960", Offset = "0x146B960", VA = "0x146B960")]
	public FlagRunningAwayOverworld()
	{
	}
}
