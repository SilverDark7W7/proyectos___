using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace generador_contraseña
{
    class TemaColors
    {
        public static Color color_form_recibir;
        public static Color color1_txt_recibir;
        public static Color color2_txt_recibir;
        public static Color boton_recibir;
        public static Color boton_borde_recibir;
        public static Color txt_borde_recibir;
        public static Color boton_generar_recibir;
        public static Color boton_guardar_recibir;
        public static Color color_modificar_recibir;
        public static Color color_btn_buscar_recibir;
        public static Color color_btn_eliminar_recibir;
        public static Color color_panel_busqueda_recibir;
        public static Color color_borde_botones_cambio_recibir;
        public static Color color_celeste_panel_recibir;
        public static Color boton_verde_recibir;
        public static Color color_celeste2_panel_recibir;
        public static Color color_textbox_registro_recibir;

        public static readonly Color color_form_dar = Color.FromArgb(44, 51, 51);
        public static readonly Color color1_txt_dar = Color.FromArgb(53, 133, 139);
        public static readonly Color color2_txt_dar = Color.FromArgb(77, 69, 93);
        public static readonly Color boton_dar = Color.FromArgb(24, 24, 35);
        public static readonly Color boton_borde_dar = Color.FromArgb(53, 133, 139); 
        public static readonly Color txt_borde_dar = Color.FromArgb(233, 100, 121); 
        public static readonly Color boton_generar_dar = Color.FromArgb(255, 211, 101); 
        public static readonly Color boton_guardar_dar = Color.FromArgb(0, 200, 151);
        public static readonly Color color_modificar_dar = Color.FromArgb(254, 98, 68);
        public static readonly Color color_btn_buscar_dar = Color.FromArgb(83, 113, 136);
        public static readonly Color color_btn_eliminar_dar = Color.FromArgb(252, 79, 79); 
        public static readonly Color color_panel_busqueda_dar = Color.FromArgb(139, 24, 116); 
        public static readonly Color color_borde_botones_cambio_dar = Color.FromArgb(248, 180, 0); 
        public static readonly Color color_celeste_panel_dar = Color.FromArgb(174, 254, 255); 
        public static readonly Color boton_verde_dar = Color.FromArgb(27, 156, 133); 
        public static readonly Color color_celeste2_panel_dar = Color.FromArgb(62, 109, 156);
        public static readonly Color color_textbox_registro_dar = Color.FromArgb(57, 62, 70);

        public static void TemaLogin(string tema)
        {

            if (tema == "color_login")
            {
                color_form_recibir = color_form_dar;
                color1_txt_recibir = color1_txt_dar;
                boton_recibir = boton_dar;
                boton_borde_recibir = boton_borde_dar;
                color_modificar_recibir = color_modificar_dar;
                color_celeste_panel_recibir = color_celeste_panel_dar;
                boton_verde_recibir = boton_verde_dar;
                color_celeste2_panel_recibir = color_celeste2_panel_dar;
                color_textbox_registro_recibir = color_textbox_registro_dar;
                
            }

            if (tema == "color1_textbox")
            {
                color1_txt_recibir = color1_txt_dar;
            }

            if (tema == "color2_textbox")
            {
                color2_txt_recibir = color2_txt_dar;
            }

            if(tema == "textbox_borde")
            {
                txt_borde_recibir = txt_borde_dar;
            }

            if (tema == "color_boton_generar")
            {
               boton_generar_recibir = boton_generar_dar;
              
            }


            if (tema == "color_boton_guardar")
            {
                boton_guardar_recibir = boton_guardar_dar;

            }
            

            if (tema == "color_botones_busqueda")
            {
                color_btn_buscar_recibir = color_btn_buscar_dar;
                color_btn_eliminar_recibir = color_btn_eliminar_dar;
                color_panel_busqueda_recibir = color_panel_busqueda_dar;

            }

            if (tema == "color_cambio_datos")
            {
                color_borde_botones_cambio_recibir = color_borde_botones_cambio_dar;

            }

        }
    }
}
