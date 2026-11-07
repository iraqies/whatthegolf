using Il2CppDummyDll;

namespace WhatTheGolf.LevelDesigner
{
	[Token(Token = "0x200124B")]
	public interface IRequireSerialization
	{
		[Token(Token = "0x6005434")]
		void Load(LevelContentData levelData);

		[Token(Token = "0x6005435")]
		void Save(LevelContentData levelData);
	}
}
