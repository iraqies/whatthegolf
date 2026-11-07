using UnityEngine;

namespace Triband.Splines
{
	public struct Vertex
	{
		public readonly Vector3 position;

		public readonly Vector3 normal;

		public readonly Vector2 uv;

		public Vertex(Vector3 position, Vector3 normal, Vector2 uv)
		{
			this.position = default;
			this.normal = default;
			this.uv = default;
		}
	}
}
