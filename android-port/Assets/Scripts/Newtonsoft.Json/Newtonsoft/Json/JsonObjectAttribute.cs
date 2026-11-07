using Il2CppDummyDll;

namespace Newtonsoft.Json
{
	[Token(Token = "0x200001C")]
	[Attribute(Name = "AttributeUsageAttribute", RVA = "0x182820", Offset = "0x182820")]
	public sealed class JsonObjectAttribute : JsonContainerAttribute
	{
		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x50")]
		private MemberSerialization _memberSerialization;

		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x54")]
		internal MissingMemberHandling? _missingMemberHandling;

		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x5C")]
		internal Required? _itemRequired;

		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x64")]
		internal NullValueHandling? _itemNullValueHandling;

		[Token(Token = "0x1700000F")]
		public MemberSerialization MemberSerialization
		{
			[Token(Token = "0x6000036")]
			[Address(RVA = "0x22E9FF0", Offset = "0x22E9FF0", VA = "0x22E9FF0")]
			get
			{
				return default;
			}
		}
	}
}
