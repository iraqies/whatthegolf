using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20005C6")]
public class GifPreviewUI : MonoBehaviour
{
	[Token(Token = "0x20005C7")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40850", Offset = "0x40850")]
	private sealed class _003CPlayImagesCR_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001D8C")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001D8D")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001D8E")]
		[FieldOffset(Offset = "0x20")]
		public GifPreviewUI _003C_003E4__this;

		[Token(Token = "0x4001D8F")]
		[FieldOffset(Offset = "0x28")]
		public float fps;

		[Token(Token = "0x4001D90")]
		[FieldOffset(Offset = "0x30")]
		private Texture2D _003CtempTex_003E5__2;

		[Token(Token = "0x4001D91")]
		[FieldOffset(Offset = "0x38")]
		private int _003CframeIndex_003E5__3;

		[Token(Token = "0x170002D9")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001A4D")]
			[Address(RVA = "0x17B3730", Offset = "0x17B3730", VA = "0x17B3730", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170002DA")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001A4F")]
			[Address(RVA = "0x17B3778", Offset = "0x17B3778", VA = "0x17B3778", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001A4A")]
		[Address(RVA = "0x17B35E0", Offset = "0x17B35E0", VA = "0x17B35E0")]
		[DebuggerHidden]
		public _003CPlayImagesCR_003Ed__11(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001A4B")]
		[Address(RVA = "0x17B360C", Offset = "0x17B360C", VA = "0x17B360C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001A4C")]
		[Address(RVA = "0x17B3610", Offset = "0x17B3610", VA = "0x17B3610", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001A4D")]
		[Address(RVA = "0x17B3730", Offset = "0x17B3730", VA = "0x17B3730", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001A4E")]
		[Address(RVA = "0x17B3738", Offset = "0x17B3738", VA = "0x17B3738", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001A4F")]
		[Address(RVA = "0x17B3778", Offset = "0x17B3778", VA = "0x17B3778", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4001D82")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RawImage image;

	[Token(Token = "0x4001D83")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Button button;

	[Token(Token = "0x4001D84")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private TMP_Text text;

	[Token(Token = "0x4001D85")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private bool aspectFill;

	[Token(Token = "0x4001D86")]
	[FieldOffset(Offset = "0x38")]
	private GifMoment moment;

	[Token(Token = "0x4001D87")]
	[FieldOffset(Offset = "0x40")]
	private Coroutine playCR;

	[Token(Token = "0x4001D88")]
	[FieldOffset(Offset = "0x48")]
	private bool firstUse;

	[Token(Token = "0x4001D89")]
	[FieldOffset(Offset = "0x4C")]
	private Vector2 originalSize;

	[Token(Token = "0x4001D8A")]
	[FieldOffset(Offset = "0x58")]
	public GameObject LockedObject;

	[Token(Token = "0x4001D8B")]
	[FieldOffset(Offset = "0x60")]
	public GameObject ImageThumbnailObject;

	[Token(Token = "0x170002D8")]
	public Button.ButtonClickedEvent onClick
	{
		[Token(Token = "0x6001A48")]
		[Address(RVA = "0x1488C74", Offset = "0x1488C74", VA = "0x1488C74")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001A46")]
	[Address(RVA = "0x1486748", Offset = "0x1486748", VA = "0x1486748")]
	public void SetMoment(GifMoment data, bool playGif)
	{
	}

	[Token(Token = "0x6001A47")]
	[Address(RVA = "0x1488BF0", Offset = "0x1488BF0", VA = "0x1488BF0")]
	public IEnumerator PlayImagesCR(float fps)
	{
		return null;
	}

	[Token(Token = "0x6001A49")]
	[Address(RVA = "0x1488C90", Offset = "0x1488C90", VA = "0x1488C90")]
	public GifPreviewUI()
	{
	}
}
