using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001B1")]
public class MainMenuInputIconGroup : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20001B2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DFC0", Offset = "0x3DFC0")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x40007A9")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x40007AA")]
		[FieldOffset(Offset = "0x8")]
		public static Func<SVGImage, Transform> _003C_003E9__10_0;

		[Token(Token = "0x40007AB")]
		[FieldOffset(Offset = "0x10")]
		public static Func<Transform, Vector3> _003C_003E9__10_1;

		[Token(Token = "0x600078A")]
		[Address(RVA = "0x17F2274", Offset = "0x17F2274", VA = "0x17F2274")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0x17F227C", Offset = "0x17F227C", VA = "0x17F227C")]
		internal Transform _003CAwake_003Eb__10_0(SVGImage i)
		{
			return null;
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0x17F22D0", Offset = "0x17F22D0", VA = "0x17F22D0")]
		internal Vector3 _003CAwake_003Eb__10_1(Transform t)
		{
			return default;
		}
	}

	[Token(Token = "0x20001B3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DFD0", Offset = "0x3DFD0")]
	private sealed class _003CFadeInOutCR_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40007AC")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40007AD")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40007AE")]
		[FieldOffset(Offset = "0x20")]
		public MainMenuInputIconGroup _003C_003E4__this;

		[Token(Token = "0x40007AF")]
		[FieldOffset(Offset = "0x28")]
		private float _003Cduration_003E5__2;

		[Token(Token = "0x40007B0")]
		[FieldOffset(Offset = "0x2C")]
		private float _003Ctime_003E5__3;

		[Token(Token = "0x17000103")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000790")]
			[Address(RVA = "0x17F2498", Offset = "0x17F2498", VA = "0x17F2498", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000104")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000792")]
			[Address(RVA = "0x17F24E0", Offset = "0x17F24E0", VA = "0x17F24E0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0x17F22EC", Offset = "0x17F22EC", VA = "0x17F22EC")]
		[DebuggerHidden]
		public _003CFadeInOutCR_003Ed__12(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0x17F2318", Offset = "0x17F2318", VA = "0x17F2318", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0x17F231C", Offset = "0x17F231C", VA = "0x17F231C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0x17F2498", Offset = "0x17F2498", VA = "0x17F2498", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0x17F24A0", Offset = "0x17F24A0", VA = "0x17F24A0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0x17F24E0", Offset = "0x17F24E0", VA = "0x17F24E0", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x400079F")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private MainMenuInputIcon[] inputIcons;

	[Token(Token = "0x40007A0")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AnimationCurve visibility;

	[Token(Token = "0x40007A1")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private bool fadeIcons;

	[Token(Token = "0x40007A2")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private Vector3 fadeOutDirection;

	[Token(Token = "0x40007A3")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Vector3 fadeOutScale;

	[Token(Token = "0x40007A4")]
	[FieldOffset(Offset = "0x48")]
	private SVGImage[] images;

	[Token(Token = "0x40007A5")]
	[FieldOffset(Offset = "0x50")]
	private Transform selfTransform;

	[Token(Token = "0x40007A6")]
	[FieldOffset(Offset = "0x58")]
	private Vector3 localPosition;

	[Token(Token = "0x40007A7")]
	[FieldOffset(Offset = "0x68")]
	private Transform[] imageTransforms;

	[Token(Token = "0x40007A8")]
	[FieldOffset(Offset = "0x70")]
	private Vector3[] imageScales;

	[Token(Token = "0x6000784")]
	[Address(RVA = "0x1559200", Offset = "0x1559200", VA = "0x1559200")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000785")]
	[Address(RVA = "0x1559624", Offset = "0x1559624", VA = "0x1559624")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000786")]
	[Address(RVA = "0x15596A0", Offset = "0x15596A0", VA = "0x15596A0")]
	private IEnumerator FadeInOutCR()
	{
		return null;
	}

	[Token(Token = "0x6000787")]
	[Address(RVA = "0x1559714", Offset = "0x1559714", VA = "0x1559714")]
	private void SetImageAlphas(SVGImage[] images, float alpha)
	{
	}

	[Token(Token = "0x6000788")]
	[Address(RVA = "0x15598C8", Offset = "0x15598C8", VA = "0x15598C8")]
	public MainMenuInputIconGroup()
	{
	}
}
