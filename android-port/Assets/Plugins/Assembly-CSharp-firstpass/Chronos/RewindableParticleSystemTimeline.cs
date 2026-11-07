using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Chronos
{
	[Token(Token = "0x20002B4")]
	public class RewindableParticleSystemTimeline : ComponentTimeline<ParticleSystem>, IParticleSystemTimeline, IComponentTimeline
	{
		[Token(Token = "0x20002B5")]
		private enum State
		{
			[Token(Token = "0x400118E")]
			Playing = 0,
			[Token(Token = "0x400118F")]
			Paused = 1,
			[Token(Token = "0x4001190")]
			Stopping = 2,
			[Token(Token = "0x4001191")]
			Stopped = 3
		}

		[Token(Token = "0x20002B6")]
		private enum EmissionAction
		{
			[Token(Token = "0x4001193")]
			EnableEmission = 0,
			[Token(Token = "0x4001194")]
			DisableEmission = 1,
			[Token(Token = "0x4001195")]
			Play = 2,
			[Token(Token = "0x4001196")]
			Stop = 3
		}

		[Token(Token = "0x20002B7")]
		private struct StateEvent
		{
			[Token(Token = "0x4001197")]
			[FieldOffset(Offset = "0x0")]
			public State state;

			[Token(Token = "0x4001198")]
			[FieldOffset(Offset = "0x4")]
			public float time;

			[Token(Token = "0x6001227")]
			[Address(RVA = "0x135525C", Offset = "0x135525C", VA = "0x135525C")]
			public StateEvent(State state, float time)
			{
			}
		}

		[Token(Token = "0x20002B8")]
		private struct EmissionEvent
		{
			[Token(Token = "0x4001199")]
			[FieldOffset(Offset = "0x0")]
			public EmissionAction action;

			[Token(Token = "0x400119A")]
			[FieldOffset(Offset = "0x4")]
			public float time;
		}

		[Token(Token = "0x4001183")]
		[FieldOffset(Offset = "0x20")]
		private float absoluteSimulationTime;

		[Token(Token = "0x4001184")]
		[FieldOffset(Offset = "0x24")]
		private float loopedSimulationTime;

		[Token(Token = "0x4001185")]
		[FieldOffset(Offset = "0x28")]
		private float relativeStartTime;

		[Token(Token = "0x4001186")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x37500", Offset = "0x37500")]
		private float playbackSpeed__BackingField;

		[Token(Token = "0x4001187")]
		[FieldOffset(Offset = "0x30")]
		private List<StateEvent> stateEvents;

		[Token(Token = "0x4001188")]
		[FieldOffset(Offset = "0x38")]
		private State stateOnStart;

		[Token(Token = "0x4001189")]
		[FieldOffset(Offset = "0x40")]
		private List<EmissionEvent> emissionEvents;

		[Token(Token = "0x400118A")]
		[FieldOffset(Offset = "0x48")]
		private bool enableEmissionOnStart;

		[Token(Token = "0x400118B")]
		[FieldOffset(Offset = "0x4C")]
		private State _state;

		[Token(Token = "0x400118C")]
		[FieldOffset(Offset = "0x50")]
		private bool _enableEmission;

		[Token(Token = "0x17000248")]
		public float playbackSpeed
		{
			[Token(Token = "0x600121B")]
			[Address(RVA = "0x13DC344", Offset = "0x13DC344", VA = "0x13DC344", Slot = "19")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3BB1C", Offset = "0x3BB1C")]
			get
			{
				return default;
			}
			[Token(Token = "0x600121C")]
			[Address(RVA = "0x13DC34C", Offset = "0x13DC34C", VA = "0x13DC34C", Slot = "20")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3BB2C", Offset = "0x3BB2C")]
			set
			{
			}
		}

		[Token(Token = "0x17000249")]
		public float time
		{
			[Token(Token = "0x600121D")]
			[Address(RVA = "0x13DC354", Offset = "0x13DC354", VA = "0x13DC354", Slot = "21")]
			set
			{
			}
		}

		[Token(Token = "0x1700024A")]
		private float stateEventsTime
		{
			[Token(Token = "0x600121E")]
			[Address(RVA = "0x13DC364", Offset = "0x13DC364", VA = "0x13DC364")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700024B")]
		private float emissionEventsTime
		{
			[Token(Token = "0x600121F")]
			[Address(RVA = "0x13DC3B0", Offset = "0x13DC3B0", VA = "0x13DC3B0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700024C")]
		private State state
		{
			[Token(Token = "0x6001222")]
			[Address(RVA = "0x13DC56C", Offset = "0x13DC56C", VA = "0x13DC56C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001223")]
			[Address(RVA = "0x13DC574", Offset = "0x13DC574", VA = "0x13DC574")]
			set
			{
			}
		}

		[Token(Token = "0x6001220")]
		[Address(RVA = "0x13DC3B8", Offset = "0x13DC3B8", VA = "0x13DC3B8")]
		private void RegisterState(State state)
		{
		}

		[Token(Token = "0x6001221")]
		[Address(RVA = "0x13DC46C", Offset = "0x13DC46C", VA = "0x13DC46C")]
		public RewindableParticleSystemTimeline(Timeline timeline, ParticleSystem component)
		{
		}

		[Token(Token = "0x6001224")]
		[Address(RVA = "0x13DC764", Offset = "0x13DC764", VA = "0x13DC764", Slot = "16")]
		public override void CopyProperties(ParticleSystem source)
		{
		}

		[Token(Token = "0x6001225")]
		[Address(RVA = "0x13DC8E4", Offset = "0x13DC8E4", VA = "0x13DC8E4", Slot = "13")]
		public override void Update()
		{
		}

		[Token(Token = "0x6001226")]
		[Address(RVA = "0x13DC5F4", Offset = "0x13DC5F4", VA = "0x13DC5F4")]
		private bool AssertForwardProperty(string property, Severity severity)
		{
			return default;
		}
	}
}
