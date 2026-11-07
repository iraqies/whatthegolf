using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200065D")]
public class BusFightPart : MonoBehaviour
{
	[Token(Token = "0x200065E")]
	public enum Pattern
	{
		[Token(Token = "0x4002114")]
		HoleBehindButton = 0,
		[Token(Token = "0x4002115")]
		InFrontOfPlayer = 1,
		[Token(Token = "0x4002116")]
		RandomClusters = 2,
		[Token(Token = "0x4002117")]
		RollBehind = 3
	}

	[Token(Token = "0x200065F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40C80", Offset = "0x40C80")]
	private sealed class _003CDettach_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002118")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002119")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400211A")]
		[FieldOffset(Offset = "0x20")]
		public BusFightPart _003C_003E4__this;

		[Token(Token = "0x1700033B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001D2C")]
			[Address(RVA = "0x177E470", Offset = "0x177E470", VA = "0x177E470", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700033C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001D2E")]
			[Address(RVA = "0x177E4B8", Offset = "0x177E4B8", VA = "0x177E4B8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001D29")]
		[Address(RVA = "0x177E080", Offset = "0x177E080", VA = "0x177E080")]
		[DebuggerHidden]
		public _003CDettach_003Ed__22(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001D2A")]
		[Address(RVA = "0x177E0AC", Offset = "0x177E0AC", VA = "0x177E0AC", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001D2B")]
		[Address(RVA = "0x177E0B0", Offset = "0x177E0B0", VA = "0x177E0B0", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001D2C")]
		[Address(RVA = "0x177E470", Offset = "0x177E470", VA = "0x177E470", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001D2D")]
		[Address(RVA = "0x177E478", Offset = "0x177E478", VA = "0x177E478", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001D2E")]
		[Address(RVA = "0x177E4B8", Offset = "0x177E4B8", VA = "0x177E4B8", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000660")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40C90", Offset = "0x40C90")]
	private sealed class _003CLandModuleAfterExplosionsAndCleanUp_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400211B")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400211C")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400211D")]
		[FieldOffset(Offset = "0x20")]
		public BusFightPart _003C_003E4__this;

		[Token(Token = "0x400211E")]
		[FieldOffset(Offset = "0x28")]
		private float _003CwaitTill_003E5__2;

		[Token(Token = "0x1700033D")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001D32")]
			[Address(RVA = "0x177F0E4", Offset = "0x177F0E4", VA = "0x177F0E4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700033E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001D34")]
			[Address(RVA = "0x177F12C", Offset = "0x177F12C", VA = "0x177F12C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001D2F")]
		[Address(RVA = "0x177EE34", Offset = "0x177EE34", VA = "0x177EE34")]
		[DebuggerHidden]
		public _003CLandModuleAfterExplosionsAndCleanUp_003Ed__23(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001D30")]
		[Address(RVA = "0x177EE60", Offset = "0x177EE60", VA = "0x177EE60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001D31")]
		[Address(RVA = "0x177EE64", Offset = "0x177EE64", VA = "0x177EE64", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001D32")]
		[Address(RVA = "0x177F0E4", Offset = "0x177F0E4", VA = "0x177F0E4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001D33")]
		[Address(RVA = "0x177F0EC", Offset = "0x177F0EC", VA = "0x177F0EC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001D34")]
		[Address(RVA = "0x177F12C", Offset = "0x177F12C", VA = "0x177F12C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000661")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40CA0", Offset = "0x40CA0")]
	private sealed class _003CAttackRoutine_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400211F")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002120")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002121")]
		[FieldOffset(Offset = "0x20")]
		public BusFightPart _003C_003E4__this;

		[Token(Token = "0x1700033F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001D38")]
			[Address(RVA = "0x177E030", Offset = "0x177E030", VA = "0x177E030", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000340")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001D3A")]
			[Address(RVA = "0x177E078", Offset = "0x177E078", VA = "0x177E078", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001D35")]
		[Address(RVA = "0x177DED4", Offset = "0x177DED4", VA = "0x177DED4")]
		[DebuggerHidden]
		public _003CAttackRoutine_003Ed__24(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001D36")]
		[Address(RVA = "0x177DF00", Offset = "0x177DF00", VA = "0x177DF00", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001D37")]
		[Address(RVA = "0x177DF04", Offset = "0x177DF04", VA = "0x177DF04", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001D38")]
		[Address(RVA = "0x177E030", Offset = "0x177E030", VA = "0x177E030", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001D39")]
		[Address(RVA = "0x177E038", Offset = "0x177E038", VA = "0x177E038", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001D3A")]
		[Address(RVA = "0x177E078", Offset = "0x177E078", VA = "0x177E078", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000662")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40CB0", Offset = "0x40CB0")]
	private sealed class _003C_003Ec__DisplayClass25_0
	{
		[Token(Token = "0x4002122")]
		[FieldOffset(Offset = "0x10")]
		public bool didPressButton;

		[Token(Token = "0x6001D3B")]
		[Address(RVA = "0x177DDF4", Offset = "0x177DDF4", VA = "0x177DDF4")]
		public _003C_003Ec__DisplayClass25_0()
		{
		}

		[Token(Token = "0x6001D3C")]
		[Address(RVA = "0x177DDFC", Offset = "0x177DDFC", VA = "0x177DDFC")]
		internal void _003CInFrontOfPlayerRoutine_003Eb__0()
		{
		}
	}

	[Token(Token = "0x2000663")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40CC0", Offset = "0x40CC0")]
	private sealed class _003CInFrontOfPlayerRoutine_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002123")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002124")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002125")]
		[FieldOffset(Offset = "0x20")]
		public BusFightPart _003C_003E4__this;

		[Token(Token = "0x4002126")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass25_0 _003C_003E8__1;

		[Token(Token = "0x4002127")]
		[FieldOffset(Offset = "0x30")]
		private float _003ClastSpawnZ_003E5__2;

		[Token(Token = "0x4002128")]
		[FieldOffset(Offset = "0x34")]
		private int _003Ccount_003E5__3;

		[Token(Token = "0x4002129")]
		[FieldOffset(Offset = "0x38")]
		private int _003Cresetcount_003E5__4;

		[Token(Token = "0x400212A")]
		[FieldOffset(Offset = "0x3C")]
		private float _003CcurrentZ_003E5__5;

		[Token(Token = "0x17000341")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001D40")]
			[Address(RVA = "0x177EDE4", Offset = "0x177EDE4", VA = "0x177EDE4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000342")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001D42")]
			[Address(RVA = "0x177EE2C", Offset = "0x177EE2C", VA = "0x177EE2C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001D3D")]
		[Address(RVA = "0x177E874", Offset = "0x177E874", VA = "0x177E874")]
		[DebuggerHidden]
		public _003CInFrontOfPlayerRoutine_003Ed__25(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001D3E")]
		[Address(RVA = "0x177E8A0", Offset = "0x177E8A0", VA = "0x177E8A0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001D3F")]
		[Address(RVA = "0x177E8A4", Offset = "0x177E8A4", VA = "0x177E8A4", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001D40")]
		[Address(RVA = "0x177EDE4", Offset = "0x177EDE4", VA = "0x177EDE4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001D41")]
		[Address(RVA = "0x177EDEC", Offset = "0x177EDEC", VA = "0x177EDEC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001D42")]
		[Address(RVA = "0x177EE2C", Offset = "0x177EE2C", VA = "0x177EE2C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000664")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40CD0", Offset = "0x40CD0")]
	private sealed class _003C_003Ec__DisplayClass26_0
	{
		[Token(Token = "0x400212B")]
		[FieldOffset(Offset = "0x10")]
		public bool didPressButton;

		[Token(Token = "0x6001D43")]
		[Address(RVA = "0x177DE08", Offset = "0x177DE08", VA = "0x177DE08")]
		public _003C_003Ec__DisplayClass26_0()
		{
		}

		[Token(Token = "0x6001D44")]
		[Address(RVA = "0x177DE10", Offset = "0x177DE10", VA = "0x177DE10")]
		internal void _003CRandomClustersRoutine_003Eb__0()
		{
		}
	}

	[Token(Token = "0x2000665")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40CE0", Offset = "0x40CE0")]
	private sealed class _003CRandomClustersRoutine_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400212C")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400212D")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400212E")]
		[FieldOffset(Offset = "0x20")]
		public BusFightPart _003C_003E4__this;

		[Token(Token = "0x400212F")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass26_0 _003C_003E8__1;

		[Token(Token = "0x4002130")]
		[FieldOffset(Offset = "0x30")]
		private float _003ClastSpawnZ_003E5__2;

		[Token(Token = "0x4002131")]
		[FieldOffset(Offset = "0x34")]
		private int _003Ccount_003E5__3;

		[Token(Token = "0x4002132")]
		[FieldOffset(Offset = "0x38")]
		private float _003CcurrentZ_003E5__4;

		[Token(Token = "0x17000343")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001D48")]
			[Address(RVA = "0x177F5BC", Offset = "0x177F5BC", VA = "0x177F5BC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000344")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001D4A")]
			[Address(RVA = "0x177F604", Offset = "0x177F604", VA = "0x177F604", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001D45")]
		[Address(RVA = "0x177F134", Offset = "0x177F134", VA = "0x177F134")]
		[DebuggerHidden]
		public _003CRandomClustersRoutine_003Ed__26(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001D46")]
		[Address(RVA = "0x177F160", Offset = "0x177F160", VA = "0x177F160", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001D47")]
		[Address(RVA = "0x177F164", Offset = "0x177F164", VA = "0x177F164", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001D48")]
		[Address(RVA = "0x177F5BC", Offset = "0x177F5BC", VA = "0x177F5BC", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001D49")]
		[Address(RVA = "0x177F5C4", Offset = "0x177F5C4", VA = "0x177F5C4", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001D4A")]
		[Address(RVA = "0x177F604", Offset = "0x177F604", VA = "0x177F604", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000666")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40CF0", Offset = "0x40CF0")]
	private sealed class _003C_003Ec__DisplayClass27_0
	{
		[Token(Token = "0x4002133")]
		[FieldOffset(Offset = "0x10")]
		public bool didPressButton;

		[Token(Token = "0x6001D4B")]
		[Address(RVA = "0x177DE1C", Offset = "0x177DE1C", VA = "0x177DE1C")]
		public _003C_003Ec__DisplayClass27_0()
		{
		}

		[Token(Token = "0x6001D4C")]
		[Address(RVA = "0x177DE24", Offset = "0x177DE24", VA = "0x177DE24")]
		internal void _003CRollBehindRoutine_003Eb__0()
		{
		}
	}

	[Token(Token = "0x2000667")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40D00", Offset = "0x40D00")]
	private sealed class _003CRollBehindRoutine_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002134")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002135")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002136")]
		[FieldOffset(Offset = "0x20")]
		public BusFightPart _003C_003E4__this;

		[Token(Token = "0x4002137")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass27_0 _003C_003E8__1;

		[Token(Token = "0x4002138")]
		[FieldOffset(Offset = "0x30")]
		private float _003ClastSpawnZ_003E5__2;

		[Token(Token = "0x4002139")]
		[FieldOffset(Offset = "0x34")]
		private int _003Ccount_003E5__3;

		[Token(Token = "0x400213A")]
		[FieldOffset(Offset = "0x38")]
		private float _003CcurrentZ_003E5__4;

		[Token(Token = "0x17000345")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001D50")]
			[Address(RVA = "0x177F924", Offset = "0x177F924", VA = "0x177F924", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000346")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001D52")]
			[Address(RVA = "0x177F96C", Offset = "0x177F96C", VA = "0x177F96C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001D4D")]
		[Address(RVA = "0x177F60C", Offset = "0x177F60C", VA = "0x177F60C")]
		[DebuggerHidden]
		public _003CRollBehindRoutine_003Ed__27(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001D4E")]
		[Address(RVA = "0x177F638", Offset = "0x177F638", VA = "0x177F638", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001D4F")]
		[Address(RVA = "0x177F63C", Offset = "0x177F63C", VA = "0x177F63C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001D50")]
		[Address(RVA = "0x177F924", Offset = "0x177F924", VA = "0x177F924", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001D51")]
		[Address(RVA = "0x177F92C", Offset = "0x177F92C", VA = "0x177F92C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001D52")]
		[Address(RVA = "0x177F96C", Offset = "0x177F96C", VA = "0x177F96C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000668")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40D10", Offset = "0x40D10")]
	private sealed class _003C_003Ec__DisplayClass28_0
	{
		[Token(Token = "0x400213B")]
		[FieldOffset(Offset = "0x10")]
		public bool didPressButton;

		[Token(Token = "0x6001D53")]
		[Address(RVA = "0x177DE30", Offset = "0x177DE30", VA = "0x177DE30")]
		public _003C_003Ec__DisplayClass28_0()
		{
		}

		[Token(Token = "0x6001D54")]
		[Address(RVA = "0x177DE38", Offset = "0x177DE38", VA = "0x177DE38")]
		internal void _003CHoleBehindButtonRoutine_003Eb__0()
		{
		}
	}

	[Token(Token = "0x2000669")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40D20", Offset = "0x40D20")]
	private sealed class _003CHoleBehindButtonRoutine_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400213C")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400213D")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400213E")]
		[FieldOffset(Offset = "0x20")]
		public BusFightPart _003C_003E4__this;

		[Token(Token = "0x400213F")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass28_0 _003C_003E8__1;

		[Token(Token = "0x4002140")]
		[FieldOffset(Offset = "0x30")]
		private int _003Chole_003E5__2;

		[Token(Token = "0x4002141")]
		[FieldOffset(Offset = "0x34")]
		private float _003ClastSpawnZ_003E5__3;

		[Token(Token = "0x4002142")]
		[FieldOffset(Offset = "0x38")]
		private float _003CcurrentZ_003E5__4;

		[Token(Token = "0x17000347")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001D58")]
			[Address(RVA = "0x177E824", Offset = "0x177E824", VA = "0x177E824", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000348")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001D5A")]
			[Address(RVA = "0x177E86C", Offset = "0x177E86C", VA = "0x177E86C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001D55")]
		[Address(RVA = "0x177E4C0", Offset = "0x177E4C0", VA = "0x177E4C0")]
		[DebuggerHidden]
		public _003CHoleBehindButtonRoutine_003Ed__28(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001D56")]
		[Address(RVA = "0x177E4EC", Offset = "0x177E4EC", VA = "0x177E4EC", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001D57")]
		[Address(RVA = "0x177E4F0", Offset = "0x177E4F0", VA = "0x177E4F0", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001D58")]
		[Address(RVA = "0x177E824", Offset = "0x177E824", VA = "0x177E824", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001D59")]
		[Address(RVA = "0x177E82C", Offset = "0x177E82C", VA = "0x177E82C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001D5A")]
		[Address(RVA = "0x177E86C", Offset = "0x177E86C", VA = "0x177E86C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x200066A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40D30", Offset = "0x40D30")]
	private sealed class _003C_003Ec__DisplayClass30_0
	{
		[Token(Token = "0x4002143")]
		[FieldOffset(Offset = "0x10")]
		public Rigidbody spawned;

		[Token(Token = "0x4002144")]
		[FieldOffset(Offset = "0x18")]
		public BusFightPart _003C_003E4__this;

		[Token(Token = "0x4002145")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 endPosition;

		[Token(Token = "0x6001D5B")]
		[Address(RVA = "0x177DE44", Offset = "0x177DE44", VA = "0x177DE44")]
		public _003C_003Ec__DisplayClass30_0()
		{
		}

		[Token(Token = "0x6001D5C")]
		[Address(RVA = "0x177DE4C", Offset = "0x177DE4C", VA = "0x177DE4C")]
		internal void _003CShoot_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x200066B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40D40", Offset = "0x40D40")]
	private sealed class _003CShoot_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002146")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002147")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002148")]
		[FieldOffset(Offset = "0x20")]
		public BusFightPart _003C_003E4__this;

		[Token(Token = "0x4002149")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 endPosition;

		[Token(Token = "0x400214A")]
		[FieldOffset(Offset = "0x34")]
		public bool isClose;

		[Token(Token = "0x400214B")]
		[FieldOffset(Offset = "0x38")]
		private Collider _003Ccol_003E5__2;

		[Token(Token = "0x17000349")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001D60")]
			[Address(RVA = "0x177FDD0", Offset = "0x177FDD0", VA = "0x177FDD0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700034A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001D62")]
			[Address(RVA = "0x177FE18", Offset = "0x177FE18", VA = "0x177FE18", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001D5D")]
		[Address(RVA = "0x177F974", Offset = "0x177F974", VA = "0x177F974")]
		[DebuggerHidden]
		public _003CShoot_003Ed__30(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001D5E")]
		[Address(RVA = "0x177F9A0", Offset = "0x177F9A0", VA = "0x177F9A0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001D5F")]
		[Address(RVA = "0x177F9A4", Offset = "0x177F9A4", VA = "0x177F9A4", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001D60")]
		[Address(RVA = "0x177FDD0", Offset = "0x177FDD0", VA = "0x177FDD0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001D61")]
		[Address(RVA = "0x177FDD8", Offset = "0x177FDD8", VA = "0x177FDD8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001D62")]
		[Address(RVA = "0x177FE18", Offset = "0x177FE18", VA = "0x177FE18", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4002100")]
	[FieldOffset(Offset = "0x18")]
	public BusFightModuleExplosions explosions;

	[Token(Token = "0x4002101")]
	[FieldOffset(Offset = "0x20")]
	public Collider buttonCollider;

	[Token(Token = "0x4002102")]
	[FieldOffset(Offset = "0x28")]
	public BusButton button;

	[Token(Token = "0x4002103")]
	[FieldOffset(Offset = "0x30")]
	public BoxCollider roadCollider;

	[Token(Token = "0x4002104")]
	[FieldOffset(Offset = "0x38")]
	public Transform spawnPosition;

	[Token(Token = "0x4002105")]
	[FieldOffset(Offset = "0x40")]
	public Rigidbody prefab;

	[Token(Token = "0x4002106")]
	[FieldOffset(Offset = "0x48")]
	public BusFightPlayer player;

	[Token(Token = "0x4002107")]
	[FieldOffset(Offset = "0x50")]
	public Pattern pattern;

	[Token(Token = "0x4002108")]
	[FieldOffset(Offset = "0x54")]
	public float spawnDistance;

	[Token(Token = "0x4002109")]
	[FieldOffset(Offset = "0x58")]
	public int spawnCount;

	[Token(Token = "0x400210A")]
	[FieldOffset(Offset = "0x5C")]
	public float randomRotateObstacle;

	[Token(Token = "0x400210B")]
	[FieldOffset(Offset = "0x60")]
	public float upForce;

	[Token(Token = "0x400210C")]
	[FieldOffset(Offset = "0x64")]
	public float xMoveTime;

	[Token(Token = "0x400210D")]
	[FieldOffset(Offset = "0x68")]
	public int cols;

	[Token(Token = "0x400210E")]
	[FieldOffset(Offset = "0x6C")]
	public float sineMovementSpeed;

	[Token(Token = "0x400210F")]
	[FieldOffset(Offset = "0x70")]
	public float speedMultiplier;

	[Token(Token = "0x4002110")]
	[FieldOffset(Offset = "0x78")]
	private Rigidbody rigid;

	[Token(Token = "0x4002111")]
	[FieldOffset(Offset = "0x80")]
	private FixedJoint joint;

	[Token(Token = "0x4002112")]
	[FieldOffset(Offset = "0x88")]
	private Collider[] colliders;

	[Token(Token = "0x6001D1D")]
	[Address(RVA = "0x17D6E80", Offset = "0x17D6E80", VA = "0x17D6E80")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001D1E")]
	[Address(RVA = "0x17D5774", Offset = "0x17D5774", VA = "0x17D5774")]
	public Vector3 GetBackPosition()
	{
		return default;
	}

	[Token(Token = "0x6001D1F")]
	[Address(RVA = "0x17D6F2C", Offset = "0x17D6F2C", VA = "0x17D6F2C")]
	public IEnumerator Dettach()
	{
		return null;
	}

	[Token(Token = "0x6001D20")]
	[Address(RVA = "0x17D6FA0", Offset = "0x17D6FA0", VA = "0x17D6FA0")]
	private IEnumerator LandModuleAfterExplosionsAndCleanUp()
	{
		return null;
	}

	[Token(Token = "0x6001D21")]
	[Address(RVA = "0x17D7014", Offset = "0x17D7014", VA = "0x17D7014")]
	public IEnumerator AttackRoutine()
	{
		return null;
	}

	[Token(Token = "0x6001D22")]
	[Address(RVA = "0x17D7088", Offset = "0x17D7088", VA = "0x17D7088")]
	private IEnumerator InFrontOfPlayerRoutine()
	{
		return null;
	}

	[Token(Token = "0x6001D23")]
	[Address(RVA = "0x17D70FC", Offset = "0x17D70FC", VA = "0x17D70FC")]
	private IEnumerator RandomClustersRoutine()
	{
		return null;
	}

	[Token(Token = "0x6001D24")]
	[Address(RVA = "0x17D7170", Offset = "0x17D7170", VA = "0x17D7170")]
	private IEnumerator RollBehindRoutine()
	{
		return null;
	}

	[Token(Token = "0x6001D25")]
	[Address(RVA = "0x17D71E4", Offset = "0x17D71E4", VA = "0x17D71E4")]
	private IEnumerator HoleBehindButtonRoutine()
	{
		return null;
	}

	[Token(Token = "0x6001D26")]
	[Address(RVA = "0x17D7258", Offset = "0x17D7258", VA = "0x17D7258")]
	private Vector3 GetTargetFromIndex(int i)
	{
		return default;
	}

	[Token(Token = "0x6001D27")]
	[Address(RVA = "0x17D735C", Offset = "0x17D735C", VA = "0x17D735C")]
	private IEnumerator Shoot(Vector3 endPosition, bool isClose)
	{
		return null;
	}

	[Token(Token = "0x6001D28")]
	[Address(RVA = "0x17D73FC", Offset = "0x17D73FC", VA = "0x17D73FC")]
	public BusFightPart()
	{
	}
}
