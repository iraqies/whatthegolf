using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Rewired.Data.Mapping
{
	[Serializable]
	[Token(Token = "0x20002B7")]
	public sealed class ControllerMap_Editor
	{
		[Token(Token = "0x4000E6C")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		[Token(Token = "0x4000E6D")]
		[FieldOffset(Offset = "0x14")]
		public int categoryId;

		[Token(Token = "0x4000E6E")]
		[FieldOffset(Offset = "0x18")]
		public int layoutId;

		[Token(Token = "0x4000E6F")]
		[FieldOffset(Offset = "0x20")]
		public string name;

		[Token(Token = "0x4000E70")]
		[FieldOffset(Offset = "0x28")]
		public string hardwareGuidString;

		[Token(Token = "0x4000E71")]
		[FieldOffset(Offset = "0x30")]
		public int customControllerUid;

		[Token(Token = "0x4000E72")]
		[FieldOffset(Offset = "0x38")]
		public List<ActionElementMap> actionElementMaps;

		[Token(Token = "0x17000561")]
		public Guid hardwareGuid
		{
			[Token(Token = "0x60013B4")]
			[Address(RVA = "0x2366C30", Offset = "0x2366C30", VA = "0x2366C30")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60013B5")]
		[Address(RVA = "0x2366CA8", Offset = "0x2366CA8", VA = "0x2366CA8")]
		public ControllerMap_Editor()
		{
		}

		[Token(Token = "0x60013B6")]
		[Address(RVA = "0x2366D2C", Offset = "0x2366D2C", VA = "0x2366D2C")]
		public ControllerMap_Editor Clone()
		{
			return null;
		}

		[Token(Token = "0x60013B7")]
		[Address(RVA = "0x2366F0C", Offset = "0x2366F0C", VA = "0x2366F0C")]
		internal JoystickMap cnkdOWmHBfKszdwDwvUpVLxVNZSI(Func<int, bool> P_0, HardwareControllerMapIdentifier P_1, HardwareJoystickMap P_2, bool P_3)
		{
			return null;
		}

		[Token(Token = "0x60013B8")]
		[Address(RVA = "0x23673D0", Offset = "0x23673D0", VA = "0x23673D0")]
		internal KeyboardMap fVMGDVEmClqGYHcOHaiLwzvRTLToA(Func<int, bool> P_0)
		{
			return null;
		}

		[Token(Token = "0x60013B9")]
		[Address(RVA = "0x2367468", Offset = "0x2367468", VA = "0x2367468")]
		internal MouseMap ihWEtXcbQdlsHGWThRgSBwvYKbLwb(Func<int, bool> P_0)
		{
			return null;
		}

		[Token(Token = "0x60013BA")]
		[Address(RVA = "0x2367500", Offset = "0x2367500", VA = "0x2367500")]
		internal CustomControllerMap QgZjZLSarbBkWpacWDcovadPAkKi(Func<int, bool> P_0, CustomController_Editor P_1)
		{
			return null;
		}

		[Token(Token = "0x60013BB")]
		[Address(RVA = "0x2366FC4", Offset = "0x2366FC4", VA = "0x2366FC4")]
		private void aRcuNuLszQybBDKkzhwftshHebVl(Func<int, bool> P_0, ControllerMap P_1, HardwareControllerMapIdentifier P_2, HardwareJoystickMap P_3, bool P_4)
		{
		}

		[Token(Token = "0x60013BC")]
		[Address(RVA = "0x23675B4", Offset = "0x23675B4", VA = "0x23675B4")]
		private void jCNylBuLlgpDWuUCobIxrrnlEXmQ(Func<int, bool> P_0, InputSource P_1, CustomControllerMap P_2, CustomController_Editor P_3)
		{
		}
	}
}
