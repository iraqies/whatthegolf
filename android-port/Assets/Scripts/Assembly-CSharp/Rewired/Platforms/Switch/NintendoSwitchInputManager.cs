using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Rewired.Utils.Interfaces;
using UnityEngine;

namespace Rewired.Platforms.Switch
{
	[Token(Token = "0x2001139")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x47C78", Offset = "0x47C78")]
	public sealed class NintendoSwitchInputManager : MonoBehaviour, IExternalInputManager
	{
		[Serializable]
		[Token(Token = "0x200113A")]
		private class UserData
		{
			[Token(Token = "0x4005AF6")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private int _allowedNpadStyles;

			[Token(Token = "0x4005AF7")]
			[FieldOffset(Offset = "0x14")]
			[SerializeField]
			private int _joyConGripStyle;

			[Token(Token = "0x4005AF8")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private bool _adjustIMUsForGripStyle;

			[Token(Token = "0x4005AF9")]
			[FieldOffset(Offset = "0x1C")]
			[SerializeField]
			private int _handheldActivationMode;

			[Token(Token = "0x4005AFA")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private bool _assignJoysticksByNpadId;

			[Token(Token = "0x4005AFB")]
			[FieldOffset(Offset = "0x21")]
			[SerializeField]
			private bool _useVibrationThread;

			[Token(Token = "0x4005AFC")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private NpadSettings_Internal _npadNo1;

			[Token(Token = "0x4005AFD")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			private NpadSettings_Internal _npadNo2;

			[Token(Token = "0x4005AFE")]
			[FieldOffset(Offset = "0x38")]
			[SerializeField]
			private NpadSettings_Internal _npadNo3;

			[Token(Token = "0x4005AFF")]
			[FieldOffset(Offset = "0x40")]
			[SerializeField]
			private NpadSettings_Internal _npadNo4;

			[Token(Token = "0x4005B00")]
			[FieldOffset(Offset = "0x48")]
			[SerializeField]
			private NpadSettings_Internal _npadNo5;

			[Token(Token = "0x4005B01")]
			[FieldOffset(Offset = "0x50")]
			[SerializeField]
			private NpadSettings_Internal _npadNo6;

			[Token(Token = "0x4005B02")]
			[FieldOffset(Offset = "0x58")]
			[SerializeField]
			private NpadSettings_Internal _npadNo7;

			[Token(Token = "0x4005B03")]
			[FieldOffset(Offset = "0x60")]
			[SerializeField]
			private NpadSettings_Internal _npadNo8;

			[Token(Token = "0x4005B04")]
			[FieldOffset(Offset = "0x68")]
			[SerializeField]
			private NpadSettings_Internal _npadHandheld;

			[Token(Token = "0x4005B05")]
			[FieldOffset(Offset = "0x70")]
			[SerializeField]
			private DebugPadSettings_Internal _debugPad;

			[Token(Token = "0x4005B06")]
			[FieldOffset(Offset = "0x78")]
			private Dictionary<int, object[]> __delegates;

			[Token(Token = "0x6004D95")]
			[Address(RVA = "0x1806928", Offset = "0x1806928", VA = "0x1806928")]
			public UserData()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200113B")]
		private sealed class NpadSettings_Internal
		{
			[Token(Token = "0x4005B07")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private bool _isAllowed;

			[Token(Token = "0x4005B08")]
			[FieldOffset(Offset = "0x14")]
			[SerializeField]
			private int _rewiredPlayerId;

			[Token(Token = "0x4005B09")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private int _joyConAssignmentMode;

			[Token(Token = "0x4005B0A")]
			[FieldOffset(Offset = "0x20")]
			private Dictionary<int, object[]> __delegates;

			[Token(Token = "0x6004D96")]
			[Address(RVA = "0x18068EC", Offset = "0x18068EC", VA = "0x18068EC")]
			internal NpadSettings_Internal(int playerId)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200113C")]
		private sealed class DebugPadSettings_Internal
		{
			[Token(Token = "0x4005B0B")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private bool _enabled;

			[Token(Token = "0x4005B0C")]
			[FieldOffset(Offset = "0x14")]
			[SerializeField]
			private int _rewiredPlayerId;

			[Token(Token = "0x4005B0D")]
			[FieldOffset(Offset = "0x18")]
			private Dictionary<int, object[]> __delegates;

			[Token(Token = "0x6004D97")]
			[Address(RVA = "0x18068C0", Offset = "0x18068C0", VA = "0x18068C0")]
			internal DebugPadSettings_Internal(int playerId)
			{
			}
		}

		[Token(Token = "0x4005AF5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UserData _userData;

		[Token(Token = "0x6004D92")]
		[Address(RVA = "0x158DD54", Offset = "0x158DD54", VA = "0x158DD54", Slot = "4")]
		private object Rewired_002EUtils_002EInterfaces_002EIExternalInputManager_002EInitialize(Platform platform, object configVars)
		{
			return null;
		}

		[Token(Token = "0x6004D93")]
		[Address(RVA = "0x158DD5C", Offset = "0x158DD5C", VA = "0x158DD5C", Slot = "5")]
		private void Rewired_002EUtils_002EInterfaces_002EIExternalInputManager_002EDeinitialize()
		{
		}

		[Token(Token = "0x6004D94")]
		[Address(RVA = "0x158DD60", Offset = "0x158DD60", VA = "0x158DD60")]
		public NintendoSwitchInputManager()
		{
		}
	}
}
