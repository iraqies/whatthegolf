using System;
using System.Collections;
using System.Collections.Generic;
using Audio;
using Cinemachine;
using UnityEngine;

public class GrassCutAction : MonoBehaviour
{
	[Serializable]
	public class SoccerPlayerOnGrass
	{
		public Transform TargetPosition;

		public SoccerPlayer SoccerPlayer;
	}

	public TerrainData GrassTerrain;

	public float CheckInterval;

	public int CheckRadius;

	public List<SoccerPlayerOnGrass> Players;

	public GameObject Football;

	public Animator FlagAnimator;

	public Animator CameraAnimator;

	public CinemachineVirtualCamera Camera;

	public ClipSettingsCollection MatchStartClip;

	public ClipSettingsCollection TribuneMoveClip;

	public ClipSettingsCollection PlayerActivatedClips;

	public ClipSettingsCollection AudienceCheer;

	private float checkTimer;

	private List<SoccerPlayerOnGrass> toBeRemoved;

	private List<SoccerPlayerOnGrass> playersLeft;

	private bool routineRunning;

	private CinemachineBasicMultiChannelPerlin noise;

	private void Start()
	{
	}

	private IEnumerator StartEndRoutine()
	{
		return null;
	}

	private void Update()
	{
	}

	private IEnumerator MovePlayer(SoccerPlayerOnGrass player)
	{
		return null;
	}

	private Vector3 ConvertWorldCor2TerrCor(Vector3 worldCor)
	{
		return default;
	}

	private IEnumerator Shake(float amplitudeGain, float frequencyGain, float duration)
	{
		return null;
	}

	private void OnDrawGizmosSelected()
	{
	}
}
