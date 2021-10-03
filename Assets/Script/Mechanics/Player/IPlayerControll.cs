using UnityEngine.Events;

namespace MyGame
{
    public interface IPlayerControll
    {
        UnityAction EvMovePlayer { get; set; }
    }
}