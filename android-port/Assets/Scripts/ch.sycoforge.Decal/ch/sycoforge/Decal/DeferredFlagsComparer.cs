using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace ch.sycoforge.Decal
{
	[StructLayout((LayoutKind)0, Size = 1)]
	public struct DeferredFlagsComparer : IEqualityComparer<DeferredFlags>
	{
		public bool Equals(DeferredFlags x, DeferredFlags y)
		{
			return false;
		}

		public int GetHashCode(DeferredFlags obj)
		{
			return 0;
		}
	}
}
