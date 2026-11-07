using Il2CppDummyDll;
using UnityEngine;

namespace Arena
{
	[Token(Token = "0x200121F")]
	public class BeachballSpawner : MonoBehaviour
	{
		[Token(Token = "0x40061F0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject ballPrefab;

		[Token(Token = "0x40061F1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject rockPrefab;

		[Token(Token = "0x40061F2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int spawnRockInterval;

		[Token(Token = "0x40061F3")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private int maxToSpawn;

		[Token(Token = "0x40061F4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float radius;

		[Token(Token = "0x40061F5")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private MinMax randomInterval;

		[Token(Token = "0x40061F6")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private MinMax randomSizeMultiplier;

		[Token(Token = "0x40061F7")]
		[FieldOffset(Offset = "0x48")]
		private int spawnCount;

		[Token(Token = "0x40061F8")]
		[FieldOffset(Offset = "0x4C")]
		private float nextSpawnTime;

		[Token(Token = "0x600537C")]
		[Address(RVA = "0x160C620", Offset = "0x160C620", VA = "0x160C620")]
		private void Update()
		{
		}

		[Token(Token = "0x600537D")]
		[Address(RVA = "0x160C69C", Offset = "0x160C69C", VA = "0x160C69C")]
		private void Spawn()
		{
		}

		[Token(Token = "0x600537E")]
		[Address(RVA = "0x160C874", Offset = "0x160C874", VA = "0x160C874")]
		public BeachballSpawner()
		{
		}
	}
}
