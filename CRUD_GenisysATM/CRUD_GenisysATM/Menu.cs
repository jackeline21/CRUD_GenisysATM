using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// En este proyecto se utilizara Material Skin
using MaterialSkin;
using MaterialSkin.Controls;

namespace CRUD_GenisysATM
{
    public partial class Menu : MaterialForm
    {
        // Para cambiar las propiedades
        // Ejemplo cambiar los colores 
        private readonly MaterialSkinManager materialSkinManager;
        public Menu()
        {
            InitializeComponent();
            // Implementar temas y colores
            materialSkinManager = MaterialSkinManager.Instance;
            //Agregar la forma a la que le vamos a cambiar propiedades
            materialSkinManager.AddFormToManage(this);
            // Tema que vamos a utilizar
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            // Instancial el esquema de color 
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue500, Primary.Blue700, Primary.Blue200,
                Accent.Orange400, TextShade.WHITE
            );
        }
    }
}
