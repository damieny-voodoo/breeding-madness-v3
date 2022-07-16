using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class availableManager : MonoBehaviour
{
    public GameObject[] orders;


    void Start()
    {
        //Debug.LogWarning("Start");
        for (int i = 0; i < orders.Length; i++)
        {
            orders[i] = GameObject.Find("order" + i.ToString());
        }
    }

    private void Update()
    {
        
        // OrderAvailability();
        // CheckMergeable();
        // PurchasableTiles();
        // FreeTiles();
        
    }

    
    public void OrderAvailability()
    {
        /*
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("tile");
        foreach (GameObject go in gos)
        {
            if (go.GetComponent<boatOrderController>())
                go.GetComponent<boatOrderController>().CheckPurchasable();
        }
        */

        /*
        ////////////////////////////////////////////////////////////////////////////////////////////////// REINIT ORDERS
        for (int i = 0; i < orders.Length; i++)
        {
            if (orders[i])
            {
                orders[i].GetComponent<orderController>().itemIsAvailable[0] = false;
                orders[i].GetComponent<orderController>().itemIsAvailable[1] = false;
                orders[i].GetComponent<orderController>().itemsToSell[0] = null;
                orders[i].GetComponent<orderController>().itemsToSell[1] = null;
                orders[i].GetComponent<orderController>().isReady = false;
                orders[i].GetComponent<orderController>().readyImage[0].SetActive(false);
                orders[i].GetComponent<orderController>().readyImage[1].SetActive(false);
            }
        }


        ////////////////////////////////////////////////////////////////////////////////////////////////// CHECK ALL ITEMS AND SEE IF THEY CAN BE SOLD
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("item");
        foreach (GameObject go in gos)
        {
            // reinit the item
            int itemTier = go.GetComponent<itemController>().itemTier;
            string itemFamily = go.GetComponent<itemController>().itemFamily;
            //bool m_canBeSold = false;
            go.GetComponent<itemController>().IsAssigned = false;

            for (int i = 0; i < orders.Length; i++)
            {
                // order item 1
                bool isAssigned = false;
                if (orders[i])
                {
                    int orderItemTier1 = orders[i].GetComponent<orderController>().tier[0];
                    string orderItemFamily1 = orders[i].GetComponent<orderController>().family[0];
                    bool orderItemAlreadyAssigned1 = orders[i].GetComponent<orderController>().itemIsAvailable[0];
                    if (itemTier == orderItemTier1 && itemFamily == orderItemFamily1 && !orderItemAlreadyAssigned1)
                    {
                        //Debug.Log("Item Assigned to order " + orders[0].name + " item "+i);
                        orders[i].GetComponent<orderController>().itemIsAvailable[0] = true;
                        orders[i].GetComponent<orderController>().itemsToSell[0] = go;
                        orders[i].GetComponent<orderController>().readyImage[0].SetActive(true);
                        isAssigned = true;
                    }
                    //order item 2
                    int orderItemTier2 = orders[i].GetComponent<orderController>().tier[1];
                    string orderItemFamily2 = orders[i].GetComponent<orderController>().family[1];
                    bool orderItemAlreadyAssigned2 = orders[i].GetComponent<orderController>().itemIsAvailable[1];
                    if (itemTier == orderItemTier2 && itemFamily == orderItemFamily2 && !isAssigned && !orderItemAlreadyAssigned2)
                    {
                        //Debug.Log("Item Assigned to order " + orders[0].name + " item " + i);
                        orders[i].GetComponent<orderController>().itemIsAvailable[1] = true;
                        orders[i].GetComponent<orderController>().itemsToSell[1] = go;
                        orders[i].GetComponent<orderController>().readyImage[1].SetActive(true);
                        isAssigned = true;
                    }
                }
            }
        }


        ////////////////////////////////////////////////////////////////////////////////////////////////// IS THE ORDER READY?
        int ordersReady = 0;
        for (int i = 0; i < orders.Length; i++)
        {
            if (orders[i])
            {
                if (orders[i].GetComponent<orderController>().itemsInOrder == 2)
                {
                    if (orders[i].GetComponent<orderController>().itemIsAvailable[0] && orders[i].GetComponent<orderController>().itemIsAvailable[1])
                    {
                        ordersReady++;
                        orders[i].GetComponent<orderController>().isReady = true;
                    }
                    else
                        orders[i].GetComponent<orderController>().isReady = false;

                }
                else if (orders[i].GetComponent<orderController>().itemIsAvailable[0])
                {
                    ordersReady++;
                    orders[i].GetComponent<orderController>().isReady = true;
                }
            }
        }
        GetComponent<orderManager>().orderReady = ordersReady;

        */
    }   /// EMPTY

    
    public void CheckMergeable()   /// EMPTY
    {
        /*
        GameObject properties = GameObject.Find("gameProperties");
        properties.GetComponent<itemManager>().mergePossible = false;
        properties.GetComponent<itemManager>().mergeItem1 = null;
        properties.GetComponent<itemManager>().mergeItem2 = null;

        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("item");
        foreach (GameObject go1 in gos)
        {
            go1.GetComponent<itemController>().mergeableItem = null;
            go1.GetComponent<itemController>().canMerge = false;
            

            string go1Family = go1.GetComponent<itemController>().itemFamily;
            int go1Tier = go1.GetComponent<itemController>().itemTier;

            foreach (GameObject go2 in gos)
            {
                if (go1 != go2)
                {
                    string go2Family = go2.GetComponent<itemController>().itemFamily;
                    int go2Tier = go2.GetComponent<itemController>().itemTier;
                    if (go2Family == go1Family && go2Tier == go1Tier)
                    {
                        go1.GetComponent<itemController>().mergeableItem = go2;
                        go1.GetComponent<itemController>().canMerge = true;
                        properties.GetComponent<itemManager>().mergePossible = true;
                        properties.GetComponent<itemManager>().mergeItem1 = go1;
                        properties.GetComponent<itemManager>().mergeItem2 = go2;
                    }
                }
            }
        }
        */
    }

    
    public void PurchasableTiles() /// EMPTY
    {
        /*
        ///////////////// FOR TUTORIALS
        float lowestPrice = Mathf.Infinity;
        bool canPurchaseTile = false;
        GameObject.Find("grid").GetComponent<tileManager>().cheapestTile = null;

        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("tile");
        foreach (GameObject go in gos)
        {
            if (go.GetComponent<tileController>().canBeUnlocked && !go.GetComponent<tileController>().isUnlocked && go.GetComponent<tileController>().unlockPrice < lowestPrice)
            {
                canPurchaseTile = true;
                lowestPrice = go.GetComponent<tileController>().unlockPrice;
                GameObject.Find("grid").GetComponent<tileManager>().cheapestTile = go;
            }
        }

        GameObject.Find("grid").GetComponent<tileManager>().canPurchaseTile = canPurchaseTile;
*/
    }
    
    public void FreeTiles()   /// EMPTY
    {
        /*
        int freeTiles = 0;
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("tile");
        foreach (GameObject go in gos)
        {
            if (!go.GetComponent<tileController>().itemIn && go.GetComponent<tileController>().isUnlocked)
            {
                freeTiles++;
                GameObject.Find("grid").GetComponent<tileManager>().freeTileObject = go;
            }
        }

        GameObject.Find("grid").GetComponent<tileManager>().freeTiles = freeTiles;
        */
    }
          
    public void DestroyItem(GameObject itemDestroyed)/// EMPTY
    {
        /*
        Destroy(itemDestroyed);

    */
    }
    
}
