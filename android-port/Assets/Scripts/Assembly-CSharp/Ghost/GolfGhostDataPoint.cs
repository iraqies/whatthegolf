using System;
using UnityEngine;

namespace Ghost
{
	[Serializable]
	public class GolfGhostDataPoint
	{
		public float Time;

		public Vector3Serializer _position;

		public QuaternionSerializer _rotation;

		public Vector3 Position => default;

		public Quaternion Rotation => default;

		public GolfGhostDataPoint(float time, Vector3 position, Quaternion rotation)
		{
		}
	}
}
