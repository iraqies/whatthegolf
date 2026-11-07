using System.Threading.Tasks;
using UnityEngine;

public class StartupLoadingScreen : MonoBehaviour
{
	public static StartupLoadingScreen Instance;

	[SerializeField] private SVGImage image;
	[SerializeField] private AnimateRectTransform animateRectTransform;

	private void Awake()
	{
		Instance = this;
	}

	public Task Show()
	{
		if (gameObject != null)
			gameObject.SetActive(true);
		return Task.CompletedTask;
	}

	public void Hide()
	{
		if (gameObject != null)
			gameObject.SetActive(false);
	}
}
