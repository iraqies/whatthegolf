using Il2CppDummyDll;
using UnityEngine;

namespace DanceOff
{
	[Token(Token = "0x20011F4")]
	public abstract class Dancer : MonoBehaviour
	{
		[Token(Token = "0x6005278")]
		[Address(RVA = "0x18D44DC", Offset = "0x18D44DC", VA = "0x18D44DC", Slot = "4")]
		public virtual void Dance(Vector2 dir)
		{
		}

		[Token(Token = "0x6005279")]
		[Address(RVA = "0x18D44E0", Offset = "0x18D44E0", VA = "0x18D44E0", Slot = "5")]
		public virtual void Fail(Vector2 dir)
		{
		}

		[Token(Token = "0x600527A")]
		[Address(RVA = "0x18D44E4", Offset = "0x18D44E4", VA = "0x18D44E4")]
		protected Dancer()
		{
		}
	}
}
