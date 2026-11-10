using System.Collections.Generic;
using System.Linq;
using CameraStack;
using Core;
using UnityEngine;
using UnityEngine.UI;

public class PrizeController : MonoBehaviour
{
	[SerializeField]
	private DailyPrizeData PrizeData;

	private List<Transform> positions;

	[SerializeField]
	private Transform positionContainer;

	private List<DailyPrize> placedPrized = new List<DailyPrize>();

	[SerializeField]
	private WinSceneUI winSceneUI;

	[SerializeField]
	private GameObject LockedCube;

	[SerializeField]
	private AnimateRectTransform ReplayBtn;

	[SerializeField]
	private Image LeftPan;

	[SerializeField]
	private Image RightPan;

	[SerializeField]
	private Image LeftPanController;

	[SerializeField]
	private Image RightPanController;

	[SerializeField]
	private List<Image> LeftPanController_c;

	[SerializeField]
	private List<Image> RightPanController_c;

	[SerializeField]
	private CameraBehavior cameraBehaviour;

	[SerializeField]
	private float leftMin;

	[SerializeField]
	private float leftMax;

	[SerializeField]
	private float rightMin;

	[SerializeField]
	private float rightMax;

	[SerializeField]
	private float leftMin_s;

	[SerializeField]
	private float leftMax_s;

	[SerializeField]
	private float rightMin_s;

	[SerializeField]
	private float rightMax_s;

	private float panTimer;

	[SerializeField]
	private float panTimerThres = 0.5f;

	private int LastViewablePedistal;

	private int TotalNumberOfPedistals;

	private Vector2 LastDir;

	private List<GolfBallController> controllers = new List<GolfBallController>();

	public bool showAll;

	public string showThis;

	public bool didUnpackPrize;

	public string lastPackReceived;

	private void OnDrawGizmos()
	{
		Gizmos.color = Color.red;
		if (positionContainer != null)
		{
			foreach (Transform child in positionContainer)
			{
				if (child != null)
				{
					Gizmos.DrawSphere(child.position, 3f);
				}
			}
		}
	}

	private Transform GetPosition(int i)
	{
		if (positions == null || positions.Count == 0)
			return null;
		int idx = i % positions.Count;
		if (idx < 0)
			idx += positions.Count;
		return positions[idx];
	}

	private DailyPrize PlacePrize(DailyPrizeData.Prize prize, Transform p, bool isWrapped, bool permanentlyLocked = false)
	{
		if (prize == null || prize.prefab == null || p == null)
			return null;

		GameObject inst = Instantiate(prize.prefab, p);
		PrizeMountain pm = inst.GetComponent<PrizeMountain>();
		if (pm == null || pm.prize == null)
			return null;

		pm.prize.Place(isWrapped);
		if (controllers != null && pm.controller != null)
		{
			controllers.Add(pm.controller);
		}
		if (isWrapped)
		{
			pm.prize.Lock(permanentlyLocked);
		}
		if (permanentlyLocked)
		{
			pm.prize.AddEventToCounter(OnCounterReachZero);
		}
		if (placedPrized != null)
		{
			placedPrized.Add(pm.prize);
		}
		return pm.prize;
	}

	private DailyPrizeData.Prize TodaysPrize(List<DailyPrizeData.Prize> savedPrizes)
	{
		if (DailyChallenges.Instance == null || DailyChallenges.Instance.lastPackPlayed == null)
			return null;

		var pack = DailyChallenges.Instance.lastPackPlayed;
		if (pack.IsSpecial)
		{
			if (!ShouldGiveSpecialDayPack(savedPrizes))
				return null;
			return pack.mountain_prize_prefab;
		}
		return GetNextPrize(savedPrizes);
	}

