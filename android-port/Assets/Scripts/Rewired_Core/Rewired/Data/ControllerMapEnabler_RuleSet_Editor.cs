using System;
using System.Collections.Generic;
using Rewired.Utils.Attributes;
using Rewired.Utils.Libraries.TinyJson;
using UnityEngine;

namespace Rewired.Data
{
	[Serializable]
	[Preserve]
	public sealed class ControllerMapEnabler_RuleSet_Editor
	{
		[SerializeField]
		[Serialize]
		private int _id;

		[Serialize]
		[SerializeField]
		private string _name;

		[Serialize]
		[SerializeField]
		private string _tag;

		[SerializeField]
		[Serialize]
		private List<ControllerMapEnabler_Rule_Editor> _rules;

		public int id => 0;

		internal ControllerMapEnabler.RuleSet ToRuntime()
		{
			return null;
		}
	}
}
