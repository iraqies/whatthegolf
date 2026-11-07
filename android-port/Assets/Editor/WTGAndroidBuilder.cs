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
			Debug.Log("[WTGAndroidBuilder] Starting WHAT THE GOLF? (v20.5.34) Android APK build...");

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
			PlayerSettings.productName = "WHAT THE GOLF?";
			PlayerSettings.SetApplicationIdentifier(BuildTargetGroup.Android, "com.thelabelgames.golf");
			PlayerSettings.bundleVersion = "20.5.34";
			PlayerSettings.Android.bundleVersionCode = 200534;
			PlayerSettings.allowUnsafeCode = true;

			PlayerSettings.defaultInterfaceOrientation = UIOrientation.AutoRotation;
			PlayerSettings.allowedAutorotateToLandscapeLeft = true;
			PlayerSettings.allowedAutorotateToLandscapeRight = true;
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

			AssetDatabase.Refresh();

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
			string apkPath = Path.Combine(outDir, "WhatTheGolf-Android.apk");
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
