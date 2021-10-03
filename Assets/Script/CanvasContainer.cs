using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace MyGame
{
    public class CanvasContainer : MonoBehaviour, ICanvasContainer
    {
        [field: SerializeField] public Button NewWorld { get; private set; }
        [field: SerializeField] public Toggle Threading { get; private set; }
    }
}