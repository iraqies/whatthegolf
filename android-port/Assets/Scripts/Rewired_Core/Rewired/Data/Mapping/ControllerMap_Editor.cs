using System;
using System.Collections.Generic;

namespace Rewired.Data.Mapping
{
	[Serializable]
	public sealed class ControllerMap_Editor
	{
		public int id;

		public int categoryId;

		public int layoutId;

		public string name;

		public string hardwareGuidString;

		public int customControllerUid;

		public List<ActionElementMap> actionElementMaps;

		public Guid hardwareGuid => default;

		public ControllerMap_Editor Clone()
		{
			return null;
		}

		internal JoystickMap cnkdOWmHBfKszdwDwvUpVLxVNZSI(Func<int, bool> P_0, HardwareControllerMapIdentifier P_1, HardwareJoystickMap P_2, bool P_3)
		{
			return null;
		}

		internal KeyboardMap fVMGDVEmClqGYHcOHaiLwzvRTLToA(Func<int, bool> P_0)
		{
			return null;
		}

		internal MouseMap ihWEtXcbQdlsHGWThRgSBwvYKbLwb(Func<int, bool> P_0)
		{
			return null;
		}

		internal CustomControllerMap QgZjZLSarbBkWpacWDcovadPAkKi(Func<int, bool> P_0, CustomController_Editor P_1)
		{
			return null;
		}

		private void aRcuNuLszQybBDKkzhwftshHebVl(Func<int, bool> P_0, ControllerMap P_1, HardwareControllerMapIdentifier P_2, HardwareJoystickMap P_3, bool P_4)
		{
		}

		private void jCNylBuLlgpDWuUCobIxrrnlEXmQ(Func<int, bool> P_0, InputSource P_1, CustomControllerMap P_2, CustomController_Editor P_3)
		{
		}
	}
}
