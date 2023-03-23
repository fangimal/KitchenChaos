using System.Collections.Generic;
using UnityEngine;

public class PlatesCounterVisual : MonoBehaviour
{
    [SerializeField] private PlatesCounter platesCounter;
    [SerializeField] private Transform counterTopPoint;
    [SerializeField] private Transform plateVisualPrefag;

    private List<GameObject> platesVisualGAmeObjectList;

    private void Awake()
    {
        platesVisualGAmeObjectList = new List<GameObject>();
    }
    private void Start()
    {
        platesCounter.OnPlateSpawned += PlatesCounter_OnPlateSpawned;
        platesCounter.OnPlateRemoved += PlatesCounter_OnPlateRemoved;
    }

    private void PlatesCounter_OnPlateRemoved(object sender, System.EventArgs e)
    {
        GameObject plateObject = platesVisualGAmeObjectList[platesVisualGAmeObjectList.Count - 1];

        platesVisualGAmeObjectList.Remove(plateObject);

        Destroy(plateObject);
    }

    private void PlatesCounter_OnPlateSpawned(object sender, System.EventArgs e)
    {
        Transform plateVisualTransform = Instantiate(plateVisualPrefag, counterTopPoint);

        float plateOffsetY = 0.1f;

        plateVisualTransform.localPosition = new Vector3(0, plateOffsetY * platesVisualGAmeObjectList.Count, 0);

        platesVisualGAmeObjectList.Add(plateVisualTransform.gameObject);
    }
}
