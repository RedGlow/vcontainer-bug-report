﻿using UnityEngine;
using VContainer;

namespace Test
{
    public class View: MonoBehaviour
    {
        [Inject] public Service Service { get; set; }

        private void Start()
        {
            Debug.Log(Service.Hello());
        }
    }
}