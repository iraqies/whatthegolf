using System.Collections;
using Moments;
using UnityEngine;
using UnityEngine.Events;

public class StandaloneGifExporter : MonoBehaviour
{
	private Moments.Recorder recorder;

	private GifMoment moment;

	public UnityAction<float> percentDone;

	public UnityAction<bool, string> exportComplete;

	public float currentPercentDone;

	private string exportPath;

	private Coroutine savingCheckCR;

	public void Export(GifMoment moment, UnityAction<float> percentDoneCallback, UnityAction<bool, string> exportCompletedCallback)
	{
	}

	public void SaveGifToFile(string gifName, GifMoment moment)
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

	private IEnumerator SavingCheckCR()
	{
		return null;
	}

	public void Cancel()
	{
	}
}
