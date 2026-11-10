using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using UnityEngine;

public class ChangeShooterSettingsOnShot : MonoBehaviour
{
	[Serializable]
	public class ChangeShotData
	{
		public int ShotNumber;

		public Transform NewArrowPosition;

		public ShooterBase NewShooter;
	}

	public GolfBallController Controller;

	public List<ChangeShotData> ChangeShotDatas;

	private int shots;

	private GolfBallShooterBase shooterBase;

	private void Start()
	{
		if (Controller != null)
		{
			Controller.OnShoot += OnShoot;
		}
	}

	private void OnShoot(Vector3 vector3)
	{
		shots++;
		if (ChangeShotDatas == null)
			return;

		ChangeShotData match = ChangeShotDatas.FirstOrDefault(s => s != null && s.ShotNumber == shots);
		if (match != null && Controller != null)
		{
			Controller.ArrowPosition = match.NewArrowPosition;
			if (match.NewShooter != null)
			{
				Controller.shooter = match.NewShooter;
			}
		}
	}
}
