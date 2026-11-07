using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PersistantObjects : MonoBehaviour
{
	public List<OverworldGoal> flags;

	public OverworldMainButton button;

	public OverworldButton2D button2d;

	public UnityEvent onEnabled;

	private bool isEnabled()
	{
		return false;
	}

	private void Start()
	{
	}

	private IEnumerator LateTick()
	{
		return null;
	}
}
