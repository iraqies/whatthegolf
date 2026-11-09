using UnityEngine;

namespace Chronos
{
	public abstract class Clock : MonoBehaviour
	{
		private bool enabledOnce;

		protected bool isLerping;

		protected float lerpStart;

		protected float lerpEnd;

		protected float lerpFrom;

		protected float lerpTo;

		[SerializeField]
		private float _localTimeScale;

		[SerializeField]
		private bool _paused;

		[SerializeField]
		private string _parentKey;

		private GlobalClock _parent;

		[SerializeField]
		private ClockBlend _parentBlend;

		public float localTimeScale
		{
			get => _localTimeScale > 0f ? _localTimeScale : 1f;
			set { _localTimeScale = value; timeScale = value; }
		}

		public float timeScale { get; protected set; }

		public float time { get; protected set; }

		public float unscaledTime { get; protected set; }

		public float deltaTime { get; protected set; }

		public float fixedDeltaTime { get; protected set; }

		public float startTime { get; protected set; }

		public bool paused
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public GlobalClock parent
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ClockBlend parentBlend
		{
			get
			{
				return ClockBlend.Multiplicative;
			}
			set
			{
			}
		}

		public TimeState state => TimeState.Accelerated;

		protected virtual void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		protected virtual void OnStartOrReEnable()
		{
		}

		protected virtual void Update()
		{
		}

		protected virtual void OnDisable()
		{
		}

		public virtual void ComputeTimeScale()
		{
		}

		public void LerpTimeScale(float timeScale, float duration, bool steady = false)
		{
		}
	}
}
