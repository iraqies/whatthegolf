using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20004C9")]
public class LevelDesignerStarter : BasePackStarter
{
	[Token(Token = "0x20004CA")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FE34", Offset = "0x3FE34")]
	private sealed class _003C_003Ec__DisplayClass3_0
	{
		[Token(Token = "0x4001904")]
		[FieldOffset(Offset = "0x10")]
		public bool _dialogDone;

		[Token(Token = "0x4001905")]
		[FieldOffset(Offset = "0x11")]
		public bool _goDiscord;

		[Token(Token = "0x6001606")]
		[Address(RVA = "0x17D2808", Offset = "0x17D2808", VA = "0x17D2808")]
		public _003C_003Ec__DisplayClass3_0()
		{
		}

		[Token(Token = "0x6001607")]
		[Address(RVA = "0x17D2810", Offset = "0x17D2810", VA = "0x17D2810")]
		internal void _003CLoadDesignerOrCommunityCR_003Eb__0()
		{
		}

		[Token(Token = "0x6001608")]
		[Address(RVA = "0x17D281C", Offset = "0x17D281C", VA = "0x17D281C")]
		internal void _003CLoadDesignerOrCommunityCR_003Eb__1()
		{
		}

		[Token(Token = "0x6001609")]
		[Address(RVA = "0x17D2828", Offset = "0x17D2828", VA = "0x17D2828")]
		internal void _003CLoadDesignerOrCommunityCR_003Eb__2()
		{
		}
	}

	[Token(Token = "0x20004CB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FE44", Offset = "0x3FE44")]
	private sealed class _003CLoadDesignerOrCommunityCR_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001906")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001907")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001908")]
		[FieldOffset(Offset = "0x20")]
		public ContentPack pack;

		[Token(Token = "0x4001909")]
		[FieldOffset(Offset = "0x28")]
		public LevelDesignerStarter _003C_003E4__this;

		[Token(Token = "0x400190A")]
		[FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass3_0 _003C_003E8__1;

		[Token(Token = "0x17000267")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600160D")]
			[Address(RVA = "0x17D2C00", Offset = "0x17D2C00", VA = "0x17D2C00", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000268")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600160F")]
			[Address(RVA = "0x17D2C48", Offset = "0x17D2C48", VA = "0x17D2C48", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600160A")]
		[Address(RVA = "0x17D2834", Offset = "0x17D2834", VA = "0x17D2834")]
		[DebuggerHidden]
		public _003CLoadDesignerOrCommunityCR_003Ed__3(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600160B")]
		[Address(RVA = "0x17D2860", Offset = "0x17D2860", VA = "0x17D2860", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600160C")]
		[Address(RVA = "0x17D2864", Offset = "0x17D2864", VA = "0x17D2864", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600160D")]
		[Address(RVA = "0x17D2C00", Offset = "0x17D2C00", VA = "0x17D2C00", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600160E")]
		[Address(RVA = "0x17D2C08", Offset = "0x17D2C08", VA = "0x17D2C08", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600160F")]
		[Address(RVA = "0x17D2C48", Offset = "0x17D2C48", VA = "0x17D2C48", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4001902")]
	[FieldOffset(Offset = "0x0")]
	private static ContentPack _pack;

	[Token(Token = "0x4001903")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private ModalWindow _earlyAccessDialog;

	[Token(Token = "0x6001603")]
	[Address(RVA = "0x152A7D8", Offset = "0x152A7D8", VA = "0x152A7D8", Slot = "4")]
	public override bool StartPack(ContentPack container, params object[] additionalContext)
	{
		return default;
	}

	[Token(Token = "0x6001604")]
	[Address(RVA = "0x152A8A0", Offset = "0x152A8A0", VA = "0x152A8A0")]
	private IEnumerator LoadDesignerOrCommunityCR(ContentPack pack)
	{
		return null;
	}

	[Token(Token = "0x6001605")]
	[Address(RVA = "0x152A918", Offset = "0x152A918", VA = "0x152A918")]
	public LevelDesignerStarter()
	{
	}
}