	private void Start()
	{
		showAll = false;
		if (positionContainer == null)
			return;

		var meshRenderers = positionContainer.GetComponentsInChildren<MeshRenderer>();
		positions = meshRenderers
			.Where(m => m != null)
			.Select(m => m.transform)
			.OrderBy(a => a != null && a.root != null ? a.root.position.x : 0f)
			.ToList();

		if (PrizeData == null)
			return;

		var savedStrings = SaveGame.DailyPrizes ?? new List<string>();
		var savedPrizes = savedStrings
			.Select(s => PrizeData.GetPrize(s))
			.Where(a => a != null)
			.ToList();

		for (int i = 0; i < savedPrizes.Count; i++)
		{
			Transform pos = GetPosition(i);
			if (pos != null)
			{
				PlacePrize(savedPrizes[i], pos, false, false);
			}
		}

		bool didPlaceToday = false;
		bool hadAlreadyPlayed = false;

		if (DailyChallenges.Instance != null &&
		    (DailyChallenges.Instance.NewPackWasCompletedToday || ShouldGiveSpecialDayPack(savedPrizes)))
		{
			DailyChallenges.Instance.NewPackWasCompletedToday = false;
			var todayPrize = TodaysPrize(savedPrizes);
			if (todayPrize != null && todayPrize.prefab != null)
			{
				Transform pos = GetPosition(savedPrizes.Count);
				if (!showAll)
				{
					SaveGame.AddAnimal(todayPrize.ID);
				}
				SaveGame.Save();
				savedPrizes.Add(todayPrize);
				DailyPrize dp = PlacePrize(todayPrize, pos, true, false);
				if (winSceneUI != null && dp != null)
				{
					winSceneUI.LockUI(dp);
				}
				didPlaceToday = true;
			}
		}
		else
		{
			hadAlreadyPlayed = true;
		}

		if (savedPrizes.Count > 0)
		{
			var lastP = savedPrizes.Last();
			lastPackReceived = lastP != null ? lastP.ID : "";
		}
		else
		{
			lastPackReceived = "";
		}

		didUnpackPrize = didPlaceToday;
		if (!didPlaceToday && winSceneUI != null)
		{
			winSceneUI.InitUI();
		}

		var lastNormal = savedPrizes.LastOrDefault(a => a is DailyPrizeData.NormalPrize) as DailyPrizeData.NormalPrize;
		var nextNormal = PrizeData.GetNextNormalPrize(lastNormal);
		DailyPrizeData.Prize lockedPrize = nextNormal != null ? PrizeData.LockedMountainPrize : PrizeData.EndPrizeMountain;
		Transform nextPos = GetPosition(savedPrizes.Count);
		if (lockedPrize != null && nextPos != null)
		{
			PlacePrize(lockedPrize, nextPos, true, true);
		}

		int offset = (hadAlreadyPlayed || didPlaceToday) ? 1 : 0;
		LastViewablePedistal = Mathf.Max(0, savedPrizes.Count - offset);
		TotalNumberOfPedistals = savedPrizes.Count;

		if (!hadAlreadyPlayed && !didPlaceToday && RightPan != null)
		{
			DimImage(RightPan, 0.5f);
		}
		if (LastViewablePedistal == 0 && LeftPan != null)
		{
			DimImage(LeftPan, 0.5f);
		}

		ActivatePedistal();

		if (controllers != null)
		{
			controllers.ForEach(c =>
			{
				if (c != null)
				{
					c.OnAimUpdate += (b, s) => OnAimUpdate(b, s, c);
					c.OnShoot += b => OnShoot(b, c);
				}
			});
		}

		if (PlatformSettings.IsSwitch)
		{
			if (RightPanController != null)
			{
				Color col = RightPanController.color;
				col.a = Mathf.Clamp(col.a + 1f, 0f, 1f);
				RightPanController.color = col;
			}
			if (LeftPanController != null)
			{
				Color col = LeftPanController.color;
				col.a = Mathf.Clamp(col.a + 1f, 0f, 1f);
				LeftPanController.color = col;
			}
			TactileArrowsOnSwitch();
		}
	}

	private bool ShouldGiveSpecialDayPack(List<DailyPrizeData.Prize> savedPrizes)
	{
		if (DailyChallenges.Instance == null || DailyChallenges.Instance.lastPackPlayed == null)
			return false;

		var pack = DailyChallenges.Instance.lastPackPlayed;
		if (!pack.IsSpecial || savedPrizes == null)
			return false;

		return !savedPrizes.Contains(pack.mountain_prize_prefab);
	}

	private void OnCounterReachZero()
	{
		if (ReplayBtn != null)
		{
			var tmp = ReplayBtn.GetComponentInChildren<TextMeshProLocalized>();
			if (tmp != null)
			{
				tmp.ChangeText("DAILY_NEXT_READY");
			}
		}
	}

	private void OnAimUpdate(Vector3 b, bool s, GolfBallController c)
	{
		if (!InputHelper.IsNavigatingWithController() || c == null)
			return;

		Vector2 dir = c.GetPlayerAxisDirection(raw: false, "AimHorizontal", "AimVertical") * 100f;
		LastDir = dir;
		panTimer += Time.deltaTime;

		if (!PlatformSettings.IsSwitch)
		{
			if (isRight_S(dir) && RightPanController != null)
			{
				DimImageStep(RightPanController, 0.2f);
			}
			if (isLeft_s(dir) && LeftPanController != null)
			{
				DimImageStep(LeftPanController, 0.2f);
			}
		}

		if (panTimer > panTimerThres - 0.2f)
		{
			if (isRight(dir))
			{
				if (RightPanController_c != null)
				{
					RightPanController_c.ForEach(g => DimImageStep(g, 0.2f));
				}
			}
			else if (isLeft(dir))
			{
				if (LeftPanController_c != null)
				{
					LeftPanController_c.ForEach(g => DimImageStep(g, 0.2f));
				}
			}
			else
			{
				panTimer = 0f;
			}
		}
	}

