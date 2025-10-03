using System;
using UnityEngine;

namespace Controllers
{
    public class GameEvents : MonoBehaviour
    {
        public static Action<GameManager.eLevelMode> RestartGame;
    }
}