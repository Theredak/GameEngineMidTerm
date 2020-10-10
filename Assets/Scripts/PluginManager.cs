using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class PluginManager : MonoBehaviour
{

    public Checkpoint _Checkpoint;
    public Checkpoint2 _Checkpoint2;
    public Checkpoint3 _Checkpoint3;
    public Checkpoint4 _Checkpoint4;
    public Checkpoint5 _Checkpoint5;

    public FinalScene _FinalScene;

    public float FirstTime;
    public float SecondTime;
    public float ThirdTime;
    public float FourthTime;
    public float FifthTime;

    public string TopScore;


    const string DLL_NAME = "EngineDLL";

    [DllImport(DLL_NAME)]

    private static extern void ResetLogger();

    [DllImport(DLL_NAME)]

    private static extern void SaveCheckpointTime(float RTBC);

    [DllImport(DLL_NAME)]

    private static extern float GetTotalTime();

    [DllImport(DLL_NAME)]
    private static extern float GetCheckpointTime(int index);
    [DllImport(DLL_NAME)]
    private static extern int GetNumCheckpoint();

    float lastTime = 0.0f;

    public void SaveTimeTest(float checkpointTime)
    {
        SaveCheckpointTime(checkpointTime);
    }

    public float LoadTimeTest(int index)
    {
        if (index >= GetNumCheckpoint())
        {
            return -1.0f;
        }
        else
        {
            return GetCheckpointTime(index);
        }
    }

    public float LoadTotalTimeTest()
    {
        return GetTotalTime();
    }

    public void ResetLoggerTest()
    {
        ResetLogger();
    }


    // Start is called before the first frame update
    void Start()
    {
        lastTime = Time.time;
        Debug.Log(Time.time);


    }

    // Update is called once per frame

    // (Input.GetKeyDown(KeyCode.Space)
    void Update()

    {

        

        for (int i = 0; i < 10; i++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha0 + i))
            {
                Debug.Log(LoadTimeTest(i));
            }
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            Debug.Log(LoadTotalTimeTest());
        }

     
    }

    private void OnDestroy()
    {
        ResetLoggerTest();
    }
}
