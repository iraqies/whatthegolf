using System.Collections;
using System.Collections.Generic;
using Core;
using UnityEngine;

public class FailOnExplode : MonoBehaviour
{
	public List<ExplosionBarrel2D> explosionBarrel2Ds;
	public List<ExplosionBarrel> explosionBarrels;
	private bool didTriggerFail;

	private void Update()
	{
		if (didTriggerFail) return;
		if (explosionBarrels != null)
		{
			for (int i = 0; i < explosionBarrels.Count; i++)
			{
				var b = explosionBarrels[i];
				if (b != null && b.didExplode)
				{
					didTriggerFail = true;
					StartCoroutine(Boom());
					return;
				}
			}
		}
		if (explosionBarrel2Ds != null)
		{
			for (int i = 0; i < explosionBarrel2Ds.Count; i++)
			{
				var b2 = explosionBarrel2Ds[i];
				if (b2 != null && b2.didExplode)
				{
					didTriggerFail = true;
					StartCoroutine(Boom());
					return;
				}
			}
		}
	}

	private IEnumerator Boom()
	{
		yield return new WaitForSeconds(0.6f);
		if (Level.HasInstance)
			Level.Instance.Fail(true, true, null, 1.5f, true, "ID_FAIL_BOOM");
	}
}
