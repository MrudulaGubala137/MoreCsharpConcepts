using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPlayerNameAndAge : MonoBehaviour
{
    public Dictionary<string,int> footballPlayers = new Dictionary<string,int>();

    // Start is called before the first frame update
    void Start()
    {
        footballPlayers.Add("Vyshnav", 10);
        footballPlayers.Add("John", 50);
        footballPlayers.Add("Akhil", 20);
        footballPlayers.Add("Dhruc", 70);

        var footballPlayerAge = footballPlayers["John"];
        Debug.Log(footballPlayerAge);

        foreach (KeyValuePair<string,int> item in footballPlayers)
        {
            Debug.Log("Player age :" + item.Value);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
