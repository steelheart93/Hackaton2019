using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DaVueltasAsi
{
    public class Excepciones : Exception
    {
        public class OrganizacionYaExisteException : Exception
        {
            public OrganizacionYaExisteException(String Nit)
                : base($"Ya existe una organizacion con Nit '{Nit}'.") { }
        }

        public class OrganizacionNoExisteException : Exception
        {
            public OrganizacionNoExisteException(String Nit)
                : base($"No existe una organizacion con Nit '{Nit}'.") { }
        }

    }
}
}
