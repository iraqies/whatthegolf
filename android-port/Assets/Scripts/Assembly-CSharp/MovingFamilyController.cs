using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Cinemachine;
using Core;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000E8C")]
public class MovingFamilyController : MonoBehaviour
{
	[Token(Token = "0x2000E8D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x450E8", Offset = "0x450E8")]
	private sealed class _003CMoveFamilyMember_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004EA5")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004EA6")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004EA7")]
		[FieldOffset(Offset = "0x20")]
		public GolfBallController controller;

		[Token(Token = "0x4004EA8")]
		[FieldOffset(Offset = "0x28")]
		public MovingFamilyController _003C_003E4__this;

		[Token(Token = "0x4004EA9")]
		[FieldOffset(Offset = "0x30")]
		public float duration;

		[Token(Token = "0x4004EAA")]
		[FieldOffset(Offset = "0x34")]
		private float _003CmovementTime_003E5__2;

		[Token(Token = "0x170006F6")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60043F9")]
			[Address(RVA = "0x17FBA58", Offset = "0x17FBA58", VA = "0x17FBA58", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170006F7")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60043FB")]
			[Address(RVA = "0x17FBAA0", Offset = "0x17FBAA0", VA = "0x17FBAA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60043F6")]
		[Address(RVA = "0x17FB5BC", Offset = "0x17FB5BC", VA = "0x17FB5BC")]
		[DebuggerHidden]
		public _003CMoveFamilyMember_003Ed__14(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60043F7")]
		[Address(RVA = "0x17FB5E8", Offset = "0x17FB5E8", VA = "0x17FB5E8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60043F8")]
		[Address(RVA = "0x17FB5EC", Offset = "0x17FB5EC", VA = "0x17FB5EC", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60043F9")]
		[Address(RVA = "0x17FBA58", Offset = "0x17FBA58", VA = "0x17FBA58", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60043FA")]
		[Address(RVA = "0x17FBA60", Offset = "0x17FBA60", VA = "0x17FBA60", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60043FB")]
		[Address(RVA = "0x17FBAA0", Offset = "0x17FBAA0", VA = "0x17FBAA0", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4004E99")]
	[FieldOffset(Offset = "0x18")]
	public float moveDuration;

	[Token(Token = "0x4004E9A")]
	[FieldOffset(Offset = "0x20")]
	public List<GolfBallController> familyMemberControllers;

	[Token(Token = "0x4004E9B")]
	[FieldOffset(Offset = "0x28")]
	public List<GameObject> familyMemberParent;

	[Token(Token = "0x4004E9C")]
	[FieldOffset(Offset = "0x30")]
	public List<CinemachineVirtualCamera> cinemachineCameras;

	[Token(Token = "0x4004E9D")]
	[FieldOffset(Offset = "0x38")]
	public List<Transform> familyMemberPositions;

	[Token(Token = "0x4004E9E")]
	[FieldOffset(Offset = "0x40")]
	private int familyIndex;

	[Token(Token = "0x4004E9F")]
	[FieldOffset(Offset = "0x44")]
	private int cameraIndex;

	[Token(Token = "0x4004EA0")]
	[FieldOffset(Offset = "0x48")]
	private int positionIndex;

	[Token(Token = "0x4004EA1")]
	[FieldOffset(Offset = "0x50")]
	private GolfBallController lastController;

	[Token(Token = "0x4004EA2")]
	[FieldOffset(Offset = "0x58")]
	private GolfBallController currentController;

	[Token(Token = "0x4004EA3")]
	[FieldOffset(Offset = "0x60")]
	public UnityEvent onStart;

	[Token(Token = "0x4004EA4")]
	[FieldOffset(Offset = "0x68")]
	public UnityEvent onComplete;

	[Token(Token = "0x60043F2")]
	[Address(RVA = "0x1576F74", Offset = "0x1576F74", VA = "0x1576F74")]
	private void Start()
	{
	}

	[Token(Token = "0x60043F3")]
	[Address(RVA = "0x1576F90", Offset = "0x1576F90", VA = "0x1576F90")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60043F4")]
	[Address(RVA = "0x1577434", Offset = "0x1577434", VA = "0x1577434")]
	private IEnumerator MoveFamilyMember(GolfBallController controller, float duration)
	{
		return null;
	}

	[Token(Token = "0x60043F5")]
	[Address(RVA = "0x15774BC", Offset = "0x15774BC", VA = "0x15774BC")]
	public MovingFamilyController()
	{
	}
}
