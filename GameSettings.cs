using UnityEngine;

namespace FinalProject
{
    public enum GameMode
    {
        FFA = 0,
        CAPTUREFLAG = 1
    }

    public class GameSettings : MonoBehaviour
    {
        public static GameMode GameMode = GameMode.FFA;
        public static bool IsAwayTeam = false;
    }
}