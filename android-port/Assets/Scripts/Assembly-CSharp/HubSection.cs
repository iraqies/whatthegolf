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

	[SerializeField]
	private SortGroupManager sortManager;

	public bool useLineRendersForBounds;

	public Bounds cachedBounds;

	public bool isUsingSectionBoundsInstead;

	public List<Bounds> cullingBounds;

	public bool hasBeenCached;

	public bool isActiveInCulling;

	[SerializeField]
	private TilemapRenderer tileRenderer;

	[CompilerGenerated]
	private Action<bool> m_OnSectionCullingUpdate;

	public event Action<bool> OnSectionCullingUpdate
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	[RuntimeInitializeOnLoadMethod]
	private static void Init()
	{
	}

	private void Awake()
	{
	}

	public override void OnPrePlayOrPreCompile()
	{
	}

	public bool PreBuildScript(bool isRotated)
	{
		return false;
	}

	public void UpdateWhenCulledIn()
	{
	}

	public Bounds GetBounds(bool redraw = true)
	{
		return default;
	}

	private void OnDrawGizmosSelected()
	{
	}

	public void Show()
	{
	}

	public void OnDisable()
	{
	}

	public bool Intersects(Bounds playerBounds)
	{
		return false;
	}

	public bool IntersectsCullingBounds(Bounds playerBounds)
	{
		return false;
	}

	public void SetActiveCulling(bool isActive)
	{
	}
}
