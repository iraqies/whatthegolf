using System.Collections;
using Audio;
using UnityEngine;
using UnityEngine.Events;

public class HotdogCannonTargets : MonoBehaviour
{
	[SerializeField]
	private Rigidbody Rigidbody;

	[SerializeField]
	private Transform root;

	[SerializeField]
	private float force;

	[SerializeField]
	private Transform cannon;

	[SerializeField]
	private Animator Animator;

	[SerializeField]
	private UnityEvent OnCollapse;

	[SerializeField]
	private ToggleGenericRagdoll RagdollToggle;

	[SerializeField]
	private AudioEventAsset sfxEventOnCollapse;

	[SerializeField]
	private AudioEventAsset sfxOnSpeedup;

	private bool hasCollapsed;

	public bool Collapse()
	{
		return false;
	}

	private IEnumerator Do()
	{
		return null;
	}

	private void OnTriggerEnter(Collider other)
	{
	}
}
