using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000DB2")]
public class MoveRocksTurnBased : MonoBehaviour
{
	[Token(Token = "0x2000DB3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44C40", Offset = "0x44C40")]
	private sealed class _003CStartMoveCR_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004ABA")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004ABB")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004ABC")]
		[FieldOffset(Offset = "0x20")]
		public MoveRocksTurnBased _003C_003E4__this;

		[Token(Token = "0x1700069B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600407C")]
			[Address(RVA = "0x17F9E74", Offset = "0x17F9E74", VA = "0x17F9E74", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700069C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600407E")]
			[Address(RVA = "0x17F9EBC", Offset = "0x17F9EBC", VA = "0x17F9EBC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6004079")]
		[Address(RVA = "0x17F9D94", Offset = "0x17F9D94", VA = "0x17F9D94")]
		[DebuggerHidden]
		public _003CStartMoveCR_003Ed__20(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600407A")]
		[Address(RVA = "0x17F9DC0", Offset = "0x17F9DC0", VA = "0x17F9DC0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600407B")]
		[Address(RVA = "0x17F9DC4", Offset = "0x17F9DC4", VA = "0x17F9DC4", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600407C")]
		[Address(RVA = "0x17F9E74", Offset = "0x17F9E74", VA = "0x17F9E74", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600407D")]
		[Address(RVA = "0x17F9E7C", Offset = "0x17F9E7C", VA = "0x17F9E7C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600407E")]
		[Address(RVA = "0x17F9EBC", Offset = "0x17F9EBC", VA = "0x17F9EBC", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4004AA9")]
	[FieldOffset(Offset = "0x18")]
	public Action _onMove;

	[Token(Token = "0x4004AAA")]
	[FieldOffset(Offset = "0x20")]
	public Action _onStop;

	[Token(Token = "0x4004AAB")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Rigidbody _rbToMoveM;

	[Token(Token = "0x4004AAC")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private List<Transform> _position;

	[Token(Token = "0x4004AAD")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float _speed;

	[Token(Token = "0x4004AAE")]
	[FieldOffset(Offset = "0x3C")]
	private int index;

	[Token(Token = "0x4004AAF")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private PlayAudioClipSetting _onGetUp;

	[Token(Token = "0x4004AB0")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private PlayAudioClipSetting _onGetPutDown;

	[Token(Token = "0x4004AB1")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Animator _animator;

	[Token(Token = "0x4004AB2")]
	[FieldOffset(Offset = "0x58")]
	private bool _moving;

	[Token(Token = "0x4004AB3")]
	[FieldOffset(Offset = "0x59")]
	private bool _startMoving;

	[Token(Token = "0x4004AB4")]
	[FieldOffset(Offset = "0x60")]
	private double _time;

	[Token(Token = "0x4004AB5")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private bool _moveOnShoot;

	[Token(Token = "0x4004AB6")]
	[FieldOffset(Offset = "0x69")]
	[SerializeField]
	private bool _constantMove;

	[Token(Token = "0x4004AB7")]
	[FieldOffset(Offset = "0x70")]
	private GolfBallController _controller;

	[Token(Token = "0x4004AB8")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int GetUp;

	[Token(Token = "0x4004AB9")]
	[FieldOffset(Offset = "0x78")]
	private bool hasMoved;

	[Token(Token = "0x600406F")]
	[Address(RVA = "0x15739F0", Offset = "0x15739F0", VA = "0x15739F0")]
	private void MoveUpdate()
	{
	}

	[Token(Token = "0x6004070")]
	[Address(RVA = "0x1573C68", Offset = "0x1573C68", VA = "0x1573C68")]
	public void Move()
	{
	}

	[Token(Token = "0x6004071")]
	[Address(RVA = "0x1573C74", Offset = "0x1573C74", VA = "0x1573C74")]
	public void StartMove()
	{
	}

	[Token(Token = "0x6004072")]
	[Address(RVA = "0x1573DA4", Offset = "0x1573DA4", VA = "0x1573DA4")]
	private IEnumerator StartMoveCR()
	{
		return null;
	}

	[Token(Token = "0x6004073")]
	[Address(RVA = "0x1573E18", Offset = "0x1573E18", VA = "0x1573E18")]
	private void Start()
	{
	}

	[Token(Token = "0x6004074")]
	[Address(RVA = "0x1573FD4", Offset = "0x1573FD4", VA = "0x1573FD4")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6004075")]
	[Address(RVA = "0x157417C", Offset = "0x157417C", VA = "0x157417C")]
	private void ControllerOnOnShoot(Vector3 obj)
	{
	}

	[Token(Token = "0x6004076")]
	[Address(RVA = "0x1574254", Offset = "0x1574254", VA = "0x1574254")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6004077")]
	[Address(RVA = "0x1574268", Offset = "0x1574268", VA = "0x1574268")]
	public MoveRocksTurnBased()
	{
	}
}
