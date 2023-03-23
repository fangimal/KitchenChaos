using UnityEngine;

[CreateAssetMenu()]
public class BurningRecipeSO : ScriptableObject
{
    public KitchenObjectSO inpup;
    public KitchenObjectSO outup;
    public float burningTimerMax;
}
