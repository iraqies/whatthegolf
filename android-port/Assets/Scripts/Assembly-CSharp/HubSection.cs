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
	public bool isActiveInCulling;
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
		foreach (var s in GetComponentsInChildren<SortByY>(true))
		{
			if (s != null)
				s.isSorting = false;
		}
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
		base.OnPrePlayOrPreCompile();
		if (SectionTilemap != null)
			tileRenderer = SectionTilemap.GetComponent<TilemapRenderer>();
	}

	public bool PreBuildScript(bool isRotated)
	{
		if (sortManager == null)
			sortManager = GetComponent<SortGroupManager>();
		if (Container != null)
		{
			Container.SetActive(true);
			if (sortManager != null)
				sortManager.PreCache();
			bool keepActive = isRotated ? (SectionPlatform == SectionPlatformEnum.All || SectionPlatform == SectionPlatformEnum.Mobile) : (SectionPlatform == SectionPlatformEnum.All || SectionPlatform == SectionPlatformEnum.Standalone);
			Container.SetActive(keepActive);
		}
		return true;
	}

	public void UpdateWhenCulledIn()
	{
		if (sortManager != null)
			sortManager.UpdateSorting();
	}

	public Bounds GetBounds(bool redraw = true)
	{
		if (!redraw && hasBeenCached)
			return cachedBounds;
		Bounds b = new Bounds(transform.position, new Vector3(40f, 40f, 10f));
		if (SectionTilemap != null)
		{
			SectionTilemap.CompressBounds();
			b = SectionTilemap.localBounds;
			b.center += transform.position;
			Vector3 min = b.min + new Vector3(-1f, -1f, 0f);
			Vector3 max = b.max + new Vector3(1f, 1f, 0f);
			b.SetMinMax(new Vector3(min.x, min.y, 0f), new Vector3(max.x, max.y, 0f));
		}
		foreach (var sr in gameObject.GetComponentsInChildren<SpriteRenderer>(true))
		{
			if (sr != null)
				b.Encapsulate(sr.bounds);
		}
		if (useLineRendersForBounds)
		{
			foreach (var lr in gameObject.GetComponentsInChildren<LineRenderer>(false))
			{
				if (lr != null)
					b.Encapsulate(lr.bounds);
			}
		}
		cachedBounds = b;
		hasBeenCached = true;
		return cachedBounds;
	}

	private void OnDrawGizmosSelected() { }

	public void Show()
	{
		if (Container != null)
			Container.SetActive(true);
	}

	public void OnDisable()
	{
		isActiveInCulling = false;
		m_OnSectionCullingUpdate?.Invoke(false);
	}

	public bool Intersects(Bounds playerBounds)
	{
		Bounds b = GetBounds(false);
		playerBounds.center = new Vector3(playerBounds.center.x, playerBounds.center.y, b.center.z);
		return b.Intersects(playerBounds);
	}

	public bool IntersectsCullingBounds(Bounds playerBounds)
	{
		Bounds b = GetBounds(false);
		playerBounds.center = new Vector3(playerBounds.center.x, playerBounds.center.y, b.center.z);
		if (isUsingSectionBoundsInstead)
		{
			if (!b.Intersects(playerBounds))
				return false;
			if (cullingBounds == null || cullingBounds.Count == 0)
				return true;
			for (int i = 0; i < cullingBounds.Count; i++)
			{
				Bounds cb = cullingBounds[i];
				playerBounds.center = new Vector3(playerBounds.center.x, playerBounds.center.y, cb.center.z);
				if (cb.Intersects(playerBounds))
					return true;
			}
			return false;
		}
		return b.Intersects(playerBounds);
	}

	public void SetActiveCulling(bool isActive)
	{
		isActiveInCulling = isActive;
		m_OnSectionCullingUpdate?.Invoke(isActive);
	}
}
