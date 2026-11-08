using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using UnityEngine;

public class AnimateRectTransformPlatformSettings : MonoBehaviour
{
	[Serializable]
	public class PlatformCameraSettings
	{
		public AvailablePlatformsEnum Platform;

		public AnimateRectTransform animateRectTransform;
	}

	public enum AvailablePlatformsEnum
	{
		Mobile = 0,
		NonMobile = 1
	}

	public List<PlatformCameraSettings> Settings;

	public AnimateRectTransform UIAnimater
	{
		get
		{
			if (Settings == null || Settings.Count == 0)
				return GetComponent<AnimateRectTransform>();
			var plat = GetPlatform();
			var match = Settings.FirstOrDefault(s => s != null && s.Platform == plat);
			if (match != null && match.animateRectTransform != null)
				return match.animateRectTransform;
			var fallback = Settings.FirstOrDefault(s => s != null && s.animateRectTransform != null);
			return fallback != null ? fallback.animateRectTransform : GetComponent<AnimateRectTransform>();
		}
	}

	private AvailablePlatformsEnum GetPlatform()
	{
		return PlatformSettings.IsMobile ? AvailablePlatformsEnum.Mobile : AvailablePlatformsEnum.NonMobile;
	}
}
