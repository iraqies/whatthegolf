using System.Collections.Generic;
using Audio.Rumble;
using Core;
using UnityEngine;

public class HookAudio : MonoBehaviour
{
	private GrapplingHook hook;

	private GrapplingHook2D hook2D;

	private float nextSound;

	[SerializeField]
	private float volume;

	[SerializeField]
	private float pitch;

	[SerializeField]
	private float pitchDeviance;

	[SerializeField]
	private float cooldown;

	[SerializeField]
	private List<AudioClip> onConnectAudioClips;

	[SerializeField]
	private List<RumbleEventAsset> onConnectRumbles;

	[SerializeField]
	private RumbleEventAsset rumbleOnConnect;

	private GolfBallController controller;

	public void SetController(GolfBallController _controller)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnCollision(Rigidbody rb)
	{
	}

	private void OnCollision2D(Rigidbody2D rb)
	{
	}

	private void PlayConnectionAudio()
	{
	}
}
