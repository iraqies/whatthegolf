using System.Collections.Generic;
using System.Linq;
using Core;
using UnityEngine;

public class ManyballsBounds : MonoBehaviour
{
	private List<GolfBallController> balls;

	private void Start()
	{
		var found = FindObjectsOfType<GolfBallController>();
		balls = found != null ? found.ToList() : new List<GolfBallController>();
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other == null) return;
		var ctrl = other.GetComponentInParent<GolfBallController>();
		if (balls == null) return;
		if (ctrl != null && balls.Contains(ctrl))
		{
			ctrl.BlockShooting = true;
			ctrl.CancelShooting();
			ctrl.enabled = false;
			balls.Remove(ctrl);
		}
		if (balls.Count <= 0 && Level.HasInstance && Level.Instance != null)
		{
			Level.Instance.Fail(true, true, null, 0f, true, "OUT OF BOUNDS");
		}
	}
}
