using System;
using UnityEngine;

namespace Ghost
{
	[Serializable]
	public struct Vector3Serializer
	{
		public float x;

		public float y;

		public float z;

		[NonSerialized]
		private Vector3 point;

		[NonSerialized]
		private bool isSet;

		public Vector3 V3 => default;

		public void Fill(Vector3 v3)
		{
		}
	}
}
