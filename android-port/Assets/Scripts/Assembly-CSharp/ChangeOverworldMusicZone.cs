using System.Collections.Generic;
using Core;
using UnityEngine;

public class ChangeOverworldMusicZone : OverworldMusicChanger
{
	public OverworldMusicData music;

	public bool requireBallType;

	public Transmogrif.BALLSHAPES ballShape;

	public List<GameObject> FlagContainers;

	private List<OverworldGoal> flags;

	public override void Init()
	{
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
	}
}
