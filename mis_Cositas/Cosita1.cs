// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

// Console.WriteLine("Hello, World!");

namespace IntroduccionCSharp.MisCositas
{
    public class Cosita1
    {
        private string saludo;
        public string Saludo { 
            get {return saludo.ToUpper();}
            
            set {saludo = value; }
        }
    }
}