using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : MonoBehaviour
{
    public Spells[] spells;

    public Spells fireBlast;
    public Spells iceBlast;

    public int level = 1;
    public int exp;

    void Start()
    {
        fireBlast = new Spells("Fire Blaster", 1, 23, 35);
        iceBlast = new Spells("Ice Blaster", 3, 40, 37);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            foreach(var spell in spells)
            {
                if(spell.levelRequired == level)
                {
                    spell.Cast();
                    exp += spell.expGained;
                }
            }
        }
    }
}
