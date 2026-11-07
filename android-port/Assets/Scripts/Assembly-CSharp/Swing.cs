using UnityEngine;

public class Swing : MonoBehaviour
{
	public bool DoSwing;

	public bool UsePhysics;

	public Vector3 Axis;

	public AnimationCurve AngleCurve;

	public float timeOffset;

	public AudioClip swooshClip;

	public float speedFactor;

	public bool useTimeTime;

	private float timeIn;

	private float timeOut;

	private float soundCooldown;

	private float nextSoundAt;

	private Rigidbody rigidbody;

	private float timeValueUsed;

	private Quaternion initialRotation;

	[SerializeField]
	private bool useLocalRotation;

	private void Awake()
	{
	}

	public void ReturnToDefaultRotation()
	{
	}

	public void StartSwinging()
	{
	}

	public void StopSwinging(bool returnToDefaultRotation)
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	private void PlaySound()
	{
	}
}
