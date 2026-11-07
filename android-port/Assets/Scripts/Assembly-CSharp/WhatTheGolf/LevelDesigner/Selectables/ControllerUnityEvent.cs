using System;
using Core;
using UnityEngine.Events;

namespace WhatTheGolf.LevelDesigner.Selectables
{
	[Serializable]
	public class ControllerUnityEvent : UnityEvent<GolfBallController>
	{
	}
}
