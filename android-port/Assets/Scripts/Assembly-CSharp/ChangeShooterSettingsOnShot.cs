using System;
using System.Collections.Generic;
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
	}

	private void OnShoot(Vector3 vector3)
	{
	}
}
