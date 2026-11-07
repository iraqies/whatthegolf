using System.Collections;
using UnityEngine;

public class BossStageController : MonoBehaviour
{
	public enum StageToPlayEnum
	{
		All = 0,
		ChaseStage = 1,
		BoatStage = 2,
		BoatStageWithoutIntro = 3,
		InsideFrogStage = 4,
		FinalStage = 5
	}

	public FinalBoss FirstStage;

	public BossSHMUP SecondStage;

	public BossFrogKingInside ThirdStage;

	public FrogKingLastStage FourthStage;

	public StageToPlayEnum StageToPlay;

	private IEnumerator Start()
	{
		return null;
	}
}
