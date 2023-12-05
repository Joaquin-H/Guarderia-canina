using BTS_3k2_PAV.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTS_3k2_PAV.Utils
{
    public class CombosUtils
    {
        public static void CargarCombo(ref ComboBox combo, 
            List<EntidadBase> lista, EntidadBase seleccionado)
        {
            var conector = new BindingSource();
            conector.DataSource = lista;

            combo.DataSource = conector;
            combo.DisplayMember = "Nombre";
            combo.ValueMember = "Id";
            if (seleccionado != null)
                combo.SelectedItem = seleccionado;
        }

        public static void CargarCombo(ref ComboBox combo,
            BindingSource conector, string diplayMember = "Nombre")
        {
            combo.DataSource = conector;
            combo.DisplayMember = diplayMember;
            combo.ValueMember = "Id";
        }
    }
}
