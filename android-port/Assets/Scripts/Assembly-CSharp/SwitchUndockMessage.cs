using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core;
using UnityEngine;

public class SwitchUndockMessage : MonoBehaviour
{
	public Animator MessageAnimator;

	public static bool IsShowing;

	private bool _shoouldShow;

	private bool _menuShowing;

	private const string HNAME = "Handheld";

	private bool hasBeenDisabledOnce;

	[CompilerGenerated]
	private Action<bool> m_OnDockingStateChanged;

	private Dictionary<GolfBallController, bool> controllers;

	public event Action<bool> OnDockingStateChanged
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	[RuntimeInitializeOnLoadMethod]
	private static void Init()
	{
	}
}
