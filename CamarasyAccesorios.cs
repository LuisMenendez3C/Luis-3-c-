using System;
using System.Collections.Generic;
using System.Text;

namespace InstalacionyVentaDeCamarasDeSeguridad
{
   
    public abstract class CamarasyAccesorios
    {
        public CamarasyAccesorios()
        {
            
        }

        public int Identificador { get; set; }//marca y modelo
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public decimal Iva { get; set; }
        

    }
    
}
    
   
