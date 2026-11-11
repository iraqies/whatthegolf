using System;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class CarnivalRopesGenerator : MonoBehaviour
{
	public enum FlagDistributionTypeEnum
	{
		PerSegment = 0,
		EvenlyDistributed = 1
	}

	public GameObject MastTemplate;

	public GameObject LineSegment;

	public GameObject FlagTemplate;

	public List<Transform> MastPositions;

	public float SegmentsLength = 5f;

	public float MassPerLine = 20f;

	public List<Material> FlagMaterials;

	public FlagDistributionTypeEnum FlagDistributionType;

	public int FlagsPerSegment = 3;

	public float FlagSpacing = 1f;

	public bool ContinuousUpdate;

	public bool DoUpdate;

	private List<GameObject> SpawnedMasts = new List<GameObject>();

	private Dictionary<GameObject, List<GameObject>> lines = new Dictionary<GameObject, List<GameObject>>();

	private int currentMaterialIndex;

	private void Update()
	{
		if (Application.isPlaying || MastTemplate == null || LineSegment == null || (!DoUpdate && !ContinuousUpdate))
		{
			return;
		}
		DoUpdate = false;
		Transform transform = base.transform.Find("Container");
		if (transform != null)
		{
			UnityEngine.Object.DestroyImmediate(transform.gameObject);
		}
		if (MastPositions.Count == 0)
		{
			return;
		}
		GameObject gameObject = new GameObject("Container");
		gameObject.transform.SetParent(base.transform);
		gameObject.transform.localPosition = Vector3.zero;
		SpawnedMasts = new List<GameObject>();
		lines = new Dictionary<GameObject, List<GameObject>>();
		currentMaterialIndex = 0;
		for (int i = 0; i < MastPositions.Count; i++)
		{
			if (i < SpawnedMasts.Count)
			{
				if (SpawnedMasts[i] == null)
				{
					for (int j = 0; j < SpawnedMasts.Count; j++)
					{
						if (lines.ContainsKey(SpawnedMasts[j]))
						{
							for (int k = 0; k < lines[SpawnedMasts[j]].Count; k++)
							{
								UnityEngine.Object.DestroyImmediate(lines[SpawnedMasts[j]][k]);
							}
						}
						UnityEngine.Object.DestroyImmediate(SpawnedMasts[j]);
					}
					SpawnedMasts.Clear();
					lines.Clear();
					return;
				}
				SpawnedMasts[i].transform.position = MastPositions[i].position;
				continue;
			}
			while (i >= SpawnedMasts.Count)
			{
				GameObject gameObject2 = UnityEngine.Object.Instantiate(MastTemplate, MastPositions[i].position, MastPositions[i].rotation, base.transform.Find("Container"));
				gameObject2.SetActive(true);
				SpawnedMasts.Add(gameObject2);
				if (SpawnedMasts.Count >= 2 && i != 0)
				{
					SpawnedMasts[i - 1].transform.LookAt(gameObject2.transform, MastPositions[i - 1].transform.up);
					if (i == MastPositions.Count - 1)
					{
						SpawnedMasts[i].transform.rotation = SpawnedMasts[i - 1].transform.rotation;
					}
				}
			}
		}
		float lastAccumulated = FlagSpacing;
		for (int l = 0; l < SpawnedMasts.Count; l++)
		{
			if ((SpawnedMasts.Count < 2 || l != 0) && !lines.ContainsKey(SpawnedMasts[l]))
			{
				Transform transform2 = SpawnedMasts[l - 1].transform.Find("WireStartLeft");
				Transform transform3 = SpawnedMasts[l].transform.Find("WireEndLeft");
				if (transform2 != null && transform3 != null)
				{
					BuildLines(transform2, transform3);
					if (FlagDistributionType == FlagDistributionTypeEnum.PerSegment)
					{
						PlaceFlagsPerSegment(transform2, transform3);
					}
					else
					{
						if (FlagSpacing <= 0f)
						{
							Debug.LogWarning("Flag spacing can't be zero or lower");
							return;
						}
						lastAccumulated = PlaceFlagsEvenly(transform2, transform3, lastAccumulated);
					}
				}
			}
		}
		if (SpawnedMasts.Count > MastPositions.Count)
		{
			int num = SpawnedMasts.Count - 1;
			while (num > MastPositions.Count - 1)
			{
				Debug.Log("i: " + num);
				if (lines != null && num < SpawnedMasts.Count && lines.ContainsKey(SpawnedMasts[num]))
				{
					for (int m = 0; m < lines[SpawnedMasts[num]].Count; m++)
					{
						UnityEngine.Object.DestroyImmediate(lines[SpawnedMasts[num]][m]);
					}
					lines[SpawnedMasts[num]].Clear();
					lines.Remove(SpawnedMasts[num]);
				}
				UnityEngine.Object.DestroyImmediate(SpawnedMasts[num]);
				SpawnedMasts.RemoveAt(num);
				num--;
			}
		}
	}

	private void PlaceFlagsPerSegment(Transform previousMast, Transform currentMast)
	{
		float num = Vector3.Distance(previousMast.position, currentMast.position);
		if (FlagDistributionType != FlagDistributionTypeEnum.PerSegment)
		{
			return;
		}
		Vector3 normalized = (currentMast.position - previousMast.position).normalized;
		float num2 = num / (float)FlagsPerSegment;
		for (float num3 = 0.5f; num3 < (float)FlagsPerSegment; num3 += 1f)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate(FlagTemplate, previousMast.position + normalized * (num2 * num3), Quaternion.LookRotation(normalized), base.transform.Find("Container"));
			gameObject.SetActive(true);
			gameObject.GetComponentInChildren<MeshRenderer>().material = GetNextFlagMaterial();
			FixedJoint component = gameObject.GetComponent<FixedJoint>();
			for (int i = 0; i < lines[currentMast.gameObject].Count; i++)
			{
				if (Vector3.Distance(previousMast.position, lines[currentMast.gameObject][i].transform.position) > Vector3.Distance(previousMast.position, gameObject.transform.position))
				{
					component.connectedBody = lines[currentMast.gameObject][i].GetComponent<Rigidbody>();
					break;
				}
			}
		}
	}

	private float PlaceFlagsEvenly(Transform previousMast, Transform currentMast, float lastAccumulated)
	{
		float num = Vector3.Distance(previousMast.position, currentMast.position);
		float flagSpacing = FlagSpacing;
		Vector3 normalized = (currentMast.position - previousMast.position).normalized;
		while (lastAccumulated < num)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate(FlagTemplate, previousMast.position + normalized * lastAccumulated, Quaternion.LookRotation(normalized), base.transform.Find("Container"));
			gameObject.GetComponentInChildren<MeshRenderer>().material = GetNextFlagMaterial();
			gameObject.SetActive(true);
			FixedJoint component = gameObject.GetComponent<FixedJoint>();
			for (int i = 0; i < lines[currentMast.gameObject].Count; i++)
			{
				if (Vector3.Distance(previousMast.position, lines[currentMast.gameObject][i].transform.position) > Vector3.Distance(previousMast.position, gameObject.transform.position))
				{
					component.connectedBody = lines[currentMast.gameObject][i].GetComponent<Rigidbody>();
					break;
				}
			}
			lastAccumulated += flagSpacing;
		}
		return Mathf.Abs(lastAccumulated - num);
	}

	private Material GetNextFlagMaterial()
	{
		if (FlagMaterials.Count != 0)
		{
			Material result = FlagMaterials[currentMaterialIndex];
			currentMaterialIndex = (currentMaterialIndex + 1) % FlagMaterials.Count;
			return result;
		}
		return null;
	}

	private void BuildLines(Transform previousMast, Transform currentMast)
	{
		float num = Vector3.Distance(previousMast.position, currentMast.position) / SegmentsLength;
		int num2 = Mathf.FloorToInt(num);
		float num3 = SegmentsLength * (num - (float)Math.Truncate(num));
		int num4 = ((num3 > 0f) ? (num2 + 1) : num2);
		lines[currentMast.gameObject] = new List<GameObject>();
		Vector3 normalized = (currentMast.position - previousMast.position).normalized;
		for (int i = 0; i < num4; i++)
		{
			float num5 = ((i == num4 - 1) ? num3 : SegmentsLength);
			GameObject gameObject = UnityEngine.Object.Instantiate(LineSegment, previousMast.position + normalized * ((float)i * SegmentsLength + num5 * 0.5f), Quaternion.LookRotation(normalized), base.transform.Find("Container"));
			gameObject.SetActive(true);
			gameObject.GetComponent<Rigidbody>().mass = MassPerLine / (float)num4;
			gameObject.transform.localScale = new Vector3(LineSegment.transform.localScale.x, LineSegment.transform.localScale.y, num5);
			lines[currentMast.gameObject].Add(gameObject);
			CharacterJoint component = gameObject.GetComponent<CharacterJoint>();
			if (i == 0)
			{
				component.connectedBody = previousMast.GetComponentInParent<Rigidbody>();
				continue;
			}
			component.connectedBody = lines[currentMast.gameObject][lines[currentMast.gameObject].Count - 2].GetComponent<Rigidbody>();
			if (i == num4 - 1)
			{
				CharacterJoint characterJoint = currentMast.GetComponentInParent<Rigidbody>().gameObject.AddComponent<CharacterJoint>();
				characterJoint.connectedBody = gameObject.GetComponent<Rigidbody>();
				CharacterJoint component2 = lines[currentMast.gameObject][0].GetComponent<CharacterJoint>();
				characterJoint.autoConfigureConnectedAnchor = component2.autoConfigureConnectedAnchor;
				characterJoint.connectedAnchor = characterJoint.connectedBody.transform.InverseTransformPoint(currentMast.position);
				characterJoint.enablePreprocessing = component2.enablePreprocessing;
				characterJoint.enableProjection = component2.enableProjection;
				characterJoint.breakForce = component2.breakForce;
				characterJoint.breakTorque = component2.breakTorque;
				characterJoint.connectedMassScale = component2.connectedMassScale;
				characterJoint.massScale = component2.massScale;
			}
		}
	}
}
