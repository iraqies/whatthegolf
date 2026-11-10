using System;
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
	private float volume = 0.5f;

	[SerializeField]
	private float pitch = 1.25f;

	[SerializeField]
	private float pitchDeviance = 0.1f;

	[SerializeField]
	private float cooldown = 0.2f;

	[SerializeField]
	private List<AudioClip> onConnectAudioClips;

	[SerializeField]
	private List<RumbleEventAsset> onConnectRumbles;

	[SerializeField]
	private RumbleEventAsset rumbleOnConnect;

	private GolfBallController controller;

	public void SetController(GolfBallController _controller)
	{
		controller = _controller;
	}

	private void OnEnable()
	{
		if (hook == null)
		{
			hook = GetComponent<GrapplingHook>();
		}
		if (hook != null)
		{
			GrapplingHook grapplingHook = hook;
			grapplingHook.OnCollided = (Action<Rigidbody>)Delegate.Combine(grapplingHook.OnCollided, new Action<Rigidbody>(OnCollision));
		}
		if (hook2D == null)
		{
			hook2D = GetComponent<GrapplingHook2D>();
		}
		if (hook2D != null)
		{
			GrapplingHook2D grapplingHook2D = hook2D;
			grapplingHook2D.OnCollided = (Action<Rigidbody2D>)Delegate.Combine(grapplingHook2D.OnCollided, new Action<Rigidbody2D>(OnCollision2D));
		}
	}

	private void OnDisable()
	{
		if (hook != null)
		{
			GrapplingHook grapplingHook = hook;
			grapplingHook.OnCollided = (Action<Rigidbody>)Delegate.Remove(grapplingHook.OnCollided, new Action<Rigidbody>(OnCollision));
		}
		if (hook2D != null)
		{
			GrapplingHook2D grapplingHook2D = hook2D;
			grapplingHook2D.OnCollided = (Action<Rigidbody2D>)Delegate.Remove(grapplingHook2D.OnCollided, new Action<Rigidbody2D>(OnCollision2D));
		}
	}

	private void OnCollision(Rigidbody rb)
	{
		PlayConnectionAudio();
	}

	private void OnCollision2D(Rigidbody2D rb)
	{
		PlayConnectionAudio();
	}

	private void PlayConnectionAudio()
	{
		if (Time.time >= nextSound)
		{
			nextSound = Time.time + cooldown;
			float newPitch = pitch + UnityEngine.Random.Range(0f - pitchDeviance, pitchDeviance);
			AudioManager.Instance.shortEffects.Play(onConnectAudioClips, delegate(AudioSource s)
			{
				s.transform.position = base.transform.position;
				s.priority = 127;
				s.volume = volume;
				s.pitch = newPitch;
			}, canRepeat: true, 0f, reverse: false);
			if (controller != null && rumbleOnConnect != null)
			{
				rumbleOnConnect.Play(controller.PlayerIndex, 1f);
			}
		}
	}
}
