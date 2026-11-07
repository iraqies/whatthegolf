using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Kilt.EasyRopes2D
{
	[Token(Token = "0x2000097")]
	public class BalloonProperty : MonoBehaviour
	{
		[Token(Token = "0x4000263")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<BallonObjectToCloneByMass> m_spriteChangerModel;

		[Token(Token = "0x4000264")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_extraThrust;

		[Token(Token = "0x4000265")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float m_ballonForceScale;

		[Token(Token = "0x4000266")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_ropeForceScale;

		[Token(Token = "0x4000267")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float m_indirectRopeForceScale;

		[Token(Token = "0x4000268")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AutomaticForceCalculatorCallerEnum m_automaticForceCalculatorOption;

		[Token(Token = "0x4000269")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private bool m_includeIndirectRopesInMassCalc;

		[Token(Token = "0x400026A")]
		[FieldOffset(Offset = "0x35")]
		private bool _needRecalcForce;

		[Token(Token = "0x400026B")]
		[FieldOffset(Offset = "0x36")]
		private bool _needRecalcAndClear;

		[Token(Token = "0x400026C")]
		[FieldOffset(Offset = "0x38")]
		private float _selfMass;

		[Token(Token = "0x400026D")]
		[FieldOffset(Offset = "0x3C")]
		private float _sumOfPluggedRopesMass;

		[Token(Token = "0x400026E")]
		[FieldOffset(Offset = "0x40")]
		private float _sumOfIndirectRopesMass;

		[Token(Token = "0x400026F")]
		[FieldOffset(Offset = "0x44")]
		private float _sumOfOtherObjectsMass;

		[Token(Token = "0x4000270")]
		[FieldOffset(Offset = "0x48")]
		private float _selfMassLerp;

		[Token(Token = "0x4000271")]
		[FieldOffset(Offset = "0x4C")]
		private float _sumOfPluggedRopesMassLerp;

		[Token(Token = "0x4000272")]
		[FieldOffset(Offset = "0x50")]
		private float _sumOfIndirectRopesMassLerp;

		[Token(Token = "0x4000273")]
		[FieldOffset(Offset = "0x54")]
		private float _sumOfOtherObjectsMassLerp;

		[Token(Token = "0x4000274")]
		[FieldOffset(Offset = "0x58")]
		private RopesAttached _ropesAttachedComponent;

		[Token(Token = "0x4000275")]
		[FieldOffset(Offset = "0x60")]
		private Rigidbody2D _rigidBody2DComponent;

		[Token(Token = "0x4000276")]
		[FieldOffset(Offset = "0x68")]
		private bool _firstFixedUpdate;

		[Token(Token = "0x4000277")]
		[FieldOffset(Offset = "0x69")]
		private bool _firstLateUpdate;

		[Token(Token = "0x4000278")]
		[FieldOffset(Offset = "0x6A")]
		private bool _waitOneCycle;

		[Token(Token = "0x4000279")]
		[FieldOffset(Offset = "0x6C")]
		private float _selfMassLerpInitial;

		[Token(Token = "0x400027A")]
		[FieldOffset(Offset = "0x70")]
		private float _sumOfPluggedRopesMassLerpInitial;

		[Token(Token = "0x400027B")]
		[FieldOffset(Offset = "0x74")]
		private float _sumOfIndirectRopesMassLerpInitial;

		[Token(Token = "0x400027C")]
		[FieldOffset(Offset = "0x78")]
		private float _sumOfOtherObjectsMassLerpInitial;

		[Token(Token = "0x400027D")]
		[FieldOffset(Offset = "0x7C")]
		private float _maxTimeToLerp;

		[Token(Token = "0x400027E")]
		[FieldOffset(Offset = "0x80")]
		private float _currentTimeToLerp;

		[Token(Token = "0x17000058")]
		public bool IncludeIndirectRopesInMassCalc
		{
			[Token(Token = "0x60002CC")]
			[Address(RVA = "0x12F8818", Offset = "0x12F8818", VA = "0x12F8818")]
			get
			{
				return default;
			}
			[Token(Token = "0x60002CD")]
			[Address(RVA = "0x12F8820", Offset = "0x12F8820", VA = "0x12F8820")]
			set
			{
			}
		}

		[Token(Token = "0x17000059")]
		public RopesAttached RopesAttachedComponent
		{
			[Token(Token = "0x60002CE")]
			[Address(RVA = "0x12F8848", Offset = "0x12F8848", VA = "0x12F8848")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005A")]
		public AutomaticForceCalculatorCallerEnum AutomaticForceCalculatorOption
		{
			[Token(Token = "0x60002CF")]
			[Address(RVA = "0x12F895C", Offset = "0x12F895C", VA = "0x12F895C")]
			get
			{
				return default;
			}
			[Token(Token = "0x60002D0")]
			[Address(RVA = "0x12F8964", Offset = "0x12F8964", VA = "0x12F8964")]
			set
			{
			}
		}

		[Token(Token = "0x1700005B")]
		public float BallonForceScale
		{
			[Token(Token = "0x60002D1")]
			[Address(RVA = "0x12F8978", Offset = "0x12F8978", VA = "0x12F8978")]
			get
			{
				return default;
			}
			[Token(Token = "0x60002D2")]
			[Address(RVA = "0x12F8980", Offset = "0x12F8980", VA = "0x12F8980")]
			set
			{
			}
		}

		[Token(Token = "0x1700005C")]
		public float IndirectRopeForceScale
		{
			[Token(Token = "0x60002D3")]
			[Address(RVA = "0x12F8D64", Offset = "0x12F8D64", VA = "0x12F8D64")]
			get
			{
				return default;
			}
			[Token(Token = "0x60002D4")]
			[Address(RVA = "0x12F8D6C", Offset = "0x12F8D6C", VA = "0x12F8D6C")]
			set
			{
			}
		}

		[Token(Token = "0x1700005D")]
		public float RopeForceScale
		{
			[Token(Token = "0x60002D5")]
			[Address(RVA = "0x12F8D84", Offset = "0x12F8D84", VA = "0x12F8D84")]
			get
			{
				return default;
			}
			[Token(Token = "0x60002D6")]
			[Address(RVA = "0x12F8D8C", Offset = "0x12F8D8C", VA = "0x12F8D8C")]
			set
			{
			}
		}

		[Token(Token = "0x1700005E")]
		public float ExtraThrust
		{
			[Token(Token = "0x60002D7")]
			[Address(RVA = "0x12F8DA4", Offset = "0x12F8DA4", VA = "0x12F8DA4")]
			get
			{
				return default;
			}
			[Token(Token = "0x60002D8")]
			[Address(RVA = "0x12F8DAC", Offset = "0x12F8DAC", VA = "0x12F8DAC")]
			set
			{
			}
		}

		[Token(Token = "0x1700005F")]
		public List<BallonObjectToCloneByMass> SpriteChangerModel
		{
			[Token(Token = "0x60002D9")]
			[Address(RVA = "0x12F8DC4", Offset = "0x12F8DC4", VA = "0x12F8DC4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002DA")]
			[Address(RVA = "0x12F8DCC", Offset = "0x12F8DCC", VA = "0x12F8DCC")]
			set
			{
			}
		}

		[Token(Token = "0x17000060")]
		public Rigidbody2D RigidBody2DComponent
		{
			[Token(Token = "0x60002DB")]
			[Address(RVA = "0x12F8DD4", Offset = "0x12F8DD4", VA = "0x12F8DD4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x12F8E8C", Offset = "0x12F8E8C", VA = "0x12F8E8C", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x12F8EEC", Offset = "0x12F8EEC", VA = "0x12F8EEC", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x12F8F5C", Offset = "0x12F8F5C", VA = "0x12F8F5C", Slot = "6")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x12F8FC0", Offset = "0x12F8FC0", VA = "0x12F8FC0", Slot = "7")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x12F8FD0", Offset = "0x12F8FD0", VA = "0x12F8FD0", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x12F9160", Offset = "0x12F9160", VA = "0x12F9160", Slot = "9")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x12F921C", Offset = "0x12F921C", VA = "0x12F921C", Slot = "10")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x12F97F0", Offset = "0x12F97F0", VA = "0x12F97F0")]
		protected void HandleOnRopePlugged(Rope2D p_rope)
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x12F97FC", Offset = "0x12F97FC", VA = "0x12F97FC")]
		protected void HandleOnRopeUnplugged(Rope2D p_rope)
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x12F9814", Offset = "0x12F9814", VA = "0x12F9814")]
		protected void HandleOnIndirectRopeCreated(Rope2D p_rope)
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x12F9820", Offset = "0x12F9820", VA = "0x12F9820")]
		protected void HandleOnIndirectRopeDestroyed(Rope2D p_rope)
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x12F982C", Offset = "0x12F982C", VA = "0x12F982C")]
		protected void HandleOnIndirectRopeBreak(Rope2D p_rope)
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x12F9838", Offset = "0x12F9838", VA = "0x12F9838")]
		protected void HandleOnRopeBreak(Rope2D p_rope, int p_brokenIndex)
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x12F9844", Offset = "0x12F9844", VA = "0x12F9844", Slot = "11")]
		protected virtual void InitialRecalcCorrector()
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x12F99EC", Offset = "0x12F99EC", VA = "0x12F99EC", Slot = "12")]
		protected virtual void SetFixedAngleActive(bool p_enabled)
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x12F9A9C", Offset = "0x12F9A9C", VA = "0x12F9A9C", Slot = "13")]
		public virtual void UpdateRopesByBalloonsController()
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x12F9250", Offset = "0x12F9250", VA = "0x12F9250")]
		public void RemoveSelfFromRopesByBalloonsController(bool p_canCreateNewInstanceFromController = true)
		{
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x12F9F90", Offset = "0x12F9F90", VA = "0x12F9F90", Slot = "14")]
		protected virtual Vector3 GetForceAnchor()
		{
			return default;
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x12F883C", Offset = "0x12F883C", VA = "0x12F883C")]
		public void MarkToRecalcForce(bool p_force = true)
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x12FA0B8", Offset = "0x12FA0B8", VA = "0x12FA0B8")]
		public void MarkToRecalcAndClearForce(bool p_force = true)
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x12FA0C4", Offset = "0x12FA0C4", VA = "0x12FA0C4", Slot = "15")]
		protected virtual void UnregisterInitialEventsReceivers()
		{
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x12FA430", Offset = "0x12FA430", VA = "0x12FA430", Slot = "16")]
		protected virtual void RegisterInitialEventsReceivers()
		{
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x12FA7B0", Offset = "0x12FA7B0", VA = "0x12FA7B0", Slot = "17")]
		public virtual void RecalcSelfMass()
		{
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x12FA7F4", Offset = "0x12FA7F4", VA = "0x12FA7F4", Slot = "18")]
		public virtual void RecalcOthersMass()
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x12FA864", Offset = "0x12FA864", VA = "0x12FA864", Slot = "19")]
		public virtual void RecalcRopesMass()
		{
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x12FAEFC", Offset = "0x12FAEFC", VA = "0x12FAEFC", Slot = "20")]
		public virtual void RecalcForces(bool p_forceRecalc = false, bool p_ropesMassOnly = false)
		{
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x12FAFCC", Offset = "0x12FAFCC", VA = "0x12FAFCC", Slot = "21")]
		public virtual void RecalcForcesAndClearBody(bool p_forceRecalc = false, bool p_ropesMassOnly = false)
		{
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x12F8998", Offset = "0x12F8998", VA = "0x12F8998")]
		public void CloneModelForceBallonComponents()
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x12FB048", Offset = "0x12FB048", VA = "0x12FB048", Slot = "22")]
		public virtual float GetIndependentForceIntensity()
		{
			return default;
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x12FB05C", Offset = "0x12FB05C", VA = "0x12FB05C", Slot = "23")]
		public virtual Vector2 GetForceVector()
		{
			return default;
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x12FAFA0", Offset = "0x12FAFA0", VA = "0x12FAFA0")]
		public void ResetTimeToLerp()
		{
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x12FB168", Offset = "0x12FB168", VA = "0x12FB168")]
		public float GetLerpIntensity()
		{
			return default;
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x12FB188", Offset = "0x12FB188", VA = "0x12FB188")]
		protected void LerpValues(float p_intensity)
		{
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x12FB260", Offset = "0x12FB260", VA = "0x12FB260")]
		public BalloonProperty()
		{
		}
	}
}
