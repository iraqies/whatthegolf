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

	public float SizeMod;

	public bool isOnlyDisablingSimulationOnRigids;

	[SerializeField]
	private List<SectionInfo> sections;

	private Bounds playerBounds;

	private Transform trans;

	private bool cullingEnabled;

	public int total;

	public int simulated;

	public int activeCullers;

	public bool CullingEnabled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public override void OnPrePlayOrPreCompile()
	{
	}

	public void Initialize()
	{
	}

	public void Cache()
	{
	}

	public void ReturnToOverworld()
	{
	}

	public void UpdateCulling()
	{
	}

	private void OnDrawGizmosSelected()
	{
	}

	public void DisableCulling()
	{
	}
}
