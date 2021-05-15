﻿using System;

namespace PastriesDelivery
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            bool result;
            var pastry = new Pastry();
           
            var availableProducts = new Storage()
            {
                Type = StorageType.AvailableProducts
            };

            var userOrders = new Storage()
            {
                Type = StorageType.UserOrders
            };

            var providerManager = new BusinessProviderManager(availableProducts);
            var consumerManager = new ConsumerManager(availableProducts, userOrders);
            var businessClientManager = new BusinessClientManager(availableProducts, userOrders);
            while (true)
            {
                Messenger.GreetUser();

                var user = Console.ReadLine();

                if (user is "provider")
                {
                    var User = new User()
                    {
                        Name = "Some Name",
                        Type = UserType.Provider,
                        PhoneNumber = "+380XXXXXXXXX",
                        Address = "Some adress"
                    };

                    Messenger.SendOfferRequirments();

                    var providerUI = new ProviderUI();
                    pastry = providerUI.AcceptData(providerManager, pastry);
                    var answer = providerUI.ConfirmOffer();

                    if (answer is "yes")
                    {
                        providerManager.AddNewOffer(pastry, User);
                        Messenger.ShowOfferAcceptedMessage();
                    }
                }

                if (user is "consumer")
                {
                   
                    var consumer = new User
                    {
                        Type = UserType.Consumer
                    };

                    var displayer = new ConsumerUI(availableProducts);
                    Messenger.ShowAvailableProductsMessage();
                    result = consumerManager.CheckForDataPrescence();

                    if (result is true)
                    {
                        displayer.DisplayAvailableProducts();
                        Messenger.SendOrderRequirments();
                        var idAndAmount = ConsumerUI.GetOrder();
                        var id = ConsumerUI.ExtractId(idAndAmount);
                        var amount = ConsumerUI.ExtractAmount(idAndAmount);
                        Messenger.ShowConfirmMessage();
                        var answer = displayer.ConfirmOrder();
                        if (answer is "yes")
                        {
                            try
                            {
                                pastry = consumerManager.ChooseProduct(id, amount);
                            }
                            catch (ArgumentOutOfRangeException)
                            {
                                Messenger.ShowUnavailableAmountMessage();
                                continue;
                            }
                            Messenger.ShowEnterAddressMessage();
                            consumer.Address = BusinessClientUI.GetAddress();
                            Messenger.ShowEnterPhoneNumberMessage();
                            consumer.PhoneNumber = BusinessClientUI.GetPhoneNumber();
                            Messenger.ShowEnterNameMessage();
                            consumer.Name = BusinessClientUI.GetUserName();
                            consumerManager.SaveOrder(pastry);
                            Messenger.ShowOrderAcceptedMessage();
                            consumerManager.SaveUser(consumer);
                        }
                    }

                    if (result is false)
                    {
                        Messenger.ShowNoProductsMessage();
                    }
                }

                if (user is "business client")
                {
                    
                    var businessClient = new User()
                    {
                        Type = UserType.BusinessClient
                    };

                    Messenger.ShowAvailableProductsMessage();
                    var displayer = new BusinessClientUI(availableProducts);
                    result = businessClientManager.CheckForDataPrescence();
                    if (result is true)
                    {
                        displayer.DisplayAvailableProducts();
                        Messenger.SendOrderRequirments();
                        var idAndAmount = BusinessClientUI.GetOrder();
                        var id = BusinessClientUI.ExtractId(idAndAmount);
                        var amount = BusinessClientUI.ExtractAmount(idAndAmount);
                        Messenger.ShowConfirmMessage();
                        var answer = displayer.ConfirmOrder();
                        if (answer is "yes")
                        {
                            try
                            {
                                pastry = businessClientManager.ChooseProduct(id, amount);
                            }
                            catch (ArgumentOutOfRangeException)
                            {
                                Messenger.ShowUnavailableAmountMessage();
                                continue;
                            }
                            Messenger.ShowEnterAddressMessage();
                            businessClient.Address = BusinessClientUI.GetAddress();
                            Messenger.ShowEnterPhoneNumberMessage();
                            businessClient.PhoneNumber = BusinessClientUI.GetPhoneNumber();
                            Messenger.ShowEnterNameMessage();
                            businessClient.Name = BusinessClientUI.GetUserName();
                            businessClientManager.SaveOrder(pastry);
                            Messenger.ShowOrderAcceptedMessage();
                            businessClientManager.SaveUser(businessClient);
                        }
                    }
                    if (result is false)
                    {
                        Messenger.ShowNoProductsMessage();
                    }
                }
            }
        }
    }
}