using System;

namespace Triband.Splines
{
	[Serializable]
	public abstract class ShapeGenerator
	{
		public IShapeGeneratorData rootData;

		public abstract Type DataType { get; }
		public abstract bool ClosedLoop { get; }
		public abstract bool AutoGenerateNormals { get; }
		public SplineMesh.UVSettings UVSettings { get; set; }

		public abstract Shape2D Generate(float t, float length);
		public abstract Shape GenerateStartCap();
		public abstract Shape GenerateEndCap();
	}

	public abstract class ShapeGenerator<T> : ShapeGenerator where T : IShapeGeneratorData
	{
		public override Type DataType => typeof(T);
		protected T Data => (T)rootData;
	}
}
