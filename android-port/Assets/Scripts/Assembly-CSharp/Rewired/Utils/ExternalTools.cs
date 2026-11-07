using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Rewired.Utils.Interfaces;

namespace Rewired.Utils
{
	[EditorBrowsable]
	public class ExternalTools : IExternalTools
	{
		private static Func<object> _getPlatformInitializerDelegate;

		private Action<bool> _EditorPausedStateChangedEvent;

		[CompilerGenerated]
		private Action<uint, bool> m_XboxOneInput_OnGamepadStateChange;

		public event Action<bool> EditorPausedStateChangedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action<uint, bool> XboxOneInput_OnGamepadStateChange
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void Destroy()
		{
		}

		public object GetPlatformInitializer()
		{
			return null;
		}

		public string GetFocusedEditorWindowTitle()
		{
			return null;
		}

		public bool IsEditorSceneViewFocused()
		{
			return false;
		}

		public bool LinuxInput_IsJoystickPreconfigured(string name)
		{
			return false;
		}

		public ulong XboxOneInput_GetControllerId(uint unityJoystickId)
		{
			return 0uL;
		}

		public bool XboxOneInput_IsGamepadActive(uint unityJoystickId)
		{
			return false;
		}

		public string XboxOneInput_GetControllerType(ulong xboxControllerId)
		{
			return null;
		}

		public uint XboxOneInput_GetJoystickId(ulong xboxControllerId)
		{
			return 0u;
		}

		public void XboxOne_Gamepad_UpdatePlugin()
		{
		}

		public bool XboxOne_Gamepad_SetGamepadVibration(ulong xboxOneJoystickId, float leftMotor, float rightMotor, float leftTriggerLevel, float rightTriggerLevel)
		{
			return false;
		}

		public void GetDeviceVIDPIDs(out List<int> vids, out List<int> pids)
		{
			vids = null;
			pids = null;
		}

		public int GetAndroidAPILevel()
		{
			return 0;
		}

		public bool UnityUI_Graphic_GetRaycastTarget(object graphic)
		{
			return false;
		}

		public void UnityUI_Graphic_SetRaycastTarget(object graphic, bool value)
		{
		}

		public IControllerTemplate CreateControllerTemplate(Guid typeGuid, object payload)
		{
			return null;
		}

		public Type[] GetControllerTemplateTypes()
		{
			return null;
		}

		public Type[] GetControllerTemplateInterfaceTypes()
		{
			return null;
		}
	}
}
