namespace WhatTheGolf.LevelDesigner
{
	public interface IRequireSerialization
	{
		void Load(LevelContentData levelData);

		void Save(LevelContentData levelData);
	}
}
