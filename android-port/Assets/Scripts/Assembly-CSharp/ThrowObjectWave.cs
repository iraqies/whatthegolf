using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowObjectWave : FrogKingBaseWave
{
	public Transform SpawnPosition;

	public Vector3 EndOffsetFromBoat;

	public List<Transform> ObjectPrefabs;

	public Transform PlayerBoat;

	public Transform ObjectShadow;

	public int ObjectsToThrow = 1;

	public float DelayBetweenThrows;

	public float WaveDuration = 4f;

	public float ObjectFlyTime = 2f;

	public float ThrowHeight = 100f;

	public float InitialWaitTime = 1f;

	public AnimationCurve ShadowScaleCurve;

	private Transform frogKingTrans;

	private List<Transform> spawnedObjects = new List<Transform>();

	public override IEnumerator WaveRoutine(SHMUPFrogKing frogKing)
	{
		StartCoroutine(WaveAnimationsRoutine());
		yield return new WaitForSeconds(InitialWaitTime);
		if (frogKing != null)
		{
			frogKingTrans = frogKing.transform;
		}
		for (int i = 0; i < ObjectsToThrow; i++)
		{
			if (ObjectPrefabs != null && ObjectPrefabs.Count > 0 && SpawnPosition != null && ObjectShadow != null)
			{
				Transform prefab = ObjectPrefabs[UnityEngine.Random.Range(0, ObjectPrefabs.Count)];
				Transform spawned = Instantiate(prefab, SpawnPosition.position, UnityEngine.Random.rotation);
				Transform shadow = Instantiate(ObjectShadow);
				shadow.gameObject.SetActive(true);
				StartCoroutine(MoveObjectRoutine(spawned, shadow));
				if (spawnedObjects != null)
				{
					spawnedObjects.Add(spawned);
					spawnedObjects.Add(shadow);
				}
			}
			if (DelayBetweenThrows > 0f)
			{
				yield return new WaitForSeconds(DelayBetweenThrows);
			}
		}
		if (frogKing != null)
		{
			yield return new WaitForSeconds(WaveDuration - 0.5f * frogKing.HitsTaken);
		}
	}

	public override void OnSinkReset()
	{
		base.OnSinkReset();
		if (spawnedObjects != null)
		{
			foreach (Transform t in spawnedObjects)
			{
				if (t != null && t.gameObject != null)
				{
					t.gameObject.SetActive(false);
				}
			}
		}
		StopAllCoroutines();
	}

	private IEnumerator MoveObjectRoutine(Transform trans, Transform shadowTrans)
	{
		if (SpawnPosition == null || frogKingTrans == null || PlayerBoat == null || trans == null || shadowTrans == null)
		{
			yield break;
		}
		Vector3 startPos = new Vector3(
			SpawnPosition.position.x,
			SpawnPosition.position.y,
			SpawnPosition.position.z - frogKingTrans.position.z
		);
		int rndX = UnityEngine.Random.Range(-100, 100);
		float endZ = Mathf.Lerp(-100f, PlayerBoat.position.z - frogKingTrans.position.z, UnityEngine.Random.value);
		Vector3 endPos = new Vector3(rndX, PlayerBoat.position.y + EndOffsetFromBoat.y, endZ);
		Vector3 midPos = (endPos - startPos) / 1.5f + new Vector3(0f, ThrowHeight, 0f);
		Vector3 initShadowScale = shadowTrans.localScale;
		yield return StartCoroutine(pTween.To(ObjectFlyTime, t =>
		{
			if (trans != null && frogKingTrans != null)
			{
				Vector3 b = TweenFunctions.Bezier(startPos, midPos, endPos, t);
				trans.position = new Vector3(b.x, b.y, frogKingTrans.position.z + b.z);
			}
			if (shadowTrans != null && frogKingTrans != null)
			{
				Vector3 sb = TweenFunctions.Bezier(startPos, midPos, endPos, 1f);
				shadowTrans.position = new Vector3(sb.x, sb.y, frogKingTrans.position.z + sb.z);
				if (ShadowScaleCurve != null)
				{
					shadowTrans.localScale = initShadowScale * ShadowScaleCurve.Evaluate(t);
				}
			}
		}));
		while (trans != null && PlayerBoat != null && trans.position.z > PlayerBoat.position.z)
		{
			yield return null;
		}
		if (trans != null)
		{
			Rigidbody rb = trans.GetComponent<Rigidbody>();
			if (rb != null)
			{
				rb.isKinematic = false;
				rb.useGravity = true;
				rb.velocity = Vector3.zero;
				rb.angularVelocity = Vector3.zero;
				rb.drag = 5f;
			}
			ExplosionBarrel barrel = trans.gameObject.GetComponent<ExplosionBarrel>();
			if (barrel != null)
			{
				barrel.Explode(null);
			}
		}
		yield return new WaitForSeconds(2f);
		if (spawnedObjects != null)
		{
			spawnedObjects.Remove(trans);
			spawnedObjects.Remove(shadowTrans);
		}
		if (trans != null)
		{
			trans.gameObject.SetActive(false);
		}
		if (shadowTrans != null)
		{
			shadowTrans.gameObject.SetActive(false);
		}
	}

	public Vector3 CalculateVelocityForTarget(Vector3 startPosition, Vector3 target, float initialAngle)
	{
		float g = Physics.gravity.magnitude;
		float rad = initialAngle * ((float)Math.PI / 180f);
		float planarDist = Vector3.Distance(new Vector3(target.x, 0f, target.z), new Vector3(startPosition.x, 0f, startPosition.z));
		float yOffset = startPosition.y - target.y;
		float cos = Mathf.Cos(rad);
		float sin = Mathf.Sin(rad);
		float tan = Mathf.Tan(rad);
		float denom = yOffset + tan * planarDist;
		if (denom <= 0.0001f || Mathf.Abs(cos) <= 0.0001f)
		{
			return (target - startPosition).normalized * 20f;
		}
		float speed = (1f / cos) * Mathf.Sqrt(0.5f * g * planarDist * planarDist / denom);
		Vector3 localVel = new Vector3(0f, sin * speed, cos * speed);
		float angle = Vector3.Angle(Vector3.forward, new Vector3(target.x - startPosition.x, 0f, target.z - startPosition.z));
		if (target.x < startPosition.x)
		{
			angle = -angle;
		}
		return Quaternion.AngleAxis(angle, Vector3.up) * localVel;
	}
}
