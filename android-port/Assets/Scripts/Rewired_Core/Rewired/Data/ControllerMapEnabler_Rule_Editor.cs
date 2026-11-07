using System;
using System.Collections.Generic;
using Rewired.Utils.Attributes;
using Rewired.Utils.Interfaces;
using Rewired.Utils.Libraries.TinyJson;
using UnityEngine;

namespace Rewired.Data
{
	[Serializable]
	[Preserve]
	public sealed class ControllerMapEnabler_Rule_Editor : IDeepCloneable
	{
		[Serialize]
		[SerializeField]
		private string _tag;

		[SerializeField]
		[Serialize]
		private bool _enable;

		[Serialize]
		[SerializeField]
		private List<int> _categoryIds;

		[Serialize]
		[SerializeField]
		private List<int> _layoutIds;

		[SerializeField]
		[Serialize]
		private ControllerSetSelector_Editor _controllerSetSelector;

		public ControllerMapEnabler_Rule_Editor()
		{
		}

		public ControllerMapEnabler_Rule_Editor(ControllerMapEnabler_Rule_Editor P_0)
		{
		}

		internal ControllerMapEnabler.Rule ToRuntime()
		{
			return null;
		}

		object IDeepCloneable.DeepClone()
		{
			return null;
		}
	}
}
