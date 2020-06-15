using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    // Start is called before the first frame updatel
    float rotSpeed = 0; //回転速度
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
        	this.rotSpeed = 10;
        }
        transform.Rotate(0, 0, this.rotSpeed);

        //ルーレットを減速させる（追加）
        this.rotSpeed *= 0.96f;
    }
}
