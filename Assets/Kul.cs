using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Kul : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        FindPartyMember();

        /*
        string a = "26";
        string b = "20";

        print("Clara diskuterer " + a + " gange i minuttet");
        print("Patrick fedter rotten " + b + " gange om måneden");

        int c = int.Parse(a);
        int d = int.Parse(b);

        if (c > d){
            print(c + " is bigger than " + d);
        }
        else{
            print(d + " is bigger than " + c);
        }
        */

    }

    public void FindPartyMember()
    {

            List<string> Characters = new List<string>()
        {
            "Nicolai",
            "Patrick",
            "Olga",
            "Mads"
        };

        int listLength = Characters.Count;
        
        Characters.RemoveAt(0);
        Characters.Insert(2, "NicolaiL");

        for (int i = 0; i < listLength; i++)
        {
            Debug.LogFormat("Index: {0} - {1}", i, Characters[i]);

            if (Characters[i] == "NicolaiL")
            {
                print("Glad you are here Big Man");
            };
        };

    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
