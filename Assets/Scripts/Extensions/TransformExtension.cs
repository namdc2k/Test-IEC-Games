using UnityEngine;

namespace Extensions{
    public static class TransformExtension{

        public static void ResetScale(this Transform transform) {
            transform.localScale = Vector3.one;
        }
    }
}