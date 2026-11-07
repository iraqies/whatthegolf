using System;
using Audio;
using UnityEngine;

public class RepeatRumbleTest : MonoBehaviour, IAudioEvent
{
	public Action<Vector3> OnAudioEvent { get; set; }

	private void Awake()
	{
	}

	public void Test()
	{
	}
}
