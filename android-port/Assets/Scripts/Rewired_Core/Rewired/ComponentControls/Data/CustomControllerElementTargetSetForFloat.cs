using System;
using UnityEngine;

namespace Rewired.ComponentControls.Data
{
	[Serializable]
	public class CustomControllerElementTargetSetForFloat : CustomControllerElementTargetSet
	{
		[SerializeField]
		private bool _splitValue;

		[SerializeField]
		private CustomControllerElementTarget _target;

		[SerializeField]
		private CustomControllerElementTarget _positiveTarget;

		[SerializeField]
		private CustomControllerElementTarget _negativeTarget;

		public bool splitValue => false;

		public CustomControllerElementTarget target => null;

		public CustomControllerElementTarget positiveTarget => null;

		public CustomControllerElementTarget negativeTarget => null;

		internal override int targetCount => 0;

		// C# has no syntax for parameterized property 'Item'.
		internal override CustomControllerElementTarget get_Item(int index)
		{
			return null;
		}

		internal CustomControllerElementTargetSetForFloat()
		{
		}

		internal CustomControllerElementTargetSetForFloat(CustomControllerElementTarget P_0)
		{
		}

		internal override void ClearElementCaches()
		{
		}
	}
}
