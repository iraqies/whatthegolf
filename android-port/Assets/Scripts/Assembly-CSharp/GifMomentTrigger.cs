using System.Collections;
using Core;
using UnityEngine;

public class GifMomentTrigger : MonoBehaviour
{
	public EGifMoment momentId;

	public float durationBeforeTrigger;

	public float durationAfterTrigger;

	private bool canOverwrite;

	private IGifRecorder recorder;

	private bool wasTriggered;

	private GifMomentManager manager;

	private bool isRecording;

	private Coroutine saveAfterDelayCR;

	private bool canRecordThisLevel => false;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void ManualTrigger()
	{
	}

	private void StartRecording()
	{
	}

	private void CancelRecording()
	{
	}

	private void OnLevelRestart()
	{
	}

	private void StopRecording(bool save)
	{
	}

	private void OnLevelCompleted(Level.CompletedState state)
	{
	}

	private void OnDestroy()
	{
	}

	private void OnTriggerEnter(Collider c)
	{
	}

	private void OnTriggerEnter2D(Collider2D c)
	{
	}

	private IEnumerator SaveAfterDelayCR(float delay)
	{
		return null;
	}
}
