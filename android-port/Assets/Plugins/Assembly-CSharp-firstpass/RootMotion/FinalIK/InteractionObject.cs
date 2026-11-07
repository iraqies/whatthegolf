using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace RootMotion.FinalIK
{
	[Token(Token = "0x2000192")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000193")]
		public class InteractionEvent
		{
			[Token(Token = "0x4000AF1")]
			[FieldOffset(Offset = "0x10")]
			public float time;

			[Token(Token = "0x4000AF2")]
			[FieldOffset(Offset = "0x14")]
			public bool pause;

			[Token(Token = "0x4000AF3")]
			[FieldOffset(Offset = "0x15")]
			public bool pickUp;

			[Token(Token = "0x4000AF4")]
			[FieldOffset(Offset = "0x18")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x4000AF5")]
			[FieldOffset(Offset = "0x20")]
			public Message[] messages;

			[Token(Token = "0x4000AF6")]
			[FieldOffset(Offset = "0x28")]
			public UnityEvent unityEvent;

			[Token(Token = "0x6000BF1")]
			[Address(RVA = "0x134B1A0", Offset = "0x134B1A0", VA = "0x134B1A0")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x6000BF2")]
			[Address(RVA = "0x134B384", Offset = "0x134B384", VA = "0x134B384")]
			public InteractionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000194")]
		public class Message
		{
			[Token(Token = "0x4000AF7")]
			[FieldOffset(Offset = "0x10")]
			public string function;

			[Token(Token = "0x4000AF8")]
			[FieldOffset(Offset = "0x18")]
			public GameObject recipient;

			[Token(Token = "0x4000AF9")]
			private const string empty = "";

			[Token(Token = "0x6000BF3")]
			[Address(RVA = "0x134B278", Offset = "0x134B278", VA = "0x134B278")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x6000BF4")]
			[Address(RVA = "0x134B38C", Offset = "0x134B38C", VA = "0x134B38C")]
			public Message()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000195")]
		public class AnimatorEvent
		{
			[Token(Token = "0x4000AFA")]
			[FieldOffset(Offset = "0x10")]
			public Animator animator;

			[Token(Token = "0x4000AFB")]
			[FieldOffset(Offset = "0x18")]
			public Animation animation;

			[Token(Token = "0x4000AFC")]
			[FieldOffset(Offset = "0x20")]
			public string animationState;

			[Token(Token = "0x4000AFD")]
			[FieldOffset(Offset = "0x28")]
			public float crossfadeTime;

			[Token(Token = "0x4000AFE")]
			[FieldOffset(Offset = "0x2C")]
			public int layer;

			[Token(Token = "0x4000AFF")]
			[FieldOffset(Offset = "0x30")]
			public bool resetNormalizedTime;

			[Token(Token = "0x4000B00")]
			private const string empty = "";

			[Token(Token = "0x6000BF5")]
			[Address(RVA = "0x134AEE8", Offset = "0x134AEE8", VA = "0x134AEE8")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x6000BF6")]
			[Address(RVA = "0x134AFE8", Offset = "0x134AFE8", VA = "0x134AFE8")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x6000BF7")]
			[Address(RVA = "0x134B0B0", Offset = "0x134B0B0", VA = "0x134B0B0")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x6000BF8")]
			[Address(RVA = "0x134B18C", Offset = "0x134B18C", VA = "0x134B18C")]
			public AnimatorEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000196")]
		public class WeightCurve
		{
			[Serializable]
			[Token(Token = "0x2000197")]
			public enum Type
			{
				[Token(Token = "0x4000B04")]
				PositionWeight = 0,
				[Token(Token = "0x4000B05")]
				RotationWeight = 1,
				[Token(Token = "0x4000B06")]
				PositionOffsetX = 2,
				[Token(Token = "0x4000B07")]
				PositionOffsetY = 3,
				[Token(Token = "0x4000B08")]
				PositionOffsetZ = 4,
				[Token(Token = "0x4000B09")]
				Pull = 5,
				[Token(Token = "0x4000B0A")]
				Reach = 6,
				[Token(Token = "0x4000B0B")]
				RotateBoneWeight = 7,
				[Token(Token = "0x4000B0C")]
				Push = 8,
				[Token(Token = "0x4000B0D")]
				PushParent = 9,
				[Token(Token = "0x4000B0E")]
				PoserWeight = 10,
				[Token(Token = "0x4000B0F")]
				BendGoalWeight = 11
			}

			[Token(Token = "0x4000B01")]
			[FieldOffset(Offset = "0x10")]
			public Type type;

			[Token(Token = "0x4000B02")]
			[FieldOffset(Offset = "0x18")]
			public AnimationCurve curve;

			[Token(Token = "0x6000BF9")]
			[Address(RVA = "0x134B3D0", Offset = "0x134B3D0", VA = "0x134B3D0")]
			public float GetValue(float timer)
			{
				return default;
			}

			[Token(Token = "0x6000BFA")]
			[Address(RVA = "0x134B3FC", Offset = "0x134B3FC", VA = "0x134B3FC")]
			public WeightCurve()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000198")]
		public class Multiplier
		{
			[Token(Token = "0x4000B10")]
			[FieldOffset(Offset = "0x10")]
			public WeightCurve.Type curve;

			[Token(Token = "0x4000B11")]
			[FieldOffset(Offset = "0x14")]
			public float multiplier;

			[Token(Token = "0x4000B12")]
			[FieldOffset(Offset = "0x18")]
			public WeightCurve.Type result;

			[Token(Token = "0x6000BFB")]
			[Address(RVA = "0x134B394", Offset = "0x134B394", VA = "0x134B394")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default;
			}

			[Token(Token = "0x6000BFC")]
			[Address(RVA = "0x134B3EC", Offset = "0x134B3EC", VA = "0x134B3EC")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x4000AE8")]
		[FieldOffset(Offset = "0x18")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x4000AE9")]
		[FieldOffset(Offset = "0x20")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x4000AEA")]
		[FieldOffset(Offset = "0x28")]
		public Transform positionOffsetSpace;

		[Token(Token = "0x4000AEB")]
		[FieldOffset(Offset = "0x30")]
		public WeightCurve[] weightCurves;

		[Token(Token = "0x4000AEC")]
		[FieldOffset(Offset = "0x38")]
		public Multiplier[] multipliers;

		[Token(Token = "0x4000AED")]
		[FieldOffset(Offset = "0x40")]
		public InteractionEvent[] events;

		[Token(Token = "0x4000AEE")]
		[FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x36724", Offset = "0x36724")]
		private float length__BackingField;

		[Token(Token = "0x4000AEF")]
		[FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x36734", Offset = "0x36734")]
		private InteractionSystem lastUsedInteractionSystem__BackingField;

		[Token(Token = "0x4000AF0")]
		[FieldOffset(Offset = "0x58")]
		private InteractionTarget[] targets;

		[Token(Token = "0x1700018B")]
		public float length
		{
			[Token(Token = "0x6000BDD")]
			[Address(RVA = "0x13A1388", Offset = "0x13A1388", VA = "0x13A1388")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A44C", Offset = "0x3A44C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000BDE")]
			[Address(RVA = "0x13A1390", Offset = "0x13A1390", VA = "0x13A1390")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A45C", Offset = "0x3A45C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700018C")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x6000BDF")]
			[Address(RVA = "0x13A1398", Offset = "0x13A1398", VA = "0x13A1398")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A46C", Offset = "0x3A46C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BE0")]
			[Address(RVA = "0x13A13A0", Offset = "0x13A13A0", VA = "0x13A13A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A47C", Offset = "0x3A47C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700018D")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x6000BE2")]
			[Address(RVA = "0x13A15DC", Offset = "0x13A15DC", VA = "0x13A15DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700018E")]
		public Transform targetsRoot
		{
			[Token(Token = "0x6000BEA")]
			[Address(RVA = "0x13A0844", Offset = "0x13A0844", VA = "0x13A0844")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000BD5")]
		[Address(RVA = "0x13A1148", Offset = "0x13A1148", VA = "0x13A1148")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3A28C", Offset = "0x3A28C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000BD6")]
		[Address(RVA = "0x13A1190", Offset = "0x13A1190", VA = "0x13A1190")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3A2C4", Offset = "0x3A2C4")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000BD7")]
		[Address(RVA = "0x13A11D8", Offset = "0x13A11D8", VA = "0x13A11D8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3A2FC", Offset = "0x3A2FC")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000BD8")]
		[Address(RVA = "0x13A1220", Offset = "0x13A1220", VA = "0x13A1220")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3A334", Offset = "0x3A334")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000BD9")]
		[Address(RVA = "0x13A1268", Offset = "0x13A1268", VA = "0x13A1268")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3A36C", Offset = "0x3A36C")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000BDA")]
		[Address(RVA = "0x13A12B0", Offset = "0x13A12B0", VA = "0x13A12B0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3A3A4", Offset = "0x3A3A4")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000BDB")]
		[Address(RVA = "0x13A12F8", Offset = "0x13A12F8", VA = "0x13A12F8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3A3DC", Offset = "0x3A3DC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000BDC")]
		[Address(RVA = "0x13A1340", Offset = "0x13A1340", VA = "0x13A1340")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3A414", Offset = "0x3A414")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000BE1")]
		[Address(RVA = "0x13A13A8", Offset = "0x13A13A8", VA = "0x13A13A8")]
		public void Initiate()
		{
		}

		[Token(Token = "0x6000BE3")]
		[Address(RVA = "0x13A167C", Offset = "0x13A167C", VA = "0x13A167C")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x6000BE4")]
		[Address(RVA = "0x139F1DC", Offset = "0x139F1DC", VA = "0x139F1DC")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default;
		}

		[Token(Token = "0x6000BE5")]
		[Address(RVA = "0x13A181C", Offset = "0x13A181C", VA = "0x13A181C")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x6000BE6")]
		[Address(RVA = "0x139F07C", Offset = "0x139F07C", VA = "0x139F07C")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x6000BE7")]
		[Address(RVA = "0x139F1D4", Offset = "0x139F1D4", VA = "0x139F1D4")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x6000BE8")]
		[Address(RVA = "0x139F980", Offset = "0x139F980", VA = "0x139F980")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x6000BE9")]
		[Address(RVA = "0x13A0364", Offset = "0x13A0364", VA = "0x13A0364")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default;
		}

		[Token(Token = "0x6000BEB")]
		[Address(RVA = "0x13A1E50", Offset = "0x13A1E50", VA = "0x13A1E50")]
		private void Start()
		{
		}

		[Token(Token = "0x6000BEC")]
		[Address(RVA = "0x13A1898", Offset = "0x13A1898", VA = "0x13A1898")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x6000BED")]
		[Address(RVA = "0x13A1824", Offset = "0x13A1824", VA = "0x13A1824")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x6000BEE")]
		[Address(RVA = "0x13A1DE4", Offset = "0x13A1DE4", VA = "0x13A1DE4")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default;
		}

		[Token(Token = "0x6000BEF")]
		[Address(RVA = "0x13A1E54", Offset = "0x13A1E54", VA = "0x13A1E54")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default;
		}

		[Token(Token = "0x6000BF0")]
		[Address(RVA = "0x13A1EC0", Offset = "0x13A1EC0", VA = "0x13A1EC0")]
		public InteractionObject()
		{
		}
	}
}
