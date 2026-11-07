using Kilt.Collections;
using UnityEngine;

namespace Kilt
{
	[ExecuteInEditMode]
	public class MarkedToDestroy : MonoBehaviour
	{
		private static ArrayList<MarkedToDestroy> _markedToDestroyInstances;

		[SerializeField]
		private Object m_target;

		[SerializeField]
		private bool m_onlyDestroyInEditor;

		[SerializeField]
		private bool m_destroyOnStart;

		[SerializeField]
		private float m_timeToDestroy;

		[SerializeField]
		private bool m_ignoreTimeScale;

		public Object Target
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool OnlyDestroyInEditor
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool DestroyOnStart
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float TimeToDestroy
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool IgnoreTimeScale
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected GameObject GameObjectCastedTarget => null;

		protected Component ComponentCastedTarget => null;

		protected virtual void Awake()
		{
		}

		protected virtual void Start()
		{
		}

		protected virtual void Update()
		{
		}

		protected virtual void LateUpdate()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		protected virtual void UpdateTime()
		{
		}

		protected virtual void DestroyTarget()
		{
		}

		protected virtual void InitAsGameObjectTarget()
		{
		}

		protected void CheckActivation()
		{
		}

		private void ReverseCheckActivation()
		{
		}

		public static bool IsMarked(Object p_object)
		{
			return false;
		}

		public static MarkedToDestroy GetMark(Object p_object)
		{
			return null;
		}

		public static void RemoveMark(Object p_object)
		{
		}
	}
}
