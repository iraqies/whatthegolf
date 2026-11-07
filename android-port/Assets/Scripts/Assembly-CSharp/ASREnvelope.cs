using Il2CppDummyDll;

[Token(Token = "0x20003CE")]
public class ASREnvelope
{
	[Token(Token = "0x20003CF")]
	private enum State
	{
		[Token(Token = "0x40014EE")]
		Idle = 0,
		[Token(Token = "0x40014EF")]
		Attack = 1,
		[Token(Token = "0x40014F0")]
		Sustain = 2,
		[Token(Token = "0x40014F1")]
		Release = 3
	}

	[Token(Token = "0x40014E8")]
	[FieldOffset(Offset = "0x10")]
	private State _state;

	[Token(Token = "0x40014E9")]
	[FieldOffset(Offset = "0x18")]
	private double _attackIncrement;

	[Token(Token = "0x40014EA")]
	[FieldOffset(Offset = "0x20")]
	private uint _sustainSamples;

	[Token(Token = "0x40014EB")]
	[FieldOffset(Offset = "0x28")]
	private double _releaseIncrement;

	[Token(Token = "0x40014EC")]
	[FieldOffset(Offset = "0x30")]
	private double _outputLevel;

	[Token(Token = "0x60011F0")]
	[Address(RVA = "0x1403CE0", Offset = "0x1403CE0", VA = "0x1403CE0")]
	public void Reset(double attackTime_s, double sustainTime_s, double releaseTime_s, int sampleRate)
	{
	}

	[Token(Token = "0x60011F1")]
	[Address(RVA = "0x1403D50", Offset = "0x1403D50", VA = "0x1403D50")]
	public double GetLevel()
	{
		return default;
	}

	[Token(Token = "0x60011F2")]
	[Address(RVA = "0x1403E48", Offset = "0x1403E48", VA = "0x1403E48")]
	public ASREnvelope()
	{
	}
}
