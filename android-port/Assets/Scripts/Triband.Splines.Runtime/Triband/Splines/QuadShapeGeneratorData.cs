using System;
using UnityEngine;

namespace Triband.Splines
{
	[Serializable]
	public class QuadShapeGeneratorData : IShapeGeneratorData
	{
		[SerializeField]
		private float width = 1f;

		[SerializeField]
		private float pivot = 0.5f;

		[SerializeField]
		private bool twoSided;

		public float Width => width;
		public float Pivot => pivot;
		public bool TwoSided => twoSided;
	}
}
