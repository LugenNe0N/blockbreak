using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    Transform p1Transform;
    Transform p2Transform;

    public Text message;

    public GameObject restratB;
    public GameObject returnB;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0f;
        message.text = "";
        restratB.SetActive(false);
        returnB.SetActive(false);
        
        foreach (Transform childTransform in this.gameObject.transform)
        {
            Debug.Log("これは子です" + childTransform.gameObject.name); // 子オブジェクト名を出力
            if (childTransform.gameObject.name == "Blocks_P1")
            {
                p1Transform = childTransform;
            }else if (childTransform.gameObject.name == "Blocks_P2")
            {
                p2Transform = childTransform;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (p1Transform.childCount == 0)
        {
            message.text = "P1 WIN";
            Debug.Log("RED WIN");
            Time.timeScale = 0f;
        }

        if (p2Transform.childCount == 0)
        {
            message.text = "P2 WIN";
            Debug.Log("BLUE WIN");
            Time.timeScale = 0f;
        }
    }
}
