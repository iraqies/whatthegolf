using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Hub
{
	public class SpecialDayRoomConfig : ScriptableObject
	{
		public List<SpecialDayStage> Stages;

		public SpecialDayStage PostStage
		{
			get
			{
				if (Stages == null) return null;
				var live = LiveStage;
				int liveIdx = (live != null) ? Stages.IndexOf(live) : -1;
				return Stages.FirstOrDefault((SpecialDayStage s) => Stages.IndexOf(s) > liveIdx);
			}
		}

		public List<SpecialDayStage> PreStages
		{
			get
			{
				if (Stages == null) return new List<SpecialDayStage>();
				var live = LiveStage;
				int liveIdx = (live != null) ? Stages.IndexOf(live) : Stages.Count;
				return Stages.Where((SpecialDayStage s) => Stages.IndexOf(s) < liveIdx).ToList();
			}
		}

		public SpecialDayStage LiveStage
		{
			get
			{
				if (Stages == null) return null;
				return Stages.FirstOrDefault((SpecialDayStage s) => s != null && s.IsAvailable);
			}
		}
	}
}
