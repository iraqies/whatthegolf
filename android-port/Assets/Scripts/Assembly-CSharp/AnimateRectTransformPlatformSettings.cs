using System;
using System.Collections.Generic;
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

	public AnimateRectTransform UIAnimater => null;

	private AvailablePlatformsEnum GetPlatform()
	{
		return AvailablePlatformsEnum.Mobile;
	}
}
