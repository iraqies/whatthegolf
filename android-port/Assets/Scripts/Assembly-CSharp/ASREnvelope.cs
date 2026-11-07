public class ASREnvelope
{
	private enum State
	{
		Idle = 0,
		Attack = 1,
		Sustain = 2,
		Release = 3
	}

	private State _state;

	private double _attackIncrement;

	private uint _sustainSamples;

	private double _releaseIncrement;

	private double _outputLevel;

	public void Reset(double attackTime_s, double sustainTime_s, double releaseTime_s, int sampleRate)
	{
	}

	public double GetLevel()
	{
		return 0.0;
	}
}
