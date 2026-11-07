using System;
using System.Collections.Generic;
using Audio;
using UnityEngine;

public class HotdogTargetBehaviour : MonoBehaviour
{
	[SerializeField]
	private Animator Animator;

	[SerializeField]
	private GameObject HeldThing;

	[SerializeField]
	private GameObject HotdogPrefab;

	[SerializeField]
	private SkinnedMeshRenderer skinnedMeshRenderer;

	public Action<HotdogTargetBehaviour> OnCollapsed;

	public AudioEventAsset sfxEventOnCollapse;

	public AudioEventAsset sfxOnSpeedup;

	[SerializeField]
	private DollyCartController FollowTarget;

	[SerializeField]
	private float SpeedMod;

	[SerializeField]
	private float RotateAnimationSpeed;

	[SerializeField]
	private float MoveSpeed;

	[SerializeField]
	private float RotateSpeed;

	public bool hasCollapsed;

	private List<Color> saturation;

	private void Start()
	{
	}

	public void Collapse()
	{
	}

	private void Desaturate()
	{
	}

	private void Saturate()
	{
	}

	private void FixedUpdate()
	{
	}

	private void OnCollisionEnter(Collision other)
	{
	}
}
