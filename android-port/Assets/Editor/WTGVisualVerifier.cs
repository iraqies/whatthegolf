using System;
using System.IO;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

public static class WTGVisualVerifier
{
	private const int Width = 576;
	private const int Height = 1280;
	private const string OutDir = "/tmp/wtg_verify";

	public static void RunVerification()
	{
		try
		{
			Directory.CreateDirectory(OutDir);
			Debug.Log("[WTGVisualVerifier] Starting visual verification renders...");

			// 1. Hub_Overworld.unity
			EditorSceneManager.OpenScene("Assets/_HubMenu/Hub_Overworld.unity", OpenSceneMode.Single);
			var gf = UnityEngine.Object.FindObjectOfType<GridFiller>();
			if (gf != null)
			{
				if (gf.rotatedMap != null) gf.rotatedMap.SetActive(true);
				if (gf.normalMap != null) gf.normalMap.SetActive(false);
			}
			foreach (var hs in UnityEngine.Object.FindObjectsOfType<HubSection>(true))
			{
				if (hs != null && hs.Container != null)
					hs.Container.SetActive(true);
			}

			Camera hubCam = FindMainCamera();
			if (hubCam != null)
			{
				hubCam.orthographic = true;
				hubCam.orthographicSize = 8.5f;
				hubCam.transform.rotation = Quaternion.identity;

				// Shot 1: Hub Main Menu
				hubCam.transform.position = new Vector3(-36.0f, -64.5f, -20.0f);
				RenderCameraToPng(hubCam, Path.Combine(OutDir, "1_hub_main.png"));

				// Shot 2: Hub VIP / Leaderboards / Achievements / More?
				hubCam.transform.position = new Vector3(-53.5f, -64.5f, -20.0f);
				RenderCameraToPng(hubCam, Path.Combine(OutDir, "2_hub_vip.png"));

				// Shot 3: Hub Intro Tunnel Hole Variant
				hubCam.orthographicSize = 11.0f;
				hubCam.transform.position = new Vector3(-36.0f, -91.0f, -20.0f);
				RenderCameraToPng(hubCam, Path.Combine(OutDir, "3_hub_tunnel.png"));
			}

			// 2. main overworld tunnel loader.unity
			EditorSceneManager.OpenScene("Assets/Scenes/GolfGames/1. GOLF IS BORING/main overworld tunnel loader.unity", OpenSceneMode.Single);
			var tunnel = UnityEngine.Object.FindObjectOfType<IntroTunnelInOverworld>();
			Vector3 worldLogo = new Vector3(-32.55f, -85.32f, 0f);
			Vector3 worldCorners = new Vector3(-35.2f, -48.4f, 0f);
			if (tunnel != null)
			{
				// Invoke Awake logic to verify runtime sorting orders & bulge setup
				tunnel.SendMessage("Awake", SendMessageOptions.DontRequireReceiver);
				worldLogo = tunnel.transform.TransformPoint(new Vector3(0.15f, -75.0f, 0f));
				worldCorners = tunnel.transform.TransformPoint(new Vector3(-2.5f, -34.2f, 0f));
				if (tunnel.ballBulge != null)
				{
					tunnel.ballBulge.position = tunnel.transform.TransformPoint(new Vector3(0.146f, -79.0f, 0.5f));
					tunnel.ballBulge.localScale = new Vector3(0.15410566f, 0.15410566f, 0.15410566f);
				}
			}
			Camera tunCam = FindMainCamera();
			if (tunCam != null)
			{
				tunCam.orthographic = true;
				tunCam.orthographicSize = 14.0f;
				tunCam.transform.rotation = Quaternion.identity;

				// Shot 4: Tunnel Logo + Bulge + MarioShortcutPipeEntryNorth
				tunCam.transform.position = new Vector3(worldLogo.x, worldLogo.y, -10.0f);
				RenderCameraToPng(tunCam, Path.Combine(OutDir, "4_tunnel_logo_bulge.png"));

				// Shot 5: Tunnel 4 Pipe Corners + MarioPipeShine
				tunCam.orthographicSize = 8.0f;
				tunCam.transform.position = new Vector3(worldCorners.x, worldCorners.y, -10.0f);
				RenderCameraToPng(tunCam, Path.Combine(OutDir, "5_tunnel_corners.png"));
			}

			// 3. Tutorial.unity (3D Golf Level)
			EditorSceneManager.OpenScene("Assets/Scenes/GolfGames/1. GOLF IS BORING/Tutorial.unity", OpenSceneMode.Single);
			Camera tutCam = FindMainCamera();
			if (tutCam != null)
			{
				RenderCameraToPng(tutCam, Path.Combine(OutDir, "6_tutorial_3d.png"));
			}

			// 4. 2D HoleInOne 01 basic.unity (Boss Fight)
			EditorSceneManager.OpenScene("Assets/Scenes/GolfGames/Hole In One/2D HoleInOne 01 basic.unity", OpenSceneMode.Single);
			foreach (var tr in UnityEngine.Object.FindObjectsOfType<HoleInOneTransition>(true))
			{
				if (tr != null) tr.gameObject.SetActive(false);
			}
			Camera bossCam = FindMainCamera();
			if (bossCam != null)
			{
				RenderCameraToPng(bossCam, Path.Combine(OutDir, "7_boss_holeinone.png"));
			}

			Debug.Log("[WTGVisualVerifier] Completed all 7 verification renders successfully.");
			EditorApplication.Exit(0);
		}
		catch (Exception ex)
		{
			Debug.LogError("[WTGVisualVerifier] Exception: " + ex);
			EditorApplication.Exit(1);
		}
	}

	private static Camera FindMainCamera()
	{
		if (Camera.main != null) return Camera.main;
		foreach (var c in UnityEngine.Object.FindObjectsOfType<Camera>(true))
		{
			if (c != null && c.gameObject.name.Contains("Main"))
				return c;
		}
		return UnityEngine.Object.FindObjectOfType<Camera>();
	}

	private static void RenderCameraToPng(Camera cam, string outPath)
	{
		RenderTexture rt = new RenderTexture(Width, Height, 24, RenderTextureFormat.ARGB32);
		RenderTexture prevTarget = cam.targetTexture;
		RenderTexture prevActive = RenderTexture.active;

		cam.targetTexture = rt;
		cam.Render();

		RenderTexture.active = rt;
		Texture2D tex = new Texture2D(Width, Height, TextureFormat.RGB24, false);
		tex.ReadPixels(new Rect(0, 0, Width, Height), 0, 0);
		tex.Apply();

		cam.targetTexture = prevTarget;
		RenderTexture.active = prevActive;
		UnityEngine.Object.DestroyImmediate(rt);

		byte[] png = tex.EncodeToPNG();
		UnityEngine.Object.DestroyImmediate(tex);
		File.WriteAllBytes(outPath, png);
		Debug.Log($"[WTGVisualVerifier] Saved {outPath} ({png.Length} bytes)");
	}
}
