﻿using System;

namespace PastriesDelivery
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Pastry pastry = new Pastry();
            var storageSerializer = new StorageSerializer
            {
                FileName = "serialized_storage"
            };
            var storage = storageSerializer.ExtractFomJsonFile();

            while (true)
            {
                Messenger.GreetUser();
                var user = Console.ReadLine();

                if (user is "provider")
                {
                    WorkWithProvider(pastry, storage);
                }

                if (user is "consumer")
                {
                    WorkWithConsumer(pastry, storage);

                }

                if (user is "business client")
                {
                    WorkWithBusinessClient(pastry, storage);
                }
            }
        }

        private static void WorkWithProvider(Pastry pastry, Storage storage)
        {
            var providerManager = new BusinessProviderManager(storage);
            var provider = new User
            {
                Name = "Some Name",
                Role = Role.Provider,
                PhoneNumber = "+380XXXXXXXXX",
                Address = "Some adress"
            };

            Messenger.SendOfferRequirments();
            pastry = ProviderUI.AcceptData(providerManager, pastry);
            Messenger.ShowConfirmMessage();
            var answer = Console.ReadLine();

            if (answer is "yes")
            {
                providerManager.CreateOffer(pastry, provider);
                Messenger.ShowOfferAcceptedMessage();
            }
        }

        private static void WorkWithConsumer(Pastry pastry, Storage storage)
        {
            bool dataIsPresent;
            int id, amount;
            var consumerManager = new ConsumerManager(storage);
            var consumer = new User
            {
                Role = Role.Сustomer
            };
            var displayer = new CustomerUI(consumerManager);
            Messenger.ShowAvailableProductsMessage();
            dataIsPresent = consumerManager.CheckForDataPrescence();

            if (dataIsPresent)
            {
                displayer.DisplayAvailableProducts();

                id = GetId();
                amount = GetAmount();

                Messenger.ShowConfirmMessage();
                var answer = Console.ReadLine();

                if (answer is "yes")
                {
                    try
                    {
                        pastry = consumerManager.ChooseProduct(id, amount);
                        consumer = GetUserInformation(consumer);
                        consumerManager.CreateOrder(pastry, consumer);
                        Messenger.ShowOrderAcceptedMessage();
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Messenger.ShowUnavailableAmountMessage();
                    }
                }
            }

            if (!dataIsPresent)
            {
                Messenger.ShowNoProductsMessage();
            }
        }

        private static void WorkWithBusinessClient(Pastry pastry, Storage storage)
        {
            bool dataIsPresent;
            int id, amount;
            var businessClientManager = new BusinessClientManager(storage);
            var businessClient = new User
            {
                Role = Role.Сustomer
            };
            Messenger.ShowAvailableProductsMessage();
            var displayer = new CustomerUI(businessClientManager);
            dataIsPresent = businessClientManager.CheckForDataPrescence();

            if (dataIsPresent)
            {
                displayer.DisplayAvailableProducts();
                id = GetId();
                amount = GetAmount();
                Messenger.ShowConfirmMessage();
                var answer = Console.ReadLine();

                if (answer is "yes")
                {
                    try
                    {
                        pastry = businessClientManager.ChooseProduct(id, amount);
                        businessClient = GetUserInformation(businessClient);
                        businessClientManager.CreateOrder(pastry, businessClient);
                        Messenger.ShowOrderAcceptedMessage();
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Messenger.ShowUnavailableAmountMessage();
                    }

                }
            }

            if (!dataIsPresent)
            {
                Messenger.ShowNoProductsMessage();
            }
        }

        private static User GetUserInformation(User user)
        {
            var regex = new RegexPatterns();
            DataValidator dv = new DataValidator(regex);

            do
            {
                Messenger.ShowEnterAddressMessage();
                user.Address = Console.ReadLine();
            } while (!dv.ValidateAddress(user.Address));

            do
            {
                Messenger.ShowEnterPhoneNumberMessage();
                user.PhoneNumber = Console.ReadLine();
            } while (!dv.ValidatePhoneNumber(user.PhoneNumber));

            Messenger.ShowEnterNameMessage();
            user.Name = Console.ReadLine();
            return user;
        }

        private static int GetAmount()
        {
            int amount = default;

            do
            {
                Console.Write("Please, enter amount: ");

                if (int.TryParse(Console.ReadLine(), out int res))
                {
                    amount = res;
                    return amount;
                }

            } while (amount == default);

            return amount;
        }

        private static int GetId()
        {
            int id = default;

            do
            {
                Console.Write("Please, enter id: ");

                if (int.TryParse(Console.ReadLine(), out int res))
                {
                    id = res;
                    return id;
                }

            } while (id == default);

            return id;
        }
    }
}