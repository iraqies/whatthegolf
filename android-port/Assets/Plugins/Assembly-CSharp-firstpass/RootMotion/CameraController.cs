using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion
{
	[Token(Token = "0x20000DD")]
	public class CameraController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000DE")]
		public enum UpdateMode
		{
			[Token(Token = "0x40004D0")]
			Update = 0,
			[Token(Token = "0x40004D1")]
			FixedUpdate = 1,
			[Token(Token = "0x40004D2")]
			LateUpdate = 2,
			[Token(Token = "0x40004D3")]
			FixedLateUpdate = 3
		}

		[Token(Token = "0x40004AA")]
		[FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x40004AB")]
		[FieldOffset(Offset = "0x20")]
		public Transform rotationSpace;

		[Token(Token = "0x40004AC")]
		[FieldOffset(Offset = "0x28")]
		public UpdateMode updateMode;

		[Token(Token = "0x40004AD")]
		[FieldOffset(Offset = "0x2C")]
		public bool lockCursor;

		[Token(Token = "0x40004AE")]
		[FieldOffset(Offset = "0x2D")]
		public bool smoothFollow;

		[Token(Token = "0x40004AF")]
		[FieldOffset(Offset = "0x30")]
		public Vector3 offset;

		[Token(Token = "0x40004B0")]
		[FieldOffset(Offset = "0x3C")]
		public float followSpeed;

		[Token(Token = "0x40004B1")]
		[FieldOffset(Offset = "0x40")]
		public float rotationSensitivity;

		[Token(Token = "0x40004B2")]
		[FieldOffset(Offset = "0x44")]
		public float yMinLimit;

		[Token(Token = "0x40004B3")]
		[FieldOffset(Offset = "0x48")]
		public float yMaxLimit;

		[Token(Token = "0x40004B4")]
		[FieldOffset(Offset = "0x4C")]
		public bool rotateAlways;

		[Token(Token = "0x40004B5")]
		[FieldOffset(Offset = "0x4D")]
		public bool rotateOnLeftButton;

		[Token(Token = "0x40004B6")]
		[FieldOffset(Offset = "0x4E")]
		public bool rotateOnRightButton;

		[Token(Token = "0x40004B7")]
		[FieldOffset(Offset = "0x4F")]
		public bool rotateOnMiddleButton;

		[Token(Token = "0x40004B8")]
		[FieldOffset(Offset = "0x50")]
		public float distance;

		[Token(Token = "0x40004B9")]
		[FieldOffset(Offset = "0x54")]
		public float minDistance;

		[Token(Token = "0x40004BA")]
		[FieldOffset(Offset = "0x58")]
		public float maxDistance;

		[Token(Token = "0x40004BB")]
		[FieldOffset(Offset = "0x5C")]
		public float zoomSpeed;

		[Token(Token = "0x40004BC")]
		[FieldOffset(Offset = "0x60")]
		public float zoomSensitivity;

		[Token(Token = "0x40004BD")]
		[FieldOffset(Offset = "0x64")]
		public LayerMask blockingLayers;

		[Token(Token = "0x40004BE")]
		[FieldOffset(Offset = "0x68")]
		public float blockingRadius;

		[Token(Token = "0x40004BF")]
		[FieldOffset(Offset = "0x6C")]
		public float blockingSmoothTime;

		[Token(Token = "0x40004C0")]
		[FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x35424", Offset = "0x35424")]
		public float blockedOffset;

		[Token(Token = "0x40004C1")]
		[FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3543C", Offset = "0x3543C")]
		private float x__BackingField;

		[Token(Token = "0x40004C2")]
		[FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3544C", Offset = "0x3544C")]
		private float y__BackingField;

		[Token(Token = "0x40004C3")]
		[FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3545C", Offset = "0x3545C")]
		private float distanceTarget__BackingField;

		[Token(Token = "0x40004C4")]
		[FieldOffset(Offset = "0x80")]
		private Vector3 targetDistance;

		[Token(Token = "0x40004C5")]
		[FieldOffset(Offset = "0x8C")]
		private Vector3 position;

		[Token(Token = "0x40004C6")]
		[FieldOffset(Offset = "0x98")]
		private Quaternion rotation;

		[Token(Token = "0x40004C7")]
		[FieldOffset(Offset = "0xA8")]
		private Vector3 smoothPosition;

		[Token(Token = "0x40004C8")]
		[FieldOffset(Offset = "0xB8")]
		private Camera cam;

		[Token(Token = "0x40004C9")]
		[FieldOffset(Offset = "0xC0")]
		private bool fixedFrame;

		[Token(Token = "0x40004CA")]
		[FieldOffset(Offset = "0xC4")]
		private float fixedDeltaTime;

		[Token(Token = "0x40004CB")]
		[FieldOffset(Offset = "0xC8")]
		private Quaternion r;

		[Token(Token = "0x40004CC")]
		[FieldOffset(Offset = "0xD8")]
		private Vector3 lastUp;

		[Token(Token = "0x40004CD")]
		[FieldOffset(Offset = "0xE4")]
		private float blockedDistance;

		[Token(Token = "0x40004CE")]
		[FieldOffset(Offset = "0xE8")]
		private float blockedDistanceV;

		[Token(Token = "0x170000CF")]
		public float x
		{
			[Token(Token = "0x6000593")]
			[Address(RVA = "0x130CE78", Offset = "0x130CE78", VA = "0x130CE78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x382B4", Offset = "0x382B4")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000594")]
			[Address(RVA = "0x130CE80", Offset = "0x130CE80", VA = "0x130CE80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x382C4", Offset = "0x382C4")]
			private set
			{
			}
		}

		[Token(Token = "0x170000D0")]
		public float y
		{
			[Token(Token = "0x6000595")]
			[Address(RVA = "0x130CE88", Offset = "0x130CE88", VA = "0x130CE88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x382D4", Offset = "0x382D4")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000596")]
			[Address(RVA = "0x130CE90", Offset = "0x130CE90", VA = "0x130CE90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x382E4", Offset = "0x382E4")]
			private set
			{
			}
		}

		[Token(Token = "0x170000D1")]
		public float distanceTarget
		{
			[Token(Token = "0x6000597")]
			[Address(RVA = "0x130CE98", Offset = "0x130CE98", VA = "0x130CE98")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x382F4", Offset = "0x382F4")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000598")]
			[Address(RVA = "0x130CEA0", Offset = "0x130CEA0", VA = "0x130CEA0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x38304", Offset = "0x38304")]
			private set
			{
			}
		}

		[Token(Token = "0x170000D2")]
		private float zoomAdd
		{
			[Token(Token = "0x60005A2")]
			[Address(RVA = "0x130D79C", Offset = "0x130D79C", VA = "0x130D79C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x130CEA8", Offset = "0x130CEA8", VA = "0x130CEA8")]
		public void SetAngles(Quaternion rotation)
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x130CEE4", Offset = "0x130CEE4", VA = "0x130CEE4")]
		public void SetAngles(float yaw, float pitch)
		{
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x130CEEC", Offset = "0x130CEEC", VA = "0x130CEEC", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x130D010", Offset = "0x130D010", VA = "0x130D010", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x130D06C", Offset = "0x130D06C", VA = "0x130D06C", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x130D0D4", Offset = "0x130D0D4", VA = "0x130D0D4", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x130D13C", Offset = "0x130D13C", VA = "0x130D13C")]
		public void UpdateInput()
		{
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x130D044", Offset = "0x130D044", VA = "0x130D044")]
		public void UpdateTransform()
		{
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x130D31C", Offset = "0x130D31C", VA = "0x130D31C")]
		public void UpdateTransform(float deltaTime)
		{
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x130D76C", Offset = "0x130D76C", VA = "0x130D76C")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default;
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x130D814", Offset = "0x130D814", VA = "0x130D814")]
		public CameraController()
		{
		}
	}
}
