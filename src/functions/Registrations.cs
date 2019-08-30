using System;
using System.Collections.Generic;
using DevLab.JmesPath.Interop;

namespace DevLab.JmesPath.Functions
{
    public sealed class Registrations
    {
        public static IRegisterFunctions Register(IRegisterFunctions repository)
        {
            repository
                .Register<Iff>()
            ;

            return repository;
        }
    }
}