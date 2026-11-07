using System.Collections;
using Audio;
using UnityEngine;
using UnityEngine.Events;

public class Teleportable : MonoBehaviour
{
	[SerializeField]
	private float force;

	[SerializeField]
	private Rigidbody rigid;

	[SerializeField]
	private Transform tail;

	[SerializeField]
	private bool playSound;

	[SerializeField]
	private bool rotateUp;

	[SerializeField]
	private float afterTeleportEventTimer;

	[SerializeField]
	private AudioClipSettings overrideClips;

	public UnityEvent OnTeleport;

	public UnityEvent OnDelayAfterTeleport;

	private float lastTeleportTime;

	private void Start()
	{
	}

	public void Teleport(TeleportHole connection, Vector3 holeEscapeDir, float holeEscapeForce)
	{
	}

	public IEnumerator TeleportCR(TeleportHole connection, Vector3 holeEscapeDir, float holeEscapeForce)
	{
		return null;
	}
}
