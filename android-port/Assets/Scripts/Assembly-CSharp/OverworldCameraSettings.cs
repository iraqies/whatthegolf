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
		add => m_OnSettingsUpdated = (Action<OverworldCameraSettings, float>)Delegate.Combine(m_OnSettingsUpdated, value);
		[CompilerGenerated]
		remove => m_OnSettingsUpdated = (Action<OverworldCameraSettings, float>)Delegate.Remove(m_OnSettingsUpdated, value);
	}

	public void SetValue(float pct)
	{
		m_OnSettingsUpdated?.Invoke(this, pct);
	}

	public void SetWeight(float pct)
	{
		SetValue(pct);
	}

	public void SetWeight(object sender, float pct)
	{
		SetValue(pct);
	}
}
