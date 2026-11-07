using System.Collections.Generic;
using Audio;
using UnityEngine;

public class RakeTrigger : MonoBehaviour
{
	public LayerMask ActivatorLayers;

	public HingeJoint RakeHingeJoint;

	public List<Joint> PoleJoints;

	public GameObject Handle;

	public Collider HandleCollider;

	public ClipSettingsCollection ActivateClip;

	public ClipSettingsCollection HitClip;

	private bool activated;

	private void OnTriggerEnter(Collider other)
	{
	}
}
