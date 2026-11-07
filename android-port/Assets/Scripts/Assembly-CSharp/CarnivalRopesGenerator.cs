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

	public float SegmentsLength;

	public float MassPerLine;

	public List<Material> FlagMaterials;

	public FlagDistributionTypeEnum FlagDistributionType;

	public int FlagsPerSegment;

	public float FlagSpacing;

	public bool ContinuousUpdate;

	public bool DoUpdate;

	private List<GameObject> SpawnedMasts;

	private Dictionary<GameObject, List<GameObject>> lines;

	private int currentMaterialIndex;

	private void Update()
	{
	}

	private void PlaceFlagsPerSegment(Transform previousMast, Transform currentMast)
	{
	}

	private float PlaceFlagsEvenly(Transform previousMast, Transform currentMast, float lastAccumulated)
	{
		return 0f;
	}

	private Material GetNextFlagMaterial()
	{
		return null;
	}

	private void BuildLines(Transform previousMast, Transform currentMast)
	{
	}
}
