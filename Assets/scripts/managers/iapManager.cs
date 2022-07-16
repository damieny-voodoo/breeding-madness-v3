
using System;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Purchasing;
using TMPro;


//namespace CompleteProject
//{
public class iapManager : MonoBehaviour//, IStoreListener
{
    /*
    public static IStoreController m_StoreController;          // The Unity Purchasing system.
    private static IExtensionProvider m_StoreExtensionProvider; // The store-specific Purchasing subsystems.

    public string[] products;

    //public static string product_0 = "iap_hc_0";
    //public static string product_1 = "iap_hc_1";
    //public static string product_2 = "iap_hc_2";

    iapBalancing iapBalancing;
    tipsManager tipsManager;

    public TextMeshProUGUI logText;
    // public static string kProductIDNonConsumable = "nonconsumable";
    // public static string kProductIDSubscription = "subscription";

    ////////////////////////////////////////////// SUBSCRIPTIONS
    //private static string kProductNameAppleSubscription = "com.unity3d.subscription.new";
    //private static string kProductNameGooglePlaySubscription = "com.unity3d.iapProduct.hc_0";

    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// INITIALIZE
    void Start()
    {
        iapBalancing = GameObject.Find("balancingData").GetComponent<iapBalancing>();
        tipsManager = GetComponent<tipsManager>();

        if (m_StoreController == null)
        {
            InitializePurchasing();
        }
    }

    public void InitializePurchasing()
    {
        if (IsInitialized())
        {
            return;
        }


        ////////////////////////////////////////////// INSTANCE
        var builder = ConfigurationBuilder.Instance(StandardPurchasingModule.Instance());

        ////////////////////////////////////////////// PRODUCTS IN BUILDER 
        foreach( string id in iapBalancing.iap_ids)
        {
            //Debug.Log("Add product " + id);
            builder.AddProduct(id, ProductType.Consumable);

        }

        ////////////////////////////////////////////// PRODUCTS  STRINGS
        products = new string[iapBalancing.iap_ids.Length];
        for ( int i = 0; i < products.Length; i++)
            products[i] = iapBalancing.iap_ids[i];


        //builder.AddProduct(product_0, ProductType.Consumable);
        //builder.AddProduct(product_1, ProductType.Consumable);
        //builder.AddProduct(product_2, ProductType.Consumable);



            ////////////////////////////////////////////// INIT
            UnityPurchasing.Initialize(this, builder);
    }


    private bool IsInitialized()
    {
        return m_StoreController != null && m_StoreExtensionProvider != null;
    }

    public void OnInitialized(IStoreController controller, IExtensionProvider extensions)
    {
        logText.text = "OnInitialized: PASS";
        //Debug.Log("OnInitialized: PASS");
        m_StoreController = controller;

        GetComponent<iapStoreManager>().InitializeStore();
        
        m_StoreExtensionProvider = extensions;
        logText.text = "";


}


public void OnInitializeFailed(InitializationFailureReason error)
    {
        logText.text = "OnInitializeFailed InitializationFailureReason:" + error;
        Debug.Log("OnInitializeFailed InitializationFailureReason:" + error);
    }


    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// PURCHASE

    public void BuyConsumable()
    {
        BuyProductID(kProductIDConsumable);
    }
  
    public void BuyProductID(int productIndex)
    {

        //logText.text = "Start purchase process for " + iapBalancing.iap_ids[productIndex] +"\n";
        //Debug.Log(" Start purchase process for " + iapBalancing.iap_ids[productIndex]);
        //logText.text += "Is initialized = " + IsInitialized() + "\n";
        //Debug.Log("Is initialized = " + IsInitialized());

        if (IsInitialized())
        {
            string productId = iapBalancing.iap_ids[productIndex];
            Product product = m_StoreController.products.WithID(productId);
            logText.text += string.Format("Try puchase product", productId) + "\n";

            /////////////////////////////////////////// TRY PURCHASE
            if (product != null && product.availableToPurchase)
            {
                logText.text += string.Format("Purchasing product asychronously: '{0}'", product.definition.id) + "\n";
                Debug.Log(string.Format("Purchasing product asychronously: '{0}'", product.definition.id));
                m_StoreController.InitiatePurchase(product);
            }

            /////////////////////////////////////////// PURCHASE FAIL
            else
            {
                logText.text += "BuyProductID: FAIL. Not purchasing product, either is not found or is not available for purchase" + "\n";
                Debug.Log("BuyProductID: FAIL. Not purchasing product, either is not found or is not available for purchase");
            }
        }
        /////////////////////////////////////////// PURCHASE FAIL
        else
        {
            logText.text += "BuyProductID: FAIL. Not initialized." + "\n";
            Debug.Log("BuyProductID FAIL. Not initialized.");
        }
    }



    public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs args)
    {

        logText.text += string.Format("Test purchasing process: ", args.purchasedProduct.definition.id, products[0], "\n");
        for (int i = 0; i < products.Length; i++)
        {
            if(String.Equals(args.purchasedProduct.definition.id, products[i], StringComparison.Ordinal))
            {
            logText.text += string.Format("Purchase processing complete: ", i, "\n");
            GetComponent<iapStoreManager>().ConfirmIapPurchase(i);
            }
        }


    //////////////////// ------------------------------------------ ADD THE PURCHASES HERE ------------------------------------------ ////////////////////

    if (String.Equals(args.purchasedProduct.definition.id, product_0, StringComparison.Ordinal))
    {
        Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
    }

    else if (String.Equals(args.purchasedProduct.definition.id, product_1, StringComparison.Ordinal))
    {
        Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
    }
    else if (String.Equals(args.purchasedProduct.definition.id, product_2, StringComparison.Ordinal))
    {
        Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
    }

    /////////////////////////////////////////// FAILED
    else
    {
        Debug.Log(string.Format("ProcessPurchase: FAIL. Unrecognized product: '{0}'", args.purchasedProduct.definition.id));
    }
    return PurchaseProcessingResult.Complete;
    }


    public void OnPurchaseFailed(Product product, PurchaseFailureReason failureReason)
    {
        Debug.Log(string.Format("OnPurchaseFailed: FAIL. Product: '{0}', PurchaseFailureReason: {1}", product.definition.storeSpecificId, failureReason));
        logText.text += string.Format("OnPurchaseFailed: FAIL. Product: '{0}', PurchaseFailureReason: {1}", product.definition.storeSpecificId, failureReason, "\n");

        tipsManager.TriggerTip(4);

    }

    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// RESTORE
    public void RestorePurchases()
    {
        if (!IsInitialized())
        {
            Debug.Log("RestorePurchases FAIL. Not initialized.");
            return;
        }

        if (Application.platform == RuntimePlatform.IPhonePlayer ||
            Application.platform == RuntimePlatform.OSXPlayer)
        {
            Debug.Log("RestorePurchases started ...");
            var apple = m_StoreExtensionProvider.GetExtension<IAppleExtensions>();
            apple.RestoreTransactions((result) =>
            {
                Debug.Log("RestorePurchases continuing: " + result + ". If no further messages, no purchases available to restore.");
            });
        }
        else
        {
            Debug.Log("RestorePurchases FAIL. Not supported on this platform. Current = " + Application.platform);
        }
    }
    */
}
//}