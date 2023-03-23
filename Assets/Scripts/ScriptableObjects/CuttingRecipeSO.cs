using UnityEngine;

[CreateAssetMenu()]
public class CuttingRecipeSO : ScriptableObject
{
    public KitchenObjectSO inpup;
    public KitchenObjectSO outup;
    public int cuttingProgressMax;
}
