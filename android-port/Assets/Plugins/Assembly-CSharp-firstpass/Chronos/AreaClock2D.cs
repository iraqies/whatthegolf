using Il2CppDummyDll;
using UnityEngine;

namespace Chronos
{
	[Token(Token = "0x200028E")]
	[DisallowMultipleComponent]
	public class AreaClock2D : AreaClock<Collider2D, Vector2>
	{
		[Token(Token = "0x60010DF")]
		[Address(RVA = "0x12F008C", Offset = "0x12F008C", VA = "0x12F008C", Slot = "22")]
		protected virtual void OnTriggerEnter2D(Collider2D other)
		{
		}

		[Token(Token = "0x60010E0")]
		[Address(RVA = "0x12F01A0", Offset = "0x12F01A0", VA = "0x12F01A0", Slot = "23")]
		protected virtual void OnTriggerExit2D(Collider2D collider)
		{
		}

		[Token(Token = "0x60010E1")]
		[Address(RVA = "0x12F026C", Offset = "0x12F026C", VA = "0x12F026C", Slot = "19")]
		protected override float PointToEdgeTimeScale(Vector3 position)
		{
			return default;
		}

		[Token(Token = "0x60010E2")]
		[Address(RVA = "0x12F0968", Offset = "0x12F0968", VA = "0x12F0968", Slot = "20")]
		public override bool ContainsPoint(Vector3 point)
		{
			return default;
		}

		[Token(Token = "0x60010E3")]
		[Address(RVA = "0x12F09F8", Offset = "0x12F09F8", VA = "0x12F09F8", Slot = "21")]
		public override void CacheComponents()
		{
		}

		[Token(Token = "0x60010E4")]
		[Address(RVA = "0x12F0B04", Offset = "0x12F0B04", VA = "0x12F0B04")]
		public AreaClock2D()
		{
		}
	}
}
