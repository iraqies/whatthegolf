using System;

namespace UnityEngine.ResourceManagement.Util
{
	internal sealed class IdCacheKey : IOperationCacheKey, IEquatable<IOperationCacheKey>
	{
		public string ID;

		public IdCacheKey(string id)
		{
		}

		private bool Equals(IdCacheKey other)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(IOperationCacheKey other)
		{
			return false;
		}
	}
}
