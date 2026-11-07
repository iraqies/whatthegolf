using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Audio;
using CameraStack;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20009FB")]
public class OverworldDoor : MonoBehaviour
{
	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x20009FC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x428A8", Offset = "0x428A8")]
	private struct _003COpenDoor_003Ed__20 : IAsyncStateMachine
	{
		[Token(Token = "0x4003709")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x400370A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x400370B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public OverworldDoor _003C_003E4__this;

		[Token(Token = "0x400370C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action onOpen;

		[Token(Token = "0x400370D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool instant;

		[Token(Token = "0x400370E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x6002F4E")]
		[Address(RVA = "0x180FAD0", Offset = "0x180FAD0", VA = "0x180FAD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6002F4F")]
		[Address(RVA = "0x180FCA0", Offset = "0x180FCA0", VA = "0x180FCA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x20009FD")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x428B8", Offset = "0x428B8")]
	private struct _003COpenDoorAsync_003Ed__21 : IAsyncStateMachine
	{
		[Token(Token = "0x400370F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4003710")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x4003711")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public OverworldDoor _003C_003E4__this;

		[Token(Token = "0x4003712")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float duration;

		[Token(Token = "0x4003713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action onOpen;

		[Token(Token = "0x4003714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool _003ChasDuration_003E5__2;

		[Token(Token = "0x4003715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x6002F50")]
		[Address(RVA = "0x180FCAC", Offset = "0x180FCAC", VA = "0x180FCAC", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6002F51")]
		[Address(RVA = "0x18103A8", Offset = "0x18103A8", VA = "0x18103A8", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x20009FE")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x428C8", Offset = "0x428C8")]
	private struct _003CMoveDoorsOpen_003Ed__22 : IAsyncStateMachine
	{
		[Token(Token = "0x4003716")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4003717")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x4003718")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float duration;

		[Token(Token = "0x4003719")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public OverworldDoor _003C_003E4__this;

		[Token(Token = "0x400371A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float _003CstartTime_003E5__2;

		[Token(Token = "0x400371B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float _003CcurrentTime_003E5__3;

		[Token(Token = "0x400371C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float _003CfinishedTime_003E5__4;

		[Token(Token = "0x400371D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x6002F52")]
		[Address(RVA = "0x180F650", Offset = "0x180F650", VA = "0x180F650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6002F53")]
		[Address(RVA = "0x180FAC4", Offset = "0x180FAC4", VA = "0x180FAC4", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x20009FF")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x428D8", Offset = "0x428D8")]
	private sealed class _003CCloseDoorRoutine_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400371E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400371F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4003720")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float duration;

		[Token(Token = "0x4003721")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public OverworldDoor _003C_003E4__this;

		[Token(Token = "0x4003722")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action onClose;

		[Token(Token = "0x170004DB")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002F57")]
			[Address(RVA = "0x180F600", Offset = "0x180F600", VA = "0x180F600", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170004DC")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002F59")]
			[Address(RVA = "0x180F648", Offset = "0x180F648", VA = "0x180F648", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002F54")]
		[Address(RVA = "0x180F338", Offset = "0x180F338", VA = "0x180F338")]
		[DebuggerHidden]
		public _003CCloseDoorRoutine_003Ed__24(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002F55")]
		[Address(RVA = "0x180F364", Offset = "0x180F364", VA = "0x180F364", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002F56")]
		[Address(RVA = "0x180F368", Offset = "0x180F368", VA = "0x180F368", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6002F57")]
		[Address(RVA = "0x180F600", Offset = "0x180F600", VA = "0x180F600", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002F58")]
		[Address(RVA = "0x180F608", Offset = "0x180F608", VA = "0x180F608", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6002F59")]
		[Address(RVA = "0x180F648", Offset = "0x180F648", VA = "0x180F648", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40036F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform LeftDoor;

	[Token(Token = "0x40036F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform RightDoor;

	[Token(Token = "0x40036F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject Button;

	[Token(Token = "0x40036FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public AnimationCurve animationCurve;

	[Token(Token = "0x40036FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float RoutineLength;

	[Token(Token = "0x40036FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float DoorExtend;

	[Token(Token = "0x40036FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject DoorSides;

	[Token(Token = "0x40036FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public List<Collider2D> Colliders;

	[Token(Token = "0x40036FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool DebugThisDoor;

	[Token(Token = "0x4003700")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Vector3[] corners;

	[Token(Token = "0x4003701")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public float BallDistanceThreshold;

	[Token(Token = "0x4003702")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public float Speed;

	[Token(Token = "0x4003703")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public float Magnitude;

	[Token(Token = "0x4003704")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public bool canPlaySound;

	[Token(Token = "0x4003705")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public PlayClipOnAudioEvent SFX;

	[Token(Token = "0x4003706")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private OverworldCamera cam;

	[Token(Token = "0x4003707")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Vector3 leftStart;

	[Token(Token = "0x4003708")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private Vector3 rightStart;

	[Token(Token = "0x6002F43")]
	[Address(RVA = "0x15B16B8", Offset = "0x15B16B8", VA = "0x15B16B8")]
	public void SetCamera(OverworldCamera overworldCamera)
	{
	}

	[Token(Token = "0x6002F44")]
	[Address(RVA = "0x15A9F4C", Offset = "0x15A9F4C", VA = "0x15A9F4C")]
	public void Init()
	{
	}

	[Token(Token = "0x6002F45")]
	[Address(RVA = "0x15A9E9C", Offset = "0x15A9E9C", VA = "0x15A9E9C")]
	public void OpenDoor(Action onOpen, bool instant = false)
	{
	}

	[Token(Token = "0x6002F46")]
	[Address(RVA = "0x15B16C0", Offset = "0x15B16C0", VA = "0x15B16C0")]
	public Task OpenDoorAsync(Action onOpen, float duration, bool playEndSounds = true)
	{
		return null;
	}

	[Token(Token = "0x6002F47")]
	[Address(RVA = "0x15B17B8", Offset = "0x15B17B8", VA = "0x15B17B8")]
	private Task MoveDoorsOpen(float duration)
	{
		return null;
	}

	[Token(Token = "0x6002F48")]
	[Address(RVA = "0x15ABE74", Offset = "0x15ABE74", VA = "0x15ABE74")]
	public void RemoveButton()
	{
	}

	[Token(Token = "0x6002F49")]
	[Address(RVA = "0x15B18A8", Offset = "0x15B18A8", VA = "0x15B18A8")]
	public IEnumerator CloseDoorRoutine(Action onClose, float duration, bool playEndSounds = true)
	{
		return null;
	}

	[Token(Token = "0x6002F4A")]
	[Address(RVA = "0x15A9C08", Offset = "0x15A9C08", VA = "0x15A9C08")]
	public Vector3 GetCornerInThatDirection(Vector3 worldDir)
	{
		return default;
	}

	[Token(Token = "0x6002F4B")]
	[Address(RVA = "0x15B1930", Offset = "0x15B1930", VA = "0x15B1930")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6002F4C")]
	[Address(RVA = "0x15B19F8", Offset = "0x15B19F8", VA = "0x15B19F8")]
	public OverworldDoor()
	{
	}

	[Token(Token = "0x6002F4D")]
	[Address(RVA = "0x15B1A30", Offset = "0x15B1A30", VA = "0x15B1A30")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68DC8", Offset = "0x68DC8")]
	private void _003CCloseDoorRoutine_003Eb__24_0(float t)
	{
	}
}
