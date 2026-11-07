using System.Collections.Generic;
using UnityEngine;

public class MainComputerSpeechbubble : GolfBehaviour
{
	public List<SpeechbubbleList> textOnIndicatorOn;

	public SpeechbubbleList textOnHitBeforeIndicators;

	public SpeechbubbleList textOnHitWithSomeIndicators;

	public SpeechbubbleList textOnHitWithAllIndicators;

	[SerializeField]
	private ShowSpeechbubbleOnHit hitbubble;

	[SerializeField]
	private OverworldMainDoorRobot robot;

	public override void OnPrePlayOrPreCompile()
	{
	}

	private void Awake()
	{
	}

	private void Robot_OnPlateChanged()
	{
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	private void Robot_OnIsReady()
	{
	}

	private void UpddateSpeechBubbles()
	{
	}
}
