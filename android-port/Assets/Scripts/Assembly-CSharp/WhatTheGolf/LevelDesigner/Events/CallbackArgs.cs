using System;

namespace WhatTheGolf.LevelDesigner.Events
{
	public struct CallbackArgs
	{
		public Action continueAction;

		public Action cancelAction;

		public CallbackArgs(Action continueAction, Action cancelAction)
		{
			this.continueAction = null;
			this.cancelAction = null;
		}
	}
}
