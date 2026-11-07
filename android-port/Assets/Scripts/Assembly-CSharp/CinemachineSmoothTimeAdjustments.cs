using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Chronos;
using Cinemachine;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000334")]
[ExecuteInEditMode]
public class CinemachineSmoothTimeAdjustments : CinemachineExtension
{
	[Token(Token = "0x2000335")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F060", Offset = "0x3F060")]
	private sealed class _003CWaitForActiveBall_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40011CA")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40011CB")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40011CC")]
		[FieldOffset(Offset = "0x20")]
		public CinemachineSmoothTimeAdjustments _003C_003E4__this;

		[Token(Token = "0x170001C0")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000ECE")]
			[Address(RVA = "0x178705C", Offset = "0x178705C", VA = "0x178705C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170001C1")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000ED0")]
			[Address(RVA = "0x17870A4", Offset = "0x17870A4", VA = "0x17870A4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000ECB")]
		[Address(RVA = "0x1786EF0", Offset = "0x1786EF0", VA = "0x1786EF0")]
		[DebuggerHidden]
		public _003CWaitForActiveBall_003Ed__15(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000ECC")]
		[Address(RVA = "0x1786F1C", Offset = "0x1786F1C", VA = "0x1786F1C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000ECD")]
		[Address(RVA = "0x1786F20", Offset = "0x1786F20", VA = "0x1786F20", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000ECE")]
		[Address(RVA = "0x178705C", Offset = "0x178705C", VA = "0x178705C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000ECF")]
		[Address(RVA = "0x1787064", Offset = "0x1787064", VA = "0x1787064", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000ED0")]
		[Address(RVA = "0x17870A4", Offset = "0x17870A4", VA = "0x17870A4", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40011BE")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	protected float startSmoothTime;

	[Token(Token = "0x40011BF")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	protected float continuousSmoothTime;

	[Token(Token = "0x40011C0")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	protected float aimSmoothTime;

	[Token(Token = "0x40011C1")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	protected bool ignoreX;

	[Token(Token = "0x40011C2")]
	[FieldOffset(Offset = "0x35")]
	[SerializeField]
	protected bool ignoreY;

	[Token(Token = "0x40011C3")]
	[FieldOffset(Offset = "0x36")]
	[SerializeField]
	protected bool ignoreZ;

	[Token(Token = "0x40011C4")]
	[FieldOffset(Offset = "0x37")]
	[SerializeField]
	protected bool ignoreYaw;

	[Token(Token = "0x40011C5")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	protected float continousTrackingTimer;

	[Token(Token = "0x40011C6")]
	[FieldOffset(Offset = "0x3C")]
	protected float smoothTime;

	[Token(Token = "0x40011C7")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	protected float dampEaseing;

	[Token(Token = "0x40011C8")]
	[FieldOffset(Offset = "0x44")]
	protected float continousTrackingTimerCountDown;

	[Token(Token = "0x40011C9")]
	[FieldOffset(Offset = "0x48")]
	public LocalClock Clock;

	[Token(Token = "0x170001BF")]
	protected GolfBallController Ball
	{
		[Token(Token = "0x6000EC5")]
		[Address(RVA = "0x189E364", Offset = "0x189E364", VA = "0x189E364")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000EC4")]
	[Address(RVA = "0x189E274", Offset = "0x189E274", VA = "0x189E274")]
	private void Start()
	{
	}

	[Token(Token = "0x6000EC6")]
	[Address(RVA = "0x189E2F0", Offset = "0x189E2F0", VA = "0x189E2F0")]
	private IEnumerator WaitForActiveBall()
	{
		return null;
	}

	[Token(Token = "0x6000EC7")]
	[Address(RVA = "0x189E404", Offset = "0x189E404", VA = "0x189E404", Slot = "7")]
	protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
	{
	}

	[Token(Token = "0x6000EC8")]
	[Address(RVA = "0x189E99C", Offset = "0x189E99C", VA = "0x189E99C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000EC9")]
	[Address(RVA = "0x189E9A0", Offset = "0x189E9A0", VA = "0x189E9A0")]
	public CinemachineSmoothTimeAdjustments()
	{
	}

	[Token(Token = "0x6000ECA")]
	[Address(RVA = "0x189E9DC", Offset = "0x189E9DC", VA = "0x189E9DC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60F2C", Offset = "0x60F2C")]
	private void _003CWaitForActiveBall_003Eb__15_0(Vector3 boost)
	{
	}
}
