using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoEndController : MonoBehaviour
{
	[Serializable]
	public class VideoOrder
	{
		public DemoEndLoader.EDemoEnded endType;

		public List<string> videoPaths;
	}

	[SerializeField]
	private Camera _cameraToUse;

	[SerializeField]
	private List<VideoOrder> _videoDefs;

	[SerializeField]
	private VideoContainer _videoContainer;

	[SerializeField]
	private DemoEndMenu _menuContainer;

	private List<string> _remainingVideoPaths;

	private IEnumerator Start()
	{
		return null;
	}

	public void ShowVideo()
	{
	}

	private void ContinueToNextVideoOrClosePlayer()
	{
	}

	public void HideVideo()
	{
	}

	public void ShowMenu()
	{
	}

	public void HideMenu()
	{
	}

	private void Update()
	{
	}
}
