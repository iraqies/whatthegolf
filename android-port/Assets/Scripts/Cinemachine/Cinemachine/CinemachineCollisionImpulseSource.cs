using Il2CppDummyDll;
using UnityEngine;

namespace Cinemachine
{
	[Token(Token = "0x2000081")]
	public class CinemachineCollisionImpulseSource : CinemachineImpulseSource
	{
		[Token(Token = "0x40002D4")]
		[FieldOffset(Offset = "0x20")]
		public LayerMask m_LayerMask;

		[Token(Token = "0x40002D5")]
		[FieldOffset(Offset = "0x28")]
		public string m_IgnoreTag;

		[Token(Token = "0x40002D6")]
		[FieldOffset(Offset = "0x30")]
		public bool m_UseImpactDirection;

		[Token(Token = "0x40002D7")]
		[FieldOffset(Offset = "0x31")]
		public bool m_ScaleImpactWithMass;

		[Token(Token = "0x40002D8")]
		[FieldOffset(Offset = "0x32")]
		public bool m_ScaleImpactWithSpeed;

		[Token(Token = "0x40002D9")]
		[FieldOffset(Offset = "0x38")]
		private Rigidbody mRigidBody;

		[Token(Token = "0x40002DA")]
		[FieldOffset(Offset = "0x40")]
		private Rigidbody2D mRigidBody2D;

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x18EC180", Offset = "0x18EC180", VA = "0x18EC180")]
		private void Start()
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x18EC200", Offset = "0x18EC200", VA = "0x18EC200")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x18EC3EC", Offset = "0x18EC3EC", VA = "0x18EC3EC")]
		private void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x18EC41C", Offset = "0x18EC41C", VA = "0x18EC41C")]
		private float GetMassAndVelocity(Collider other, ref Vector3 vel)
		{
			return default;
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x18EC254", Offset = "0x18EC254", VA = "0x18EC254")]
		private void GenerateImpactEvent(Collider other, Vector3 vel)
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x18EC628", Offset = "0x18EC628", VA = "0x18EC628")]
		private void OnCollisionEnter2D(Collision2D c)
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x18EC818", Offset = "0x18EC818", VA = "0x18EC818")]
		private void OnTriggerEnter2D(Collider2D c)
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x18EC848", Offset = "0x18EC848", VA = "0x18EC848")]
		private float GetMassAndVelocity2D(Collider2D other2d, ref Vector3 vel)
		{
			return default;
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x18EC680", Offset = "0x18EC680", VA = "0x18EC680")]
		private void GenerateImpactEvent2D(Collider2D other2d, Vector3 vel)
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x18ECA54", Offset = "0x18ECA54", VA = "0x18ECA54")]
		public CinemachineCollisionImpulseSource()
		{
		}
	}
}
