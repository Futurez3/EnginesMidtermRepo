using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScene_Score_Manager : MonoBehaviour
{

    public GameObject PluginManager;
    private PluginHandler _pluginScript;

    public GameObject CP_1;
    public GameObject CP_2;
    public GameObject CP_3;
    public GameObject CP_4;
    public GameObject CP_5;
    public GameObject Finish;

    public GameObject TotalTime;

    public GameObject Score;

    // Start is called before the first frame update
    void Start()
    {
        _pluginScript = PluginManager.GetComponent<PluginHandler>();

        //Score_Text.GetComponent<TMPro.TextMeshProUGUI>().text = Score.ToString();

        CP_1.GetComponent<TMPro.TextMeshProUGUI>().text = _pluginScript.LoadTime(0).ToString("#.0");
        CP_2.GetComponent<TMPro.TextMeshProUGUI>().text = _pluginScript.LoadTime(1).ToString("#.0");
        CP_3.GetComponent<TMPro.TextMeshProUGUI>().text = _pluginScript.LoadTime(2).ToString("#.0");
        CP_4.GetComponent<TMPro.TextMeshProUGUI>().text = _pluginScript.LoadTime(3).ToString("#.0");
        CP_5.GetComponent<TMPro.TextMeshProUGUI>().text = _pluginScript.LoadTime(4).ToString("#.0");

        Finish.GetComponent<TMPro.TextMeshProUGUI>().text = _pluginScript.LoadTime(5).ToString("#.0");

        TotalTime.GetComponent<TMPro.TextMeshProUGUI>().text = _pluginScript.LoadTotalTime().ToString("#.0");

        Score.GetComponent<TMPro.TextMeshProUGUI>().text = _pluginScript.Get_TimeScore().ToString();

       // _pluginScript.ResetLog();
    }

    public void Reset()
    {
        CP_1.GetComponent<TMPro.TextMeshProUGUI>().text = "0.0";
        CP_2.GetComponent<TMPro.TextMeshProUGUI>().text = "0.0";
        CP_3.GetComponent<TMPro.TextMeshProUGUI>().text = "0.0";
        CP_4.GetComponent<TMPro.TextMeshProUGUI>().text = "0.0";
        CP_5.GetComponent<TMPro.TextMeshProUGUI>().text = "0.0";

        Finish.GetComponent<TMPro.TextMeshProUGUI>().text = "0.0";

        TotalTime.GetComponent<TMPro.TextMeshProUGUI>().text = "0.0";

        Score.GetComponent<TMPro.TextMeshProUGUI>().text = "0";

        _pluginScript.ResetLog();
    }

   

    // Update is called once per frame
    void Update()
    {
        
    }
}
