using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TMPro
{
	[Serializable]
	[Token(Token = "0x2000009")]
	public abstract class TMP_Asset : ScriptableObject
	{
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x18")]
		private int m_InstanceID;

		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x1C")]
		public int hashCode;

		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x20")]
		public Material material;

		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x28")]
		public int materialHashCode;

		[Token(Token = "0x17000002")]
		public int instanceID
		{
			[Token(Token = "0x600001E")]
			[Address(RVA = "0x2A7D85C", Offset = "0x2A7D85C", VA = "0x2A7D85C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x2A7D894", Offset = "0x2A7D894", VA = "0x2A7D894")]
		protected TMP_Asset()
		{
		}
	}
}
