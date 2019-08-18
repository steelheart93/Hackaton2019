using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DaVueltasFin
{
    public class NumeroTarjetaNoExisteException : Exception
    {
        public NumeroTarjetaNoExisteException(String numero)
            : base($"No existe numero de tarjeta: '{numero}'.") { }
    }

    public class TarjetaNoActivaException : Exception
    {
        public TarjetaNoActivaException(String numero)
            : base($"No se encuetra activa la tarjeta: '{numero}'.") { }
    }

    public class ValorDonacionException : Exception
    {
        public ValorDonacionException(float valor)
            : base($"El valor a donar es inferior a lo permitido: '{valor}'.") { }
    }

    public class EntidadInvalidaException : Exception
    {
        public EntidadInvalidaException(String codigo)
            : base($"La entidad no se encuentra registrada: '{codigo}'.") { }
    }


}
