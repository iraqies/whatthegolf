using System.Collections;
using UnityEngine;

public class TransitionTester : MonoBehaviour
{
	[SerializeField]
	private Transition _transition;

	private Coroutine _cr;

	public void TestInterruptionStart()
	{
	}

	public void TestInterruptionEnd()
	{
	}

	private IEnumerator KillCR()
	{
		return null;
	}
}
