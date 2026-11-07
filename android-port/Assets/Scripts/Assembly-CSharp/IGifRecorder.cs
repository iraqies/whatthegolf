public interface IGifRecorder
{
	void StartRecording(float gifDuration, GifMoment moment);

	void Stop(bool save);

	void Dispose();
}
