using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Cinemachine;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000639")]
public class BossSHMUP : MonoBehaviour
{
	[Token(Token = "0x200063A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40AF0", Offset = "0x40AF0")]
	private sealed class _003CStageRoutine_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400204B")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400204C")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400204D")]
		[FieldOffset(Offset = "0x20")]
		public BossSHMUP _003C_003E4__this;

		[Token(Token = "0x1700031F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001C71")]
			[Address(RVA = "0x1779A80", Offset = "0x1779A80", VA = "0x1779A80", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000320")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001C73")]
			[Address(RVA = "0x1779AC8", Offset = "0x1779AC8", VA = "0x1779AC8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001C6E")]
		[Address(RVA = "0x1779890", Offset = "0x1779890", VA = "0x1779890")]
		[DebuggerHidden]
		public _003CStageRoutine_003Ed__20(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001C6F")]
		[Address(RVA = "0x17798BC", Offset = "0x17798BC", VA = "0x17798BC", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001C70")]
		[Address(RVA = "0x17798C0", Offset = "0x17798C0", VA = "0x17798C0", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001C71")]
		[Address(RVA = "0x1779A80", Offset = "0x1779A80", VA = "0x1779A80", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001C72")]
		[Address(RVA = "0x1779A88", Offset = "0x1779A88", VA = "0x1779A88", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001C73")]
		[Address(RVA = "0x1779AC8", Offset = "0x1779AC8", VA = "0x1779AC8", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x200063B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40B00", Offset = "0x40B00")]
	private sealed class _003C_003Ec__DisplayClass22_0
	{
		[Token(Token = "0x400204E")]
		[FieldOffset(Offset = "0x10")]
		public BossSHMUP _003C_003E4__this;

		[Token(Token = "0x400204F")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 bossStartPos;

		[Token(Token = "0x4002050")]
		[FieldOffset(Offset = "0x24")]
		public float sinkDepth;

		[Token(Token = "0x6001C74")]
		[Address(RVA = "0x17774AC", Offset = "0x17774AC", VA = "0x17774AC")]
		public _003C_003Ec__DisplayClass22_0()
		{
		}

		[Token(Token = "0x6001C75")]
		[Address(RVA = "0x17774B4", Offset = "0x17774B4", VA = "0x17774B4")]
		internal void _003CIntroRoutine_003Eb__2(float t)
		{
		}
	}

	[Token(Token = "0x200063C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40B10", Offset = "0x40B10")]
	private sealed class _003C_003Ec__DisplayClass22_1
	{
		[Token(Token = "0x4002051")]
		[FieldOffset(Offset = "0x10")]
		public float maxAmp;

		[Token(Token = "0x6001C76")]
		[Address(RVA = "0x1777558", Offset = "0x1777558", VA = "0x1777558")]
		public _003C_003Ec__DisplayClass22_1()
		{
		}

		[Token(Token = "0x6001C77")]
		[Address(RVA = "0x1777560", Offset = "0x1777560", VA = "0x1777560")]
		internal void _003CIntroRoutine_003Eb__3(float f)
		{
		}

		[Token(Token = "0x6001C78")]
		[Address(RVA = "0x17775CC", Offset = "0x17775CC", VA = "0x17775CC")]
		internal void _003CIntroRoutine_003Eb__4(float f)
		{
		}
	}

	[Token(Token = "0x200063D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40B20", Offset = "0x40B20")]
	private sealed class _003C_003Ec__DisplayClass22_2
	{
		[Token(Token = "0x4002052")]
		[FieldOffset(Offset = "0x10")]
		public BossIslandPart island;

		[Token(Token = "0x4002053")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 startPos;

		[Token(Token = "0x4002054")]
		[FieldOffset(Offset = "0x28")]
		public _003C_003Ec__DisplayClass22_0 CS_0024_003C_003E8__locals1;

		[Token(Token = "0x6001C79")]
		[Address(RVA = "0x1777638", Offset = "0x1777638", VA = "0x1777638")]
		public _003C_003Ec__DisplayClass22_2()
		{
		}

		[Token(Token = "0x6001C7A")]
		[Address(RVA = "0x1777640", Offset = "0x1777640", VA = "0x1777640")]
		internal void _003CIntroRoutine_003Eb__6(float t)
		{
		}
	}

	[Token(Token = "0x200063E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40B30", Offset = "0x40B30")]
	private sealed class _003C_003Ec__DisplayClass22_3
	{
		[Token(Token = "0x4002055")]
		[FieldOffset(Offset = "0x10")]
		public TentacleController tentacle;

		[Token(Token = "0x4002056")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 startPos;

		[Token(Token = "0x4002057")]
		[FieldOffset(Offset = "0x28")]
		public _003C_003Ec__DisplayClass22_0 CS_0024_003C_003E8__locals2;

		[Token(Token = "0x6001C7B")]
		[Address(RVA = "0x17776E0", Offset = "0x17776E0", VA = "0x17776E0")]
		public _003C_003Ec__DisplayClass22_3()
		{
		}

		[Token(Token = "0x6001C7C")]
		[Address(RVA = "0x17776E8", Offset = "0x17776E8", VA = "0x17776E8")]
		internal void _003CIntroRoutine_003Eb__7(float t)
		{
		}
	}

	[Token(Token = "0x200063F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40B40", Offset = "0x40B40")]
	private sealed class _003C_003Ec__DisplayClass22_4
	{
		[Token(Token = "0x4002058")]
		[FieldOffset(Offset = "0x10")]
		public float maxAmp;

		[Token(Token = "0x6001C7D")]
		[Address(RVA = "0x17777A0", Offset = "0x17777A0", VA = "0x17777A0")]
		public _003C_003Ec__DisplayClass22_4()
		{
		}

		[Token(Token = "0x6001C7E")]
		[Address(RVA = "0x17777A8", Offset = "0x17777A8", VA = "0x17777A8")]
		internal void _003CIntroRoutine_003Eb__8(float f)
		{
		}

		[Token(Token = "0x6001C7F")]
		[Address(RVA = "0x1777814", Offset = "0x1777814", VA = "0x1777814")]
		internal void _003CIntroRoutine_003Eb__9(float f)
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000640")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40B50", Offset = "0x40B50")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4002059")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x400205A")]
		[FieldOffset(Offset = "0x8")]
		public static Func<TentacleController, bool> _003C_003E9__22_1;

		[Token(Token = "0x400205B")]
		[FieldOffset(Offset = "0x10")]
		public static Action _003C_003E9__22_5;

		[Token(Token = "0x400205C")]
		[FieldOffset(Offset = "0x18")]
		public static Action _003C_003E9__22_10;

		[Token(Token = "0x6001C81")]
		[Address(RVA = "0x1777424", Offset = "0x1777424", VA = "0x1777424")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6001C82")]
		[Address(RVA = "0x177742C", Offset = "0x177742C", VA = "0x177742C")]
		internal bool _003CIntroRoutine_003Eb__22_1(TentacleController t)
		{
			return default;
		}

		[Token(Token = "0x6001C83")]
		[Address(RVA = "0x177744C", Offset = "0x177744C", VA = "0x177744C")]
		internal void _003CIntroRoutine_003Eb__22_5()
		{
		}

		[Token(Token = "0x6001C84")]
		[Address(RVA = "0x177747C", Offset = "0x177747C", VA = "0x177747C")]
		internal void _003CIntroRoutine_003Eb__22_10()
		{
		}
	}

	[Token(Token = "0x2000641")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40B60", Offset = "0x40B60")]
	private sealed class _003CIntroRoutine_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400205D")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400205E")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400205F")]
		[FieldOffset(Offset = "0x20")]
		public BossSHMUP _003C_003E4__this;

		[Token(Token = "0x4002060")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass22_0 _003C_003E8__1;

		[Token(Token = "0x4002061")]
		[FieldOffset(Offset = "0x30")]
		private List<TentacleController>.Enumerator _003C_003E7__wrap1;

		[Token(Token = "0x17000321")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001C89")]
			[Address(RVA = "0x177921C", Offset = "0x177921C", VA = "0x177921C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000322")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001C8B")]
			[Address(RVA = "0x1779264", Offset = "0x1779264", VA = "0x1779264", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001C85")]
		[Address(RVA = "0x1777880", Offset = "0x1777880", VA = "0x1777880")]
		[DebuggerHidden]
		public _003CIntroRoutine_003Ed__22(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001C86")]
		[Address(RVA = "0x17778AC", Offset = "0x17778AC", VA = "0x17778AC", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001C87")]
		[Address(RVA = "0x1777980", Offset = "0x1777980", VA = "0x1777980", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001C88")]
		[Address(RVA = "0x1777924", Offset = "0x1777924", VA = "0x1777924")]
		private void _003C_003Em__Finally1()
		{
		}

		[Token(Token = "0x6001C89")]
		[Address(RVA = "0x177921C", Offset = "0x177921C", VA = "0x177921C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001C8A")]
		[Address(RVA = "0x1779224", Offset = "0x1779224", VA = "0x1779224", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001C8B")]
		[Address(RVA = "0x1779264", Offset = "0x1779264", VA = "0x1779264", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000642")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40B70", Offset = "0x40B70")]
	private sealed class _003CPlayRoutine_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002062")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002063")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002064")]
		[FieldOffset(Offset = "0x20")]
		public BossSHMUP _003C_003E4__this;

		[Token(Token = "0x17000323")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001C8F")]
			[Address(RVA = "0x1779840", Offset = "0x1779840", VA = "0x1779840", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000324")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001C91")]
			[Address(RVA = "0x1779888", Offset = "0x1779888", VA = "0x1779888", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001C8C")]
		[Address(RVA = "0x1779398", Offset = "0x1779398", VA = "0x1779398")]
		[DebuggerHidden]
		public _003CPlayRoutine_003Ed__23(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001C8D")]
		[Address(RVA = "0x17793C4", Offset = "0x17793C4", VA = "0x17793C4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001C8E")]
		[Address(RVA = "0x17793C8", Offset = "0x17793C8", VA = "0x17793C8", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001C8F")]
		[Address(RVA = "0x1779840", Offset = "0x1779840", VA = "0x1779840", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001C90")]
		[Address(RVA = "0x1779848", Offset = "0x1779848", VA = "0x1779848", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001C91")]
		[Address(RVA = "0x1779888", Offset = "0x1779888", VA = "0x1779888", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000643")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40B80", Offset = "0x40B80")]
	private sealed class _003COutroRoutine_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002065")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002066")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x17000325")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001C95")]
			[Address(RVA = "0x1779348", Offset = "0x1779348", VA = "0x1779348", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000326")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001C97")]
			[Address(RVA = "0x1779390", Offset = "0x1779390", VA = "0x1779390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001C92")]
		[Address(RVA = "0x177926C", Offset = "0x177926C", VA = "0x177926C")]
		[DebuggerHidden]
		public _003COutroRoutine_003Ed__28(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001C93")]
		[Address(RVA = "0x1779298", Offset = "0x1779298", VA = "0x1779298", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001C94")]
		[Address(RVA = "0x177929C", Offset = "0x177929C", VA = "0x177929C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001C95")]
		[Address(RVA = "0x1779348", Offset = "0x1779348", VA = "0x1779348", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001C96")]
		[Address(RVA = "0x1779350", Offset = "0x1779350", VA = "0x1779350", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001C97")]
		[Address(RVA = "0x1779390", Offset = "0x1779390", VA = "0x1779390", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000644")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40B90", Offset = "0x40B90")]
	private sealed class _003C_003CIntroRoutine_003Eg__SmashTentacle_007C22_0_003Ed : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002067")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002068")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002069")]
		[FieldOffset(Offset = "0x20")]
		public TentacleController tentacle;

		[Token(Token = "0x17000327")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001C9B")]
			[Address(RVA = "0x1777374", Offset = "0x1777374", VA = "0x1777374", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000328")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001C9D")]
			[Address(RVA = "0x17773BC", Offset = "0x17773BC", VA = "0x17773BC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001C98")]
		[Address(RVA = "0x1777260", Offset = "0x1777260", VA = "0x1777260")]
		[DebuggerHidden]
		public _003C_003CIntroRoutine_003Eg__SmashTentacle_007C22_0_003Ed(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001C99")]
		[Address(RVA = "0x177728C", Offset = "0x177728C", VA = "0x177728C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001C9A")]
		[Address(RVA = "0x1777290", Offset = "0x1777290", VA = "0x1777290", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001C9B")]
		[Address(RVA = "0x1777374", Offset = "0x1777374", VA = "0x1777374", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001C9C")]
		[Address(RVA = "0x177737C", Offset = "0x177737C", VA = "0x177737C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001C9D")]
		[Address(RVA = "0x17773BC", Offset = "0x17773BC", VA = "0x17773BC", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4002037")]
	[FieldOffset(Offset = "0x18")]
	public Rigidbody Boss;

	[Token(Token = "0x4002038")]
	[FieldOffset(Offset = "0x20")]
	public FinalBoss FinalBoss;

	[Token(Token = "0x4002039")]
	[FieldOffset(Offset = "0x28")]
	public ParticleSystem IntroBubbles;

	[Token(Token = "0x400203A")]
	[FieldOffset(Offset = "0x30")]
	public List<TentacleController> Tentacles;

	[Token(Token = "0x400203B")]
	[FieldOffset(Offset = "0x38")]
	public Rigidbody PreviousBossCar;

	[Token(Token = "0x400203C")]
	[FieldOffset(Offset = "0x40")]
	public SHMUPController Player;

	[Token(Token = "0x400203D")]
	[FieldOffset(Offset = "0x48")]
	public SHMUPFrogKing FrogKing;

	[Token(Token = "0x400203E")]
	[FieldOffset(Offset = "0x50")]
	public GameObject IntroCamerasStandalone;

	[Token(Token = "0x400203F")]
	[FieldOffset(Offset = "0x58")]
	public GameObject IntroCamerasMobile;

	[Token(Token = "0x4002040")]
	[FieldOffset(Offset = "0x60")]
	public GameObject PlayerCamStandalone;

	[Token(Token = "0x4002041")]
	[FieldOffset(Offset = "0x68")]
	public GameObject PlayerCamMobile;

	[Token(Token = "0x4002042")]
	[FieldOffset(Offset = "0x70")]
	public List<GameObject> ObjectsToDisableOnStart;

	[Token(Token = "0x4002043")]
	[FieldOffset(Offset = "0x78")]
	public AudioClipSettings introWaterSFX;

	[Token(Token = "0x4002044")]
	[FieldOffset(Offset = "0x80")]
	public AudioClipSettings tentacleEmergeSFX;

	[Token(Token = "0x4002045")]
	[FieldOffset(Offset = "0x88")]
	public AudioClipSettings islandSinkSFX;

	[Token(Token = "0x4002046")]
	[FieldOffset(Offset = "0x90")]
	public uint emptyWwiseState;

	[Token(Token = "0x4002047")]
	[FieldOffset(Offset = "0x94")]
	public uint bossStateMusic;

	[Token(Token = "0x4002048")]
	[FieldOffset(Offset = "0x98")]
	public bool SkipIntro;

	[Token(Token = "0x4002049")]
	[FieldOffset(Offset = "0xA0")]
	public CinemachineStateDrivenCamera testPlayerCam;

	[Token(Token = "0x400204A")]
	[FieldOffset(Offset = "0xA8")]
	private bool playerEnteredMouth;

	[Token(Token = "0x6001C62")]
	[Address(RVA = "0x1700180", Offset = "0x1700180", VA = "0x1700180")]
	public IEnumerator StageRoutine()
	{
		return null;
	}

	[Token(Token = "0x6001C63")]
	[Address(RVA = "0x17001F4", Offset = "0x17001F4", VA = "0x17001F4")]
	public void Initialize()
	{
	}

	[Token(Token = "0x6001C64")]
	[Address(RVA = "0x1700210", Offset = "0x1700210", VA = "0x1700210")]
	private IEnumerator IntroRoutine()
	{
		return null;
	}

	[Token(Token = "0x6001C65")]
	[Address(RVA = "0x1700284", Offset = "0x1700284", VA = "0x1700284")]
	private IEnumerator PlayRoutine()
	{
		return null;
	}

	[Token(Token = "0x6001C66")]
	[Address(RVA = "0x17002F8", Offset = "0x17002F8", VA = "0x17002F8")]
	private void OnEnterMouth()
	{
	}

	[Token(Token = "0x6001C67")]
	[Address(RVA = "0x1700304", Offset = "0x1700304", VA = "0x1700304")]
	private void OnSinkBefore()
	{
	}

	[Token(Token = "0x6001C68")]
	[Address(RVA = "0x1700320", Offset = "0x1700320", VA = "0x1700320")]
	private void OnSinkAfterTransition()
	{
	}

	[Token(Token = "0x6001C69")]
	[Address(RVA = "0x170033C", Offset = "0x170033C", VA = "0x170033C")]
	private void OnSinkReset()
	{
	}

	[Token(Token = "0x6001C6A")]
	[Address(RVA = "0x1700358", Offset = "0x1700358", VA = "0x1700358")]
	private IEnumerator OutroRoutine()
	{
		return null;
	}

	[Token(Token = "0x6001C6B")]
	[Address(RVA = "0x17003B4", Offset = "0x17003B4", VA = "0x17003B4")]
	public void Cleanup()
	{
	}

	[Token(Token = "0x6001C6C")]
	[Address(RVA = "0x17003F0", Offset = "0x17003F0", VA = "0x17003F0")]
	public BossSHMUP()
	{
	}

	[Token(Token = "0x6001C6D")]
	[Address(RVA = "0x17003F8", Offset = "0x17003F8", VA = "0x17003F8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63FBC", Offset = "0x63FBC")]
	internal static IEnumerator _003CIntroRoutine_003Eg__SmashTentacle_007C22_0(TentacleController tentacle)
	{
		return null;
	}
}
