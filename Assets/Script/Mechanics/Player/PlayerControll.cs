using CryoDI;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace MyGame
{
    public class PlayerControll : IPlayerControll, IInitializable
    {
        [Dependency] public IMyInput MyInput { private get; set; }
        [Dependency] public IPlayer Player { private get; set; }

        public UnityAction EvMovePlayer { get; set; }

        public void Initialize()
        {
            MyInput.EvDown += StartPoint;
            MyInput.EvUp += EndPoint;

        }

        Vector2 startPoint;

        private void EndPoint() => SelectDirection(MyInput.GetPosition() - startPoint);

        private void StartPoint() => startPoint = MyInput.GetPosition();

        private void SelectDirection(Vector2 delta)
        {
            if (delta.sqrMagnitude < 5000f) return;

            float angle = Vector2.SignedAngle(Vector2.up, delta) + 180;

            if (angle >= 315 || angle < 45)
            {
                Move(Vector2.down);
                return;
            }
            if (angle >= 225)
            {
                Move(Vector2.left);
                return;
            }
            if (angle >= 135)
            {
                Move(Vector2.up);
                return;
            }
            Move(Vector2.right);
        }

        private void Move(Vector3 direction)
        {
            Player.transform.position +=  direction;
            Player.transform.up = direction;
            EvMovePlayer?.Invoke();
        }
    }
}