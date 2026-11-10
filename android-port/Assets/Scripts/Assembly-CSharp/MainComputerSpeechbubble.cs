using System.Collections.Generic;
using System.Linq;
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
			robot = GetComponent<OverworldMainDoorRobot>() ?? GetComponentInParent<OverworldMainDoorRobot>();
	}

	private void Awake()
	{
		if (hitbubble == null)
			hitbubble = GetComponent<ShowSpeechbubbleOnHit>();
		if (robot == null)
			robot = GetComponent<OverworldMainDoorRobot>() ?? GetComponentInParent<OverworldMainDoorRobot>();
		if (robot != null)
		{
			robot.OnIsReady -= Robot_OnIsReady;
			robot.OnIsReady += Robot_OnIsReady;
			robot.OnPlateChanged -= Robot_OnPlateChanged;
			robot.OnPlateChanged += Robot_OnPlateChanged;
			if (robot.IsInitialized)
				Robot_OnIsReady();
		}
	}

	private void Robot_OnPlateChanged()
	{
		if (robot == null || hitbubble == null)
			return;
		int onCount = robot.plates != null ? robot.plates.Count(p => p != null && p.isOn) : 0;
		if (textOnIndicatorOn != null && textOnIndicatorOn.Count > 0 && onCount > 0)
		{
			if (textOnIndicatorOn.Count < onCount)
			{
				hitbubble.TextList = null;
			}
			else
			{
				int idx = (onCount - 1) % textOnIndicatorOn.Count;
				hitbubble.TextList = textOnIndicatorOn[idx];
				hitbubble.ResetConversation();
			}
			if (hitbubble.TextList != null)
			{
				StartCoroutine(hitbubble.HandleHit(UpddateSpeechBubbles));
				return;
			}
		}
		UpddateSpeechBubbles();
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (robot == null || robot.IsCompleted() || robot.IsOpen())
			return;
		if (collision == null || collision.collider == null || collision.collider.attachedRigidbody == null)
			return;
		if (collision.collider.attachedRigidbody.GetComponent<OverworldBall2D>() == null)
			return;
		UpddateSpeechBubbles();
		if (hitbubble != null && hitbubble.TextList != null)
		{
			StartCoroutine(hitbubble.HandleHit());
		}
	}

	private void Robot_OnIsReady()
	{
		UpddateSpeechBubbles();
	}

	public void UpddateSpeechBubbles()
	{
		if (robot == null || hitbubble == null)
			return;
		if (robot.IsCompleted())
		{
			hitbubble.TextList = null;
			return;
		}
		int onCount = robot.plates != null ? robot.plates.Count(p => p != null && p.isOn) : 0;
		int total = robot.plates != null ? robot.plates.Count : 0;
		SpeechbubbleList target = textOnHitBeforeIndicators;
		if (total > 0 && onCount == total)
			target = textOnHitWithAllIndicators;
		else if (onCount >= 1)
			target = textOnHitWithSomeIndicators;
		if (hitbubble.TextList != target)
		{
			hitbubble.TextList = target;
			hitbubble.ResetConversation();
		}
	}
}
