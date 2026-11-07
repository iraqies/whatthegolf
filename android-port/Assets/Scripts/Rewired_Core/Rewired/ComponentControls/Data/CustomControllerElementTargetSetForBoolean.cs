using System;
using UnityEngine;

namespace Rewired.ComponentControls.Data
{
	[Serializable]
	public class CustomControllerElementTargetSetForBoolean : CustomControllerElementTargetSet
	{
		private const int FEYqngSpWHCylzGRtugricMIeqFB = 1;

		[SerializeField]
		private CustomControllerElementTarget _target;

		public CustomControllerElementTarget target => null;

		internal override int targetCount => 0;

		// C# has no syntax for parameterized property 'Item'.
		internal override CustomControllerElementTarget get_Item(int index)
		{
			return null;
		}

		internal CustomControllerElementTargetSetForBoolean()
		{
		}

		internal override void ClearElementCaches()
		{
		}
	}
}
