using System;

namespace Core
{
	[Flags]
	public enum Store
	{
		Unknown = 0,
		Epic = 1,
		Arcade = 2,
		Switch = 4,
		Steam = 8,
		Oculus = 0x10,
		Playstation = 0x20,
		GOG = 0x40,
		XboxOne = 0x80
	}
}
