using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyGame
{
    public class CameraSetting : MonoBehaviour, ICameraSetting
    {
        [field: SerializeField] public Vector2Int MinMaxScale { get; private set; }
    }
}