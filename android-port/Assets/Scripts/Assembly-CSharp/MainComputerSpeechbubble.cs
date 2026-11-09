using System.Collections.Generic;
using UnityEngine;

public class MainComputerSpeechbubble : GolfBehaviour
{
	public List<SpeechbubbleList> textOnIndicatorOn;
	public SpeechbubbleList textOnHitBeforeIndicators;
	public SpeechbubbleList textOnHitWithSomeIndicators;
	public SpeechbubbleList textOnHitWithAllIndicators;
	[SerializeField] private ShowSpeechbubbleOnHit hitbubble;
	[SerializeField] private OverworldMainDoorRobot robot;

	public override void OnPrePlayOrPreCompile()
	{
		base.OnPrePlayOrPreCompile();
		if (hitbubble == null)
			hitbubble = GetComponent<ShowSpeechbubbleOnHit>();
		if (robot == null)
			robot = GetComponentInParent<OverworldMainDoorRobot>();
	}

	private void Awake()
	{
		if (hitbubble == null)
			hitbubble = GetComponent<ShowSpeechbubbleOnHit>();
		if (robot == null)
			robot = GetComponentInParent<OverworldMainDoorRobot>();
		if (robot != null)
		{
			if (robot.IsInitialized)
				Robot_OnIsReady();
			else
				robot.OnIsReady += Robot_OnIsReady;
			robot.OnPlateChanged += Robot_OnPlateChanged;
		}
	}

	private void Robot_OnPlateChanged()
	{
		UpddateSpeechBubbles();
		if (robot != null && robot.plates != null && textOnIndicatorOn != null && hitbubble != null)
		{
			int onCount = 0;
			foreach (var p in robot.plates)
			{
				if (p != null && p.isOn)
					onCount++;
			}
			int idx = Mathf.Clamp(onCount - 1, 0, textOnIndicatorOn.Count - 1);
			if (onCount > 0 && idx < textOnIndicatorOn.Count && textOnIndicatorOn[idx] != null)
			{
				hitbubble.TextList = textOnIndicatorOn[idx];
				hitbubble.ResetConversation();
				hitbubble.ForceStartSpeechBubble();
			}
		}
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		UpddateSpeechBubbles();
	}

	private void Robot_OnIsReady()
	{
		UpddateSpeechBubbles();
	}

	private void UpddateSpeechBubbles()
	{
		if (robot == null || hitbubble == null)
			return;
		int onCount = 0;
		int total = robot.plates != null ? robot.plates.Count : 0;
		if (robot.plates != null)
		{
			foreach (var p in robot.plates)
			{
				if (p != null && p.isOn)
					onCount++;
			}
		}
		SpeechbubbleList target = textOnHitBeforeIndicators;
		if (total > 0 && onCount >= total && textOnHitWithAllIndicators != null)
			target = textOnHitWithAllIndicators;
		else if (onCount > 0 && textOnHitWithSomeIndicators != null)
			target = textOnHitWithSomeIndicators;
		if (target != null && hitbubble.TextList != target)
		{
			hitbubble.TextList = target;
			hitbubble.ResetConversation();
		}
	}
}
