using Moments;

public class StandaloneGifRecorder : IGifRecorder
{
	private Moments.Recorder recorder;

	private GifMoment moment;

	public void StartRecording(float gifDuration, GifMoment moment)
	{
	}

	private void OnProcessingDone()
	{
	}

	private void OnFileSaveProgress(int id, float percent)
	{
	}

	private void OnFileSaved(int id, string filepath)
	{
	}

	public void Stop(bool save)
	{
	}

	public void Dispose()
	{
	}
}
