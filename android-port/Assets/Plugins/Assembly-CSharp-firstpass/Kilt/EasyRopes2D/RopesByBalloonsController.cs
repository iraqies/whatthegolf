using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Kilt.EasyRopes2D
{
	[Token(Token = "0x2000099")]
	public class RopesByBalloonsController : MonoBehaviour
	{
		[Token(Token = "0x4000281")]
		[FieldOffset(Offset = "0x0")]
		private static RopesByBalloonsController m_instance;

		[Token(Token = "0x4000282")]
		[FieldOffset(Offset = "0x18")]
		private List<RopesByBallons> _ropesByBallonsList;

		[Token(Token = "0x4000283")]
		[FieldOffset(Offset = "0x20")]
		protected bool _needRemoveNulls;

		[Token(Token = "0x17000063")]
		public static RopesByBalloonsController Instance
		{
			[Token(Token = "0x6000301")]
			[Address(RVA = "0x13F23E8", Offset = "0x13F23E8", VA = "0x13F23E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000302")]
			[Address(RVA = "0x13F25D8", Offset = "0x13F25D8", VA = "0x13F25D8")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000064")]
		public List<RopesByBallons> RopesByBallonsList
		{
			[Token(Token = "0x6000303")]
			[Address(RVA = "0x13F2630", Offset = "0x13F2630", VA = "0x13F2630")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000304")]
			[Address(RVA = "0x13F26AC", Offset = "0x13F26AC", VA = "0x13F26AC")]
			protected set
			{
			}
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x13F26B4", Offset = "0x13F26B4", VA = "0x13F26B4", Slot = "4")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x13F26C4", Offset = "0x13F26C4", VA = "0x13F26C4", Slot = "5")]
		protected virtual RopesByBallons GetRopeByBallonStructureInternal(Rope2D p_rope, bool p_registerNewIfDontFind = true)
		{
			return null;
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x13F2A34", Offset = "0x13F2A34", VA = "0x13F2A34", Slot = "6")]
		protected virtual List<RopesByBallons> GetAllStructsWithBallonInternal(BalloonProperty p_ballon)
		{
			return null;
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x13F2E40", Offset = "0x13F2E40", VA = "0x13F2E40", Slot = "7")]
		protected virtual void RemoveNullRefs(bool p_force = false)
		{
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x13F30BC", Offset = "0x13F30BC", VA = "0x13F30BC")]
		public static bool InstanceExists()
		{
			return default;
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x13F3138", Offset = "0x13F3138", VA = "0x13F3138")]
		public static RopesByBalloonsController GetInstance(bool p_canCreateANewOne = false)
		{
			return null;
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x13F32BC", Offset = "0x13F32BC", VA = "0x13F32BC")]
		public static RopesByBallons GetRopeByBallonStructure(Rope2D p_rope, bool p_registerNewIfDontFind = true, bool p_canCreateNewControllerIfDontExists = true)
		{
			return null;
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x13F3384", Offset = "0x13F3384", VA = "0x13F3384")]
		public static List<RopesByBallons> GetAllStructsWithBallon(BalloonProperty p_ballon, bool p_canCreateNewControllerIfDontExists = true)
		{
			return null;
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x13F3480", Offset = "0x13F3480", VA = "0x13F3480")]
		public RopesByBalloonsController()
		{
		}
	}
}
