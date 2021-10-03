using UnityEngine.UI;

namespace MyGame
{
    public interface ICanvasContainer
    {
        Button NewWorld { get; }

        Toggle Threading { get; }
    }
}