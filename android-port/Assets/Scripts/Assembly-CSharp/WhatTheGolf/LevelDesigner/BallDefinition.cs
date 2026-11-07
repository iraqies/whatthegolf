using Il2CppDummyDll;
using UnityEngine;

namespace WhatTheGolf.LevelDesigner
{
	[Token(Token = "0x200123D")]
	public sealed class BallDefinition : SelectableDefinition
	{
		[Token(Token = "0x4006270")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private BaseCameraController m_OverrideCameraPrefab;

		[Token(Token = "0x17000964")]
		public BaseCameraController overrideCameraPrefab
		{
			[Token(Token = "0x600540A")]
			[Address(RVA = "0x1518BC8", Offset = "0x1518BC8", VA = "0x1518BC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600540B")]
		[Address(RVA = "0x1518BD0", Offset = "0x1518BD0", VA = "0x1518BD0")]
		public BallDefinition()
		{
		}
	}
}
