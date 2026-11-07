using Audio.Impact;
using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x200135F")]
	public class ImpactUser : MonoBehaviour, ISpatializeDisable
	{
		[Token(Token = "0x40067B0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool getFirstRigidbodyInParent;

		[Token(Token = "0x40067B1")]
		[FieldOffset(Offset = "0x19")]
		[SerializeField]
		private bool sizeAffects;

		[Token(Token = "0x40067B2")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private ObjectWeight objectSize;

		[Token(Token = "0x40067B3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool disableOnOutOfBounds;

		[Token(Token = "0x40067B4")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float startDelay;

		[Token(Token = "0x40067B5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		public ImpactAsset impactAsset;

		[Token(Token = "0x40067B6")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A0F0", Offset = "0x5A0F0")]
		private bool IsEnabled__BackingField;

		[Token(Token = "0x40067B7")]
		[FieldOffset(Offset = "0x31")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A100", Offset = "0x5A100")]
		private bool DisableSpatial__BackingField;

		[Token(Token = "0x40067B8")]
		[FieldOffset(Offset = "0x34")]
		private float nextPlayTime;

		[Token(Token = "0x40067B9")]
		[FieldOffset(Offset = "0x38")]
		private bool isCollisionWithPlayer;

		[Token(Token = "0x40067BA")]
		[FieldOffset(Offset = "0x39")]
		private bool isMultiplayerLevel;

		[Token(Token = "0x40067BB")]
		[FieldOffset(Offset = "0x3C")]
		private int layerMaskGolfBall;

		[Token(Token = "0x17000A2F")]
		public bool GetFirstRigidbodyInParent
		{
			[Token(Token = "0x6005A59")]
			[Address(RVA = "0x14E7F88", Offset = "0x14E7F88", VA = "0x14E7F88")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000A30")]
		public bool SizeAffects
		{
			[Token(Token = "0x6005A5A")]
			[Address(RVA = "0x14E7F90", Offset = "0x14E7F90", VA = "0x14E7F90")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000A31")]
		public ObjectWeight ObjectSize
		{
			[Token(Token = "0x6005A5B")]
			[Address(RVA = "0x14E7F98", Offset = "0x14E7F98", VA = "0x14E7F98")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000A32")]
		public bool DisableOnOutOfBounds
		{
			[Token(Token = "0x6005A5C")]
			[Address(RVA = "0x14E7FA0", Offset = "0x14E7FA0", VA = "0x14E7FA0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000A33")]
		public float StartDelay
		{
			[Token(Token = "0x6005A5D")]
			[Address(RVA = "0x14E7FA8", Offset = "0x14E7FA8", VA = "0x14E7FA8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000A34")]
		public bool IsEnabled
		{
			[Token(Token = "0x6005A5E")]
			[Address(RVA = "0x14E7FB0", Offset = "0x14E7FB0", VA = "0x14E7FB0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x72308", Offset = "0x72308")]
			get
			{
				return default;
			}
			[Token(Token = "0x6005A5F")]
			[Address(RVA = "0x14E7FB8", Offset = "0x14E7FB8", VA = "0x14E7FB8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x72318", Offset = "0x72318")]
			set
			{
			}
		}

		[Token(Token = "0x17000A35")]
		public bool DisableSpatial
		{
			[Token(Token = "0x6005A60")]
			[Address(RVA = "0x14E7FC0", Offset = "0x14E7FC0", VA = "0x14E7FC0", Slot = "5")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x72328", Offset = "0x72328")]
			get
			{
				return default;
			}
			[Token(Token = "0x6005A61")]
			[Address(RVA = "0x14E7FC8", Offset = "0x14E7FC8", VA = "0x14E7FC8", Slot = "4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x72338", Offset = "0x72338")]
			set
			{
			}
		}

		[Token(Token = "0x6005A62")]
		[Address(RVA = "0x14E7FD0", Offset = "0x14E7FD0", VA = "0x14E7FD0")]
		private void Start()
		{
		}

		[Token(Token = "0x6005A63")]
		[Address(RVA = "0x14E802C", Offset = "0x14E802C", VA = "0x14E802C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6005A64")]
		[Address(RVA = "0x14E8214", Offset = "0x14E8214", VA = "0x14E8214", Slot = "6")]
		protected virtual void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6005A65")]
		[Address(RVA = "0x14E8308", Offset = "0x14E8308", VA = "0x14E8308", Slot = "7")]
		protected virtual void OnCollisionEnter2D(Collision2D collision)
		{
		}

		[Token(Token = "0x6005A66")]
		[Address(RVA = "0x14E83F4", Offset = "0x14E83F4", VA = "0x14E83F4", Slot = "8")]
		protected virtual bool Validate(HitInfo info)
		{
			return default;
		}

		[Token(Token = "0x6005A67")]
		[Address(RVA = "0x14E7D70", Offset = "0x14E7D70", VA = "0x14E7D70")]
		public void OnHit(HitInfo info)
		{
		}

		[Token(Token = "0x6005A68")]
		[Address(RVA = "0x14E83FC", Offset = "0x14E83FC", VA = "0x14E83FC")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6005A69")]
		[Address(RVA = "0x14E7B10", Offset = "0x14E7B10", VA = "0x14E7B10")]
		public ImpactUser()
		{
		}
	}
}
