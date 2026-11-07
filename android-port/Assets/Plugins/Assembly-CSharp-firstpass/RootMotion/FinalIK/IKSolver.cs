using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Serializable]
	[Token(Token = "0x200016C")]
	public abstract class IKSolver
	{
		[Serializable]
		[Token(Token = "0x200016D")]
		public class Point
		{
			[Token(Token = "0x4000938")]
			[FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x4000939")]
			[FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x36070", Offset = "0x36070")]
			public float weight;

			[Token(Token = "0x400093A")]
			[FieldOffset(Offset = "0x1C")]
			public Vector3 solverPosition;

			[Token(Token = "0x400093B")]
			[FieldOffset(Offset = "0x28")]
			public Quaternion solverRotation;

			[Token(Token = "0x400093C")]
			[FieldOffset(Offset = "0x38")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x400093D")]
			[FieldOffset(Offset = "0x44")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x6000A4F")]
			[Address(RVA = "0x133F7AC", Offset = "0x133F7AC", VA = "0x133F7AC")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000A50")]
			[Address(RVA = "0x133F7FC", Offset = "0x133F7FC", VA = "0x133F7FC")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x6000A51")]
			[Address(RVA = "0x133F384", Offset = "0x133F384", VA = "0x133F384")]
			public Point()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200016E")]
		public class Bone : Point
		{
			[Token(Token = "0x400093E")]
			[FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x400093F")]
			[FieldOffset(Offset = "0x58")]
			public float sqrMag;

			[Token(Token = "0x4000940")]
			[FieldOffset(Offset = "0x5C")]
			public Vector3 axis;

			[Token(Token = "0x4000941")]
			[FieldOffset(Offset = "0x68")]
			private RotationLimit _rotationLimit;

			[Token(Token = "0x4000942")]
			[FieldOffset(Offset = "0x70")]
			private bool isLimited;

			[Token(Token = "0x17000148")]
			public RotationLimit rotationLimit
			{
				[Token(Token = "0x6000A52")]
				[Address(RVA = "0x133EF10", Offset = "0x133EF10", VA = "0x133EF10")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A53")]
			[Address(RVA = "0x133F010", Offset = "0x133F010", VA = "0x133F010")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000A54")]
			[Address(RVA = "0x133F1C0", Offset = "0x133F1C0", VA = "0x133F1C0")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000A55")]
			[Address(RVA = "0x133F324", Offset = "0x133F324", VA = "0x133F324")]
			public Bone()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200016F")]
		public class Node : Point
		{
			[Token(Token = "0x4000943")]
			[FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x4000944")]
			[FieldOffset(Offset = "0x58")]
			public float effectorPositionWeight;

			[Token(Token = "0x4000945")]
			[FieldOffset(Offset = "0x5C")]
			public float effectorRotationWeight;

			[Token(Token = "0x4000946")]
			[FieldOffset(Offset = "0x60")]
			public Vector3 offset;

			[Token(Token = "0x6000A56")]
			[Address(RVA = "0x133F728", Offset = "0x133F728", VA = "0x133F728")]
			public Node()
			{
			}

			[Token(Token = "0x6000A57")]
			[Address(RVA = "0x133F764", Offset = "0x133F764", VA = "0x133F764")]
			public Node(Transform transform)
			{
			}
		}

		[Token(Token = "0x2000170")]
		public delegate void UpdateDelegate();

		[Token(Token = "0x2000171")]
		public delegate void IterationDelegate(int i);

		[Token(Token = "0x400092F")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 IKPosition;

		[Token(Token = "0x4000930")]
		[FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x36038", Offset = "0x36038")]
		public float IKPositionWeight;

		[Token(Token = "0x4000931")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x36050", Offset = "0x36050")]
		private bool initiated__BackingField;

		[Token(Token = "0x4000932")]
		[FieldOffset(Offset = "0x28")]
		public UpdateDelegate OnPreInitiate;

		[Token(Token = "0x4000933")]
		[FieldOffset(Offset = "0x30")]
		public UpdateDelegate OnPostInitiate;

		[Token(Token = "0x4000934")]
		[FieldOffset(Offset = "0x38")]
		public UpdateDelegate OnPreUpdate;

		[Token(Token = "0x4000935")]
		[FieldOffset(Offset = "0x40")]
		public UpdateDelegate OnPostUpdate;

		[Token(Token = "0x4000936")]
		[FieldOffset(Offset = "0x48")]
		protected bool firstInitiation;

		[Token(Token = "0x4000937")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		protected Transform root;

		[Token(Token = "0x17000147")]
		public bool initiated
		{
			[Token(Token = "0x6000A43")]
			[Address(RVA = "0x1389AA4", Offset = "0x1389AA4", VA = "0x1389AA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A05C", Offset = "0x3A05C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000A44")]
			[Address(RVA = "0x1389AAC", Offset = "0x1389AAC", VA = "0x1389AAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A06C", Offset = "0x3A06C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000A3B")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x6000A3C")]
		[Address(RVA = "0x138535C", Offset = "0x138535C", VA = "0x138535C")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x6000A3D")]
		[Address(RVA = "0x1385274", Offset = "0x1385274", VA = "0x1385274")]
		public void Update()
		{
		}

		[Token(Token = "0x6000A3E")]
		[Address(RVA = "0x1389A4C", Offset = "0x1389A4C", VA = "0x1389A4C", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default;
		}

		[Token(Token = "0x6000A3F")]
		[Address(RVA = "0x1389A58", Offset = "0x1389A58", VA = "0x1389A58")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x6000A40")]
		[Address(RVA = "0x1389A64", Offset = "0x1389A64", VA = "0x1389A64")]
		public float GetIKPositionWeight()
		{
			return default;
		}

		[Token(Token = "0x6000A41")]
		[Address(RVA = "0x1389A6C", Offset = "0x1389A6C", VA = "0x1389A6C")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x6000A42")]
		[Address(RVA = "0x1389A9C", Offset = "0x1389A9C", VA = "0x1389A9C")]
		public Transform GetRoot()
		{
			return null;
		}

		[Token(Token = "0x6000A45")]
		public abstract Point[] GetPoints();

		[Token(Token = "0x6000A46")]
		public abstract Point GetPoint(Transform transform);

		[Token(Token = "0x6000A47")]
		public abstract void FixTransforms();

		[Token(Token = "0x6000A48")]
		public abstract void StoreDefaultLocalState();

		[Token(Token = "0x6000A49")]
		protected abstract void OnInitiate();

		[Token(Token = "0x6000A4A")]
		protected abstract void OnUpdate();

		[Token(Token = "0x6000A4B")]
		[Address(RVA = "0x1389AB4", Offset = "0x1389AB4", VA = "0x1389AB4")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000A4C")]
		[Address(RVA = "0x1389ACC", Offset = "0x1389ACC", VA = "0x1389ACC")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000A4D")]
		[Address(RVA = "0x1389C18", Offset = "0x1389C18", VA = "0x1389C18")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default;
		}

		[Token(Token = "0x6000A4E")]
		[Address(RVA = "0x1389CA8", Offset = "0x1389CA8", VA = "0x1389CA8")]
		protected IKSolver()
		{
		}
	}
}
