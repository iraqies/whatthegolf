using System.Collections;
using UnityEngine;

[ExecuteAlways]
public class AlignObjectWithScreenEdge : MonoBehaviour
{
	public enum EdgeEnum
	{
		Top = 0,
		Bottom = 1,
		Left = 2,
		Right = 3
	}

	public EdgeEnum EdgeToAlignTo;

	public bool ForceUpdate;

	private IEnumerator Start()
	{
		return null;
	}

	private void Update()
	{
	}

	private void SetPosition()
	{
	}
}
