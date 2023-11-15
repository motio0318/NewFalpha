using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TresureBoxManager : MonoBehaviour
{
    public Sprite closeImg;//閉じた画像
    public Sprite openImg; //開いた画像

    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        //SpriteRendererを取得
        spriteRenderer = GetComponent<SpriteRenderer>();

        //初期の画像を閉じた画像にする
        spriteRenderer.sprite = closeImg;
    }
    
    //宝箱を開ける関数
    public void OpenBox()
    {
        //開けた画像に変える
        spriteRenderer.sprite = openImg;
    }
}
