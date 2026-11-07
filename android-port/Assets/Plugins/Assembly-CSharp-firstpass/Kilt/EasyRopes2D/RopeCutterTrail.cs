using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Kilt.EasyRopes2D
{
	[Token(Token = "0x20000A5")]
	public class RopeCutterTrail : MonoBehaviour
	{
		[Token(Token = "0x40002E7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private LayerMask m_collisionMask;

		[Token(Token = "0x40002E8")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private bool m_onlyShowWhenGrabTouch;

		[Token(Token = "0x40002E9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_minDistanceToRayCastAll;

		[Token(Token = "0x40002EA")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float m_minDistanceToCut;

		[Token(Token = "0x40002EB")]
		[FieldOffset(Offset = "0x28")]
		private float _trailTime;

		[Token(Token = "0x40002EC")]
		[FieldOffset(Offset = "0x2C")]
		private bool _cutting;

		[Token(Token = "0x40002ED")]
		[FieldOffset(Offset = "0x30")]
		private float _currentDeltaTime;

		[Token(Token = "0x40002EE")]
		[FieldOffset(Offset = "0x34")]
		private float _maxDeltaTime;

		[Token(Token = "0x40002EF")]
		[FieldOffset(Offset = "0x38")]
		private Vector2 _oldPosition;

		[Token(Token = "0x40002F0")]
		[FieldOffset(Offset = "0x40")]
		private TrailRenderer _trailComponent;

		[Token(Token = "0x40002F1")]
		[FieldOffset(Offset = "0x48")]
		private Camera _cameraThatDrawThisObject;

		[Token(Token = "0x40002F2")]
		[FieldOffset(Offset = "0x50")]
		private bool _grabbing;

		[Token(Token = "0x40002F3")]
		[FieldOffset(Offset = "0x58")]
		private CameraInputController.MouseOrTouch _touchReference;

		[Token(Token = "0x17000080")]
		public LayerMask CollisionMask
		{
			[Token(Token = "0x6000399")]
			[Address(RVA = "0x13ED9FC", Offset = "0x13ED9FC", VA = "0x13ED9FC")]
			get
			{
				return default;
			}
			[Token(Token = "0x600039A")]
			[Address(RVA = "0x13EDA04", Offset = "0x13EDA04", VA = "0x13EDA04")]
			set
			{
			}
		}

		[Token(Token = "0x17000081")]
		public bool Cutting
		{
			[Token(Token = "0x600039B")]
			[Address(RVA = "0x13EDA54", Offset = "0x13EDA54", VA = "0x13EDA54")]
			get
			{
				return default;
			}
			[Token(Token = "0x600039C")]
			[Address(RVA = "0x13EDA5C", Offset = "0x13EDA5C", VA = "0x13EDA5C")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000082")]
		public bool OnlyShowWhenGrabTouch
		{
			[Token(Token = "0x600039D")]
			[Address(RVA = "0x13EDB54", Offset = "0x13EDB54", VA = "0x13EDB54")]
			get
			{
				return default;
			}
			[Token(Token = "0x600039E")]
			[Address(RVA = "0x13EDB5C", Offset = "0x13EDB5C", VA = "0x13EDB5C")]
			set
			{
			}
		}

		[Token(Token = "0x17000083")]
		public float MinDistanceToRayCastAll
		{
			[Token(Token = "0x600039F")]
			[Address(RVA = "0x13EDB70", Offset = "0x13EDB70", VA = "0x13EDB70")]
			get
			{
				return default;
			}
			[Token(Token = "0x60003A0")]
			[Address(RVA = "0x13EDB78", Offset = "0x13EDB78", VA = "0x13EDB78")]
			set
			{
			}
		}

		[Token(Token = "0x17000084")]
		public float MinDistanceToCut
		{
			[Token(Token = "0x60003A1")]
			[Address(RVA = "0x13EDB90", Offset = "0x13EDB90", VA = "0x13EDB90")]
			get
			{
				return default;
			}
			[Token(Token = "0x60003A2")]
			[Address(RVA = "0x13EDB98", Offset = "0x13EDB98", VA = "0x13EDB98")]
			set
			{
			}
		}

		[Token(Token = "0x17000085")]
		public TrailRenderer TrailComponent
		{
			[Token(Token = "0x60003A3")]
			[Address(RVA = "0x13EDBB0", Offset = "0x13EDBB0", VA = "0x13EDBB0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000086")]
		public Camera CameraThatDrawThisObject
		{
			[Token(Token = "0x60003A4")]
			[Address(RVA = "0x13EDC5C", Offset = "0x13EDC5C", VA = "0x13EDC5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x13EDE58", Offset = "0x13EDE58", VA = "0x13EDE58", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x13EDE94", Offset = "0x13EDE94", VA = "0x13EDE94", Slot = "5")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x13EDEA4", Offset = "0x13EDEA4", VA = "0x13EDEA4", Slot = "6")]
		protected virtual void OnTriggerEnter2D(Collider2D p_collider)
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x13EDF98", Offset = "0x13EDF98", VA = "0x13EDF98", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x13EE1DC", Offset = "0x13EE1DC", VA = "0x13EE1DC", Slot = "8")]
		protected virtual void HandleOnGlobalPress(bool p_isPressed)
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x13EE400", Offset = "0x13EE400", VA = "0x13EE400", Slot = "9")]
		protected virtual void HandleOnGlobalDrag(Vector2 p_delta)
		{
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x13EE758", Offset = "0x13EE758", VA = "0x13EE758", Slot = "10")]
		protected virtual void HandleOnGlobalDrop(GameObject p_dropObject)
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x13EE824", Offset = "0x13EE824", VA = "0x13EE824", Slot = "11")]
		protected virtual void OnPress(bool p_isPressed)
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x13EE838", Offset = "0x13EE838", VA = "0x13EE838", Slot = "12")]
		protected virtual void OnDrag(Vector2 p_delta)
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x13EE850", Offset = "0x13EE850", VA = "0x13EE850", Slot = "13")]
		protected virtual void OnDrop(GameObject p_object)
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x13EE8B4", Offset = "0x13EE8B4", VA = "0x13EE8B4", Slot = "14")]
		public virtual void Init()
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x13EE96C", Offset = "0x13EE96C", VA = "0x13EE96C", Slot = "15")]
		public virtual void RegisterEvents()
		{
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x13EEB88", Offset = "0x13EEB88", VA = "0x13EEB88", Slot = "16")]
		public virtual void UnregisterEvents()
		{
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x13EED88", Offset = "0x13EED88", VA = "0x13EED88")]
		protected void CheckCollisionWithTensionedRopes()
		{
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x13EF108", Offset = "0x13EF108", VA = "0x13EF108")]
		protected List<Rope2D> GetTensionedCuttableRopes()
		{
			return null;
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x13EF41C", Offset = "0x13EF41C", VA = "0x13EF41C")]
		protected GameObject GetNodeWithSmallestDistanteToPoint(Rope2D p_rope, Vector2 p_point)
		{
			return null;
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x13EDFA0", Offset = "0x13EDFA0", VA = "0x13EDFA0")]
		protected void TryRayCastAll(bool p_force = false)
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x13EF6E8", Offset = "0x13EF6E8", VA = "0x13EF6E8", Slot = "17")]
		protected virtual bool TryCut(GameObject p_object)
		{
			return default;
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x13EF7D8", Offset = "0x13EF7D8", VA = "0x13EF7D8", Slot = "18")]
		protected virtual void GrabTouch()
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x13EE4A0", Offset = "0x13EE4A0", VA = "0x13EE4A0")]
		public bool IsGrabbing()
		{
			return default;
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x13EE2B4", Offset = "0x13EE2B4", VA = "0x13EE2B4")]
		public bool IsTouchReferenceEqualsCurrentTouch(CameraInputController.MouseOrTouch p_currentTouch)
		{
			return default;
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x13EF9D8", Offset = "0x13EF9D8", VA = "0x13EF9D8")]
		public bool HaveTouch()
		{
			return default;
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x13EE4C0", Offset = "0x13EE4C0", VA = "0x13EE4C0")]
		public void UpdateTrail(bool p_isPressing)
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x13EFBB4", Offset = "0x13EFBB4", VA = "0x13EFBB4", Slot = "19")]
		protected virtual void ResetToNonPressingState(bool p_forceDeativateColliders = false)
		{
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x13EFBAC", Offset = "0x13EFBAC", VA = "0x13EFBAC")]
		public float GetDeltaTime()
		{
			return default;
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x13EFD68", Offset = "0x13EFD68", VA = "0x13EFD68")]
		public RopeCutterTrail()
		{
		}
	}
}
