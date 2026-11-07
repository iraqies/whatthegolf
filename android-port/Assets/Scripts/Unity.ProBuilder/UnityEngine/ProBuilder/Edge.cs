using System;

namespace UnityEngine.ProBuilder
{
	[Serializable]
	public struct Edge : IEquatable<Edge>
	{
		public int a;

		public int b;

		public static readonly Edge Empty;

		public Edge(int a, int b)
		{
			this.a = 0;
			this.b = 0;
		}

		public override string ToString()
		{
			return null;
		}

		public bool Equals(Edge other)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
