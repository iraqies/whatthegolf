using System.Linq;
using Core;
using UnityEngine;

public class AddControllerToSoccerPlayerTarget : MonoBehaviour
{
	[SerializeField]
	private bool _findController;

	private void Awake()
	{
		SoccerPlayer component = GetComponent<SoccerPlayer>();
		if (component != null)
		{
			GolfBallController[] source = Object.FindObjectsOfType<GolfBallController>();
			component.balls = source.Select((GolfBallController g) => g.GetComponent<Rigidbody>()).ToList();
		}
	}
}
