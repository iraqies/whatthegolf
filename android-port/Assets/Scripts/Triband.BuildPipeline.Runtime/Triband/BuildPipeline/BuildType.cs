using System;

namespace Triband.BuildPipeline
{
	[Flags]
	public enum BuildType
	{
		Unknown = 0,
		Development = 1,
		Release = 2
	}
}
