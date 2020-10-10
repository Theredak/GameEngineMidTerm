using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalScene : MonoBehaviour
{
    public bool Ending = false;

    [SerializeField] public Transform Player;
    [SerializeField] public Transform respawnPoint;

    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("EndScene");
        Ending = true;
    }
}
