using UnityEngine;

namespace MyGame
{
    public interface IContainerPanet
    {
        Planet PrefabPlanet { get; }
        Sprite[] AllPlanet { get; }
        float Persent { get; }
        int MaxRatio { get; }

#if UNITY_EDITOR
        bool OnPrintTime { get; }
#endif
    }
}