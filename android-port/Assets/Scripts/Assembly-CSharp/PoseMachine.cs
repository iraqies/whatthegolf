using System;
using System.Collections;
using UnityEngine;

public class PoseMachine : MonoBehaviour
{
	public Transform Pivot;

	public void NextPose(Action onDone)
	{
	}

	public void RedoPose(Action onDone)
	{
	}

	private IEnumerator ChangePoseMachine(Action onDone, bool next)
	{
		return null;
	}
}
