using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using Il2CppDummyDll;
using UnityEngine;

namespace PlayFab.Public
{
	[Token(Token = "0x20011B7")]
	public abstract class PlayFabLoggerBase : IPlayFabLogger
	{
		[Token(Token = "0x20011B8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4825C", Offset = "0x4825C")]
		private sealed class _003CRegisterLogger_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4005F43")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4005F44")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4005F45")]
			[FieldOffset(Offset = "0x20")]
			public PlayFabLoggerBase _003C_003E4__this;

			[Token(Token = "0x170008B8")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6005103")]
				[Address(RVA = "0x18281D0", Offset = "0x18281D0", VA = "0x18281D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170008B9")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6005105")]
				[Address(RVA = "0x1828218", Offset = "0x1828218", VA = "0x1828218", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6005100")]
			[Address(RVA = "0x1828074", Offset = "0x1828074", VA = "0x1828074")]
			[DebuggerHidden]
			public _003CRegisterLogger_003Ed__23(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6005101")]
			[Address(RVA = "0x18280A0", Offset = "0x18280A0", VA = "0x18280A0", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6005102")]
			[Address(RVA = "0x18280A4", Offset = "0x18280A4", VA = "0x18280A4", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6005103")]
			[Address(RVA = "0x18281D0", Offset = "0x18281D0", VA = "0x18281D0", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6005104")]
			[Address(RVA = "0x18281D8", Offset = "0x18281D8", VA = "0x18281D8", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6005105")]
			[Address(RVA = "0x1828218", Offset = "0x1828218", VA = "0x1828218", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4005F3B")]
		[FieldOffset(Offset = "0x0")]
		private static readonly StringBuilder Sb;

		[Token(Token = "0x4005F3C")]
		[FieldOffset(Offset = "0x10")]
		private readonly Queue<string> LogMessageQueue;

		[Token(Token = "0x4005F3D")]
		[FieldOffset(Offset = "0x18")]
		private Thread _writeLogThread;

		[Token(Token = "0x4005F3E")]
		[FieldOffset(Offset = "0x20")]
		private readonly object _threadLock;

		[Token(Token = "0x4005F3F")]
		[FieldOffset(Offset = "0x8")]
		private static readonly TimeSpan _threadKillTimeout;

		[Token(Token = "0x4005F40")]
		[FieldOffset(Offset = "0x28")]
		private DateTime _threadKillTime;

		[Token(Token = "0x4005F41")]
		[FieldOffset(Offset = "0x30")]
		private bool _isApplicationPlaying;

		[Token(Token = "0x4005F42")]
		[FieldOffset(Offset = "0x34")]
		private int _pendingLogsCount;

		[Token(Token = "0x60050F4")]
		[Address(RVA = "0x15EEC40", Offset = "0x15EEC40", VA = "0x15EEC40")]
		protected PlayFabLoggerBase()
		{
		}

		[Token(Token = "0x60050F5")]
		[Address(RVA = "0x15EEE9C", Offset = "0x15EEE9C", VA = "0x15EEE9C", Slot = "7")]
		public virtual void OnEnable()
		{
		}

		[Token(Token = "0x60050F6")]
		[Address(RVA = "0x15EEF50", Offset = "0x15EEF50", VA = "0x15EEF50")]
		private IEnumerator RegisterLogger()
		{
			return null;
		}

		[Token(Token = "0x60050F7")]
		[Address(RVA = "0x15EEFC4", Offset = "0x15EEFC4", VA = "0x15EEFC4", Slot = "8")]
		public virtual void OnDisable()
		{
		}

		[Token(Token = "0x60050F8")]
		[Address(RVA = "0x15EF140", Offset = "0x15EF140", VA = "0x15EF140", Slot = "9")]
		public virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60050F9")]
		protected abstract void BeginUploadLog();

		[Token(Token = "0x60050FA")]
		protected abstract void UploadLog(string message);

		[Token(Token = "0x60050FB")]
		protected abstract void EndUploadLog();

		[Token(Token = "0x60050FC")]
		[Address(RVA = "0x15EF148", Offset = "0x15EF148", VA = "0x15EF148")]
		private void HandleUnityLog(string message, string stacktrace, LogType type)
		{
		}

		[Token(Token = "0x60050FD")]
		[Address(RVA = "0x15EF63C", Offset = "0x15EF63C", VA = "0x15EF63C")]
		private void ActivateThreadWorker()
		{
		}

		[Token(Token = "0x60050FE")]
		[Address(RVA = "0x15EF7B8", Offset = "0x15EF7B8", VA = "0x15EF7B8")]
		private void WriteLogThreadWorker()
		{
		}
	}
}
