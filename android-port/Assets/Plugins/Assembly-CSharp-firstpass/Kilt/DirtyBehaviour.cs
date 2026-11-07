using UnityEngine;

namespace Kilt
{
	public class DirtyBehaviour : MonoBehaviour
	{
		protected bool _started;

		protected bool _isDirty;

		protected virtual void OnEnable()
		{
		}

		protected virtual void Start()
		{
		}

		protected virtual void Update()
		{
		}

		public virtual void SetDirty()
		{
		}

		public virtual void TryApply(bool p_force = false)
		{
		}

		protected virtual void Apply()
		{
		}
	}
}
