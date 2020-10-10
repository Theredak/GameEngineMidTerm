using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Runtime.InteropServices;



public class FinalScore : MonoBehaviour
{

    //  public GameObject myTextgameObject; 

    public Checkpoint _checkpoint;
    public Checkpoint2 _checkpoint2;



    public Text ourComponent;

    const string DLL_NAME = "EngineDLL";

    [DllImport(DLL_NAME)]

    private static extern float GetTotalTime();

    [DllImport(DLL_NAME)]
    private static extern float GetCheckpointTime(int index);
    [DllImport(DLL_NAME)]
    private static extern int GetNumCheckpoint();

    float lastTime = 0.0f;



void Start()
    {

        



        ourComponent.text = ("Total-Run-Time to Complete Maze = ") + Time.time.ToString() + ("  ") +  ("Total-Run-Time-Between-CheckPoints = ") + ((GetNumCheckpoint().ToString()));
      

    }

    void Update()
    {
      
        
    }
}


