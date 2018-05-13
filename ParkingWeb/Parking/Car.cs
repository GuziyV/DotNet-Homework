﻿using System;

namespace Parking
{
    public class Car
    {
        public Car(uint id, CarType type, decimal balance = 0)
        {
            Id = id;
            Type = type;
            Balance = balance;
        }
        public uint Id { get; private set; }

        public readonly CarType Type;

        public decimal Balance { get; private set; }

        public decimal AddMoney(decimal value)
        {
            Balance += value;
            return Balance;
        }

        public decimal GiveMoney(decimal value)
        {
            Balance -= value;
            return Balance;
        }

    }

    public enum CarType
    {
        Passenger,
        Truck,
        Bus,
        Motorcycle
    }
}
