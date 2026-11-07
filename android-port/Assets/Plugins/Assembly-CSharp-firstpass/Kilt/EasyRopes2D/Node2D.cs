using System.Collections;
using UnityEngine;

namespace Kilt.EasyRopes2D
{
	public class Node2D : MonoBehaviour
	{
		private Rope2D _ropeParent;

		private bool _needApplyIgnore;

		private bool _started;

		public Rope2D RopeParent => null;

		protected virtual bool NeedApplyIgnore
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected virtual bool Started
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void Start()
		{
		}

		protected virtual void OnDisable()
		{
		}

		public virtual void ApplyIgnoreRopeCollision(bool p_force = false)
		{
		}

		protected virtual IEnumerator RequestApplyIgnoreRopeCollision(bool p_force)
		{
			return null;
		}

		public bool Cut()
		{
			return false;
		}
	}
}
