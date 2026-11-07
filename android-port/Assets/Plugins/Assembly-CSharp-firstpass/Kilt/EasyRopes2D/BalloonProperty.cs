using System.Collections.Generic;
using UnityEngine;

namespace Kilt.EasyRopes2D
{
	public class BalloonProperty : MonoBehaviour
	{
		[SerializeField]
		private List<BallonObjectToCloneByMass> m_spriteChangerModel;

		[SerializeField]
		private float m_extraThrust;

		[SerializeField]
		private float m_ballonForceScale;

		[SerializeField]
		private float m_ropeForceScale;

		[SerializeField]
		private float m_indirectRopeForceScale;

		[SerializeField]
		private AutomaticForceCalculatorCallerEnum m_automaticForceCalculatorOption;

		[SerializeField]
		private bool m_includeIndirectRopesInMassCalc;

		private bool _needRecalcForce;

		private bool _needRecalcAndClear;

		private float _selfMass;

		private float _sumOfPluggedRopesMass;

		private float _sumOfIndirectRopesMass;

		private float _sumOfOtherObjectsMass;

		private float _selfMassLerp;

		private float _sumOfPluggedRopesMassLerp;

		private float _sumOfIndirectRopesMassLerp;

		private float _sumOfOtherObjectsMassLerp;

		private RopesAttached _ropesAttachedComponent;

		private Rigidbody2D _rigidBody2DComponent;

		private bool _firstFixedUpdate;

		private bool _firstLateUpdate;

		private bool _waitOneCycle;

		private float _selfMassLerpInitial;

		private float _sumOfPluggedRopesMassLerpInitial;

		private float _sumOfIndirectRopesMassLerpInitial;

		private float _sumOfOtherObjectsMassLerpInitial;

		private float _maxTimeToLerp;

		private float _currentTimeToLerp;

		public bool IncludeIndirectRopesInMassCalc
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public RopesAttached RopesAttachedComponent => null;

		public AutomaticForceCalculatorCallerEnum AutomaticForceCalculatorOption
		{
			get
			{
				return AutomaticForceCalculatorCallerEnum.Never;
			}
			set
			{
			}
		}

		public float BallonForceScale
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float IndirectRopeForceScale
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float RopeForceScale
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float ExtraThrust
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public List<BallonObjectToCloneByMass> SpriteChangerModel
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Rigidbody2D RigidBody2DComponent => null;

		protected virtual void Awake()
		{
		}

		protected virtual void Start()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		protected virtual void FixedUpdate()
		{
		}

		protected virtual void LateUpdate()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		protected void HandleOnRopePlugged(Rope2D p_rope)
		{
		}

		protected void HandleOnRopeUnplugged(Rope2D p_rope)
		{
		}

		protected void HandleOnIndirectRopeCreated(Rope2D p_rope)
		{
		}

		protected void HandleOnIndirectRopeDestroyed(Rope2D p_rope)
		{
		}

		protected void HandleOnIndirectRopeBreak(Rope2D p_rope)
		{
		}

		protected void HandleOnRopeBreak(Rope2D p_rope, int p_brokenIndex)
		{
		}

		protected virtual void InitialRecalcCorrector()
		{
		}

		protected virtual void SetFixedAngleActive(bool p_enabled)
		{
		}

		public virtual void UpdateRopesByBalloonsController()
		{
		}

		public void RemoveSelfFromRopesByBalloonsController(bool p_canCreateNewInstanceFromController = true)
		{
		}

		protected virtual Vector3 GetForceAnchor()
		{
			return default;
		}

		public void MarkToRecalcForce(bool p_force = true)
		{
		}

		public void MarkToRecalcAndClearForce(bool p_force = true)
		{
		}

		protected virtual void UnregisterInitialEventsReceivers()
		{
		}

		protected virtual void RegisterInitialEventsReceivers()
		{
		}

		public virtual void RecalcSelfMass()
		{
		}

		public virtual void RecalcOthersMass()
		{
		}

		public virtual void RecalcRopesMass()
		{
		}

		public virtual void RecalcForces(bool p_forceRecalc = false, bool p_ropesMassOnly = false)
		{
		}

		public virtual void RecalcForcesAndClearBody(bool p_forceRecalc = false, bool p_ropesMassOnly = false)
		{
		}

		public void CloneModelForceBallonComponents()
		{
		}

		public virtual float GetIndependentForceIntensity()
		{
			return 0f;
		}

		public virtual Vector2 GetForceVector()
		{
			return default;
		}

		public void ResetTimeToLerp()
		{
		}

		public float GetLerpIntensity()
		{
			return 0f;
		}

		protected void LerpValues(float p_intensity)
		{
		}
	}
}
