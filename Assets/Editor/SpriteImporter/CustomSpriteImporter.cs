using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.Presets;
public class CustomSpriteImporter : AssetPostprocessor
{ 
    private bool _isActive = true;

    void OnPreprocessAsset()
    {
        if (!_isActive)
            return;

        TextureImporter texImporter = assetImporter as TextureImporter;

        // Get the preset
        Preset preset = (Preset) AssetDatabase.LoadAssetAtPath("Assets/Editor/SpriteImporter/Settings/TextureImporterPreset.preset", typeof(Preset));

        if(preset == null)
        {
            Debug.LogError("[CustomSpriteImporter OnPreprocessAsset] Settings' preset not found");
            return;
        }

        if (texImporter != null)
        {
            TextureImporterSettings texSettings = new TextureImporterSettings();

            if (!preset.CanBeAppliedTo(texImporter))
            {
                Debug.LogError("Source and target asset types do not match!");
            }
            else
            {
                // Apply the preset to the importer - custom settings
                preset.ApplyTo(texImporter);
            }

            Debug.Log("[CustomSpriteImporter OnPreprocessAsset] Asset Done : " + assetPath);
        }
     
    }
}
