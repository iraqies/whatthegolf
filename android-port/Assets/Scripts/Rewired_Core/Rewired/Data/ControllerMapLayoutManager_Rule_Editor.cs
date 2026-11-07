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
	public sealed class ControllerMapLayoutManager_Rule_Editor : IDeepCloneable
	{
		[SerializeField]
		[Serialize]
		private string _tag;

		[Serialize]
		[SerializeField]
		private List<int> _categoryIds;

		[Serialize]
		[SerializeField]
		private int _layoutId;

		[SerializeField]
		[Serialize]
		private ControllerSetSelector_Editor _controllerSetSelector;

		public ControllerMapLayoutManager_Rule_Editor()
		{
		}

		public ControllerMapLayoutManager_Rule_Editor(ControllerMapLayoutManager_Rule_Editor P_0)
		{
		}

		internal ControllerMapLayoutManager.Rule ToRuntime()
		{
			return null;
		}

		object IDeepCloneable.DeepClone()
		{
			return null;
		}
	}
}
