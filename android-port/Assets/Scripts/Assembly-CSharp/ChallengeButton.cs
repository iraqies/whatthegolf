using System;
using System.Collections.Generic;
using UnityEngine;

public class ChallengeButton : MonoBehaviour
{
	public bool disableOnExit;

	private Animator m_Animator;

	private List<Rigidbody> m_rigidsOnTop;

	public Action<ChallengeButton> OnButtonTrigger;

	public bool IsButtonOn { get; set; }

	private void Awake()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}
}
