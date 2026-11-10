using System.Collections.Generic;
using System.Linq;
using Core;
using UnityEngine;

public class ChangeSoccerPlayer : MonoBehaviour
{
	public SoccerPlayer ComputerPlayer;

	public GolfBallController Controller;

	public List<GolfBallController> OtherControllers;

	private void Start()
	{
		if (ComputerPlayer != null)
		{
			ComputerPlayer.onKick = (System.Action)System.Delegate.Combine(ComputerPlayer.onKick, new System.Action(OnKick));
		}
	}

	private void OnKick()
	{
		if (OtherControllers != null)
		{
			GolfBallController golfBallController = OtherControllers.FirstOrDefault((GolfBallController c) => c != null && c.enabled);
			if (golfBallController != null)
			{
				golfBallController.enabled = false;
			}
		}
		if (Controller != null)
		{
			Controller.enabled = true;
		}
	}
}
