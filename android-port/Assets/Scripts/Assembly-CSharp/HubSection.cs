using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Tilemaps;

public class HubSection : GolfBehaviour
{
	public enum SectionPlatformEnum
	{
		All = 0,
		Mobile = 1,
		Standalone = 2,
		None = 3
	}

	public static Tilemap LAST_SELECTED_TILEMAP_FOR_EDITOR;
	public SectionPlatformEnum SectionPlatform;
	public GameObject Container;
	public Tilemap SectionTilemap;
	public List<Tilemap> DecorationsMaps;
	public bool shouldRotateTilesForMobile;
	public bool dontChangeAnimatorCullingMode;
	[SerializeField] private SortGroupManager sortManager;
	public bool useLineRendersForBounds;
	public Bounds cachedBounds;
	public bool isUsingSectionBoundsInstead;
	public List<Bounds> cullingBounds;
	public bool hasBeenCached;
	public bool isActiveInCulling = true;
	[SerializeField] private TilemapRenderer tileRenderer;

	[CompilerGenerated]
	private Action<bool> m_OnSectionCullingUpdate;

	public event Action<bool> OnSectionCullingUpdate
	{
		[CompilerGenerated]
		add => m_OnSectionCullingUpdate = (Action<bool>)Delegate.Combine(m_OnSectionCullingUpdate, value);
		[CompilerGenerated]
		remove => m_OnSectionCullingUpdate = (Action<bool>)Delegate.Remove(m_OnSectionCullingUpdate, value);
	}

	[RuntimeInitializeOnLoadMethod]
	private static void Init()
	{
		LAST_SELECTED_TILEMAP_FOR_EDITOR = null;
	}

	private void Awake()
	{
		if (tileRenderer != null)
			tileRenderer.enabled = false;
		if (SectionTilemap != null)
		{
			var tr = SectionTilemap.GetComponent<Renderer>();
			if (tr != null) tr.enabled = false;
		}
		if (DecorationsMaps != null)
		{
			foreach (var dm in DecorationsMaps)
			{
				if (dm != null)
				{
					var r = dm.GetComponent<Renderer>();
					if (r != null) r.enabled = true;
				}
			}
		}
		if (Container != null)
			Container.SetActive(true);
		if (!dontChangeAnimatorCullingMode)
		{
			foreach (var anim in GetComponentsInChildren<Animator>(true))
			{
				if (anim != null)
					anim.cullingMode = AnimatorCullingMode.CullCompletely;
			}
		}
	}

	public override void OnPrePlayOrPreCompile()
	{
		Awake();
	}

	public bool PreBuildScript(bool isRotated)
	{
		Awake();
		return true;
	}

	public void UpdateWhenCulledIn()
	{
		if (sortManager != null)
			sortManager.UpdateSorting();
	}

	public Bounds GetBounds(bool redraw = true)
	{
		if (hasBeenCached && !redraw) return cachedBounds;
		if (SectionTilemap != null)
		{
			SectionTilemap.CompressBounds();
			Bounds b = SectionTilemap.localBounds;
			b.center += SectionTilemap.transform.position;
			cachedBounds = b;
			hasBeenCached = true;
			return cachedBounds;
		}
		return new Bounds(transform.position, new Vector3(100f, 100f, 100f));
	}

	private void OnDrawGizmosSelected() { }

	public void Show()
	{
		if (Container != null)
			Container.SetActive(true);
		gameObject.SetActive(true);
	}

	public void OnDisable()
	{
		SetActiveCulling(false);
	}

	public bool Intersects(Bounds playerBounds)
	{
		return true;
	}

	public bool IntersectsCullingBounds(Bounds playerBounds)
	{
		return true;
	}

	public void SetActiveCulling(bool isActive)
	{
		isActiveInCulling = isActive;
		if (Container != null && isActive)
			Container.SetActive(true);
		m_OnSectionCullingUpdate?.Invoke(isActive);
	}
}
