using System;
using System.Collections.Generic;
using Moments;
using UnityEngine;

public class BaseSaveGif : MonoBehaviour
{
	public float GifDuration;

	public float SaveDelay;

	public Action<string, List<RenderTexture>> OnFramesRetrieved;

	protected Moments.Recorder recorder;

	private bool isSaving;

	private bool destroyNextFrame;

	private void Awake()
	{
	}

	protected virtual void Start()
	{
	}

	private void Update()
	{
	}

	private void Instance_OnLevelWillUnload()
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

	protected void Save()
	{
	}

	protected void SaveInterval(float duration)
	{
	}
}
