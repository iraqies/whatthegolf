using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.ProBuilder
{
	[Serializable]
	[Token(Token = "0x2000020")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x1B5B00", Offset = "0x1B5B00")]
	public sealed class SharedVertex : ICollection<int>, IEnumerable<int>, IEnumerable
	{
		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B6544", Offset = "0x1B6544")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B6544", Offset = "0x1B6544")]
		private int[] m_Vertices;

		// C# has no syntax for parameterized property 'Item'.
		// Its 'property:' attributes below are ignored by the compiler (CS0657).
		[property: Token(Token = "0x1700004D")]
		[Token(Token = "0x6000111")]
		[Address(RVA = "0x2A4D88C", Offset = "0x2A4D88C", VA = "0x2A4D88C")]
		public int get_Item(int i)
		{
			return default;
		}

		[Token(Token = "0x1700004E")]
		public int Count
		{
			[Token(Token = "0x600011A")]
			[Address(RVA = "0x2A4D8C8", Offset = "0x2A4D8C8", VA = "0x2A4D8C8", Slot = "4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700004F")]
		public bool IsReadOnly
		{
			[Token(Token = "0x600011B")]
			[Address(RVA = "0x2A59E34", Offset = "0x2A59E34", VA = "0x2A59E34", Slot = "5")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x2A59AE4", Offset = "0x2A59AE4", VA = "0x2A59AE4")]
		public SharedVertex(IEnumerable<int> indexes)
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x2A4E70C", Offset = "0x2A4E70C", VA = "0x2A4E70C")]
		public SharedVertex(SharedVertex sharedVertex)
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x2A58164", Offset = "0x2A58164", VA = "0x2A58164", Slot = "11")]
		public IEnumerator<int> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x2A59B9C", Offset = "0x2A59B9C", VA = "0x2A59B9C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x2A59C08", Offset = "0x2A59C08", VA = "0x2A59C08", Slot = "12")]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x2A57AAC", Offset = "0x2A57AAC", VA = "0x2A57AAC", Slot = "6")]
		public void Add(int item)
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x2A59CBC", Offset = "0x2A59CBC", VA = "0x2A59CBC", Slot = "7")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x2A59D18", Offset = "0x2A59D18", VA = "0x2A59D18", Slot = "8")]
		public bool Contains(int item)
		{
			return default;
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x2A59D80", Offset = "0x2A59D80", VA = "0x2A59D80", Slot = "9")]
		public void CopyTo(int[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x2A59D9C", Offset = "0x2A59D9C", VA = "0x2A59D9C", Slot = "10")]
		public bool Remove(int item)
		{
			return default;
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x2A4E880", Offset = "0x2A4E880", VA = "0x2A4E880")]
		public static void GetSharedVertexLookup(IList<SharedVertex> sharedVertices, Dictionary<int, int> lookup)
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x2A4EDB0", Offset = "0x2A4EDB0", VA = "0x2A4EDB0")]
		internal static SharedVertex[] ToSharedVertices(IEnumerable<KeyValuePair<int, int>> lookup)
		{
			return null;
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x2A59E50", Offset = "0x2A59E50", VA = "0x2A59E50")]
		private static SharedVertex[] ToSharedVertices(List<List<int>> list)
		{
			return null;
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x2A52BD0", Offset = "0x2A52BD0", VA = "0x2A52BD0")]
		public static SharedVertex[] GetSharedVerticesWithPositions(IList<Vector3> positions)
		{
			return null;
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x2A5760C", Offset = "0x2A5760C", VA = "0x2A5760C")]
		internal static void SetCoincident(ref Dictionary<int, int> lookup, IEnumerable<int> vertices)
		{
		}
	}
}
