using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Hub
{
	[Token(Token = "0x2001072")]
	public class DailyView : MonoBehaviour
	{
		[Token(Token = "0x40056A5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SVGImage image;

		[Token(Token = "0x40056A6")]
		[FieldOffset(Offset = "0x20")]
		private DailyChallengeLevelDataContainer _pack;

		[Token(Token = "0x40056A7")]
		[FieldOffset(Offset = "0x28")]
		private DayOfWeek lastUpdate;

		[Token(Token = "0x60049CC")]
		[Address(RVA = "0x18D3C44", Offset = "0x18D3C44", VA = "0x18D3C44")]
		private void Start()
		{
		}

		[Token(Token = "0x60049CD")]
		[Address(RVA = "0x18D3D5C", Offset = "0x18D3D5C", VA = "0x18D3D5C")]
		private void Update()
		{
		}

		[Token(Token = "0x60049CE")]
		[Address(RVA = "0x18D3D30", Offset = "0x18D3D30", VA = "0x18D3D30")]
		private void Apply(DailyChallengeLevelDataContainer newPack)
		{
		}

		[Token(Token = "0x60049CF")]
		[Address(RVA = "0x18D3EB4", Offset = "0x18D3EB4", VA = "0x18D3EB4")]
		public DailyView()
		{
		}
	}
}
