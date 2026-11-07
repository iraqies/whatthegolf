using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E3E")]
public class SpecialDayOverworldDoor : MonoBehaviour
{
	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000E3F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44F18", Offset = "0x44F18")]
	private struct _003COpenDoor_003Ed__17 : IAsyncStateMachine
	{
		[Token(Token = "0x4004D4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4004D4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x4004D50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SpecialDayOverworldDoor _003C_003E4__this;

		[Token(Token = "0x4004D51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action onOpen;

		[Token(Token = "0x4004D52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool instant;

		[Token(Token = "0x4004D53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x60042CC")]
		[Address(RVA = "0x1855A44", Offset = "0x1855A44", VA = "0x1855A44", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x60042CD")]
		[Address(RVA = "0x1855C10", Offset = "0x1855C10", VA = "0x1855C10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000E40")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44F28", Offset = "0x44F28")]
	private struct _003CCloseDoor_003Ed__18 : IAsyncStateMachine
	{
		[Token(Token = "0x4004D54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4004D55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x4004D56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SpecialDayOverworldDoor _003C_003E4__this;

		[Token(Token = "0x4004D57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action onClose;

		[Token(Token = "0x4004D58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool instant;

		[Token(Token = "0x4004D59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x60042CE")]
		[Address(RVA = "0x1854E10", Offset = "0x1854E10", VA = "0x1854E10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x60042CF")]
		[Address(RVA = "0x1854FE0", Offset = "0x1854FE0", VA = "0x1854FE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000E41")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44F38", Offset = "0x44F38")]
	private struct _003COpenDoorAsync_003Ed__19 : IAsyncStateMachine
	{
		[Token(Token = "0x4004D5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4004D5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x4004D5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SpecialDayOverworldDoor _003C_003E4__this;

		[Token(Token = "0x4004D5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float duration;

		[Token(Token = "0x4004D5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action onOpen;

		[Token(Token = "0x4004D5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool _003ChasDuration_003E5__2;

		[Token(Token = "0x4004D60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x60042D0")]
		[Address(RVA = "0x1855C1C", Offset = "0x1855C1C", VA = "0x1855C1C", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x60042D1")]
		[Address(RVA = "0x185629C", Offset = "0x185629C", VA = "0x185629C", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000E42")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44F48", Offset = "0x44F48")]
	private struct _003CMoveDoorsAsync_003Ed__20 : IAsyncStateMachine
	{
		[Token(Token = "0x4004D61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4004D62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x4004D63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float duration;

		[Token(Token = "0x4004D64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SpecialDayOverworldDoor _003C_003E4__this;

		[Token(Token = "0x4004D65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool shouldOpen;

		[Token(Token = "0x4004D66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float _003CstartTime_003E5__2;

		[Token(Token = "0x4004D67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float _003CcurrentTime_003E5__3;

		[Token(Token = "0x4004D68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float _003CfinishedTime_003E5__4;

		[Token(Token = "0x4004D69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private (Vector3, Vector3) _003CleftPositions_003E5__5;

		[Token(Token = "0x4004D6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private (Vector3, Vector3) _003CrightPositions_003E5__6;

		[Token(Token = "0x4004D6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x60042D2")]
		[Address(RVA = "0x18553F8", Offset = "0x18553F8", VA = "0x18553F8", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x60042D3")]
		[Address(RVA = "0x1855A38", Offset = "0x1855A38", VA = "0x1855A38", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000E43")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44F58", Offset = "0x44F58")]
	private struct _003CCloseDoorAsync_003Ed__21 : IAsyncStateMachine
	{
		[Token(Token = "0x4004D6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4004D6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x4004D6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float duration;

		[Token(Token = "0x4004D6F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SpecialDayOverworldDoor _003C_003E4__this;

		[Token(Token = "0x4004D70")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action onClose;

		[Token(Token = "0x4004D71")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x60042D4")]
		[Address(RVA = "0x1854FEC", Offset = "0x1854FEC", VA = "0x1854FEC", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x60042D5")]
		[Address(RVA = "0x18553EC", Offset = "0x18553EC", VA = "0x18553EC", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x4004D3D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform LeftDoor;

	[Token(Token = "0x4004D3E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform RightDoor;

	[Token(Token = "0x4004D3F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject Button;

	[Token(Token = "0x4004D40")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public AnimationCurve animationCurve;

	[Token(Token = "0x4004D41")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float RoutineLength;

	[Token(Token = "0x4004D42")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float DoorExtend;

	[Token(Token = "0x4004D43")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject DoorSides;

	[Token(Token = "0x4004D44")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public List<Collider2D> Colliders;

	[Token(Token = "0x4004D45")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool DebugThisDoor;

	[Token(Token = "0x4004D46")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Vector3[] corners;

	[Token(Token = "0x4004D47")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public float BallDistanceThreshold;

	[Token(Token = "0x4004D48")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public float Speed;

	[Token(Token = "0x4004D49")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public float Magnitude;

	[Token(Token = "0x4004D4A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public bool canPlaySound;

	[Token(Token = "0x4004D4B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public PlayClipOnAudioEvent SFX;

	[Token(Token = "0x4004D4C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Vector3 leftStart;

	[Token(Token = "0x4004D4D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private Vector3 rightStart;

	[Token(Token = "0x60042C6")]
	[Address(RVA = "0x16CAF80", Offset = "0x16CAF80", VA = "0x16CAF80")]
	public void OpenDoor(Action onOpen, bool instant = false)
	{
	}

	[Token(Token = "0x60042C7")]
	[Address(RVA = "0x16CB1F0", Offset = "0x16CB1F0", VA = "0x16CB1F0")]
	public void CloseDoor(Action onClose, bool instant = false)
	{
	}

	[Token(Token = "0x60042C8")]
	[Address(RVA = "0x16CB3A4", Offset = "0x16CB3A4", VA = "0x16CB3A4")]
	private Task OpenDoorAsync(Action onOpen, float duration)
	{
		return null;
	}

	[Token(Token = "0x60042C9")]
	[Address(RVA = "0x16CB49C", Offset = "0x16CB49C", VA = "0x16CB49C")]
	private Task MoveDoorsAsync(bool shouldOpen, float duration)
	{
		return null;
	}

	[Token(Token = "0x60042CA")]
	[Address(RVA = "0x16CB59C", Offset = "0x16CB59C", VA = "0x16CB59C")]
	private Task CloseDoorAsync(Action onClose, float duration, bool playEndSounds = true)
	{
		return null;
	}

	[Token(Token = "0x60042CB")]
	[Address(RVA = "0x16CB68C", Offset = "0x16CB68C", VA = "0x16CB68C")]
	public SpecialDayOverworldDoor()
	{
	}
}
