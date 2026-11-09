using System;
using System.Collections.Generic;
using Audio;
using UnityEngine;

public class OverworldConsole : GolfBehaviour
{
	public SpriteRenderer monitor;
	public SpriteRenderer lightbulb;
	public List<Color> lightbulbColors;
	public List<Color> colors;
	public float volume = 1f;
	public RandomAudioClips hitSfx;
	public List<string> secrets;
	public Action<SpeechbubbleList> OnHit;
	private ShowSpeechbubbleOnHit speech;
	private float nextHitSound;
	private float nextColor;
	private int colorIndex;
	private float interval = 0.25f;

	public override void OnPrePlayOrPreCompile()
	{
		base.OnPrePlayOrPreCompile();
		speech = GetComponent<ShowSpeechbubbleOnHit>();
	}

	private void Start()
	{
		speech = GetComponent<ShowSpeechbubbleOnHit>();
		if (speech != null && speech.TextList != null && speech.TextList.textIds != null && speech.TextList.textIds.Count > 1)
		{
			byte[] bytes = SaveGame.DeviceUUID.ToByteArray();
			int seed = (bytes != null && bytes.Length > 0) ? bytes[0] : 42;
			var oldState = UnityEngine.Random.state;
			UnityEngine.Random.InitState(seed);
			while (speech.TextList.textIds.Count > 1)
			{
				speech.TextList.textIds.RemoveAt(UnityEngine.Random.Range(0, speech.TextList.textIds.Count));
			}
			UnityEngine.Random.state = oldState;
		}
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision == null || collision.gameObject == null) return;
		var ball = collision.gameObject.GetComponent<OverworldBall2D>();
		float mag = collision.relativeVelocity.magnitude;
		float vol = Mathf.Clamp01(mag / 10f);
		if (ball != null && Time.time > nextHitSound)
		{
			if (hitSfx != null)
				hitSfx.PlayRandomClip(transform, vol * volume, 1f);
			nextHitSound = Time.time + 0.05f;
			interval = 0.05f;
			if (speech != null && speech.TextList != null)
				OnHit?.Invoke(speech.TextList);
		}
	}

	private void Update()
	{
		if (Time.time > nextColor)
		{
			if (colors != null && colors.Count > 0 && monitor != null)
			{
				colorIndex = (colorIndex + 1) % colors.Count;
				monitor.color = colors[colorIndex];
			}
			if (lightbulbColors != null && lightbulbColors.Count > 0 && lightbulb != null)
			{
				lightbulb.color = lightbulbColors[colorIndex % lightbulbColors.Count];
			}
			nextColor = Time.time + interval;
		}
		interval = Mathf.MoveTowards(interval, 0.25f, Time.deltaTime * 0.5f);
	}
}
