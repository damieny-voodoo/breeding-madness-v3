using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using Unity.Notifications.Android;
using TMPro;

public class notificationManager : MonoBehaviour
{
    public bool debugOn;
    public Color notifColor;
    public TextMeshProUGUI debugText;
    localizationData localizationData;
    resourcesBalancing resourcesBalancing;
    resourcesManager resourcesManager;
    iapStoreManager iapStoreManager;
    localizerManager localizerManager;
    saveManager saveManager;

    /*
    // ENERGY
    //public int energyDelay;
    AndroidNotification energyNotification;
    AndroidNotificationChannel energyChannel;

    // SEEDS
    public int seedDelay;
    AndroidNotification seedNotification;
    AndroidNotificationChannel seedChannel;

    // RETENTION
    AndroidNotification retentionNotification_1;
    AndroidNotificationChannel retentionChannel_1;
    AndroidNotification retentionNotification_2;
    AndroidNotificationChannel retentionChannel_2;
    AndroidNotification retentionNotification_3;
    AndroidNotificationChannel retentionChannel_3;

    // FREE ENERGY
    AndroidNotification freeEnergyNotification;
    AndroidNotificationChannel freeEnergyChannel;
    */

    private void Start()
    {
        /*
            saveManager = GetComponent<saveManager>();
            localizationData = GameObject.Find("balancingData").GetComponent<localizationData>();
            resourcesBalancing = GameObject.Find("balancingData").GetComponent<resourcesBalancing>();
            resourcesManager = GetComponent<resourcesManager>();
            localizerManager = GetComponent<localizerManager>();
            iapStoreManager = GetComponent<iapStoreManager>();


            StartSetup();
        */
    }

    void StartSetup()
    {
        /*
            SetupEnergyNotification();
            //SetupSeedNotification();
            SetupRetentionNotification_1();
            SetupRetentionNotification_2();
            SetupRetentionNotification_3();

            SetupFreeEnergyNotification();

            RemoveSentNotifications();
        */
    }


    private void OnApplicationFocus(bool focus)
    {
        /*
            if (focus)
            {
                RemoveSentNotifications();
                //LaunchRetentionNotification();
            }

            if (!focus)
            {
                AndroidNotificationCenter.CancelAllNotifications();
                LaunchNotification();
                LaunchRetentionNotification();
                LaunchFreeEnergyNotification();
            }
        */
    }


    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// ENERGY AND SEEDS

    public void LaunchNotification()
    {
        /*

            int notificationBlocked = saveManager.GetSavedInt("notificationBlocked");

            if (notificationBlocked == 0)
            {
                /////////////////////// ENERGY
                int energyDelay = resourcesManager.timeLeftToMax;
                if (energyDelay > 0)
                {

                    energyNotification.FireTime = System.DateTime.Now.AddSeconds(energyDelay);

                    /////////////////////// SEND WITH STATUS
                    var id = AndroidNotificationCenter.SendNotification(energyNotification, "energyChannel_id");

                }

            }

        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// LAUNCH RETENTION
        public void LaunchRetentionNotification()
        {
            int notificationBlocked = saveManager.GetSavedInt("notificationBlocked");

            if (notificationBlocked == 0)
            {

                /////////////////////// UPDATE TIMING
                retentionNotification_1.FireTime = System.DateTime.Now.AddHours(24);
                retentionNotification_2.FireTime = System.DateTime.Now.AddHours(72);
                retentionNotification_3.FireTime = System.DateTime.Now.AddHours(168);


                /////////////////////// SEND WITH STATUS
                var id = AndroidNotificationCenter.SendNotification(retentionNotification_1, "retentionChannel_1_id");
                var id2 = AndroidNotificationCenter.SendNotification(retentionNotification_2, "retentionChannel_2_id");
                var id3 = AndroidNotificationCenter.SendNotification(retentionNotification_3, "retentionChannel_3_id");

            }
        */

    }
    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// LAUNCH FREE ENERGY
    public void LaunchFreeEnergyNotification()
    {
        /*

            int notificationBlocked = saveManager.GetSavedInt("notificationBlocked");

            if (notificationBlocked == 0)
            {

                /////////////////////// UPDATE TIMING
                /// ENERGY
                int freeEnergyDelay = iapStoreManager.nextFreeEnergyTimeLeft;
                if (freeEnergyDelay > 0)
                {

                    freeEnergyNotification.FireTime = System.DateTime.Now.AddSeconds(freeEnergyDelay);

                    /////////////////////// SEND WITH STATUS
                    var id = AndroidNotificationCenter.SendNotification(freeEnergyNotification, "freeEnergyChannel_id");

                }

        }
        */

    }

    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// UTILITIES

    void RemoveSentNotifications()
    {
        /*
            AndroidNotificationCenter.CancelAllDisplayedNotifications();
        */
    }

    public void CancelAllNotifications()
    {
        /*
            AndroidNotificationCenter.CancelAllScheduledNotifications();
        */
    }

