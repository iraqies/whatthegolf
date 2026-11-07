using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DailyCountdown : MonoBehaviour
{
	private TextMeshPro text;

	private TextMeshProUGUI textGUI;

	private DateTime EOD;

	private float time;

	private bool usingUGUI;

	public bool debug;

	[SerializeField]
	private string appendString;

	[SerializeField]
	private bool showHours;

	[SerializeField]
	private bool showMinutes;

	[SerializeField]
	private bool showSeconds;

	[SerializeField]
	private string stringOnReachZero;

	public Action OnCountdownZero;

	[SerializeField]
	private TextMeshPro ToEnable;

	[SerializeField]
	private List<TextMeshPro> ToDisable;

	private bool end;

	private void Start()
	{
	}

	private void UpdateTimer()
	{
	}

	private void Update()
	{
	}
}
