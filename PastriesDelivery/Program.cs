﻿using System;

namespace PastriesDelivery
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var storage = new Storage();
            while (true)
            {
                static string DetectUser()
                {
                    return Console.ReadLine();
                }
                Messenger.GreetUser();

                var user = DetectUser();

                if (user is "provider")
                {
                    var pastry = new Pastry();
                    var manager = new BusinessProviderManager(storage);
                    var User = new User()
                    {
                        Name = "Some Name",
                        Type = UserType.Provider,
                        PhoneNumber = "+380XXXXXXXXX",
                        Address = "Some adress"
                    };

                    Messenger.SendOfferRequirments();

                    try
                    {
                        var providerUI = new ProviderUI(storage);
                        pastry = providerUI.AcceptData(pastry);
                        var answer = providerUI.ConfirmOffer();

                        if (answer is "yes")
                        {
                            manager.AddNewOffer(pastry, User);
                            Messenger.ShowOfferAcceptedMessage();
                        }
                    }
                    catch (FormatException)
                    {
                        Messenger.ShowWrongDataMessage();
                    }
                }

                if (user is "consumer")
                {
                    var manager = new ConsumerManager(storage);
                    var messenger = new Messenger(storage);
                    var consumer = new User
                    {
                        Name = "Some name",
                        Type = UserType.Consumer
                    };

                    var displayer = new ConsumerUI(storage);
                    Messenger.ShowAvailableProductsMessage();
                    bool result = displayer.CheckForDataPrescence();

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
                                var pastry = manager.ChooseProduct(id, amount);
                                messenger.ShowUnavailableAmountMessage(id, amount);
                                consumer.Address = ConsumerUI.GetAddress();
                                consumer.PhoneNumber = ConsumerUI.GetPhoneNumber();
                                storage = manager.SendOrderToStorage(storage, pastry);
                                Messenger.ShowOrderAcceptedMessage();
                                storage = manager.SendUserToStorage(storage, consumer);
                            }
                            catch (FormatException)
                            {
                                Messenger.ShowWrongDataMessage();
                            }
                        }
                    }
                    if (result is false)
                    {
                        Messenger.ShowNoProductsMessage();
                    }
                }

                if (user is "business client")
                {
                    var manager = new BusinessClientManager(storage);
                    var messenger = new Messenger(storage);
                    var businessClient = new User()
                    {
                        Name = "Some name",
                        Type = UserType.BusinessClient
                    };

                    Messenger.ShowAvailableProductsMessage();
                    var displayer = new BusinessClientUI(storage);
                    bool result = displayer.CheckForDataPrescence();
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
<<<<<<< HEAD
                                var pastry = manager.ChooseProduct(id, amount);
                                messenger.ShowUnavailableAmountMessage(id, amount);
                                businessClient.Address = BusinessClientUI.GetAddress();
=======
                                var pastry = manager.ChooseProduct(idAndAmount, storage);
                                messenger.ShowUnavailableAmountMessage(idAndAmount);
                                
                                businessClient.Address = BusinessClientUI.GetAddress();
                                
>>>>>>> bcfe49a (Regular expressions were added.)
                                businessClient.PhoneNumber = BusinessClientUI.GetPhoneNumber();
                                manager.SendOrderToStorage(pastry);
                                Messenger.ShowOrderAcceptedMessage();
                                manager.SendUserToStorage(businessClient);
                            }
                            catch (FormatException)
                            {
                                Messenger.ShowWrongDataMessage();
                            }
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