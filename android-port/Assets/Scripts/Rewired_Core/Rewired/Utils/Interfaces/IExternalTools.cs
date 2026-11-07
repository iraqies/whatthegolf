using System;
using System.Collections.Generic;

namespace Rewired.Utils.Interfaces
{
	public interface IExternalTools
	{
		event Action<bool> EditorPausedStateChangedEvent;

		event Action<uint, bool> XboxOneInput_OnGamepadStateChange;

		void Destroy();

		object GetPlatformInitializer();

		string GetFocusedEditorWindowTitle();

		bool IsEditorSceneViewFocused();

		bool LinuxInput_IsJoystickPreconfigured(string name);

		ulong XboxOneInput_GetControllerId(uint unityJoystickId);

		bool XboxOneInput_IsGamepadActive(uint unityJoystickId);

		string XboxOneInput_GetControllerType(ulong xboxControllerId);

		uint XboxOneInput_GetJoystickId(ulong xboxControllerId);

		void XboxOne_Gamepad_UpdatePlugin();

		bool XboxOne_Gamepad_SetGamepadVibration(ulong xboxOneJoystickId, float leftMotor, float rightMotor, float leftTriggerLevel, float rightTriggerLevel);

		void GetDeviceVIDPIDs(out List<int> vids, out List<int> pids);

		int GetAndroidAPILevel();

		bool UnityUI_Graphic_GetRaycastTarget(object graphic);

		void UnityUI_Graphic_SetRaycastTarget(object graphic, bool value);

		IControllerTemplate CreateControllerTemplate(Guid typeGuid, object payload);

		Type[] GetControllerTemplateTypes();

		Type[] GetControllerTemplateInterfaceTypes();
	}
}
