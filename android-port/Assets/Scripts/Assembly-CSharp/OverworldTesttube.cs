using Audio;
using UnityEngine;

public class OverworldTesttube : MonoBehaviour
{
	public Transform floatyObject;

	public float floatyDistance;

	public float floatyRotation;

	public bool isRotatingSineWave;

	public RandomAudioClips hitSfx;

	public ParticleSystem particles;

	private float nextHitSound;

	private Collider2D col;

	private Coroutine lastRoutine;

	private Vector3 baseFloatyPosition;

	private Quaternion baseFloatyRotation;

	private float floatTime;

	private void Awake()
	{
	}

	private void OnDrawGizmosSelected()
	{
	}

	private void Update()
	{
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
	}
}
