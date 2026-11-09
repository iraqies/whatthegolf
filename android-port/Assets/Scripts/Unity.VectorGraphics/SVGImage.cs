using Unity.Collections;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.U2D;
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
		get => m_PreserveAspect;
		set
		{
			if (m_PreserveAspect != value)
			{
				m_PreserveAspect = value;
				SetVerticesDirty();
			}
		}
	}

	public Sprite sprite
	{
		get => m_Sprite;
		set
		{
			if (m_Sprite != value)
			{
				m_Sprite = value;
				SetAllDirty();
			}
		}
	}

	public override Texture mainTexture
	{
		get
		{
			if (m_Sprite == null)
			{
				if (material != null && material.mainTexture != null)
					return material.mainTexture;
				return s_WhiteTexture;
			}
			return m_Sprite.texture != null ? m_Sprite.texture : s_WhiteTexture;
		}
	}

	protected override void OnPopulateMesh(VertexHelper toFill)
	{
		if (m_Sprite == null)
		{
			base.OnPopulateMesh(toFill);
			return;
		}
		GenerateSprite(toFill);
	}

	private void GenerateSprite(VertexHelper vh)
	{
		if (m_Sprite == null || vh == null)
			return;

		Vector2[] vertices = m_Sprite.vertices;
		if (vertices == null || vertices.Length == 0)
			return;

		float minX = float.MaxValue, maxX = float.MinValue;
		float minY = float.MaxValue, maxY = float.MinValue;
		for (int i = 0; i < vertices.Length; i++)
		{
			Vector2 v = vertices[i];
			if (v.x < minX) minX = v.x;
			if (v.x > maxX) maxX = v.x;
			if (v.y < minY) minY = v.y;
			if (v.y > maxY) maxY = v.y;
		}

		float vWidth = Mathf.Max(maxX - minX, 0.0001f);
		float vHeight = Mathf.Max(maxY - minY, 0.0001f);
		float ppu = m_Sprite.pixelsPerUnit > 0.01f ? m_Sprite.pixelsPerUnit : 100f;

		float spriteW = m_Sprite.rect.width;
		float spriteH = m_Sprite.rect.height;
		if (!float.IsFinite(spriteW) || spriteW <= 0.001f)
			spriteW = vWidth * ppu;
		if (!float.IsFinite(spriteH) || spriteH <= 0.001f)
			spriteH = vHeight * ppu;

		Vector2 boundsSize = m_Sprite.bounds.size;
		if (!float.IsFinite(boundsSize.x) || boundsSize.x <= 0.0001f)
			boundsSize.x = vWidth;
		if (!float.IsFinite(boundsSize.y) || boundsSize.y <= 0.0001f)
			boundsSize.y = vHeight;

		Vector2 spritePivot = m_Sprite.pivot;
		float pivNormX = (float.IsFinite(spritePivot.x) && spriteW > 0.001f) ? (spritePivot.x / spriteW) : (-minX / vWidth);
		float pivNormY = (float.IsFinite(spritePivot.y) && spriteH > 0.001f) ? (spritePivot.y / spriteH) : (-minY / vHeight);
		if (!float.IsFinite(pivNormX)) pivNormX = 0.5f;
		if (!float.IsFinite(pivNormY)) pivNormY = 0.5f;

		Vector2 rtPivot = rectTransform.pivot;
		Vector2 dims = GetDrawingDimensions(m_PreserveAspect, spriteW, spriteH);

		bool hasColors = m_Sprite.HasVertexAttribute(VertexAttribute.Color);
		if (hasColors)
			s_SpriteColor = m_Sprite.GetVertexAttribute<Color32>(VertexAttribute.Color);

		bool hasUV2 = m_Sprite.HasVertexAttribute(VertexAttribute.TexCoord2);
		if (hasUV2)
			s_TextCord2 = m_Sprite.GetVertexAttribute<Vector2>(VertexAttribute.TexCoord2);

		vh.Clear();
		Vector2[] uvs = m_Sprite.uv;

		Vector2 origin = new Vector2(
			(rtPivot.x - pivNormX) * dims.x,
			(rtPivot.y - pivNormY) * dims.y
		);

		Color baseColor = color;
		for (int i = 0; i < vertices.Length; i++)
		{
			Vector3 pos = new Vector3(
				vertices[i].x / boundsSize.x * dims.x - origin.x,
				vertices[i].y / boundsSize.y * dims.y - origin.y,
				0f
			);
			Color32 vertColor = hasColors
				? (Color32)(baseColor * (Color)s_SpriteColor[i])
				: (Color32)baseColor;
			Vector4 uv0 = (uvs != null && i < uvs.Length) ? (Vector4)uvs[i] : Vector4.zero;
			vh.AddVert(pos, vertColor, uv0);
			if (hasUV2)
			{
				int idx = vh.currentVertCount - 1;
				vh.PopulateUIVertex(ref s_TempVertex, idx);
				s_TempVertex.uv2 = s_TextCord2[i];
				vh.SetUIVertex(s_TempVertex, idx);
			}
		}

		ushort[] triangles = m_Sprite.triangles;
		if (triangles != null)
		{
			for (int j = 0; j + 2 < triangles.Length; j += 3)
			{
				vh.AddTriangle(triangles[j], triangles[j + 1], triangles[j + 2]);
			}
		}
	}

	private Vector2 GetDrawingDimensions(bool shouldPreserveAspect, float spriteW = 0f, float spriteH = 0f)
	{
		if (m_Sprite == null)
			return Vector2.zero;
		if (spriteW <= 0f) spriteW = m_Sprite.rect.width;
		if (spriteH <= 0f) spriteH = m_Sprite.rect.height;
		Vector2 size = new Vector2(Mathf.RoundToInt(spriteW), Mathf.RoundToInt(spriteH));
		if (size.x <= 0f || size.y <= 0f)
			size = new Vector2(Mathf.Max(spriteW, 1f), Mathf.Max(spriteH, 1f));
		Rect r = GetPixelAdjustedRect();
		if (shouldPreserveAspect && size.sqrMagnitude > 0f && r.width > 0f && r.height > 0f)
		{
			float spriteRatio = size.x / size.y;
			float rectRatio = r.width / r.height;
			if (spriteRatio > rectRatio)
				r.height = r.width * (1f / spriteRatio);
			else
				r.width = r.height * spriteRatio;
		}
		return r.size;
	}
}
