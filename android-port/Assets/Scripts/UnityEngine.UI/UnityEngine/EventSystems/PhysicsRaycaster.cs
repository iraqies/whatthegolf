using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.EventSystems
{
	[Token(Token = "0x20000B2")]
	[Attribute(Name = "RequireComponent", RVA = "0x1F6BC0", Offset = "0x1F6BC0")]
	public class PhysicsRaycaster : BaseRaycaster
	{
		[Token(Token = "0x20000B3")]
		private class RaycastHitComparer : IComparer<RaycastHit>
		{
			[Token(Token = "0x40002FB")]
			[FieldOffset(Offset = "0x0")]
			public static RaycastHitComparer instance;

			[Token(Token = "0x6000686")]
			[Address(RVA = "0x2C46834", Offset = "0x2C46834", VA = "0x2C46834", Slot = "4")]
			public int Compare(RaycastHit x, RaycastHit y)
			{
				return default;
			}

			[Token(Token = "0x6000687")]
			[Address(RVA = "0x2C46884", Offset = "0x2C46884", VA = "0x2C46884")]
			public RaycastHitComparer()
			{
			}
		}

		[Token(Token = "0x40002F5")]
		protected const int kNoEventMaskSet = -1;

		[Token(Token = "0x40002F6")]
		[FieldOffset(Offset = "0x20")]
		protected Camera m_EventCamera;

		[Token(Token = "0x40002F7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected LayerMask m_EventMask;

		[Token(Token = "0x40002F8")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		protected int m_MaxRayIntersections;

		[Token(Token = "0x40002F9")]
		[FieldOffset(Offset = "0x30")]
		protected int m_LastMaxRayIntersections;

		[Token(Token = "0x40002FA")]
		[FieldOffset(Offset = "0x38")]
		private RaycastHit[] m_Hits;

		[Token(Token = "0x170001BA")]
		public override Camera eventCamera
		{
			[Token(Token = "0x600067D")]
			[Address(RVA = "0x2C2BA40", Offset = "0x2C2BA40", VA = "0x2C2BA40", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001BB")]
		public virtual int depth
		{
			[Token(Token = "0x600067E")]
			[Address(RVA = "0x2C2BB00", Offset = "0x2C2BB00", VA = "0x2C2BB00", Slot = "22")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170001BC")]
		public int finalEventMask
		{
			[Token(Token = "0x600067F")]
			[Address(RVA = "0x2C2B96C", Offset = "0x2C2B96C", VA = "0x2C2B96C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170001BD")]
		public LayerMask eventMask
		{
			[Token(Token = "0x6000680")]
			[Address(RVA = "0x2C2BBD4", Offset = "0x2C2BBD4", VA = "0x2C2BBD4")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000681")]
			[Address(RVA = "0x2C2BBDC", Offset = "0x2C2BBDC", VA = "0x2C2BBDC")]
			set
			{
			}
		}

		[Token(Token = "0x170001BE")]
		public int maxRayIntersections
		{
			[Token(Token = "0x6000682")]
			[Address(RVA = "0x2C2BBE4", Offset = "0x2C2BBE4", VA = "0x2C2BBE4")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000683")]
			[Address(RVA = "0x2C2BBEC", Offset = "0x2C2BBEC", VA = "0x2C2BBEC")]
			set
			{
			}
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0x2C2AF4C", Offset = "0x2C2AF4C", VA = "0x2C2AF4C")]
		protected PhysicsRaycaster()
		{
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0x2C2B6EC", Offset = "0x2C2B6EC", VA = "0x2C2B6EC")]
		protected bool ComputeRayAndDistance(PointerEventData eventData, ref Ray ray, ref int eventDisplayIndex, ref float distanceToClipPlane)
		{
			return default;
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0x2C2BBF4", Offset = "0x2C2BBF4", VA = "0x2C2BBF4", Slot = "17")]
		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
		}
	}
}
