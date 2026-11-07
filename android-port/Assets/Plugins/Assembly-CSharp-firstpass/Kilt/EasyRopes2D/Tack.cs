using UnityEngine;

namespace Kilt.EasyRopes2D
{
	public class Tack : MonoBehaviour
	{
		[SerializeField]
		private bool _isKinematic;

		private bool m_isKinematic;

		public bool IsKinematic
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected virtual void Awake()
		{
		}

		protected virtual void Update()
		{
		}

		protected virtual void CorrectValues()
		{
		}

		public int GetTackIndex()
		{
			return 0;
		}
	}
}
