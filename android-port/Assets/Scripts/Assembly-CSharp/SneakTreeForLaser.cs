using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000DDE")]
public class SneakTreeForLaser : MonoBehaviour
{
	[Token(Token = "0x2000DDF")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44DB8", Offset = "0x44DB8")]
	private sealed class _003CMoveCR_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004B91")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004B92")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004B93")]
		[FieldOffset(Offset = "0x20")]
		public SneakTreeForLaser _003C_003E4__this;

		[Token(Token = "0x4004B94")]
		[FieldOffset(Offset = "0x28")]
		private double _003Ct_003E5__2;

		[Token(Token = "0x4004B95")]
		[FieldOffset(Offset = "0x30")]
		private Vector3 _003Cstart_003E5__3;

		[Token(Token = "0x4004B96")]
		[FieldOffset(Offset = "0x3C")]
		private Vector3 _003Cend_003E5__4;

		[Token(Token = "0x170006BC")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6004161")]
			[Address(RVA = "0x1852698", Offset = "0x1852698", VA = "0x1852698", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170006BD")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6004163")]
			[Address(RVA = "0x18526E0", Offset = "0x18526E0", VA = "0x18526E0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600415E")]
		[Address(RVA = "0x18523B8", Offset = "0x18523B8", VA = "0x18523B8")]
		[DebuggerHidden]
		public _003CMoveCR_003Ed__16(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600415F")]
		[Address(RVA = "0x18523E4", Offset = "0x18523E4", VA = "0x18523E4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6004160")]
		[Address(RVA = "0x18523E8", Offset = "0x18523E8", VA = "0x18523E8", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6004161")]
		[Address(RVA = "0x1852698", Offset = "0x1852698", VA = "0x1852698", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6004162")]
		[Address(RVA = "0x18526A0", Offset = "0x18526A0", VA = "0x18526A0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6004163")]
		[Address(RVA = "0x18526E0", Offset = "0x18526E0", VA = "0x18526E0", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4004B86")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Animation _animation;

	[Token(Token = "0x4004B87")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AnimationClip _walk;

	[Token(Token = "0x4004B88")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private AnimationClip _still;

	[Token(Token = "0x4004B89")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject _arms;

	[Token(Token = "0x4004B8A")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float _speed;

	[Token(Token = "0x4004B8B")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private List<Transform> _positions;

	[Token(Token = "0x4004B8C")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private UnityEvent _OnLasered;

	[Token(Token = "0x4004B8D")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private AudioSource _audio;

	[Token(Token = "0x4004B8E")]
	[FieldOffset(Offset = "0x58")]
	private int index;

	[Token(Token = "0x4004B8F")]
	[FieldOffset(Offset = "0x5C")]
	private bool _moving;

	[Token(Token = "0x4004B90")]
	[FieldOffset(Offset = "0x5D")]
	private bool _canMove;

	[Token(Token = "0x6004157")]
	[Address(RVA = "0x16BA834", Offset = "0x16BA834", VA = "0x16BA834")]
	private void Start()
	{
	}

	[Token(Token = "0x6004158")]
	[Address(RVA = "0x16BA994", Offset = "0x16BA994", VA = "0x16BA994")]
	private void OnLasered()
	{
	}

	[Token(Token = "0x6004159")]
	[Address(RVA = "0x16BAA3C", Offset = "0x16BAA3C", VA = "0x16BAA3C")]
	public void Move()
	{
	}

	[Token(Token = "0x600415A")]
	[Address(RVA = "0x16BAB54", Offset = "0x16BAB54", VA = "0x16BAB54")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600415B")]
	[Address(RVA = "0x16BAC9C", Offset = "0x16BAC9C", VA = "0x16BAC9C")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x600415C")]
	[Address(RVA = "0x16BAAE0", Offset = "0x16BAAE0", VA = "0x16BAAE0")]
	private IEnumerator MoveCR()
	{
		return null;
	}

	[Token(Token = "0x600415D")]
	[Address(RVA = "0x16BADFC", Offset = "0x16BADFC", VA = "0x16BADFC")]
	public SneakTreeForLaser()
	{
	}
}
