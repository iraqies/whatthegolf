using System.Threading.Tasks;
using UnityEngine;

public class StartupLoadingScreen : MonoBehaviour
{
	public static StartupLoadingScreen Instance;

	[SerializeField]
	private SVGImage image;

	[SerializeField]
	private AnimateRectTransform animateRectTransform;

	private void Awake()
	{
	}

	public Task Show()
	{
		return null;
	}

	public void Hide()
	{
	}
}
