using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Serializable]
	[Token(Token = "0x2001365")]
	public class LimbGroup
	{
		[Token(Token = "0x40067D6")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40067D7")]
		[FieldOffset(Offset = "0x18")]
		public List<GameObject> m_CollideOnLimbs;

		[Token(Token = "0x40067D8")]
		[FieldOffset(Offset = "0x20")]
		public Action<HitInfo> onGroupCollision;

		[Token(Token = "0x40067D9")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A170", Offset = "0x5A170")]
		private RigidbodyCollisionInfo[] m_colInfo__BackingField;

		[Token(Token = "0x40067DA")]
		[FieldOffset(Offset = "0x30")]
		private HashSet<GameObject> m_allLimbs;

		[Token(Token = "0x40067DB")]
		[FieldOffset(Offset = "0x38")]
		private bool m_canHitSelf;

		[Token(Token = "0x17000A37")]
		private RigidbodyCollisionInfo[] m_colInfo
		{
			[Token(Token = "0x6005A76")]
			[Address(RVA = "0x1532264", Offset = "0x1532264", VA = "0x1532264")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72368", Offset = "0x72368")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005A77")]
			[Address(RVA = "0x153226C", Offset = "0x153226C", VA = "0x153226C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72378", Offset = "0x72378")]
			set
			{
			}
		}

		[Token(Token = "0x6005A75")]
		[Address(RVA = "0x15321D0", Offset = "0x15321D0", VA = "0x15321D0")]
		public LimbGroup(string _name)
		{
		}

		[Token(Token = "0x6005A78")]
		[Address(RVA = "0x1532274", Offset = "0x1532274", VA = "0x1532274")]
		public void Init(List<GameObject> allLimbs, bool canHitSelf)
		{
		}

		[Token(Token = "0x6005A79")]
		[Address(RVA = "0x15324B0", Offset = "0x15324B0", VA = "0x15324B0")]
		private void OnGroupCollision(HitInfo hit)
		{
		}
	}
}
