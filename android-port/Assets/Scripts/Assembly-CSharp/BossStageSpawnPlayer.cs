using System.Collections;
using System.Collections.Generic;
using Audio;
using UnityEngine;

public class BossStageSpawnPlayer : MonoBehaviour
{
	public Transform SpawnPoint;

	public Rigidbody PipeRigid;

	public ParticleSystem MachineParticles;

	public List<MeshRenderer> Lights;

	public Material OnMaterial;

	public Material OffMaterial;

	public Transform HiddenControllerStartPosition;

	public AudioSource PipeMove;

	public AudioClipSettings SteamSound;

	public AudioClipSettings EggSpawn;

	public AudioClip LightsSound;

	private bool firstSpawn = true;

	public ParticleSystem BirthSystem;

	public Animator RobotFaceAnimator;

	public List<ParticleSystem> WheelTrails;

	private void Awake()
	{
	}

	public IEnumerator SpawnPlayer(BossPlayerEgg egg)
	{
		if (egg == null)
		{
			yield break;
		}
		if (Lights != null && OnMaterial != null)
		{
			for (int i = 0; i < Lights.Count; i++)
			{
				if (Lights[i] != null)
				{
					Lights[i].sharedMaterial = OnMaterial;
				}
				if (LightsSound != null)
				{
					AudioManager.PlaySFX(LightsSound, transform.position);
				}
				yield return new WaitForSeconds(0.1f);
			}
		}
		if (MachineParticles != null)
		{
			MachineParticles.Play();
		}
		if (SteamSound != null)
		{
			AudioManager.PlaySFX(SteamSound, transform.position);
		}
		if (BirthSystem != null)
		{
			BirthSystem.Play();
		}
		if (EggSpawn != null)
		{
			AudioManager.PlaySFX(EggSpawn, SpawnPoint != null ? SpawnPoint.position : transform.position);
		}
		if (SpawnPoint != null)
		{
			egg.transform.position = SpawnPoint.position;
			egg.transform.rotation = SpawnPoint.rotation;
		}
		egg.gameObject.SetActive(true);
		firstSpawn = false;
		yield return new WaitForSeconds(Mathf.Max(0.5f, egg.HatchTime + egg.ShakeDuration));
	}
}
