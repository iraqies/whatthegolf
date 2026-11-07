using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchSplashScreen : MonoBehaviour
{
	public List<Graphic> fadeGraphics;

	public RawImage bgImage;

	public RawImage bgBehindImage;

	public Color bgColor;

	public static SwitchSplashScreen Instance { get; private set; }

	protected void Awake()
	{
	}

	private void Start()
	{
	}

	public IEnumerator ShowRoutine()
	{
		return null;
	}

	public IEnumerator HideRoutine()
	{
		return null;
	}

	public void SetOff()
	{
	}
}
