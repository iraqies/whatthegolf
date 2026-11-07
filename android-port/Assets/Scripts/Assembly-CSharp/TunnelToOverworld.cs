using Audio;
using CameraStack;
using UnityEngine;

public class TunnelToOverworld : MonoBehaviour
{
	public CBFollow followCamera;

	public GolfGoal goal;

	public AudioSource piperollSource;

	public AudioClip sfxOnEnteringTunnel;

	public AudioClipSettings catSfxOnEnter;

	public FollowTransform BallFollower;

	private bool didActivate;

	private bool isStaticFollow;

	private bool didWin;

	public Vector3 offset;

	private Vector3 currentOffset;

	private Transform ballTransform;

	private float timeSinceStatic;

	private void OnTriggerEnter(Collider other)
	{
	}

	private void Update()
	{
	}
}
