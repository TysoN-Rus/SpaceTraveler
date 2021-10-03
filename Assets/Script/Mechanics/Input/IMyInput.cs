using UnityEngine;
using UnityEngine.Events;

namespace MyGame
{
    public interface IMyInput
    {
        UnityAction EvDown { get; set; }
        UnityAction EvUp { get; set; }
        UnityAction<float> EvScroll { get; set; }

        Vector2 GetPosition();
    }
}