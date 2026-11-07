namespace UnityEngine.ResourceManagement.Util
{
	[ExecuteInEditMode]
	public abstract class ComponentSingleton<T> : MonoBehaviour where T : ComponentSingleton<T>
	{
		private static T s_Instance;

		public static bool Exists => false;

		public static T Instance => null;

		private static T FindInstance()
		{
			return null;
		}

		protected virtual string GetGameObjectName()
		{
			return null;
		}

		private static T CreateNewSingleton()
		{
			return null;
		}

		private void Awake()
		{
		}

		public static void DestroySingleton()
		{
		}
	}
}
