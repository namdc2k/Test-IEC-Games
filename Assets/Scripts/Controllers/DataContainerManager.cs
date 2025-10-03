using System;
using SO;
using UnityEngine;
using UnityEngine.Serialization;

namespace Controllers{
    public class DataContainerManager : MonoBehaviour{
        private static DataContainerManager _instance;

        private void Awake() {
            _instance = this;
        }

        [FormerlySerializedAs("_container")] [SerializeField]private SOContainer soContainer;
        public static SOItemNormal GetNormalItem(int itemID) {
            return _instance.soContainer.items[itemID];
        }
    }
}