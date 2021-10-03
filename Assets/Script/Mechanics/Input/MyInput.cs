using CryoDI;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace MyGame
{
    public class MyInput : IMyInput, IInitializable
    {
        [Dependency] public ICreator Creator { private get; set; }

        private InputControll input;

        public UnityAction EvDown { get; set; }
        public UnityAction EvUp { get; set; }
        public UnityAction<float> EvScroll { get; set; }

        private IEnumerator coroutine;

        public Vector2 GetPosition() => input.Touch.PrimaryPosition.ReadValue<Vector2>();

        private bool press = false;

        public void Initialize()
        {
            input = new InputControll();
            input.Touch.PrimaryContact.started += x => { press = true; EvDown?.Invoke(); };
            input.Touch.PrimaryContact.canceled += x => { if (press) { press = false; EvUp?.Invoke(); } };

            input.Touch.TwoContact.started += x => StartScroll();
            input.Touch.TwoContact.canceled += x => StopScroll();

            input.Touch.Scroll.started += x => Scroll(x);
            input.Enable();
        }

        private void Scroll(InputAction.CallbackContext x)
        {
            EvScroll?.Invoke(-x.ReadValue<Vector2>().y / 120);
        }

        private void StopScroll()
        {
            if (coroutine != null)
            {
                Creator.MyStopCoroutine(coroutine);
                coroutine = null;
            }
        }

        private void StartScroll()
        {
            coroutine = Scrolling();
            Creator.MyStartCoroutine(coroutine);
        }
        private IEnumerator Scrolling()
        {
            float preciousDistance = 0;
            float distance;
            while (true)
            {
                distance = Vector2.Distance(input.Touch.PrimaryPosition.ReadValue<Vector2>(), input.Touch.TwoPosition.ReadValue<Vector2>());

                if (Vector2.Dot(input.Touch.PrimaryDelta.ReadValue<Vector2>(), input.Touch.TwoDelta.ReadValue<Vector2>()) < -1f)
                    if (distance > preciousDistance)
                    {
                        EvScroll?.Invoke(-1);
                    }
                    else if (distance < preciousDistance)
                    {
                        EvScroll?.Invoke(1);
                    }

                preciousDistance = distance;
                yield return null;
            }
        }

    }
}