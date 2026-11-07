using Il2CppDummyDll;
using UnityEngine;

namespace ch.sycoforge.Decal
{
	[Token(Token = "0x200000C")]
	public class DecalReceiver : MonoBehaviour
	{
		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x18")]
		public int MaxDecals;

		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x1C")]
		public float DepthStep;

		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x20")]
		internal int receivedAmount;

		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x24")]
		internal float sum;

		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x28")]
		internal float fractionsum;

		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x2C")]
		internal float step;

		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0x30")]
		internal EasyDecal LastDecal;

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x2C5C178", Offset = "0x2C5C178", VA = "0x2C5C178")]
		public void Receive(EasyDecal decal)
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x2C5C1CC", Offset = "0x2C5C1CC", VA = "0x2C5C1CC")]
		public DecalReceiver()
		{
		}
	}
}
