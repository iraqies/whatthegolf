using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Core;
using UnityEditor;
using UnityEditor.Build.Reporting;
using UnityEngine;

public static class WTGAndroidBuilder
{
	[MenuItem("WhatTheGolf/Build Android APK")]
	public static void BuildAll()
	{
		try
		{
			Debug.Log("[WTGAndroidBuilder] Starting WHAT THE GOLF? (v1.0.43) Android APK build...");

			string sdkRoot = Environment.GetEnvironmentVariable("ANDROID_SDK_ROOT") ?? "/home/ubuntu/mm-sdk";
			string ndkRoot = Environment.GetEnvironmentVariable("ANDROID_NDK_ROOT") ?? "/home/ubuntu/ndk-r23b";
			string jdkRoot = Environment.GetEnvironmentVariable("JAVA_HOME") ?? "/home/ubuntu/jdk11";

			if (Directory.Exists(sdkRoot)) EditorPrefs.SetString("AndroidSdkRoot", sdkRoot);
			if (Directory.Exists(ndkRoot))
			{
				EditorPrefs.SetString("AndroidNdkRoot", ndkRoot);
				EditorPrefs.SetString("AndroidNdkRootR23B", ndkRoot);
			}
			if (Directory.Exists(jdkRoot))
			{
				EditorPrefs.SetString("JdkPath", jdkRoot);
				EditorPrefs.SetString("Jdk11Path", jdkRoot);
				EditorPrefs.SetBool("JdkUseEmbedded", false);
			}

			PlayerSettings.companyName = "Triband";
			PlayerSettings.productName = "GOLF?";
			PlayerSettings.SetApplicationIdentifier(BuildTargetGroup.Android, "com.thelabelgames.golf");
			PlayerSettings.bundleVersion = "1.0.43";
			PlayerSettings.Android.bundleVersionCode = 200543;
			PlayerSettings.allowUnsafeCode = true;

			PlayerSettings.defaultInterfaceOrientation = UIOrientation.Portrait;
			PlayerSettings.allowedAutorotateToLandscapeLeft = false;
			PlayerSettings.allowedAutorotateToLandscapeRight = false;
			PlayerSettings.allowedAutorotateToPortrait = true;
			PlayerSettings.allowedAutorotateToPortraitUpsideDown = false;

			PlayerSettings.Android.minSdkVersion = AndroidSdkVersions.AndroidApiLevel24;
			PlayerSettings.Android.targetSdkVersion = (AndroidSdkVersions)34;
			PlayerSettings.Android.renderOutsideSafeArea = true;
			PlayerSettings.SplashScreen.show = false;
			PlayerSettings.SplashScreen.showUnityLogo = false;

			PlayerSettings.SetUseDefaultGraphicsAPIs(BuildTarget.Android, false);
			PlayerSettings.SetGraphicsAPIs(
				BuildTarget.Android,
				new UnityEngine.Rendering.GraphicsDeviceType[] { UnityEngine.Rendering.GraphicsDeviceType.OpenGLES3 }
			);
			PlayerSettings.SetScriptingBackend(BuildTargetGroup.Android, ScriptingImplementation.IL2CPP);

			string archEnv = Environment.GetEnvironmentVariable("WTG_ARCH") ?? "ARM64";
			if (archEnv == "X86_64")
				PlayerSettings.Android.targetArchitectures = AndroidArchitecture.X86_64;
			else if (archEnv == "BOTH")
				PlayerSettings.Android.targetArchitectures = AndroidArchitecture.ARM64 | AndroidArchitecture.X86_64;
			else
				PlayerSettings.Android.targetArchitectures = AndroidArchitecture.ARM64;

			AssetDatabase.Refresh(ImportAssetOptions.ForceSynchronousImport);

			const string iconAssetPath = "Assets/Resources/AppIcon.png";
			if (File.Exists(iconAssetPath))
			{
				AssetDatabase.ImportAsset(iconAssetPath, ImportAssetOptions.ForceSynchronousImport);
				TextureImporter ti = AssetImporter.GetAtPath(iconAssetPath) as TextureImporter;
				if (ti != null)
				{
					ti.textureType = TextureImporterType.Default;
					ti.isReadable = true;
					ti.alphaIsTransparency = true;
					ti.mipmapEnabled = false;
					ti.npotScale = TextureImporterNPOTScale.None;
					ti.SaveAndReimport();
				}
				Texture2D appIcon = AssetDatabase.LoadAssetAtPath<Texture2D>(iconAssetPath);
				if (appIcon != null)
				{
					PlayerSettings.SetIconsForTargetGroup(BuildTargetGroup.Unknown, new Texture2D[] { appIcon });
					int[] iconSizes = PlayerSettings.GetIconSizesForTargetGroup(BuildTargetGroup.Android);
					if (iconSizes != null && iconSizes.Length > 0)
					{
						Texture2D[] androidIcons = new Texture2D[iconSizes.Length];
						for (int i = 0; i < iconSizes.Length; i++)
							androidIcons[i] = appIcon;
						PlayerSettings.SetIconsForTargetGroup(BuildTargetGroup.Android, androidIcons);
					}
					Debug.Log("[WTGAndroidBuilder] Applied original WHAT THE GOLF? AppIcon.png to PlayerSettings.");
				}
			}

			var scenes = EditorBuildSettings.scenes
				.Where(s => s != null && s.enabled && File.Exists(s.path))
				.Select(s => s.path)
				.ToList();

			if (!scenes.Contains("Assets/Scenes/_Start.unity") && File.Exists("Assets/Scenes/_Start.unity"))
				scenes.Insert(0, "Assets/Scenes/_Start.unity");
			if (!scenes.Contains("Assets/Scenes/Loading.unity") && File.Exists("Assets/Scenes/Loading.unity"))
				scenes.Insert(Mathf.Min(1, scenes.Count), "Assets/Scenes/Loading.unity");

			string outDir = Environment.GetEnvironmentVariable("WTG_BUILD_DIR") ?? "/home/ubuntu/c113work/build";
			Directory.CreateDirectory(outDir);
			string apkPath = Path.Combine(outDir, "WhatTheGolf-Android-v43.apk");
			if (File.Exists(apkPath))
				File.Delete(apkPath);

			EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTargetGroup.Android, BuildTarget.Android);
			EditorUserBuildSettings.exportAsGoogleAndroidProject = false;
			EditorUserBuildSettings.androidBuildSystem = AndroidBuildSystem.Gradle;

			var opts = new BuildPlayerOptions
			{
				scenes = scenes.ToArray(),
				locationPathName = apkPath,
				target = BuildTarget.Android,
				targetGroup = BuildTargetGroup.Android,
				options = BuildOptions.None
			};

			BuildReport report = BuildPipeline.BuildPlayer(opts);
			Debug.LogFormat(
				"[WTGAndroidBuilder] BuildPlayer result: {0}, totalSize={1}, totalErrors={2}",
				report.summary.result,
				report.summary.totalSize,
				report.summary.totalErrors
			);

			if (report.summary.result != BuildResult.Succeeded)
			{
				EditorApplication.Exit(2);
				return;
			}
			EditorApplication.Exit(0);
		}
		catch (Exception ex)
		{
			Debug.LogError("[WTGAndroidBuilder] Exception: " + ex);
			EditorApplication.Exit(1);
		}
	}
}
