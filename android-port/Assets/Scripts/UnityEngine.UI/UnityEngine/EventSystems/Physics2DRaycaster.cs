using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.EventSystems
{
	[Token(Token = "0x20000B1")]
	[Attribute(Name = "RequireComponent", RVA = "0x1F6B58", Offset = "0x1F6B58")]
	public class Physics2DRaycaster : PhysicsRaycaster
	{
		[Token(Token = "0x40002F4")]
		[FieldOffset(Offset = "0x40")]
		private RaycastHit2D[] m_Hits;

		[Token(Token = "0x600067A")]
		[Address(RVA = "0x2C2AF18", Offset = "0x2C2AF18", VA = "0x2C2AF18")]
		protected Physics2DRaycaster()
		{
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0x2C2AF80", Offset = "0x2C2AF80", VA = "0x2C2AF80", Slot = "17")]
		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
		}
	}
}
