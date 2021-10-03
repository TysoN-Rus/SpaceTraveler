using System.Collections;
using UnityEngine;

namespace MyGame
{
    public interface ICreator
    {
        Planet GetPlanet(Planet prefab, Vector3 position);
        void MyStartCoroutine(IEnumerator courutine);
        void MyStopCoroutine(IEnumerator courutine);
    }
}