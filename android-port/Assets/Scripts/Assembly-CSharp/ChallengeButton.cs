using System;
using System.Collections.Generic;
using UnityEngine;

public class ChallengeButton : MonoBehaviour
{
	public bool disableOnExit;

	private Animator m_Animator;

	private List<Rigidbody> m_rigidsOnTop = new List<Rigidbody>();

	public Action<ChallengeButton> OnButtonTrigger;

	public bool IsButtonOn { get; set; }

	private void Awake()
	{
		m_Animator = GetComponentInChildren<Animator>();
		m_rigidsOnTop = new List<Rigidbody>();
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other == null) return;
		var rb = other.attachedRigidbody ?? other.GetComponentInParent<Rigidbody>();
		if (rb != null && !m_rigidsOnTop.Contains(rb))
			m_rigidsOnTop.Add(rb);
		if (!IsButtonOn)
		{
			IsButtonOn = true;
			if (m_Animator != null)
				m_Animator.SetBool("On", true);
			OnButtonTrigger?.Invoke(this);
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (other == null) return;
		var rb = other.attachedRigidbody ?? other.GetComponentInParent<Rigidbody>();
		if (rb != null)
			m_rigidsOnTop.Remove(rb);
		m_rigidsOnTop.RemoveAll(r => r == null);
		if (disableOnExit && m_rigidsOnTop.Count == 0 && IsButtonOn)
		{
			IsButtonOn = false;
			if (m_Animator != null)
				m_Animator.SetBool("On", false);
			OnButtonTrigger?.Invoke(this);
		}
	}
}
