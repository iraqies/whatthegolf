using UnityEngine;

public class HorseJudge : MonoBehaviour
{
	public Animator Animator;

	public SetMaterialColorToPlayerColor LeftFlag;

	public SetMaterialColorToPlayerColor RightFlag;

	private void Awake()
	{
	}

	private void InstanceOnOnMultiplayerSetup(MultiplayerLevelInfo info)
	{
	}
}
