using System.Collections.Generic;
using UnityEngine;

namespace SO{
    [CreateAssetMenu(fileName = "CONTAINER", menuName = "Match3/Container", order = 0)]
    public class SOContainer : ScriptableObject{
        public List<SOItemNormal> items;
    }
}