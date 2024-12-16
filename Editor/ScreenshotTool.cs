using System;
using UnityEditor;
using UnityEngine;

namespace ScreenshotTool.Editor
{
    public class ScreenshotTool : EditorWindow
    {

        [MenuItem("Tools/Capture Screenshot")]
        static void CaptureScreenshot()
        {
            ScreenCapture.CaptureScreenshot($"screenshot_{DateTime.Now:HH_mm_ss}.png", 1);
        }
    }
}


