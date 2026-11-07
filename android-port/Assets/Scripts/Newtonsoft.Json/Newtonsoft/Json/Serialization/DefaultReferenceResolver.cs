using Il2CppDummyDll;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x2000096")]
	[Attribute(Name = "NullableContextAttribute", RVA = "0x183844", Offset = "0x183844")]
	[Attribute(Name = "NullableAttribute", RVA = "0x183844", Offset = "0x183844")]
	internal class DefaultReferenceResolver : IReferenceResolver
	{
		[Token(Token = "0x4000236")]
		[FieldOffset(Offset = "0x10")]
		private int _referenceCount;

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x22C1CCC", Offset = "0x22C1CCC", VA = "0x22C1CCC")]
		private BidirectionalDictionary<string, object> GetMappings(object context)
		{
			return null;
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x22C1DFC", Offset = "0x22C1DFC", VA = "0x22C1DFC", Slot = "4")]
		public object ResolveReference(object context, string reference)
		{
			return null;
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x22C1E7C", Offset = "0x22C1E7C", VA = "0x22C1E7C", Slot = "5")]
		public string GetReference(object context, object value)
		{
			return null;
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x22C1F84", Offset = "0x22C1F84", VA = "0x22C1F84", Slot = "7")]
		public void AddReference(object context, string reference, object value)
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x22C1FF4", Offset = "0x22C1FF4", VA = "0x22C1FF4", Slot = "6")]
		public bool IsReferenced(object context, object value)
		{
			return default;
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x22C2070", Offset = "0x22C2070", VA = "0x22C2070")]
		public DefaultReferenceResolver()
		{
		}
	}
}
