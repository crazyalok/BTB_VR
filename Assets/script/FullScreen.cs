﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullScreen : MonoBehaviour {
    void AwakeStart()
    {
        Screen.fullScreen = !Screen.fullScreen;
    }

}
