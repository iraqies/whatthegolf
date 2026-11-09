using System.Collections.Generic;
using UnityEngine;

public class OverworldPortalCameraBlender : GolfBehaviour
{
	public OverworldCameraSettings farPortal;

	public OverworldCameraSettings outgoing;

	private Coroutine current;

	[SerializeField]
	private List<SimplePortal> portals;

	public override void OnPrePlayOrPreCompile()
	{
		base.OnPrePlayOrPreCompile();
		portals = new List<SimplePortal>(FindObjectsOfType<SimplePortal>());
	}

	private void Start()
	{
		if (portals == null || portals.Count == 0)
			portals = new List<SimplePortal>(FindObjectsOfType<SimplePortal>());
		for (int i = 0; i < portals.Count; i++)
		{
			if (portals[i] != null)
			{
				portals[i].OnPortaling -= Portal_OnPortaling;
				portals[i].OnPortaling += Portal_OnPortaling;
			}
		}
	}

	private void Portal_OnPortaling(SimplePortal portal, GameObject thing, SimplePortal targetPortal)
	{
		if (farPortal == null) return;
		if (current != null) StopCoroutine(current);
		current = StartCoroutine(pTween.To(0.35f, 0f, 1f, t =>
		{
			if (farPortal != null)
				farPortal.SetValue(Mathf.Sin(t * Mathf.PI));
		}));
	}
}
