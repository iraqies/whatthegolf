using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

[Token(Token = "0x2000533")]
public class SpeechBubbleUI : MonoBehaviour
{
	[Token(Token = "0x2000534")]
	public class Task
	{
		[Token(Token = "0x4001AD3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string text;

		[Token(Token = "0x4001AD4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector2 speakerPosition;

		[Token(Token = "0x4001AD5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector2? bubblePosition;

		[Token(Token = "0x4001AD6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Camera camera;

		[Token(Token = "0x4001AD7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector2? arrowDirection;

		[Token(Token = "0x4001AD8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool bypassLocalization;

		[Token(Token = "0x4001AD9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Func<string, string> onPreprocess;

		[Token(Token = "0x4001ADA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool isDone;

		[Token(Token = "0x60017C7")]
		[Address(RVA = "0x18591F8", Offset = "0x18591F8", VA = "0x18591F8")]
		public Task()
		{
		}
	}

	[Token(Token = "0x2000535")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40314", Offset = "0x40314")]
	private sealed class _003CShowCoroutine_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001ADB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001ADC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001ADD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SpeechBubbleUI _003C_003E4__this;

		[Token(Token = "0x4001ADE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string _003ClocalizedText_003E5__2;

		[Token(Token = "0x4001ADF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private IEnumerator _003Cco_003E5__3;

		[Token(Token = "0x170002A2")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60017CB")]
			[Address(RVA = "0x18591A8", Offset = "0x18591A8", VA = "0x18591A8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170002A3")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60017CD")]
			[Address(RVA = "0x18591F0", Offset = "0x18591F0", VA = "0x18591F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60017C8")]
		[Address(RVA = "0x1858CFC", Offset = "0x1858CFC", VA = "0x1858CFC")]
		[DebuggerHidden]
		public _003CShowCoroutine_003Ed__29(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60017C9")]
		[Address(RVA = "0x1858D28", Offset = "0x1858D28", VA = "0x1858D28", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60017CA")]
		[Address(RVA = "0x1858D2C", Offset = "0x1858D2C", VA = "0x1858D2C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60017CB")]
		[Address(RVA = "0x18591A8", Offset = "0x18591A8", VA = "0x18591A8", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60017CC")]
		[Address(RVA = "0x18591B0", Offset = "0x18591B0", VA = "0x18591B0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60017CD")]
		[Address(RVA = "0x18591F0", Offset = "0x18591F0", VA = "0x18591F0", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000536")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40324", Offset = "0x40324")]
	private sealed class _003C_003Ec__DisplayClass31_0
	{
		[Token(Token = "0x4001AE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SpeechBubbleUI _003C_003E4__this;

		[Token(Token = "0x4001AE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector2 startSize;

		[Token(Token = "0x4001AE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector2 targetSize;

		[Token(Token = "0x4001AE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector2 bubblePosition_start;

		[Token(Token = "0x4001AE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector2 bubblePosition_target;

		[Token(Token = "0x60017CE")]
		[Address(RVA = "0x185823C", Offset = "0x185823C", VA = "0x185823C")]
		public _003C_003Ec__DisplayClass31_0()
		{
		}

		[Token(Token = "0x60017CF")]
		[Address(RVA = "0x1858244", Offset = "0x1858244", VA = "0x1858244")]
		internal void _003CShowBubbleCoroutine_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x2000537")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40334", Offset = "0x40334")]
	private sealed class _003CShowBubbleCoroutine_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001AE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001AE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001AE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SpeechBubbleUI _003C_003E4__this;

		[Token(Token = "0x4001AE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Task task;

		[Token(Token = "0x4001AE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass31_0 _003C_003E8__1;

		[Token(Token = "0x4001AEA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private IEnumerator _003Cco_003E5__2;

		[Token(Token = "0x170002A4")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60017D3")]
			[Address(RVA = "0x1858CAC", Offset = "0x1858CAC", VA = "0x1858CAC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170002A5")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60017D5")]
			[Address(RVA = "0x1858CF4", Offset = "0x1858CF4", VA = "0x1858CF4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60017D0")]
		[Address(RVA = "0x18583C0", Offset = "0x18583C0", VA = "0x18583C0")]
		[DebuggerHidden]
		public _003CShowBubbleCoroutine_003Ed__31(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60017D1")]
		[Address(RVA = "0x18583EC", Offset = "0x18583EC", VA = "0x18583EC", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60017D2")]
		[Address(RVA = "0x18583F0", Offset = "0x18583F0", VA = "0x18583F0", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60017D3")]
		[Address(RVA = "0x1858CAC", Offset = "0x1858CAC", VA = "0x1858CAC", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60017D4")]
		[Address(RVA = "0x1858CB4", Offset = "0x1858CB4", VA = "0x1858CB4", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60017D5")]
		[Address(RVA = "0x1858CF4", Offset = "0x1858CF4", VA = "0x1858CF4", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000538")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40344", Offset = "0x40344")]
	private struct _003C_003Ec__DisplayClass32_0
	{
		[Token(Token = "0x4001AEB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector2 targetSize;

		[Token(Token = "0x4001AEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float innerRatio;
	}

	[Token(Token = "0x2000539")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40354", Offset = "0x40354")]
	private sealed class _003C_003Ec__DisplayClass35_0
	{
		[Token(Token = "0x4001AED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector2 startSize;

		[Token(Token = "0x4001AEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SpeechBubbleUI _003C_003E4__this;

		[Token(Token = "0x60017D6")]
		[Address(RVA = "0x1858320", Offset = "0x1858320", VA = "0x1858320")]
		public _003C_003Ec__DisplayClass35_0()
		{
		}

		[Token(Token = "0x60017D7")]
		[Address(RVA = "0x1858328", Offset = "0x1858328", VA = "0x1858328")]
		internal void _003CHide_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x4001ABA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Vector2 padding;

	[Token(Token = "0x4001ABB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Vector2 minSize;

	[Token(Token = "0x4001ABC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Vector2 maxSize;

	[Token(Token = "0x4001ABD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Vector2 arrowOffset;

	[Token(Token = "0x4001ABE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Vector2 arrowExtraOffset;

	[Token(Token = "0x4001ABF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private float maxArrowScale;

	[Token(Token = "0x4001AC0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private TextMeshProUGUI bubbleText;

	[Token(Token = "0x4001AC1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private RectTransform bubbleTextTransform;

	[Token(Token = "0x4001AC2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private RectTransform bubbleTransform;

	[Token(Token = "0x4001AC3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private RectTransform arrowTransform;

	[Token(Token = "0x4001AC4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private SpeechBubbleTextEffect textEffect;

	[Token(Token = "0x4001AC5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private bool bypassEnlargeSpeechBubbles;

	[Token(Token = "0x4001AC6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private Color textColor;

	[Token(Token = "0x4001AC7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private Color textColorInvisible;

	[Token(Token = "0x4001AC8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private Color arrowColor;

	[Token(Token = "0x4001AC9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private Color arrowColorInvisible;

	[Token(Token = "0x4001ACA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private StringBuilder sb;

	[Token(Token = "0x4001ACB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private bool isVisible;

	[Token(Token = "0x4001ACC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private Task activeTask;

	[Token(Token = "0x4001ACD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private Task nextTask;

	[Token(Token = "0x4001ACE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private Coroutine coroutine;

	[Token(Token = "0x4001ACF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private float enlargeSpeechBubbleScale;

	[Token(Token = "0x4001AD0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	private float arrowFadeDuration;

	[Token(Token = "0x4001AD1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private float resizeDuration;

	[Token(Token = "0x4001AD2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private TextMeshProLocalized bubbleTextLocalized;

	[Token(Token = "0x60017B8")]
	[Address(RVA = "0x16CF948", Offset = "0x16CF948", VA = "0x16CF948")]
	private void Awake()
	{
	}

	[Token(Token = "0x60017B9")]
	[Address(RVA = "0x16CF9EC", Offset = "0x16CF9EC", VA = "0x16CF9EC")]
	private void UpdateScale()
	{
	}

	[Token(Token = "0x60017BA")]
	[Address(RVA = "0x16CFAC8", Offset = "0x16CFAC8", VA = "0x16CFAC8")]
	public Task Show(string text, Vector2 speakerPosition, [Optional] Vector2? bubblePosition, [Optional] Camera camera, [Optional] Vector2? arrowDirection, [Optional][DefaultParameterValue(false)] bool localized, [Optional] Func<string, string> OnPreprocess)
	{
		return null;
	}

	[Token(Token = "0x60017BB")]
	[Address(RVA = "0x16CFC24", Offset = "0x16CFC24", VA = "0x16CFC24")]
	private IEnumerator ShowCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60017BC")]
	[Address(RVA = "0x16CFC98", Offset = "0x16CFC98", VA = "0x16CFC98")]
	private Vector2 ViewportToLocal(Vector3 position_view)
	{
		return default;
	}

	[Token(Token = "0x60017BD")]
	[Address(RVA = "0x16CFCD8", Offset = "0x16CFCD8", VA = "0x16CFCD8")]
	private IEnumerator ShowBubbleCoroutine(Task task)
	{
		return null;
	}

	[Token(Token = "0x60017BE")]
	[Address(RVA = "0x16CFD50", Offset = "0x16CFD50", VA = "0x16CFD50")]
	private Vector2 GetArrowPositionOnBubble(Vector2 arrowPosition_local, Vector2 bubblePosition, Vector2 targetSize)
	{
		return default;
	}

	[Token(Token = "0x60017BF")]
	[Address(RVA = "0x16CFEC4", Offset = "0x16CFEC4", VA = "0x16CFEC4")]
	private Vector2 OnUnitBox(Vector2 dir)
	{
		return default;
	}

	[Token(Token = "0x60017C0")]
	[Address(RVA = "0x16CFF8C", Offset = "0x16CFF8C", VA = "0x16CFF8C")]
	private float ZeroSign(float f)
	{
		return default;
	}

	[Token(Token = "0x60017C1")]
	[Address(RVA = "0x16CFFBC", Offset = "0x16CFFBC", VA = "0x16CFFBC")]
	public void Hide(bool showAnimation = true)
	{
	}

	[Token(Token = "0x60017C2")]
	[Address(RVA = "0x16D01E4", Offset = "0x16D01E4", VA = "0x16D01E4")]
	public SpeechBubbleUI()
	{
	}

	[Token(Token = "0x60017C3")]
	[Address(RVA = "0x16D0298", Offset = "0x16D0298", VA = "0x16D0298")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62EC8", Offset = "0x62EC8")]
	private void _003CShowCoroutine_003Eb__29_0(string text)
	{
	}

	[Token(Token = "0x60017C4")]
	[Address(RVA = "0x16CFE9C", Offset = "0x16CFE9C", VA = "0x16CFE9C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62ED8", Offset = "0x62ED8")]
	internal static Vector2 _003CGetArrowPositionOnBubble_003Eg__ToBubbleSpace_007C32_0(Vector2 dir, ref _003C_003Ec__DisplayClass32_0 P_1)
	{
		return default;
	}

	[Token(Token = "0x60017C5")]
	[Address(RVA = "0x16CFF64", Offset = "0x16CFF64", VA = "0x16CFF64")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62EE8", Offset = "0x62EE8")]
	internal static Vector2 _003CGetArrowPositionOnBubble_003Eg__FromBubbleSpace_007C32_1(Vector2 dir, ref _003C_003Ec__DisplayClass32_0 P_1)
	{
		return default;
	}

	[Token(Token = "0x60017C6")]
	[Address(RVA = "0x16D02BC", Offset = "0x16D02BC", VA = "0x16D02BC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62EF8", Offset = "0x62EF8")]
	private void _003CHide_003Eb__35_1()
	{
	}
}
