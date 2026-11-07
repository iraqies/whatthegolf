using System;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDependentCanvasScaling : MonoBehaviour
{
	[Serializable]
	private struct CanvasSettings
	{
		public EPlatformType platform;

		public int canvasWidth;

		public int canvasHeigt;
	}

	[SerializeField]
	private List<CanvasSettings> settings;

	[SerializeField]
	private RectTransform childRectTransform;

	private void Awake()
	{
	}
}
