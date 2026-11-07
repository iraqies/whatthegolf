using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;

namespace MonitorComponents
{
	[Token(Token = "0x2000275")]
	public class TypeInspectors
	{
		[Token(Token = "0x2000276")]
		private class DefaultTypeInspector : ITypeInspector
		{
			[Token(Token = "0x2000277")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x34200", Offset = "0x34200")]
			private sealed class _003C_003Ec__DisplayClass3_0
			{
				[Token(Token = "0x400106A")]
				[FieldOffset(Offset = "0x10")]
				public TypeInspectors typeInspectors;

				[Token(Token = "0x600104A")]
				[Address(RVA = "0x1358424", Offset = "0x1358424", VA = "0x1358424")]
				public _003C_003Ec__DisplayClass3_0()
				{
				}

				[Token(Token = "0x600104B")]
				[Address(RVA = "0x135AEE4", Offset = "0x135AEE4", VA = "0x135AEE4")]
				internal bool _003C_002Ector_003Eb__0(FieldInfo f)
				{
					return default;
				}
			}

			[Token(Token = "0x4001067")]
			[FieldOffset(Offset = "0x10")]
			private string[] fieldNameStrings;

			[Token(Token = "0x4001068")]
			[FieldOffset(Offset = "0x18")]
			private Field[] fields;

			[Token(Token = "0x4001069")]
			[FieldOffset(Offset = "0x20")]
			private Dictionary<string, FieldInfo> nameToFieldInfo;

			[Token(Token = "0x6001048")]
			[Address(RVA = "0x1357F2C", Offset = "0x1357F2C", VA = "0x1357F2C")]
			public DefaultTypeInspector(TypeInspectors typeInspectors, Type type)
			{
			}

			[Token(Token = "0x6001049")]
			[Address(RVA = "0x1358434", Offset = "0x1358434", VA = "0x1358434", Slot = "4")]
			public object GetValue(object instance, string fieldName)
			{
				return null;
			}
		}

		[Token(Token = "0x2000278")]
		public class Field
		{
			[Token(Token = "0x400106B")]
			[FieldOffset(Offset = "0x10")]
			public string name;

			[Token(Token = "0x400106C")]
			[FieldOffset(Offset = "0x18")]
			public Type type;

			[Token(Token = "0x600104C")]
			[Address(RVA = "0x135842C", Offset = "0x135842C", VA = "0x135842C")]
			public Field()
			{
			}
		}

		[Token(Token = "0x2000279")]
		private class QuaternionTypeInspector : ITypeInspector
		{
			[Token(Token = "0x400106D")]
			[FieldOffset(Offset = "0x10")]
			private string[] fieldNameStrings;

			[Token(Token = "0x400106E")]
			[FieldOffset(Offset = "0x18")]
			private Field[] fields;

			[Token(Token = "0x600104D")]
			[Address(RVA = "0x13584D8", Offset = "0x13584D8", VA = "0x13584D8", Slot = "4")]
			public object GetValue(object instance, string fieldName)
			{
				return null;
			}

			[Token(Token = "0x600104E")]
			[Address(RVA = "0x1358644", Offset = "0x1358644", VA = "0x1358644")]
			public QuaternionTypeInspector()
			{
			}
		}

		[Token(Token = "0x200027A")]
		public interface ITypeInspector
		{
			[Token(Token = "0x600104F")]
			object GetValue(object instance, string fieldName);
		}

		[Token(Token = "0x4001062")]
		[FieldOffset(Offset = "0x10")]
		private HashSet<Type> sampleTypes;

		[Token(Token = "0x4001063")]
		[FieldOffset(Offset = "0x0")]
		private static BindingFlags flags;

		[Token(Token = "0x4001064")]
		[FieldOffset(Offset = "0x8")]
		private static TypeInspectors instance;

		[Token(Token = "0x4001065")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<Type, ITypeInspector> inspectors;

		[Token(Token = "0x4001066")]
		[FieldOffset(Offset = "0x10")]
		private static Dictionary<Type, string> valueTypes;

		[Token(Token = "0x170001F3")]
		public static TypeInspectors Instance
		{
			[Token(Token = "0x6001046")]
			[Address(RVA = "0x1324D74", Offset = "0x1324D74", VA = "0x1324D74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001041")]
		[Address(RVA = "0x1324750", Offset = "0x1324750", VA = "0x1324750")]
		public TypeInspectors()
		{
		}

		[Token(Token = "0x6001042")]
		[Address(RVA = "0x13249B0", Offset = "0x13249B0", VA = "0x13249B0")]
		public ITypeInspector GetTypeInspector(Type type)
		{
			return null;
		}

		[Token(Token = "0x6001043")]
		[Address(RVA = "0x1324A90", Offset = "0x1324A90", VA = "0x1324A90")]
		public bool IsSampleType(Type type)
		{
			return default;
		}

		[Token(Token = "0x6001044")]
		[Address(RVA = "0x1324AF4", Offset = "0x1324AF4", VA = "0x1324AF4")]
		public bool IsAcceptableType(Type type)
		{
			return default;
		}

		[Token(Token = "0x6001045")]
		[Address(RVA = "0x1324CAC", Offset = "0x1324CAC", VA = "0x1324CAC")]
		private static string GetReadableName(Type type)
		{
			return null;
		}
	}
}
