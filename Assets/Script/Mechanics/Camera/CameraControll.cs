using CryoDI;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace MyGame
{
    public class CameraControll : ICameraControll, IInitializable
    {
        [Dependency] public Camera Camera { private get; set; }
        [Dependency] public IPlayer Player { private get; set; }
        [Dependency] public IPlayerControll PlayerControll { private get; set; }
        [Dependency] public IMyInput MyInput { private get; set; }
        [Dependency] public ICameraSetting CameraSetting { private get; set; }

        public UnityAction EvMovingCamera { get; set; }
        public UnityAction EvScaleCamera { get; set; }

        private Vector2 deltaScrin;

        public void Initialize()
        {
            CalculationDeltaScrin();
            MyInput.EvScroll += Scroll;
            PlayerControll.EvMovePlayer += Checked;
        }

        private void Scroll(float arg0)
        {
            Camera.orthographicSize += arg0;
            Camera.orthographicSize = Mathf.Clamp(Camera.orthographicSize, (float)CameraSetting.MinMaxScale.x / 2, (float)CameraSetting.MinMaxScale.y / 2);
            
            CalculationDeltaScrin();
            Checked();
            EvScaleCamera?.Invoke();
        }

        private void Checked()
        {
            if (Mathf.Abs(Player.transform.position.x - Camera.transform.position.x) >= deltaScrin.x - 1 ||
                Mathf.Abs(Player.transform.position.y - Camera.transform.position.y) >= deltaScrin.y - 1)
            {
                Camera.transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y, Camera.transform.position.z);
                EvMovingCamera?.Invoke();
            }
        }

        private void CalculationDeltaScrin() => deltaScrin = (Camera.ViewportToWorldPoint(new Vector3(0, 0, Camera.nearClipPlane)) - Camera.transform.position) * -1;
        public Vector2 GetDeltaScrin() => deltaScrin;
        public Vector2Int GetDeltaScrinInt() => new Vector2Int((int)deltaScrin.x+1, (int)deltaScrin.y+1);
    }
}