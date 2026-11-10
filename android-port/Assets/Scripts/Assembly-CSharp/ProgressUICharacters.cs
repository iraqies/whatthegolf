using System;
using System.Collections;
using System.Collections.Generic;
using Audio.Multiplayer;
using UnityEngine;

public class ProgressUICharacters : MonoBehaviour
{
	[Serializable]
	public class ProgressAvatar
	{
		public PlayerColors.AvatarIDs ID;

		public GameObject GameObject;

		public float MoveSpeed = 5f;

		public Animator Animator;
	}

	public ProgressUICharacterAudio progressUIAudio;

	public AnimationCurve CharacterMoveCurve = AnimationCurve.EaseInOut(0f, 0f, 1f, 1f);

	public List<ProgressAvatar> LeftCharacters;

	public List<ProgressAvatar> RightCharacters;

	public List<ProgressAvatar> TopCharacters;

	public List<ProgressAvatar> BottomCharacters;

	public List<ProgressAvatar> LeftCrownAvatar;

	public List<ProgressAvatar> RightCrownAvatar;

	private List<ProgressAvatar> activeCharacters;

	private Dictionary<ProgressAvatar, Vector3> offsets;

	private bool initialized;

	public void Initialize()
	{
		if (initialized)
		{
			return;
		}
		activeCharacters = new List<ProgressAvatar>();
		offsets = new Dictionary<ProgressAvatar, Vector3>();
		initialized = true;
	}

	public void SetCharacters(List<MultiplayerConfiguration.PlayerInfo> players)
	{
		if (!initialized)
		{
			Initialize();
		}
		activeCharacters.Clear();
		if (players == null)
		{
			return;
		}
		for (int i = 0; i < players.Count; i++)
		{
			MultiplayerConfiguration.PlayerInfo p = players[i];
			if (p == null || p.Avatar == null)
			{
				continue;
			}
			List<ProgressAvatar> pool = p.Side switch
			{
				LobbySpawnPoint.SpawnPointPositions.Left => LeftCharacters,
				LobbySpawnPoint.SpawnPointPositions.Right => RightCharacters,
				LobbySpawnPoint.SpawnPointPositions.Top => TopCharacters,
				LobbySpawnPoint.SpawnPointPositions.Bottom => BottomCharacters,
				_ => LeftCharacters,
			};
			if (pool == null)
			{
				continue;
			}
			for (int j = 0; j < pool.Count; j++)
			{
				ProgressAvatar av = pool[j];
				if (av != null && av.GameObject != null)
				{
					bool match = av.ID == p.Avatar.AvatarID;
					av.GameObject.SetActive(match);
					if (match)
					{
						activeCharacters.Add(av);
					}
				}
			}
		}
	}

	public IEnumerator DoWinPose(PlayerColors.AvatarIDs winID)
	{
		if (activeCharacters != null)
		{
			for (int i = 0; i < activeCharacters.Count; i++)
			{
				if (activeCharacters[i] != null && activeCharacters[i].ID == winID && activeCharacters[i].Animator != null)
				{
					activeCharacters[i].Animator.SetTrigger("Win");
				}
			}
		}
		yield return new WaitForSeconds(0.5f);
	}

	public IEnumerator MoveCharacters(Vector3 to)
	{
		if (activeCharacters == null || activeCharacters.Count == 0)
		{
			yield break;
		}
		int doneCount = 0;
		for (int i = 0; i < activeCharacters.Count; i++)
		{
			StartCoroutine(MoveCharacter(activeCharacters[i], to, () => doneCount++));
		}
		while (doneCount < activeCharacters.Count)
		{
			yield return null;
		}
	}

	private IEnumerator MoveCharacter(ProgressAvatar avatar, Vector3 to, Action onDone)
	{
		if (avatar == null || avatar.GameObject == null)
		{
			onDone?.Invoke();
			yield break;
		}
		Vector3 startPos = avatar.GameObject.transform.position;
		float duration = Mathf.Max(0.2f, Vector3.Distance(startPos, to) / Mathf.Max(1f, avatar.MoveSpeed));
		float t = 0f;
		while (t < duration)
		{
			t += Time.deltaTime;
			float n = Mathf.Clamp01(t / duration);
			float eval = CharacterMoveCurve != null && CharacterMoveCurve.length > 0 ? CharacterMoveCurve.Evaluate(n) : n;
			avatar.GameObject.transform.position = Vector3.Lerp(startPos, to, eval);
			yield return null;
		}
		avatar.GameObject.transform.position = to;
		onDone?.Invoke();
	}

	public void ResetCharacters()
	{
		if (activeCharacters != null)
		{
			for (int i = 0; i < activeCharacters.Count; i++)
			{
				if (activeCharacters[i] != null && activeCharacters[i].GameObject != null)
				{
					activeCharacters[i].GameObject.SetActive(false);
				}
			}
			activeCharacters.Clear();
		}
	}
}
