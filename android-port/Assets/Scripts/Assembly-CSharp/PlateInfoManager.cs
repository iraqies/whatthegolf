using System;
using System.Collections;
using System.Collections.Generic;
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
	}

	private IEnumerator StartAfter()
	{
		return null;
	}

	private OverworldGoal[] GetOverworldGoalInstances()
	{
		return null;
	}

	private static void onSceneUnloaded(Scene scene)
	{
	}

	private static void ClearOverworldGoalCache()
	{
	}

	private void UpdateState()
	{
	}

	private Tuple<int, int> GetCompletedAnCrowns()
	{
		return null;
	}

	private void UpdateState(bool overworld)
	{
	}

	private IEnumerator AnimateIn()
	{
		return null;
	}

	private void OnDisable()
	{
	}

	public void ShowText()
	{
	}

	public void OnAnimationDone()
	{
	}

	private AreaState GetState(int completed, int crowns)
	{
		return AreaState.DOOR_CLOSED;
	}

	private static string SectionID(AreaIDEnum id)
	{
		return null;
	}
}
