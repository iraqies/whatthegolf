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
		}
	}

	public class PlayerStrokeData
	{
		public List<Stroke> CurrentStrokes;

		public Queue<Stroke> AvailableStrokeTransforms;

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
	private Vector2 cardPositionOffset;

	[SerializeField]
	private GameObject playerStrokesContainer;

	[SerializeField]
	private float positionChangeSpeed;

	[SerializeField]
	private float appearSpeed;

	[SerializeField]
	private float scaleChangeForCurrent;

	[SerializeField]
	private AnimationCurve appearCurve;

	[SerializeField]
	private RectTransform container;

	[SerializeField]
	private List<Color> PlayerColors;

	[SerializeField]
	private List<AudioClip> appearClips;

	[SerializeField]
	private float appearVolume;

	[SerializeField]
	private float appearDelay;

	public float scaleMod;

	public CounterTypes CounterType;

	public bool UseExternalCountActivator;

	public float SafeAreaMod;

	public RectTransform LeaderCrown;

	private Animator leaderCrownAnimator;

	public Action<int, int> OnStrokeUpdated;

	private Dictionary<int, PlayerStrokeData> playerData;

	private Transform[] playerContainers;

	private List<Stroke> toBeRemoved;

	private List<GolfBallController> subscribedControllers;

	private readonly int MAXPLAYERS;

	private Vector3 baseOffsetMax;

	private Vector3 crownTargetPosition;

	private Vector2 crownTargetPivot;

	private Vector3 crownVelRef;

	public void Awake()
	{
	}

	public void Init()
	{
	}

	private void Instance_OnLevelWillUnload()
	{
	}

	public void SetInitialStrokes(bool hasInitialStrokes, int strokes, int playerIndex)
	{
	}

	public void MoveCrownToPlayer(int playerIndex)
	{
	}

	public void MoveToMiddle()
	{
	}

	public void Instance_OnLevelLoaded(LevelData data)
	{
	}

	public void SubscribePlayerToStrokeCounter(GolfBallController controller, Color color)
	{
	}

	public void SubscribePlayerToStrokeCounter(GolfBallController controller)
	{
	}

	private void Instance_OnGolfStroke(GolfBallController shooter, int strokes)
	{
	}

	public void CountStroke(int strokes)
	{
	}

	public void CountStroke(int playerIndex, int strokes)
	{
	}

	public void RegisterShot(int playerIndex, int strokes)
	{
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
	}

	public void ToggleLeaderCrown(bool state)
	{
	}

	public void ResetForPlayer(int playerIndex, int resetToThis)
	{
	}
}
