using System;
using System.Collections.Generic;
using UnityEngine;

public class SectionCulling : GolfBehaviour
{
	[Serializable]
	public class SectionInfo
	{
		public HubSection section;
		public Rigidbody2D[] rigids;
		public CullWhenHidden[] cullers;
		public SpriteRenderer[] sprites;
		public MonoBehaviour[] rotators;
		public bool isActive;
	}

	public float SizeMod = 1.1f;
	public bool isOnlyDisablingSimulationOnRigids = true;
	[SerializeField] private List<SectionInfo> sections;
	private Bounds playerBounds;
	private Transform trans;
	private bool cullingEnabled;
	public int total;
	public int simulated;
	public int activeCullers;

	public bool CullingEnabled
	{
		get => cullingEnabled;
		set => cullingEnabled = value;
	}

	private void Awake()
	{
		DisableCulling();
	}

	public override void OnPrePlayOrPreCompile()
	{
		DisableCulling();
	}

	public void Initialize()
	{
		DisableCulling();
	}

	public void Cache()
	{
	}

	public void ReturnToOverworld()
	{
		DisableCulling();
	}

	public void UpdateCulling()
	{
	}

	private void OnDrawGizmosSelected()
	{
	}

	public void DisableCulling()
	{
		cullingEnabled = false;
		if (sections == null) return;
		foreach (var info in sections)
		{
			if (info == null) continue;
			info.isActive = true;
			if (info.section != null)
			{
				if (info.section.Container != null)
					info.section.Container.SetActive(true);
				info.section.SetActiveCulling(true);
			}
			if (info.rigids != null)
			{
				foreach (var r in info.rigids)
				{
					if (r != null) r.simulated = true;
				}
			}
			if (info.sprites != null)
			{
				foreach (var sp in info.sprites)
				{
					if (sp != null) sp.enabled = true;
				}
			}
			if (info.rotators != null)
			{
				foreach (var rot in info.rotators)
				{
					if (rot != null) rot.enabled = true;
				}
			}
			if (info.cullers != null)
			{
				foreach (var c in info.cullers)
				{
					if (c != null) c.OnSectionVisible();
				}
			}
		}
	}
}
