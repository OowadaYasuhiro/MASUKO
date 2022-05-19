using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< HEAD
using static Constant;
=======
>>>>>>> a6ceb9a119109db116ebcae5a9a2088efa6b8b03

public class Stage
{

    //選択されたステージ
    string select_stage_number;

    public Stage(string number)
    {
        switch (number)
        {
<<<<<<< HEAD
            case (main_ep1_1):

                break;
            case (main_ep1_2):

                break;
            case (main_ep1_3):

                break;
            case (main_ep1_4):

                break;
            case (main_ep2_1):

                break;
            case (main_ep2_2):

                break;
            case (main_ep2_3):

                break;
            case (main_ep2_4):

                break;
            case (main_ep3_1):

                break;
            case (main_ep3_2):

                break;
            case (main_ep3_3):

                break;
            case (main_ep3_4):

                break;
            case (main_ep4_1):

                break;
            case (main_ep4_2):

                break;
            case (main_ep4_3):

                break;
            case (main_ep4_4):

                break;
            case (main_ep5_1):

                break;
            case (main_ep5_2):

                break;
            case (main_ep5_3):

                break;
            case (main_ep5_4):
=======
            case (StageSelect_Deta.main_ep1_1):

                break;
            case (StageSelect_Deta.main_ep1_2):

                break;
            case (StageSelect_Deta.main_ep1_3):

                break;
            case (StageSelect_Deta.main_ep1_4):

                break;
            case (StageSelect_Deta.main_ep2_1):

                break;
            case (StageSelect_Deta.main_ep2_2):

                break;
            case (StageSelect_Deta.main_ep2_3):

                break;
            case (StageSelect_Deta.main_ep2_4):

                break;
            case (StageSelect_Deta.main_ep3_1):

                break;
            case (StageSelect_Deta.main_ep3_2):

                break;
            case (StageSelect_Deta.main_ep3_3):

                break;
            case (StageSelect_Deta.main_ep3_4):

                break;
            case (StageSelect_Deta.main_ep4_1):

                break;
            case (StageSelect_Deta.main_ep4_2):

                break;
            case (StageSelect_Deta.main_ep4_3):

                break;
            case (StageSelect_Deta.main_ep4_4):

                break;
            case (StageSelect_Deta.main_ep5_1):

                break;
            case (StageSelect_Deta.main_ep5_2):

                break;
            case (StageSelect_Deta.main_ep5_3):

                break;
            case (StageSelect_Deta.main_ep5_4):
>>>>>>> a6ceb9a119109db116ebcae5a9a2088efa6b8b03

                break;
        }
        select_stage_number = number;
    }

}
