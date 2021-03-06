﻿using System.IO;
using System.Text;
using UnityEditor;
using UnityEngine;

namespace Quat
{
    public class SequenceCreator : MonoBehaviour
    {
        [MenuItem("Sequence/Create New Sequence")]
        public static void CreateTemp()
        {
            string content = File.ReadAllText($"{Application.dataPath}/Quat/Scripts/Temp/TempSequence.cs");
            content = content.Replace("TempSequence", "NewSequence");
            File.WriteAllText($"{Application.dataPath}/NewSequence.cs", content, Encoding.UTF8);
            AssetDatabase.Refresh();
        }
    }
}