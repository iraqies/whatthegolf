using UnityEngine;

namespace Triband.Splines
{
	public struct Vertex2D
	{
		public readonly Vector2 position;

		public readonly Vector2 uv;

		public readonly Vector2 normal;

		public Vertex2D(Vector2 position, Vector2 uv)
		{
			this.position = default;
			this.uv = default;
			normal = default;
		}
	}
}
