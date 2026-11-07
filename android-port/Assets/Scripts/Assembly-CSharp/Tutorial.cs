using System.Collections;
using System.Collections.Generic;
using Core;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
	private enum Helper
	{
		SIRI_REMOTE_HELPER = 0,
		GAMEPAD_HELPER = 1,
		SWITCH_CONTROL_HELPER = 2,
		IOS_HELPER = 3,
		MOUSE_HELPER = 4,
		NONE = 5,
		GAMEPAD_HELPER_IOS = 6,
		PS_HELPER = 7
	}

	public Animator tvRemoteHelper;

	public Animator SwitchController;

	public Animator iOSController;

	public Animator tvJstickHelper;

	public Animator mouseHelper;

	public Animator iOSGamePad;

	public Animator psController;

	private Helper helperState;

	private bool shouldShowHelpPrev;

	public int state;

	public List<GameObject> tutorialStates;

	public bool forceControllerHelpOnTV;

	public GolfBallController controller;

	public float controllerInteractionsToShowHelper;

	public float noInputTimeToShowHelp;

	public bool limitMoreThan45;

	private float _controllerInteraction;

	private float _timeNotShooting;

	public bool showAdditionalHelpSwitch;

	public bool showAdditionalHelpStandalone;

	public bool showAdditionalHelpTV;

	public bool showAdditionalHelpIOS;

	public bool showAdditionalHelpPS;

	private bool showAdditionalHelp;

	private bool didShoot;

	private bool didAim;

	private void Awake()
	{
	}

	private bool IsUsingGamepad()
	{
		return false;
	}

	private void DetectHelperState()
	{
	}

	private bool ShouldShowHelp()
	{
		return false;
	}

	private void Update()
	{
	}

	private void TurnOffAnimations()
	{
	}

	private void TurnOnAnimations()
	{
	}

	private void Controller_OnShoot(Vector3 obj)
	{
	}

	private void Instance_OnOutOfBounds()
	{
	}

	private IEnumerator NextStage()
	{
		return null;
	}

	private void Controller_OnCancel()
	{
	}

	private void Controller_OnAimUpdate(Vector3 arg1, bool arg2)
	{
	}

	private void Controller_OnAimStart()
	{
	}

	private void TurnOffIfOn(ref Animator animator)
	{
	}

	private void TurnOnIfOff(ref Animator animator)
	{
	}
}
