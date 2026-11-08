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

	private Helper helperState = Helper.IOS_HELPER;
	private bool shouldShowHelpPrev;
	public int state;
	public List<GameObject> tutorialStates;
	public bool forceControllerHelpOnTV;
	public GolfBallController controller;
	public float controllerInteractionsToShowHelper;
	public float noInputTimeToShowHelp = 3f;
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
		TurnOffAnimations();
		if (controller == null)
			controller = FindObjectOfType<GolfBallController>();
		if (controller != null)
		{
			controller.OnAimStart += Controller_OnAimStart;
			controller.OnAimUpdate += Controller_OnAimUpdate;
			controller.OnCancel += Controller_OnCancel;
			controller.OnShoot += Controller_OnShoot;
		}
		if (tutorialStates != null)
		{
			for (int i = 0; i < tutorialStates.Count; i++)
			{
				if (tutorialStates[i] != null)
					tutorialStates[i].SetActive(i == state);
			}
		}
	}

	private bool IsUsingGamepad() => false;

	private void DetectHelperState()
	{
		helperState = Helper.IOS_HELPER;
	}

	private bool ShouldShowHelp() => !didShoot && !didAim && _timeNotShooting > noInputTimeToShowHelp;

	private void Update()
	{
		if (!didShoot && !didAim)
			_timeNotShooting += Time.deltaTime;
	}

	private void TurnOffAnimations()
	{
		TurnOffIfOn(ref tvRemoteHelper);
		TurnOffIfOn(ref SwitchController);
		TurnOffIfOn(ref iOSController);
		TurnOffIfOn(ref tvJstickHelper);
		TurnOffIfOn(ref mouseHelper);
		TurnOffIfOn(ref iOSGamePad);
		TurnOffIfOn(ref psController);
	}

	private void TurnOnAnimations()
	{
		TurnOffAnimations();
	}

	private void Controller_OnShoot(Vector3 obj)
	{
		didShoot = true;
		TurnOffAnimations();
		StartCoroutine(NextStage());
	}

	private void Instance_OnOutOfBounds()
	{
	}

	private IEnumerator NextStage()
	{
		yield return new WaitForSeconds(0.5f);
		state++;
		if (tutorialStates != null)
		{
			for (int i = 0; i < tutorialStates.Count; i++)
			{
				if (tutorialStates[i] != null)
					tutorialStates[i].SetActive(i == state);
			}
		}
	}

	private void Controller_OnCancel()
	{
		didAim = false;
	}

	private void Controller_OnAimUpdate(Vector3 arg1, bool arg2)
	{
		didAim = !arg2;
	}

	private void Controller_OnAimStart()
	{
		didAim = true;
		TurnOffAnimations();
	}

	private void TurnOffIfOn(ref Animator animator)
	{
		if (animator != null && animator.gameObject != null)
			animator.gameObject.SetActive(false);
	}

	private void TurnOnIfOff(ref Animator animator)
	{
		if (animator != null && animator.gameObject != null)
			animator.gameObject.SetActive(true);
	}
}
