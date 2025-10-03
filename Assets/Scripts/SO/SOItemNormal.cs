using System.IO;
using Sirenix.OdinInspector;
using UnityEditor;
using UnityEngine;

namespace SO
{
    [CreateAssetMenu(fileName = "ITEM_NORMAL_", menuName = "ITEM/NORMAL", order = 0)]
    public class SOItemNormal : ScriptableObject
    {
        //TODO: Create Data for item 
        // Quick test 
        public Sprite texture;

        /// <summary>
        /// Applicable for large games and can load from Addressable instead of loading from Resource
        /// </summary>
        public string pathName;

#if UNITY_EDITOR
        /// <summary>
        /// Set pathName automatically from texture (relative Resources path)
        /// Example: "Textures/Fish/fish_01"
        /// </summary>
        [Button("Load Path")]
        public void SetPathFromSprite()
        {
            if (texture == null)
            {
                Debug.LogWarning("⚠ No texture assigned!");
                return;
            }

            string fullPath = AssetDatabase.GetAssetPath(texture);
            if (fullPath.StartsWith("Assets/Resources/"))
            {
                string relativePath = fullPath.Substring("Assets/Resources/".Length);
                relativePath = Path.ChangeExtension(relativePath, null);
                pathName = relativePath;
            }
            else
            {
                pathName = fullPath;
            }

            EditorUtility.SetDirty(this);
        }
#endif
    }
}