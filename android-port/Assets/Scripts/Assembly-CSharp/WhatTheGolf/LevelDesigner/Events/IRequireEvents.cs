using Il2CppDummyDll;

namespace WhatTheGolf.LevelDesigner.Events
{
	[Token(Token = "0x20012BA")]
	public interface IRequireEvents
	{
	}
	[Token(Token = "0x20012BB")]
	public interface IRequireEvents<T> : IRequireEvents where T : IEvent
	{
		[Token(Token = "0x60056CF")]
		void OnEvent(T evt);
	}
}
