using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x2001359")]
	[Attribute(Name = "RequireComponent", RVA = "0x48CCC", Offset = "0x48CCC")]
	public class AudioTremolo : MonoBehaviour
	{
		[Token(Token = "0x400678E")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "RangeAttribute", RVA = "0x59F1C", Offset = "0x59F1C")]
		[SerializeField]
		private float frequency;

		[Token(Token = "0x400678F")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "RangeAttribute", RVA = "0x59F60", Offset = "0x59F60")]
		[SerializeField]
		private float depth;

		[Token(Token = "0x4006790")]
		[FieldOffset(Offset = "0x20")]
		private float increment;

		[Token(Token = "0x4006791")]
		[FieldOffset(Offset = "0x24")]
		private float phase;

		[Token(Token = "0x4006792")]
		[FieldOffset(Offset = "0x28")]
		private float sampling_frequency;

		[Token(Token = "0x6005A42")]
		[Address(RVA = "0x150E0D8", Offset = "0x150E0D8", VA = "0x150E0D8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6005A43")]
		[Address(RVA = "0x150E104", Offset = "0x150E104", VA = "0x150E104")]
		private void OnAudioFilterRead(float[] data, int channels)
		{
		}

		[Token(Token = "0x6005A44")]
		[Address(RVA = "0x150E22C", Offset = "0x150E22C", VA = "0x150E22C")]
		public void SetFrequency(float f)
		{
		}

		[Token(Token = "0x6005A45")]
		[Address(RVA = "0x150E234", Offset = "0x150E234", VA = "0x150E234")]
		public void SetDepth(float d)
		{
		}

		[Token(Token = "0x6005A46")]
		[Address(RVA = "0x150E23C", Offset = "0x150E23C", VA = "0x150E23C")]
		public AudioTremolo()
		{
		}
	}
}
