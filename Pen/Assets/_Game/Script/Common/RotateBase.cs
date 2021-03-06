﻿using UnityEngine;

namespace _Game.Script.Common
{
    public class RotateBase : MonoBehaviour
    {
        [SerializeField] protected float Speed;


        public virtual void Rotate()
        {
            transform.Rotate(0f, 0f, Speed * Time.deltaTime);
        }
    }
}