using System.Collections.Generic;
using Core;

public class MarioCoinChallenge : Challenge
{
	public List<MarioBreakableBlock> coinBlocks;

	private int hitAmount;

	private int maxHitAmount;

	private GolfBallController controller;

	protected override void Activate()
	{
	}

	private void OnBlockHit(MarioBreakableBlock block)
	{
	}
}
