using System;
using Il2CppDummyDll;
using Rewired.Data.Mapping;
using UnityEngine;

namespace Rewired.Data
{
	[Token(Token = "0x20001B7")]
	public sealed class ControllerDataFiles : ScriptableObject
	{
		[Token(Token = "0x40009EF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private HardwareJoystickMap defaultHardwareJoystickMap;

		[Token(Token = "0x40009F0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private HardwareJoystickMap[] hardwareJoystickMaps;

		[Token(Token = "0x40009F1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private HardwareJoystickTemplateMap[] joystickTemplates;

		[NonSerialized]
		[Token(Token = "0x40009F2")]
		[FieldOffset(Offset = "0x30")]
		private bool kIYovWzhdTIKVHftiOVFxvPLeXrm;

		[Token(Token = "0x1700038E")]
		public Guid defaultHardwareJoystickMapGuid
		{
			[Token(Token = "0x6000CD9")]
			[Address(RVA = "0x235AA1C", Offset = "0x235AA1C", VA = "0x235AA1C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700038F")]
		public HardwareJoystickTemplateMap[] JoystickTemplates
		{
			[Token(Token = "0x6000CDA")]
			[Address(RVA = "0x235AAF8", Offset = "0x235AAF8", VA = "0x235AAF8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000CDB")]
			[Address(RVA = "0x235AB00", Offset = "0x235AB00", VA = "0x235AB00")]
			set
			{
			}
		}

		[Token(Token = "0x17000390")]
		public HardwareJoystickMap[] HardwareJoystickMaps
		{
			[Token(Token = "0x6000CDC")]
			[Address(RVA = "0x235AB08", Offset = "0x235AB08", VA = "0x235AB08")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000CDD")]
			[Address(RVA = "0x235AB10", Offset = "0x235AB10", VA = "0x235AB10")]
			set
			{
			}
		}

		[Token(Token = "0x17000391")]
		public HardwareJoystickMap DefaultHardwareJoystickMap
		{
			[Token(Token = "0x6000CDE")]
			[Address(RVA = "0x235AB18", Offset = "0x235AB18", VA = "0x235AB18")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000CDF")]
			[Address(RVA = "0x235AB20", Offset = "0x235AB20", VA = "0x235AB20")]
			set
			{
			}
		}

		[Token(Token = "0x6000CE0")]
		[Address(RVA = "0x235AB28", Offset = "0x235AB28", VA = "0x235AB28")]
		public ControllerDataFiles()
		{
		}

		[Token(Token = "0x6000CE1")]
		[Address(RVA = "0x235AB30", Offset = "0x235AB30", VA = "0x235AB30")]
		public string[] GetJoystickNames()
		{
			return null;
		}

		[Token(Token = "0x6000CE2")]
		[Address(RVA = "0x235AD10", Offset = "0x235AD10", VA = "0x235AD10")]
		public string[] GetEditorJoystickNames()
		{
			return null;
		}

		[Token(Token = "0x6000CE3")]
		[Address(RVA = "0x235AF48", Offset = "0x235AF48", VA = "0x235AF48")]
		public Guid[] GetJoystickGuids()
		{
			return null;
		}

		[Token(Token = "0x6000CE4")]
		[Address(RVA = "0x235B148", Offset = "0x235B148", VA = "0x235B148")]
		public string[] GetJoystickTemplateNames()
		{
			return null;
		}

		[Token(Token = "0x6000CE5")]
		[Address(RVA = "0x235B2E4", Offset = "0x235B2E4", VA = "0x235B2E4")]
		public Guid[] GetJoystickTemplateGuids()
		{
			return null;
		}

		[Token(Token = "0x6000CE6")]
		[Address(RVA = "0x235B498", Offset = "0x235B498", VA = "0x235B498")]
		public HardwareJoystickMap GetHardwareJoystickMap(Guid guid)
		{
			return null;
		}

		[Token(Token = "0x6000CE7")]
		[Address(RVA = "0x235B674", Offset = "0x235B674", VA = "0x235B674")]
		public HardwareJoystickTemplateMap GetJoystickTemplate(Guid guid)
		{
			return null;
		}

		[Token(Token = "0x6000CE8")]
		[Address(RVA = "0x235B7F8", Offset = "0x235B7F8", VA = "0x235B7F8")]
		public IHardwareControllerTemplateMap GetControllerTemplate(Guid guid)
		{
			return null;
		}

		[Token(Token = "0x6000CE9")]
		[Address(RVA = "0x235B7FC", Offset = "0x235B7FC", VA = "0x235B7FC")]
		public IHardwareControllerMap GetHardwareJoystickOrTemplateMap(Guid guid)
		{
			return null;
		}

		[Token(Token = "0x6000CEA")]
		[Address(RVA = "0x235B8BC", Offset = "0x235B8BC", VA = "0x235B8BC")]
		internal ControllerTemplateElementIdentifier EUZRwgQIgYtQoFlxWBOXLFnVfPwl(Guid P_0, int P_1)
		{
			return null;
		}

		[Token(Token = "0x6000CEB")]
		[Address(RVA = "0x235BD2C", Offset = "0x235BD2C", VA = "0x235BD2C")]
		internal HardwareJoystickMap_InputManager igyTzPwKAtUKQePinKyePYFeMWpS(Guid P_0, InputSource P_1)
		{
			return null;
		}

		[Token(Token = "0x6000CEC")]
		[Address(RVA = "0x235C068", Offset = "0x235C068", VA = "0x235C068")]
		internal HardwareJoystickMap_InputManager QybEKscbrtSTeOWvpcJxVwbuuRGnA(BridgedControllerHWInfo P_0)
		{
			return null;
		}

		[Token(Token = "0x6000CED")]
		[Address(RVA = "0x235BF50", Offset = "0x235BF50", VA = "0x235BF50")]
		private HardwareJoystickMap_InputManager iMpeSJkzGihLBfkSFVWvavOWGDtr(HardwareJoystickMap P_0, BridgedControllerHWInfo P_1, bool P_2, out InputPlatform P_3, out int P_4, out HardwareJoystickMap.Platform P_5)
		{
			return null;
		}

		[Token(Token = "0x6000CEE")]
		[Address(RVA = "0x235C368", Offset = "0x235C368", VA = "0x235C368")]
		private HardwareJoystickMap_InputManager DOTARxVKUszxeQgDyGmMvOlDLZQG(BridgedControllerHWInfo P_0, string P_1)
		{
			return null;
		}

		[Token(Token = "0x6000CEF")]
		[Address(RVA = "0x235C2F8", Offset = "0x235C2F8", VA = "0x235C2F8")]
		private HardwareJoystickMap_InputManager xRkffNJUDhwycCKhxflaknQToJlEA(BridgedControllerHWInfo P_0)
		{
			return null;
		}

		[Token(Token = "0x6000CF0")]
		[Address(RVA = "0x235BE50", Offset = "0x235BE50", VA = "0x235BE50")]
		private void hDWcPcAMSTBgWuXOoABfbCNmQJEs()
		{
		}
	}
}
