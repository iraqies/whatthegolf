using System.Collections.Generic;
using Core;
using UnityEngine;

public class TimeScaleChangeEffect : MonoBehaviour
{
	public CanvasGroup CanvasGroup;

	public Vector2 AlphaRange;

	public float Scale;

	public float ChangeSpeed;

	public List<Transform> Bars;

	public float FovChange;

	public float OrthoSizeChange;

	private float target;

	private CameraFilterPack_Color_Sepia sepia;

	private bool inLevel;

	private void Start()
	{
	}

	private void InstanceOnOnLevelWillUnload()
	{
	}

	public void ToggleEffect(bool state)
	{
	}

	private void InstanceOnOnLevelLoaded(LevelData levelData)
	{
	}

	private void Update()
	{
	}
}
