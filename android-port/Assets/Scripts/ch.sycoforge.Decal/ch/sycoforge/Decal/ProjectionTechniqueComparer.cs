using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace ch.sycoforge.Decal
{
	[StructLayout((LayoutKind)0, Size = 1)]
	public struct ProjectionTechniqueComparer : IEqualityComparer<ProjectionTechnique>
	{
		public bool Equals(ProjectionTechnique x, ProjectionTechnique y)
		{
			return false;
		}

		public int GetHashCode(ProjectionTechnique obj)
		{
			return 0;
		}
	}
}
