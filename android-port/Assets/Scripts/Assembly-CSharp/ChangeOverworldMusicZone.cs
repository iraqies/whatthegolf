using System.Collections.Generic;
using Core;
using UnityEngine;

public class ChangeOverworldMusicZone : OverworldMusicChanger
{
	public OverworldMusicData music;

	public bool requireBallType;

	public Transmogrif.BALLSHAPES ballShape;

	public List<GameObject> FlagContainers;

	private List<OverworldGoal> flags = new List<OverworldGoal>();

	public override void Init()
	{
		flags = new List<OverworldGoal>();
		if (FlagContainers != null)
		{
			for (int i = 0; i < FlagContainers.Count; i++)
			{
				if (FlagContainers[i] != null)
					flags.AddRange(FlagContainers[i].GetComponentsInChildren<OverworldGoal>(true));
			}
		}
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision == null || music == null) return;
		var ball = collision.GetComponent<OverworldBall2D>() ?? collision.GetComponentInParent<OverworldBall2D>();
		if (ball == null) return;
		if (requireBallType && OverworldBallManager.Instance != null && OverworldBallManager.Instance.currentShape != ballShape)
			return;
		TriggerMusic(music, flags);
	}
}
