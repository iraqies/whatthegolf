using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class OverworldDoorRobotSmallButtonDisplay : MonoBehaviour
{
	public List<Color> colors;
	private float nextChange;
	private List<SpriteRenderer> renders;

	private void Awake()
	{
		renders = GetComponentsInChildren<SpriteRenderer>().ToList();
	}

	private void Update()
	{
		if (renders == null || renders.Count == 0 || colors == null || colors.Count == 0)
			return;
		if (Time.time > nextChange)
		{
			foreach (var r in renders)
			{
				if (r != null)
					r.color = colors[Random.Range(0, colors.Count)];
			}
			nextChange = Time.time + Random.Range(0.2f, 0.8f);
		}
	}
}
