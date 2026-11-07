using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Rewired.Utils.Interfaces;

namespace Rewired.Utils
{
	[Token(Token = "0x200113D")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x47CE0", Offset = "0x47CE0")]
	public class ExternalTools : IExternalTools
	{
		[Token(Token = "0x4005B0E")]
		[FieldOffset(Offset = "0x0")]
		private static Func<object> _getPlatformInitializerDelegate;

		[Token(Token = "0x4005B0F")]
		[FieldOffset(Offset = "0x10")]
		private Action<bool> _EditorPausedStateChangedEvent;

		[Token(Token = "0x4005B10")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x56E60", Offset = "0x56E60")]
		private Action<uint, bool> m_XboxOneInput_OnGamepadStateChange;

		[Token(Token = "0x14000083")]
		public event Action<bool> EditorPausedStateChangedEvent
		{
			[Token(Token = "0x6004D9A")]
			[Address(RVA = "0x145439C", Offset = "0x145439C", VA = "0x145439C", Slot = "4")]
			add
			{
			}
			[Token(Token = "0x6004D9B")]
			[Address(RVA = "0x1454420", Offset = "0x1454420", VA = "0x1454420", Slot = "5")]
			remove
			{
			}
		}

		[Token(Token = "0x14000084")]
		public event Action<uint, bool> XboxOneInput_OnGamepadStateChange
		{
			[Token(Token = "0x6004DA0")]
			[Address(RVA = "0x1454574", Offset = "0x1454574", VA = "0x1454574", Slot = "12")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FDA8", Offset = "0x6FDA8")]
			add
			{
			}
			[Token(Token = "0x6004DA1")]
			[Address(RVA = "0x1454618", Offset = "0x1454618", VA = "0x1454618", Slot = "13")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FDB8", Offset = "0x6FDB8")]
			remove
			{
			}
		}

		[Token(Token = "0x6004D98")]
		[Address(RVA = "0x1454390", Offset = "0x1454390", VA = "0x1454390")]
		public ExternalTools()
		{
		}

		[Token(Token = "0x6004D99")]
		[Address(RVA = "0x1454398", Offset = "0x1454398", VA = "0x1454398", Slot = "6")]
		public void Destroy()
		{
		}

		[Token(Token = "0x6004D9C")]
		[Address(RVA = "0x14544A4", Offset = "0x14544A4", VA = "0x14544A4", Slot = "7")]
		public object GetPlatformInitializer()
		{
			return null;
		}

		[Token(Token = "0x6004D9D")]
		[Address(RVA = "0x1454518", Offset = "0x1454518", VA = "0x1454518", Slot = "8")]
		public string GetFocusedEditorWindowTitle()
		{
			return null;
		}

		[Token(Token = "0x6004D9E")]
		[Address(RVA = "0x1454564", Offset = "0x1454564", VA = "0x1454564", Slot = "9")]
		public bool IsEditorSceneViewFocused()
		{
			return default;
		}

		[Token(Token = "0x6004D9F")]
		[Address(RVA = "0x145456C", Offset = "0x145456C", VA = "0x145456C", Slot = "10")]
		public bool LinuxInput_IsJoystickPreconfigured(string name)
		{
			return default;
		}

		[Token(Token = "0x6004DA2")]
		[Address(RVA = "0x14546BC", Offset = "0x14546BC", VA = "0x14546BC", Slot = "11")]
		public ulong XboxOneInput_GetControllerId(uint unityJoystickId)
		{
			return default;
		}

		[Token(Token = "0x6004DA3")]
		[Address(RVA = "0x14546C4", Offset = "0x14546C4", VA = "0x14546C4", Slot = "14")]
		public bool XboxOneInput_IsGamepadActive(uint unityJoystickId)
		{
			return default;
		}

		[Token(Token = "0x6004DA4")]
		[Address(RVA = "0x14546CC", Offset = "0x14546CC", VA = "0x14546CC", Slot = "15")]
		public string XboxOneInput_GetControllerType(ulong xboxControllerId)
		{
			return null;
		}

		[Token(Token = "0x6004DA5")]
		[Address(RVA = "0x1454718", Offset = "0x1454718", VA = "0x1454718", Slot = "16")]
		public uint XboxOneInput_GetJoystickId(ulong xboxControllerId)
		{
			return default;
		}

		[Token(Token = "0x6004DA6")]
		[Address(RVA = "0x1454720", Offset = "0x1454720", VA = "0x1454720", Slot = "17")]
		public void XboxOne_Gamepad_UpdatePlugin()
		{
		}

		[Token(Token = "0x6004DA7")]
		[Address(RVA = "0x1454724", Offset = "0x1454724", VA = "0x1454724", Slot = "18")]
		public bool XboxOne_Gamepad_SetGamepadVibration(ulong xboxOneJoystickId, float leftMotor, float rightMotor, float leftTriggerLevel, float rightTriggerLevel)
		{
			return default;
		}

		[Token(Token = "0x6004DA8")]
		[Address(RVA = "0x145472C", Offset = "0x145472C", VA = "0x145472C", Slot = "19")]
		public void GetDeviceVIDPIDs(out List<int> vids, out List<int> pids)
		{
		}

		[Token(Token = "0x6004DA9")]
		[Address(RVA = "0x14547C8", Offset = "0x14547C8", VA = "0x14547C8", Slot = "20")]
		public int GetAndroidAPILevel()
		{
			return default;
		}

		[Token(Token = "0x6004DAA")]
		[Address(RVA = "0x14547D0", Offset = "0x14547D0", VA = "0x14547D0", Slot = "21")]
		public bool UnityUI_Graphic_GetRaycastTarget(object graphic)
		{
			return default;
		}

		[Token(Token = "0x6004DAB")]
		[Address(RVA = "0x14548E4", Offset = "0x14548E4", VA = "0x14548E4", Slot = "22")]
		public void UnityUI_Graphic_SetRaycastTarget(object graphic, bool value)
		{
		}

		[Token(Token = "0x6004DAC")]
		[Address(RVA = "0x14549FC", Offset = "0x14549FC", VA = "0x14549FC", Slot = "23")]
		public IControllerTemplate CreateControllerTemplate(Guid typeGuid, object payload)
		{
			return null;
		}

		[Token(Token = "0x6004DAD")]
		[Address(RVA = "0x1454A80", Offset = "0x1454A80", VA = "0x1454A80", Slot = "24")]
		public Type[] GetControllerTemplateTypes()
		{
			return null;
		}

		[Token(Token = "0x6004DAE")]
		[Address(RVA = "0x1454B1C", Offset = "0x1454B1C", VA = "0x1454B1C", Slot = "25")]
		public Type[] GetControllerTemplateInterfaceTypes()
		{
			return null;
		}
	}
}
