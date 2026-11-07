using System;
using Il2CppDummyDll;

namespace PlayFab.Json
{
	[Token(Token = "0x200119B")]
	public class SimpleJsonInstance : ISerializerPlugin, IPlayFabPlugin
	{
		[Token(Token = "0x200119C")]
		public class PlayFabSimpleJsonCuztomization : PocoJsonSerializerStrategy
		{
			[Token(Token = "0x6005055")]
			[Address(RVA = "0x184E24C", Offset = "0x184E24C", VA = "0x184E24C", Slot = "12")]
			public override object DeserializeObject(object value, Type type)
			{
				return null;
			}

			[Token(Token = "0x6005056")]
			[Address(RVA = "0x184E790", Offset = "0x184E790", VA = "0x184E790", Slot = "14")]
			protected override bool TrySerializeKnownTypes(object input, out object output)
			{
				return default;
			}

			[Token(Token = "0x6005057")]
			[Address(RVA = "0x184EA78", Offset = "0x184EA78", VA = "0x184EA78")]
			public PlayFabSimpleJsonCuztomization()
			{
			}
		}

		[Token(Token = "0x4005F00")]
		[FieldOffset(Offset = "0x0")]
		public static PlayFabSimpleJsonCuztomization ApiSerializerStrategy;

		[Token(Token = "0x6005051")]
		public T DeserializeObject<T>(string json)
		{
			return (T)null;
		}

		[Token(Token = "0x6005052")]
		[Address(RVA = "0x16ACB08", Offset = "0x16ACB08", VA = "0x16ACB08", Slot = "5")]
		public string SerializeObject(object json)
		{
			return null;
		}

		[Token(Token = "0x6005053")]
		[Address(RVA = "0x16ACBB4", Offset = "0x16ACBB4", VA = "0x16ACBB4")]
		public SimpleJsonInstance()
		{
		}
	}
}
