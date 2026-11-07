using System.Collections.Generic;
using UnityEngine;

public class ToggleObjectBasedOnAvatarSelected : MonoBehaviour
{
	public PlayerColors.AvatarIDs AvatarIDThatEnablesObject;

	public List<Renderer> RenderersToDisableIfSeleceted;

	public void UpdateBasedOnAvatar(MultiplayerConfiguration.PlayerInfo player)
	{
	}
}
