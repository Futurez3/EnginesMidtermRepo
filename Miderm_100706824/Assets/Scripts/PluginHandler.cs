using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class PluginHandler : MonoBehaviour
{
    const string DLL_NAME = "EnginesDLL_Tutorial";

    [DllImport(DLL_NAME)]
    private static extern void ResetLogger();

    [DllImport(DLL_NAME)]
    private static extern void SaveCheckPointTime(float RTBC);

    [DllImport(DLL_NAME)]
    private static extern float GetTotalTime();

    [DllImport(DLL_NAME)]
    private static extern float GetCheckPointTime(int index);

    [DllImport(DLL_NAME)]
    private static extern int GetNumCheckpoints();

    [DllImport(DLL_NAME)]
    private static extern void SaveTimeScore(int score);

    [DllImport(DLL_NAME)]
    private static extern int GetTimeScore();


    float lastTime = 0.0f;

    public void SaveTimeTest(float CPtime)
    {
        SaveCheckPointTime(CPtime);
    }

    public float LoadTimeTest(int index)
    {
       if(index >= GetNumCheckpoints())
       {
            return -1.0f;
       }
       else
        {
            return GetCheckPointTime(index);
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


    public void Save_TimeScore(int score)
    {
        SaveTimeScore(score);
    }

    public int Get_TimeScore()
    {
        return GetTimeScore();
    }

    void OnDestroy()
    {
        ResetLoggerTest();
    }

    void Start()
    {
        lastTime = Time.time;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            float currentTime = Time.time;
            float checkpointTime = currentTime - lastTime;
            lastTime = currentTime;

            SaveTimeTest(checkpointTime);
        }

        for(int i = 0; i < 10; i++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha0+i))
            {
                Debug.Log(LoadTimeTest(i));
            }
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            Debug.Log(LoadTotalTimeTest());
        }
    }
}
