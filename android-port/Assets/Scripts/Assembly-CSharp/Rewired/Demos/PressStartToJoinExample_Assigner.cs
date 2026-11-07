using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Rewired.Demos
{
	[Token(Token = "0x200116E")]
	public class PressStartToJoinExample_Assigner : MonoBehaviour
	{
		[Token(Token = "0x200116F")]
		private class PlayerMap
		{
			[Token(Token = "0x4005C2B")]
			[FieldOffset(Offset = "0x10")]
			public int rewiredPlayerId;

			[Token(Token = "0x4005C2C")]
			[FieldOffset(Offset = "0x14")]
			public int gamePlayerId;

			[Token(Token = "0x6004FB3")]
			[Address(RVA = "0x182AF48", Offset = "0x182AF48", VA = "0x182AF48")]
			public PlayerMap(int rewiredPlayerId, int gamePlayerId)
			{
			}
		}

		[Token(Token = "0x4005C27")]
		[FieldOffset(Offset = "0x0")]
		private static PressStartToJoinExample_Assigner instance;

		[Token(Token = "0x4005C28")]
		[FieldOffset(Offset = "0x18")]
		public int maxPlayers;

		[Token(Token = "0x4005C29")]
		[FieldOffset(Offset = "0x20")]
		private List<PlayerMap> playerMap;

		[Token(Token = "0x4005C2A")]
		[FieldOffset(Offset = "0x28")]
		private int gamePlayerIdCounter;

		[Token(Token = "0x6004FAD")]
		[Address(RVA = "0x161E984", Offset = "0x161E984", VA = "0x161E984")]
		public static Player GetRewiredPlayer(int gamePlayerId)
		{
			return null;
		}

		[Token(Token = "0x6004FAE")]
		[Address(RVA = "0x161EBFC", Offset = "0x161EBFC", VA = "0x161EBFC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6004FAF")]
		[Address(RVA = "0x161EC9C", Offset = "0x161EC9C", VA = "0x161EC9C")]
		private void Update()
		{
		}

		[Token(Token = "0x6004FB0")]
		[Address(RVA = "0x161ED94", Offset = "0x161ED94", VA = "0x161ED94")]
		private void AssignNextPlayer(int rewiredPlayerId)
		{
		}

		[Token(Token = "0x6004FB1")]
		[Address(RVA = "0x161F00C", Offset = "0x161F00C", VA = "0x161F00C")]
		private int GetNextGamePlayerId()
		{
			return default;
		}

		[Token(Token = "0x6004FB2")]
		[Address(RVA = "0x161F020", Offset = "0x161F020", VA = "0x161F020")]
		public PressStartToJoinExample_Assigner()
		{
		}
	}
}
