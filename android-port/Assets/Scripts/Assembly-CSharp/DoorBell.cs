using Audio;
using UnityEngine;

public class DoorBell : MonoBehaviour
{
	public HingeJoint LeftDoor;

	public HingeJoint RightDoor;

	public string PoleTag;

	public ClipSettingsCollection RingClip;

	public ClipSettingsCollection OpenClip;

	private bool hasRung;

	private void Start()
	{
	}

	private void OnCollisionEnter(Collision other)
	{
	}
}
