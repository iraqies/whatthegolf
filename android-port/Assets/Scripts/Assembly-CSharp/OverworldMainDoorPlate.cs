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
		add => m_OnStateChange = (Action<bool, bool>)Delegate.Combine(m_OnStateChange, value);
		[CompilerGenerated]
		remove => m_OnStateChange = (Action<bool, bool>)Delegate.Remove(m_OnStateChange, value);
	}

	public event Action OnInit
	{
		[CompilerGenerated]
		add => m_OnInit = (Action)Delegate.Combine(m_OnInit, value);
		[CompilerGenerated]
		remove => m_OnInit = (Action)Delegate.Remove(m_OnInit, value);
	}

	public override void OnPrePlayOrPreCompile()
	{
		base.OnPrePlayOrPreCompile();
		if (sprite == null)
			sprite = GetComponentInChildren<SpriteRenderer>();
	}

	public void SetState(bool on, bool onLoad = false)
	{
		isOn = on;
		if (animator != null)
		{
			if (on)
			{
				animator.keepAnimatorControllerStateOnDisable = true;
				animator.SetBool(onLoad ? "InstantOn" : "On", true);
			}
			else
			{
				animator.SetBool("On", false);
			}
		}
		if (!DontColorSprite && sprite != null)
			sprite.color = isOn ? colorOn : colorOff;
		m_OnStateChange?.Invoke(isOn, onLoad);
	}

	public void ChangeState(bool isOn, bool isLoad)
	{
		m_OnStateChange?.Invoke(isOn, isLoad);
	}

	public void Initialize(OverworldMainDoorRobot overworldMainDoorRobot)
	{
		computer = overworldMainDoorRobot;
		isInitialized = true;
		m_OnInit?.Invoke();
	}

	private void Start()
	{
		if (plateInfo != null)
		{
			plateInfo.onAreaStateChanged -= ChangeState;
			plateInfo.onAreaStateChanged += ChangeState;
		}
	}

	private void ChangeState(PlateInfoManager.AreaState state)
	{
		if (DoorIsClosed != null) DoorIsClosed.SetActive(state == PlateInfoManager.AreaState.DOOR_CLOSED);
		if (DoorIsOpen != null) DoorIsOpen.SetActive(state == PlateInfoManager.AreaState.DOOR_OPEN);
		if (LevelsComplete != null) LevelsComplete.SetActive(state == PlateInfoManager.AreaState.LEVELS_COMLETE);
		if (CrownsComplete != null) CrownsComplete.SetActive(state == PlateInfoManager.AreaState.CHALLENGES_COMPLETE);
	}

	private void OnDrawGizmos()
	{
	}
}
