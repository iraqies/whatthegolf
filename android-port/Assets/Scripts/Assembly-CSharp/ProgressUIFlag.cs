using UnityEngine;

public class ProgressUIFlag : MonoBehaviour
{
	[SerializeField]
	private SVGImage uncompleted;

	[SerializeField]
	private SVGImage completed;

	public void Toggle(bool isCompleted)
	{
		if (uncompleted != null)
		{
			uncompleted.enabled = !isCompleted;
		}
		if (completed != null)
		{
			completed.enabled = isCompleted;
		}
	}

	public void SetColor(Color color)
	{
		if (completed != null)
		{
			completed.color = color;
		}
	}
}
