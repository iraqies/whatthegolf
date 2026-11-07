namespace Kilt
{
	public abstract class Singleton<T> : BaseSingleton where T : BaseSingleton
	{
		protected static T s_instance;

		protected bool _keepNewInstanceIfDuplicated;

		public static T Instance
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected virtual bool KeepNewInstanceIfDuplicated
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool InstanceExists()
		{
			return false;
		}

		public static T GetInstance(bool p_canCreateANewOne = false)
		{
			return null;
		}

		protected virtual void Awake()
		{
		}

		protected virtual void CheckInstance()
		{
		}
	}
}
