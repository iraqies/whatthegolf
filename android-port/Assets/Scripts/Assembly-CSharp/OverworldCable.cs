using System;
using System.Collections;
using UnityEngine;

public class OverworldCable : MonoBehaviour
{
	public LineRenderer line;
	public LineRenderer lineFill;
	public Material OffMaterial;
	public Material OnMaterial;
	public float Speed = 10f;
	public float LineOnMoveSpeed = 1f;
	public ParticleSystem Particles;
	public Action<float> OnMoveNormalized;

	private bool isOn;
	private float offsetTimer;
	private float offsetStartDamper;
	private const float zOffset = -0.1f;

	private void Awake()
	{
		if (OnMaterial != null)
			OnMaterial = Instantiate(OnMaterial);
	}

	public void Toggle(bool state)
	{
		if (line != null)
			line.material = state ? OnMaterial : OffMaterial;
		isOn = state;
		offsetStartDamper = state ? 1f : 0f;
		if (lineFill != null)
			lineFill.gameObject.SetActive(!state);
	}

	public IEnumerator SetEnableColorRoutine(Action<Vector3> OnMove = null, bool instant = false)
	{
		if (instant || line == null)
		{
			if (line != null && OnMaterial != null)
				line.material = OnMaterial;
			if (lineFill != null)
				lineFill.gameObject.SetActive(false);
			isOn = true;
			yield break;
		}

		if (lineFill != null)
		{
			if (OnMaterial != null)
				lineFill.material = OnMaterial;
			lineFill.gameObject.SetActive(true);
			lineFill.transform.position = line.transform.position;
		}

		if (Particles != null && line.positionCount > 0)
			Particles.transform.position = line.GetPosition(0);

		float totalLength = 0f;
		int posCount = line.positionCount;
		for (int i = 0; i < posCount - 1; i++)
			totalLength += Vector2.Distance(line.GetPosition(i), line.GetPosition(i + 1));

		float accumLength = 0f;
		if (lineFill != null && posCount > 0)
		{
			lineFill.positionCount = 1;
			lineFill.SetPosition(0, line.GetPosition(0));
		}

		float spd = Mathf.Max(2f, Speed);
		for (int i = 0; i < posCount - 1; i++)
		{
			Vector3 pA = line.GetPosition(i);
			Vector3 pB = line.GetPosition(i + 1);
			Vector3 dir = (pB - pA).normalized;
			float segLen = Vector3.Distance(pA, pB);
			if (lineFill != null)
				lineFill.positionCount = lineFill.positionCount + 1;

			float segProgress = 0f;
			while (segProgress < segLen)
			{
				Vector3 curPos = pA + dir * segProgress;
				curPos.z += zOffset;
				if (lineFill != null && lineFill.positionCount > 0)
					lineFill.SetPosition(lineFill.positionCount - 1, curPos);
				OnMove?.Invoke(curPos);
				if (totalLength > 0.001f)
					OnMoveNormalized?.Invoke((accumLength + segProgress) / totalLength);
				if (Particles != null)
				{
					Particles.transform.position = curPos;
					Particles.Emit(1);
				}
				yield return null;
				segProgress += spd * Time.deltaTime;
			}

			accumLength += segLen;
			if (lineFill != null && lineFill.positionCount > 0)
				lineFill.SetPosition(lineFill.positionCount - 1, new Vector3(pB.x, pB.y, pB.z + zOffset));
		}

		if (line != null && OnMaterial != null)
			line.material = OnMaterial;
		if (lineFill != null)
			lineFill.gameObject.SetActive(false);
		isOn = true;
	}

	private void Update()
	{
		if (isOn && OnMaterial != null)
		{
			offsetTimer += Time.deltaTime * LineOnMoveSpeed * offsetStartDamper;
			offsetStartDamper = Mathf.Clamp01(offsetStartDamper + Time.deltaTime * 0.5f);
			OnMaterial.mainTextureOffset = new Vector2(-offsetTimer, 0f);
		}
	}
}
