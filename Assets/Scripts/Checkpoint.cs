using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Checkpoint : MonoBehaviour
{
    public bool Touching = false;

    [SerializeField] public Transform Player;
    [SerializeField] public Transform respawnPoint;

    public ProgressBar _progressbar;

    public void OnTriggerEnter(Collider other)
    {
        Player.transform.position = respawnPoint.transform.position;
        _progressbar.IncrementProgress(0.2f);
        Touching = true;

    }
}
