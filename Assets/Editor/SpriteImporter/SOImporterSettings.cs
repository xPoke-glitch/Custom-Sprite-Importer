using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CreateAssetMenu(fileName ="SpriteImporterSettings", menuName ="Sprite Importer/Settings")]
public class SOImporterSettings : ScriptableObject
{
    public bool IsActive = false;
    public string PresetPath = "Assets/Editor/SpriteImporter/Settings/TextureImporterPreset.preset";
}
