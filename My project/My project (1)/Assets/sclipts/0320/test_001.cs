using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_001 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int age;                              //������ int ���� �̸��� age
        age = 30;                             //age �� 30�� �Է� (=)�� �Է�
        Debug.Log(age);                       //Consol.log â�� age �� ���� �����ش�.

        float height1 = 106.5f;               //�ε��Ҽ����� float ���� �̸���height1 �̰� 160.5f �� �Է�
        float height2;                        //float �� height2 ���� (�Է� ���� ���� ���� NULL)
        height2 = height1;                    //height1�� �ִ� height2 �� ���� �����ش�.
        Debug.Log(height2);                   //Consol.log â�� height �� ���� �����ش�.

        string name;                          //���ڿ� name ����
        name = "Sara";                        //name�� Sara �Է�
        Debug.Log(name);  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
