using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Rewired.Utils.Interfaces
{
	[Token(Token = "0x2000393")]
	public interface IExternalTools
	{
		[Token(Token = "0x1400004E")]
		event Action<bool> EditorPausedStateChangedEvent;

		[Token(Token = "0x1400004F")]
		event Action<uint, bool> XboxOneInput_OnGamepadStateChange;

		[Token(Token = "0x6001B83")]
		void Destroy();

		[Token(Token = "0x6001B84")]
		object GetPlatformInitializer();

		[Token(Token = "0x6001B85")]
		string GetFocusedEditorWindowTitle();

		[Token(Token = "0x6001B86")]
		bool IsEditorSceneViewFocused();

		[Token(Token = "0x6001B87")]
		bool LinuxInput_IsJoystickPreconfigured(string name);

		[Token(Token = "0x6001B88")]
		ulong XboxOneInput_GetControllerId(uint unityJoystickId);

		[Token(Token = "0x6001B8B")]
		bool XboxOneInput_IsGamepadActive(uint unityJoystickId);

		[Token(Token = "0x6001B8C")]
		string XboxOneInput_GetControllerType(ulong xboxControllerId);

		[Token(Token = "0x6001B8D")]
		uint XboxOneInput_GetJoystickId(ulong xboxControllerId);

		[Token(Token = "0x6001B8E")]
		void XboxOne_Gamepad_UpdatePlugin();

		[Token(Token = "0x6001B8F")]
		bool XboxOne_Gamepad_SetGamepadVibration(ulong xboxOneJoystickId, float leftMotor, float rightMotor, float leftTriggerLevel, float rightTriggerLevel);

		[Token(Token = "0x6001B90")]
		void GetDeviceVIDPIDs(out List<int> vids, out List<int> pids);

		[Token(Token = "0x6001B91")]
		int GetAndroidAPILevel();

		[Token(Token = "0x6001B92")]
		bool UnityUI_Graphic_GetRaycastTarget(object graphic);

		[Token(Token = "0x6001B93")]
		void UnityUI_Graphic_SetRaycastTarget(object graphic, bool value);

		[Token(Token = "0x6001B94")]
		IControllerTemplate CreateControllerTemplate(Guid typeGuid, object payload);

		[Token(Token = "0x6001B95")]
		Type[] GetControllerTemplateTypes();

		[Token(Token = "0x6001B96")]
		Type[] GetControllerTemplateInterfaceTypes();
	}
}
