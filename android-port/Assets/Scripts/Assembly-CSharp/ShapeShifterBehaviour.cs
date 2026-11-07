using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000E2E")]
public class ShapeShifterBehaviour : MonoBehaviour
{
	[Token(Token = "0x2000E2F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44EC8", Offset = "0x44EC8")]
	private sealed class _003CCooldown_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004CF1")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004CF2")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004CF3")]
		[FieldOffset(Offset = "0x20")]
		public ShapeShifterBehaviour _003C_003E4__this;

		[Token(Token = "0x170006D5")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600428A")]
			[Address(RVA = "0x184870C", Offset = "0x184870C", VA = "0x184870C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170006D6")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600428C")]
			[Address(RVA = "0x1848754", Offset = "0x1848754", VA = "0x1848754", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6004287")]
		[Address(RVA = "0x184861C", Offset = "0x184861C", VA = "0x184861C")]
		[DebuggerHidden]
		public _003CCooldown_003Ed__16(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6004288")]
		[Address(RVA = "0x1848648", Offset = "0x1848648", VA = "0x1848648", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6004289")]
		[Address(RVA = "0x184864C", Offset = "0x184864C", VA = "0x184864C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600428A")]
		[Address(RVA = "0x184870C", Offset = "0x184870C", VA = "0x184870C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600428B")]
		[Address(RVA = "0x1848714", Offset = "0x1848714", VA = "0x1848714", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600428C")]
		[Address(RVA = "0x1848754", Offset = "0x1848754", VA = "0x1848754", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4004CE9")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float m_shapeShiftCooldown;

	[Token(Token = "0x4004CEA")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Transform m_shapeTransform;

	[Token(Token = "0x4004CEB")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private List<string> m_acceptedTag;

	[Token(Token = "0x4004CEC")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private bool m_rotateUpOnShapeshift;

	[Token(Token = "0x4004CED")]
	[FieldOffset(Offset = "0x38")]
	public UnityEvent OnTransform;

	[Token(Token = "0x4004CEE")]
	[FieldOffset(Offset = "0x40")]
	private GameObject m_lastCopiedGameObject;

	[Token(Token = "0x4004CEF")]
	[FieldOffset(Offset = "0x48")]
	private Coroutine m_cooldownRoutine;

	[Token(Token = "0x4004CF0")]
	[FieldOffset(Offset = "0x50")]
	private bool m_isOnCooldown;

	[Token(Token = "0x170006D4")]
	public GameObject LastCopiedItem
	{
		[Token(Token = "0x600427E")]
		[Address(RVA = "0x169D8A0", Offset = "0x169D8A0", VA = "0x169D8A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600427F")]
	[Address(RVA = "0x169D8A8", Offset = "0x169D8A8", VA = "0x169D8A8")]
	private bool IsShapeShiftAllowed(string collisionTag)
	{
		return default;
	}

	[Token(Token = "0x6004280")]
	[Address(RVA = "0x169D90C", Offset = "0x169D90C", VA = "0x169D90C")]
	private bool WasNotCopiedBefore(GameObject touchedObject)
	{
		return default;
	}

	[Token(Token = "0x6004281")]
	[Address(RVA = "0x169D994", Offset = "0x169D994", VA = "0x169D994")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6004282")]
	[Address(RVA = "0x169DCF0", Offset = "0x169DCF0", VA = "0x169DCF0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6004283")]
	[Address(RVA = "0x169DB58", Offset = "0x169DB58", VA = "0x169DB58")]
	public void ShapeShift(GameObject touchedObject)
	{
	}

	[Token(Token = "0x6004284")]
	[Address(RVA = "0x169DE10", Offset = "0x169DE10", VA = "0x169DE10")]
	private void CleanUpCopiedObject()
	{
	}

	[Token(Token = "0x6004285")]
	[Address(RVA = "0x169DC7C", Offset = "0x169DC7C", VA = "0x169DC7C")]
	private IEnumerator Cooldown()
	{
		return null;
	}

	[Token(Token = "0x6004286")]
	[Address(RVA = "0x169DF54", Offset = "0x169DF54", VA = "0x169DF54")]
	public ShapeShifterBehaviour()
	{
	}
}
