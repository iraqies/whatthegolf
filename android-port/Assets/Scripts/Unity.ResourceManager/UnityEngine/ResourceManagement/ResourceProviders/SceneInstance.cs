using System;
using UnityEngine.SceneManagement;

namespace UnityEngine.ResourceManagement.ResourceProviders
{
	public struct SceneInstance
	{
		private Scene m_Scene;

		internal AsyncOperation m_Operation;

		public Scene Scene
		{
			get
			{
				return default;
			}
			internal set
			{
			}
		}

		[Obsolete]
		public void Activate()
		{
		}

		public AsyncOperation ActivateAsync()
		{
			return null;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}
	}
}
