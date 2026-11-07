using System.Collections.Generic;
using UnityEngine;

public class FailChallengeOnTipObject : MonoBehaviour
{
	public Challenge challenge;

	public bool FindTippablesInChildren;

	public List<TippableObjectBase> Tippables;

	private void Awake()
	{
	}

	private void OnTip(GameObject obj)
	{
	}
}
