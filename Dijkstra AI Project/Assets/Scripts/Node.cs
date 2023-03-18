using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Node : MonoBehaviour
{
    public Node[] ConnectsTo;


    public List<GameObject> statusOptions = new List<GameObject>();

    public float cost;
    public float timesVisited;

    private void Start()
    {
        //foreach (Transform t in transform.GetChild(0).GetComponentsInChildren<Transform>())
        //{
        //    if(t.name.Contains("king") || t.name.Contains("knight"))
        //    {
        //        statusOptions.Add(t.gameObject);

        //    }
        //}

        //statusOptions[0].SetActive(false);
        //cost = 50;
        if(ConnectsTo.Length == 2)
        {
            Debug.Log(name);

            Debug.Log(ConnectsTo[0].name + ConnectsTo[0].cost);
            Debug.Log(ConnectsTo[1].name + ConnectsTo[1].cost);
            Debug.Log("--------------------------");

        }

    }

    public void ChangeMe()
    {
        if (statusOptions[0].activeSelf)
        {
            statusOptions[0].SetActive(false);
            statusOptions[1].SetActive(true);
            cost = 50;

        }
        else if (statusOptions[1].activeSelf)
        {
            statusOptions[1].SetActive(false);
            statusOptions[0].SetActive(true);
            cost = 5;
        }

        FindObjectOfType<Pathfinder>().BuildGraph();
    }

    private void OnDrawGizmos()
    {
        foreach (Node n in ConnectsTo)
        {
            Gizmos.color = Color.red;
            //Gizmos.DrawLine(transform.position, n.transform.position);
            Gizmos.DrawRay(transform.position, (n.transform.position - transform.position).normalized * 2);
        }
    }

}
