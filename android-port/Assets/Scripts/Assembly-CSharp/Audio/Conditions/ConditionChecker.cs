using System;
using System.Collections.Generic;
using UnityEngine;

namespace Audio.Conditions
{
	[Serializable]
	public class ConditionChecker
	{
		[SerializeField]
		private List<SerializedAudioCondition> conditions;

		public bool CheckConditions()
		{
			if (conditions == null || conditions.Count == 0)
				return true;
			return conditions.CheckConditions();
		}
	}
}
