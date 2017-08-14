using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcel
{
    class insertProduct
    {
        public string action { get; set; }
        public string Contenido_del_packete { get; set; }
        public int Peso_en_libras { get; set; }
        public int Valor_del_producto_enviado { get; set; }
       // public string Fecha_de_envio { get; set; }
        public string tracking_num { get; set; }

        public insertProduct(string cdp, int pl, int vdpe, /*string fde,*/ string tn)
        {
            action = "altProduct";
            Contenido_del_packete = cdp;
            Peso_en_libras = pl;
            Valor_del_producto_enviado = vdpe;
            //Fecha_de_envio = fde;
            tracking_num = tn;
        }
    }

    class resultInsertProduc
    {
        public string Contenido_del_packete { get; set; }
        public int Peso_en_libras { get; set; }
        public int Valor_del_producto_enviado { get; set; }
        //public string Fecha_de_envio { get; set; }
        public string tracking_num { get; set; }
    }
}
