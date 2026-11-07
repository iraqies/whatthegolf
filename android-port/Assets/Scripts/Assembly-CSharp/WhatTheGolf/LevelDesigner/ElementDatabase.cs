using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace WhatTheGolf.LevelDesigner
{
	[Token(Token = "0x200123F")]
	public class ElementDatabase : ScriptableObject
	{
		[Token(Token = "0x4006271")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<ElementDefinition> m_Elements;

		[Token(Token = "0x4006272")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<int, ElementDefinition> m_idToElementLookup;

		[Token(Token = "0x17000965")]
		private Dictionary<int, ElementDefinition> idToElementLookup
		{
			[Token(Token = "0x600540D")]
			[Address(RVA = "0x143CE6C", Offset = "0x143CE6C", VA = "0x143CE6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600540E")]
		public List<ElementDefinition> GetElementsOfType<T>() where T : ElementDefinition
		{
			return null;
		}

		[Token(Token = "0x600540F")]
		[Address(RVA = "0x143D094", Offset = "0x143D094", VA = "0x143D094")]
		public ElementDefinition GetElement(int id)
		{
			return null;
		}

		[Token(Token = "0x6005410")]
		[Address(RVA = "0x143D214", Offset = "0x143D214", VA = "0x143D214")]
		public ElementDatabase()
		{
		}
	}
}
