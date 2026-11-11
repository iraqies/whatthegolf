using System.Collections.Generic;
using UnityEngine;

public class ToggleObjectBasedOnAvatarSelected : MonoBehaviour
{
	public PlayerColors.AvatarIDs AvatarIDThatEnablesObject;

	public List<Renderer> RenderersToDisableIfSeleceted;

	public void UpdateBasedOnAvatar(MultiplayerConfiguration.PlayerInfo player)
	{
		if (player == null || player.color == null)
			return;
		gameObject.SetActive(player.color.AvatarID == AvatarIDThatEnablesObject);
		if (RenderersToDisableIfSeleceted != null)
		{
			RenderersToDisableIfSeleceted.ForEach(r =>
			{
				if (r != null)
					r.enabled = false;
			});
		}
	}
}
