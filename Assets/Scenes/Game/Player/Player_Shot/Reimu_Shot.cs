using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reimu_Shot : Player_Shot
{
    protected override void Ini()
    {
        base.Ini();
        P_Shot[0] = GameObject.Find("PShot1");
        P_Shot[1] = GameObject.Find("PShot2");
        P_Shot[2] = GameObject.Find("PShot3");
        P_Shot[3] = GameObject.Find("PShot4");
        P_Shot[4] = GameObject.Find("PShot5");
        P_Shot[5] = GameObject.Find("PShot6");
        P_Shot[6] = GameObject.Find("PShot7");
        P_Shot[7] = GameObject.Find("PShot8");
        P_Shot[8] = GameObject.Find("PShot9");
        P_Shot[9] = GameObject.Find("PShot10");
        P_Shot[10] = GameObject.Find("PShot11");
        P_Shot[11] = GameObject.Find("PShot12");
        P_Shot[12] = GameObject.Find("PShot13");
        P_Shot[13] = GameObject.Find("PShot14");
        P_Shot[14] = GameObject.Find("PShot15");
    }



    protected override void ShotPow_Mgr()
    {
        

        if (player.shot_pow < 8)
        {

            P_Shot[0].SetActive(true);
            P_Shot[1].SetActive(false);
            P_Shot[2].SetActive(false);
            P_Shot[3].SetActive(false);
            P_Shot[4].SetActive(false);

            P_Shot[5].SetActive(false);
            P_Shot[6].SetActive(false);
            P_Shot[7].SetActive(false);
            P_Shot[8].SetActive(false);

            P_Shot[9].SetActive(true);
            P_Shot[10].SetActive(true);
            P_Shot[11].SetActive(false);
            P_Shot[12].SetActive(false);
            P_Shot[13].SetActive(false);
            P_Shot[14].SetActive(false);

        }
        if (player.shot_pow >= 8 && player.shot_pow < 16)
        {
            P_Shot[0].SetActive(false);
            P_Shot[1].SetActive(true);
            P_Shot[2].SetActive(true);
            P_Shot[3].SetActive(false);
            P_Shot[4].SetActive(false);

            P_Shot[5].SetActive(false);
            P_Shot[6].SetActive(false);
            P_Shot[7].SetActive(false);
            P_Shot[8].SetActive(false);

            P_Shot[9].SetActive(true);
            P_Shot[10].SetActive(true);
            P_Shot[11].SetActive(false);
            P_Shot[12].SetActive(false);
            P_Shot[13].SetActive(false);
            P_Shot[14].SetActive(false);

        }
        if (player.shot_pow >= 16 && player.shot_pow < 32)
        {
            P_Shot[0].SetActive(false);
            P_Shot[1].SetActive(true);
            P_Shot[2].SetActive(true);
            P_Shot[3].SetActive(false);
            P_Shot[4].SetActive(false);

            P_Shot[5].SetActive(false);
            P_Shot[6].SetActive(false);
            P_Shot[7].SetActive(false);
            P_Shot[8].SetActive(false);

            P_Shot[9].SetActive(false);
            P_Shot[10].SetActive(false);
            P_Shot[11].SetActive(true);
            P_Shot[12].SetActive(true);
            P_Shot[11].transform.localPosition = new Vector3(0.18f, 0, 0);
            P_Shot[12].transform.localPosition = new Vector3(-0.18f, 0, 0);
            P_Shot[13].SetActive(false);
            P_Shot[14].SetActive(false);

        }
        if (player.shot_pow >= 32 && player.shot_pow < 64)
        {
            P_Shot[0].SetActive(true);
            P_Shot[1].SetActive(false);
            P_Shot[2].SetActive(false);
            P_Shot[3].SetActive(true);
            P_Shot[4].SetActive(true);

            P_Shot[5].SetActive(false);
            P_Shot[6].SetActive(false);
            P_Shot[7].SetActive(false);
            P_Shot[8].SetActive(false);

            P_Shot[9].SetActive(false);
            P_Shot[10].SetActive(false);
            P_Shot[11].SetActive(true);
            P_Shot[12].SetActive(true);

            P_Shot[11].transform.localPosition = new Vector3(0.18f, 0, 0);
            P_Shot[12].transform.localPosition = new Vector3(-0.18f, 0, 0);

            P_Shot[13].SetActive(false);
            P_Shot[14].SetActive(false);

        }
        if (player.shot_pow >= 64 && player.shot_pow < 80)
        {
            P_Shot[0].SetActive(true);
            P_Shot[1].SetActive(false);
            P_Shot[2].SetActive(false);
            P_Shot[3].SetActive(true);
            P_Shot[4].SetActive(true);

            P_Shot[5].SetActive(false);
            P_Shot[6].SetActive(false);
            P_Shot[7].SetActive(false);
            P_Shot[8].SetActive(false);

            P_Shot[9].SetActive(true);
            P_Shot[10].SetActive(true);
            P_Shot[11].SetActive(true);
            P_Shot[12].SetActive(true);

            P_Shot[11].transform.localPosition = new Vector3(0.3f, 0, 0);
            P_Shot[12].transform.localPosition = new Vector3(-0.3f, 0, 0);

            P_Shot[13].SetActive(false);
            P_Shot[14].SetActive(false);

        }
        if (player.shot_pow >= 80 && player.shot_pow < 128)
        {
            P_Shot[0].SetActive(true);
            P_Shot[1].SetActive(false);
            P_Shot[2].SetActive(false);
            P_Shot[3].SetActive(true);
            P_Shot[4].SetActive(true);

            P_Shot[5].SetActive(false);
            P_Shot[6].SetActive(false);
            P_Shot[7].SetActive(false);
            P_Shot[8].SetActive(false);

            P_Shot[9].SetActive(false);
            P_Shot[10].SetActive(false);
            P_Shot[11].SetActive(true);
            P_Shot[12].SetActive(true);
            P_Shot[11].transform.localPosition = new Vector3(0.18f, 0, 0);
            P_Shot[12].transform.localPosition = new Vector3(-0.18f, 0, 0);

            P_Shot[13].SetActive(true);
            P_Shot[14].SetActive(true);

        }
        if (player.shot_pow >= 128)
        {
            P_Shot[0].SetActive(false);
            P_Shot[1].SetActive(false);
            P_Shot[2].SetActive(false);
            P_Shot[3].SetActive(false);
            P_Shot[4].SetActive(false);

            P_Shot[5].SetActive(true);
            P_Shot[6].SetActive(true);
            P_Shot[7].SetActive(true);
            P_Shot[8].SetActive(true);

            P_Shot[9].SetActive(false);
            P_Shot[10].SetActive(false);
            P_Shot[11].SetActive(true);
            P_Shot[12].SetActive(true);
            P_Shot[11].transform.localPosition = new Vector3(0.18f, 0, 0);
            P_Shot[12].transform.localPosition = new Vector3(-0.18f, 0, 0);
            P_Shot[13].SetActive(true);
            P_Shot[14].SetActive(true);

        }


    }
    


}
