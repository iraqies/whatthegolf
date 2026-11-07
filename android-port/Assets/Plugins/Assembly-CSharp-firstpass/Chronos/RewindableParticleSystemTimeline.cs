using System.Collections.Generic;
using UnityEngine;

namespace Chronos
{
	public class RewindableParticleSystemTimeline : ComponentTimeline<ParticleSystem>, IParticleSystemTimeline, IComponentTimeline
	{
		private enum State
		{
			Playing = 0,
			Paused = 1,
			Stopping = 2,
			Stopped = 3
		}

		private enum EmissionAction
		{
			EnableEmission = 0,
			DisableEmission = 1,
			Play = 2,
			Stop = 3
		}

		private struct StateEvent
		{
			public State state;

			public float time;

			public StateEvent(State state, float time)
			{
				this.state = State.Playing;
				this.time = 0f;
			}
		}

		private struct EmissionEvent
		{
			public EmissionAction action;

			public float time;
		}

		private float absoluteSimulationTime;

		private float loopedSimulationTime;

		private float relativeStartTime;

		private List<StateEvent> stateEvents;

		private State stateOnStart;

		private List<EmissionEvent> emissionEvents;

		private bool enableEmissionOnStart;

		private State _state;

		private bool _enableEmission;

		public float playbackSpeed { get; set; }

		public float time
		{
			set
			{
			}
		}

		private float stateEventsTime => 0f;

		private float emissionEventsTime => 0f;

		private State state
		{
			get
			{
				return State.Playing;
			}
			set
			{
			}
		}

		private void RegisterState(State state)
		{
		}

		public RewindableParticleSystemTimeline(Timeline timeline, ParticleSystem component)
			: base((Timeline)null, (ParticleSystem)null)
		{
		}

		public override void CopyProperties(ParticleSystem source)
		{
		}

		public override void Update()
		{
		}

		private bool AssertForwardProperty(string property, Severity severity)
		{
			return false;
		}
	}
}
