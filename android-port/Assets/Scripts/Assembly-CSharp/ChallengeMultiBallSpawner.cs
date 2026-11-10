using System.Collections;
using System.Collections.Generic;
using Core;
using UnityEngine;

public class ChallengeMultiBallSpawner : MonoBehaviour
{
	public GolfBallController controller;

	private GolfBallController _currentController;

	public int maxSpawn = 10;

	private List<GolfBallController> _spawnedBalls = new List<GolfBallController>();

	private void Awake()
	{
		if (controller == null || controller.gameObject == null) return;
		controller.gameObject.SetActive(false);
		_currentController = InstantiateGolfBall();
		if (_currentController != null)
			_currentController.OnShoot += ControllerOnShoot;
	}

	private void ControllerOnShoot(Vector3 obj)
	{
		if (_currentController != null)
		{
			_currentController.OnShoot -= ControllerOnShoot;
			var col = _currentController.GetComponent<Collider>();
			if (col != null)
				col.enabled = true;
			_currentController.enabled = false;
			if (_currentController.arrow != null)
				_currentController.arrow.Hide();
		}
		StartCoroutine(WaitAndSpawn());
	}

	private IEnumerator WaitAndSpawn()
	{
		yield return new WaitForSeconds(0.3f);
		_currentController = InstantiateGolfBall();
		if (_currentController != null)
			_currentController.OnShoot += ControllerOnShoot;
	}

	private GolfBallController InstantiateGolfBall()
	{
		if (_spawnedBalls == null)
			_spawnedBalls = new List<GolfBallController>();
		if (_spawnedBalls.Count > maxSpawn && _spawnedBalls.Count > 0)
		{
			if (_spawnedBalls[0] != null)
				Destroy(_spawnedBalls[0].gameObject);
			_spawnedBalls.RemoveAt(0);
		}
		if (controller == null) return null;
		GolfBallController inst = Instantiate(controller, transform.position, Quaternion.identity);
		if (inst == null) return null;
		inst.gameObject.SetActive(true);
		var col = inst.GetComponent<Collider>();
		if (col != null)
			col.enabled = false;
		_spawnedBalls.Add(inst);
		return inst;
	}
}
