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
		if (buttonImage != null && defaultButtonSprite != null)
		{
			buttonImage.sprite = defaultButtonSprite;
		}
	}

	public void SpawnpointPickedBy(PlayerColors.AvatarData avatar)
	{
		if (ReadySilhouette != null)
		{
			ReadySilhouette.SetActive(false);
		}
		if (PressToJoinAnimator != null)
		{
			PressToJoinAnimator.SetBool("Connecting", false);
			PressToJoinAnimator.SetBool("Connected", true);
		}
		if (PipeAnimator != null)
		{
			PipeAnimator.SetTrigger("Shoot");
		}
		if (PillowAnimator != null)
		{
			PillowAnimator.SetBool("Visible", true);
		}
		if (Pillow != null && avatar != null)
		{
			Pillow.material.color = avatar.BaseColor;
		}
		if (Particles != null)
		{
			Particles.Play();
		}
		if (spawnAudioBehaviour != null)
		{
			spawnAudioBehaviour.OnSpawn(avatar);
		}
	}

	public void SpawnpointDeactivated()
	{
		if (ReadySilhouette != null)
		{
			ReadySilhouette.SetActive(true);
		}
		if (PressToJoinAnimator != null)
		{
			PressToJoinAnimator.SetBool("Connecting", false);
			PressToJoinAnimator.SetBool("Connected", false);
		}
		if (PillowAnimator != null)
		{
			PillowAnimator.SetBool("Visible", false);
		}
	}

	public void SpawnpointGettingActivated(float time)
	{
		if (PressToJoinAnimator != null)
		{
			PressToJoinAnimator.SetBool("Connecting", true);
		}
		if (spawnAudioBehaviour != null)
		{
			spawnAudioBehaviour.OnActivating(time);
		}
	}
}
