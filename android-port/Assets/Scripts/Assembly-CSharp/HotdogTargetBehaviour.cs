using System;
using System.Collections.Generic;
using Audio;
using Cinemachine;
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
	private float SpeedMod = 0.1f;

	[SerializeField]
	private float RotateAnimationSpeed = 5f;

	[SerializeField]
	private float MoveSpeed = 1f;

	[SerializeField]
	private float RotateSpeed = 1f;

	public bool hasCollapsed;

	private List<Color> saturation = new List<Color>();

	private void Start()
	{
		if (Animator != null)
		{
			Animator.SetBool("HoldingThing", false);
			Animator.SetBool("CanSeePlayer", false);
		}
		if (FollowTarget != null)
		{
			CinemachineDollyCart component = FollowTarget.gameObject.GetComponent<CinemachineDollyCart>();
			if (component != null)
			{
				component.m_Speed = 0f;
			}
		}
	}

	public void Collapse()
	{
		if (HeldThing != null && HotdogPrefab != null)
		{
			UnityEngine.Object.Instantiate(HotdogPrefab, HeldThing.transform);
		}
		if (Animator != null)
		{
			Animator.SetBool("HoldingThing", true);
		}
		if ((bool)sfxEventOnCollapse)
		{
			sfxEventOnCollapse.Play(base.transform.position);
		}
		if (Animator != null)
		{
			Animator.SetInteger("CanSeeID", UnityEngine.Random.Range(1, 3));
			Animator.SetInteger("ExcitedID", UnityEngine.Random.Range(1, 3));
		}
		hasCollapsed = true;
		if (Animator != null)
		{
			Animator.SetTrigger("LevelCompleted");
		}
		OnCollapsed?.Invoke(this);
	}

	private void Desaturate()
	{
		if (skinnedMeshRenderer == null)
		{
			return;
		}
		Material[] materials = skinnedMeshRenderer.materials;
		if (materials == null)
		{
			return;
		}
		for (int i = 0; i < materials.Length; i++)
		{
			Material material = materials[i];
			if (material != null)
			{
				if (saturation != null)
				{
					saturation.Add(material.color);
				}
				Color.RGBToHSV(material.color, out var H, out var _, out var V);
				material.color = Color.HSVToRGB(H, 0f, V);
			}
		}
	}

	private void Saturate()
	{
		if (skinnedMeshRenderer == null || saturation == null)
		{
			return;
		}
		Material[] materials = skinnedMeshRenderer.materials;
		if (materials == null)
		{
			return;
		}
		for (int num = materials.Length - 1; num >= 0; num--)
		{
			Material[] materials2 = skinnedMeshRenderer.materials;
			if (materials2 != null && num < materials2.Length && num < saturation.Count && materials2[num] != null)
			{
				materials2[num].color = saturation[num];
			}
		}
	}

	private void FixedUpdate()
	{
		if (hasCollapsed && FollowTarget != null)
		{
			CinemachineDollyCart component = FollowTarget.gameObject.GetComponent<CinemachineDollyCart>();
			if (component != null)
			{
				component.m_Speed = 0.5f;
			}
		}
	}

	private void OnCollisionEnter(Collision other)
	{
		Collapse();
	}
}
