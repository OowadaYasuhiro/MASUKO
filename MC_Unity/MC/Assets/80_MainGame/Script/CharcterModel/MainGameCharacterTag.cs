using UnityEngine;

public class MainGameCharacterTag : MonoBehaviour
{

    public MainGameCharacterTag() : base()
    {
        ;
    }

    //所属
    protected bool player { get; set; }
    protected bool enemy { get; set; }
    protected bool summonsCharactor { get; set; }
}
