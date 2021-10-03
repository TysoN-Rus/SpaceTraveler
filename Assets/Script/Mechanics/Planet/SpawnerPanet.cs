using CryoDI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using UnityEngine;
using Debug = UnityEngine.Debug;

namespace MyGame
{
    public class SpawnerPanet : ISpawnerPanet, IInitializable
    {
        [Dependency] public IContainerPanet Container { private get; set; }
        [Dependency] public ICreator Creator { private get; set; }
        [Dependency] public ICameraControll CameraControll { private get; set; }
        [Dependency] public IPlayer Player { private get; set; }
        [Dependency] public ICanvasContainer CanvasContainer { private get; set; }

        public struct Data
        {
            public Vector2 position;
            public Sprite sprite;
            public string text;
        }

        private List<Data> data = new List<Data>(100);

        private MD5CryptoServiceProvider MD5;

        private List<Planet> planets;
        private Vector2Int delta;

        private string sol;

        private readonly string key = "SpawnerPanet";
        int countThreads;
        public void Initialize()
        {
            if (PlayerPrefs.HasKey(key))
            {
                sol = PlayerPrefs.GetString(key);
            }
            else
            {
                sol = "Bee";
                PlayerPrefs.SetString(key, sol);
            }

            countThreads = Environment.ProcessorCount;
            MD5 = new MD5CryptoServiceProvider();

            planets = new List<Planet>();

            CanvasContainer.Threading.onValueChanged.AddListener((x) => GeneratePlanet());

            CanvasContainer.NewWorld.onClick.AddListener(RandomWorld);

            CameraControll.EvMovingCamera += GeneratePlanet;
            CameraControll.EvScaleCamera += UpdateDelta;
            //for (int i = 0; i < 10; i++)
            UpdateDelta();
        }

        private void RandomWorld()
        {
            sol = DateTime.Now.Ticks.ToString();
            PlayerPrefs.SetString(key, sol);
            GeneratePlanet();
        }

        private void UpdateDelta()
        {
            delta = CameraControll.GetDeltaScrinInt();

            //delta.x = 50;
            //delta.y = 50;

            if (CanvasContainer.Threading.isOn)
            {
                if (countActiveThread != 0)
                    return;
                GeneratePlanetThread();
            }
            else GeneratePlanet();
        }

        #region NotThreading
        private void GeneratePlanet()
        {

#if UNITY_EDITOR
            Stopwatch bee = new Stopwatch();
            if (Container.OnPrintTime)
                bee.Start();
#endif



            for (int i = 0; i < planets.Count; i++)
                planets[i].gameObject.SetActive(false);


            for (int i = -delta.x; i <= delta.x; i++)
            {
                for (int j = -delta.y; j <= delta.y; j++)
                {
                    SpawnPlanet(new Vector2(i + Player.transform.position.x, j + Player.transform.position.y));
                }
            }
#if UNITY_EDITOR
            if (Container.OnPrintTime)
            {
                bee.Stop();
                Debug.Log(bee.ElapsedMilliseconds);
            }
#endif

        }
        public void SpawnPlanet(Vector2 position)
        {
            string str = (position.x + sol + position.y);
            byte[] hash = GetMD5(str);
            if (!PresencePlanet(hash[0])) return;
            Planet temp = Creator.GetPlanet(Container.PrefabPlanet, position);
            temp.image.sprite = SelectImagePlanet(hash[1]);
            temp.rating.text = GetRatioPlanet(hash[2] * hash[3]).ToString("0");
            planets.Add(temp);
        }

        #endregion

        #region Threading

        private void GeneratePlanetThread()
        {
#if UNITY_EDITOR
            Stopwatch bee = new Stopwatch();
            if (Container.OnPrintTime)
                bee.Start();
#endif


            for (int i = 0; i < planets.Count; i++)
                planets[i].gameObject.SetActive(false);
            data.Clear();

            DivisionIntoThreads(delta);

            float fix = Time.time;
            while (countActiveThread != 0)
            {
                if (fix > Time.time + 30)
                {
                    Debug.Log("Break");

#if UNITY_EDITOR
                    bee.Stop();
#endif
                    return;
                }
            }

            for (int i = 0; i < data.Count; i++)
                SpawnPlanet(data[i]);

#if UNITY_EDITOR
            if (Container.OnPrintTime)
            {
                bee.Stop();
                Debug.Log(bee.ElapsedMilliseconds);
            }
#endif

        }

        int countActiveThread = 0;
        Thread thread;
        private void DivisionIntoThreads(Vector2Int delta)
        {
            Vector3 player = Player.transform.position;
            int a = delta.x * 2 / countThreads + 1;
            for (int t = 0; t < countThreads; t++)
            {
                int xS = -delta.x + a * t;
                int xN = -delta.x + a * (t + 1);
                if (xN > delta.x + 1)
                    thread = new Thread(() => Thread(xS, delta.x + 1, delta.y, player));
                else
                    thread = new Thread(() => Thread(xS, xN, delta.y, player));
                countActiveThread++;
                thread.Start();
            }
        }

        private void Thread(int xS, int xN, int y, Vector3 player)
        {
            //Stopwatch a = new Stopwatch();
            //a.Start();
            MD5CryptoServiceProvider MD = new MD5CryptoServiceProvider();
            List<Data> newData = new List<Data>();
            Vector2 position;
            for (int i = xS; i < xN; i++)
            {
                for (int j = -y; j <= y; j++)
                {
                    position.x = i + player.x;
                    position.y = j + player.y;

                    byte[] hash = GetMD5(MD, position.x + sol + position.y);
                    if (!PresencePlanet(hash[0])) continue;

                    newData.Add(Calculation(position, hash[1], hash[2] * hash[3]));
                }
            }

            lock (data)
            {
                data.AddRange(newData);
            }
            countActiveThread--;

            //a.Stop();
            //Debug.Log(xS + " " + a.ElapsedMilliseconds);
        }

        private Data Calculation(Vector2 position, byte sprite, int ratio)
        {
            Data dataTemp = new Data();
            dataTemp.position = position;
            dataTemp.sprite = SelectImagePlanet(sprite);
            int ratioInt = GetRatioPlanet(ratio);
            dataTemp.text = ratioInt.ToString("0");
            return dataTemp;
        }
        public void SpawnPlanet(Data data)
        {
            Planet temp = Creator.GetPlanet(Container.PrefabPlanet, data.position);
            temp.image.sprite = data.sprite;
            temp.rating.text = data.text;
            planets.Add(temp);
        }

        #endregion

        private bool PresencePlanet(byte val)
        {
            if (val / 256.0f * 100 < Container.Persent) return true;
            else return false;
        }
        private Sprite SelectImagePlanet(byte val) => Container.AllPlanet[(int)(val / 256.0f * Container.AllPlanet.Length)];
        private int GetRatioPlanet(int val) => (int)(val / 65536.0f * Container.MaxRatio);
        private byte[] GetMD5(string str) => MD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(str));
        private byte[] GetMD5(MD5CryptoServiceProvider MD5, string str) => MD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(str));
    }
}