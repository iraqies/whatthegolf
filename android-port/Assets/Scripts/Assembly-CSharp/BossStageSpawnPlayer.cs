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

	private bool firstSpawn;

	public ParticleSystem BirthSystem;

	public Animator RobotFaceAnimator;

	public List<ParticleSystem> WheelTrails;

	private void Awake()
	{
	}

	public IEnumerator SpawnPlayer(BossPlayerEgg egg)
	{
		return null;
	}
}
