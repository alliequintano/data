using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Demo : MonoBehaviour
{
    public GameObject dataPoint;

    private void Awake()
    {

        List<Dictionary<string, object>> data = DataReader.Read("example");

        for (var i = 0; i < data.Count; i++)
        {
            foreach (KeyValuePair<string, object> kvp in data[i])
            {
                Debug.Log(kvp.Key + kvp.Value);
            }

            Instantiate(dataPoint,
                new Vector3(Convert.ToInt32(data[i]["x"]), Convert.ToInt32(data[i]["y"]), Convert.ToInt32(data[i]["z"])),
                Quaternion.identity);
        }
    }
}
