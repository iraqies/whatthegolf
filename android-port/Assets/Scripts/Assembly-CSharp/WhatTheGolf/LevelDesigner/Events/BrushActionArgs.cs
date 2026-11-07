namespace WhatTheGolf.LevelDesigner.Events
{
	public struct BrushActionArgs
	{
		public enum BrushType
		{
			PaintTerrain = 0,
			PaintObject = 1,
			Eraser = 2
		}

		public BrushType brushType;

		public float delta;

		public BrushActionArgs(BrushType brushType, float delta)
		{
			this.brushType = BrushType.PaintTerrain;
			this.delta = 0f;
		}
	}
}
