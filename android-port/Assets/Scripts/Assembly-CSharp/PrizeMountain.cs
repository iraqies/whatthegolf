using System.Linq;
using Core;
using Triband.MountainGeneratorTool;
using UnityEngine;

public class PrizeMountain : MonoBehaviour
{
	public DailyPrize prize;

	public GolfBallController controller;

	private void Awake()
	{
		var gen = GetComponentInChildren<MountainGenerator>();
		if (gen != null)
		{
			gen.BuildMountain();
			var renderers = gen.gameObject.GetComponentsInChildren<MeshRenderer>();
			if (renderers != null)
			{
				foreach (var r in renderers.Where(r => r != null && r.name == "Cube"))
				{
					r.enabled = false;
				}
			}
		}
	}
}