    public void GetSeedDelay()
    {
        /*

            seedDelay = 2000000;

            for (int i = 0; i < resourcesManager.differentSeeds; i++)
            {
                if (resourcesManager.seeds_timeLeftToMax[i] > 0 && resourcesManager.seeds_timeLeftToMax[i] < seedDelay)
                    seedDelay = resourcesManager.seeds_timeLeftToMax[i];
        }
        */

    }


    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// SETUPS
    void SetupEnergyNotification()
    {
        /*
            // CHANNEL
            energyChannel = new AndroidNotificationChannel()
            {
                Id = "energyChannel_id",
                Name = "energyChannel",
                Importance = Importance.Default,
                Description = "Energy notifs",
            };
            AndroidNotificationCenter.RegisterNotificationChannel(energyChannel);

            // TEXTS
            energyNotification.Title = localizerManager.LocalizedText(67);
            energyNotification.Text = localizerManager.LocalizedText(68);

            // COLOR
            energyNotification.Color = notifColor;

            // ICONS
            energyNotification.LargeIcon = "icon_energy_large";
            energyNotification.SmallIcon = "icon_energy_small";
        */

    }


    void SetupSeedNotification()
    {
        /*
            // CHANNEL
            seedChannel = new AndroidNotificationChannel()
            {
                Id = "seedChannel_id",
                Name = "seedChannel",
                Importance = Importance.Default,
                Description = "Seeds Notifs",
            };
            AndroidNotificationCenter.RegisterNotificationChannel(seedChannel);

            // TEXT
            seedNotification.Title = localizerManager.LocalizedText(105);
            seedNotification.Text = localizerManager.LocalizedText(106);

            // COLOR
            seedNotification.Color = notifColor;

            // ICONS
            seedNotification.LargeIcon = "icon_energy_large";
            seedNotification.SmallIcon = "icon_energy_small";
        */
    }
    void SetupRetentionNotification_1()
    {
        /*
            // CHANNEL
            retentionChannel_1 = new AndroidNotificationChannel()
            {
                Id = "retentionChannel_1_id",
                Name = "retentionChannel_1",
                Importance = Importance.Default,
                Description = "Retention 24h",
            };
            AndroidNotificationCenter.RegisterNotificationChannel(retentionChannel_1);


            // TEXT
            retentionNotification_1.Title = localizerManager.LocalizedText(188);
            retentionNotification_1.Text = localizerManager.LocalizedText(189);

            // COLOR
            retentionNotification_1.Color = notifColor;

            // ICONS
            retentionNotification_1.LargeIcon = "icon_energy_large";
            retentionNotification_1.SmallIcon = "icon_energy_small";
        */
    }
    void SetupRetentionNotification_2()
    {
        /*
            // CHANNEL
            retentionChannel_2 = new AndroidNotificationChannel()
            {
                Id = "retentionChannel_2_id",
                Name = "retentionChannel_2",
                Importance = Importance.Default,
                Description = "Retention 72h",
            };
            AndroidNotificationCenter.RegisterNotificationChannel(retentionChannel_2);

            // TEXT
            retentionNotification_2.Title = localizerManager.LocalizedText(190);
            retentionNotification_2.Text = localizerManager.LocalizedText(191);

            // COLOR
            retentionNotification_2.Color = notifColor;

            // ICONS
            retentionNotification_2.LargeIcon = "icon_energy_large";
            retentionNotification_2.SmallIcon = "icon_energy_small";
        */
    }
    void SetupRetentionNotification_3()
    {
        /*
            // CHANNEL
            retentionChannel_3 = new AndroidNotificationChannel()
            {
                Id = "retentionChannel_3_id",
                Name = "retentionChannel_3",
                Importance = Importance.Default,
                Description = "Retention 7days",
            };
            AndroidNotificationCenter.RegisterNotificationChannel(retentionChannel_3);

            // TEXT
            retentionNotification_3.Title = localizerManager.LocalizedText(192);
            retentionNotification_3.Text = localizerManager.LocalizedText(193);

            // COLOR
            retentionNotification_3.Color = notifColor;

            // ICONS
            retentionNotification_3.LargeIcon = "icon_energy_large";
            retentionNotification_3.SmallIcon = "icon_energy_small";
        */
    }
    void SetupFreeEnergyNotification()
        {
        /*
            // CHANNEL
            freeEnergyChannel = new AndroidNotificationChannel()
            {
                Id = "freeEnergyChannel_id",
                Name = "freeEnergyChannel",
                Importance = Importance.Default,
                Description = "Free energy notifs",
            };
            AndroidNotificationCenter.RegisterNotificationChannel(freeEnergyChannel);


            // TEXT
            freeEnergyNotification.Title = localizerManager.LocalizedText(200);
            freeEnergyNotification.Text = localizerManager.LocalizedText(201);

            // COLOR
            freeEnergyNotification.Color = notifColor;

            // ICONS
            freeEnergyNotification.LargeIcon = "icon_energy_large";
            freeEnergyNotification.SmallIcon = "icon_energy_small";
        */
        }
    }
