using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class OverworldCameraSettings : MonoBehaviour
{
	[Serializable]
	public class CameraData
	{
		public float orthographicSize;

		public float sideTrackPadding;

		public float upperTrackPadding;

		public float lowerTrackPadding;

		public bool lockVerticalAxis;

		public bool lockHorizontalAxis;

		public Vector2 offset;

		public float tweenTime;

		public float tweenTimtweenTime;

		public float lookAhead;
	}

	[CompilerGenerated]
	private Action<OverworldCameraSettings, float> m_OnSettingsUpdated;

	public CameraData IOSData;

	public CameraData PCTVData;

	public event Action<OverworldCameraSettings, float> OnSettingsUpdated
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public void SetValue(float pct)
	{
	}
}
