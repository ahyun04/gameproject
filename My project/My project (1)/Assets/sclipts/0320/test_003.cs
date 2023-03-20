using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_003 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string str1 = "happy ";               //string �� str1 ���� �� happy �� �Է� 
        string str2 = "birthday";             //string �� str2 ���� �� birthday �� �Է�
        string message;                       //string ��

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
