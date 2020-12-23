using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p_Bullet02 : Player_Bullet
{
    private Player_Bullet pBullet;

    // Start is called before the first frame update
    void Start()
    {
        pBullet = this.gameObject.GetComponent<Player_Bullet>();

        angle = pBullet.bullet_angle;
        homing = pBullet.bullet_homing;

        Ini();



    }

    // Update is called once per frame
    void Update()
    {

        Bullet_Destroy(240);
        pBullet.bullet_falg = flag;





        if (homing)
        {
            Tracking();

        }


        rotate();
        forward(0.8f);


    }
}
