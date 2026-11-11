using System.Collections;
using System.Collections.Generic;
using Audio;
using Core;
using UnityEngine;

public class DoubleSwingers : GolfBallShooterBase
{
	public List<Rigidbody> Swingers;

	public float RotateSpeed = 10f;

	public List<Joint> FixedJoints;

	public Rigidbody Pole;

	public float GroundCheckDist = 2f;

	public LayerMask GroundMask;

	public float SwingWarmupSpeed = 2f;

	public ClipSettingsCollection SwitchClip;

	public ClipSettingsCollection FailClip;

	public AudioSource MoveSource;

	private int currentSwinger;

	private int swingDirection = 1;

	private Dictionary<Rigidbody, Quaternion> baseRotations;

	private Dictionary<Rigidbody, List<Rigidbody>> swingerRigidbodies;

	private bool isSwinging;

	private DoubleSwingersPlatform currentPlatform;

	private Vector3 platformOffset;

	private float swingWarmup;

	private IEnumerator Start()
	{
		baseRotations = new Dictionary<Rigidbody, Quaternion>();
		swingerRigidbodies = new Dictionary<Rigidbody, List<Rigidbody>>();
		foreach (Rigidbody swinger in Swingers)
		{
			List<Rigidbody> list = new List<Rigidbody>();
			Rigidbody[] componentsInChildren = swinger.gameObject.GetComponentsInChildren<Rigidbody>();
			foreach (Rigidbody rigidbody in componentsInChildren)
			{
				list.Add(rigidbody);
				if (rigidbody != swinger)
				{
					baseRotations.Add(rigidbody, rigidbody.transform.localRotation);
				}
			}
			swingerRigidbodies.Add(swinger, list);
		}
		yield return null;
		SwitchSwinger(0);
	}

	public override void OnShoot(Vector3 boost)
	{
		isSwinging = false;
		MoveSource.Stop();
		SwitchSwinger((currentSwinger + 1) % Swingers.Count);
	}

	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		if (isSwinging)
		{
			swingWarmup += Time.deltaTime * SwingWarmupSpeed;
			Swingers[currentSwinger].MoveRotation(Swingers[currentSwinger].rotation * Quaternion.AngleAxis(RotateSpeed * Time.deltaTime * (float)swingDirection * Mathf.Clamp01(swingWarmup), Vector3.up));
		}
		if (currentPlatform != null)
		{
			Swingers[currentSwinger].MovePosition(currentPlatform.transform.position - platformOffset);
		}
		foreach (Rigidbody swinger in Swingers)
		{
			if (Physics.Raycast(swinger.position, Vector3.down, out var hitInfo, GroundCheckDist, GroundMask) && hitInfo.rigidbody != null && hitInfo.rigidbody.transform.TryGetComponent<DoubleSwingersPlatform>(out var component))
			{
				component.Glow();
			}
		}
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
		if (!onlyAimArrow)
		{
			if (!MoveSource.isPlaying)
			{
				MoveSource.Play();
			}
			isSwinging = true;
		}
	}

	private void SwitchSwinger(int nextSwinger)
	{
		foreach (Rigidbody item in swingerRigidbodies[Swingers[currentSwinger]])
		{
			item.isKinematic = false;
		}
		FixedJoints[currentSwinger].massScale = 0f;
		FixedJoints[currentSwinger].connectedMassScale = 1f;
		currentSwinger = nextSwinger;
		GolfBallController.ArrowPosition = Swingers[currentSwinger].transform;
		foreach (Rigidbody item2 in swingerRigidbodies[Swingers[currentSwinger]])
		{
			item2.isKinematic = true;
		}
		FixedJoints[currentSwinger].massScale = 1f;
		FixedJoints[currentSwinger].connectedMassScale = 1f;
		swingDirection = -swingDirection;
		swingWarmup = 0f;
		foreach (Rigidbody item3 in swingerRigidbodies[Swingers[currentSwinger]])
		{
			if (baseRotations.ContainsKey(item3))
			{
				item3.transform.localRotation = baseRotations[item3];
			}
		}
		if (Physics.Raycast(Swingers[currentSwinger].position, Vector3.down, out var hitInfo, GroundCheckDist, GroundMask))
		{
			SwitchClip.Play(base.transform.position, 1f, 1f);
			if (hitInfo.transform.TryGetComponent<DoubleSwingersPlatform>(out var component))
			{
				component.Bounce();
				currentPlatform = component;
				platformOffset = currentPlatform.transform.position - Swingers[currentSwinger].position;
			}
			else
			{
				currentPlatform = null;
			}
			return;
		}
		currentPlatform = null;
		foreach (Joint fixedJoint in FixedJoints)
		{
			Object.Destroy(fixedJoint);
		}
		foreach (Rigidbody item4 in swingerRigidbodies[Swingers[currentSwinger]])
		{
			item4.isKinematic = false;
		}
		Pole.constraints = RigidbodyConstraints.None;
		Pole.useGravity = true;
		FailClip.Play(base.transform.position, 1f, 1f);
		if (Level.Instance != null && !Level.Instance.IsMultiplayer)
		{
			Level.Instance.Fail(true, true, null, 1f, true, "");
		}
	}
}
