using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x2001364")]
	public class RagdollLimbSettings : MonoBehaviour
	{
		[Token(Token = "0x40067CE")]
		[FieldOffset(Offset = "0x18")]
		public LimbGroup Head;

		[Token(Token = "0x40067CF")]
		[FieldOffset(Offset = "0x20")]
		public LimbGroup Arms;

		[Token(Token = "0x40067D0")]
		[FieldOffset(Offset = "0x28")]
		public LimbGroup Torso;

		[Token(Token = "0x40067D1")]
		[FieldOffset(Offset = "0x30")]
		public LimbGroup Legs;

		[Token(Token = "0x40067D2")]
		[FieldOffset(Offset = "0x38")]
		public GameObject m_Root;

		[Token(Token = "0x40067D3")]
		[FieldOffset(Offset = "0x40")]
		public bool canHitSelf;

		[Token(Token = "0x40067D4")]
		[FieldOffset(Offset = "0x48")]
		public List<GameObject> m_AllLimbs;

		[Token(Token = "0x40067D5")]
		[FieldOffset(Offset = "0x50")]
		private RigidbodyCollisionInfo[] limbInfos;

		[Token(Token = "0x6005A73")]
		[Address(RVA = "0x163B7D0", Offset = "0x163B7D0", VA = "0x163B7D0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6005A74")]
		[Address(RVA = "0x163B84C", Offset = "0x163B84C", VA = "0x163B84C")]
		public RagdollLimbSettings()
		{
		}
	}
}
