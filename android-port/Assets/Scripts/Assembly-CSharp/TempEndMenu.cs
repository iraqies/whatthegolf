using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TempEndMenu : MonoBehaviour
{
	public TMP_InputField IdeaInputField;

	public TMP_InputField EmailInputField;

	public TextMeshProUGUI ErrorText;

	public ConfettiSpawner ConfettiSpawner;

	public OverworldGoalWithMenuPopup ConfettiSpawnPosition;

	public List<AudioClip> SuccessClips;

	public List<AudioClip> FailClips;

	public float Duration;

	public float Speed;

	public float Magnitude;

	private string postUrl;

	private string serverConnectionError;

	private string signupError;

	private PerlinShake shaker;

	private void Start()
	{
	}

	public void SaveButtonClicked()
	{
	}

	private IEnumerator SignupCoroutine(string email, string comment)
	{
		return null;
	}

	private void SetErrorMessage(string message)
	{
	}

	private void Update()
	{
	}

	private bool IsValidEmail(string email)
	{
		return false;
	}
}
