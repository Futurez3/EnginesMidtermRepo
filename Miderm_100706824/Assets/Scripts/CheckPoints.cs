using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoints : MonoBehaviour
{
    public GameObject PluginManager;
    public GameObject ScoreManager;
    public GameObject SceneManager;

    private PluginHandler _pluginScript;
    private Score_Manager _scoreScript;
    private Scene_Manager _sceneScript;
    



    private bool active = true;
    // Start is called before the first frame update
    void Start()
    {
        active = true;
        _pluginScript = PluginManager.GetComponent<PluginHandler>();
        _scoreScript = ScoreManager.GetComponent<Score_Manager>();
        _sceneScript = SceneManager.GetComponent<Scene_Manager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" && active)
        {
            Debug.Log("Time recorded!");
            _pluginScript.TriggerCP();
            active = false;
        }

        if(transform.tag == "Finish")
        {
            Debug.Log("Ended!");
            _pluginScript.TriggerCP();
            _pluginScript.Save_TimeScore(_scoreScript.getScore());

            _sceneScript.TransitionScene("EndScene");
            //active = false;
        }
    }
}
