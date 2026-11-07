using UnityEngine;

namespace Menu.QuickMenu
{
	public abstract class MissingComponent<T> : MonoBehaviour where T : MonoBehaviour
	{
		protected T Component;

		private void OnEnable()
		{
		}

		protected abstract bool NullCheck();

		protected abstract void Replace();
	}
}
