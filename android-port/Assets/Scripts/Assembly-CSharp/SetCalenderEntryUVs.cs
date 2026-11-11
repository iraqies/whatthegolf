using UnityEngine;

public class SetCalenderEntryUVs : MonoBehaviour
{
	public RectTransform ParentRect;

	public RectTransform Rect;

	public Material Mat;

	public SVGImage Image;

	public Vector2 offset;

	private Material instancedMaterial;

	private void Start()
	{
		if (Mat != null)
		{
			instancedMaterial = Instantiate(Mat);
			if (Image != null)
			{
				Image.material = instancedMaterial;
			}
		}
	}

	private void Update()
	{
		if (Rect == null || ParentRect == null || instancedMaterial == null)
		{
			return;
		}
		Vector2 tiling = new Vector2(
			Rect.rect.width / Mathf.Max(0.001f, ParentRect.rect.width),
			Rect.rect.height / Mathf.Max(0.001f, ParentRect.rect.height)
		);
		Vector2 off = new Vector2(
			(offset.x + (Rect.anchoredPosition.x - ParentRect.anchoredPosition.x)) / Mathf.Max(0.001f, ParentRect.rect.width),
			(Rect.anchoredPosition.y + ParentRect.anchoredPosition.y + offset.y) / Mathf.Max(0.001f, ParentRect.rect.height)
		);
		instancedMaterial.SetVector("_Tiling", tiling);
		instancedMaterial.SetVector("_Offset", off);
	}

	public void SetOverlayColor(Color col)
	{
		if (instancedMaterial != null)
		{
			instancedMaterial.SetColor("_OverlayColor", col);
		}
	}

	private void OnDestroy()
	{
		if (instancedMaterial != null)
		{
			Destroy(instancedMaterial);
			instancedMaterial = null;
		}
	}
}
