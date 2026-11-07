using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.ResourceManagement.Util
{
	[Serializable]
	[Token(Token = "0x200003B")]
	public struct ObjectInitializationData
	{
		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B7E60", Offset = "0x1B7E60")]
		[SerializeField]
		private string m_Id;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B7EAC", Offset = "0x1B7EAC")]
		private SerializedType m_ObjectType;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B7EF8", Offset = "0x1B7EF8")]
		private string m_Data;

		[Token(Token = "0x17000032")]
		public string Id
		{
			[Token(Token = "0x6000158")]
			[Address(RVA = "0x2A6A948", Offset = "0x2A6A948", VA = "0x2A6A948")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000033")]
		public SerializedType ObjectType
		{
			[Token(Token = "0x6000159")]
			[Address(RVA = "0x2A6A950", Offset = "0x2A6A950", VA = "0x2A6A950")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000034")]
		public string Data
		{
			[Token(Token = "0x600015A")]
			[Address(RVA = "0x2A6A960", Offset = "0x2A6A960", VA = "0x2A6A960")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x2A6A968", Offset = "0x2A6A968", VA = "0x2A6A968", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600015C")]
		public TObject CreateInstance<TObject>([Optional] string idOverride)
		{
			return (TObject)null;
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x2A6AA00", Offset = "0x2A6AA00", VA = "0x2A6AA00")]
		public AsyncOperationHandle GetAsyncInitHandle(ResourceManager rm, [Optional] string idOverride)
		{
			return default;
		}
	}
}
