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

	public float volume;

	public RandomAudioClips hitSfx;

	public List<string> secrets;

	public Action<SpeechbubbleList> OnHit;

	private ShowSpeechbubbleOnHit speech;

	private float nextHitSound;

	private float nextColor;

	private int colorIndex;

	private float interval;

	public override void OnPrePlayOrPreCompile()
	{
	}

	private void Start()
	{
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	private void Update()
	{
	}
}
