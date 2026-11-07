using System;
using System.Collections.Generic;
using Rewired.Utils.Interfaces;
using UnityEngine;

namespace Rewired.Platforms.Switch
{
	public sealed class NintendoSwitchInputManager : MonoBehaviour, IExternalInputManager
	{
		[Serializable]
		private class UserData
		{
			[SerializeField]
			private int _allowedNpadStyles;

			[SerializeField]
			private int _joyConGripStyle;

			[SerializeField]
			private bool _adjustIMUsForGripStyle;

			[SerializeField]
			private int _handheldActivationMode;

			[SerializeField]
			private bool _assignJoysticksByNpadId;

			[SerializeField]
			private bool _useVibrationThread;

			[SerializeField]
			private NpadSettings_Internal _npadNo1;

			[SerializeField]
			private NpadSettings_Internal _npadNo2;

			[SerializeField]
			private NpadSettings_Internal _npadNo3;

			[SerializeField]
			private NpadSettings_Internal _npadNo4;

			[SerializeField]
			private NpadSettings_Internal _npadNo5;

			[SerializeField]
			private NpadSettings_Internal _npadNo6;

			[SerializeField]
			private NpadSettings_Internal _npadNo7;

			[SerializeField]
			private NpadSettings_Internal _npadNo8;

			[SerializeField]
			private NpadSettings_Internal _npadHandheld;

			[SerializeField]
			private DebugPadSettings_Internal _debugPad;

			private Dictionary<int, object[]> __delegates;
		}

		[Serializable]
		private sealed class NpadSettings_Internal
		{
			[SerializeField]
			private bool _isAllowed;

			[SerializeField]
			private int _rewiredPlayerId;

			[SerializeField]
			private int _joyConAssignmentMode;

			private Dictionary<int, object[]> __delegates;

			internal NpadSettings_Internal(int playerId)
			{
			}
		}

		[Serializable]
		private sealed class DebugPadSettings_Internal
		{
			[SerializeField]
			private bool _enabled;

			[SerializeField]
			private int _rewiredPlayerId;

			private Dictionary<int, object[]> __delegates;

			internal DebugPadSettings_Internal(int playerId)
			{
			}
		}

		[SerializeField]
		private UserData _userData;

		object IExternalInputManager.Initialize(Platform platform, object configVars)
		{
			return null;
		}

		void IExternalInputManager.Deinitialize()
		{
		}
	}
}
