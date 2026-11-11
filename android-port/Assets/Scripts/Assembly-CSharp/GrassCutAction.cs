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

	public float CheckInterval = 0.5f;

	public int CheckRadius = 3;

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

	private List<SoccerPlayerOnGrass> toBeRemoved = new List<SoccerPlayerOnGrass>();

	private List<SoccerPlayerOnGrass> playersLeft = new List<SoccerPlayerOnGrass>();

	private bool routineRunning;

	private CinemachineBasicMultiChannelPerlin noise;

	private void Start()
	{
		checkTimer = CheckInterval;
		playersLeft = Players != null ? new List<SoccerPlayerOnGrass>(Players) : new List<SoccerPlayerOnGrass>();
		if (Camera != null)
		{
			noise = Camera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
		}
	}

	private IEnumerator StartEndRoutine()
	{
		routineRunning = true;
		if (CameraAnimator != null)
		{
			CameraAnimator.SetTrigger("Intro");
		}
		yield return new WaitForSeconds(0.5f);
		if (TribuneMoveClip != null)
		{
			TribuneMoveClip.Play(null, transform.position, 1f, 1f);
		}
		if (FlagAnimator != null)
		{
			FlagAnimator.SetTrigger("Move");
		}
		yield return StartCoroutine(Shake(2f, 2f, 1f));
		if (AudienceCheer != null)
		{
			AudienceCheer.Play(null, transform.position, 1f, 1f);
		}
		if (Football != null)
		{
			Football.SetActive(true);
		}
		yield return new WaitForSeconds(0.5f);
		if (Players != null)
		{
			for (int i = 0; i < Players.Count; i++)
			{
				if (Players[i] != null && Players[i].SoccerPlayer != null)
				{
					Players[i].SoccerPlayer.enabled = true;
					Rigidbody rb = Players[i].SoccerPlayer.GetRigid();
					if (rb != null)
					{
						rb.isKinematic = false;
					}
				}
			}
		}
		if (CameraAnimator != null)
		{
			CameraAnimator.SetTrigger("Outro");
		}
		if (MatchStartClip != null)
		{
			MatchStartClip.Play(null, transform.position, 1f, 1f);
		}
	}

	private void Update()
	{
		if (playersLeft == null || playersLeft.Count == 0 || GrassTerrain == null)
		{
			if (!routineRunning && playersLeft != null && playersLeft.Count == 0)
			{
				StartCoroutine(StartEndRoutine());
			}
			return;
		}
		checkTimer -= Time.deltaTime;
		if (checkTimer > 0f)
		{
			return;
		}
		checkTimer = CheckInterval;
		int[,] details = GrassTerrain.GetDetailLayer(0, 0, GrassTerrain.detailWidth, GrassTerrain.detailHeight, 0);
		toBeRemoved.Clear();
		for (int i = 0; i < playersLeft.Count; i++)
		{
			SoccerPlayerOnGrass p = playersLeft[i];
			if (p == null || p.SoccerPlayer == null)
			{
				toBeRemoved.Add(p);
				continue;
			}
			Vector3 tCor = ConvertWorldCor2TerrCor(p.SoccerPlayer.transform.position);
			int cx = Mathf.RoundToInt(tCor.x);
			int cz = Mathf.RoundToInt(tCor.z);
			bool hasGrass = false;
			for (int dx = -CheckRadius; dx <= CheckRadius && !hasGrass; dx++)
			{
				for (int dz = -CheckRadius; dz <= CheckRadius && !hasGrass; dz++)
				{
					int rx = cx + dx;
					int rz = cz + dz;
					if (rz >= 0 && rz < details.GetLength(0) && rx >= 0 && rx < details.GetLength(1) && details[rz, rx] > 0)
					{
						hasGrass = true;
					}
				}
			}
			if (!hasGrass)
			{
				toBeRemoved.Add(p);
			}
		}
		for (int i = 0; i < toBeRemoved.Count; i++)
		{
			SoccerPlayerOnGrass rem = toBeRemoved[i];
			playersLeft.Remove(rem);
			if (rem != null)
			{
				StartCoroutine(MovePlayer(rem));
			}
		}
		toBeRemoved.Clear();
		if (playersLeft.Count == 0 && !routineRunning)
		{
			StartCoroutine(StartEndRoutine());
		}
	}

	private IEnumerator MovePlayer(SoccerPlayerOnGrass player)
	{
		if (player == null || player.SoccerPlayer == null || player.TargetPosition == null)
		{
			yield break;
		}
		if (PlayerActivatedClips != null)
		{
			PlayerActivatedClips.Play(null, player.SoccerPlayer.transform.position, 1f, 1f);
		}
		Vector3 startPos = player.SoccerPlayer.transform.position;
		Rigidbody rb = player.SoccerPlayer.GetRigid();
		yield return StartCoroutine(pTween.To(0.5f, t =>
		{
			Vector3 nextPos = Vector3.Lerp(startPos, player.TargetPosition.position, Mathf.SmoothStep(0f, 1f, Mathf.Clamp01(t)));
			if (rb != null)
			{
				rb.MovePosition(nextPos);
			}
			else if (player.SoccerPlayer != null)
			{
				player.SoccerPlayer.transform.position = nextPos;
			}
		}));
	}

	private Vector3 ConvertWorldCor2TerrCor(Vector3 worldCor)
	{
		Terrain t = Terrain.activeTerrain;
		if (t == null || t.terrainData == null)
		{
			return Vector3.zero;
		}
		Vector3 rel = worldCor - t.transform.position;
		Vector3 size = t.terrainData.size;
		int res = t.terrainData.detailResolution;
		return new Vector3((rel.x / Mathf.Max(0.01f, size.x)) * res, 0f, (rel.z / Mathf.Max(0.01f, size.z)) * res);
	}

	private IEnumerator Shake(float amplitudeGain, float frequencyGain, float duration)
	{
		if (noise == null)
		{
			yield break;
		}
		noise.m_AmplitudeGain = amplitudeGain;
		noise.m_FrequencyGain = frequencyGain;
		yield return StartCoroutine(pTween.To(duration, t =>
		{
			if (noise != null)
			{
				noise.m_AmplitudeGain = Mathf.Lerp(amplitudeGain, 0f, t);
				noise.m_FrequencyGain = Mathf.Lerp(frequencyGain, 0f, t);
			}
		}));
		if (noise != null)
		{
			noise.m_AmplitudeGain = 0f;
			noise.m_FrequencyGain = 0f;
		}
	}

	private void OnDrawGizmosSelected()
	{
	}
}
