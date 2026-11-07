using System;

namespace WhatTheGolf.LevelDesigner.Events
{
	public struct CallbackAndGuidArgs
	{
		public Action continueAction;

		public Action cancelAction;

		public Guid guid;

		public CallbackAndGuidArgs(Action continueAction, Action cancelAction, Guid guid)
		{
			this.continueAction = null;
			this.cancelAction = null;
			this.guid = default;
		}
	}
}
