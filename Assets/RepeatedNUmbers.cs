using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatedNUmbers : MonoBehaviour
{
    

    public int[] num;

    public void numtest()
    {
       var result = TestForDuplicates(num);
        Debug.Log(result);
    }
    public bool TestForDuplicates( int []args)
    {
        Dictionary<int, int> register = new Dictionary<int, int>();
        bool result = false;
        for(int i=0;i<args.Length;++i)
        {
            if(!register.ContainsKey(args[i]))
            {
                register.Add(args[i], 1);
            }
            else
            {
                register[args[i]]+=1;
            }
        }

        for(int i=0;i<register.Count;++i)
        {
            if(register[args[i]]>1)
            {
                Debug.Log("reached here ");
                result = true;
                break;
            }
        }
        register.Clear();
        return result;
    }

    public bool TestVialist(int [] args)
    {
        List<int> register = new List<int>();
        for(int i =0;i<args.Length;i++)
        {
            if(register.Contains(args[i]))
            {
                return true;
            }
            else
            {
                register.Add(args[i]);
            }
        }
        return false;
    }
}
