using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    enum Wapen { Sniper, Knife, Shotgun, Granade };
    private string wapenHold;
    Dictionary<Wapen, int> Inventory = new Dictionary<Wapen, int>();
   
    void Start()
    {
        Inventory.Add(Wapen.Shotgun, 8);
        Inventory.Add(Wapen.Sniper, 5);
        Inventory.Add(Wapen.Knife, 6);
        Inventory.Add(Wapen.Granade, 3);


        print(Inventory);
    }
    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            print("space key was pressed");
        }
        
           switch(Input.inputString)
            {
                case "1": break;
                case "2": break;
                case "3": break;
                case "4": break;

            }
        
    
    }
}