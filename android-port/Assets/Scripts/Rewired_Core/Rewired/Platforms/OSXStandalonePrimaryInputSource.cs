using System.ComponentModel;

namespace Rewired.Platforms
{
	[EditorBrowsable]
	public enum OSXStandalonePrimaryInputSource
	{
		Native = 0,
		GameController = 1,
		SDL2 = 10,
		Unity = 100
	}
}
