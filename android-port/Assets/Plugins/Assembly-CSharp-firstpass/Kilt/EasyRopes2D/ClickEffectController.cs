using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Kilt.EasyRopes2D
{
	public class ClickEffectController : Singleton<ClickEffectController>
	{
		[CompilerGenerated]
		private static Action<bool> m_OnGlobalPress;

		[CompilerGenerated]
		private static Action<Vector2> m_OnGlobalDrag;

		[CompilerGenerated]
		private static Action<GameObject> m_OnGlobalDrop;

		[SerializeField]
		private float m_pressRadius;

		[SerializeField]
		private GameObject m_clickEffect;

		[SerializeField]
		private GameObject m_trailEffect;

		[SerializeField]
		private Camera m_clickEffectCamera;

		private GameObject _effectInScene;

		private GameObject _trailEffectInScene;

		public float PressRadius
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public GameObject ClickEffect
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public GameObject TrailEffect
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Camera ClickEffectCamera => null;

		public static event Action<bool> OnGlobalPress
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<Vector2> OnGlobalDrag
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<GameObject> OnGlobalDrop
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		protected override void Awake()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		protected virtual void Start()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		protected virtual void OnSceneLoaded(Scene p_scene, LoadSceneMode p_mode)
		{
		}

		protected void RegisterLevelEvents()
		{
		}

		protected void UnregisterLevelEvents()
		{
		}

		protected virtual void RegistedEvents()
		{
		}

		protected virtual void UnregisterEvents()
		{
		}

		protected virtual GameObject FindCloseObjectInRange(Vector2 p_globalPoint, float p_radius)
		{
			return null;
		}

		protected void ShowEffect()
		{
		}

		protected virtual void ShowEffect(Vector2 p_point, float p_radius)
		{
		}

		protected void ShowTrailEffect()
		{
		}

		protected virtual void ShowTrailEffect(Vector2 p_point)
		{
		}

		protected virtual float GetNewRadius(Camera p_newCamera, Vector2 p_screenPoint)
		{
			return 0f;
		}

		protected virtual void TryUpdateCurrentTouch(Camera p_pressCamera)
		{
		}

		protected virtual void HandleOnGlobalPress(bool p_isPressed)
		{
		}

		protected virtual void HandleOnGlobalDrag(Vector2 p_delta)
		{
		}

		protected virtual void HandleOnGlobalDrop(GameObject p_dropObject)
		{
		}
	}
}
