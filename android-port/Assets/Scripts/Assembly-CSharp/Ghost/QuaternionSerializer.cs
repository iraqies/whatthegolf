using System;
using UnityEngine;

namespace Ghost
{
	[Serializable]
	public struct QuaternionSerializer
	{
		public float x;

		public float y;

		public float z;

		public float w;

		[NonSerialized]
		private Quaternion rotation;

		[NonSerialized]
		private bool isSet;

		public Quaternion Q => default;

		public void Fill(Quaternion q)
		{
		}
	}
}
