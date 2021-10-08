using System.IO;
using UnityEditor;
using UnityEngine;

namespace Demonics.Base
{
    public class FolderCreator : EditorWindow
    {
        private bool _create3DFolders;
        private bool _createHDRPFolders;


        [MenuItem("Demonics/Folder Creator")]
        public static void ShowWindow()
        {
            GetWindow(typeof(FolderCreator), false, "Folder Creator");
        }

        void OnGUI()
        {
            EditorGUILayout.Space();
            if (GUILayout.Button("Create folders", GUILayout.Height(50f)))
            {
                CreateFolders();
            }
            EditorGUILayout.Space();
            EditorGUILayout.LabelField("", GUI.skin.horizontalSlider);
            EditorGUILayout.Space();
            GUILayout.BeginHorizontal("box");
            _create3DFolders = GUILayout.Toggle(_create3DFolders, "3D", GUILayout.Height(40f));
            GUILayout.EndHorizontal();
            GUILayout.BeginHorizontal("box");
            _createHDRPFolders = GUILayout.Toggle(_createHDRPFolders, "HDRP", GUILayout.Height(40f));
            GUILayout.EndHorizontal();
        }

        private void CreateFolders()
        {
            if (_create3DFolders)
            {
                Directory.CreateDirectory(Path.Combine(Application.dataPath, "_Project/Models"));
                Directory.CreateDirectory(Path.Combine(Application.dataPath, "_Project/Textures"));
            }
            if (_createHDRPFolders)
            {
                Directory.CreateDirectory(Path.Combine(Application.dataPath, "_Project/Profiles"));
            }
            AssetDatabase.Refresh();
        }
    }
}