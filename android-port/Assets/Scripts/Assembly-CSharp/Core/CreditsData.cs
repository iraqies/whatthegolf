using System;
using System.Collections.Generic;
using UnityEngine;

namespace Core
{
	[Serializable]
	public class CreditsData : ScriptableObject
	{
		[Serializable]
		public class Credit
		{
			public string title;

			public bool isRandomizingNames;

			public string twitter;

			public List<string> names;
		}

		public List<Credit> credits;
	}
}
