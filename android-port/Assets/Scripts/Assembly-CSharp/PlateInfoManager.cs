using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Core;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlateInfoManager : MonoBehaviour
{
	public enum AreaState
	{
		DOOR_CLOSED = 0,
		DOOR_OPEN = 1,
		LEVELS_COMLETE = 2,
		CHALLENGES_COMPLETE = 3
	}

	public enum ChestID
	{
		CHEST_CARS = 0,
		CHEST_INTRO = 1,
		CHEST_EASY2D = 2,
		CHEST_LIVINGROOM = 3,
		CHEST_PLATFORMER = 4,
		CHEST_SOCCER1 = 5,
		CHEST_SPACE = 6,
		CHEST_EXPLOSION = 7,
		CHEST_OL = 8,
		CHEST_LEBOWSKI = 9,
		CHEST_PORTAL = 10,
		CHEST_SUPERPUTT = 11,
		CHEST_KITCHEN = 12,
		CHEST_GRAVITY_MAIN = 13,
		CHEST_GRAVITY_SIDE = 14,
		CHEST_HOLOROOM = 15,
		CHEST_FPG = 16,
		CHEST_MUSIC = 17,
		CHEST_STEALTH = 18,
		CHEST_JUNGLE = 19,
		CHEST_WATER = 20,
		CHEST_DESERT1 = 21,
		CHEST_DESERT2 = 22,
		CHEST_SAWABLE = 23,
		CHEST_END = 24
	}

	[SerializeField]
	private enum AreaIDEnum
	{
		INTRO_10 = 0,
		EASY2D_09A = 1,
		LIVINGROOM_09B = 2,
		PLATFORMERS_08A = 3,
		SOCCER_08B = 4,
		SPACE_08C = 5,
		EXPLOSION_08D = 6,
		OL_07A = 7,
		LEBOWSKI_07B = 8,
		PORTAL_06A = 9,
		SUPERPUTT_06B = 10,
		KITCHEN_05A = 11,
		GRAVITY_05B = 12,
		FPG_05C = 13,
		MUSIC_04A = 14,
		STEALTH_04B = 15,
		JUNGLE_03A = 16,
		CARS_03B = 17,
		WATER_02 = 18,
		WETERN_01 = 19,
		END_00 = 20
	}

	[SerializeField]
	private Animator BubbleAnimator;

	[SerializeField]
	private OverworldMainDoorPlate plate;

	[SerializeField]
	private TextMeshPro text;

	[SerializeField]
	private GameObject DefaultIcon;

	[SerializeField]
	private GameObject CrownIcon;

	[SerializeField]
	private GameObject Text;

	[SerializeField]
	private GameObject ABTransition;

	[SerializeField]
	private GameObject BCTransition;

	[SerializeField]
	private OverworldLevelData _campaignData;

	[SerializeField]
	private AreaIDEnum Name;

	[SerializeField]
	private GameObject Container;

	[SerializeField]
	private GameObject Tip;

	private List<LevelData> levels;

	public OverworldButton2D overrideLevels;

	public ChestID chestID;

	private AreaState areaState;

	public Action<AreaState> onAreaStateChanged;

	private List<OverworldGoal> goals;

	private bool usingGoals;

	private static OverworldGoal[] overworldGoalCache;

	private bool isAnimating;

	private void Awake()
	{
		StartCoroutine(StartAfter());
	}

	private IEnumerator StartAfter()
	{
		int num = GetInstanceID() & 8;
		yield return new WaitForSeconds((float)num / 60f + 0.5f);
		if (overrideLevels != null && overrideLevels.requireGoals != null)
		{
			levels = overrideLevels.requireGoals.Select((OverworldGoal g) => g.levelData).ToList();
			goals = overrideLevels.requireGoals;
			usingGoals = true;
		}
		else if (_campaignData != null)
		{
			string id = SectionID(Name);
			OverworldLevelSection overworldLevelSection = _campaignData.Sections?.Find((OverworldLevelSection s) => s.ID == id);
			if (overworldLevelSection == null)
			{
				UnityEngine.Object.Destroy(base.gameObject);
				yield break;
			}
			levels = overworldLevelSection.Levels;
			if (levels != null)
			{
				levels = levels.Where((LevelData l) => l != null && !l.name.Contains("Skip")).ToList();
				levels = levels.Where((LevelData l) => l != null && !l.IsBossLevel).ToList();
			}
			OverworldGoal[] overworldGoalInstances = GetOverworldGoalInstances();
			if (overworldGoalInstances != null && levels != null)
			{
				goals = overworldGoalInstances.Where((OverworldGoal g) => g != null && !g.isSkipping && levels.Contains(g.levelData)).ToList();
			}
			usingGoals = true;
		}
		UpdateState();
		onAreaStateChanged?.Invoke(areaState);
		if (plate != null)
		{
			plate.OnStateChange += delegate
			{
				ShowText();
			};
		}
		if (OverworldManager2d.Instance != null)
		{
			OverworldManager2d.Instance.OnToggleOverworld += UpdateState;
		}
		yield return null;
	}

	private OverworldGoal[] GetOverworldGoalInstances()
	{
		if (overworldGoalCache == null)
		{
			overworldGoalCache = UnityEngine.Object.FindObjectsOfType<OverworldGoal>();
			SceneManager.sceneUnloaded += onSceneUnloaded;
		}
		return overworldGoalCache;
	}

	private static void onSceneUnloaded(Scene scene)
	{
		if (scene.name == "main overworld")
		{
			ClearOverworldGoalCache();
			SceneManager.sceneUnloaded -= onSceneUnloaded;
		}
	}

	private static void ClearOverworldGoalCache()
	{
		overworldGoalCache = null;
	}

	private void UpdateState()
	{
		if (levels != null || goals != null)
		{
			Tuple<int, int> completedAnCrowns = GetCompletedAnCrowns();
			if (completedAnCrowns != null)
			{
				areaState = GetState(completedAnCrowns.Item1, completedAnCrowns.Item2);
				onAreaStateChanged?.Invoke(areaState);
			}
		}
	}

	private Tuple<int, int> GetCompletedAnCrowns()
	{
		if (usingGoals && goals != null)
		{
			int item = goals.Count((OverworldGoal l) => l != null && l.IsCompleted());
			int item2 = goals.Count((OverworldGoal g) => g != null && g.IsFullyCompleted());
			return new Tuple<int, int>(item, item2);
		}
		if (levels != null)
		{
			int item3 = levels.Count((LevelData l) => l != null && l.IsCompletedInSaveGame);
			int item4 = levels.Count((LevelData l) => l != null && l.Challenges != null && l.Challenges.Count >= 1 && l.HasCompletedAllChallenges());
			return new Tuple<int, int>(item3, item4);
		}
		return new Tuple<int, int>(0, 0);
	}

	private void UpdateState(bool overworld)
	{
		if (overworld)
		{
			UpdateState();
		}
	}

	private IEnumerator AnimateIn()
	{
		if (Name == AreaIDEnum.INTRO_10 || isAnimating || Container == null)
		{
			yield break;
		}
		isAnimating = true;
		Container.gameObject.SetActive(true);
		if (Tip != null)
		{
			Tip.SetActive(false);
		}
		yield return StartCoroutine(pTween.To(0.25f, delegate(float t)
		{
			if (Container != null)
			{
				float d = Mathf.Lerp(0f, 1.2f, t * t);
				Container.transform.localScale = Vector3.one * d;
			}
			if (t > 0.5f && Tip != null)
			{
				Tip.SetActive(true);
			}
		}));
		yield return new WaitForSeconds(1.5f);
		yield return StartCoroutine(pTween.To(0.2f, delegate(float t)
		{
			if (Container != null)
			{
				float d2 = Mathf.Lerp(1.2f, 0f, t * t);
				Container.transform.localScale = Vector3.one * d2;
			}
			if (t > 0.5f && Tip != null)
			{
				Tip.SetActive(false);
			}
		}));
		if (Container != null)
		{
			Container.gameObject.SetActive(false);
		}
		isAnimating = false;
		yield return null;
	}

	private void OnDisable()
	{
		StopAllCoroutines();
		if (!(Container == null))
		{
			Container.transform.localScale = Vector3.zero;
			if (Tip != null)
			{
				Tip.SetActive(false);
			}
			Container.gameObject.SetActive(false);
			isAnimating = false;
			OnAnimationDone();
		}
	}

	public void ShowText()
	{
		if (levels == null)
		{
			Debug.LogWarning("No levels on PlateInfoManager " + Name.ToString() + " on " + ((base.gameObject != null) ? base.gameObject.ToString() : null));
			return;
		}
		Tuple<int, int> completedAnCrowns = GetCompletedAnCrowns();
		if (completedAnCrowns == null)
		{
			return;
		}
		int item = completedAnCrowns.Item1;
		int item2 = completedAnCrowns.Item2;
		AreaState state = GetState(item, item2);
		onAreaStateChanged?.Invoke(state);
		if (Text == null || DefaultIcon == null || CrownIcon == null || ABTransition == null || BCTransition == null || text == null)
		{
			return;
		}
		if ((int)state >= 2 && state != areaState)
		{
			Text.SetActive(false);
			DefaultIcon.SetActive(false);
			CrownIcon.SetActive(false);
			ABTransition.SetActive(state == AreaState.LEVELS_COMLETE);
			BCTransition.SetActive(state == AreaState.CHALLENGES_COMPLETE);
			areaState = state;
			StartCoroutine(AnimateIn());
			return;
		}
		areaState = state;
		Text.SetActive(true);
		ABTransition.SetActive(false);
		BCTransition.SetActive(false);
		if (areaState == AreaState.LEVELS_COMLETE && item2 >= 1)
		{
			DefaultIcon.SetActive(false);
			CrownIcon.SetActive(true);
		}
		else if (areaState == AreaState.LEVELS_COMLETE && item2 == 0)
		{
			Text.SetActive(false);
			ABTransition.SetActive(true);
			DefaultIcon.SetActive(false);
			CrownIcon.SetActive(false);
		}
		else if (areaState == AreaState.CHALLENGES_COMPLETE)
		{
			Text.SetActive(false);
			BCTransition.SetActive(true);
			DefaultIcon.SetActive(false);
			CrownIcon.SetActive(false);
		}
		else
		{
			DefaultIcon.SetActive(true);
			CrownIcon.SetActive(false);
		}
		text.text = (((int)areaState < 2) ? item : item2).ToString();
		text.text = text.text + "/" + levels.Count;
		StartCoroutine(AnimateIn());
	}

	public void OnAnimationDone()
	{
		if (BubbleAnimator != null)
		{
			BubbleAnimator.SetBool("AB", false);
			BubbleAnimator.SetBool("BC", false);
		}
		if (Container != null)
		{
			Container.SetActive(true);
		}
	}

	private AreaState GetState(int completed, int crowns)
	{
		if (completed == 0)
		{
			return AreaState.DOOR_CLOSED;
		}
		AreaState result = AreaState.DOOR_OPEN;
		if (plate != null && plate.isOn)
		{
			result = AreaState.LEVELS_COMLETE;
		}
		if (SaveGame.GetIsChestUnlocked(chestID.ToString()))
		{
			return AreaState.CHALLENGES_COMPLETE;
		}
		return result;
	}

	private static string SectionID(AreaIDEnum id)
	{
		string[] array = id.ToString().Split('_');
		if (array.Length > 1)
		{
			return array[1];
		}
		return array[0];
	}
}
