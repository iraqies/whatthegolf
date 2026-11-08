using System;
using System.Collections.Generic;
using System.Linq;
using Core;
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

	public float SizeMod = 1.5f;
	public bool isOnlyDisablingSimulationOnRigids;
	[SerializeField] private List<SectionInfo> sections;
	private Bounds playerBounds;
	private Transform trans;
	private bool cullingEnabled = true;
	public int total;
	public int simulated;
	public int activeCullers;

	public bool CullingEnabled
	{
		get => cullingEnabled;
		set
		{
			cullingEnabled = value;
			if (!value)
				DisableCulling();
		}
	}

	public override void OnPrePlayOrPreCompile()
	{
		base.OnPrePlayOrPreCompile();
		Cache();
	}

	public void Initialize()
	{
		trans = transform;
		Camera cam = Camera.main;
		if (cam != null)
		{
			Vector3 bl = cam.ViewportToWorldPoint(new Vector3(0f, 0f, 0f));
			Vector3 tr = cam.ViewportToWorldPoint(new Vector3(1f, 1f, 0f));
			float w = Mathf.Abs(tr.x - bl.x) * Mathf.Max(1.2f, SizeMod);
			float h = Mathf.Abs(tr.y - bl.y) * Mathf.Max(1.2f, SizeMod);
			if (w < 25f) w = 40f;
			if (h < 25f) h = 40f;
			playerBounds = new Bounds(trans.position, new Vector3(w, h, 100f));
		}
		else
		{
			playerBounds = new Bounds(trans.position, new Vector3(45f, 45f, 100f));
		}

		bool isRotated = PlatformSettings.Instance != null && PlatformSettings.Instance.GetCurrent() != null && PlatformSettings.Instance.GetCurrent().useRotatedOverworldAndCameraInLevels;
		if (sections == null || sections.Count == 0)
			Cache();
		if (sections == null) return;

		for (int i = 0; i < sections.Count; i++)
		{
			var info = sections[i];
			if (info == null) continue;
			if (info.rigids != null)
			{
				for (int j = 0; j < info.rigids.Length; j++)
				{
					var r = info.rigids[j];
					if (r != null)
					{
						r.Sleep();
						r.simulated = false;
					}
				}
			}
			if (info.cullers != null)
			{
				for (int j = 0; j < info.cullers.Length; j++)
				{
					var c = info.cullers[j];
					if (c != null)
					{
						c.Init();
						c.OnInvisible();
					}
				}
			}
			if (info.rotators != null)
			{
				for (int j = 0; j < info.rotators.Length; j++)
				{
					if (info.rotators[j] != null)
						info.rotators[j].enabled = false;
				}
			}
			info.isActive = false;
			if (info.section != null)
			{
				info.section.SetActiveCulling(false);
				if (info.section.Container != null)
				{
					bool keepActive = isRotated
						? (info.section.SectionPlatform == HubSection.SectionPlatformEnum.All || info.section.SectionPlatform == HubSection.SectionPlatformEnum.Mobile)
						: (info.section.SectionPlatform == HubSection.SectionPlatformEnum.All || info.section.SectionPlatform == HubSection.SectionPlatformEnum.Standalone);
					info.section.Container.SetActive(keepActive);
				}
			}
		}
		UpdateCulling();
	}

	public void Cache()
	{
		var allSections = FindObjectsOfType<HubSection>();
		sections = new List<SectionInfo>();
		total = 0;
		bool isRotated = PlatformSettings.Instance != null && PlatformSettings.Instance.GetCurrent() != null && PlatformSettings.Instance.GetCurrent().useRotatedOverworldAndCameraInLevels;
		for (int i = 0; i < allSections.Length; i++)
		{
			var sec = allSections[i];
			if (sec == null) continue;
			sec.Show();
			var rbs = sec.GetComponentsInChildren<Rigidbody2D>(true)
				.Where(r => r != null && r.GetComponent<IgnoreSectionCulling>() == null)
				.ToArray();
			total += rbs.Length;
			var culls = sec.GetComponentsInChildren<CullWhenHidden>(true);
			var info = new SectionInfo
			{
				section = sec,
				rigids = rbs,
				cullers = culls,
				isActive = false
			};
			sec.SetActiveCulling(false);
			sections.Add(info);
			sec.PreBuildScript(isRotated);
		}
	}

	public void ReturnToOverworld()
	{
		if (sections != null)
		{
			for (int i = 0; i < sections.Count; i++)
			{
				var info = sections[i];
				if (info == null) continue;
				if (isOnlyDisablingSimulationOnRigids && info.rigids != null)
				{
					for (int j = 0; j < info.rigids.Length; j++)
					{
						if (info.rigids[j] != null)
							info.rigids[j].Sleep();
					}
				}
				if (info.rotators != null)
				{
					for (int j = 0; j < info.rotators.Length; j++)
					{
						if (info.rotators[j] != null)
							info.rotators[j].enabled = false;
					}
				}
			}
		}
		UpdateCulling();
	}

	public void UpdateCulling()
	{
		if (!cullingEnabled) return;
		if (trans == null) trans = transform;
		Vector3 pos = trans.position;
		if (CameraStack.OverworldCamera.Instance != null && CameraStack.OverworldCamera.Instance.MainCamera != null)
		{
			pos = CameraStack.OverworldCamera.Instance.MainCamera.transform.position;
		}
		else if (OverworldManager2d.HasInstance && OverworldManager2d.Instance != null && OverworldManager2d.Instance.ball != null)
		{
			pos = OverworldManager2d.Instance.ball.transform.position;
		}
		playerBounds.center = new Vector3(pos.x, pos.y, 0f);
		if (sections == null) return;

		for (int i = 0; i < sections.Count; i++)
		{
			var info = sections[i];
			if (info == null || info.section == null || info.section.Container == null)
				continue;
			if (!info.section.Container.activeInHierarchy && isOnlyDisablingSimulationOnRigids)
				continue;

			bool intersects = info.section.IntersectsCullingBounds(playerBounds);
			if (info.isActive)
				info.section.UpdateWhenCulledIn();

			if (intersects && !info.isActive)
			{
				info.isActive = true;
				info.section.SetActiveCulling(true);
				if (isOnlyDisablingSimulationOnRigids)
				{
					if (info.rigids != null)
					{
						for (int j = 0; j < info.rigids.Length; j++)
						{
							var r = info.rigids[j];
							if (r != null)
							{
								r.simulated = true;
								r.Sleep();
								simulated++;
							}
						}
					}
				}
				else if (info.section.Container != null)
				{
					info.section.Container.SetActive(true);
				}

				if (info.cullers != null)
				{
					for (int j = 0; j < info.cullers.Length; j++)
					{
						var c = info.cullers[j];
						if (c != null)
						{
							c.OnSectionVisible();
							activeCullers++;
						}
					}
				}
				if (info.rotators != null)
				{
					for (int j = 0; j < info.rotators.Length; j++)
					{
						if (info.rotators[j] != null)
							info.rotators[j].enabled = true;
					}
				}
			}
			else if (!intersects && info.isActive)
			{
				info.isActive = false;
				info.section.SetActiveCulling(false);
				if (isOnlyDisablingSimulationOnRigids)
				{
					if (info.rigids != null)
					{
						for (int j = 0; j < info.rigids.Length; j++)
						{
							var r = info.rigids[j];
							if (r != null)
							{
								r.Sleep();
								r.simulated = false;
								simulated--;
							}
						}
					}
				}
				else if (info.section.Container != null)
				{
					info.section.Container.SetActive(false);
				}

				if (info.cullers != null)
				{
					for (int j = 0; j < info.cullers.Length; j++)
					{
						var c = info.cullers[j];
						if (c != null)
						{
							c.OnSectionInvisible();
							activeCullers--;
						}
					}
				}
				if (info.rotators != null)
				{
					for (int j = 0; j < info.rotators.Length; j++)
					{
						if (info.rotators[j] != null)
							info.rotators[j].enabled = false;
					}
				}
			}
		}
	}

	private void OnDrawGizmosSelected()
	{
	}

	public void DisableCulling()
	{
		if (sections == null) return;
		foreach (var info in sections)
		{
			if (info == null || info.section == null) continue;
			if (info.section.Container != null)
				info.section.Container.SetActive(true);
			if (isOnlyDisablingSimulationOnRigids && info.rigids != null)
			{
				for (int i = 0; i < info.rigids.Length; i++)
				{
					if (info.rigids[i] != null)
						info.rigids[i].simulated = true;
				}
			}
		}
	}
}
