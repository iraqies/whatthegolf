using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class AutoStartShowcase : MonoBehaviour
{
	public UnityEvent AutostartEvent;

	private string activeSceneName;

	private void Start()
	{
	}

	private IEnumerator AutoStart()
	{
		return null;
	}

	private void SceneManager_activeSceneChanged(Scene arg0, Scene arg1)
	{
	}
}
