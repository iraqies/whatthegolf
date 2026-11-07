using Unity.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SVGImage : MaskableGraphic
{
	[SerializeField]
	private Sprite m_Sprite;

	[SerializeField]
	private bool m_PreserveAspect;

	private static NativeSlice<Color32> s_SpriteColor;

	private static NativeSlice<Vector2> s_TextCord2;

	private static UIVertex s_TempVertex;

	public bool preserveAspect
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public Sprite sprite
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public override Texture mainTexture => null;

	protected override void OnPopulateMesh(VertexHelper toFill)
	{
	}

	private void GenerateSprite(VertexHelper vh)
	{
	}

	private Vector2 GetDrawingDimensions(bool shouldPreserveAspect)
	{
		return default;
	}
}
