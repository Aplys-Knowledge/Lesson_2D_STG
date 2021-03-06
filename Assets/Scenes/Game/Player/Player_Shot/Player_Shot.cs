﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Shot : MonoBehaviour
{
    protected Chara player;

    private int[] bullet_flag = new int[256];
    private Player_Bullet[] Bullet = new Player_Bullet[256];

    protected GameObject[] bullet_pre = new GameObject[4];

    protected GameObject[] P_Shot = new GameObject[16];

    protected bool flag;

    protected string[] bullet_name = new string[8];



    protected virtual void Ini()
    {

        //player = this.GetComponent<Chara>();
        for(int i = 0; i < 256; i++)
        {
            bullet_flag[i] = 0;
        }

        bullet_name[0] = "Bullet/Player/p_Bullet01";
        bullet_name[1] = "Bullet/Player/p_Bullet02";


    }



    protected void Shot(int num, int rate, float angle, bool homing)
    {
        int k;

        if (player.shot_flag)
        {
            if (player.shot_cnt % rate == 0)
            {
                if ((k = Bullet_Num()) != -1)
                {
                    bullet_flag[k] = 1;
                    Bullet[k] = Instantiate((GameObject)Resources.Load(bullet_name[num]), transform.position, Quaternion.identity).GetComponent<Player_Bullet>();
                    Bullet[k].bullet_angle = angle;
                    Bullet[k].bullet_homing = homing;

                }
            }

        }

        /*
        if (Input.GetButton("Shot"))
        {

            Instantiate((GameObject)Resources.Load("Bullet/Player/p_Bullet01"), transform.position, Quaternion.identity);



        }
        */

    }

    protected virtual void ShotPow_Mgr()
    {
        
    }

    private int Bullet_Num()
    {
        for(int i = 0; i < 256; i++)
        {
            if (bullet_flag[i] == 0)
            {
                return i;

            }

        }
        return -1;

    }
    
    protected void Bullet_Mgr()
    {
        for(int i = 0; i < 256; i++)
        {
            if (bullet_flag[i] == 1)
            {
                if (Bullet[i].bullet_falg == -1)
                {
                    bullet_flag[i] = 0;
                }
                
            }

        }

    }





}
