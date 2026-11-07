using System;
using UnityEngine;

namespace Prime31
{
	public abstract class AbstractManager : MonoBehaviour
	{
		private static LifecycleHelper _prime31LifecycleHelperRef;

		private static ThreadingCallbackHelper _threadingCallbackHelper;

		private static GameObject _prime31GameObject;

		public static LifecycleHelper coroutineSurrogate => null;

		public static LifecycleHelper lifecycleHelper => null;

		public static ThreadingCallbackHelper getThreadingCallbackHelper()
		{
			return null;
		}

		public static void createThreadingCallbackHelper()
		{
		}

		public static GameObject getPrime31ManagerGameObject()
		{
			return null;
		}

		public static void initialize(Type type)
		{
		}

		private void Awake()
		{
		}
	}
}
