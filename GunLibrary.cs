﻿using FinalProject.ScriptableObjectGens;
using UnityEngine;

namespace FinalProject
{
    public class GunLibrary : MonoBehaviour
    {
        public Gun[] allGuns;
        public static Gun[] guns;

        private void Awake()
        {
            guns = allGuns;
        }

        public static Gun FindGun (string name)
        {
            foreach(Gun a in guns)
            {
                if (a.name.Equals(name)) return a;
            }

            return guns[0];
        }
    }
}