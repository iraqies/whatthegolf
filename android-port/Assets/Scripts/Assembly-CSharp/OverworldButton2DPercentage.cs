using System.Collections.Generic;
using System.Text.RegularExpressions;
using CameraStack;
using UnityEngine.Tilemaps;

public class OverworldButton2DPercentage : OverworldButton2D
{
	public float PercentageThreshold;

	public List<OverworldGoal> ignoreFlags;

	private Regex whitespaceRemover;

	private float Threshold => 0f;

	public override void Init(Tilemap tilemap, List<OverworldGoal> goals, OverworldCamera camera)
	{
	}

	public override void UpdateStatus()
	{
	}

	public override int GetFlagsLeft()
	{
		return 0;
	}
}
