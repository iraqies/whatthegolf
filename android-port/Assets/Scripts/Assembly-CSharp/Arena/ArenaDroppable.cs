using Audio;
using Il2CppDummyDll;
using UnityEngine;

namespace Arena
{
	[Token(Token = "0x2001217")]
	public abstract class ArenaDroppable : MonoBehaviour
	{
		[Token(Token = "0x40061C8")]
		[FieldOffset(Offset = "0x18")]
		public Rigidbody Rigidbody;

		[Token(Token = "0x40061C9")]
		[FieldOffset(Offset = "0x20")]
		public ParticleSystem destroyDropParticles;

		[Token(Token = "0x40061CA")]
		[FieldOffset(Offset = "0x28")]
		public AudioEventAsset swooshSfx;

		[Token(Token = "0x40061CB")]
		[FieldOffset(Offset = "0x30")]
		public AudioEventAsset crashSfx;

		[Token(Token = "0x40061CC")]
		[FieldOffset(Offset = "0x38")]
		public ClipSettingsCollection hitPlayerSFX;

		[Token(Token = "0x40061CD")]
		[FieldOffset(Offset = "0x40")]
		protected Animator animator;

		[Token(Token = "0x40061CE")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5857C", Offset = "0x5857C")]
		private Vector2 GridPosition__BackingField;

		[Token(Token = "0x17000931")]
		public Vector2 GridPosition
		{
			[Token(Token = "0x600534D")]
			[Address(RVA = "0x1422424", Offset = "0x1422424", VA = "0x1422424")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x70EE8", Offset = "0x70EE8")]
			get
			{
				return default;
			}
			[Token(Token = "0x600534E")]
			[Address(RVA = "0x142242C", Offset = "0x142242C", VA = "0x142242C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x70EF8", Offset = "0x70EF8")]
			set
			{
			}
		}

		[Token(Token = "0x600534F")]
		[Address(RVA = "0x1422434", Offset = "0x1422434", VA = "0x1422434")]
		public void PlaySwoosh()
		{
		}

		[Token(Token = "0x6005350")]
		[Address(RVA = "0x1422484", Offset = "0x1422484", VA = "0x1422484", Slot = "4")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x6005351")]
		[Address(RVA = "0x1422564", Offset = "0x1422564", VA = "0x1422564", Slot = "5")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6005352")]
		[Address(RVA = "0x142260C", Offset = "0x142260C", VA = "0x142260C")]
		public void CheckHits()
		{
		}

		[Token(Token = "0x6005353")]
		[Address(RVA = "0x1422878", Offset = "0x1422878", VA = "0x1422878", Slot = "6")]
		public virtual Collider[] GetHitColliders()
		{
			return null;
		}

		[Token(Token = "0x6005354")]
		[Address(RVA = "0x14228C0", Offset = "0x14228C0", VA = "0x14228C0", Slot = "7")]
		public virtual void HitPlayer()
		{
		}

		[Token(Token = "0x6005355")]
		[Address(RVA = "0x14228C4", Offset = "0x14228C4", VA = "0x14228C4", Slot = "8")]
		public virtual void HitGround()
		{
		}

		[Token(Token = "0x6005356")]
		[Address(RVA = "0x14228C8", Offset = "0x14228C8", VA = "0x14228C8")]
		protected ArenaDroppable()
		{
		}
	}
}
