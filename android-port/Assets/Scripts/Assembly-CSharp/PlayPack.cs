using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E90")]
public class PlayPack : MonoBehaviour
{
	[Token(Token = "0x2000E91")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x450F8", Offset = "0x450F8")]
	private sealed class _003C_003Ec__DisplayClass2_0
	{
		[Token(Token = "0x4004EB1")]
		[FieldOffset(Offset = "0x10")]
		public PlayPack _003C_003E4__this;

		[Token(Token = "0x4004EB2")]
		[FieldOffset(Offset = "0x18")]
		public List<LevelDataAndChallenge> levelsToPlay;

		[Token(Token = "0x4004EB3")]
		[FieldOffset(Offset = "0x20")]
		public bool aborted;

		[Token(Token = "0x4004EB4")]
		[FieldOffset(Offset = "0x28")]
		public Action _003C_003E9__1;

		[Token(Token = "0x6004405")]
		[Address(RVA = "0x18282E4", Offset = "0x18282E4", VA = "0x18282E4")]
		public _003C_003Ec__DisplayClass2_0()
		{
		}

		[Token(Token = "0x6004406")]
		[Address(RVA = "0x18282EC", Offset = "0x18282EC", VA = "0x18282EC")]
		internal void _003CPlayShowToAFriendLevels_003Eb__1()
		{
		}
	}

	[Token(Token = "0x2000E92")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x45108", Offset = "0x45108")]
	private sealed class _003C_003Ec__DisplayClass2_1
	{
		[Token(Token = "0x4004EB5")]
		[FieldOffset(Offset = "0x10")]
		public int i;

		[Token(Token = "0x4004EB6")]
		[FieldOffset(Offset = "0x18")]
		public _003C_003Ec__DisplayClass2_0 CS_0024_003C_003E8__locals1;

		[Token(Token = "0x6004407")]
		[Address(RVA = "0x18282F8", Offset = "0x18282F8", VA = "0x18282F8")]
		public _003C_003Ec__DisplayClass2_1()
		{
		}

		[Token(Token = "0x6004408")]
		[Address(RVA = "0x1828300", Offset = "0x1828300", VA = "0x1828300")]
		internal void _003CPlayShowToAFriendLevels_003Eb__2(bool isCompleted)
		{
		}
	}

	[Token(Token = "0x2000E93")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x45118", Offset = "0x45118")]
	private sealed class _003C_003Ec__DisplayClass2_2
	{
		[Token(Token = "0x4004EB7")]
		[FieldOffset(Offset = "0x10")]
		public LevelDataAndChallenge levelc;

		[Token(Token = "0x4004EB8")]
		[FieldOffset(Offset = "0x18")]
		public _003C_003Ec__DisplayClass2_1 CS_0024_003C_003E8__locals2;

		[Token(Token = "0x6004409")]
		[Address(RVA = "0x1828570", Offset = "0x1828570", VA = "0x1828570")]
		public _003C_003Ec__DisplayClass2_2()
		{
		}

		[Token(Token = "0x600440A")]
		[Address(RVA = "0x1828578", Offset = "0x1828578", VA = "0x1828578")]
		internal void _003CPlayShowToAFriendLevels_003Eb__0(Level.CompletedState s)
		{
		}
	}

	[Token(Token = "0x2000E94")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x45128", Offset = "0x45128")]
	private sealed class _003CPlayShowToAFriendLevels_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004EB9")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004EBA")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004EBB")]
		[FieldOffset(Offset = "0x20")]
		public PlayPack _003C_003E4__this;

		[Token(Token = "0x4004EBC")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass2_0 _003C_003E8__1;

		[Token(Token = "0x4004EBD")]
		[FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass2_1 _003C_003E8__2;

		[Token(Token = "0x4004EBE")]
		[FieldOffset(Offset = "0x38")]
		private LevelManager _003ClevelManager_003E5__2;

		[Token(Token = "0x170006F8")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600440E")]
			[Address(RVA = "0x1828B54", Offset = "0x1828B54", VA = "0x1828B54", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170006F9")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6004410")]
			[Address(RVA = "0x1828B9C", Offset = "0x1828B9C", VA = "0x1828B9C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600440B")]
		[Address(RVA = "0x1828640", Offset = "0x1828640", VA = "0x1828640")]
		[DebuggerHidden]
		public _003CPlayShowToAFriendLevels_003Ed__2(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600440C")]
		[Address(RVA = "0x182866C", Offset = "0x182866C", VA = "0x182866C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600440D")]
		[Address(RVA = "0x1828670", Offset = "0x1828670", VA = "0x1828670", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600440E")]
		[Address(RVA = "0x1828B54", Offset = "0x1828B54", VA = "0x1828B54", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600440F")]
		[Address(RVA = "0x1828B5C", Offset = "0x1828B5C", VA = "0x1828B5C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6004410")]
		[Address(RVA = "0x1828B9C", Offset = "0x1828B9C", VA = "0x1828B9C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4004EB0")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private DailyChallengeLevelDataContainer _container;

	[Token(Token = "0x6004402")]
	[Address(RVA = "0x15F49C8", Offset = "0x15F49C8", VA = "0x15F49C8")]
	private void Start()
	{
	}

	[Token(Token = "0x6004403")]
	[Address(RVA = "0x15F4A44", Offset = "0x15F4A44", VA = "0x15F4A44")]
	public IEnumerator PlayShowToAFriendLevels()
	{
		return null;
	}

	[Token(Token = "0x6004404")]
	[Address(RVA = "0x15F4AB8", Offset = "0x15F4AB8", VA = "0x15F4AB8")]
	public PlayPack()
	{
	}
}
