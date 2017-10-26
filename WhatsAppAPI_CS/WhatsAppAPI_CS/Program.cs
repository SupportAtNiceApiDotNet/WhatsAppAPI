using System;
using System.Net;
using System.Net.Http;
using System.IO;

namespace WhatsAppAPI_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            WhatApp whatsApp = new WhatApp("<Your unique X-APIId>");        // you get this on https://niceapi.net/Details 
            whatsApp.Send("<Mobile number>", "Sent from my application.");  // one of the numbers you registred at https://niceapi.net/Register
        }
    }
}
