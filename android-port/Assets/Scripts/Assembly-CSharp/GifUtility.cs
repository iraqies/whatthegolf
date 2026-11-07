using System;
using System.Collections;
using System.Collections.Generic;
using Moments;
using TMPro;
using UnityEngine;

public class GifUtility : MonoBehaviour
{
	public static int GifHeight;

	public static int GifWidth;

	public static int FramesPerSecond;

	public static int Quality;

	public static bool CaptureGifs;

	[SerializeField]
	private TextMeshProUGUI scoreText;

	[SerializeField]
	private Camera scoreCamera;

	[SerializeField]
	private Material blitMaterial;

	[SerializeField]
	private Moments.Recorder finalRecorder;

	[SerializeField]
	private int gifWidth;

	[SerializeField]
	private int gifHeight;

	[SerializeField]
	private int framesPerSecond;

	[SerializeField]
	private int quality;

	public Action OnGifSaved;

	public Action<float> OnGifSaveProgress;

	public Action OnGifBatchCompleted;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnBatchCompleted()
	{
	}

	private void OnFileSaveProgress(int i, float p)
	{
	}

	private void OnFileSaved(int i, string s)
	{
	}

	public IEnumerator CombineGifsWhenReady(string levelName, int numberOfStrokes, Dictionary<string, List<RenderTexture>> allFrames, Action onDone = null)
	{
		return null;
	}

	public void AllLevelsCompleted()
	{
	}

	public void Abort()
	{
	}

	private void OnApplicationQuit()
	{
	}
}
