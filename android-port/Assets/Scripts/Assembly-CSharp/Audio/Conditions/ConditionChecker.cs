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
			return false;
		}
	}
}
