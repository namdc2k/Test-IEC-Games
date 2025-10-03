using System.Collections.Generic;
using Extensions;
using UnityEngine;

namespace Controllers{
    public class PoolItemNormal : MonoBehaviour{
        private static PoolItemNormal _instance;
        private Queue<GameObject> _poolItems;
        [SerializeField] GameObject prefab; 
        
        private void Awake() {
            _instance = this;
            _poolItems = new Queue<GameObject>();
        }

        public static GameObject SpawnItem() {
            if (_instance._poolItems.Count > 0) {
                GameObject go = _instance._poolItems.Dequeue();
                go.SetActive(true);
                go.transform.ResetScale();
                return go;
            }
            GameObject go1 = Instantiate(_instance.prefab, _instance.transform);
            return go1;
        }
        
        public static void DeSpawnItem(GameObject item) {
            item.SetActive(false);
            _instance._poolItems.Enqueue(item);
        }
    }
}