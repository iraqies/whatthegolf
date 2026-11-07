using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

[Token(Token = "0x2000581")]
public class SpeechBubble : MonoBehaviour
{
	[Token(Token = "0x2000582")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x405D4", Offset = "0x405D4")]
	private sealed class _003CShowText_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001C48")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001C49")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001C4A")]
		[FieldOffset(Offset = "0x20")]
		public SpeechBubble _003C_003E4__this;

		[Token(Token = "0x4001C4B")]
		[FieldOffset(Offset = "0x28")]
		private int _003CtotalVisibleCharacters_003E5__2;

		[Token(Token = "0x4001C4C")]
		[FieldOffset(Offset = "0x2C")]
		private int _003Ccounter_003E5__3;

		[Token(Token = "0x170002B5")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001916")]
			[Address(RVA = "0x185791C", Offset = "0x185791C", VA = "0x185791C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170002B6")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001918")]
			[Address(RVA = "0x1857964", Offset = "0x1857964", VA = "0x1857964", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001913")]
		[Address(RVA = "0x1857768", Offset = "0x1857768", VA = "0x1857768")]
		[DebuggerHidden]
		public _003CShowText_003Ed__19(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001914")]
		[Address(RVA = "0x1857794", Offset = "0x1857794", VA = "0x1857794", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001915")]
		[Address(RVA = "0x1857798", Offset = "0x1857798", VA = "0x1857798", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001916")]
		[Address(RVA = "0x185791C", Offset = "0x185791C", VA = "0x185791C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001917")]
		[Address(RVA = "0x1857924", Offset = "0x1857924", VA = "0x1857924", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001918")]
		[Address(RVA = "0x1857964", Offset = "0x1857964", VA = "0x1857964", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4001C39")]
	[FieldOffset(Offset = "0x18")]
	public string Text;

	[Token(Token = "0x4001C3A")]
	[FieldOffset(Offset = "0x20")]
	public string TextID;

	[Token(Token = "0x4001C3B")]
	[FieldOffset(Offset = "0x28")]
	public float LifeTime;

	[Token(Token = "0x4001C3C")]
	[FieldOffset(Offset = "0x2C")]
	public float FloatStrength;

	[Token(Token = "0x4001C3D")]
	[FieldOffset(Offset = "0x30")]
	public List<GameObject> TriggerObjects;

	[Token(Token = "0x4001C3E")]
	[FieldOffset(Offset = "0x38")]
	public float SpeechSpeed;

	[Token(Token = "0x4001C3F")]
	[FieldOffset(Offset = "0x3C")]
	public float Distance;

	[Token(Token = "0x4001C40")]
	[FieldOffset(Offset = "0x40")]
	public float Delay;

	[Token(Token = "0x4001C41")]
	[FieldOffset(Offset = "0x44")]
	public float TextDelay;

	[Token(Token = "0x4001C42")]
	[FieldOffset(Offset = "0x48")]
	private ParticleSystem particles;

	[Token(Token = "0x4001C43")]
	[FieldOffset(Offset = "0x50")]
	private float lifeTimer;

	[Token(Token = "0x4001C44")]
	[FieldOffset(Offset = "0x58")]
	private TextMeshProUGUI text;

	[Token(Token = "0x4001C45")]
	[FieldOffset(Offset = "0x60")]
	private bool started;

	[Token(Token = "0x4001C46")]
	[FieldOffset(Offset = "0x68")]
	private Transform container;

	[Token(Token = "0x4001C47")]
	[FieldOffset(Offset = "0x70")]
	private bool killParticles;

	[Token(Token = "0x600190B")]
	[Address(RVA = "0x16CEC88", Offset = "0x16CEC88", VA = "0x16CEC88")]
	private void Awake()
	{
	}

	[Token(Token = "0x600190C")]
	[Address(RVA = "0x16CECF8", Offset = "0x16CECF8", VA = "0x16CECF8")]
	private void Start()
	{
	}

	[Token(Token = "0x600190D")]
	[Address(RVA = "0x16CED74", Offset = "0x16CED74", VA = "0x16CED74")]
	private void Update()
	{
	}

	[Token(Token = "0x600190E")]
	[Address(RVA = "0x16CF088", Offset = "0x16CF088", VA = "0x16CF088")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600190F")]
	[Address(RVA = "0x16CF1D4", Offset = "0x16CF1D4", VA = "0x16CF1D4")]
	private IEnumerator ShowText()
	{
		return null;
	}

	[Token(Token = "0x6001910")]
	[Address(RVA = "0x16CEF88", Offset = "0x16CEF88", VA = "0x16CEF88")]
	public void Show()
	{
	}

	[Token(Token = "0x6001911")]
	[Address(RVA = "0x16CF248", Offset = "0x16CF248", VA = "0x16CF248")]
	public void Hide()
	{
	}

	[Token(Token = "0x6001912")]
	[Address(RVA = "0x16CF254", Offset = "0x16CF254", VA = "0x16CF254")]
	public SpeechBubble()
	{
	}
}
