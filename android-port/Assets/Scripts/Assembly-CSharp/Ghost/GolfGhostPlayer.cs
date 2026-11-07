using Il2CppDummyDll;
using PersistentData;
using UnityEngine;

namespace Ghost
{
	[Token(Token = "0x20010F4")]
	public class GolfGhostPlayer : MonoBehaviour
	{
		[Token(Token = "0x4005948")]
		[FieldOffset(Offset = "0x18")]
		private GolfGhostData ghost;

		[Token(Token = "0x4005949")]
		[FieldOffset(Offset = "0x20")]
		private float strokePlayTime;

		[Token(Token = "0x400594A")]
		[FieldOffset(Offset = "0x24")]
		private int index;

		[Token(Token = "0x400594B")]
		[FieldOffset(Offset = "0x28")]
		private int strokeIndex;

		[Token(Token = "0x400594C")]
		[FieldOffset(Offset = "0x2C")]
		private int playerStrokeCount;

		[Token(Token = "0x400594D")]
		[FieldOffset(Offset = "0x30")]
		private GameObject model;

		[Token(Token = "0x400594E")]
		[FieldOffset(Offset = "0x38")]
		private string currentPrefabID;

		[Token(Token = "0x6004BD4")]
		[Address(RVA = "0x149F29C", Offset = "0x149F29C", VA = "0x149F29C")]
		private void Update()
		{
		}

		[Token(Token = "0x6004BD5")]
		[Address(RVA = "0x149F64C", Offset = "0x149F64C", VA = "0x149F64C")]
		internal void SetGhost(PersistentStoryData currentData)
		{
		}

		[Token(Token = "0x6004BD6")]
		[Address(RVA = "0x149F710", Offset = "0x149F710", VA = "0x149F710")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6004BD7")]
		[Address(RVA = "0x149F8B4", Offset = "0x149F8B4", VA = "0x149F8B4")]
		public void LoadGhost()
		{
		}

		[Token(Token = "0x6004BD8")]
		[Address(RVA = "0x149F700", Offset = "0x149F700", VA = "0x149F700")]
		public void Play(GolfGhostData ghost)
		{
		}

		[Token(Token = "0x6004BD9")]
		[Address(RVA = "0x149FA40", Offset = "0x149FA40", VA = "0x149FA40")]
		public void PlayerStroke()
		{
		}

		[Token(Token = "0x6004BDA")]
		[Address(RVA = "0x149F5D8", Offset = "0x149F5D8", VA = "0x149F5D8")]
		private void GhostAdvance()
		{
		}

		[Token(Token = "0x6004BDB")]
		[Address(RVA = "0x149FAD0", Offset = "0x149FAD0", VA = "0x149FAD0")]
		private void LoadGhostModel()
		{
		}

		[Token(Token = "0x6004BDC")]
		[Address(RVA = "0x149FDD0", Offset = "0x149FDD0", VA = "0x149FDD0")]
		public GolfGhostPlayer()
		{
		}
	}
}
