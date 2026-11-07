using System;
using UnityEngine;

namespace NaughtyAttributes.Test
{
	[Serializable]
	public class DisableIfNest2
	{
		public bool disable1;

		public bool disable2;

		public Vector2 enableIfAll;

		public Vector2 enableIfAny;
	}
}
