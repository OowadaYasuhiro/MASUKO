//Typeに使用
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//このクラスはプロジェクトの全てのシーンに存在し、複製されることのないクラスの抽象化された親クラスです
//Masterに継承されます
//staticでない為複数のクラスに継承可能です(確かめてはいない
public abstract class SingletonMonoBehaviour<T> : MonoBehaviour where T : MonoBehaviour
{
    //継承先でオーバーライドさせ、trueを返させることでインスタンスが存在することを確認しDontDestroyOnLoadを付加します
    protected abstract bool dontDestroyOnLoad { get; }

    //継承するときにTに入れたクラスのインスタンス
    private static T instance;
    //インスタンスが存在しない場合インスタンスを生成し、既に存在する場合はそれを返します
    public static T Instance {
        get {
            //Awakeが呼ばれる前はinstanceがnull、多分このif文はnullを許容している物に対して使うものnullの時に通る？
            //https://stackoverflow.com/questions/7535818/using-if-bool-vs-if-bool-false-in-c-sharp/7535839
            if (!instance){
                //instanceにTのインスタンスを代入
                Type t = typeof(T);
                instance = (T)FindObjectOfType(t);
            }
            return instance;
        }
    }

    //インスタンスが複数個生成されるのを防ぎます
    protected virtual void Awake(){
        //インスタンスが存在する場合、Instansはそれを返すためこのif文が成立し自分を削除します
        if (this != Instance){
            Destroy(this);
            return;
        }
        //正しくオーバーライドされたらこのif文が通ります
        if (dontDestroyOnLoad){
            DontDestroyOnLoad(this.gameObject);
        }
    }
}
