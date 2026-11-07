using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using WhatTheGolf.LevelDesigner.Events;

namespace WhatTheGolf.LevelDesigner.GUI
{
	[Token(Token = "0x200129E")]
	public class SaveOnExitGUI : BaseGUI, IRequireEvents<GameStateEvent>, IRequireEvents
	{
		[Token(Token = "0x200129F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x488DC", Offset = "0x488DC")]
		private sealed class _003CSaveCo_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4006488")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4006489")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400648A")]
			[FieldOffset(Offset = "0x20")]
			public SaveOnExitGUI _003C_003E4__this;

			[Token(Token = "0x400648B")]
			[FieldOffset(Offset = "0x28")]
			private float _003CendTime_003E5__2;

			[Token(Token = "0x170009D7")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6005675")]
				[Address(RVA = "0x183DF44", Offset = "0x183DF44", VA = "0x183DF44", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170009D8")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6005677")]
				[Address(RVA = "0x183DF8C", Offset = "0x183DF8C", VA = "0x183DF8C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6005672")]
			[Address(RVA = "0x183DCA4", Offset = "0x183DCA4", VA = "0x183DCA4")]
			[DebuggerHidden]
			public _003CSaveCo_003Ed__14(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6005673")]
			[Address(RVA = "0x183DCD0", Offset = "0x183DCD0", VA = "0x183DCD0", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6005674")]
			[Address(RVA = "0x183DCD4", Offset = "0x183DCD4", VA = "0x183DCD4", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6005675")]
			[Address(RVA = "0x183DF44", Offset = "0x183DF44", VA = "0x183DF44", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6005676")]
			[Address(RVA = "0x183DF4C", Offset = "0x183DF4C", VA = "0x183DF4C", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6005677")]
			[Address(RVA = "0x183DF8C", Offset = "0x183DF8C", VA = "0x183DF8C", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x400647E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Button closeButton;

		[Token(Token = "0x400647F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Button backButton;

		[Token(Token = "0x4006480")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Button saveButton;

		[Token(Token = "0x4006481")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Button dontSaveButton;

		[Token(Token = "0x4006482")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject warningGroup;

		[Token(Token = "0x4006483")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject savingGroup;

		[Token(Token = "0x4006484")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform savingProgressBar;

		[Token(Token = "0x4006485")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private float savingDuration;

		[Token(Token = "0x4006486")]
		[FieldOffset(Offset = "0x7C")]
		private bool isSaving;

		[Token(Token = "0x4006487")]
		[FieldOffset(Offset = "0x80")]
		private CallbackArgs callbackArgs;

		[Token(Token = "0x170009D6")]
		public override bool isActiveOnOpen
		{
			[Token(Token = "0x6005667")]
			[Address(RVA = "0x1676AB0", Offset = "0x1676AB0", VA = "0x1676AB0", Slot = "4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6005668")]
		[Address(RVA = "0x1676AB8", Offset = "0x1676AB8", VA = "0x1676AB8", Slot = "6")]
		public override void Init()
		{
		}

		[Token(Token = "0x6005669")]
		[Address(RVA = "0x1676C38", Offset = "0x1676C38", VA = "0x1676C38", Slot = "7")]
		public void OnEvent(GameStateEvent evt)
		{
		}

		[Token(Token = "0x600566A")]
		[Address(RVA = "0x1676DE4", Offset = "0x1676DE4", VA = "0x1676DE4")]
		private IEnumerator SaveCo()
		{
			return null;
		}

		[Token(Token = "0x600566B")]
		[Address(RVA = "0x1676E58", Offset = "0x1676E58", VA = "0x1676E58")]
		private void HandleBack()
		{
		}

		[Token(Token = "0x600566C")]
		[Address(RVA = "0x1676F60", Offset = "0x1676F60", VA = "0x1676F60")]
		private void HandleSave()
		{
		}

		[Token(Token = "0x600566D")]
		[Address(RVA = "0x1676FF4", Offset = "0x1676FF4", VA = "0x1676FF4")]
		private void HandleDontSave()
		{
		}

		[Token(Token = "0x600566E")]
		[Address(RVA = "0x1676D58", Offset = "0x1676D58", VA = "0x1676D58")]
		private void Show()
		{
		}

		[Token(Token = "0x600566F")]
		[Address(RVA = "0x1676E90", Offset = "0x1676E90", VA = "0x1676E90")]
		private void Hide()
		{
		}

		[Token(Token = "0x6005670")]
		[Address(RVA = "0x167702C", Offset = "0x167702C", VA = "0x167702C")]
		private void Disable()
		{
		}

		[Token(Token = "0x6005671")]
		[Address(RVA = "0x167714C", Offset = "0x167714C", VA = "0x167714C")]
		public SaveOnExitGUI()
		{
		}
	}
}
