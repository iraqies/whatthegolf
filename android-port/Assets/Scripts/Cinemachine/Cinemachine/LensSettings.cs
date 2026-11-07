using System;
using UnityEngine;

namespace Cinemachine
{
	[Serializable]
	public struct LensSettings
	{
		public static LensSettings Default;

		public float FieldOfView;

		public float OrthographicSize;

		public float NearClipPlane;

		public float FarClipPlane;

		public float Dutch;

		public Vector2 LensShift;

		public bool Orthographic { get; set; }

		public Vector2 SensorSize { get; set; }

		public float Aspect => 0f;

		public bool IsPhysicalCamera { get; set; }

		public static LensSettings FromCamera(Camera fromCamera)
		{
			return default;
		}

		public void SnapshotCameraReadOnlyProperties(Camera camera)
		{
		}

		public LensSettings(float fov, float orthographicSize, float nearClip, float farClip, float dutch)
		{
			FieldOfView = 0f;
			OrthographicSize = 0f;
			NearClipPlane = 0f;
			FarClipPlane = 0f;
			Dutch = 0f;
			Orthographic = false;
			SensorSize = default;
			IsPhysicalCamera = false;
			LensShift = default;
		}

		public static LensSettings Lerp(LensSettings lensA, LensSettings lensB, float t)
		{
			return default;
		}

		public void Validate()
		{
		}
	}
}
