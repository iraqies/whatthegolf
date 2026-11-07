using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UnityEngine.ResourceManagement.AsyncOperations
{
	public struct AsyncOperationHandle<TObject> : IEnumerator, IEquatable<AsyncOperationHandle<TObject>>
	{
		internal AsyncOperationBase<TObject> m_InternalOp;

		private int m_Version;

		private string m_LocationName;

		private bool m_UnloadSceneOpExcludeReleaseCallback;

		internal string LocationName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool UnloadSceneOpExcludeReleaseCallback
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public string DebugName => null;

		internal AsyncOperationBase<TObject> InternalOp => null;

		public bool IsDone => false;

		public Exception OperationException => null;

		public float PercentComplete => 0f;

		internal int ReferenceCount => 0;

		public TObject Result => default;

		public AsyncOperationStatus Status => AsyncOperationStatus.None;

		public Task<TObject> Task => null;

		object IEnumerator.Current => null;

		public event Action<AsyncOperationHandle<TObject>> Completed
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action<AsyncOperationHandle> CompletedTypeless
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action<AsyncOperationHandle> Destroyed
		{
			add
			{
			}
			remove
			{
			}
		}

		public static implicit operator AsyncOperationHandle(AsyncOperationHandle<TObject> obj)
		{
			return default;
		}

		internal AsyncOperationHandle(AsyncOperationBase<TObject> op)
		{
			m_InternalOp = null;
			m_Version = 0;
			m_LocationName = null;
			m_UnloadSceneOpExcludeReleaseCallback = false;
		}

		public DownloadStatus GetDownloadStatus()
		{
			return default;
		}

		internal DownloadStatus InternalGetDownloadStatus(HashSet<object> visited)
		{
			return default;
		}

		internal AsyncOperationHandle(IAsyncOperation op)
		{
			m_InternalOp = null;
			m_Version = 0;
			m_LocationName = null;
			m_UnloadSceneOpExcludeReleaseCallback = false;
		}

		internal AsyncOperationHandle(IAsyncOperation op, int version)
		{
			m_InternalOp = null;
			m_Version = 0;
			m_LocationName = null;
			m_UnloadSceneOpExcludeReleaseCallback = false;
		}

		internal AsyncOperationHandle(IAsyncOperation op, string locationName)
		{
			m_InternalOp = null;
			m_Version = 0;
			m_LocationName = null;
			m_UnloadSceneOpExcludeReleaseCallback = false;
		}

		internal AsyncOperationHandle(IAsyncOperation op, int version, string locationName)
		{
			m_InternalOp = null;
			m_Version = 0;
			m_LocationName = null;
			m_UnloadSceneOpExcludeReleaseCallback = false;
		}

		internal AsyncOperationHandle<TObject> Acquire()
		{
			return default;
		}

		public void GetDependencies(List<AsyncOperationHandle> deps)
		{
		}

		public bool Equals(AsyncOperationHandle<TObject> other)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public TObject WaitForCompletion()
		{
			return default;
		}

		public bool IsValid()
		{
			return false;
		}

		internal void Release()
		{
		}

		bool IEnumerator.MoveNext()
		{
			return false;
		}

		void IEnumerator.Reset()
		{
		}
	}
	public struct AsyncOperationHandle : IEnumerator
	{
		private static bool m_IsWaitingForCompletion;

		internal IAsyncOperation m_InternalOp;

		private int m_Version;

		private string m_LocationName;

		public static bool IsWaitingForCompletion
		{
			get
			{
				return false;
			}
			internal set
			{
			}
		}

		internal string LocationName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string DebugName => null;

		private IAsyncOperation InternalOp => null;

		public bool IsDone => false;

		public Exception OperationException => null;

		public float PercentComplete => 0f;

		internal int ReferenceCount => 0;

		public object Result => null;

		public AsyncOperationStatus Status => AsyncOperationStatus.None;

		public Task<object> Task => null;

		object IEnumerator.Current => null;

		public event Action<AsyncOperationHandle> Completed
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action<AsyncOperationHandle> Destroyed
		{
			add
			{
			}
			remove
			{
			}
		}

		internal AsyncOperationHandle(IAsyncOperation op)
		{
			m_InternalOp = null;
			m_Version = 0;
			m_LocationName = null;
		}

		internal AsyncOperationHandle(IAsyncOperation op, int version)
		{
			m_InternalOp = null;
			m_Version = 0;
			m_LocationName = null;
		}

		internal AsyncOperationHandle(IAsyncOperation op, string locationName)
		{
			m_InternalOp = null;
			m_Version = 0;
			m_LocationName = null;
		}

		internal AsyncOperationHandle(IAsyncOperation op, int version, string locationName)
		{
			m_InternalOp = null;
			m_Version = 0;
			m_LocationName = null;
		}

		internal AsyncOperationHandle Acquire()
		{
			return default;
		}

		public AsyncOperationHandle<T> Convert<T>()
		{
			return default;
		}

		public bool Equals(AsyncOperationHandle other)
		{
			return false;
		}

		public void GetDependencies(List<AsyncOperationHandle> deps)
		{
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public bool IsValid()
		{
			return false;
		}

		public DownloadStatus GetDownloadStatus()
		{
			return default;
		}

		internal DownloadStatus InternalGetDownloadStatus(HashSet<object> visited)
		{
			return default;
		}

		internal void Release()
		{
		}

		bool IEnumerator.MoveNext()
		{
			return false;
		}

		void IEnumerator.Reset()
		{
		}

		public object WaitForCompletion()
		{
			return null;
		}
	}
}
