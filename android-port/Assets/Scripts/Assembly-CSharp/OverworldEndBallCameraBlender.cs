using UnityEngine;

public class OverworldEndBallCameraBlender : GolfBehaviour
{
	public OverworldCameraSettings endCameraSettings;

	private Coroutine current;

	public Color baseBackground;

	public Color endBackground;

	public SpriteRenderer backgroundRenderer;

	private Coroutine currentColor;

	private bool isInEndMode;

	public override void OnPrePlayOrPreCompile()
	{
	}

	private void Start()
	{
	}

	private void Instance_OnNewBall(Transmogrif.BALLSHAPES shape)
	{
	}

	private void CheckEndMode(Transmogrif.BALLSHAPES shape)
	{
	}
}
