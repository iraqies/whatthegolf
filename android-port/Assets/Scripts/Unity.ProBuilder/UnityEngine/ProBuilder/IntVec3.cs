using System;

namespace UnityEngine.ProBuilder
{
	internal struct IntVec3 : IEquatable<IntVec3>
	{
		public Vector3 value;

		public float x => 0f;

		public float y => 0f;

		public float z => 0f;

		public IntVec3(Vector3 vector)
		{
			value = default;
		}

		public override string ToString()
		{
			return null;
		}

		public bool Equals(IntVec3 p)
		{
			return false;
		}

		public bool Equals(Vector3 p)
		{
			return false;
		}

		public override bool Equals(object b)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		private static int round(float v)
		{
			return 0;
		}

		public static implicit operator IntVec3(Vector3 p)
		{
			return default;
		}
	}
}
