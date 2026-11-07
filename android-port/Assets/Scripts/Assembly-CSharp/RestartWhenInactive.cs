using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class RestartWhenInactive : MonoBehaviour
{
	public float TimeBeforeCountdown;

	public float CountdownTime;

	public List<string> DisableInScenes;

	public List<string> FasterInScenes;

	public TextWithShadow Text;

	public UnityEvent RestartEvent;

	public UnityEvent CountdownReachedEvent;

	public UnityEvent CountdownCancelled;

	public float timer;

	private bool countdownReached;

	private Vector3 lastMousePos;

	private string activeSceneName;

	private void Start()
	{
	}

	private void SceneManager_activeSceneChanged(Scene arg0, Scene arg1)
	{
	}

	private void Update()
	{
	}

	private void Reset()
	{
	}
}
