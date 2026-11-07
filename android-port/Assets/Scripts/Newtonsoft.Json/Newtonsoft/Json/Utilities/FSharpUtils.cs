using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json.Utilities
{
	[Token(Token = "0x200005A")]
	[AttributeAttribute(Name = "NullableAttribute", RVA = "0x183124", Offset = "0x183124")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x183124", Offset = "0x183124")]
	internal class FSharpUtils
	{
		[Token(Token = "0x200005B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x183164", Offset = "0x183164")]
		private sealed class _003C_003Ec__DisplayClass52_0
		{
			[Token(Token = "0x40001CF")]
			[FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "NullableAttribute", RVA = "0x185D28", Offset = "0x185D28")]
			public MethodCall<object, object> call;

			[Token(Token = "0x40001D0")]
			[FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "NullableAttribute", RVA = "0x185DA0", Offset = "0x185DA0")]
			public MethodCall<object, object> invoke;

			[Token(Token = "0x600026B")]
			[Address(RVA = "0x23382B8", Offset = "0x23382B8", VA = "0x23382B8")]
			public _003C_003Ec__DisplayClass52_0()
			{
			}

			[Token(Token = "0x600026C")]
			[Address(RVA = "0x23382C0", Offset = "0x23382C0", VA = "0x23382C0")]
			internal object _003CCreateFSharpFuncCall_003Eb__0([AttributeAttribute(Name = "NullableAttribute", RVA = "0x18BD10", Offset = "0x18BD10")] object target, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18BD24", Offset = "0x18BD24")] object[] args)
			{
				return null;
			}
		}

		[Token(Token = "0x200005C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x183174", Offset = "0x183174")]
		private sealed class _003C_003Ec__DisplayClass55_0<TKey, TValue>
		{
			[Token(Token = "0x40001D1")]
			[FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "NullableAttribute", RVA = "0x185E18", Offset = "0x185E18")]
			public ObjectConstructor<object> ctorDelegate;

			[Token(Token = "0x600026D")]
			public _003C_003Ec__DisplayClass55_0()
			{
			}

			[Token(Token = "0x600026E")]
			internal object _003CBuildMapCreator_003Eb__0([AttributeAttribute(Name = "NullableAttribute", RVA = "0x18BD94", Offset = "0x18BD94")] object[] args)
			{
				return null;
			}
		}

		[Serializable]
		[Token(Token = "0x200005D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x183184", Offset = "0x183184")]
		private sealed class _003C_003Ec__55<TKey, TValue>
		{
			[Token(Token = "0x40001D2")]
			[FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "NullableAttribute", RVA = "0x185E88", Offset = "0x185E88")]
			public static readonly _003C_003Ec__55<TKey, TValue> _003C_003E9;

			[Token(Token = "0x40001D3")]
			[FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "NullableAttribute", RVA = "0x185E9C", Offset = "0x185E9C")]
			public static Func<KeyValuePair<TKey, TValue>, Tuple<TKey, TValue>> _003C_003E9__55_1;

			[Token(Token = "0x6000270")]
			public _003C_003Ec__55()
			{
			}

			[Token(Token = "0x6000271")]
			[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x188F4C", Offset = "0x188F4C")]
			internal Tuple<TKey, TValue> _003CBuildMapCreator_003Eb__55_1(KeyValuePair<TKey, TValue> kv)
			{
				return null;
			}
		}

		[Token(Token = "0x40001C1")]
		[FieldOffset(Offset = "0x0")]
		private static readonly object Lock;

		[Token(Token = "0x40001C2")]
		[FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x1859A4", Offset = "0x1859A4")]
		private static FSharpUtils _instance;

		[Token(Token = "0x40001C3")]
		[FieldOffset(Offset = "0x10")]
		private MethodInfo _ofSeq;

		[Token(Token = "0x40001C4")]
		[FieldOffset(Offset = "0x18")]
		private Type _mapType;

		[Token(Token = "0x40001C5")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1859B8", Offset = "0x1859B8")]
		private Assembly FSharpCoreAssembly__BackingField;

		[Token(Token = "0x40001C6")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x1859C8", Offset = "0x1859C8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1859C8", Offset = "0x1859C8")]
		private MethodCall<object, object> IsUnion__BackingField;

		[Token(Token = "0x40001C7")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x185A50", Offset = "0x185A50")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x185A50", Offset = "0x185A50")]
		private MethodCall<object, object> GetUnionCases__BackingField;

		[Token(Token = "0x40001C8")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x185AD8", Offset = "0x185AD8")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x185AD8", Offset = "0x185AD8")]
		private MethodCall<object, object> PreComputeUnionTagReader__BackingField;

		[Token(Token = "0x40001C9")]
		[FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x185B60", Offset = "0x185B60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x185B60", Offset = "0x185B60")]
		private MethodCall<object, object> PreComputeUnionReader__BackingField;

		[Token(Token = "0x40001CA")]
		[FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x185BE8", Offset = "0x185BE8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x185BE8", Offset = "0x185BE8")]
		private MethodCall<object, object> PreComputeUnionConstructor__BackingField;

		[Token(Token = "0x40001CB")]
		[FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x185C70", Offset = "0x185C70")]
		private Func<object, object> GetUnionCaseInfoDeclaringType__BackingField;

		[Token(Token = "0x40001CC")]
		[FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x185C80", Offset = "0x185C80")]
		private Func<object, object> GetUnionCaseInfoName__BackingField;

		[Token(Token = "0x40001CD")]
		[FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x185C90", Offset = "0x185C90")]
		private Func<object, object> GetUnionCaseInfoTag__BackingField;

		[Token(Token = "0x40001CE")]
		[FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x185CA0", Offset = "0x185CA0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x185CA0", Offset = "0x185CA0")]
		private MethodCall<object, object> GetUnionCaseInfoFields__BackingField;

		[Token(Token = "0x1700005D")]
		public static FSharpUtils Instance
		{
			[Token(Token = "0x6000250")]
			[Address(RVA = "0x22C8484", Offset = "0x22C8484", VA = "0x22C8484")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005E")]
		private Assembly FSharpCoreAssembly
		{
			[Token(Token = "0x6000251")]
			[Address(RVA = "0x22C84E8", Offset = "0x22C84E8", VA = "0x22C84E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x188E08", Offset = "0x188E08")]
			set
			{
			}
		}

		[Token(Token = "0x1700005F")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18EB20", Offset = "0x18EB20")]
		public MethodCall<object, object> IsUnion
		{
			[Token(Token = "0x6000252")]
			[Address(RVA = "0x22C84F0", Offset = "0x22C84F0", VA = "0x22C84F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x188E18", Offset = "0x188E18")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000253")]
			[Address(RVA = "0x22C84F8", Offset = "0x22C84F8", VA = "0x22C84F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x188E28", Offset = "0x188E28")]
			[param: AttributeAttribute(Name = "NullableAttribute", RVA = "0x18BA40", Offset = "0x18BA40")]
			private set
			{
			}
		}

		[Token(Token = "0x17000060")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18EB98", Offset = "0x18EB98")]
		public MethodCall<object, object> GetUnionCases
		{
			[Token(Token = "0x6000254")]
			[Address(RVA = "0x22C8500", Offset = "0x22C8500", VA = "0x22C8500")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x188E38", Offset = "0x188E38")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000255")]
			[Address(RVA = "0x22C8508", Offset = "0x22C8508", VA = "0x22C8508")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x188E48", Offset = "0x188E48")]
			[param: AttributeAttribute(Name = "NullableAttribute", RVA = "0x18BAB8", Offset = "0x18BAB8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000061")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18EC10", Offset = "0x18EC10")]
		public MethodCall<object, object> PreComputeUnionTagReader
		{
			[Token(Token = "0x6000256")]
			[Address(RVA = "0x22C8510", Offset = "0x22C8510", VA = "0x22C8510")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x188E58", Offset = "0x188E58")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000257")]
			[Address(RVA = "0x22C8518", Offset = "0x22C8518", VA = "0x22C8518")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x188E68", Offset = "0x188E68")]
			[param: AttributeAttribute(Name = "NullableAttribute", RVA = "0x18BB30", Offset = "0x18BB30")]
			private set
			{
			}
		}

		[Token(Token = "0x17000062")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18EC88", Offset = "0x18EC88")]
		public MethodCall<object, object> PreComputeUnionReader
		{
			[Token(Token = "0x6000258")]
			[Address(RVA = "0x22C8520", Offset = "0x22C8520", VA = "0x22C8520")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x188E78", Offset = "0x188E78")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000259")]
			[Address(RVA = "0x22C8528", Offset = "0x22C8528", VA = "0x22C8528")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x188E88", Offset = "0x188E88")]
			[param: AttributeAttribute(Name = "NullableAttribute", RVA = "0x18BBA8", Offset = "0x18BBA8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000063")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18ED00", Offset = "0x18ED00")]
		public MethodCall<object, object> PreComputeUnionConstructor
		{
			[Token(Token = "0x600025A")]
			[Address(RVA = "0x22C8530", Offset = "0x22C8530", VA = "0x22C8530")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x188E98", Offset = "0x188E98")]
			get
			{
				return null;
			}
			[Token(Token = "0x600025B")]
			[Address(RVA = "0x22C8538", Offset = "0x22C8538", VA = "0x22C8538")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x188EA8", Offset = "0x188EA8")]
			[param: AttributeAttribute(Name = "NullableAttribute", RVA = "0x18BC20", Offset = "0x18BC20")]
			private set
			{
			}
		}

		[Token(Token = "0x17000064")]
		public Func<object, object> GetUnionCaseInfoDeclaringType
		{
			[Token(Token = "0x600025C")]
			[Address(RVA = "0x22C8540", Offset = "0x22C8540", VA = "0x22C8540")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x188EB8", Offset = "0x188EB8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600025D")]
			[Address(RVA = "0x22C8548", Offset = "0x22C8548", VA = "0x22C8548")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x188EC8", Offset = "0x188EC8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000065")]
		public Func<object, object> GetUnionCaseInfoName
		{
			[Token(Token = "0x600025E")]
			[Address(RVA = "0x22C8550", Offset = "0x22C8550", VA = "0x22C8550")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x188ED8", Offset = "0x188ED8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600025F")]
			[Address(RVA = "0x22C8558", Offset = "0x22C8558", VA = "0x22C8558")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x188EE8", Offset = "0x188EE8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000066")]
		public Func<object, object> GetUnionCaseInfoTag
		{
			[Token(Token = "0x6000260")]
			[Address(RVA = "0x22C8560", Offset = "0x22C8560", VA = "0x22C8560")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x188EF8", Offset = "0x188EF8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000261")]
			[Address(RVA = "0x22C8568", Offset = "0x22C8568", VA = "0x22C8568")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x188F08", Offset = "0x188F08")]
			private set
			{
			}
		}

		[Token(Token = "0x17000067")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18ED78", Offset = "0x18ED78")]
		public MethodCall<object, object> GetUnionCaseInfoFields
		{
			[Token(Token = "0x6000262")]
			[Address(RVA = "0x22C8570", Offset = "0x22C8570", VA = "0x22C8570")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x188F18", Offset = "0x188F18")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000263")]
			[Address(RVA = "0x22C8578", Offset = "0x22C8578", VA = "0x22C8578")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x188F28", Offset = "0x188F28")]
			[param: AttributeAttribute(Name = "NullableAttribute", RVA = "0x18BC98", Offset = "0x18BC98")]
			private set
			{
			}
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x22C7C70", Offset = "0x22C7C70", VA = "0x22C7C70")]
		private FSharpUtils(Assembly fsharpCoreAssembly)
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x22C45D0", Offset = "0x22C45D0", VA = "0x22C45D0")]
		public static void EnsureInitialized(Assembly fsharpCoreAssembly)
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x22C81B8", Offset = "0x22C81B8", VA = "0x22C81B8")]
		private static MethodInfo GetMethodWithNonPublicFallback(Type type, string methodName, BindingFlags bindingFlags)
		{
			return null;
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x22C8230", Offset = "0x22C8230", VA = "0x22C8230")]
		private static MethodCall<object, object> CreateFSharpFuncCall(Type type, string methodName)
		{
			return null;
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x22C8580", Offset = "0x22C8580", VA = "0x22C8580")]
		public ObjectConstructor<object> CreateSeq(Type t)
		{
			return null;
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x22C868C", Offset = "0x22C868C", VA = "0x22C868C")]
		public ObjectConstructor<object> CreateMap(Type keyType, Type valueType)
		{
			return null;
		}

		[Token(Token = "0x6000269")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x188F38", Offset = "0x188F38")]
		public ObjectConstructor<object> BuildMapCreator<TKey, TValue>()
		{
			return null;
		}
	}
}
