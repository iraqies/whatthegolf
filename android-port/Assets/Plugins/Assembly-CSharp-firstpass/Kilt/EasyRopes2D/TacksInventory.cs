using System.Collections.Generic;
using UnityEngine;

namespace Kilt.EasyRopes2D
{
	[ExecuteInEditMode]
	public class TacksInventory : MonoBehaviour
	{
		private List<Tack> m_tacksInObject;

		private bool _needCheckKinematic;

		private bool _needFillWithChildrenTacks;

		public List<Tack> TacksInObject
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		protected virtual void Awake()
		{
		}

		protected virtual void Start()
		{
		}

		protected virtual void Update()
		{
		}

		public void AddTackInList(Tack p_tack)
		{
		}

		public void RemoveTackFromList(Tack p_tack)
		{
		}

		public void FillWithChildrenTacks(bool p_force = false)
		{
		}

		public void MarkToCheckKinematic()
		{
		}

		public void CheckKinematic(bool p_force = false)
		{
		}

		public GameObject GetTackObjectWithIndex(int p_index, bool p_returnDefaultWhenOutOfBounds = true)
		{
			return null;
		}

		public Tack GetTackWithIndex(int p_index, bool p_returnDefaultWhenOutOfBounds = true)
		{
			return null;
		}

		public int GetIndexOfTack(Tack p_tack, bool p_addThisTackIfNotAdded = true)
		{
			return 0;
		}
	}
}
