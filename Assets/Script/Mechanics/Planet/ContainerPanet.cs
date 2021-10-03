using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyGame
{
    public class ContainerPanet : MonoBehaviour, IContainerPanet
    {
        [field: SerializeField] public Planet PrefabPlanet { get; private set; }
        [field: SerializeField] public Sprite[] AllPlanet { get; private set; }
        [field: SerializeField] public float Persent { get; private set; }
        [field: SerializeField] public int MaxRatio { get; private set; }

#if UNITY_EDITOR
        [field: SerializeField] public bool OnPrintTime { get; private set; }
#endif

    }
}