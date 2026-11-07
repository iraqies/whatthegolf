namespace WhatTheGolf.LevelDesigner.Tools
{
	public abstract class BaseTool
	{
		private MainController m_Owner;

		public MainController owner
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public abstract void Init();

		public abstract void Update(bool guiHasFocus);

		public abstract void Dispose();
	}
}
