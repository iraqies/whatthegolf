using UnityEngine;

namespace Cinemachine
{
	public interface ICinemachineTargetGroup
	{
		BoundingSphere Sphere { get; }

		Bounds GetViewSpaceBoundingBox(Matrix4x4 observer);

		void GetViewSpaceAngularBounds(Matrix4x4 observer, out Vector2 minAngles, out Vector2 maxAngles, out Vector2 zRange);
	}
}
