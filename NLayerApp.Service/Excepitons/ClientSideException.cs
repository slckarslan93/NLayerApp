﻿namespace NLayerApp.Service.Excepitons
{
    public class ClientSideException : Exception
    {
        public ClientSideException(string message) : base(message)
        {
        }
    }
}