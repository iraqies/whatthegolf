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

	private Helper helperState = Helper.NONE;
	private bool shouldShowHelpPrev;
	public int state = -1;
	public List<GameObject> tutorialStates;
	public bool forceControllerHelpOnTV;
	public GolfBallController controller;
	public float controllerInteractionsToShowHelper = 1f;
	public float noInputTimeToShowHelp = 3f;
	public bool limitMoreThan45 = true;
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
		if (controller == null)
			controller = FindObjectOfType<GolfBallController>();

		DetectHelperState();
		shouldShowHelpPrev = ShouldShowHelp();
		if (shouldShowHelpPrev)
			TurnOnAnimations();
		else
			TurnOffAnimations();

		if (controller != null)
		{
			controller.OnAimStart += Controller_OnAimStart;
			controller.OnAimUpdate += Controller_OnAimUpdate;
			controller.OnCancel += Controller_OnCancel;
			controller.OnShoot += Controller_OnShoot;
		}
		if (showAdditionalHelp && Level.HasInstance && Level.Instance != null)
		{
			Level.Instance.OnOutOfBounds += Instance_OnOutOfBounds;
		}
	}

	private bool IsUsingGamepad() => InputHelper.IsNavigatingWithController();

	private void DetectHelperState()
	{
		helperState = Helper.IOS_HELPER;
		if (IsUsingGamepad())
			helperState = Helper.GAMEPAD_HELPER_IOS;
		showAdditionalHelp = showAdditionalHelpIOS || showAdditionalHelpSwitch || showAdditionalHelpStandalone;
	}

	private bool ShouldShowHelp()
	{
		if (didShoot) return false;
		if (didAim && helperState == Helper.MOUSE_HELPER) return false;
		return _timeNotShooting > noInputTimeToShowHelp || _controllerInteraction > controllerInteractionsToShowHelper;
	}

	private void Update()
	{
		_timeNotShooting += Time.unscaledDeltaTime;
		if (Input.anyKeyDown)
			_controllerInteraction += 0.1f;

		bool show = ShouldShowHelp();
		Helper prevHelper = helperState;
		DetectHelperState();
		if (helperState != prevHelper)
		{
			TurnOffAnimations();
			if (show)
				TurnOnAnimations();
		}
		if (show != shouldShowHelpPrev)
		{
			if (show)
				TurnOnAnimations();
			else
				TurnOffAnimations();
		}
		shouldShowHelpPrev = show;
	}

	private void TurnOffAnimations()
	{
		TurnOffIfOn(ref iOSController);
		TurnOffIfOn(ref iOSGamePad);
		TurnOffIfOn(ref SwitchController);
		TurnOffIfOn(ref tvRemoteHelper);
		TurnOffIfOn(ref tvJstickHelper);
		TurnOffIfOn(ref mouseHelper);
		TurnOffIfOn(ref psController);
	}

	private void TurnOnAnimations()
	{
		switch (helperState)
		{
			case Helper.SIRI_REMOTE_HELPER: TurnOnIfOff(ref tvRemoteHelper); break;
			case Helper.GAMEPAD_HELPER: TurnOnIfOff(ref tvJstickHelper); break;
			case Helper.SWITCH_CONTROL_HELPER: TurnOnIfOff(ref SwitchController); break;
			case Helper.IOS_HELPER: TurnOnIfOff(ref iOSController); break;
			case Helper.MOUSE_HELPER: TurnOnIfOff(ref mouseHelper); break;
			case Helper.GAMEPAD_HELPER_IOS: TurnOnIfOff(ref iOSGamePad); break;
			case Helper.PS_HELPER: TurnOnIfOff(ref psController); break;
		}
	}

	private void Controller_OnShoot(Vector3 obj)
	{
		didShoot = true;
		_timeNotShooting = 0f;
		if (controller != null)
			controller.useAngleLimit = false;
		TurnOffAnimations();
	}

	private void Instance_OnOutOfBounds()
	{
		StartCoroutine(NextStage());
	}

	private IEnumerator NextStage()
	{
		yield return new WaitForSecondsRealtime(0.3f);
		_timeNotShooting = 0f;
		if (tutorialStates != null)
		{
			int count = Mathf.Min(state, tutorialStates.Count);
			for (int i = 0; i < count; i++)
			{
				if (tutorialStates[i] != null)
					tutorialStates[i].SetActive(true);
			}
		}
		int prevState = state;
		state = prevState + 1;
		if (controller != null)
		{
			if (prevState == 1)
			{
				controller.angleLimit = 45;
				controller.useAngleLimit = true;
			}
			else if (prevState == 2)
			{
				controller.angleLimit = limitMoreThan45 ? 25 : 45;
				controller.useAngleLimit = true;
			}
			else if (state >= 4)
			{
				controller.angleLimit = limitMoreThan45 ? 5 : 45;
				controller.useAngleLimit = true;
			}
		}
	}

	private void Controller_OnCancel()
	{
		_timeNotShooting = 10f;
	}

	private void Controller_OnAimUpdate(Vector3 arg1, bool arg2)
	{
		_timeNotShooting = 0f;
	}

	private void Controller_OnAimStart()
	{
		didAim = true;
		_timeNotShooting = 0f;
	}

	private void TurnOffIfOn(ref Animator animator)
	{
		if (animator == null) return;
		if (animator.GetBool("Show"))
		{
			animator.SetBool("Hide", true);
			animator.SetBool("Show", false);
		}
	}

	private void TurnOnIfOff(ref Animator animator)
	{
		if (animator == null) return;
		if (!animator.GetBool("Show"))
		{
			animator.SetBool("Show", true);
		}
	}
}
