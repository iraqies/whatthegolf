using Audio;
using UnityEngine;

public class LobbySpawnPoint : MonoBehaviour
{
	public enum SpawnPointPositions
	{
		Left = 0,
		Right = 1,
		Top = 2,
		Bottom = 3
	}

	public SpawnPointPositions Position;

	public GameObject ReadySilhouette;

	public Animator PressToJoinAnimator;

	public Animator PipeAnimator;

	public ParticleSystem Particles;

	public MeshRenderer Pillow;

	public Transform CrownSpawnPosition;

	public Transform PlayerSpawnPosition;

	public Animator PillowAnimator;

	public LobbySpawnAudio spawnAudioBehaviour;

	public Sprite defaultButtonSprite;

	public Sprite playstationButtonSprite;

	public SVGImage buttonImage;

	private void Awake()
	{
	}

	public void SpawnpointPickedBy(PlayerColors.AvatarData avatar)
	{
	}

	public void SpawnpointDeactivated()
	{
	}

	public void SpawnpointGettingActivated(float time)
	{
	}
}
