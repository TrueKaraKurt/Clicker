using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class NumConvert
{
    public static string ToLongNumberdDisplayer(this decimal number) 
    {
        string temp;
        temp = number.ToString("G30");
        int index;
        int spaceCount =(int)Mathf.Floor(temp.Length/(3*1.0f));
        for (int i = 1; i <= spaceCount; i++)
        {
            index = temp.Length - 3 * i - (i-1);
            temp = temp.Insert( index , " ");
        }
        
        return temp;
    }
}
