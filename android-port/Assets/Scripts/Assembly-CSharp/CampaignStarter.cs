using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

[Token(Token = "0x2000184")]
public class CampaignStarter : BasePackStarter
{
	[Token(Token = "0x2000185")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DE00", Offset = "0x3DE00")]
	private sealed class _003C_003Ec__DisplayClass2_0
	{
		[Token(Token = "0x40006E8")]
		[FieldOffset(Offset = "0x10")]
		public ContentPack pack;

		[Token(Token = "0x40006E9")]
		[FieldOffset(Offset = "0x18")]
		public CampaignStarter _003C_003E4__this;

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x1781080", Offset = "0x1781080", VA = "0x1781080")]
		public _003C_003Ec__DisplayClass2_0()
		{
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x1781088", Offset = "0x1781088", VA = "0x1781088")]
		internal bool _003CStartCampaignCR_003Eb__0(Onboarding o)
		{
			return default;
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x17810B8", Offset = "0x17810B8", VA = "0x17810B8")]
		internal void _003CStartCampaignCR_003Eb__1(bool complete)
		{
		}
	}

	[Token(Token = "0x2000186")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DE10", Offset = "0x3DE10")]
	private sealed class _003CStartCampaignCR_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40006EA")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40006EB")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40006EC")]
		[FieldOffset(Offset = "0x20")]
		public ContentPack pack;

		[Token(Token = "0x40006ED")]
		[FieldOffset(Offset = "0x28")]
		public CampaignStarter _003C_003E4__this;

		[Token(Token = "0x40006EE")]
		[FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass2_0 _003C_003E8__1;

		[Token(Token = "0x40006EF")]
		[FieldOffset(Offset = "0x38")]
		public OverworldLevelSection section;

		[Token(Token = "0x170000E7")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60006B6")]
			[Address(RVA = "0x1781638", Offset = "0x1781638", VA = "0x1781638", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170000E8")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60006B8")]
			[Address(RVA = "0x1781680", Offset = "0x1781680", VA = "0x1781680", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x17810D4", Offset = "0x17810D4", VA = "0x17810D4")]
		[DebuggerHidden]
		public _003CStartCampaignCR_003Ed__2(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x1781100", Offset = "0x1781100", VA = "0x1781100", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x1781104", Offset = "0x1781104", VA = "0x1781104", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x1781638", Offset = "0x1781638", VA = "0x1781638", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x1781640", Offset = "0x1781640", VA = "0x1781640", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x1781680", Offset = "0x1781680", VA = "0x1781680", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Serializable]
	[Token(Token = "0x2000187")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DE20", Offset = "0x3DE20")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x40006F0")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x40006F1")]
		[FieldOffset(Offset = "0x8")]
		public static Func<bool> _003C_003E9__5_0;

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x1781024", Offset = "0x1781024", VA = "0x1781024")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x178102C", Offset = "0x178102C", VA = "0x178102C")]
		internal bool _003CWaitAfterLevelLoaded_003Eb__5_0()
		{
			return default;
		}
	}

	[Token(Token = "0x2000188")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DE30", Offset = "0x3DE30")]
	private sealed class _003CWaitAfterLevelLoaded_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40006F2")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40006F3")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40006F4")]
		[FieldOffset(Offset = "0x20")]
		public CampaignStarter _003C_003E4__this;

		[Token(Token = "0x170000E9")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60006BF")]
			[Address(RVA = "0x17818CC", Offset = "0x17818CC", VA = "0x17818CC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170000EA")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60006C1")]
			[Address(RVA = "0x1781914", Offset = "0x1781914", VA = "0x1781914", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x1781688", Offset = "0x1781688", VA = "0x1781688")]
		[DebuggerHidden]
		public _003CWaitAfterLevelLoaded_003Ed__5(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x17816B4", Offset = "0x17816B4", VA = "0x17816B4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x17816B8", Offset = "0x17816B8", VA = "0x17816B8", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x17818CC", Offset = "0x17818CC", VA = "0x17818CC", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x17818D4", Offset = "0x17818D4", VA = "0x17818D4", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x1781914", Offset = "0x1781914", VA = "0x1781914", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40006E7")]
	[FieldOffset(Offset = "0x20")]
	private OverworldManager2d overworldCaller;

	[Token(Token = "0x60006AA")]
	[Address(RVA = "0x1885C28", Offset = "0x1885C28", VA = "0x1885C28", Slot = "4")]
	public override bool StartPack(ContentPack pack, params object[] additionalContext)
	{
		return default;
	}

	[Token(Token = "0x60006AB")]
	[Address(RVA = "0x1885D00", Offset = "0x1885D00", VA = "0x1885D00")]
	private IEnumerator StartCampaignCR(ContentPack pack, OverworldLevelSection section)
	{
		return null;
	}

	[Token(Token = "0x60006AC")]
	[Address(RVA = "0x1885D88", Offset = "0x1885D88", VA = "0x1885D88")]
	private void LevelAborted()
	{
	}

	[Token(Token = "0x60006AD")]
	[Address(RVA = "0x1885E24", Offset = "0x1885E24", VA = "0x1885E24")]
	private void BackFromOnboarding(bool isComplete)
	{
	}

	[Token(Token = "0x60006AE")]
	[Address(RVA = "0x1885F20", Offset = "0x1885F20", VA = "0x1885F20")]
	private IEnumerator WaitAfterLevelLoaded()
	{
		return null;
	}

	[Token(Token = "0x60006AF")]
	[Address(RVA = "0x1885F94", Offset = "0x1885F94", VA = "0x1885F94")]
	public CampaignStarter()
	{
	}
}
