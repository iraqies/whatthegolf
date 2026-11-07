namespace WhatTheGolf.LevelDesigner.Events
{
	public class GameStateEvent : BaseEvent<GameStateEvent.GameStateEventType>
	{
		public enum GameStateEventType
		{
			Empty = 0,
			SetStateTest = 1,
			SetStateEdit = 2,
			SetStatePlay = 3,
			SetStateGolflix = 4,
			OnSelectObject = 5,
			OnRequireUnloadLevel = 6
		}

		public GameStateEvent(GameStateEventType eventType, object data = null)
			: base(GameStateEventType.Empty, (object)null)
		{
		}
	}
}
