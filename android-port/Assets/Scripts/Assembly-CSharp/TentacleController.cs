using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

[Token(Token = "0x20006A5")]
public class TentacleController : MonoBehaviour
{
	[Token(Token = "0x20006A6")]
	public enum TentacleStatesEnum
	{
		[Token(Token = "0x40022C3")]
		Hidden = 0,
		[Token(Token = "0x40022C4")]
		Appearing = 1,
		[Token(Token = "0x40022C5")]
		Idle = 2,
		[Token(Token = "0x40022C6")]
		Obstacle = 3,
		[Token(Token = "0x40022C7")]
		Blocking = 4,
		[Token(Token = "0x40022C8")]
		Sinking = 5
	}

	[Token(Token = "0x20006A7")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40F90", Offset = "0x40F90")]
	private sealed class _003CTentacleRoutine_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40022C9")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40022CA")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40022CB")]
		[FieldOffset(Offset = "0x20")]
		public TentacleController _003C_003E4__this;

		[Token(Token = "0x40022CC")]
		[FieldOffset(Offset = "0x28")]
		private IEnumerator _003Cco_003E5__2;

		[Token(Token = "0x1700037D")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001E97")]
			[Address(RVA = "0x1864310", Offset = "0x1864310", VA = "0x1864310", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700037E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001E99")]
			[Address(RVA = "0x1864358", Offset = "0x1864358", VA = "0x1864358", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001E94")]
		[Address(RVA = "0x18641A8", Offset = "0x18641A8", VA = "0x18641A8")]
		[DebuggerHidden]
		public _003CTentacleRoutine_003Ed__9(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001E95")]
		[Address(RVA = "0x18641D4", Offset = "0x18641D4", VA = "0x18641D4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001E96")]
		[Address(RVA = "0x18641D8", Offset = "0x18641D8", VA = "0x18641D8", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001E97")]
		[Address(RVA = "0x1864310", Offset = "0x1864310", VA = "0x1864310", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001E98")]
		[Address(RVA = "0x1864318", Offset = "0x1864318", VA = "0x1864318", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001E99")]
		[Address(RVA = "0x1864358", Offset = "0x1864358", VA = "0x1864358", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x20006A8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40FA0", Offset = "0x40FA0")]
	private sealed class _003CAppearingState_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40022CD")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40022CE")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40022CF")]
		[FieldOffset(Offset = "0x20")]
		public TentacleController _003C_003E4__this;

		[Token(Token = "0x40022D0")]
		[FieldOffset(Offset = "0x28")]
		private float _003CrefVal_003E5__2;

		[Token(Token = "0x40022D1")]
		[FieldOffset(Offset = "0x2C")]
		private float _003Ctimer_003E5__3;

		[Token(Token = "0x40022D2")]
		[FieldOffset(Offset = "0x30")]
		private float _003CmaxTime_003E5__4;

		[Token(Token = "0x1700037F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001E9D")]
			[Address(RVA = "0x186369C", Offset = "0x186369C", VA = "0x186369C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000380")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001E9F")]
			[Address(RVA = "0x18636E4", Offset = "0x18636E4", VA = "0x18636E4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001E9A")]
		[Address(RVA = "0x186343C", Offset = "0x186343C", VA = "0x186343C")]
		[DebuggerHidden]
		public _003CAppearingState_003Ed__11(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001E9B")]
		[Address(RVA = "0x1863468", Offset = "0x1863468", VA = "0x1863468", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001E9C")]
		[Address(RVA = "0x186346C", Offset = "0x186346C", VA = "0x186346C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001E9D")]
		[Address(RVA = "0x186369C", Offset = "0x186369C", VA = "0x186369C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001E9E")]
		[Address(RVA = "0x18636A4", Offset = "0x18636A4", VA = "0x18636A4", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001E9F")]
		[Address(RVA = "0x18636E4", Offset = "0x18636E4", VA = "0x18636E4", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x20006A9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40FB0", Offset = "0x40FB0")]
	private sealed class _003CObstacleRoutine_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40022D3")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40022D4")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40022D5")]
		[FieldOffset(Offset = "0x20")]
		public TentacleController _003C_003E4__this;

		[Token(Token = "0x40022D6")]
		[FieldOffset(Offset = "0x28")]
		private float _003CrefVal_003E5__2;

		[Token(Token = "0x40022D7")]
		[FieldOffset(Offset = "0x2C")]
		private float _003Ctimer_003E5__3;

		[Token(Token = "0x40022D8")]
		[FieldOffset(Offset = "0x30")]
		private IEnumerator _003Cco_003E5__4;

		[Token(Token = "0x40022D9")]
		[FieldOffset(Offset = "0x38")]
		private bool _003CtimerBelowBefore_003E5__5;

		[Token(Token = "0x17000381")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001EA3")]
			[Address(RVA = "0x1863FA0", Offset = "0x1863FA0", VA = "0x1863FA0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000382")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001EA5")]
			[Address(RVA = "0x1863FE8", Offset = "0x1863FE8", VA = "0x1863FE8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001EA0")]
		[Address(RVA = "0x1863C84", Offset = "0x1863C84", VA = "0x1863C84")]
		[DebuggerHidden]
		public _003CObstacleRoutine_003Ed__12(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001EA1")]
		[Address(RVA = "0x1863CB0", Offset = "0x1863CB0", VA = "0x1863CB0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001EA2")]
		[Address(RVA = "0x1863CB4", Offset = "0x1863CB4", VA = "0x1863CB4", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001EA3")]
		[Address(RVA = "0x1863FA0", Offset = "0x1863FA0", VA = "0x1863FA0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001EA4")]
		[Address(RVA = "0x1863FA8", Offset = "0x1863FA8", VA = "0x1863FA8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001EA5")]
		[Address(RVA = "0x1863FE8", Offset = "0x1863FE8", VA = "0x1863FE8", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x20006AA")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40FC0", Offset = "0x40FC0")]
	private sealed class _003CIdleState_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40022DA")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40022DB")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40022DC")]
		[FieldOffset(Offset = "0x20")]
		public TentacleController _003C_003E4__this;

		[Token(Token = "0x40022DD")]
		[FieldOffset(Offset = "0x28")]
		private float _003CrefVal_003E5__2;

		[Token(Token = "0x17000383")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001EA9")]
			[Address(RVA = "0x1863C34", Offset = "0x1863C34", VA = "0x1863C34", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000384")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001EAB")]
			[Address(RVA = "0x1863C7C", Offset = "0x1863C7C", VA = "0x1863C7C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001EA6")]
		[Address(RVA = "0x1863A80", Offset = "0x1863A80", VA = "0x1863A80")]
		[DebuggerHidden]
		public _003CIdleState_003Ed__13(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001EA7")]
		[Address(RVA = "0x1863AAC", Offset = "0x1863AAC", VA = "0x1863AAC", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001EA8")]
		[Address(RVA = "0x1863AB0", Offset = "0x1863AB0", VA = "0x1863AB0", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001EA9")]
		[Address(RVA = "0x1863C34", Offset = "0x1863C34", VA = "0x1863C34", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001EAA")]
		[Address(RVA = "0x1863C3C", Offset = "0x1863C3C", VA = "0x1863C3C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001EAB")]
		[Address(RVA = "0x1863C7C", Offset = "0x1863C7C", VA = "0x1863C7C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x20006AB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40FD0", Offset = "0x40FD0")]
	private sealed class _003CHiddenState_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40022DE")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40022DF")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40022E0")]
		[FieldOffset(Offset = "0x20")]
		public TentacleController _003C_003E4__this;

		[Token(Token = "0x17000385")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001EAF")]
			[Address(RVA = "0x1863A30", Offset = "0x1863A30", VA = "0x1863A30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000386")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001EB1")]
			[Address(RVA = "0x1863A78", Offset = "0x1863A78", VA = "0x1863A78", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001EAC")]
		[Address(RVA = "0x1863978", Offset = "0x1863978", VA = "0x1863978")]
		[DebuggerHidden]
		public _003CHiddenState_003Ed__14(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001EAD")]
		[Address(RVA = "0x18639A4", Offset = "0x18639A4", VA = "0x18639A4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001EAE")]
		[Address(RVA = "0x18639A8", Offset = "0x18639A8", VA = "0x18639A8", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001EAF")]
		[Address(RVA = "0x1863A30", Offset = "0x1863A30", VA = "0x1863A30", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001EB0")]
		[Address(RVA = "0x1863A38", Offset = "0x1863A38", VA = "0x1863A38", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001EB1")]
		[Address(RVA = "0x1863A78", Offset = "0x1863A78", VA = "0x1863A78", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x20006AC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40FE0", Offset = "0x40FE0")]
	private sealed class _003CBlockingState_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40022E1")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40022E2")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40022E3")]
		[FieldOffset(Offset = "0x20")]
		public TentacleController _003C_003E4__this;

		[Token(Token = "0x40022E4")]
		[FieldOffset(Offset = "0x28")]
		private float _003CrefVal_003E5__2;

		[Token(Token = "0x17000387")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001EB5")]
			[Address(RVA = "0x1863928", Offset = "0x1863928", VA = "0x1863928", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000388")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001EB7")]
			[Address(RVA = "0x1863970", Offset = "0x1863970", VA = "0x1863970", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001EB2")]
		[Address(RVA = "0x18636EC", Offset = "0x18636EC", VA = "0x18636EC")]
		[DebuggerHidden]
		public _003CBlockingState_003Ed__15(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001EB3")]
		[Address(RVA = "0x1863718", Offset = "0x1863718", VA = "0x1863718", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001EB4")]
		[Address(RVA = "0x186371C", Offset = "0x186371C", VA = "0x186371C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001EB5")]
		[Address(RVA = "0x1863928", Offset = "0x1863928", VA = "0x1863928", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001EB6")]
		[Address(RVA = "0x1863930", Offset = "0x1863930", VA = "0x1863930", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001EB7")]
		[Address(RVA = "0x1863970", Offset = "0x1863970", VA = "0x1863970", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x20006AD")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40FF0", Offset = "0x40FF0")]
	private sealed class _003CSinkState_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40022E5")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40022E6")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40022E7")]
		[FieldOffset(Offset = "0x20")]
		public TentacleController _003C_003E4__this;

		[Token(Token = "0x40022E8")]
		[FieldOffset(Offset = "0x28")]
		private float _003Ctimer_003E5__2;

		[Token(Token = "0x40022E9")]
		[FieldOffset(Offset = "0x2C")]
		private float _003CmaxTime_003E5__3;

		[Token(Token = "0x40022EA")]
		[FieldOffset(Offset = "0x30")]
		private float _003CrefVal_003E5__4;

		[Token(Token = "0x17000389")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001EBB")]
			[Address(RVA = "0x1864158", Offset = "0x1864158", VA = "0x1864158", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700038A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001EBD")]
			[Address(RVA = "0x18641A0", Offset = "0x18641A0", VA = "0x18641A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001EB8")]
		[Address(RVA = "0x1863FF0", Offset = "0x1863FF0", VA = "0x1863FF0")]
		[DebuggerHidden]
		public _003CSinkState_003Ed__16(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001EB9")]
		[Address(RVA = "0x186401C", Offset = "0x186401C", VA = "0x186401C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001EBA")]
		[Address(RVA = "0x1864020", Offset = "0x1864020", VA = "0x1864020", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001EBB")]
		[Address(RVA = "0x1864158", Offset = "0x1864158", VA = "0x1864158", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001EBC")]
		[Address(RVA = "0x1864160", Offset = "0x1864160", VA = "0x1864160", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001EBD")]
		[Address(RVA = "0x18641A0", Offset = "0x18641A0", VA = "0x18641A0", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40022BD")]
	[FieldOffset(Offset = "0x18")]
	public CCDIK Tentacle;

	[Token(Token = "0x40022BE")]
	[FieldOffset(Offset = "0x20")]
	public float BlockRange;

	[Token(Token = "0x40022BF")]
	[FieldOffset(Offset = "0x24")]
	public Vector2 BaseWeightRange;

	[Token(Token = "0x40022C0")]
	[FieldOffset(Offset = "0x30")]
	private IEnumerator currentStateRoutine;

	[Token(Token = "0x40022C1")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private TentacleStatesEnum state;

	[Token(Token = "0x6001E87")]
	[Address(RVA = "0x170EF50", Offset = "0x170EF50", VA = "0x170EF50")]
	private void Start()
	{
	}

	[Token(Token = "0x6001E88")]
	[Address(RVA = "0x170F040", Offset = "0x170F040", VA = "0x170F040")]
	public void SetState(TentacleStatesEnum newState)
	{
	}

	[Token(Token = "0x6001E89")]
	[Address(RVA = "0x170F048", Offset = "0x170F048", VA = "0x170F048")]
	public TentacleStatesEnum GetState()
	{
		return default;
	}

	[Token(Token = "0x6001E8A")]
	[Address(RVA = "0x170EFCC", Offset = "0x170EFCC", VA = "0x170EFCC")]
	private IEnumerator TentacleRoutine()
	{
		return null;
	}

	[Token(Token = "0x6001E8B")]
	[Address(RVA = "0x170F050", Offset = "0x170F050", VA = "0x170F050")]
	private IEnumerator GetNextState()
	{
		return null;
	}

	[Token(Token = "0x6001E8C")]
	[Address(RVA = "0x170F320", Offset = "0x170F320", VA = "0x170F320")]
	private IEnumerator AppearingState()
	{
		return null;
	}

	[Token(Token = "0x6001E8D")]
	[Address(RVA = "0x170F408", Offset = "0x170F408", VA = "0x170F408")]
	private IEnumerator ObstacleRoutine()
	{
		return null;
	}

	[Token(Token = "0x6001E8E")]
	[Address(RVA = "0x170F394", Offset = "0x170F394", VA = "0x170F394")]
	private IEnumerator IdleState()
	{
		return null;
	}

	[Token(Token = "0x6001E8F")]
	[Address(RVA = "0x170F2AC", Offset = "0x170F2AC", VA = "0x170F2AC")]
	private IEnumerator HiddenState()
	{
		return null;
	}

	[Token(Token = "0x6001E90")]
	[Address(RVA = "0x170F47C", Offset = "0x170F47C", VA = "0x170F47C")]
	private IEnumerator BlockingState()
	{
		return null;
	}

	[Token(Token = "0x6001E91")]
	[Address(RVA = "0x170F4F0", Offset = "0x170F4F0", VA = "0x170F4F0")]
	private IEnumerator SinkState()
	{
		return null;
	}

	[Token(Token = "0x6001E92")]
	[Address(RVA = "0x170F564", Offset = "0x170F564", VA = "0x170F564")]
	public TentacleController()
	{
	}

	[Token(Token = "0x6001E93")]
	[Address(RVA = "0x170F588", Offset = "0x170F588", VA = "0x170F588")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64FCC", Offset = "0x64FCC")]
	private void _003CObstacleRoutine_003Eb__12_0(float t)
	{
	}
}
