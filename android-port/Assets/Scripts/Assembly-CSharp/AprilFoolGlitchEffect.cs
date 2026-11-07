using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E6A")]
public class AprilFoolGlitchEffect : MonoBehaviour
{
	[Token(Token = "0x2000E6B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x45058", Offset = "0x45058")]
	private sealed class _003CGlitchRoutine_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004E08")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004E09")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004E0A")]
		[FieldOffset(Offset = "0x20")]
		public AprilFoolGlitchEffect _003C_003E4__this;

		[Token(Token = "0x4004E0B")]
		[FieldOffset(Offset = "0x28")]
		private int _003CglitchCount_003E5__2;

		[Token(Token = "0x4004E0C")]
		[FieldOffset(Offset = "0x2C")]
		private int _003Cglitches_003E5__3;

		[Token(Token = "0x4004E0D")]
		[FieldOffset(Offset = "0x30")]
		private Rigidbody _003Crb_003E5__4;

		[Token(Token = "0x4004E0E")]
		[FieldOffset(Offset = "0x38")]
		private GameObject _003CglitchMesh_003E5__5;

		[Token(Token = "0x170006EA")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600436B")]
			[Address(RVA = "0x176CDAC", Offset = "0x176CDAC", VA = "0x176CDAC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170006EB")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600436D")]
			[Address(RVA = "0x176CDF4", Offset = "0x176CDF4", VA = "0x176CDF4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6004368")]
		[Address(RVA = "0x176C96C", Offset = "0x176C96C", VA = "0x176C96C")]
		[DebuggerHidden]
		public _003CGlitchRoutine_003Ed__10(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6004369")]
		[Address(RVA = "0x176C998", Offset = "0x176C998", VA = "0x176C998", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600436A")]
		[Address(RVA = "0x176C99C", Offset = "0x176C99C", VA = "0x176C99C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600436B")]
		[Address(RVA = "0x176CDAC", Offset = "0x176CDAC", VA = "0x176CDAC", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600436C")]
		[Address(RVA = "0x176CDB4", Offset = "0x176CDB4", VA = "0x176CDB4", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600436D")]
		[Address(RVA = "0x176CDF4", Offset = "0x176CDF4", VA = "0x176CDF4", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4004E01")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform m_originalVisualsTransform;

	[Token(Token = "0x4004E02")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject[] m_listOfBreadToActivate;

	[Token(Token = "0x4004E03")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject m_breadGlitchGO;

	[Token(Token = "0x4004E04")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float m_breadGlitchScaleMultiplier;

	[Token(Token = "0x4004E05")]
	[FieldOffset(Offset = "0x38")]
	private MeshRenderer originalRenderer;

	[Token(Token = "0x4004E06")]
	[FieldOffset(Offset = "0x40")]
	private Vector3 originalPosition;

	[Token(Token = "0x4004E07")]
	[FieldOffset(Offset = "0x4C")]
	private Quaternion originalRotation;

	[Token(Token = "0x6004363")]
	[Address(RVA = "0x141CE00", Offset = "0x141CE00", VA = "0x141CE00")]
	private void Start()
	{
	}

	[Token(Token = "0x6004364")]
	[Address(RVA = "0x141CFF8", Offset = "0x141CFF8", VA = "0x141CFF8")]
	private void ActivateGlitch()
	{
	}

	[Token(Token = "0x6004365")]
	[Address(RVA = "0x141CF7C", Offset = "0x141CF7C", VA = "0x141CF7C")]
	private void EnableBread(bool enable)
	{
	}

	[Token(Token = "0x6004366")]
	[Address(RVA = "0x141D074", Offset = "0x141D074", VA = "0x141D074")]
	private IEnumerator GlitchRoutine()
	{
		return null;
	}

	[Token(Token = "0x6004367")]
	[Address(RVA = "0x141D0E8", Offset = "0x141D0E8", VA = "0x141D0E8")]
	public AprilFoolGlitchEffect()
	{
	}
}
