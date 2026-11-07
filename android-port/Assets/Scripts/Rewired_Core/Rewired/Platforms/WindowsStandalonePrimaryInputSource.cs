using System.ComponentModel;

namespace Rewired.Platforms
{
	[EditorBrowsable]
	public enum WindowsStandalonePrimaryInputSource
	{
		RawInput = 0,
		DirectInput = 1,
		XInput = 2,
		SDL2 = 10,
		Unity = 100
	}
}
