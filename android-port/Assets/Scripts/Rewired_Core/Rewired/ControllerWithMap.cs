using System;

namespace Rewired
{
	public abstract class ControllerWithMap : Controller
	{
		internal ControllerWithMap(int P_0, InputSource P_1, string P_2, string P_3, string P_4, ControllerType P_5, Guid P_6, int P_7, bool[] P_8, HardwareControllerMap_Game P_9, Extension P_10, ControllerDataUpdater P_11)
			: base(0, InputSource.None, null, null, null, ControllerType.Keyboard, default, 0, null, null, null, null, null)
		{
		}
	}
}
