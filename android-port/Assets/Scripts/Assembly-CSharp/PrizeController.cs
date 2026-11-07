using System.Collections.Generic;
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

	private List<DailyPrize> placedPrized;

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
	private float panTimerThres;

	private int LastViewablePedistal;

	private int TotalNumberOfPedistals;

	private Vector2 LastDir;

	private List<GolfBallController> controllers;

	public bool showAll;

	public string showThis;

	public bool didUnpackPrize;

	public string lastPackReceived;

	private void OnDrawGizmos()
	{
	}

	private Transform GetPosition(int i)
	{
		return null;
	}

	private DailyPrize PlacePrize(DailyPrizeData.Prize prize, Transform p, bool isWrapped, bool permanentlyLocked = false)
	{
		return null;
	}

	private DailyPrizeData.Prize TodaysPrize(List<DailyPrizeData.Prize> savedPrizes)
	{
		return null;
	}

	private void Start()
	{
	}

	private bool ShouldGiveSpecialDayPack(List<DailyPrizeData.Prize> savedPrizes)
	{
		return false;
	}

	private void OnCounterReachZero()
	{
	}

	private void OnAimUpdate(Vector3 b, bool s, GolfBallController c)
	{
	}

	private void OnShoot(Vector3 b, GolfBallController c)
	{
	}

	private void TactileArrowsOnSwitch()
	{
	}

	private bool isLeft(Vector2 v)
	{
		return false;
	}

	private bool isRight(Vector2 v)
	{
		return false;
	}

	private bool isLeft_s(Vector2 v)
	{
		return false;
	}

	private bool isRight_S(Vector2 v)
	{
		return false;
	}

	private void Update()
	{
	}

	private DailyPrizeData.Prize GetNextPrize(List<DailyPrizeData.Prize> savePrized)
	{
		return null;
	}

	public void PanLeft()
	{
	}

	public void PanRight()
	{
	}

	public void SetControllerActive(bool b)
	{
	}

	private void ActivatePedistal()
	{
	}

	private void DimImage(Image i, float a)
	{
	}

	private void DimImageStep(Image i, float step)
	{
	}
}
