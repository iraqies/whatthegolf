namespace WhatTheGolf.LevelDesigner.GUI
{
	internal struct MenuStateCache
	{
		public readonly MenuGUI.MenuState state;

		public readonly string searchString;

		public MenuStateCache(MenuGUI.MenuState state, string searchString)
		{
			this.state = MenuGUI.MenuState.Home;
			this.searchString = null;
		}
	}
}
