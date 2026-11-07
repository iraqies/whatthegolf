using System;

namespace UnityEngine.AddressableAssets.Initialization
{
	[Serializable]
	public class CacheInitializationData
	{
		[SerializeField]
		private bool m_CompressionEnabled;

		[SerializeField]
		private string m_CacheDirectoryOverride;

		[SerializeField]
		private int m_ExpirationDelay;

		[SerializeField]
		private bool m_LimitCacheSize;

		[SerializeField]
		private long m_MaximumCacheSize;

		public bool CompressionEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public string CacheDirectoryOverride
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[Obsolete]
		public int ExpirationDelay
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool LimitCacheSize
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public long MaximumCacheSize
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}
	}
}
