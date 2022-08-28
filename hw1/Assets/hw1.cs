using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hw1 : MonoBehaviour
{
    string hero = " Koruko ";
    int heroHealth = 100;

    int damagedHealth = 80;

    int boostedHealth = 90;




    // Start is called before the first frame update
    void Start()
    {
        print(" I am " + hero + ". I am at " + heroHealth + "HP.");

        Damaged();
        Boost();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void Damaged()
    {
        damagedHealth = heroHealth - 20;
        print(" I am damaged. My health is at " + damagedHealth + "HP");

    }

    void Boost()
    {
        boostedHealth = damagedHealth + 10;
        print(" I have regained 10HP. My health is at " + boostedHealth + "HP");

    }
}
