using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Kilt.EasyRopes2D
{
	[Token(Token = "0x20000B5")]
	[ExecuteInEditMode]
	public class TacksInventory : MonoBehaviour
	{
		[Token(Token = "0x4000378")]
		[FieldOffset(Offset = "0x18")]
		private List<Tack> m_tacksInObject;

		[Token(Token = "0x4000379")]
		[FieldOffset(Offset = "0x20")]
		private bool _needCheckKinematic;

		[Token(Token = "0x400037A")]
		[FieldOffset(Offset = "0x21")]
		private bool _needFillWithChildrenTacks;

		[Token(Token = "0x170000C4")]
		public List<Tack> TacksInObject
		{
			[Token(Token = "0x60004C2")]
			[Address(RVA = "0x1318E2C", Offset = "0x1318E2C", VA = "0x1318E2C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004C3")]
			[Address(RVA = "0x1318EA8", Offset = "0x1318EA8", VA = "0x1318EA8")]
			protected set
			{
			}
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x1318EBC", Offset = "0x1318EBC", VA = "0x1318EBC", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x1318F8C", Offset = "0x1318F8C", VA = "0x1318F8C", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x1319364", Offset = "0x1319364", VA = "0x1319364", Slot = "6")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x1319390", Offset = "0x1319390", VA = "0x1319390")]
		public void AddTackInList(Tack p_tack)
		{
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x1319494", Offset = "0x1319494", VA = "0x1319494")]
		public void RemoveTackFromList(Tack p_tack)
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x1318EC4", Offset = "0x1318EC4", VA = "0x1318EC4")]
		public void FillWithChildrenTacks(bool p_force = false)
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x13183E8", Offset = "0x13183E8", VA = "0x13183E8")]
		public void MarkToCheckKinematic()
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x1318FB8", Offset = "0x1318FB8", VA = "0x1318FB8")]
		public void CheckKinematic(bool p_force = false)
		{
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x1318CA4", Offset = "0x1318CA4", VA = "0x1318CA4")]
		public GameObject GetTackObjectWithIndex(int p_index, bool p_returnDefaultWhenOutOfBounds = true)
		{
			return null;
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x131959C", Offset = "0x131959C", VA = "0x131959C")]
		public Tack GetTackWithIndex(int p_index, bool p_returnDefaultWhenOutOfBounds = true)
		{
			return null;
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x1318424", Offset = "0x1318424", VA = "0x1318424")]
		public int GetIndexOfTack(Tack p_tack, bool p_addThisTackIfNotAdded = true)
		{
			return default;
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x1319900", Offset = "0x1319900", VA = "0x1319900")]
		public TacksInventory()
		{
		}
	}
}
