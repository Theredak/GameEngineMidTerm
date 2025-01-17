﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Checkpoint3 : MonoBehaviour
{
    public bool Touching3 = false;

    [SerializeField] public Transform Player;
    [SerializeField] public Transform respawnPoint;

    public ProgressBar _progressbar;

    void OnTriggerEnter(Collider other)
    {
        Player.transform.position = respawnPoint.transform.position;
        _progressbar.IncrementProgress(0.2f);
        Touching3 = true;
    }
}
