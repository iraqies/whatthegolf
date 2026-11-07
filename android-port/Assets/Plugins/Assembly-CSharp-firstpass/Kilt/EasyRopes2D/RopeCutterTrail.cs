using System.Collections.Generic;
using UnityEngine;

namespace Kilt.EasyRopes2D
{
	public class RopeCutterTrail : MonoBehaviour
	{
		[SerializeField]
		private LayerMask m_collisionMask;

		[SerializeField]
		private bool m_onlyShowWhenGrabTouch;

		[SerializeField]
		private float m_minDistanceToRayCastAll;

		[SerializeField]
		private float m_minDistanceToCut;

		private float _trailTime;

		private bool _cutting;

		private float _currentDeltaTime;

		private float _maxDeltaTime;

		private Vector2 _oldPosition;

		private TrailRenderer _trailComponent;

		private Camera _cameraThatDrawThisObject;

		private bool _grabbing;

		private CameraInputController.MouseOrTouch _touchReference;

		public LayerMask CollisionMask
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public bool Cutting
		{
			get
			{
				return false;
			}
			protected set
			{
			}
		}

		public bool OnlyShowWhenGrabTouch
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float MinDistanceToRayCastAll
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float MinDistanceToCut
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public TrailRenderer TrailComponent => null;

		public Camera CameraThatDrawThisObject => null;

		protected virtual void Start()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		protected virtual void OnTriggerEnter2D(Collider2D p_collider)
		{
		}

		protected virtual void LateUpdate()
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

		protected virtual void OnPress(bool p_isPressed)
		{
		}

		protected virtual void OnDrag(Vector2 p_delta)
		{
		}

		protected virtual void OnDrop(GameObject p_object)
		{
		}

		public virtual void Init()
		{
		}

		public virtual void RegisterEvents()
		{
		}

		public virtual void UnregisterEvents()
		{
		}

		protected void CheckCollisionWithTensionedRopes()
		{
		}

		protected List<Rope2D> GetTensionedCuttableRopes()
		{
			return null;
		}

		protected GameObject GetNodeWithSmallestDistanteToPoint(Rope2D p_rope, Vector2 p_point)
		{
			return null;
		}

		protected void TryRayCastAll(bool p_force = false)
		{
		}

		protected virtual bool TryCut(GameObject p_object)
		{
			return false;
		}

		protected virtual void GrabTouch()
		{
		}

		public bool IsGrabbing()
		{
			return false;
		}

		public bool IsTouchReferenceEqualsCurrentTouch(CameraInputController.MouseOrTouch p_currentTouch)
		{
			return false;
		}

		public bool HaveTouch()
		{
			return false;
		}

		public void UpdateTrail(bool p_isPressing)
		{
		}

		protected virtual void ResetToNonPressingState(bool p_forceDeativateColliders = false)
		{
		}

		public float GetDeltaTime()
		{
			return 0f;
		}
	}
}