	private void OnShoot(Vector3 b, GolfBallController c)
	{
		if (!InputHelper.IsNavigatingWithController())
			return;

		if (panTimer > panTimerThres)
		{
			if (isRight(LastDir))
			{
				PanRight();
				return;
			}
			if (isLeft(LastDir))
			{
				PanLeft();
				return;
			}
		}

		panTimer = 0f;
		if (!PlatformSettings.IsSwitch)
		{
			if (RightPanController != null)
				DimImageStep(RightPanController, -1f);
			if (LeftPanController != null)
				DimImageStep(LeftPanController, -1f);
		}
		if (RightPanController_c != null)
		{
			RightPanController_c.ForEach(g => DimImageStep(g, -1f));
		}
		if (LeftPanController_c != null)
		{
			LeftPanController_c.ForEach(g => DimImageStep(g, -1f));
		}
	}

	private void TactileArrowsOnSwitch()
	{
		if (LeftPanController != null)
		{
			var btn = LeftPanController.gameObject.AddComponent<Button>();
			if (btn != null && btn.onClick != null)
				btn.onClick.AddListener(PanLeft);
		}
		if (RightPanController != null)
		{
			var btn = RightPanController.gameObject.AddComponent<Button>();
			if (btn != null && btn.onClick != null)
				btn.onClick.AddListener(PanRight);
		}
	}

	private bool isLeft(Vector2 v)
	{
		return v.x > leftMin && v.x < leftMax;
	}

	private bool isRight(Vector2 v)
	{
		return v.x > rightMin && v.x < rightMax;
	}

	private bool isLeft_s(Vector2 v)
	{
		return v.x > leftMin_s && v.x < leftMax_s;
	}

	private bool isRight_S(Vector2 v)
	{
		return v.x > rightMin_s && v.x < rightMax_s;
	}

	private void Update()
	{
		if (!InputHelper.IsNavigatingWithController())
			return;

		if (!PlatformSettings.IsSwitch)
		{
			if (RightPanController != null)
				DimImageStep(RightPanController, -0.1f);
			if (LeftPanController != null)
				DimImageStep(LeftPanController, -0.1f);
		}
		if (RightPanController_c != null)
		{
			RightPanController_c.ForEach(g => DimImageStep(g, -0.1f));
		}
		if (LeftPanController_c != null)
		{
			LeftPanController_c.ForEach(g => DimImageStep(g, -0.1f));
		}
	}

	private DailyPrizeData.Prize GetNextPrize(List<DailyPrizeData.Prize> savePrized)
	{
		if (PrizeData == null)
			return null;

		DailyPrizeData.NormalPrize lastNormal = null;
		if (savePrized != null)
		{
			lastNormal = savePrized
				.Where(a => a is DailyPrizeData.NormalPrize)
				.DefaultIfEmpty(null)
				.Last() as DailyPrizeData.NormalPrize;
		}
		return PrizeData.GetNextNormalPrize(lastNormal);
	}

	public void PanLeft()
	{
		if (LastViewablePedistal > 0)
		{
			LastViewablePedistal--;
		}
		if (LastViewablePedistal == 0)
		{
			DimImage(LeftPan, 0.5f);
		}
		DimImage(RightPan, 1f);
		ActivatePedistal();
	}

	public void PanRight()
	{
		if (LastViewablePedistal < TotalNumberOfPedistals)
		{
			LastViewablePedistal++;
		}
		if (LastViewablePedistal == TotalNumberOfPedistals)
		{
			DimImage(RightPan, 0.5f);
		}
		DimImage(LeftPan, 1f);
		ActivatePedistal();
	}

	public void SetControllerActive(bool b)
	{
		if (placedPrized != null && LastViewablePedistal >= 0 && LastViewablePedistal < placedPrized.Count)
		{
			var prize = placedPrized[LastViewablePedistal];
			if (prize != null)
			{
				prize.SetControllerActive(b);
			}
		}
	}

	private void ActivatePedistal()
	{
		if (placedPrized != null)
		{
			for (int i = placedPrized.Count - 1; i >= 0; i--)
			{
				if (placedPrized[i] != null)
				{
					placedPrized[i].Activate(i == LastViewablePedistal);
				}
			}
		}
		if (MainAudioListener.Instance != null)
		{
			MainAudioListener.Instance.OnCameraBehaviourChanged(cameraBehaviour);
		}
	}

	private void DimImage(Image i, float a)
	{
		if (i == null)
			return;

		Color startCol = i.color;
		Color targetCol = new Color(startCol.r, startCol.g, startCol.b, a);
		StartCoroutine(pTween.To(0.3f, t =>
		{
			if (i != null)
			{
				i.color = Color.Lerp(startCol, targetCol, t);
			}
		}));
	}

	private void DimImageStep(Image i, float step)
	{
		if (i == null)
			return;

		Color c = i.color;
		c.a = Mathf.Clamp(c.a + step, 0f, 1f);
		i.color = c;
	}
}
