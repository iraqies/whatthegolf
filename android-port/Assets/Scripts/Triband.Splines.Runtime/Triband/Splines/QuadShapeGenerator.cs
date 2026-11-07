using System;
using UnityEngine;

namespace Triband.Splines
{
	[Serializable]
	public class QuadShapeGenerator : ShapeGenerator<QuadShapeGeneratorData>
	{
		public override bool ClosedLoop => false;
		public override bool AutoGenerateNormals => true;

		public override Shape2D Generate(float t, float length)
		{
			var s = new Shape2D();
			float w = Data != null && Data.Width > 0f ? Data.Width : 1f;
			float p = Data != null ? Data.Pivot : 0.5f;
			float x0 = -w * p;
			float x1 = w * (1f - p);
			s.AddVertex(new Vertex2D(new Vector2(x0, 0f), GenerateUVs(0f, t, length)));
			s.AddVertex(new Vertex2D(new Vector2(x1, 0f), GenerateUVs(1f, t, length)));
			return s;
		}

		private Vector2 GenerateUVs(float x, float t, float length)
		{
			float v = UVSettings.verticalUVMode == SplineMesh.UVMode.WorldSpace ? t * length : t;
			return new Vector2(x, v);
		}

		public override Shape GenerateStartCap() => new Shape();
		public override Shape GenerateEndCap() => new Shape();
	}
}
