using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitchenObject : MonoBehaviour
{
    [SerializeField] private KitchenObjectSO kitchenObjectSO;

    private IKitchenParentObject kitchenParentObject;

    public KitchenObjectSO GetKitchenObjectSO()
    { 
        return kitchenObjectSO;
    }

    public void SetKitchenObjectParent(IKitchenParentObject kitchenParentObject)
    {
        if (this.kitchenParentObject != null)
        {
            this.kitchenParentObject.ClearKitchenObject();
        }

        this.kitchenParentObject = kitchenParentObject;

        if(kitchenParentObject.HasKitchenObject()) {
            Debug.LogError("Counter already has a KitchenObject!");
        }

        kitchenParentObject.SetKitchenObject(this);

        transform.parent = kitchenParentObject.GetRespawnPoint();
        transform.localPosition = Vector3.zero;

    }

    public IKitchenParentObject GetKitchenParentObject()
    {
        return kitchenParentObject;
    }


}
