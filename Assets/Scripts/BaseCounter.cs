using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCounter : MonoBehaviour, IKitchenParentObject
{
    [SerializeField] private Transform spawnPoint;

    private KitchenObject kitchenObject;


    public virtual void Interact (Player player)
    {
        Debug.Log("BaseCounter.Interact()");

    }
    public void SetKitchenObject(KitchenObject kitchenObject)
    {
        this.kitchenObject = kitchenObject;
    }

    public KitchenObject GetKitchenObject()
    {
        return kitchenObject;
    }

    public void ClearKitchenObject()
    {
        kitchenObject = null;
    }

    public bool HasKitchenObject()
    {
        return kitchenObject != null;
    }

    public Transform GetRespawnPoint()
    {
        return spawnPoint;
    }


}
