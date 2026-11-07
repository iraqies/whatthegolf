using System;
using UnityEngine;

namespace Rewired.Utils.Classes.Data
{
	[Serializable]
	public struct ScreenRect
	{
		public float xMin;

		public float yMin;

		public float width;

		public float height;

		public float xMax => 0f;

		public float yMax => 0f;

		public Vector2 center => default;

		public ScreenRect(float P_0, float P_1, float P_2, float P_3)
		{
			xMin = 0f;
			yMin = 0f;
			width = 0f;
			height = 0f;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
