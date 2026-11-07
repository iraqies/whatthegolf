using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Rewired.Interfaces;
using UnityEngine;

namespace Rewired
{
	public sealed class Keyboard : ControllerWithMap
	{
		private sealed class yuYWUacflKxmBhmfoesMsBjdZOOb : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo>, IDisposable, IEnumerable, IEnumerator
		{
			private int RxAoyfYzYDsYonLGXsvUgwChukLk;

			private ControllerPollingInfo VqEePGSMyrGKIqkWibsjeHcWPSIx;

			private int wLBvvzlDcbAEPyDfgnprolEZBsgN;

			public Keyboard TtytLoUfsgUyhsklaKccrnoMiiek;

			private int sArDJaApjHHOXVwYydQNgVrLbneLA;

			private int fIMVaffCgsuIJcnrkMmGGKfPwwel;

			ControllerPollingInfo IEnumerator<ControllerPollingInfo>.Current
			{
				[DebuggerHidden]
				get
				{
					return default;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public yuYWUacflKxmBhmfoesMsBjdZOOb(int P_0)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[DebuggerHidden]
			IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		private sealed class LglsUBPFysTsItjzpEZCVsaBmKzO : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo>, IDisposable, IEnumerable, IEnumerator
		{
			private int RxAoyfYzYDsYonLGXsvUgwChukLk;

			private ControllerPollingInfo VqEePGSMyrGKIqkWibsjeHcWPSIx;

			private int wLBvvzlDcbAEPyDfgnprolEZBsgN;

			public Keyboard TtytLoUfsgUyhsklaKccrnoMiiek;

			private int sArDJaApjHHOXVwYydQNgVrLbneLA;

			private int fIMVaffCgsuIJcnrkMmGGKfPwwel;

			ControllerPollingInfo IEnumerator<ControllerPollingInfo>.Current
			{
				[DebuggerHidden]
				get
				{
					return default;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public LglsUBPFysTsItjzpEZCVsaBmKzO(int P_0)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[DebuggerHidden]
			IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		private static Keyboard JJpYEzvjUtGECvHgvcGIgXvyVWiSA;

		private readonly IUnifiedKeyboardSource eyyVWBZaxsCJCQMmwhCWcagfYfzWA;

		private ModifierKeyFlags boVDfwknXCoctMvohoPrHRSiyPbi;

		private ModifierKeyFlags XwpuFFBHeLMpRjDvJfMDQJtOXKjA;

		private Func<KeyboardKeyCode, int> ifrWFigIsftrgtIztMiWvrvQQqL;

		private readonly int[] eDsnovpgDYRCEkItkogoNDRSYMgr;

		private static KeyboardKeyCode[] fzwYAxzrcqhmaApcRmPhwHCTgEfKA;

		private readonly int ioJHYiWACZZkkzZeFRiOwxJFfdQw;

		private static Guid prVaMvCMokqAbWLeJcbpooSHlNBE;

		private static KeyboardKeyCode[] ogbVLzWCRfeTihmGeCdFpUNKDXuPA => jlrqnrGWuWAiuOVPCwaNTaskOrpr();

		public override Guid deviceInstanceGuid => default;

		private static KeyboardKeyCode[] jlrqnrGWuWAiuOVPCwaNTaskOrpr()
		{
			return null;
		}

		internal Keyboard(string P_0, IUnifiedKeyboardSource P_1)
			: base(0, InputSource.None, null, null, null, ControllerType.Keyboard, default, 0, null, null, null, null)
		{
		}

		private Keyboard(int P_0, InputSource P_1, string P_2, string P_3, HardwareControllerMap_Game P_4, int P_5, Extension P_6, ControllerDataUpdater P_7)
			: base(0, InputSource.None, null, null, null, ControllerType.Keyboard, default, 0, null, null, null, null)
		{
		}

		public bool GetKey(KeyCode keyCode)
		{
			return false;
		}

		public bool GetKeyDown(KeyCode keyCode)
		{
			return false;
		}

		public double GetKeyTimePressed(KeyCode keyCode)
		{
			return 0.0;
		}

		public double GetModifierKeyTimePressed(ModifierKey key)
		{
			return 0.0;
		}

		public KeyCode GetKeyCodeByButtonIndex(int buttonIndex)
		{
			return KeyCode.None;
		}

		public KeyCode GetKeyCodeById(int elementIdentifierId)
		{
			return KeyCode.None;
		}

		public IEnumerable<ControllerPollingInfo> PollForAllKeys()
		{
			return null;
		}

		public IEnumerable<ControllerPollingInfo> PollForAllKeysDown()
		{
			return null;
		}

		public override IEnumerable<ControllerPollingInfo> PollForAllButtonsDown()
		{
			return null;
		}

		public static bool IsModifierKey(KeyCode key)
		{
			return false;
		}

		internal static bool trZafsVxHDJMaoTvWPAzFzJbrlbl(KeyboardKeyCode P_0)
		{
			return false;
		}

		public static ModifierKeyFlags KeyCodeToModifierKeyFlags(KeyCode key)
		{
			return ModifierKeyFlags.None;
		}

		public static bool ModifierKeyFlagsContain(ModifierKeyFlags flags, ModifierKey key)
		{
			return false;
		}

		public static bool ModifierKeyFlagsContain(ModifierKeyFlags flags, KeyCode key)
		{
			return false;
		}

		public static ModifierKeyFlags ModifierKeyToModifierKeyFlags(ModifierKey key)
		{
			return ModifierKeyFlags.None;
		}

		public static string GetKeyName(KeyCode key)
		{
			return null;
		}

		public static string GetKeyName(KeyCode key, ModifierKeyFlags flags)
		{
			return null;
		}

		public static string ModifierKeyFlagsToString(ModifierKeyFlags flags, bool abbreviate)
		{
			return null;
		}

		public static string ModifierKeyFlagsToString(ModifierKeyFlags flags)
		{
			return null;
		}

		internal static KeyboardKeyCode lbKrYDonKuonbZuyvZjwCetiVeki(KeyCode P_0)
		{
			return KeyboardKeyCode.None;
		}

		internal static KeyCode JopyRNKJDwgoEWSurnWzJODKdzOk(KeyboardKeyCode P_0)
		{
			return KeyCode.None;
		}

		internal static ModifierKeyFlags mKNIIexTHIbsnigjJPesRfqSFIzkA(ModifierKeyFlags P_0)
		{
			return ModifierKeyFlags.None;
		}

		internal static int HVRdbMGJASvNJRKWhACVREVAjGDe(ModifierKeyFlags P_0)
		{
			return 0;
		}

		internal static KeyboardKeyCode GetKeyboardKeyCodeByButtonIndex(int buttonIndex)
		{
			return KeyboardKeyCode.None;
		}

		internal static int qLwqAFVXIrkFTLxKuwVLiCCndNbkA(KeyboardKeyCode P_0)
		{
			return 0;
		}

		internal static void CYCUDNoanHYzGAabMMwoCdyIUash(ref int P_0, ref KeyCode P_1)
		{
		}

		internal override void PwSVyxiNOmkyuuXUHWyuymUyabog(UpdateLoopType P_0)
		{
		}

		internal void DtgpVXPyTPhskVKHNnJAXrucMrXt(UpdateLoopType P_0)
		{
		}

		internal bool NqnspTmKVTuOenOXgaESJYqWWgyMA(KeyboardKeyCode P_0)
		{
			return false;
		}

		internal bool ngSbgQwwHNlDRfcEWdGhCacxQsPyA(KeyboardKeyCode P_0, ModifierKeyFlags P_1)
		{
			return false;
		}

		internal int GetButtonIndex(KeyboardKeyCode keyCode)
		{
			return 0;
		}

		internal override void dSUizcQaOGnPQOOBZVgCNLRSewAe(ControllerMap controllerMap)
		{
		}

		internal override void JpxRPMmkCiJxotCLchUqPLcjlZiQ(ControllerMap controllerMap, ActionElementMap map)
		{
		}

		internal override void SPGTRPyvIslcMdbPTItsewSLRPxx()
		{
		}

		internal override bool RQRRqZiAdoXIQMUtzTIWsndPGdwX(bool P_0)
		{
			return false;
		}

		private bool WlSFvyDKnvpozxUvgdMGAIblCodzA(out Button P_0, out Button P_1, ModifierKey P_2)
		{
			P_0 = null;
			P_1 = null;
			return false;
		}

		private void JWatcBsgqUJfAeASrBdOcCtHeoGCA()
		{
		}
	}
}
