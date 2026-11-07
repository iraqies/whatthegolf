using System.Collections.Generic;
using UnityEngine;

namespace Hub
{
	public class SpecialDayRoomConfig : ScriptableObject
	{
		public List<SpecialDayStage> Stages;

		public SpecialDayStage PostStage => null;

		public List<SpecialDayStage> PreStages => null;

		public SpecialDayStage LiveStage => null;
	}
}
