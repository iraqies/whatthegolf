using System.Collections;
using CameraStack;
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
		yield return null;
		SetPosition();
	}

	private void Update()
	{
		if (ForceUpdate)
		{
			SetPosition();
			ForceUpdate = false;
		}
	}

	private void SetPosition()
	{
		Vector3 direction = new Vector3((EdgeToAlignTo == EdgeEnum.Left) ? (-0.5f) : ((EdgeToAlignTo == EdgeEnum.Right) ? 0.5f : 0f), (EdgeToAlignTo == EdgeEnum.Bottom) ? (-0.5f) : ((EdgeToAlignTo == EdgeEnum.Top) ? 0.5f : 0f), 0f);
		Vector3 vector = CameraManager.Instance.transform.TransformDirection(direction);
		Vector3 vector2 = Camera.main.ViewportToWorldPoint(new Vector3(vector.x + 0.5f, vector.y + 0.5f, 0f));
		base.transform.position = new Vector3(vector2.x, vector2.y, base.transform.position.z);
	}
}
