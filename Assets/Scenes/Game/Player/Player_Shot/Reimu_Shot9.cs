﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reimu_Shot9 : Reimu_Shot
{
    protected override void Ini()
    {
        player = GameObject.Find("reimu(Clone)").GetComponent<Chara>();

        base.Ini();
    }

    // Start is called before the first frame update
    void Start()
    {
        Ini();
    }

    // Update is called once per frame
    void Update()
    {
        ShotPow_Mgr();

        Shot(1, 7, 0, true);
        Bullet_Mgr();


    }

}
