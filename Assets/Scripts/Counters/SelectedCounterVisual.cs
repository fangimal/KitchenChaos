using UnityEngine;

public class SelectedCounterVisual : MonoBehaviour
{
    [SerializeField] private BaseCounter baseCounter;
    [SerializeField] private GameObject[] visualGameObjectArray;
    private void Start()
    {
        Player.Instance.OnSelectedCounterChanged += Player_OnSelectedCounterChanged;
    }

    private void Player_OnSelectedCounterChanged(object sender, Player.OnSelectedCounterChangedEventArtgs e)
    {
        if (e.selectedCounter == baseCounter)
        {
            Show();
        }
        else
        {
            Hide();
        } 
    }

    private void Show()
    {
        foreach (var go in visualGameObjectArray)
        {
            go.SetActive(true);
        }
    }

    private void Hide()
    {
        foreach (var go in visualGameObjectArray)
        {
            go.SetActive(false);
        }
    }
}
