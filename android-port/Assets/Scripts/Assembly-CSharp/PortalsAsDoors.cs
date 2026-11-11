using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PortalsAsDoors : GolfBehaviour
{
	private SimplePortal portal;

	private SimplePortal linkedPortal;

	[SerializeField]
	private List<OverworldGoal> goals;

	public Action OnPortalUsed;

	private bool isOpen;

	[SerializeField]
	private OverworldID overworldID;

	public override void OnPrePlayOrPreCompile()
	{
		goals = new List<OverworldGoal>();
		goals = FindObjectsInOverworld.Find<OverworldGoal>(goals);
		Transform boundsTr = base.transform.Find("Bounds");
		if (boundsTr != null)
		{
			Bounds bounds = new Bounds(boundsTr.position, boundsTr.localScale);
			goals = goals.Where((OverworldGoal g) => g != null && bounds.Contains(g.transform.position)).ToList();
		}
		overworldID = GetComponent<OverworldID>();
	}

	private void Start()
	{
		portal = GetComponent<SimplePortal>();
		if (portal != null)
		{
			if (portal.LinkedPortal != null)
			{
				portal.LinkedPortal.LinkedPortal = portal;
			}
			if (goals != null)
			{
				goals.ForEach(delegate(OverworldGoal g)
				{
					if (g != null)
					{
						g.OnUpdateData += CheckGoal;
					}
				});
			}
			linkedPortal = portal.LinkedPortal;
			portal.LinkedPortal = null;
			CheckGoal();
		}
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (isOpen || collision == null || !collision.gameObject.CompareTag("Player"))
		{
			return;
		}
		if (HintEffect.Instance != null && goals != null)
		{
			Vector3[] positions = (from g in goals
				where g != null && !g.IsCompleted()
				select g.transform.position).ToArray();
			HintEffect.Instance.Play(base.transform.position, positions);
		}
	}

	private void CheckGoal(OverworldGoal goal = null)
	{
		if (goals != null && goals.All((OverworldGoal g) => g != null && g.IsCompleted()))
		{
			Open();
		}
	}

	private void Open()
	{
		isOpen = true;
		UnSubscribe();
		ParticleSystem componentInChildren = GetComponentInChildren<ParticleSystem>();
		if (componentInChildren != null)
		{
			ParticleSystem.EmissionModule emission = componentInChildren.emission;
			emission.enabled = true;
			componentInChildren.Play();
		}
		if (portal != null)
		{
			portal.LinkedPortal = linkedPortal;
			portal.OnPortaling += LinkedPortalUsed;
		}
	}

	private void LinkedPortalUsed(SimplePortal s, GameObject go, SimplePortal s2)
	{
		if (overworldID != null)
		{
			SaveGame.SetDoorOpen(overworldID.ID);
		}
		OnPortalUsed?.Invoke();
		if (portal != null)
		{
			portal.OnPortaling -= LinkedPortalUsed;
		}
	}

	public bool IsOpen()
	{
		if (overworldID != null)
		{
			return SaveGame.GetIsDoorOpen(overworldID.ID);
		}
		return isOpen;
	}

	private void OnDestroy()
	{
		UnSubscribe();
	}

	private void UnSubscribe()
	{
		if (goals != null)
		{
			goals.ForEach(delegate(OverworldGoal g)
			{
				if (g != null)
				{
					g.OnUpdateData -= CheckGoal;
				}
			});
		}
	}
}
