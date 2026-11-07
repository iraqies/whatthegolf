using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCarTunneOnEnableIndicator : MonoBehaviour
{
	public OverworldMainDoorPlate plate;

	public List<ExplosionBarrel2D> barrels;

	public List<GameObject> DisableObjectsOnExplosion;

	public List<GameObject> EnableObjectsOnExplosion;

	private bool isKeepingBall;

	private IEnumerator Start()
	{
		return null;
	}

	private void SetObjectStates()
	{
	}

	private void Plate_OnStateChange(bool state, bool onLoad)
	{
	}

	private IEnumerator ExplodeRoutine()
	{
		return null;
	}

	private IEnumerator KeepBall(Vector3 pos)
	{
		return null;
	}
}
