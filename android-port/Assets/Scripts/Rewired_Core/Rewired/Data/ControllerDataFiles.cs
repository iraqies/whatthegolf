using System;
using Rewired.Data.Mapping;
using UnityEngine;

namespace Rewired.Data
{
	public sealed class ControllerDataFiles : ScriptableObject
	{
		[SerializeField]
		private HardwareJoystickMap defaultHardwareJoystickMap;

		[SerializeField]
		private HardwareJoystickMap[] hardwareJoystickMaps;

		[SerializeField]
		private HardwareJoystickTemplateMap[] joystickTemplates;

		[NonSerialized]
		private bool kIYovWzhdTIKVHftiOVFxvPLeXrm;

		public Guid defaultHardwareJoystickMapGuid => default;

		public HardwareJoystickTemplateMap[] JoystickTemplates
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public HardwareJoystickMap[] HardwareJoystickMaps
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public HardwareJoystickMap DefaultHardwareJoystickMap
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string[] GetJoystickNames()
		{
			return null;
		}

		public string[] GetEditorJoystickNames()
		{
			return null;
		}

		public Guid[] GetJoystickGuids()
		{
			return null;
		}

		public string[] GetJoystickTemplateNames()
		{
			return null;
		}

		public Guid[] GetJoystickTemplateGuids()
		{
			return null;
		}

		public HardwareJoystickMap GetHardwareJoystickMap(Guid guid)
		{
			return null;
		}

		public HardwareJoystickTemplateMap GetJoystickTemplate(Guid guid)
		{
			return null;
		}

		public IHardwareControllerTemplateMap GetControllerTemplate(Guid guid)
		{
			return null;
		}

		public IHardwareControllerMap GetHardwareJoystickOrTemplateMap(Guid guid)
		{
			return null;
		}

		internal ControllerTemplateElementIdentifier EUZRwgQIgYtQoFlxWBOXLFnVfPwl(Guid P_0, int P_1)
		{
			return null;
		}

		internal HardwareJoystickMap_InputManager igyTzPwKAtUKQePinKyePYFeMWpS(Guid P_0, InputSource P_1)
		{
			return null;
		}

		internal HardwareJoystickMap_InputManager QybEKscbrtSTeOWvpcJxVwbuuRGnA(BridgedControllerHWInfo P_0)
		{
			return null;
		}

		private HardwareJoystickMap_InputManager iMpeSJkzGihLBfkSFVWvavOWGDtr(HardwareJoystickMap P_0, BridgedControllerHWInfo P_1, bool P_2, out InputPlatform P_3, out int P_4, out HardwareJoystickMap.Platform P_5)
		{
			P_3 = default;
			P_4 = default;
			P_5 = null;
			return null;
		}

		private HardwareJoystickMap_InputManager DOTARxVKUszxeQgDyGmMvOlDLZQG(BridgedControllerHWInfo P_0, string P_1)
		{
			return null;
		}

		private HardwareJoystickMap_InputManager xRkffNJUDhwycCKhxflaknQToJlEA(BridgedControllerHWInfo P_0)
		{
			return null;
		}

		private void hDWcPcAMSTBgWuXOoABfbCNmQJEs()
		{
		}
	}
}
