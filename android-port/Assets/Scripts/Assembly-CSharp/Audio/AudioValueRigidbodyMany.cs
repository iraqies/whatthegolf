using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x20013D5")]
	public class AudioValueRigidbodyMany : BaseAudioValue
	{
		[Token(Token = "0x4006A9D")]
		[FieldOffset(Offset = "0x38")]
		public List<Rigidbody> rigid;

		[Token(Token = "0x4006A9E")]
		[FieldOffset(Offset = "0x40")]
		public List<Rigidbody2D> rigid2D;

		[Token(Token = "0x4006A9F")]
		[FieldOffset(Offset = "0x48")]
		public AudioSource audioSource;

		[Token(Token = "0x4006AA0")]
		[FieldOffset(Offset = "0x50")]
		public bool moveAudioSourceToMiddlePosition;

		[Token(Token = "0x4006AA1")]
		[FieldOffset(Offset = "0x54")]
		public float PositionChangeSpeed;

		[Token(Token = "0x4006AA2")]
		[FieldOffset(Offset = "0x58")]
		public float minVelocityThreshold;

		[Token(Token = "0x4006AA3")]
		[FieldOffset(Offset = "0x5C")]
		public bool removeOnOutOfBounds;

		[Token(Token = "0x4006AA4")]
		[FieldOffset(Offset = "0x60")]
		public float groundCheckFrequency;

		[Token(Token = "0x4006AA5")]
		[FieldOffset(Offset = "0x64")]
		public float groundCheckDistance;

		[Token(Token = "0x4006AA6")]
		[FieldOffset(Offset = "0x68")]
		public LayerMask groundIs;

		[Token(Token = "0x4006AA7")]
		[FieldOffset(Offset = "0x6C")]
		public float averageVelocity;

		[Token(Token = "0x4006AA8")]
		[FieldOffset(Offset = "0x70")]
		private List<Rigidbody> currentRigids;

		[Token(Token = "0x4006AA9")]
		[FieldOffset(Offset = "0x78")]
		private List<Rigidbody2D> currentRigids2D;

		[Token(Token = "0x4006AAA")]
		[FieldOffset(Offset = "0x80")]
		private Vector3 middlePosition;

		[Token(Token = "0x4006AAB")]
		[FieldOffset(Offset = "0x8C")]
		private Vector3 lastPosition;

		[Token(Token = "0x4006AAC")]
		[FieldOffset(Offset = "0x98")]
		private float groundCheckTimer;

		[Token(Token = "0x17000A76")]
		private float groundCheckCooldown
		{
			[Token(Token = "0x6005C7F")]
			[Address(RVA = "0x1510FB4", Offset = "0x1510FB4", VA = "0x1510FB4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000A77")]
		protected override bool Use2D
		{
			[Token(Token = "0x6005C80")]
			[Address(RVA = "0x1510FC4", Offset = "0x1510FC4", VA = "0x1510FC4", Slot = "6")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6005C81")]
		[Address(RVA = "0x151101C", Offset = "0x151101C", VA = "0x151101C")]
		private void Start()
		{
		}

		[Token(Token = "0x6005C82")]
		[Address(RVA = "0x15112C0", Offset = "0x15112C0", VA = "0x15112C0")]
		private void Update()
		{
		}

		[Token(Token = "0x6005C83")]
		[Address(RVA = "0x151142C", Offset = "0x151142C", VA = "0x151142C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6005C84")]
		[Address(RVA = "0x1511960", Offset = "0x1511960", VA = "0x1511960", Slot = "7")]
		protected override void SetValue()
		{
		}

		[Token(Token = "0x6005C85")]
		[Address(RVA = "0x151199C", Offset = "0x151199C", VA = "0x151199C")]
		private void SetValuesFrom3D()
		{
		}

		[Token(Token = "0x6005C86")]
		[Address(RVA = "0x1511998", Offset = "0x1511998", VA = "0x1511998")]
		private void SetValuesFrom2D()
		{
		}

		[Token(Token = "0x6005C87")]
		[Address(RVA = "0x15116B8", Offset = "0x15116B8", VA = "0x15116B8")]
		private void GroundCheck3D()
		{
		}

		[Token(Token = "0x6005C88")]
		[Address(RVA = "0x15114A8", Offset = "0x15114A8", VA = "0x15114A8")]
		private void GroundCheck2D()
		{
		}

		[Token(Token = "0x6005C89")]
		[Address(RVA = "0x1511B10", Offset = "0x1511B10", VA = "0x1511B10")]
		private void OnAnyOutOfBounds(TriggerInfo info)
		{
		}

		[Token(Token = "0x6005C8A")]
		[Address(RVA = "0x1511CEC", Offset = "0x1511CEC", VA = "0x1511CEC")]
		private bool OutOfBounds(GameObject otherHit)
		{
			return default;
		}

		[Token(Token = "0x6005C8B")]
		[Address(RVA = "0x1511E0C", Offset = "0x1511E0C", VA = "0x1511E0C")]
		public AudioValueRigidbodyMany()
		{
		}
	}
}
