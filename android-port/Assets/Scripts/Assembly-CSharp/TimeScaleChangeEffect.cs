using System.Collections.Generic;
using CameraStack;
using Core;
using UnityEngine;

public class TimeScaleChangeEffect : MonoBehaviour
{
	public CanvasGroup CanvasGroup;

	public Vector2 AlphaRange = new Vector2(0f, 0.5f);

	public float Scale;

	public float ChangeSpeed = 5f;

	public List<Transform> Bars;

	public float FovChange = -5f;

	public float OrthoSizeChange = -1f;

	private float target;

	private CameraFilterPack_Color_Sepia sepia;

	private bool inLevel;

	private void Start()
	{
		if (LevelManager.Instance != null)
		{
			LevelManager.Instance.OnLevelLoaded += InstanceOnOnLevelLoaded;
			LevelManager.Instance.OnLevelWillUnload += InstanceOnOnLevelWillUnload;
		}
	}

	private void InstanceOnOnLevelWillUnload()
	{
		if (sepia != null)
		{
			Object.Destroy(sepia);
			sepia = null;
		}
		inLevel = false;
	}

	public void ToggleEffect(bool state)
	{
		inLevel = state;
	}

	private void InstanceOnOnLevelLoaded(LevelData levelData)
	{
		if (sepia != null)
		{
			Object.Destroy(sepia);
			sepia = null;
		}
		inLevel = false;
	}

	private void Update()
	{
		if (!inLevel || sepia == null || CameraManager.Instance == null)
		{
			return;
		}
		float desired = 1f - Mathf.Clamp01(Time.timeScale);
		target = Mathf.MoveTowards(target, desired, Time.unscaledDeltaTime * ChangeSpeed);
		if (Bars != null)
		{
			for (int i = 0; i < Bars.Count; i++)
			{
				if (Bars[i] != null)
				{
					float yScale = Mathf.Lerp(0f, Scale, target);
					Bars[i].localScale = new Vector3(1f, yScale, 1f);
				}
			}
		}
		sepia._Fade = Mathf.Lerp(AlphaRange.x, AlphaRange.y, target);
	}
}
