using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_003 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string str1 = "happy ";               //string 형 str1 선언 후 happy 값 입력 
        string str2 = "birthday";             //string 형 str2 선언 후 birthday 값 입력
        string message;                       //string 형

        message = str1 + str2;
        Debug.Log(message);

        str1 += str2;
        Debug.Log(str1);

        int num = 123;
        message = str1 + num;
        Debug.Log(message);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
