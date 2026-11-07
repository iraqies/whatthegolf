using System.Collections.Generic;
using UnityEngine;

namespace WhatTheGolf.LevelDesigner
{
	public class ElementDatabase : ScriptableObject
	{
		[SerializeField]
		private List<ElementDefinition> m_Elements;

		private Dictionary<int, ElementDefinition> m_idToElementLookup;

		private Dictionary<int, ElementDefinition> idToElementLookup => null;

		public List<ElementDefinition> GetElementsOfType<T>() where T : ElementDefinition
		{
			return null;
		}

		public ElementDefinition GetElement(int id)
		{
			return null;
		}
	}
}
