using Audio;
using Cinemachine;
using UnityEngine;

public class DelayedRunner : MonoBehaviour
{
	public CinemachineDollyCart CartToStart;

	public PuppetAutoRun Runner;

	public ClipSettingsCollection StartClip;

	private bool hasStarted;

	private void OnTriggerEnter(Collider other)
	{
	}
}
