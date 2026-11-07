using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Audio;
using UnityEngine;

public class OverworldMainDoorPlate : GolfBehaviour
{
	[CompilerGenerated]
	private Action<bool, bool> m_OnStateChange;

	[CompilerGenerated]
	private Action m_OnInit;

	public bool isOn;

	public Color colorOn;

	public Color colorOff;

	public SpriteRenderer sprite;

	public GameObject DoorIsClosed;

	public GameObject DoorIsOpen;

	public GameObject LevelsComplete;

	public GameObject CrownsComplete;

	public Transform returningBallTransform;

	public PlateInfoManager plateInfo;

	public Animator animator;

	public OverworldMainDoorRobot computer;

	public PlayClipOnAudioEvent SFX_TurnOn;

	public bool DontColorSprite;

	public bool isMovingBallOut;

	public bool isInitialized;

	public List<GameObject> ReversableObjects;

	public event Action<bool, bool> OnStateChange
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action OnInit
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public override void OnPrePlayOrPreCompile()
	{
	}

	public void SetState(bool on, bool onLoad = false)
	{
	}

	public void ChangeState(bool isOn, bool isLoad)
	{
	}

	public void Initialize(OverworldMainDoorRobot overworldMainDoorRobot)
	{
	}

	private void Start()
	{
	}

	private void ChangeState(PlateInfoManager.AreaState state)
	{
	}

	private void OnDrawGizmos()
	{
	}
}
