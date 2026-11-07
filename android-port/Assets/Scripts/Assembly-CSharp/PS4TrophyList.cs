using System;
using System.Collections.Generic;
using UnityEngine;

public class PS4TrophyList : ScriptableObject
{
	[Serializable]
	public struct PS4Trophy
	{
		public string name;

		public int id;
	}

	public List<PS4Trophy> trophies;
}
