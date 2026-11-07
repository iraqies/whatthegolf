namespace WhatTheGolf.LevelDesigner
{
	public abstract class BaseSystem
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

		public abstract void Update();

		public abstract void Dispose();
	}
}
