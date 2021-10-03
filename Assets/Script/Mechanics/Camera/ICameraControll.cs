using UnityEngine;
using UnityEngine.Events;

namespace MyGame
{
    public interface ICameraControll
    {
        UnityAction EvMovingCamera { get; set; }
        UnityAction EvScaleCamera { get; set; }
        Vector2 GetDeltaScrin();
        Vector2Int GetDeltaScrinInt();
    }
}