using System.Collections.Generic;
using UnityEngine;

public class OverworldDoorRobotSmallmonitor : MonoBehaviour
{
	public OverworldMainDoorPlate plate;
	public List<Color> colors;
	private float nextChange;
	private SpriteRenderer render;

	private void Awake()
	{
		render = GetComponent<SpriteRenderer>();
	}

	private void Update()
	{
		if (plate == null || !plate.isOn || render == null || colors == null || colors.Count == 0)
			return;
		if (Time.time > nextChange)
		{
			render.color = colors[Random.Range(0, colors.Count)];
			nextChange = Time.time + Random.Range(0.2f, 0.8f);
		}
	}
}
