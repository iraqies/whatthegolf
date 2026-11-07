using Il2CppDummyDll;
using RootMotion.Dynamics;
using UnityEngine;

namespace Olympics.Wrestling
{
	[Token(Token = "0x20011E2")]
	public class StickyObject : MonoBehaviour
	{
		[Token(Token = "0x20011E3")]
		public struct StickInfo
		{
			[Token(Token = "0x4006013")]
			[FieldOffset(Offset = "0x0")]
			public Transform stickTo;

			[Token(Token = "0x4006014")]
			[FieldOffset(Offset = "0x8")]
			public Vector3 offsetOnTransform;

			[Token(Token = "0x4006015")]
			[FieldOffset(Offset = "0x18")]
			public MuscleCollisionBroadcaster muscle;
		}

		[Token(Token = "0x4006009")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float unpin;

		[Token(Token = "0x400600A")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float multiplier;

		[Token(Token = "0x400600B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LayerMask stickToLayer;

		[Token(Token = "0x400600C")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool stickToOtherStickyObjects;

		[Token(Token = "0x400600D")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5780C", Offset = "0x5780C")]
		private Rigidbody StuckOn__BackingField;

		[Token(Token = "0x400600E")]
		[FieldOffset(Offset = "0x30")]
		private Rigidbody stickyRigidbody;

		[Token(Token = "0x400600F")]
		[FieldOffset(Offset = "0x38")]
		private Collider stickyCollider;

		[Token(Token = "0x4006010")]
		[FieldOffset(Offset = "0x40")]
		private Vector3 Velocity;

		[Token(Token = "0x4006011")]
		[FieldOffset(Offset = "0x4C")]
		private bool stickNextFrame;

		[Token(Token = "0x4006012")]
		[FieldOffset(Offset = "0x50")]
		private StickInfo stickInfo;

		[Token(Token = "0x170008DA")]
		public Rigidbody StuckOn
		{
			[Token(Token = "0x60051D0")]
			[Address(RVA = "0x16E0464", Offset = "0x16E0464", VA = "0x16E0464")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x70618", Offset = "0x70618")]
			get
			{
				return null;
			}
			[Token(Token = "0x60051D1")]
			[Address(RVA = "0x16E046C", Offset = "0x16E046C", VA = "0x16E046C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x70628", Offset = "0x70628")]
			private set
			{
			}
		}

		[Token(Token = "0x60051D2")]
		[Address(RVA = "0x16E0474", Offset = "0x16E0474", VA = "0x16E0474")]
		private void Awake()
		{
		}

		[Token(Token = "0x60051D3")]
		[Address(RVA = "0x16E04F4", Offset = "0x16E04F4", VA = "0x16E04F4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60051D4")]
		[Address(RVA = "0x16E0604", Offset = "0x16E0604", VA = "0x16E0604")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60051D5")]
		[Address(RVA = "0x16E0814", Offset = "0x16E0814", VA = "0x16E0814")]
		private bool CheckMask(GameObject go)
		{
			return default;
		}

		[Token(Token = "0x60051D6")]
		[Address(RVA = "0x16E0860", Offset = "0x16E0860", VA = "0x16E0860")]
		public StickyObject()
		{
		}
	}
}
