using Il2CppDummyDll;
using UnityEngine;

namespace Audio.SaveGame
{
	[Token(Token = "0x20013E7")]
	public class EpisodeOverworldId : OverworldID
	{
		[Token(Token = "0x4006B26")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private EpisodeEntranceManager _entranceManager;

		[Token(Token = "0x6005CD3")]
		[Address(RVA = "0x14461E0", Offset = "0x14461E0", VA = "0x14461E0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6005CD4")]
		[Address(RVA = "0x14462CC", Offset = "0x14462CC", VA = "0x14462CC")]
		public EpisodeOverworldId()
		{
		}
	}
}
