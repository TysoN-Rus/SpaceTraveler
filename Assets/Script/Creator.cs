using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyGame
{
    public class Creator : MonoBehaviour, ICreator
    {
        private List<Planet> planets = new List<Planet>(100);

        

        public Planet GetPlanet(Planet prefab, Vector3 position)
        {
            for (int i = 0; i < planets.Count; i++)
            {
                if (!planets[i].gameObject.activeSelf)
                {
                    planets[i].transform.position = position;
                    planets[i].gameObject.SetActive(true);
                    return planets[i];
                }
            }

            Planet temp = Instantiate(prefab, position, Quaternion.identity, transform);
            planets.Add(temp);
            return temp;
        }

        public void MyStartCoroutine(IEnumerator courutine) => base.StartCoroutine(courutine);
        public void MyStopCoroutine(IEnumerator courutine) => base.StopCoroutine(courutine);

    }
}