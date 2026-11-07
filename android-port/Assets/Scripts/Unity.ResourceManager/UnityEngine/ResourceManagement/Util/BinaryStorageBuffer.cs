using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;

namespace UnityEngine.ResourceManagement.Util
{
	[Token(Token = "0x2000018")]
	internal class BinaryStorageBuffer
	{
		[Token(Token = "0x2000019")]
		private class BuiltinTypesSerializer : ISerializationAdapter<int>, ISerializationAdapter, ISerializationAdapter<bool>, ISerializationAdapter<long>, ISerializationAdapter<string>, ISerializationAdapter<Hash128>
		{
			[Token(Token = "0x200001A")]
			private struct ObjectToStringRemap
			{
				[Token(Token = "0x400005C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public uint stringId;

				[Token(Token = "0x400005D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
				public char separator;
			}

			[Token(Token = "0x200001B")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B7A48", Offset = "0x1B7A48")]
			private sealed class _003C_003Ec__DisplayClass4_0
			{
				[Token(Token = "0x400005E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public char s;

				[Token(Token = "0x60000CD")]
				[Address(RVA = "0x2A79F58", Offset = "0x2A79F58", VA = "0x2A79F58")]
				public _003C_003Ec__DisplayClass4_0()
				{
				}

				[Token(Token = "0x60000CE")]
				[Address(RVA = "0x2A79F60", Offset = "0x2A79F60", VA = "0x2A79F60")]
				internal bool _003CFindBestSeparator_003Eb__0(char c)
				{
					return default;
				}
			}

			[Token(Token = "0x17000022")]
			public IEnumerable<ISerializationAdapter> Dependencies
			{
				[Token(Token = "0x60000C8")]
				[Address(RVA = "0x2A72F20", Offset = "0x2A72F20", VA = "0x2A72F20", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000C9")]
			[Address(RVA = "0x2A72F28", Offset = "0x2A72F28", VA = "0x2A72F28", Slot = "6")]
			public object Deserialize(Reader reader, Type t, uint offset)
			{
				return null;
			}

			[Token(Token = "0x60000CA")]
			[Address(RVA = "0x2A7334C", Offset = "0x2A7334C", VA = "0x2A7334C")]
			private char FindBestSeparator(string str, params char[] seps)
			{
				return default;
			}

			[Token(Token = "0x60000CB")]
			[Address(RVA = "0x2A73558", Offset = "0x2A73558", VA = "0x2A73558", Slot = "5")]
			public uint Serialize(Writer writer, object val)
			{
				return default;
			}

			[Token(Token = "0x60000CC")]
			[Address(RVA = "0x2A73A24", Offset = "0x2A73A24", VA = "0x2A73A24")]
			public BuiltinTypesSerializer()
			{
			}
		}

		[Token(Token = "0x200001C")]
		private class TypeSerializer : ISerializationAdapter<Type>, ISerializationAdapter
		{
			[Token(Token = "0x200001D")]
			private struct Data
			{
				[Token(Token = "0x400005F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public uint assemblyId;

				[Token(Token = "0x4000060")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
				public uint classId;
			}

			[Token(Token = "0x17000023")]
			public IEnumerable<ISerializationAdapter> Dependencies
			{
				[Token(Token = "0x60000CF")]
				[Address(RVA = "0x2A7485C", Offset = "0x2A7485C", VA = "0x2A7485C", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000D0")]
			[Address(RVA = "0x2A74864", Offset = "0x2A74864", VA = "0x2A74864", Slot = "6")]
			public object Deserialize(Reader reader, Type type, uint offset)
			{
				return null;
			}

			[Token(Token = "0x60000D1")]
			[Address(RVA = "0x2A74A4C", Offset = "0x2A74A4C", VA = "0x2A74A4C", Slot = "5")]
			public uint Serialize(Writer writer, object val)
			{
				return default;
			}

			[Token(Token = "0x60000D2")]
			[Address(RVA = "0x2A73C0C", Offset = "0x2A73C0C", VA = "0x2A73C0C")]
			public TypeSerializer()
			{
			}
		}

		[Token(Token = "0x200001E")]
		private struct DynamicString
		{
			[Token(Token = "0x4000061")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public uint stringId;

			[Token(Token = "0x4000062")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public uint nextId;
		}

		[Token(Token = "0x200001F")]
		private struct ObjectTypeData
		{
			[Token(Token = "0x4000063")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public uint typeId;

			[Token(Token = "0x4000064")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public uint objectId;
		}

		[Token(Token = "0x2000020")]
		public interface ISerializationAdapter
		{
			[Token(Token = "0x17000024")]
			IEnumerable<ISerializationAdapter> Dependencies
			{
				[Token(Token = "0x60000D3")]
				get;
			}

			[Token(Token = "0x60000D4")]
			uint Serialize(Writer writer, object val);

			[Token(Token = "0x60000D5")]
			object Deserialize(Reader reader, Type t, uint offset);
		}

		[Token(Token = "0x2000021")]
		public interface ISerializationAdapter<T> : ISerializationAdapter
		{
		}

		[Token(Token = "0x2000022")]
		public class Reader
		{
			[Token(Token = "0x4000065")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private byte[] m_Buffer;

			[Token(Token = "0x4000066")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Dictionary<Type, ISerializationAdapter> m_Adapters;

			[Token(Token = "0x4000067")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private LRUCache<uint, object> m_Cache;

			[Token(Token = "0x4000068")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private StringBuilder stringBuilder;

			[Token(Token = "0x60000D6")]
			[Address(RVA = "0x2A73A2C", Offset = "0x2A73A2C", VA = "0x2A73A2C")]
			private void Init(byte[] data, int maxCachedObjects, params ISerializationAdapter[] adapters)
			{
			}

			[Token(Token = "0x60000D7")]
			[Address(RVA = "0x2A73C14", Offset = "0x2A73C14", VA = "0x2A73C14")]
			public void AddSerializationAdapter(ISerializationAdapter a)
			{
			}

			[Token(Token = "0x60000D8")]
			[Address(RVA = "0x2A73C20", Offset = "0x2A73C20", VA = "0x2A73C20")]
			public Reader(byte[] data, int maxCachedObjects = 1024, params ISerializationAdapter[] adapters)
			{
			}

			[Token(Token = "0x60000D9")]
			[Address(RVA = "0x2A73C68", Offset = "0x2A73C68", VA = "0x2A73C68")]
			internal byte[] GetBuffer()
			{
				return null;
			}

			[Token(Token = "0x60000DA")]
			[Address(RVA = "0x2A73C70", Offset = "0x2A73C70", VA = "0x2A73C70")]
			public Reader(Stream inputStream, uint bufferSize, int maxCachedObjects, params ISerializationAdapter[] adapters)
			{
			}

			[Token(Token = "0x60000DB")]
			private bool TryGetCachedValue<T>(uint offset, out T val)
			{
				return default;
			}

			[Token(Token = "0x60000DC")]
			[Address(RVA = "0x2A73D54", Offset = "0x2A73D54", VA = "0x2A73D54")]
			public object[] ReadObjectArray(uint id, bool cacheValues = true)
			{
				return null;
			}

			[Token(Token = "0x60000DD")]
			[Address(RVA = "0x2A73FD8", Offset = "0x2A73FD8", VA = "0x2A73FD8")]
			public object[] ReadObjectArray(Type t, uint id, bool cacheValues = true)
			{
				return null;
			}

			[Token(Token = "0x60000DE")]
			public T[] ReadObjectArray<T>(uint id, bool cacheValues = true)
			{
				return null;
			}

			[Token(Token = "0x60000DF")]
			[Address(RVA = "0x2A73F1C", Offset = "0x2A73F1C", VA = "0x2A73F1C")]
			public object ReadObject(uint id, bool cacheValue = true)
			{
				return null;
			}

			[Token(Token = "0x60000E0")]
			public T ReadObject<T>(uint offset, bool cacheValue = true)
			{
				return (T)null;
			}

			[Token(Token = "0x60000E1")]
			[Address(RVA = "0x2A74128", Offset = "0x2A74128", VA = "0x2A74128")]
			public object ReadObject(Type t, uint id, bool cacheValue = true)
			{
				return null;
			}

			[Token(Token = "0x60000E2")]
			public T[] ReadValueArray<T>(uint id, bool cacheValue = true) where T : struct
			{
				return null;
			}

			[Token(Token = "0x60000E3")]
			public T ReadValue<T>(uint id) where T : struct
			{
				return (T)null;
			}

			[Token(Token = "0x60000E4")]
			[Address(RVA = "0x2A732C0", Offset = "0x2A732C0", VA = "0x2A732C0")]
			public string ReadString(uint id, char sep = '\0', bool cacheValue = true)
			{
				return null;
			}

			[Token(Token = "0x60000E5")]
			[Address(RVA = "0x2A74608", Offset = "0x2A74608", VA = "0x2A74608")]
			private string ReadStringInternal(uint offset, Encoding enc, bool cacheValue = true)
			{
				return null;
			}

			[Token(Token = "0x60000E6")]
			[Address(RVA = "0x2A74370", Offset = "0x2A74370", VA = "0x2A74370")]
			private string ReadAutoEncodedString(uint id, bool cacheValue)
			{
				return null;
			}

			[Token(Token = "0x60000E7")]
			[Address(RVA = "0x2A743CC", Offset = "0x2A743CC", VA = "0x2A743CC")]
			private string ReadDynamicString(uint id, char sep, bool cacheValue)
			{
				return null;
			}
		}

		[Token(Token = "0x2000023")]
		public class Writer
		{
			[Token(Token = "0x2000024")]
			private class Chunk
			{
				[Token(Token = "0x400006E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public uint position;

				[Token(Token = "0x400006F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public byte[] data;

				[Token(Token = "0x6000102")]
				[Address(RVA = "0x2A79F70", Offset = "0x2A79F70", VA = "0x2A79F70")]
				public Chunk()
				{
				}
			}

			[Token(Token = "0x2000025")]
			private struct StringParts
			{
				[Token(Token = "0x4000070")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public string str;

				[Token(Token = "0x4000071")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public uint dataSize;

				[Token(Token = "0x4000072")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				public bool isUnicode;
			}

			[Token(Token = "0x4000069")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private uint totalBytes;

			[Token(Token = "0x400006A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private uint defaulChunkSize;

			[Token(Token = "0x400006B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private List<Chunk> chunks;

			[Token(Token = "0x400006C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Dictionary<Hash128, uint> existingValues;

			[Token(Token = "0x400006D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Dictionary<Type, ISerializationAdapter> serializationAdapters;

			[Token(Token = "0x17000025")]
			public uint Length
			{
				[Token(Token = "0x60000E8")]
				[Address(RVA = "0x2A74B8C", Offset = "0x2A74B8C", VA = "0x2A74B8C")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x60000E9")]
			[Address(RVA = "0x2A74B94", Offset = "0x2A74B94", VA = "0x2A74B94")]
			public Writer(int chunkSize = 1048576, params ISerializationAdapter[] adapters)
			{
			}

			[Token(Token = "0x60000EA")]
			[Address(RVA = "0x2A74DE8", Offset = "0x2A74DE8", VA = "0x2A74DE8")]
			private Chunk FindChunkWithSpace(uint length)
			{
				return null;
			}

			[Token(Token = "0x60000EB")]
			[Address(RVA = "0x2A74F38", Offset = "0x2A74F38", VA = "0x2A74F38")]
			private unsafe uint WriteInternal(void* pData, uint dataSize, bool prefixSize)
			{
				return default;
			}

			[Token(Token = "0x60000EC")]
			[Address(RVA = "0x2A750F0", Offset = "0x2A750F0", VA = "0x2A750F0")]
			private uint ReserveInternal(uint dataSize, bool prefixSize)
			{
				return default;
			}

			[Token(Token = "0x60000ED")]
			[Address(RVA = "0x2A75150", Offset = "0x2A75150", VA = "0x2A75150")]
			private unsafe void WriteInternal(uint id, void* pData, uint dataSize, bool prefixSize)
			{
			}

			[Token(Token = "0x60000EE")]
			public uint Reserve<T>() where T : struct
			{
				return default;
			}

			[Token(Token = "0x60000EF")]
			public uint Write<T>([In] ref T val) where T : struct
			{
				return default;
			}

			[Token(Token = "0x60000F0")]
			public uint Write<T>(T val) where T : struct
			{
				return default;
			}

			[Token(Token = "0x60000F1")]
			public uint Write<T>(uint offset, [In] ref T val) where T : struct
			{
				return default;
			}

			[Token(Token = "0x60000F2")]
			public uint Write<T>(uint offset, T val) where T : struct
			{
				return default;
			}

			[Token(Token = "0x60000F3")]
			public uint Reserve<T>(uint count) where T : struct
			{
				return default;
			}

			[Token(Token = "0x60000F4")]
			public uint Write<T>(T[] values, bool hashElements = true) where T : struct
			{
				return default;
			}

			[Token(Token = "0x60000F5")]
			public uint Write<T>(uint offset, T[] values, bool hashElements = true) where T : struct
			{
				return default;
			}

			[Token(Token = "0x60000F6")]
			public uint WriteObjects<T>(IEnumerable<T> objs, bool serizalizeTypeData)
			{
				return default;
			}

			[Token(Token = "0x60000F7")]
			[Address(RVA = "0x2A7540C", Offset = "0x2A7540C", VA = "0x2A7540C")]
			public uint WriteObject(object obj, bool serializeTypeData)
			{
				return default;
			}

			[Token(Token = "0x60000F8")]
			[Address(RVA = "0x2A73A0C", Offset = "0x2A73A0C", VA = "0x2A73A0C")]
			public uint WriteString(string str, char sep = '\0')
			{
				return default;
			}

			[Token(Token = "0x60000F9")]
			[Address(RVA = "0x2A757D8", Offset = "0x2A757D8", VA = "0x2A757D8")]
			private uint WriteStringInternal(string val, Encoding enc)
			{
				return default;
			}

			[Token(Token = "0x60000FA")]
			[Address(RVA = "0x2A75854", Offset = "0x2A75854", VA = "0x2A75854")]
			public byte[] SerializeToByteArray()
			{
				return null;
			}

			[Token(Token = "0x60000FB")]
			[Address(RVA = "0x2A75AC8", Offset = "0x2A75AC8", VA = "0x2A75AC8")]
			public uint SerializeToStream(Stream str)
			{
				return default;
			}

			[Token(Token = "0x60000FC")]
			[Address(RVA = "0x2A75C50", Offset = "0x2A75C50", VA = "0x2A75C50")]
			private static bool IsUnicode(string str)
			{
				return default;
			}

			[Token(Token = "0x60000FD")]
			[Address(RVA = "0x2A7572C", Offset = "0x2A7572C", VA = "0x2A7572C")]
			private uint WriteAutoEncodedString(string str)
			{
				return default;
			}

			[Token(Token = "0x60000FE")]
			[Address(RVA = "0x2A75CB8", Offset = "0x2A75CB8", VA = "0x2A75CB8")]
			private uint WriteUnicodeString(string str)
			{
				return default;
			}

			[Token(Token = "0x60000FF")]
			[Address(RVA = "0x2A75CF4", Offset = "0x2A75CF4", VA = "0x2A75CF4")]
			private static uint ComputeStringSize(string str, out bool isUnicode)
			{
				return default;
			}

			[Token(Token = "0x6000100")]
			[Address(RVA = "0x2A75D8C", Offset = "0x2A75D8C", VA = "0x2A75D8C")]
			private uint RecurseDynamicStringParts(StringParts[] parts, int index, char sep, uint minSize)
			{
				return default;
			}

			[Token(Token = "0x6000101")]
			[Address(RVA = "0x2A7556C", Offset = "0x2A7556C", VA = "0x2A7556C")]
			private uint WriteDynamicString(string str, char sep)
			{
				return default;
			}
		}

		[Token(Token = "0x4000059")]
		private const uint kUnicodeStringFlag = 2147483648u;

		[Token(Token = "0x400005A")]
		private const uint kDynamicStringFlag = 1073741824u;

		[Token(Token = "0x400005B")]
		private const uint kClearFlagsMask = 1073741823u;

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x2A62E28", Offset = "0x2A62E28", VA = "0x2A62E28")]
		private unsafe static void ComputeHash(void* pData, ulong size, Hash128* hash)
		{
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x2A62E40", Offset = "0x2A62E40", VA = "0x2A62E40")]
		private static void AddSerializationAdapter(Dictionary<Type, ISerializationAdapter> serializationAdapters, ISerializationAdapter adapter, bool forceOverride = false)
		{
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x2A63488", Offset = "0x2A63488", VA = "0x2A63488")]
		private static bool GetSerializationAdapter(Dictionary<Type, ISerializationAdapter> serializationAdapters, Type t, out ISerializationAdapter adapter)
		{
			return default;
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x2A636F0", Offset = "0x2A636F0", VA = "0x2A636F0")]
		public BinaryStorageBuffer()
		{
		}
	}
}
