using Il2CppDummyDll;
using UnityEngine;

namespace MonitorComponents
{
	[Token(Token = "0x200026C")]
	public class MonitorInput
	{
		[Token(Token = "0x4000FD3")]
		[FieldOffset(Offset = "0x10")]
		private Monitor monitor;

		[Token(Token = "0x4000FD4")]
		[FieldOffset(Offset = "0x18")]
		private string description;

		[Token(Token = "0x4000FD5")]
		[FieldOffset(Offset = "0x20")]
		private Color color;

		[Token(Token = "0x4000FD6")]
		[FieldOffset(Offset = "0x30")]
		public int sampleIndex;

		[Token(Token = "0x4000FD7")]
		[FieldOffset(Offset = "0x34")]
		public int numberOfSamples;

		[Token(Token = "0x4000FD8")]
		[FieldOffset(Offset = "0x38")]
		public float[] samples;

		[Token(Token = "0x4000FD9")]
		[FieldOffset(Offset = "0x40")]
		public float[] times;

		[Token(Token = "0x4000FDA")]
		[FieldOffset(Offset = "0x48")]
		public int[] frames;

		[Token(Token = "0x170001F1")]
		public Color Color
		{
			[Token(Token = "0x6001012")]
			[Address(RVA = "0x13B0CB4", Offset = "0x13B0CB4", VA = "0x13B0CB4")]
			set
			{
			}
		}

		[Token(Token = "0x600100E")]
		[Address(RVA = "0x13AFEE0", Offset = "0x13AFEE0", VA = "0x13AFEE0")]
		public MonitorInput(Monitor monitor, string description)
		{
		}

		[Token(Token = "0x600100F")]
		[Address(RVA = "0x13AF2CC", Offset = "0x13AF2CC", VA = "0x13AF2CC")]
		public MonitorInput(Monitor monitor, string description, Color color)
		{
		}

		[Token(Token = "0x6001010")]
		[Address(RVA = "0x13AF5B4", Offset = "0x13AF5B4", VA = "0x13AF5B4")]
		public void Sample(float value)
		{
		}

		[Token(Token = "0x6001011")]
		[Address(RVA = "0x13AF474", Offset = "0x13AF474", VA = "0x13AF474")]
		public void Close()
		{
		}
	}
}
