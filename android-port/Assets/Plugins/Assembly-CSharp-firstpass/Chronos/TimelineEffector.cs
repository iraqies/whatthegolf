using System.Collections.Generic;
using UnityEngine;

namespace Chronos
{
	public abstract class TimelineEffector : MonoBehaviour
	{
		protected internal const float DefaultRecordingInterval = 0.5f;

		private bool enabledOnce;

		[SerializeField]
		private float _recordingInterval;

		internal List<IComponentTimeline> components;

		protected abstract Timeline timeline { get; }

		public float recordingInterval
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public AnimationTimeline animation { get; protected set; }

		public AnimatorTimeline animator { get; protected set; }

		public List<AudioSourceTimeline> audioSources { get; protected set; }

		public AudioSourceTimeline audioSource { get; protected set; }

		public NavMeshAgentTimeline navMeshAgent { get; protected set; }

		public IParticleSystemTimeline particleSystem { get; protected set; }

		public RigidbodyTimeline3D rigidbody { get; protected set; }

		public RigidbodyTimeline2D rigidbody2D { get; protected set; }

		public new TransformTimeline transform { get; protected set; }

		public TrailRendererTimeline trailRenderer { get; protected set; }

		protected IRecorder recorder => null;

		public TimelineEffector()
		{
		}

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

		protected virtual void FixedUpdate()
		{
		}

		protected virtual void OnDisable()
		{
		}

		public virtual void CacheComponents()
		{
		}

		public virtual void Reset()
		{
		}

		public void ResetRecording()
		{
		}

		public int EstimateMemoryUsage()
		{
			return 0;
		}
	}
}
