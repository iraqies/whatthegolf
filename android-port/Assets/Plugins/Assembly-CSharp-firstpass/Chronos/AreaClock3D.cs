using Il2CppDummyDll;
using UnityEngine;

namespace Chronos
{
	[Token(Token = "0x200028F")]
	[DisallowMultipleComponent]
	public class AreaClock3D : AreaClock<Collider, Vector3>
	{
		[Token(Token = "0x60010E5")]
		[Address(RVA = "0x12F0B5C", Offset = "0x12F0B5C", VA = "0x12F0B5C", Slot = "22")]
		protected virtual void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60010E6")]
		[Address(RVA = "0x12F0C70", Offset = "0x12F0C70", VA = "0x12F0C70", Slot = "23")]
		protected virtual void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x60010E7")]
		[Address(RVA = "0x12F0D3C", Offset = "0x12F0D3C", VA = "0x12F0D3C", Slot = "19")]
		protected override float PointToEdgeTimeScale(Vector3 position)
		{
			return default;
		}

		[Token(Token = "0x60010E8")]
		[Address(RVA = "0x12F1220", Offset = "0x12F1220", VA = "0x12F1220", Slot = "20")]
		public override bool ContainsPoint(Vector3 point)
		{
			return default;
		}

		[Token(Token = "0x60010E9")]
		[Address(RVA = "0x12F128C", Offset = "0x12F128C", VA = "0x12F128C", Slot = "21")]
		public override void CacheComponents()
		{
		}

		[Token(Token = "0x60010EA")]
		[Address(RVA = "0x12F1398", Offset = "0x12F1398", VA = "0x12F1398")]
		public AreaClock3D()
		{
		}
	}
}
