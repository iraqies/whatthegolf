using Audio;
using Core;
using Il2CppDummyDll;
using UnityEngine;

namespace BustAMoveGolf
{
	[Token(Token = "0x20010E2")]
	public class SimplexGridManager : MonoBehaviour
	{
		[Token(Token = "0x40058F1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject ballPrefab;

		[Token(Token = "0x40058F2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Material redMaterial;

		[Token(Token = "0x40058F3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Material blueMaterial;

		[Token(Token = "0x40058F4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Material greenMaterial;

		[Token(Token = "0x40058F5")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Material yellowMaterial;

		[Token(Token = "0x40058F6")]
		[FieldOffset(Offset = "0x40")]
		public int CurrentRow;

		[Token(Token = "0x40058F7")]
		[FieldOffset(Offset = "0x48")]
		public Rigidbody Ceiling;

		[Token(Token = "0x40058F8")]
		[FieldOffset(Offset = "0x50")]
		public Rigidbody Flag;

		[Token(Token = "0x40058F9")]
		[FieldOffset(Offset = "0x58")]
		public int columns;

		[Token(Token = "0x40058FA")]
		[FieldOffset(Offset = "0x5C")]
		public int rows;

		[Token(Token = "0x40058FB")]
		[FieldOffset(Offset = "0x60")]
		public RandomAudioClips BallMatchOneshot;

		[Token(Token = "0x40058FC")]
		[FieldOffset(Offset = "0x68")]
		private BustAMoveBall[,] grid;

		[Token(Token = "0x40058FD")]
		[FieldOffset(Offset = "0x70")]
		public float radius;

		[Token(Token = "0x40058FE")]
		[FieldOffset(Offset = "0x78")]
		private Vector3[] ceilingPositions;

		[Token(Token = "0x40058FF")]
		[FieldOffset(Offset = "0x80")]
		public bool BallActive;

		[Token(Token = "0x170007FE")]
		public float YSpacing
		{
			[Token(Token = "0x6004BA0")]
			[Address(RVA = "0x16B0B98", Offset = "0x16B0B98", VA = "0x16B0B98")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6004B9A")]
		[Address(RVA = "0x16B0758", Offset = "0x16B0758", VA = "0x16B0758")]
		private void Awake()
		{
		}

		[Token(Token = "0x6004B9B")]
		[Address(RVA = "0x16B0F88", Offset = "0x16B0F88", VA = "0x16B0F88")]
		private void OnComplete(Level.CompletedState completedState)
		{
		}

		[Token(Token = "0x6004B9C")]
		[Address(RVA = "0x16B1068", Offset = "0x16B1068", VA = "0x16B1068")]
		private void MoveCeilingDown()
		{
		}

		[Token(Token = "0x6004B9D")]
		[Address(RVA = "0x16B0BB4", Offset = "0x16B0BB4", VA = "0x16B0BB4")]
		private void AssignAllNeighbors()
		{
		}

		[Token(Token = "0x6004B9E")]
		[Address(RVA = "0x16B134C", Offset = "0x16B134C", VA = "0x16B134C")]
		private void AssignNeighbors(BustAMoveBall ball)
		{
		}

		[Token(Token = "0x6004B9F")]
		[Address(RVA = "0x16B119C", Offset = "0x16B119C", VA = "0x16B119C")]
		private BustAMoveBall[] FindNeighbors(BustAMoveBall ball)
		{
			return null;
		}

		[Token(Token = "0x6004BA1")]
		[Address(RVA = "0x16B13D4", Offset = "0x16B13D4", VA = "0x16B13D4")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6004BA2")]
		[Address(RVA = "0x16B1624", Offset = "0x16B1624", VA = "0x16B1624")]
		public void SnapToCeiling(BustAMoveBall snapBall)
		{
		}

		[Token(Token = "0x6004BA3")]
		[Address(RVA = "0x16B1A64", Offset = "0x16B1A64", VA = "0x16B1A64")]
		public void SnapToBallGrid(BustAMoveBall snapBall, BustAMoveBall colBall)
		{
		}

		[Token(Token = "0x6004BA4")]
		[Address(RVA = "0x16B19D8", Offset = "0x16B19D8", VA = "0x16B19D8")]
		private void DestroyBall(BustAMoveBall ball)
		{
		}

		[Token(Token = "0x6004BA5")]
		[Address(RVA = "0x16B1E00", Offset = "0x16B1E00", VA = "0x16B1E00")]
		private Vector3[] GetNeighborPositions(BustAMoveBall ball)
		{
			return null;
		}

		[Token(Token = "0x6004BA6")]
		[Address(RVA = "0x16B2068", Offset = "0x16B2068", VA = "0x16B2068")]
		public Material GetMaterialFromColor(BustAMoveColor color)
		{
			return null;
		}

		[Token(Token = "0x6004BA7")]
		[Address(RVA = "0x16B2138", Offset = "0x16B2138", VA = "0x16B2138")]
		public SimplexGridManager()
		{
		}
	}
}
