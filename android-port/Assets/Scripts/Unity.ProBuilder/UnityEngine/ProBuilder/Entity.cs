using Il2CppDummyDll;

namespace UnityEngine.ProBuilder
{
	[Token(Token = "0x200000A")]
	[DisallowMultipleComponent]
	internal sealed class Entity : MonoBehaviour
	{
		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B5E04", Offset = "0x1B5E04")]
		[SerializeField]
		private EntityType m_EntityType;

		[Token(Token = "0x1700000C")]
		public EntityType entityType
		{
			[Token(Token = "0x6000021")]
			[Address(RVA = "0x2A48D38", Offset = "0x2A48D38", VA = "0x2A48D38")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x2A48D40", Offset = "0x2A48D40", VA = "0x2A48D40")]
		public void Awake()
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x2A48E34", Offset = "0x2A48E34", VA = "0x2A48E34")]
		public void SetEntity(EntityType t)
		{
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x2A48E3C", Offset = "0x2A48E3C", VA = "0x2A48E3C")]
		public Entity()
		{
		}
	}
}
