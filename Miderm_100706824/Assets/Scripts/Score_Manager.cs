using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score_Manager : MonoBehaviour
{
    public GameObject Score_Text;
    
    public int Score = 50000;
    

    private float t = 2.0f;
    private const float rate = 1.0f;
 
    public int getScore()
    {
        return Score;
    }

    // Start is called before the first frame update
    void Start()
    {
        Score = 50000;
        Score_Text.GetComponent<TMPro.TextMeshProUGUI>().text = Score.ToString();
       //Score_Text.text = Score;
    }

    // Update is called once per frame
    void Update()
    {
        t -= Time.deltaTime;

        if(t <= 0)
        {
            Score -= 10;
            Score_Text.GetComponent<TMPro.TextMeshProUGUI>().text = Score.ToString();

            t = rate;
        }
        
    }
}
