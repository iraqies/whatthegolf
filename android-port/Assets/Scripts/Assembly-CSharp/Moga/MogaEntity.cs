using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;

namespace Moga
{
	[Token(Token = "0x20010CA")]
	public class MogaEntity : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20010CB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47B64", Offset = "0x47B64")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4005882")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4005883")]
			[FieldOffset(Offset = "0x8")]
			public static Predicate<MogaEntity> _003C_003E9__30_0;

			[Token(Token = "0x6004B3E")]
			[Address(RVA = "0x17F8A04", Offset = "0x17F8A04", VA = "0x17F8A04")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6004B3F")]
			[Address(RVA = "0x17F8A0C", Offset = "0x17F8A0C", VA = "0x17F8A0C")]
			internal bool _003CSelectNewTarget_003Eb__30_0(MogaEntity e)
			{
				return default;
			}
		}

		[Token(Token = "0x400586C")]
		[FieldOffset(Offset = "0x18")]
		public float AttackRange;

		[Token(Token = "0x400586D")]
		[FieldOffset(Offset = "0x1C")]
		public float StartHealth;

		[Token(Token = "0x400586E")]
		[FieldOffset(Offset = "0x20")]
		public float AttackInterval;

		[Token(Token = "0x400586F")]
		[FieldOffset(Offset = "0x24")]
		public float Damage;

		[Token(Token = "0x4005870")]
		[FieldOffset(Offset = "0x28")]
		public int TeamIndex;

		[Token(Token = "0x4005871")]
		[FieldOffset(Offset = "0x2C")]
		public LayerMask AttackLayer;

		[Token(Token = "0x4005872")]
		[FieldOffset(Offset = "0x30")]
		public Transform AttackMuzzle;

		[Token(Token = "0x4005873")]
		[FieldOffset(Offset = "0x38")]
		public Transform AttackBase;

		[Token(Token = "0x4005874")]
		[FieldOffset(Offset = "0x40")]
		public float CurrentHealth;

		[Token(Token = "0x4005875")]
		[FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x560B0", Offset = "0x560B0")]
		private Collider Collider__BackingField;

		[Token(Token = "0x4005876")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private List<MogaEntity> entitiesInRange;

		[Token(Token = "0x4005877")]
		[FieldOffset(Offset = "0x58")]
		protected MogaEntity currentTarget;

		[Token(Token = "0x4005878")]
		[FieldOffset(Offset = "0x60")]
		private float attackTimer;

		[Token(Token = "0x4005879")]
		[FieldOffset(Offset = "0x68")]
		private NavMeshAgent agent;

		[Token(Token = "0x400587A")]
		[FieldOffset(Offset = "0x70")]
		private MogaGameController gameController;

		[Token(Token = "0x400587B")]
		[FieldOffset(Offset = "0x78")]
		private LineRenderer lineRenderer;

		[Token(Token = "0x400587C")]
		[FieldOffset(Offset = "0x80")]
		private float damageTimer;

		[Token(Token = "0x400587D")]
		[FieldOffset(Offset = "0x84")]
		private float lineTimer;

		[Token(Token = "0x400587E")]
		[FieldOffset(Offset = "0x88")]
		private MeshRenderer renderer;

		[Token(Token = "0x400587F")]
		[FieldOffset(Offset = "0x90")]
		private Color startColor;

		[Token(Token = "0x4005880")]
		[FieldOffset(Offset = "0xA0")]
		private Color targetColor;

		[Token(Token = "0x4005881")]
		[FieldOffset(Offset = "0xB0")]
		private Vector3 lastNavmeshTarget;

		[Token(Token = "0x170007F1")]
		public Collider Collider
		{
			[Token(Token = "0x6004B2D")]
			[Address(RVA = "0x156A954", Offset = "0x156A954", VA = "0x156A954")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F924", Offset = "0x6F924")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004B2E")]
			[Address(RVA = "0x156A95C", Offset = "0x156A95C", VA = "0x156A95C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F934", Offset = "0x6F934")]
			private set
			{
			}
		}

		[Token(Token = "0x6004B2F")]
		[Address(RVA = "0x156A964", Offset = "0x156A964", VA = "0x156A964", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6004B30")]
		[Address(RVA = "0x156AE84", Offset = "0x156AE84", VA = "0x156AE84")]
		private void Update()
		{
		}

		[Token(Token = "0x6004B31")]
		[Address(RVA = "0x156B224", Offset = "0x156B224", VA = "0x156B224")]
		private void AttackTarget()
		{
		}

		[Token(Token = "0x6004B32")]
		[Address(RVA = "0x156B554", Offset = "0x156B554", VA = "0x156B554")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6004B33")]
		[Address(RVA = "0x156B890", Offset = "0x156B890", VA = "0x156B890")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x6004B34")]
		[Address(RVA = "0x156B894", Offset = "0x156B894", VA = "0x156B894", Slot = "5")]
		protected virtual void SelectNewTarget()
		{
		}

		[Token(Token = "0x6004B35")]
		[Address(RVA = "0x156B558", Offset = "0x156B558", VA = "0x156B558")]
		private void CheckObject(Collider col)
		{
		}

		[Token(Token = "0x6004B36")]
		[Address(RVA = "0x156BC18", Offset = "0x156BC18", VA = "0x156BC18", Slot = "6")]
		protected virtual void Die()
		{
		}

		[Token(Token = "0x6004B37")]
		[Address(RVA = "0x156BC9C", Offset = "0x156BC9C", VA = "0x156BC9C")]
		public void StartEntity()
		{
		}

		[Token(Token = "0x6004B38")]
		[Address(RVA = "0x156B498", Offset = "0x156B498", VA = "0x156B498")]
		public void TakeDamage(float damage)
		{
		}

		[Token(Token = "0x6004B39")]
		[Address(RVA = "0x156B39C", Offset = "0x156B39C", VA = "0x156B39C")]
		public void SetNavMeshTarget(Vector3 pos)
		{
		}

		[Token(Token = "0x6004B3A")]
		[Address(RVA = "0x156BDF8", Offset = "0x156BDF8", VA = "0x156BDF8")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6004B3B")]
		[Address(RVA = "0x156BF04", Offset = "0x156BF04", VA = "0x156BF04")]
		public MogaEntity()
		{
		}

		[Token(Token = "0x6004B3C")]
		[Address(RVA = "0x156BF20", Offset = "0x156BF20", VA = "0x156BF20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F944", Offset = "0x6F944")]
		private float _003CSelectNewTarget_003Eb__30_1(MogaEntity e)
		{
			return default;
		}
	}
}
