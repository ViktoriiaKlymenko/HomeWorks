<<<<<<< HEAD
﻿using System;

namespace PastriesDelivery
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var currencyConverter = new CurrencyService();
            Pastry pastry = new Pastry();
            var storage = StorageSerializer.ExtractFomJsonFile();
            var logger = new Logger();
            while (true)
            {
                Messenger.GreetUser();
                var user = Console.ReadLine();

                if (user is "provider")
                {
                    WorkWithProvider(pastry, storage, logger);
                }

                if (user is "consumer")
                {
<<<<<<< HEAD
<<<<<<< HEAD
                    WorkWithConsumer(pastry, storage, currencyConverter);
=======
                    WorkWithConsumer(pastry, storage, logger);
>>>>>>> main
=======
                    WorkWithConsumer(pastry, storage, currencyConverter, logger);
>>>>>>> b570995b4acb0dc6aa8f439c08b1c3f6635fcf8c
                }

                if (user is "business client")
                {
<<<<<<< HEAD
<<<<<<< HEAD
                    WorkWithBusinessClient(pastry, storage, currencyConverter);
=======
                    WorkWithBusinessClient(pastry, storage, logger);
>>>>>>> main
=======
                    WorkWithBusinessClient(pastry, storage, currencyConverter, logger);
>>>>>>> b570995b4acb0dc6aa8f439c08b1c3f6635fcf8c
                }
                StorageSerializer.SaveToJsonFile(storage);
            }
        }

        private static void WorkWithProvider(Pastry pastry, IStorage storage, ICurrencyConverter currencyConverter, ILogger logger)
        {
            var providerManager = new BusinessProviderManager(storage, logger);
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

<<<<<<< HEAD
<<<<<<< HEAD
        private static void WorkWithConsumer(Pastry pastry, Storage storage, ICurrencyService currencyConverter)
        {
            bool dataIsPresent;
            int id, amount;
            var consumerManager = new ConsumerManager(storage, currencyConverter);
=======
        private static void WorkWithConsumer(Pastry pastry, IStorage storage, ILogger logger)
        {
            bool dataIsPresent;
            int id, amount;
            var consumerManager = new ConsumerManager(storage, logger);
>>>>>>> main
=======
        private static void WorkWithConsumer(Pastry pastry, IStorage storage, ICurrencyConverter currencyConverter, ILogger logger)
        {
            bool dataIsPresent;
            int id, amount;
            var consumerManager = new ConsumerManager(storage, logger);
>>>>>>> b570995b4acb0dc6aa8f439c08b1c3f6635fcf8c
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
                        var order = consumerManager.CreateOrder(pastry, consumer);
                        displayer.DisplayOrder(order);
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

<<<<<<< HEAD
<<<<<<< HEAD
        private static void WorkWithBusinessClient(Pastry pastry, Storage storage, ICurrencyService currencyConverter)
        {
            bool dataIsPresent;
            int id, amount;
            var businessClientManager = new BusinessClientManager(storage, currencyConverter);
=======
        private static void WorkWithBusinessClient(Pastry pastry, IStorage storage, ILogger logger)
        {
            bool dataIsPresent;
            int id, amount;
            var businessClientManager = new BusinessClientManager(storage, logger);
>>>>>>> main
=======
        private static void WorkWithBusinessClient(Pastry pastry, IStorage storage, ICurrencyConverter currencyConverter, ILogger logger)
        {
            bool dataIsPresent;
            int id, amount;
            var businessClientManager = new BusinessClientManager(storage, logger);
>>>>>>> b570995b4acb0dc6aa8f439c08b1c3f6635fcf8c
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

                        if (businessClient is null)
                        {
                            return;
                        }

                        var order = businessClientManager.CreateOrder(pastry, businessClient);
                        displayer.DisplayOrder(order);
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
<<<<<<< HEAD
<<<<<<< HEAD
            Messenger.ShowCancelMessage();
=======
            Messenger.ShowExitMessage();
>>>>>>> main
=======
            Messenger.ShowCancelMessage();
>>>>>>> b570995b4acb0dc6aa8f439c08b1c3f6635fcf8c
            do
            {
                Messenger.ShowEnterAddressMessage();
                user.Address = Console.ReadLine();
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> b570995b4acb0dc6aa8f439c08b1c3f6635fcf8c

                if (user.Address is "stop")
                {
                    return null;
                }
            } while (DataValidator.ValidateAddress(user.Address));
<<<<<<< HEAD
=======
            } while (!DataValidator.IsAddressValid(user.Address));
>>>>>>> main
=======
>>>>>>> b570995b4acb0dc6aa8f439c08b1c3f6635fcf8c

            do
            {
                Messenger.ShowEnterPhoneNumberMessage();
                user.PhoneNumber = Console.ReadLine();
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> b570995b4acb0dc6aa8f439c08b1c3f6635fcf8c

                if (user.Address is "stop")
                {
                    return null;
                }
            } while (DataValidator.ValidatePhoneNumber(user.PhoneNumber));
<<<<<<< HEAD
=======
            } while (!DataValidator.IsPhoneNumberValid(user.PhoneNumber));
>>>>>>> main
=======
>>>>>>> b570995b4acb0dc6aa8f439c08b1c3f6635fcf8c

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
=======
﻿//using System;

//namespace PastriesDelivery
//{
//    internal class Program
//    {
//        private static void Main(string[] args)
//        {
//            Pastry pastry = new Pastry();
//            var storage = StorageSerializer.ExtractFomJsonFile();
//            var logger = new Logger();
//            while (true)
//            {
//                Messenger.GreetUser();
//                var user = Console.ReadLine();

//                if (user is "provider")
//                {
//                    WorkWithProvider(pastry, storage, logger);
//                }

//                if (user is "consumer")
//                {
//                    WorkWithConsumer(pastry, storage, logger);
//                }

//                if (user is "business client")
//                {
//                    WorkWithBusinessClient(pastry, storage, logger);
//                }
//                StorageSerializer.SaveToJsonFile(storage);
//            }
//        }

//        private static void WorkWithProvider(Pastry pastry, IStorage storage, ILogger logger)
//        {
//            var providerManager = new BusinessProviderManager(storage, logger);
//            var provider = new User
//            {
//                Name = "Some Name",
//                Role = Role.Provider,
//                PhoneNumber = "+380XXXXXXXXX",
//                Address = "Some adress"
//            };

//            Messenger.SendOfferRequirments();
//            pastry = ProviderUI.AcceptData(providerManager, pastry);
//            Messenger.ShowConfirmMessage();
//            var answer = Console.ReadLine();

//            if (answer is "yes")
//            {
//                providerManager.CreateOffer(pastry, provider);
//                Messenger.ShowOfferAcceptedMessage();
//            }
//        }

//        private static void WorkWithConsumer(Pastry pastry, IStorage storage, ILogger logger)
//        {
//            bool dataIsPresent;
//            int id, amount;
//            var consumerManager = new ConsumerManager(storage, logger);
//            var consumer = new User
//            {
//                Role = Role.Сustomer
//            };
//            var displayer = new CustomerUI(consumerManager);
//            Messenger.ShowAvailableProductsMessage();
//            dataIsPresent = consumerManager.CheckForDataPrescence();

//            if (dataIsPresent)
//            {
//                displayer.DisplayAvailableProducts();

//                id = GetId();
//                amount = GetAmount();

//                Messenger.ShowConfirmMessage();
//                var answer = Console.ReadLine();

//                if (answer is "yes")
//                {
//                    try
//                    {
//                        pastry = consumerManager.ChooseProduct(id, amount);
//                        consumer = GetUserInformation(consumer);
//                        consumerManager.CreateOrder(pastry, consumer);
//                        Messenger.ShowOrderAcceptedMessage();
//                    }
//                    catch (ArgumentOutOfRangeException)
//                    {
//                        Messenger.ShowUnavailableAmountMessage();
//                    }
//                }
//            }

//            if (!dataIsPresent)
//            {
//                Messenger.ShowNoProductsMessage();
//            }
//        }

//        private static void WorkWithBusinessClient(Pastry pastry, IStorage storage, ILogger logger)
//        {
//            bool dataIsPresent;
//            int id, amount;
//            var businessClientManager = new BusinessClientManager(storage, logger);
//            var businessClient = new User
//            {
//                Role = Role.Сustomer
//            };
//            Messenger.ShowAvailableProductsMessage();
//            var displayer = new CustomerUI(businessClientManager);
//            dataIsPresent = businessClientManager.CheckForDataPrescence();

//            if (dataIsPresent)
//            {
//                displayer.DisplayAvailableProducts();
//                id = GetId();
//                amount = GetAmount();
//                Messenger.ShowConfirmMessage();
//                var answer = Console.ReadLine();

//                if (answer is "yes")
//                {
//                    try
//                    {
//                        pastry = businessClientManager.ChooseProduct(id, amount);
//                        businessClient = GetUserInformation(businessClient);
//                        businessClientManager.CreateOrder(pastry, businessClient);
//                        Messenger.ShowOrderAcceptedMessage();
//                    }
//                    catch (ArgumentOutOfRangeException)
//                    {
//                        Messenger.ShowUnavailableAmountMessage();
//                    }
//                }
//            }

//            if (!dataIsPresent)
//            {
//                Messenger.ShowNoProductsMessage();
//            }
//        }

//        private static User GetUserInformation(User user)
//        {
//            Messenger.ShowExitMessage();
//            do
//            {
//                Messenger.ShowEnterAddressMessage();
//                user.Address = Console.ReadLine();
//            } while (!DataValidator.IsAddressValid(user.Address));

//            do
//            {
//                Messenger.ShowEnterPhoneNumberMessage();
//                user.PhoneNumber = Console.ReadLine();
//            } while (!DataValidator.IsPhoneNumberValid(user.PhoneNumber));

//            Messenger.ShowEnterNameMessage();
//            user.Name = Console.ReadLine();
//            return user;
//        }

//        private static int GetAmount()
//        {
//            int amount = default;

//            do
//            {
//                Console.Write("Please, enter amount: ");

//                if (int.TryParse(Console.ReadLine(), out int res))
//                {
//                    amount = res;
//                    return amount;
//                }
//            } while (amount == default);

//            return amount;
//        }

//        private static int GetId()
//        {
//            int id = default;

//            do
//            {
//                Console.Write("Please, enter id: ");

//                if (int.TryParse(Console.ReadLine(), out int res))
//                {
//                    id = res;
//                    return id;
//                }
//            } while (id == default);

//            return id;
//        }
//    }
//}
>>>>>>> Task4-APILayer
