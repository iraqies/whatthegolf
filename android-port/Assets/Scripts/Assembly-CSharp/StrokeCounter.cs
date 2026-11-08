using System;
using System.Collections.Generic;
using Core;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StrokeCounter : MonoBehaviour
{
	public class Stroke
	{
		public RectTransform StrokeRect;

		public Image Image;

		public TextMeshProUGUI Text;

		public float AppearTimer;

		public bool Disappearing;

		public bool AppearSoundHasPlayed;

		public int CurrentIndex => 0;

		public void Reset()
		{
			AppearTimer = 0f;
			Disappearing = false;
			AppearSoundHasPlayed = false;
			if (StrokeRect != null)
				StrokeRect.gameObject.SetActive(false);
		}
	}

	public class PlayerStrokeData
	{
		public List<Stroke> CurrentStrokes = new List<Stroke>();

		public Queue<Stroke> AvailableStrokeTransforms = new Queue<Stroke>();

		public Stroke LastStroke;

		public bool PlayerActive;

		public int TotalStrokes;

		public int InitialStrokes;

		public bool HasInitialStrokes;
	}

	public enum CounterTypes
	{
		CardsAppearing = 0,
		CardsDisappearing = 1
	}

	[SerializeField]
	private RectTransform strokeAppearPosition;

	[SerializeField]
	private Vector2 cardPositionOffset = new Vector2(0f, -50f);

	[SerializeField]
	private GameObject playerStrokesContainer;

	[SerializeField]
	private float positionChangeSpeed = 10f;

	[SerializeField]
	private float appearSpeed = 8f;

	[SerializeField]
	private float scaleChangeForCurrent = 1.2f;

	[SerializeField]
	private AnimationCurve appearCurve;

	[SerializeField]
	private RectTransform container;

	[SerializeField]
	private List<Color> PlayerColors;

	[SerializeField]
	private List<AudioClip> appearClips;

	[SerializeField]
	private float appearVolume = 0.5f;

	[SerializeField]
	private float appearDelay;

	public float scaleMod = 1f;

	public CounterTypes CounterType;

	public bool UseExternalCountActivator;

	public float SafeAreaMod;

	public RectTransform LeaderCrown;

	private Animator leaderCrownAnimator;

	public Action<int, int> OnStrokeUpdated;

	private Dictionary<int, PlayerStrokeData> playerData = new Dictionary<int, PlayerStrokeData>();

	private Transform[] playerContainers;

	private List<Stroke> toBeRemoved = new List<Stroke>();

	private List<GolfBallController> subscribedControllers = new List<GolfBallController>();

	private readonly int MAXPLAYERS = 2;

	private Vector3 baseOffsetMax;

	private Vector3 crownTargetPosition;

	private Vector2 crownTargetPivot;

	private Vector3 crownVelRef;

	public void Awake()
	{
		HideTemplates();
	}

	public void Init()
	{
		HideTemplates();
		if (LevelManager.Exists && LevelManager.Instance != null)
		{
			LevelManager.Instance.OnLevelLoaded -= Instance_OnLevelLoaded;
			LevelManager.Instance.OnLevelLoaded += Instance_OnLevelLoaded;
			LevelManager.Instance.OnLevelWillUnload -= Instance_OnLevelWillUnload;
			LevelManager.Instance.OnLevelWillUnload += Instance_OnLevelWillUnload;
		}
	}

	private void HideTemplates()
	{
		if (strokeAppearPosition != null)
			strokeAppearPosition.gameObject.SetActive(false);
		if (playerStrokesContainer != null)
			playerStrokesContainer.SetActive(false);
		if (LeaderCrown != null)
			LeaderCrown.gameObject.SetActive(false);
	}

	private void Instance_OnLevelWillUnload()
	{
		if (subscribedControllers != null)
		{
			for (int i = 0; i < subscribedControllers.Count; i++)
			{
				if (subscribedControllers[i] != null)
					subscribedControllers[i].OnPlayerHasShot -= Instance_OnGolfStroke;
			}
			subscribedControllers.Clear();
		}
		HideTemplates();
	}

	public void SetInitialStrokes(bool hasInitialStrokes, int strokes, int playerIndex)
	{
		HideTemplates();
	}

	public void MoveCrownToPlayer(int playerIndex)
	{
	}

	public void MoveToMiddle()
	{
	}

	public void Instance_OnLevelLoaded(LevelData data)
	{
		HideTemplates();
	}

	public void SubscribePlayerToStrokeCounter(GolfBallController controller, Color color)
	{
		if (controller != null && !subscribedControllers.Contains(controller))
		{
			subscribedControllers.Add(controller);
			controller.OnPlayerHasShot -= Instance_OnGolfStroke;
			controller.OnPlayerHasShot += Instance_OnGolfStroke;
		}
	}

	public void SubscribePlayerToStrokeCounter(GolfBallController controller)
	{
		SubscribePlayerToStrokeCounter(controller, Color.white);
	}

	private void Instance_OnGolfStroke(GolfBallController shooter, int strokes)
	{
		if (!UseExternalCountActivator && shooter != null)
			CountStroke(shooter.PlayerIndex, strokes);
	}

	public void CountStroke(int strokes)
	{
		CountStroke(0, strokes);
	}

	public void CountStroke(int playerIndex, int strokes)
	{
		OnStrokeUpdated?.Invoke(playerIndex, strokes);
	}

	public void RegisterShot(int playerIndex, int strokes)
	{
		OnStrokeUpdated?.Invoke(playerIndex, strokes);
	}

	public void RemoveCurrentStroke(int playerIndex)
	{
	}

	private void Update()
	{
	}

	public void TogglePlayer(int player, bool state, int order = -1)
	{
	}

	public void Reset(int resetToThis = 0)
	{
		Game.strokes = resetToThis;
		HideTemplates();
	}

	public void ToggleLeaderCrown(bool state)
	{
		if (LeaderCrown != null)
			LeaderCrown.gameObject.SetActive(state);
	}

	public void ResetForPlayer(int playerIndex, int resetToThis)
	{
		HideTemplates();
	}
}
