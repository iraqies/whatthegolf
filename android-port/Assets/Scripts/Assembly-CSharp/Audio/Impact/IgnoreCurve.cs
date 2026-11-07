using System;

namespace Audio.Impact
{
	[Flags]
	public enum IgnoreCurve
	{
		None = 0,
		IgnoreVolume = 1,
		IgnorePitch = 2
	}
}
