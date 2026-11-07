using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Serializable]
	[Token(Token = "0x200014B")]
	public class Grounding
	{
		[Serializable]
		[Token(Token = "0x200014C")]
		public enum Quality
		{
			[Token(Token = "0x400081F")]
			Fastest = 0,
			[Token(Token = "0x4000820")]
			Simple = 1,
			[Token(Token = "0x4000821")]
			Best = 2
		}

		[Token(Token = "0x200014D")]
		public class Leg
		{
			[Token(Token = "0x4000822")]
			[FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x35C6C", Offset = "0x35C6C")]
			private bool isGrounded__BackingField;

			[Token(Token = "0x4000823")]
			[FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x35C7C", Offset = "0x35C7C")]
			private Vector3 IKPosition__BackingField;

			[Token(Token = "0x4000824")]
			[FieldOffset(Offset = "0x20")]
			public Quaternion rotationOffset;

			[Token(Token = "0x4000825")]
			[FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x35C8C", Offset = "0x35C8C")]
			private bool initiated__BackingField;

			[Token(Token = "0x4000826")]
			[FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x35C9C", Offset = "0x35C9C")]
			private float heightFromGround__BackingField;

			[Token(Token = "0x4000827")]
			[FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x35CAC", Offset = "0x35CAC")]
			private Vector3 velocity__BackingField;

			[Token(Token = "0x4000828")]
			[FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x35CBC", Offset = "0x35CBC")]
			private Transform transform__BackingField;

			[Token(Token = "0x4000829")]
			[FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x35CCC", Offset = "0x35CCC")]
			private float IKOffset__BackingField;

			[Token(Token = "0x400082A")]
			[FieldOffset(Offset = "0x54")]
			public bool invertFootCenter;

			[Token(Token = "0x400082B")]
			[FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x35CDC", Offset = "0x35CDC")]
			private RaycastHit heelHit__BackingField;

			[Token(Token = "0x400082C")]
			[FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x35CEC", Offset = "0x35CEC")]
			private RaycastHit capsuleHit__BackingField;

			[Token(Token = "0x400082D")]
			[FieldOffset(Offset = "0xB0")]
			private Grounding grounding;

			[Token(Token = "0x400082E")]
			[FieldOffset(Offset = "0xB8")]
			private float lastTime;

			[Token(Token = "0x400082F")]
			[FieldOffset(Offset = "0xBC")]
			private float deltaTime;

			[Token(Token = "0x4000830")]
			[FieldOffset(Offset = "0xC0")]
			private Vector3 lastPosition;

			[Token(Token = "0x4000831")]
			[FieldOffset(Offset = "0xCC")]
			private Quaternion toHitNormal;

			[Token(Token = "0x4000832")]
			[FieldOffset(Offset = "0xDC")]
			private Quaternion r;

			[Token(Token = "0x4000833")]
			[FieldOffset(Offset = "0xEC")]
			private Vector3 up;

			[Token(Token = "0x4000834")]
			[FieldOffset(Offset = "0xF8")]
			private bool doOverrideFootPosition;

			[Token(Token = "0x4000835")]
			[FieldOffset(Offset = "0xFC")]
			private Vector3 overrideFootPosition;

			[Token(Token = "0x4000836")]
			[FieldOffset(Offset = "0x108")]
			private Vector3 transformPosition;

			[Token(Token = "0x17000130")]
			public bool isGrounded
			{
				[Token(Token = "0x600092B")]
				[Address(RVA = "0x133B098", Offset = "0x133B098", VA = "0x133B098")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3938C", Offset = "0x3938C")]
				get
				{
					return default;
				}
				[Token(Token = "0x600092C")]
				[Address(RVA = "0x133B0A0", Offset = "0x133B0A0", VA = "0x133B0A0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3939C", Offset = "0x3939C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000131")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x600092D")]
				[Address(RVA = "0x133B0A8", Offset = "0x133B0A8", VA = "0x133B0A8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x393AC", Offset = "0x393AC")]
				get
				{
					return default;
				}
				[Token(Token = "0x600092E")]
				[Address(RVA = "0x133B0B4", Offset = "0x133B0B4", VA = "0x133B0B4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x393BC", Offset = "0x393BC")]
				private set
				{
				}
			}

			[Token(Token = "0x17000132")]
			public bool initiated
			{
				[Token(Token = "0x600092F")]
				[Address(RVA = "0x133B0C0", Offset = "0x133B0C0", VA = "0x133B0C0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x393CC", Offset = "0x393CC")]
				get
				{
					return default;
				}
				[Token(Token = "0x6000930")]
				[Address(RVA = "0x133B0C8", Offset = "0x133B0C8", VA = "0x133B0C8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x393DC", Offset = "0x393DC")]
				private set
				{
				}
			}

			[Token(Token = "0x17000133")]
			public float heightFromGround
			{
				[Token(Token = "0x6000931")]
				[Address(RVA = "0x133B0D0", Offset = "0x133B0D0", VA = "0x133B0D0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x393EC", Offset = "0x393EC")]
				get
				{
					return default;
				}
				[Token(Token = "0x6000932")]
				[Address(RVA = "0x133B0D8", Offset = "0x133B0D8", VA = "0x133B0D8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x393FC", Offset = "0x393FC")]
				private set
				{
				}
			}

			[Token(Token = "0x17000134")]
			public Vector3 velocity
			{
				[Token(Token = "0x6000933")]
				[Address(RVA = "0x133B0E0", Offset = "0x133B0E0", VA = "0x133B0E0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3940C", Offset = "0x3940C")]
				get
				{
					return default;
				}
				[Token(Token = "0x6000934")]
				[Address(RVA = "0x133B0EC", Offset = "0x133B0EC", VA = "0x133B0EC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3941C", Offset = "0x3941C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000135")]
			public Transform transform
			{
				[Token(Token = "0x6000935")]
				[Address(RVA = "0x133B0F8", Offset = "0x133B0F8", VA = "0x133B0F8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3942C", Offset = "0x3942C")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000936")]
				[Address(RVA = "0x133B100", Offset = "0x133B100", VA = "0x133B100")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3943C", Offset = "0x3943C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000136")]
			public float IKOffset
			{
				[Token(Token = "0x6000937")]
				[Address(RVA = "0x133B108", Offset = "0x133B108", VA = "0x133B108")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3944C", Offset = "0x3944C")]
				get
				{
					return default;
				}
				[Token(Token = "0x6000938")]
				[Address(RVA = "0x133B110", Offset = "0x133B110", VA = "0x133B110")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3945C", Offset = "0x3945C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000137")]
			public RaycastHit heelHit
			{
				[Token(Token = "0x6000939")]
				[Address(RVA = "0x133B118", Offset = "0x133B118", VA = "0x133B118")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3946C", Offset = "0x3946C")]
				get
				{
					return default;
				}
				[Token(Token = "0x600093A")]
				[Address(RVA = "0x133B130", Offset = "0x133B130", VA = "0x133B130")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3947C", Offset = "0x3947C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000138")]
			public RaycastHit capsuleHit
			{
				[Token(Token = "0x600093B")]
				[Address(RVA = "0x133B150", Offset = "0x133B150", VA = "0x133B150")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3948C", Offset = "0x3948C")]
				get
				{
					return default;
				}
				[Token(Token = "0x600093C")]
				[Address(RVA = "0x133B168", Offset = "0x133B168", VA = "0x133B168")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3949C", Offset = "0x3949C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000139")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x6000941")]
				[Address(RVA = "0x133C258", Offset = "0x133C258", VA = "0x133C258")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x1700013A")]
			private float rootYOffset
			{
				[Token(Token = "0x600094A")]
				[Address(RVA = "0x133C3C4", Offset = "0x133C3C4", VA = "0x133C3C4")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x600093D")]
			[Address(RVA = "0x133B188", Offset = "0x133B188", VA = "0x133B188")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x600093E")]
			[Address(RVA = "0x133B21C", Offset = "0x133B21C", VA = "0x133B21C")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x600093F")]
			[Address(RVA = "0x133B26C", Offset = "0x133B26C", VA = "0x133B26C")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000940")]
			[Address(RVA = "0x133B2DC", Offset = "0x133B2DC", VA = "0x133B2DC")]
			public void Process()
			{
			}

			[Token(Token = "0x6000942")]
			[Address(RVA = "0x133BF24", Offset = "0x133BF24", VA = "0x133BF24")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default;
			}

			[Token(Token = "0x6000943")]
			[Address(RVA = "0x133BA14", Offset = "0x133BA14", VA = "0x133BA14")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default;
			}

			[Token(Token = "0x6000944")]
			[Address(RVA = "0x133C2EC", Offset = "0x133C2EC", VA = "0x133C2EC")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default;
			}

			[Token(Token = "0x6000945")]
			[Address(RVA = "0x133BC78", Offset = "0x133BC78", VA = "0x133BC78")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x6000946")]
			[Address(RVA = "0x133BD74", Offset = "0x133BD74", VA = "0x133BD74")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x6000947")]
			[Address(RVA = "0x133C360", Offset = "0x133C360", VA = "0x133C360")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default;
			}

			[Token(Token = "0x6000948")]
			[Address(RVA = "0x133C280", Offset = "0x133C280", VA = "0x133C280")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x6000949")]
			[Address(RVA = "0x133C458", Offset = "0x133C458", VA = "0x133C458")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default;
			}

			[Token(Token = "0x600094B")]
			[Address(RVA = "0x133C4EC", Offset = "0x133C4EC", VA = "0x133C4EC")]
			public Leg()
			{
			}
		}

		[Token(Token = "0x200014E")]
		public class Pelvis
		{
			[Token(Token = "0x4000837")]
			[FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x35CFC", Offset = "0x35CFC")]
			private Vector3 IKOffset__BackingField;

			[Token(Token = "0x4000838")]
			[FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x35D0C", Offset = "0x35D0C")]
			private float heightOffset__BackingField;

			[Token(Token = "0x4000839")]
			[FieldOffset(Offset = "0x20")]
			private Grounding grounding;

			[Token(Token = "0x400083A")]
			[FieldOffset(Offset = "0x28")]
			private Vector3 lastRootPosition;

			[Token(Token = "0x400083B")]
			[FieldOffset(Offset = "0x34")]
			private float damperF;

			[Token(Token = "0x400083C")]
			[FieldOffset(Offset = "0x38")]
			private bool initiated;

			[Token(Token = "0x400083D")]
			[FieldOffset(Offset = "0x3C")]
			private float lastTime;

			[Token(Token = "0x1700013B")]
			public Vector3 IKOffset
			{
				[Token(Token = "0x600094C")]
				[Address(RVA = "0x133C530", Offset = "0x133C530", VA = "0x133C530")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x394AC", Offset = "0x394AC")]
				get
				{
					return default;
				}
				[Token(Token = "0x600094D")]
				[Address(RVA = "0x133C53C", Offset = "0x133C53C", VA = "0x133C53C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x394BC", Offset = "0x394BC")]
				private set
				{
				}
			}

			[Token(Token = "0x1700013C")]
			public float heightOffset
			{
				[Token(Token = "0x600094E")]
				[Address(RVA = "0x133C548", Offset = "0x133C548", VA = "0x133C548")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x394CC", Offset = "0x394CC")]
				get
				{
					return default;
				}
				[Token(Token = "0x600094F")]
				[Address(RVA = "0x133C550", Offset = "0x133C550", VA = "0x133C550")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x394DC", Offset = "0x394DC")]
				private set
				{
				}
			}

			[Token(Token = "0x6000950")]
			[Address(RVA = "0x133C558", Offset = "0x133C558", VA = "0x133C558")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x6000951")]
			[Address(RVA = "0x133C5CC", Offset = "0x133C5CC", VA = "0x133C5CC")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000952")]
			[Address(RVA = "0x133C568", Offset = "0x133C568", VA = "0x133C568")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x6000953")]
			[Address(RVA = "0x133C638", Offset = "0x133C638", VA = "0x133C638")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x6000954")]
			[Address(RVA = "0x133C7E0", Offset = "0x133C7E0", VA = "0x133C7E0")]
			public Pelvis()
			{
			}
		}

		[Token(Token = "0x4000806")]
		[FieldOffset(Offset = "0x10")]
		public LayerMask layers;

		[Token(Token = "0x4000807")]
		[FieldOffset(Offset = "0x14")]
		public float maxStep;

		[Token(Token = "0x4000808")]
		[FieldOffset(Offset = "0x18")]
		public float heightOffset;

		[Token(Token = "0x4000809")]
		[FieldOffset(Offset = "0x1C")]
		public float footSpeed;

		[Token(Token = "0x400080A")]
		[FieldOffset(Offset = "0x20")]
		public float footRadius;

		[Token(Token = "0x400080B")]
		[FieldOffset(Offset = "0x24")]
		public float footCenterOffset;

		[Token(Token = "0x400080C")]
		[FieldOffset(Offset = "0x28")]
		public float prediction;

		[Token(Token = "0x400080D")]
		[FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x35BD0", Offset = "0x35BD0")]
		public float footRotationWeight;

		[Token(Token = "0x400080E")]
		[FieldOffset(Offset = "0x30")]
		public float footRotationSpeed;

		[Token(Token = "0x400080F")]
		[FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x35BE8", Offset = "0x35BE8")]
		public float maxFootRotationAngle;

		[Token(Token = "0x4000810")]
		[FieldOffset(Offset = "0x38")]
		public bool rotateSolver;

		[Token(Token = "0x4000811")]
		[FieldOffset(Offset = "0x3C")]
		public float pelvisSpeed;

		[Token(Token = "0x4000812")]
		[FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x35C04", Offset = "0x35C04")]
		public float pelvisDamper;

		[Token(Token = "0x4000813")]
		[FieldOffset(Offset = "0x44")]
		public float lowerPelvisWeight;

		[Token(Token = "0x4000814")]
		[FieldOffset(Offset = "0x48")]
		public float liftPelvisWeight;

		[Token(Token = "0x4000815")]
		[FieldOffset(Offset = "0x4C")]
		public float rootSphereCastRadius;

		[Token(Token = "0x4000816")]
		[FieldOffset(Offset = "0x50")]
		public bool overstepFallsDown;

		[Token(Token = "0x4000817")]
		[FieldOffset(Offset = "0x54")]
		public Quality quality;

		[Token(Token = "0x4000818")]
		[FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x35C1C", Offset = "0x35C1C")]
		private Leg[] legs__BackingField;

		[Token(Token = "0x4000819")]
		[FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x35C2C", Offset = "0x35C2C")]
		private Pelvis pelvis__BackingField;

		[Token(Token = "0x400081A")]
		[FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x35C3C", Offset = "0x35C3C")]
		private bool isGrounded__BackingField;

		[Token(Token = "0x400081B")]
		[FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x35C4C", Offset = "0x35C4C")]
		private Transform root__BackingField;

		[Token(Token = "0x400081C")]
		[FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x35C5C", Offset = "0x35C5C")]
		private RaycastHit rootHit__BackingField;

		[Token(Token = "0x400081D")]
		[FieldOffset(Offset = "0xA4")]
		private bool initiated;

		[Token(Token = "0x17000128")]
		public Leg[] legs
		{
			[Token(Token = "0x6000913")]
			[Address(RVA = "0x1380F0C", Offset = "0x1380F0C", VA = "0x1380F0C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x392EC", Offset = "0x392EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000914")]
			[Address(RVA = "0x1380F14", Offset = "0x1380F14", VA = "0x1380F14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x392FC", Offset = "0x392FC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000129")]
		public Pelvis pelvis
		{
			[Token(Token = "0x6000915")]
			[Address(RVA = "0x1380F1C", Offset = "0x1380F1C", VA = "0x1380F1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3930C", Offset = "0x3930C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000916")]
			[Address(RVA = "0x1380F24", Offset = "0x1380F24", VA = "0x1380F24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3931C", Offset = "0x3931C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700012A")]
		public bool isGrounded
		{
			[Token(Token = "0x6000917")]
			[Address(RVA = "0x1380F2C", Offset = "0x1380F2C", VA = "0x1380F2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3932C", Offset = "0x3932C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000918")]
			[Address(RVA = "0x1380F34", Offset = "0x1380F34", VA = "0x1380F34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3933C", Offset = "0x3933C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700012B")]
		public Transform root
		{
			[Token(Token = "0x6000919")]
			[Address(RVA = "0x1380F3C", Offset = "0x1380F3C", VA = "0x1380F3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3934C", Offset = "0x3934C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600091A")]
			[Address(RVA = "0x1380F44", Offset = "0x1380F44", VA = "0x1380F44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3935C", Offset = "0x3935C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700012C")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x600091B")]
			[Address(RVA = "0x1380F4C", Offset = "0x1380F4C", VA = "0x1380F4C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3936C", Offset = "0x3936C")]
			get
			{
				return default;
			}
			[Token(Token = "0x600091C")]
			[Address(RVA = "0x1380F64", Offset = "0x1380F64", VA = "0x1380F64")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3937C", Offset = "0x3937C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700012D")]
		public bool rootGrounded
		{
			[Token(Token = "0x600091D")]
			[Address(RVA = "0x1380F84", Offset = "0x1380F84", VA = "0x1380F84")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700012E")]
		public Vector3 up
		{
			[Token(Token = "0x6000925")]
			[Address(RVA = "0x1381228", Offset = "0x1381228", VA = "0x1381228")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700012F")]
		private bool useRootRotation
		{
			[Token(Token = "0x6000928")]
			[Address(RVA = "0x138155C", Offset = "0x138155C", VA = "0x138155C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600091E")]
		[Address(RVA = "0x1380FD8", Offset = "0x1380FD8", VA = "0x1380FD8")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default;
		}

		[Token(Token = "0x600091F")]
		[Address(RVA = "0x13812D0", Offset = "0x13812D0", VA = "0x13812D0")]
		public bool IsValid(ref string errorMessage)
		{
			return default;
		}

		[Token(Token = "0x6000920")]
		[Address(RVA = "0x1380278", Offset = "0x1380278", VA = "0x1380278")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x6000921")]
		[Address(RVA = "0x1380704", Offset = "0x1380704", VA = "0x1380704")]
		public void Update()
		{
		}

		[Token(Token = "0x6000922")]
		[Address(RVA = "0x13813F8", Offset = "0x13813F8", VA = "0x13813F8")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default;
		}

		[Token(Token = "0x6000923")]
		[Address(RVA = "0x137FEA8", Offset = "0x137FEA8", VA = "0x137FEA8")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000924")]
		[Address(RVA = "0x13813E0", Offset = "0x13813E0", VA = "0x13813E0")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000926")]
		[Address(RVA = "0x13815DC", Offset = "0x13815DC", VA = "0x13815DC")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default;
		}

		[Token(Token = "0x6000927")]
		[Address(RVA = "0x13816CC", Offset = "0x13816CC", VA = "0x13816CC")]
		public Vector3 Flatten(Vector3 v)
		{
			return default;
		}

		[Token(Token = "0x6000929")]
		[Address(RVA = "0x13817DC", Offset = "0x13817DC", VA = "0x13817DC")]
		public Vector3 GetFootCenterOffset()
		{
			return default;
		}

		[Token(Token = "0x600092A")]
		[Address(RVA = "0x1381858", Offset = "0x1381858", VA = "0x1381858")]
		public Grounding()
		{
		}
	}
}
