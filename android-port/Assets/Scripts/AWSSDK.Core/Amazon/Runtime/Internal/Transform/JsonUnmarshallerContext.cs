using System.Collections.Generic;
using System.IO;
using System.Text;
using Il2CppDummyDll;
using ThirdParty.Json.LitJson;

namespace Amazon.Runtime.Internal.Transform
{
	[Token(Token = "0x200021B")]
	public class JsonUnmarshallerContext : UnmarshallerContext
	{
		[Token(Token = "0x200021C")]
		private enum PathSegmentType
		{
			[Token(Token = "0x40007C4")]
			Value = 0,
			[Token(Token = "0x40007C5")]
			Delimiter = 1
		}

		[Token(Token = "0x200021D")]
		private struct PathSegment
		{
			[Token(Token = "0x40007C6")]
			[FieldOffset(Offset = "0x0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27BB8", Offset = "0x27BB8")]
			private PathSegmentType SegmentType__BackingField;

			[Token(Token = "0x40007C7")]
			[FieldOffset(Offset = "0x8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27BC8", Offset = "0x27BC8")]
			private string Value__BackingField;

			[Token(Token = "0x17000412")]
			internal PathSegmentType SegmentType
			{
				[Token(Token = "0x6001035")]
				[Address(RVA = "0x128F40C", Offset = "0x128F40C", VA = "0x128F40C")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BD50", Offset = "0x2BD50")]
				get
				{
					return default;
				}
				[Token(Token = "0x6001036")]
				[Address(RVA = "0x128F414", Offset = "0x128F414", VA = "0x128F414")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BD60", Offset = "0x2BD60")]
				set
				{
				}
			}

			[Token(Token = "0x17000413")]
			internal string Value
			{
				[Token(Token = "0x6001037")]
				[Address(RVA = "0x128F41C", Offset = "0x128F41C", VA = "0x128F41C")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BD70", Offset = "0x2BD70")]
				get
				{
					return null;
				}
				[Token(Token = "0x6001038")]
				[Address(RVA = "0x128F424", Offset = "0x128F424", VA = "0x128F424")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BD80", Offset = "0x2BD80")]
				set
				{
				}
			}
		}

		[Token(Token = "0x200021E")]
		private class JsonPathStack
		{
			[Token(Token = "0x40007C8")]
			[FieldOffset(Offset = "0x10")]
			private Stack<PathSegment> stack;

			[Token(Token = "0x40007C9")]
			[FieldOffset(Offset = "0x18")]
			private int currentDepth;

			[Token(Token = "0x40007CA")]
			[FieldOffset(Offset = "0x20")]
			private StringBuilder stackStringBuilder;

			[Token(Token = "0x40007CB")]
			[FieldOffset(Offset = "0x28")]
			private string stackString;

			[Token(Token = "0x17000414")]
			public int CurrentDepth
			{
				[Token(Token = "0x6001039")]
				[Address(RVA = "0x128F100", Offset = "0x128F100", VA = "0x128F100")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000415")]
			public string CurrentPath
			{
				[Token(Token = "0x600103A")]
				[Address(RVA = "0x128F108", Offset = "0x128F108", VA = "0x128F108")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000416")]
			public int Count
			{
				[Token(Token = "0x600103E")]
				[Address(RVA = "0x128F308", Offset = "0x128F308", VA = "0x128F308")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x600103B")]
			[Address(RVA = "0x128F154", Offset = "0x128F154", VA = "0x128F154")]
			internal void Push(PathSegment segment)
			{
			}

			[Token(Token = "0x600103C")]
			[Address(RVA = "0x128F200", Offset = "0x128F200", VA = "0x128F200")]
			internal PathSegment Pop()
			{
				return default;
			}

			[Token(Token = "0x600103D")]
			[Address(RVA = "0x128F2B4", Offset = "0x128F2B4", VA = "0x128F2B4")]
			internal PathSegment Peek()
			{
				return default;
			}

			[Token(Token = "0x600103F")]
			[Address(RVA = "0x128F354", Offset = "0x128F354", VA = "0x128F354")]
			public JsonPathStack()
			{
			}
		}

		[Token(Token = "0x40007BB")]
		private const string DELIMITER = "/";

		[Token(Token = "0x40007BC")]
		[FieldOffset(Offset = "0x38")]
		private StreamReader streamReader;

		[Token(Token = "0x40007BD")]
		[FieldOffset(Offset = "0x40")]
		private JsonReader jsonReader;

		[Token(Token = "0x40007BE")]
		[FieldOffset(Offset = "0x48")]
		private JsonPathStack stack;

		[Token(Token = "0x40007BF")]
		[FieldOffset(Offset = "0x50")]
		private string currentField;

		[Token(Token = "0x40007C0")]
		[FieldOffset(Offset = "0x58")]
		private JsonToken? currentToken;

		[Token(Token = "0x40007C1")]
		[FieldOffset(Offset = "0x60")]
		private bool disposed;

		[Token(Token = "0x40007C2")]
		[FieldOffset(Offset = "0x61")]
		private bool wasPeeked;

		[Token(Token = "0x1700040B")]
		public override bool IsStartOfDocument
		{
			[Token(Token = "0x6001027")]
			[Address(RVA = "0x1236148", Offset = "0x1236148", VA = "0x1236148", Slot = "11")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700040C")]
		public override bool IsEndElement
		{
			[Token(Token = "0x6001028")]
			[Address(RVA = "0x1236218", Offset = "0x1236218", VA = "0x1236218", Slot = "10")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700040D")]
		public override bool IsStartElement
		{
			[Token(Token = "0x6001029")]
			[Address(RVA = "0x1236278", Offset = "0x1236278", VA = "0x1236278", Slot = "9")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700040E")]
		public override int CurrentDepth
		{
			[Token(Token = "0x600102A")]
			[Address(RVA = "0x12362D8", Offset = "0x12362D8", VA = "0x12362D8", Slot = "6")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700040F")]
		public override string CurrentPath
		{
			[Token(Token = "0x600102B")]
			[Address(RVA = "0x12362F4", Offset = "0x12362F4", VA = "0x12362F4", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000410")]
		public JsonToken CurrentTokenType
		{
			[Token(Token = "0x600102F")]
			[Address(RVA = "0x12361C4", Offset = "0x12361C4", VA = "0x12361C4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000411")]
		public Stream Stream
		{
			[Token(Token = "0x6001030")]
			[Address(RVA = "0x1236970", Offset = "0x1236970", VA = "0x1236970")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001026")]
		[Address(RVA = "0x1235C98", Offset = "0x1235C98", VA = "0x1235C98")]
		public JsonUnmarshallerContext(Stream responseStream, bool maintainResponseBody, IWebResponseData responseData, bool isException = false)
		{
		}

		[Token(Token = "0x600102C")]
		[Address(RVA = "0x1236310", Offset = "0x1236310", VA = "0x1236310", Slot = "7")]
		public override bool Read()
		{
			return default;
		}

		[Token(Token = "0x600102D")]
		[Address(RVA = "0x12365A0", Offset = "0x12365A0", VA = "0x12365A0")]
		public bool Peek(JsonToken token)
		{
			return default;
		}

		[Token(Token = "0x600102E")]
		[Address(RVA = "0x123663C", Offset = "0x123663C", VA = "0x123663C", Slot = "8")]
		public override string ReadText()
		{
			return null;
		}

		[Token(Token = "0x6001031")]
		[Address(RVA = "0x1225AC0", Offset = "0x1225AC0", VA = "0x1225AC0")]
		public int Peek()
		{
			return default;
		}

		[Token(Token = "0x6001032")]
		[Address(RVA = "0x1236994", Offset = "0x1236994", VA = "0x1236994")]
		private int StreamPeek()
		{
			return default;
		}

		[Token(Token = "0x6001033")]
		[Address(RVA = "0x12363D8", Offset = "0x12363D8", VA = "0x12363D8")]
		private void UpdateContext()
		{
		}

		[Token(Token = "0x6001034")]
		[Address(RVA = "0x12369FC", Offset = "0x12369FC", VA = "0x12369FC", Slot = "12")]
		protected override void Dispose(bool disposing)
		{
		}
	}
}
