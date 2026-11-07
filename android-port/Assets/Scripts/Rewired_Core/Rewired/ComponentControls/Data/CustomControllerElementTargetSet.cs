using System;

namespace Rewired.ComponentControls.Data
{
	[Serializable]
	public abstract class CustomControllerElementTargetSet
	{
		internal abstract int targetCount { get; }

		// C# has no syntax for parameterized property 'Item'.
		internal abstract CustomControllerElementTarget get_Item(int index);

		internal abstract void ClearElementCaches();
	}
}
