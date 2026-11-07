using UnityEngine;

namespace TMPro
{
	public static class TMPro_EventManager
	{
		public static readonly FastAction<object, Compute_DT_EventArgs> COMPUTE_DT_EVENT;

		public static readonly FastAction<bool, Material> MATERIAL_PROPERTY_EVENT;

		public static readonly FastAction<bool, Object> FONT_PROPERTY_EVENT;

		public static readonly FastAction<bool, Object> SPRITE_ASSET_PROPERTY_EVENT;

		public static readonly FastAction<bool, Object> TEXTMESHPRO_PROPERTY_EVENT;

		public static readonly FastAction<GameObject, Material, Material> DRAG_AND_DROP_MATERIAL_EVENT;

		public static readonly FastAction<bool> TEXT_STYLE_PROPERTY_EVENT;

		public static readonly FastAction<Object> COLOR_GRADIENT_PROPERTY_EVENT;

		public static readonly FastAction TMP_SETTINGS_PROPERTY_EVENT;

		public static readonly FastAction RESOURCE_LOAD_EVENT;

		public static readonly FastAction<bool, Object> TEXTMESHPRO_UGUI_PROPERTY_EVENT;

		public static readonly FastAction<Object> TEXT_CHANGED_EVENT;

		public static void ON_TEXT_CHANGED(Object obj)
		{
		}
	}
}
