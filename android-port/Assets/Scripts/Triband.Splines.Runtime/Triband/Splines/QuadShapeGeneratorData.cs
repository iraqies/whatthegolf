using System;
using UnityEngine;

namespace Triband.Splines
{
	[Serializable]
	public class QuadShapeGeneratorData : IShapeGeneratorData
	{
		[SerializeField]
		private float width;

		[SerializeField]
		private float pivot;

		[SerializeField]
		private bool twoSided;

		public float Width => 0f;

		public float Pivot => 0f;

		public bool TwoSided => false;
	}
}
