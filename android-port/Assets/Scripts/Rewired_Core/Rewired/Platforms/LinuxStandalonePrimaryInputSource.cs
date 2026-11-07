using System.ComponentModel;

namespace Rewired.Platforms
{
	[EditorBrowsable]
	public enum LinuxStandalonePrimaryInputSource
	{
		Native = 0,
		SDL2 = 10,
		Unity = 100
	}
}
