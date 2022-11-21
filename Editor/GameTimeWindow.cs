using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Playables;

namespace PixelWizards.GameTime
{
    public class GameTimeWindow : EditorWindow
    {
        // the icons
        private static Texture quarterSpeed, halfSpeed, normalSpeed, doubleSpeed, quadSpeed, pause, reverse, stop;

        private float buttonWidth = 32f;
        private float buttonHeight = 32f;
        private static float windowWidth = 220;
        private static float windowHeight = 35f;
        
        [MenuItem("Window/Sequencing/Game Time Controller")]
        public static void ShowWindow()
        {
            var window = EditorWindow.GetWindow(typeof(GameTimeWindow));
            window.titleContent = new GUIContent("Game Time Controls");
            window.maxSize = new Vector2(windowWidth, windowHeight);
            window.minSize = new Vector2(windowWidth, windowHeight);
            LoadIcons();
        }
        
        private static void LoadIcons()
        {
            quarterSpeed = (Texture2D)AssetDatabase.LoadAssetAtPath("Packages/com.pixelwizards.gametimecontroller/Icons/quarterspeed.png", typeof(Texture2D));
            halfSpeed = (Texture2D)AssetDatabase.LoadAssetAtPath("Packages/com.pixelwizards.gametimecontroller/Icons/halfspeed.png", typeof(Texture2D));
            normalSpeed = (Texture2D)AssetDatabase.LoadAssetAtPath("Packages/com.pixelwizards.gametimecontroller/Icons/normalspeed.png", typeof(Texture2D));
            doubleSpeed = (Texture2D)AssetDatabase.LoadAssetAtPath("Packages/com.pixelwizards.gametimecontroller/Icons/doublespeed.png", typeof(Texture2D));
            quadSpeed = (Texture2D)AssetDatabase.LoadAssetAtPath("Packages/com.pixelwizards.gametimecontroller/Icons/quadspeed.png", typeof(Texture2D));
            pause = (Texture2D)AssetDatabase.LoadAssetAtPath("Packages/com.pixelwizards.gametimecontroller/Icons/pause.png", typeof(Texture2D));
        }

        void OnGUI()
        {
            GUILayout.BeginVertical();
            {
                GUILayout.BeginHorizontal();
                {
                    if (GUILayout.Button(new GUIContent(quarterSpeed, "Quarter (0.25x) Speed"), GUILayout.Width(buttonWidth), GUILayout.Height(buttonHeight)))
                    {
                        Time.timeScale = 0.25f;
                    }

                    if (GUILayout.Button(new GUIContent(halfSpeed, "Half (0.5x) Speed"), GUILayout.Width(buttonWidth), GUILayout.Height(buttonHeight)))
                    {
                        Time.timeScale = 0.5f;
                    }
                    
                    if (GUILayout.Button(new GUIContent(pause, "Pause (0x) playback"), GUILayout.Width(buttonWidth), GUILayout.Height(buttonHeight)))
                    {
                        Time.timeScale = 0f;
                    }

                    if (GUILayout.Button(new GUIContent(normalSpeed, "Normal (1x) Speed"), GUILayout.Width(buttonWidth), GUILayout.Height(buttonHeight)))
                    {
                        Time.timeScale = 1.0f;
                    }
                    
                    if (GUILayout.Button(new GUIContent(doubleSpeed, "Double (2x) Speed"), GUILayout.Width(buttonWidth), GUILayout.Height(buttonHeight)))
                    {
                        Time.timeScale = 2f;
                    }

                    if (GUILayout.Button(new GUIContent(quadSpeed, "Quad (4x) Speed"), GUILayout.Width(buttonWidth), GUILayout.Height(buttonHeight)))
                    {
                        Time.timeScale = 4f;
                    }
                }
                GUILayout.EndHorizontal();
            }
            GUILayout.EndVertical();
        }
    }
}