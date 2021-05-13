﻿using System;

namespace PastriesDelivery
{
    /// <summary>
    /// This class describes methods intended for work with consumer interface.
    /// </summary>
    internal class ConsumerUI : IDataDisplayer
    {
        private readonly IStorage _storage;

        public ConsumerUI(IStorage storage)
        {
            _storage = storage;
        }

        public bool CheckForDataPrescence()
        {
            if (_storage.Pastries.Count == 0)
            {
                return false;
            }
            return true;
        }

        public void DisplayAvailableProducts()
        {
            for (int i = 0; i < _storage.Pastries.Count; i++)
            {
                if (_storage.Type[i] == StorageType.AvailableProducts)
                {
                    var pastry = _storage.Pastries[i];
                    Console.WriteLine("Pastry Id: " + pastry.Id);
                    Console.WriteLine("Pastry name: " + pastry.Name);
                    Console.WriteLine("Pastry type: " + pastry.Type);
                    Console.WriteLine("Pastry weight: " + pastry.Weight + " gr");
                    Console.WriteLine("Pastry price: " + pastry.Price + " USD");
                    Console.WriteLine("Pastry amount: " + pastry.Amount);
                }
            }
        }

        public static string GetAddress()
        {
            string address;
            var patterns = new RegexPatterns();
            var dataValidator = new DataValidator(patterns);
            do
            {
                Messenger.ShowEnterAddressMessage();
                address = Console.ReadLine();
            } while (!dataValidator.ValidateAddress(address));
            return address;
        }

        public static string GetPhoneNumber()
        {
            string phoneNumber;
            var patterns = new RegexPatterns();
            var dataValidator = new DataValidator(patterns);
            do
            {
                Messenger.ShowEnterPhoneNumberMessage();
                phoneNumber = Console.ReadLine();
            } while (!dataValidator.ValidateAddress(phoneNumber));
            return phoneNumber;
        }

        public static string GetOrder()
        {
            return Console.ReadLine();
        }

        public string ConfirmOrder()
        {
            var answer = Console.ReadLine();
            return answer;
        }

        internal static int ExtractId(string idAndAmount)
        {
            var id = Convert.ToInt32(idAndAmount.Split(" ", StringSplitOptions.RemoveEmptyEntries)[0]);
            return id;
        }

        internal static int ExtractAmount(string idAndAmount)
        {
            var amount = Convert.ToInt32(idAndAmount.Split(" ", StringSplitOptions.RemoveEmptyEntries)[1]);
            return amount;
        }
    }
}