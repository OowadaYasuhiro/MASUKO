using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< HEAD
<<<<<<< HEAD
using static Constant;
=======
>>>>>>> a6ceb9a119109db116ebcae5a9a2088efa6b8b03
=======
using static Constant;
>>>>>>> 24bfaa1b23e9c3e385b48701e5a3e1278d8bee4a

public class Stage
{

    //選択されたステージ
    string select_stage_number;

    public Stage(string number)
    {
        switch (number)
        {
<<<<<<< HEAD
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
=======
            case (main_ep1_1):
>>>>>>> 24bfaa1b23e9c3e385b48701e5a3e1278d8bee4a

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
<<<<<<< HEAD
            case (StageSelect_Deta.main_ep5_4):
>>>>>>> a6ceb9a119109db116ebcae5a9a2088efa6b8b03
=======
            case (main_ep5_4):
>>>>>>> 24bfaa1b23e9c3e385b48701e5a3e1278d8bee4a

                break;
        }
        select_stage_number = number;
    }

}
