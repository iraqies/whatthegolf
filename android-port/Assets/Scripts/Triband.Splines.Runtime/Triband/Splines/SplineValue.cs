using UnityEngine;

namespace Triband.Splines
{
	public struct SplineValue
	{
		public readonly Vector3 position;

		public readonly Quaternion rotation;

		public readonly Vector3 normal;

		public readonly Vector3 tangent;

		public readonly Vector3 binormal;

		public float t { get; internal set; }

		public SplineValue(Vector3 position, Quaternion rotation, Vector3 normal, Vector3 tangent, Vector3 binormal)
		{
			this.position = default;
			this.rotation = default;
			this.normal = default;
			this.tangent = default;
			this.binormal = default;
			t = 0f;
		}
	}
}
