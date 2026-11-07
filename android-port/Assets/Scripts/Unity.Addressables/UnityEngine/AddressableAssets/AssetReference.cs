using System;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;

namespace UnityEngine.AddressableAssets
{
	[Serializable]
	public class AssetReference : IKeyEvaluator
	{
		[SerializeField]
		protected internal string m_AssetGUID;

		[SerializeField]
		private string m_SubObjectName;

		[SerializeField]
		private string m_SubObjectType;

		private AsyncOperationHandle m_Operation;

		public AsyncOperationHandle OperationHandle
		{
			get
			{
				return default;
			}
			internal set
			{
			}
		}

		public virtual object RuntimeKey => null;

		public virtual string AssetGUID => null;

		public virtual string SubObjectName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal virtual Type SubOjbectType => null;

		public bool IsDone => false;

		public virtual Object Asset => null;

		public bool IsValid()
		{
			return false;
		}

		public AssetReference()
		{
		}

		public AssetReference(string guid)
		{
		}

		public override string ToString()
		{
			return null;
		}

		private static AsyncOperationHandle<T> CreateFailedOperation<T>()
		{
			return default;
		}

		[Obsolete]
		public AsyncOperationHandle<TObject> LoadAsset<TObject>()
		{
			return default;
		}

		[Obsolete]
		public AsyncOperationHandle<SceneInstance> LoadScene()
		{
			return default;
		}

		[Obsolete]
		public AsyncOperationHandle<GameObject> Instantiate(Vector3 position, Quaternion rotation, Transform parent = null)
		{
			return default;
		}

		[Obsolete]
		public AsyncOperationHandle<GameObject> Instantiate(Transform parent = null, bool instantiateInWorldSpace = false)
		{
			return default;
		}

		public virtual AsyncOperationHandle<TObject> LoadAssetAsync<TObject>()
		{
			return default;
		}

		public virtual AsyncOperationHandle<SceneInstance> LoadSceneAsync(LoadSceneMode loadMode = LoadSceneMode.Single, bool activateOnLoad = true, int priority = 100)
		{
			return default;
		}

		public virtual AsyncOperationHandle<SceneInstance> UnLoadScene()
		{
			return default;
		}

		public virtual AsyncOperationHandle<GameObject> InstantiateAsync(Vector3 position, Quaternion rotation, Transform parent = null)
		{
			return default;
		}

		public virtual AsyncOperationHandle<GameObject> InstantiateAsync(Transform parent = null, bool instantiateInWorldSpace = false)
		{
			return default;
		}

		public virtual bool RuntimeKeyIsValid()
		{
			return false;
		}

		public virtual void ReleaseAsset()
		{
		}

		public virtual void ReleaseInstance(GameObject obj)
		{
		}

		public virtual bool ValidateAsset(Object obj)
		{
			return false;
		}

		public virtual bool ValidateAsset(string path)
		{
			return false;
		}
	}
}
