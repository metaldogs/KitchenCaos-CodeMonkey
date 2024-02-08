using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System;

public class ContainerCounter : BaseCounter
{

    public event EventHandler OnPlayerGrabObject;

    [SerializeField] private KitchenObjectSO kitchenObjectSO;

    public override void Interact(Player player)
    {
        Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab).transform;
        kitchenObjectTransform.GetComponent<KitchenObject>().SetKitchenObjectParent(player);
        OnPlayerGrabObject?.Invoke(this, EventArgs.Empty);
    }
}
