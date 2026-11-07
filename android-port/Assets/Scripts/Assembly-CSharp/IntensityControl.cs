using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20003D0")]
public class IntensityControl : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20003D1")]
	public class SequencerIntensityPair
	{
		[Token(Token = "0x40014F3")]
		[FieldOffset(Offset = "0x10")]
		public StepSequencer Sequencer;

		[Token(Token = "0x40014F4")]
		[FieldOffset(Offset = "0x18")]
		public float Intensity;

		[Token(Token = "0x60011F6")]
		[Address(RVA = "0x17C6E94", Offset = "0x17C6E94", VA = "0x17C6E94")]
		public SequencerIntensityPair()
		{
		}
	}

	[Token(Token = "0x40014F2")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private SequencerIntensityPair[] _sequencerIntensityPairs;

	[Token(Token = "0x60011F3")]
	[Address(RVA = "0x14F16C8", Offset = "0x14F16C8", VA = "0x14F16C8")]
	public void OnSliderUpdate(float sliderValue)
	{
	}

	[Token(Token = "0x60011F4")]
	[Address(RVA = "0x14F173C", Offset = "0x14F173C", VA = "0x14F173C")]
	private void Start()
	{
	}

	[Token(Token = "0x60011F5")]
	[Address(RVA = "0x14F17A0", Offset = "0x14F17A0", VA = "0x14F17A0")]
	public IntensityControl()
	{
	}
}
