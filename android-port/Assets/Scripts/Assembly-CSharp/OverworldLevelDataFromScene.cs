using System;
using System.Collections.Generic;
using UnityEngine;

public class OverworldLevelDataFromScene : MonoBehaviour
{
	[Serializable]
	public class SectionData
	{
		public string name;

		public string number;

		public List<GameObject> sections;

		public Transmogrif.BALLSHAPES ballShape;

		public OverworldID unlockTrigger;
	}

	public List<SectionData> sections;
}
