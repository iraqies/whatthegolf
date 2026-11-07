using System;
using UnityEngine;

namespace Triband.Splines
{
	[Serializable]
	public class QuadShapeGenerator : ShapeGenerator<QuadShapeGeneratorData>
	{
		public override bool ClosedLoop => false;

		public override bool AutoGenerateNormals => false;

		public override Shape2D Generate(float t, float length)
		{
			return null;
		}

		private Vector2 GenerateUVs(float x, float t, float length)
		{
			return default;
		}

		public override Shape GenerateStartCap()
		{
			return null;
		}

		public override Shape GenerateEndCap()
		{
			return null;
		}
	}
}
