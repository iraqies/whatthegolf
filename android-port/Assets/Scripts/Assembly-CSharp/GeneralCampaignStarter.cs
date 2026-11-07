using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000368")]
public class GeneralCampaignStarter : BasePackStarter
{
	[Token(Token = "0x2000369")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F2FC", Offset = "0x3F2FC")]
	private sealed class _003CStartPack_003Ed__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40012B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40012B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40012B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ContentPack pack;

		[Token(Token = "0x40012B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string level;

		[Token(Token = "0x40012B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GeneralCampaignStarter _003C_003E4__this;

		[Token(Token = "0x40012BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transmogrif.BALLSHAPES shape;

		[Token(Token = "0x40012BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool _003Cunload_003E5__2;

		[Token(Token = "0x170001D7")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000FD1")]
			[Address(RVA = "0x17B32F0", Offset = "0x17B32F0", VA = "0x17B32F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170001D8")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000FD3")]
			[Address(RVA = "0x17B3338", Offset = "0x17B3338", VA = "0x17B3338", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000FCE")]
		[Address(RVA = "0x17B303C", Offset = "0x17B303C", VA = "0x17B303C")]
		[DebuggerHidden]
		public _003CStartPack_003Ed__1(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000FCF")]
		[Address(RVA = "0x17B3068", Offset = "0x17B3068", VA = "0x17B3068", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000FD0")]
		[Address(RVA = "0x17B306C", Offset = "0x17B306C", VA = "0x17B306C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000FD1")]
		[Address(RVA = "0x17B32F0", Offset = "0x17B32F0", VA = "0x17B32F0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000FD2")]
		[Address(RVA = "0x17B32F8", Offset = "0x17B32F8", VA = "0x17B32F8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000FD3")]
		[Address(RVA = "0x17B3338", Offset = "0x17B3338", VA = "0x17B3338", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Serializable]
	[Token(Token = "0x200036A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F30C", Offset = "0x3F30C")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x40012BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x40012BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<bool> _003C_003E9__3_0;

		[Token(Token = "0x40012BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Func<bool> _003C_003E9__3_1;

		[Token(Token = "0x40012BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Func<bool> _003C_003E9__5_0;

		[Token(Token = "0x40012C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Func<bool> _003C_003E9__5_1;

		[Token(Token = "0x40012C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static Func<bool> _003C_003E9__5_2;

		[Token(Token = "0x40012C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static Func<bool> _003C_003E9__7_0;

		[Token(Token = "0x40012C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static Func<OverworldGoal, string> _003C_003E9__8_2;

		[Token(Token = "0x6000FD5")]
		[Address(RVA = "0x17B1564", Offset = "0x17B1564", VA = "0x17B1564")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6000FD6")]
		[Address(RVA = "0x17B156C", Offset = "0x17B156C", VA = "0x17B156C")]
		internal bool _003CStartCampaignCR_003Eb__3_0()
		{
			return default;
		}

		[Token(Token = "0x6000FD7")]
		[Address(RVA = "0x17B1574", Offset = "0x17B1574", VA = "0x17B1574")]
		internal bool _003CStartCampaignCR_003Eb__3_1()
		{
			return default;
		}

		[Token(Token = "0x6000FD8")]
		[Address(RVA = "0x17B1610", Offset = "0x17B1610", VA = "0x17B1610")]
		internal bool _003CAwaitLevelLoadCR_003Eb__5_0()
		{
			return default;
		}

		[Token(Token = "0x6000FD9")]
		[Address(RVA = "0x17B16D8", Offset = "0x17B16D8", VA = "0x17B16D8")]
		internal bool _003CAwaitLevelLoadCR_003Eb__5_1()
		{
			return default;
		}

		[Token(Token = "0x6000FDA")]
		[Address(RVA = "0x17B16FC", Offset = "0x17B16FC", VA = "0x17B16FC")]
		internal bool _003CAwaitLevelLoadCR_003Eb__5_2()
		{
			return default;
		}

		[Token(Token = "0x6000FDB")]
		[Address(RVA = "0x17B179C", Offset = "0x17B179C", VA = "0x17B179C")]
		internal bool _003CGoToPosition_003Eb__7_0()
		{
			return default;
		}

		[Token(Token = "0x6000FDC")]
		[Address(RVA = "0x17B181C", Offset = "0x17B181C", VA = "0x17B181C")]
		internal string _003CCheckDoors_003Eb__8_2(OverworldGoal g)
		{
			return null;
		}
	}

	[Token(Token = "0x200036B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F31C", Offset = "0x3F31C")]
	private sealed class _003CStartCampaignCR_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40012C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40012C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40012C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ContentPack pack;

		[Token(Token = "0x40012C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GeneralCampaignStarter _003C_003E4__this;

		[Token(Token = "0x40012C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string level;

		[Token(Token = "0x40012C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transmogrif.BALLSHAPES shape;

		[Token(Token = "0x40012CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private CampaignDef _003Cdef_003E5__2;

		[Token(Token = "0x170001D9")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000FE0")]
			[Address(RVA = "0x17B2FEC", Offset = "0x17B2FEC", VA = "0x17B2FEC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170001DA")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000FE2")]
			[Address(RVA = "0x17B3034", Offset = "0x17B3034", VA = "0x17B3034", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000FDD")]
		[Address(RVA = "0x17B2964", Offset = "0x17B2964", VA = "0x17B2964")]
		[DebuggerHidden]
		public _003CStartCampaignCR_003Ed__3(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000FDE")]
		[Address(RVA = "0x17B2990", Offset = "0x17B2990", VA = "0x17B2990", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000FDF")]
		[Address(RVA = "0x17B2994", Offset = "0x17B2994", VA = "0x17B2994", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000FE0")]
		[Address(RVA = "0x17B2FEC", Offset = "0x17B2FEC", VA = "0x17B2FEC", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000FE1")]
		[Address(RVA = "0x17B2FF4", Offset = "0x17B2FF4", VA = "0x17B2FF4", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000FE2")]
		[Address(RVA = "0x17B3034", Offset = "0x17B3034", VA = "0x17B3034", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x200036C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F32C", Offset = "0x3F32C")]
	private sealed class _003C_003Ec__DisplayClass4_0
	{
		[Token(Token = "0x40012CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string notificationId;

		[Token(Token = "0x6000FE3")]
		[Address(RVA = "0x17B1840", Offset = "0x17B1840", VA = "0x17B1840")]
		public _003C_003Ec__DisplayClass4_0()
		{
		}

		[Token(Token = "0x6000FE4")]
		[Address(RVA = "0x17B1848", Offset = "0x17B1848", VA = "0x17B1848")]
		internal bool _003CGoToComputerCR_003Eb__0(OverworldMainDoorRobot g)
		{
			return default;
		}
	}

	[Token(Token = "0x200036D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F33C", Offset = "0x3F33C")]
	private sealed class _003CGoToComputerCR_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40012CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40012CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40012CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string notificationId;

		[Token(Token = "0x40012CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GeneralCampaignStarter _003C_003E4__this;

		[Token(Token = "0x40012D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass4_0 _003C_003E8__1;

		[Token(Token = "0x170001DB")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000FE8")]
			[Address(RVA = "0x17B2330", Offset = "0x17B2330", VA = "0x17B2330", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170001DC")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000FEA")]
			[Address(RVA = "0x17B2378", Offset = "0x17B2378", VA = "0x17B2378", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000FE5")]
		[Address(RVA = "0x17B2070", Offset = "0x17B2070", VA = "0x17B2070")]
		[DebuggerHidden]
		public _003CGoToComputerCR_003Ed__4(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000FE6")]
		[Address(RVA = "0x17B209C", Offset = "0x17B209C", VA = "0x17B209C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000FE7")]
		[Address(RVA = "0x17B20A0", Offset = "0x17B20A0", VA = "0x17B20A0", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000FE8")]
		[Address(RVA = "0x17B2330", Offset = "0x17B2330", VA = "0x17B2330", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000FE9")]
		[Address(RVA = "0x17B2338", Offset = "0x17B2338", VA = "0x17B2338", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000FEA")]
		[Address(RVA = "0x17B2378", Offset = "0x17B2378", VA = "0x17B2378", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x200036E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F34C", Offset = "0x3F34C")]
	private sealed class _003CAwaitLevelLoadCR_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40012D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40012D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40012D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float delay;

		[Token(Token = "0x170001DD")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000FEE")]
			[Address(RVA = "0x17B2020", Offset = "0x17B2020", VA = "0x17B2020", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170001DE")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000FF0")]
			[Address(RVA = "0x17B2068", Offset = "0x17B2068", VA = "0x17B2068", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000FEB")]
		[Address(RVA = "0x17B1B44", Offset = "0x17B1B44", VA = "0x17B1B44")]
		[DebuggerHidden]
		public _003CAwaitLevelLoadCR_003Ed__5(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000FEC")]
		[Address(RVA = "0x17B1B70", Offset = "0x17B1B70", VA = "0x17B1B70", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000FED")]
		[Address(RVA = "0x17B1B74", Offset = "0x17B1B74", VA = "0x17B1B74", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000FEE")]
		[Address(RVA = "0x17B2020", Offset = "0x17B2020", VA = "0x17B2020", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000FEF")]
		[Address(RVA = "0x17B2028", Offset = "0x17B2028", VA = "0x17B2028", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000FF0")]
		[Address(RVA = "0x17B2068", Offset = "0x17B2068", VA = "0x17B2068", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x200036F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F35C", Offset = "0x3F35C")]
	private sealed class _003C_003Ec__DisplayClass6_0
	{
		[Token(Token = "0x40012D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string level;

		[Token(Token = "0x6000FF1")]
		[Address(RVA = "0x17B186C", Offset = "0x17B186C", VA = "0x17B186C")]
		public _003C_003Ec__DisplayClass6_0()
		{
		}

		[Token(Token = "0x6000FF2")]
		[Address(RVA = "0x17B1874", Offset = "0x17B1874", VA = "0x17B1874")]
		internal bool _003CGoToLevelCR_003Eb__0(OverworldGoal g)
		{
			return default;
		}
	}

	[Token(Token = "0x2000370")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F36C", Offset = "0x3F36C")]
	private sealed class _003CGoToLevelCR_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40012D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40012D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40012D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string level;

		[Token(Token = "0x40012D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GeneralCampaignStarter _003C_003E4__this;

		[Token(Token = "0x40012D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float delay;

		[Token(Token = "0x40012DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private _003C_003Ec__DisplayClass6_0 _003C_003E8__1;

		[Token(Token = "0x40012DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transmogrif.BALLSHAPES shape;

		[Token(Token = "0x170001DF")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000FF6")]
			[Address(RVA = "0x17B26D0", Offset = "0x17B26D0", VA = "0x17B26D0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170001E0")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000FF8")]
			[Address(RVA = "0x17B2718", Offset = "0x17B2718", VA = "0x17B2718", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000FF3")]
		[Address(RVA = "0x17B2380", Offset = "0x17B2380", VA = "0x17B2380")]
		[DebuggerHidden]
		public _003CGoToLevelCR_003Ed__6(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000FF4")]
		[Address(RVA = "0x17B23AC", Offset = "0x17B23AC", VA = "0x17B23AC", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000FF5")]
		[Address(RVA = "0x17B23B0", Offset = "0x17B23B0", VA = "0x17B23B0", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000FF6")]
		[Address(RVA = "0x17B26D0", Offset = "0x17B26D0", VA = "0x17B26D0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000FF7")]
		[Address(RVA = "0x17B26D8", Offset = "0x17B26D8", VA = "0x17B26D8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000FF8")]
		[Address(RVA = "0x17B2718", Offset = "0x17B2718", VA = "0x17B2718", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000371")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F37C", Offset = "0x3F37C")]
	private sealed class _003CGoToPosition_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40012DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40012DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40012DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector2 position;

		[Token(Token = "0x170001E1")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000FFC")]
			[Address(RVA = "0x17B2914", Offset = "0x17B2914", VA = "0x17B2914", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170001E2")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000FFE")]
			[Address(RVA = "0x17B295C", Offset = "0x17B295C", VA = "0x17B295C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000FF9")]
		[Address(RVA = "0x17B2720", Offset = "0x17B2720", VA = "0x17B2720")]
		[DebuggerHidden]
		public _003CGoToPosition_003Ed__7(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000FFA")]
		[Address(RVA = "0x17B274C", Offset = "0x17B274C", VA = "0x17B274C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000FFB")]
		[Address(RVA = "0x17B2750", Offset = "0x17B2750", VA = "0x17B2750", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000FFC")]
		[Address(RVA = "0x17B2914", Offset = "0x17B2914", VA = "0x17B2914", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000FFD")]
		[Address(RVA = "0x17B291C", Offset = "0x17B291C", VA = "0x17B291C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000FFE")]
		[Address(RVA = "0x17B295C", Offset = "0x17B295C", VA = "0x17B295C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000372")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F38C", Offset = "0x3F38C")]
	private sealed class _003C_003Ec__DisplayClass8_0
	{
		[Token(Token = "0x40012DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string level;

		[Token(Token = "0x40012E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool foundDoorToOpen;

		[Token(Token = "0x6000FFF")]
		[Address(RVA = "0x17B18A4", Offset = "0x17B18A4", VA = "0x17B18A4")]
		public _003C_003Ec__DisplayClass8_0()
		{
		}

		[Token(Token = "0x6001000")]
		[Address(RVA = "0x17B18AC", Offset = "0x17B18AC", VA = "0x17B18AC")]
		internal bool _003CCheckDoors_003Eb__0(OverworldButton2D d)
		{
			return default;
		}

		[Token(Token = "0x6001001")]
		[Address(RVA = "0x17B1A14", Offset = "0x17B1A14", VA = "0x17B1A14")]
		internal void _003CCheckDoors_003Eb__1(OverworldButton2D relevantDoor)
		{
		}
	}

	[Token(Token = "0x6000FC4")]
	[Address(RVA = "0x1483D64", Offset = "0x1483D64", VA = "0x1483D64", Slot = "4")]
	public override bool StartPack(ContentPack pack, params object[] additionalContext)
	{
		return default;
	}

	[Token(Token = "0x6000FC5")]
	[Address(RVA = "0x1483E40", Offset = "0x1483E40", VA = "0x1483E40")]
	private IEnumerator StartPack(ContentPack pack, [Optional] string level, Transmogrif.BALLSHAPES shape = Transmogrif.BALLSHAPES.ball)
	{
		return null;
	}

	[Token(Token = "0x6000FC6")]
	[Address(RVA = "0x1483ED0", Offset = "0x1483ED0", VA = "0x1483ED0")]
	public Task StartCampaign(ContentPack pack, [Optional] string level, Transmogrif.BALLSHAPES shape = Transmogrif.BALLSHAPES.ball)
	{
		return null;
	}

	[Token(Token = "0x6000FC7")]
	[Address(RVA = "0x1483F68", Offset = "0x1483F68", VA = "0x1483F68")]
	private IEnumerator StartCampaignCR(ContentPack pack, [Optional] string level, Transmogrif.BALLSHAPES shape = Transmogrif.BALLSHAPES.ball)
	{
		return null;
	}

	[Token(Token = "0x6000FC8")]
	[Address(RVA = "0x1483FF8", Offset = "0x1483FF8", VA = "0x1483FF8")]
	private IEnumerator GoToComputerCR(string notificationId)
	{
		return null;
	}

	[Token(Token = "0x6000FC9")]
	[Address(RVA = "0x1484070", Offset = "0x1484070", VA = "0x1484070")]
	private IEnumerator AwaitLevelLoadCR(float delay)
	{
		return null;
	}

	[Token(Token = "0x6000FCA")]
	[Address(RVA = "0x14840E4", Offset = "0x14840E4", VA = "0x14840E4")]
	private IEnumerator GoToLevelCR(string level, Transmogrif.BALLSHAPES shape, float delay = 0f)
	{
		return null;
	}

	[Token(Token = "0x6000FCB")]
	[Address(RVA = "0x148417C", Offset = "0x148417C", VA = "0x148417C")]
	private IEnumerator GoToPosition(Vector2 position)
	{
		return null;
	}

	[Token(Token = "0x6000FCC")]
	[Address(RVA = "0x14841F4", Offset = "0x14841F4", VA = "0x14841F4")]
	private bool CheckDoors(string level)
	{
		return default;
	}

	[Token(Token = "0x6000FCD")]
	[Address(RVA = "0x14843E8", Offset = "0x14843E8", VA = "0x14843E8")]
	public GeneralCampaignStarter()
	{
	}
}
