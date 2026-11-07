using System;
using System.Collections.Generic;

namespace Ghost
{
	[Serializable]
	public class GhostStrokeData
	{
		public string GhostPrefabID;

		public List<GolfGhostDataPoint> DataPoints;

		public GhostStrokeData(string ghostPrefabID)
		{
		}
	}
}
