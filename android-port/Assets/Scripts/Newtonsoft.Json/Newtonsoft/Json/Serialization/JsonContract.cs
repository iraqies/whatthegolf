using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x20000A7")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x183A3C", Offset = "0x183A3C")]
	[AttributeAttribute(Name = "NullableAttribute", RVA = "0x183A3C", Offset = "0x183A3C")]
	public abstract class JsonContract
	{
		[Token(Token = "0x20000A8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x183A7C", Offset = "0x183A7C")]
		private sealed class _003C_003Ec__DisplayClass57_0
		{
			[Token(Token = "0x4000273")]
			[FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "NullableAttribute", RVA = "0x187264", Offset = "0x187264")]
			public MethodInfo callbackMethodInfo;

			[Token(Token = "0x6000421")]
			[Address(RVA = "0x2339194", Offset = "0x2339194", VA = "0x2339194")]
			public _003C_003Ec__DisplayClass57_0()
			{
			}

			[Token(Token = "0x6000422")]
			[Address(RVA = "0x233919C", Offset = "0x233919C", VA = "0x233919C")]
			internal void _003CCreateSerializationCallback_003Eb__0(object o, StreamingContext context)
			{
			}
		}

		[Token(Token = "0x20000A9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x183A8C", Offset = "0x183A8C")]
		private sealed class _003C_003Ec__DisplayClass58_0
		{
			[Token(Token = "0x4000274")]
			[FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "NullableAttribute", RVA = "0x187278", Offset = "0x187278")]
			public MethodInfo callbackMethodInfo;

			[Token(Token = "0x6000423")]
			[Address(RVA = "0x23392A4", Offset = "0x23392A4", VA = "0x23392A4")]
			public _003C_003Ec__DisplayClass58_0()
			{
			}

			[Token(Token = "0x6000424")]
			[Address(RVA = "0x23392AC", Offset = "0x23392AC", VA = "0x23392AC")]
			internal void _003CCreateSerializationErrorCallback_003Eb__0(object o, StreamingContext context, ErrorContext econtext)
			{
			}
		}

		[Token(Token = "0x400025E")]
		[FieldOffset(Offset = "0x10")]
		internal bool IsNullable;

		[Token(Token = "0x400025F")]
		[FieldOffset(Offset = "0x11")]
		internal bool IsConvertable;

		[Token(Token = "0x4000260")]
		[FieldOffset(Offset = "0x12")]
		internal bool IsEnum;

		[Token(Token = "0x4000261")]
		[FieldOffset(Offset = "0x18")]
		internal Type NonNullableUnderlyingType;

		[Token(Token = "0x4000262")]
		[FieldOffset(Offset = "0x20")]
		internal ReadType InternalReadType;

		[Token(Token = "0x4000263")]
		[FieldOffset(Offset = "0x24")]
		internal JsonContractType ContractType;

		[Token(Token = "0x4000264")]
		[FieldOffset(Offset = "0x28")]
		internal bool IsReadOnlyOrFixedSize;

		[Token(Token = "0x4000265")]
		[FieldOffset(Offset = "0x29")]
		internal bool IsSealed;

		[Token(Token = "0x4000266")]
		[FieldOffset(Offset = "0x2A")]
		internal bool IsInstantiable;

		[Token(Token = "0x4000267")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x186F0C", Offset = "0x186F0C")]
		private List<SerializationCallback> _onDeserializedCallbacks;

		[Token(Token = "0x4000268")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x186F7C", Offset = "0x186F7C")]
		private List<SerializationCallback> _onDeserializingCallbacks;

		[Token(Token = "0x4000269")]
		[FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x186FEC", Offset = "0x186FEC")]
		private List<SerializationCallback> _onSerializedCallbacks;

		[Token(Token = "0x400026A")]
		[FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18705C", Offset = "0x18705C")]
		private List<SerializationCallback> _onSerializingCallbacks;

		[Token(Token = "0x400026B")]
		[FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x1870CC", Offset = "0x1870CC")]
		private List<SerializationErrorCallback> _onErrorCallbacks;

		[Token(Token = "0x400026C")]
		[FieldOffset(Offset = "0x58")]
		private Type _createdType;

		[Token(Token = "0x400026D")]
		[FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x18713C", Offset = "0x18713C")]
		private readonly Type UnderlyingType__BackingField;

		[Token(Token = "0x400026E")]
		[FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x18714C", Offset = "0x18714C")]
		private bool? IsReference__BackingField;

		[Token(Token = "0x400026F")]
		[FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18715C", Offset = "0x18715C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x18715C", Offset = "0x18715C")]
		private JsonConverter Converter__BackingField;

		[Token(Token = "0x4000270")]
		[FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x187198", Offset = "0x187198")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x187198", Offset = "0x187198")]
		private JsonConverter InternalConverter__BackingField;

		[Token(Token = "0x4000271")]
		[FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x1871D4", Offset = "0x1871D4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1871D4", Offset = "0x1871D4")]
		private Func<object> DefaultCreator__BackingField;

		[Token(Token = "0x4000272")]
		[FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x187254", Offset = "0x187254")]
		private bool DefaultCreatorNonPublic__BackingField;

		[Token(Token = "0x17000095")]
		public Type UnderlyingType
		{
			[Token(Token = "0x6000407")]
			[Address(RVA = "0x22E67D8", Offset = "0x22E67D8", VA = "0x22E67D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189908", Offset = "0x189908")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000096")]
		public Type CreatedType
		{
			[Token(Token = "0x6000408")]
			[Address(RVA = "0x22E67E0", Offset = "0x22E67E0", VA = "0x22E67E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000409")]
			[Address(RVA = "0x22E5C90", Offset = "0x22E5C90", VA = "0x22E5C90")]
			set
			{
			}
		}

		[Token(Token = "0x17000097")]
		public bool? IsReference
		{
			[Token(Token = "0x600040A")]
			[Address(RVA = "0x22E67E8", Offset = "0x22E67E8", VA = "0x22E67E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189918", Offset = "0x189918")]
			get
			{
				return null;
			}
			[Token(Token = "0x600040B")]
			[Address(RVA = "0x22E67F0", Offset = "0x22E67F0", VA = "0x22E67F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189928", Offset = "0x189928")]
			set
			{
			}
		}

		[Token(Token = "0x17000098")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18F07C", Offset = "0x18F07C")]
		public JsonConverter Converter
		{
			[Token(Token = "0x600040C")]
			[Address(RVA = "0x22E67F8", Offset = "0x22E67F8", VA = "0x22E67F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189938", Offset = "0x189938")]
			[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x189938", Offset = "0x189938")]
			get
			{
				return null;
			}
			[Token(Token = "0x600040D")]
			[Address(RVA = "0x22E6800", Offset = "0x22E6800", VA = "0x22E6800")]
			[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x189974", Offset = "0x189974")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189974", Offset = "0x189974")]
			set
			{
			}
		}

		[Token(Token = "0x17000099")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18F090", Offset = "0x18F090")]
		public JsonConverter InternalConverter
		{
			[Token(Token = "0x600040E")]
			[Address(RVA = "0x22E6808", Offset = "0x22E6808", VA = "0x22E6808")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1899B0", Offset = "0x1899B0")]
			[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x1899B0", Offset = "0x1899B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600040F")]
			[Address(RVA = "0x22E6810", Offset = "0x22E6810", VA = "0x22E6810")]
			[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x1899EC", Offset = "0x1899EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1899EC", Offset = "0x1899EC")]
			internal set
			{
			}
		}

		[Token(Token = "0x1700009A")]
		public IList<SerializationCallback> OnDeserializedCallbacks
		{
			[Token(Token = "0x6000410")]
			[Address(RVA = "0x22E6818", Offset = "0x22E6818", VA = "0x22E6818")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009B")]
		public IList<SerializationCallback> OnDeserializingCallbacks
		{
			[Token(Token = "0x6000411")]
			[Address(RVA = "0x22E6894", Offset = "0x22E6894", VA = "0x22E6894")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009C")]
		public IList<SerializationCallback> OnSerializedCallbacks
		{
			[Token(Token = "0x6000412")]
			[Address(RVA = "0x22E6910", Offset = "0x22E6910", VA = "0x22E6910")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009D")]
		public IList<SerializationCallback> OnSerializingCallbacks
		{
			[Token(Token = "0x6000413")]
			[Address(RVA = "0x22E698C", Offset = "0x22E698C", VA = "0x22E698C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009E")]
		public IList<SerializationErrorCallback> OnErrorCallbacks
		{
			[Token(Token = "0x6000414")]
			[Address(RVA = "0x22E6A08", Offset = "0x22E6A08", VA = "0x22E6A08")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009F")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18F0A4", Offset = "0x18F0A4")]
		public Func<object> DefaultCreator
		{
			[Token(Token = "0x6000415")]
			[Address(RVA = "0x22E6A84", Offset = "0x22E6A84", VA = "0x22E6A84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189A28", Offset = "0x189A28")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000416")]
			[Address(RVA = "0x22E6A8C", Offset = "0x22E6A8C", VA = "0x22E6A8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189A38", Offset = "0x189A38")]
			[param: AttributeAttribute(Name = "NullableAttribute", RVA = "0x18CCF4", Offset = "0x18CCF4")]
			set
			{
			}
		}

		[Token(Token = "0x170000A0")]
		public bool DefaultCreatorNonPublic
		{
			[Token(Token = "0x6000417")]
			[Address(RVA = "0x22E6A94", Offset = "0x22E6A94", VA = "0x22E6A94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189A48", Offset = "0x189A48")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000418")]
			[Address(RVA = "0x22E6A9C", Offset = "0x22E6A9C", VA = "0x22E6A9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189A58", Offset = "0x189A58")]
			set
			{
			}
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x22E6654", Offset = "0x22E6654", VA = "0x22E6654")]
		internal JsonContract(Type underlyingType)
		{
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x22E6AA4", Offset = "0x22E6AA4", VA = "0x22E6AA4")]
		internal void InvokeOnSerializing(object o, StreamingContext context)
		{
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x22E6C10", Offset = "0x22E6C10", VA = "0x22E6C10")]
		internal void InvokeOnSerialized(object o, StreamingContext context)
		{
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x22E6D7C", Offset = "0x22E6D7C", VA = "0x22E6D7C")]
		internal void InvokeOnDeserializing(object o, StreamingContext context)
		{
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x22E6EE8", Offset = "0x22E6EE8", VA = "0x22E6EE8")]
		internal void InvokeOnDeserialized(object o, StreamingContext context)
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x22E7054", Offset = "0x22E7054", VA = "0x22E7054")]
		internal void InvokeOnError(object o, StreamingContext context, ErrorContext errorContext)
		{
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x22E71C8", Offset = "0x22E71C8", VA = "0x22E71C8")]
		internal static SerializationCallback CreateSerializationCallback(MethodInfo callbackMethodInfo)
		{
			return null;
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x22E727C", Offset = "0x22E727C", VA = "0x22E727C")]
		internal static SerializationErrorCallback CreateSerializationErrorCallback(MethodInfo callbackMethodInfo)
		{
			return null;
		}
	}
}
