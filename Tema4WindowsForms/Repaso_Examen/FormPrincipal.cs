using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repaso_Examen
{
    public partial class FormPrincipal : Form
    {
        CheckBox ch;
        ToolTip toolTip = new ToolTip();
        public FormPrincipal()
        {
            InitializeComponent();
            timer1.Start();
            botones = new Button[] { btnJugar, btnReset, btnSalir };
        }

        //Cambiar botones color
        Button[] botones;
        int indice = 0;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            foreach (Button boton in botones)
            {
                boton.BackColor = Color.Beige;
            }
            botones[indice].BackColor = Color.Yellow;
            indice++;
            if (indice >= botones.Length)
            {
                indice = 0;
            }
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            int x = 30;
            int y = 30;
            for (int i = 1; i <= 50; i++)
            {
                ch = new CheckBox();
                ch.Enabled = true;
                ch.Visible = true;
                ch.Size = new Size(30, 30);
                ch.Location = new Point(x, y);
                ch.Text = i.ToString();
                ch.TabIndex = i + 4;
                if (i % 9 == 0)
                {
                    y += 40;
                    x = 30;
                }
                else
                {
                    x += 40;
                }
                ch.CheckedChanged += checkBox_Checked;
                toolTip.SetToolTip(ch, "No marcado");
                Controls.Add(ch);
            }
        }
        int contadorCheckBox = 0;
        List<string> checkBoxElegidos = new List<string>();
        private void checkBox_Checked(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                toolTip.SetToolTip((CheckBox)sender, "Marcado");
                contadorCheckBox++;

            }
            else
            {
                toolTip.SetToolTip((CheckBox)sender, "No marcado");
                contadorCheckBox--;
            }
        }


        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (LstNombres.Items.Count > 0)
            {
                if (MessageBox.Show("Se saldrá de la aplicacion", this.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
            // Si la lista no tiene items sale directamente
            else
            {
                e.Cancel = false;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblResultados.Text = "Resultados";
            foreach (Control c in Controls)
            {
                if (c is CheckBox)
                {
                    ((CheckBox)c).Checked = false;
                    ((CheckBox)c).BackColor = Color.White;
                    toolTip.SetToolTip((CheckBox)c, "No marcado");
                }
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int[] numerosGanadores;
        //int[] numerosAcertados;
        private void btnJugar_Click(object sender, EventArgs e)
        {

            if (contadorCheckBox != 6)
            {
                MessageBox.Show("Usted debe marcar exactamente 6 checkBoxes", "ERROR DE USO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Random random = new Random();
                int aleatorio = random.Next(1, 50);
                numerosGanadores = new int[6];
                for (int i = 0; i < numerosGanadores.Length; i++)
                {
                    while (numerosGanadores.Contains(aleatorio))
                    {
                        aleatorio = random.Next(1, 50);
                    }
                    numerosGanadores[i] = aleatorio;
                    lblResultados.Text += $", {numerosGanadores[i]}";
                    //Pintar de oro checkBox que coincidan
                }
            }
            SacarFormModal();

        }

        //Este codigo iria en jugar 
        private void SacarFormModal()
        {
            if (numerosGanadores.Length >= 1)
            {
                FormDatos formDatos = new FormDatos();
                formDatos.MaximizeBox = false;
                formDatos.MinimizeBox = false;
                formDatos.FormBorderStyle = FormBorderStyle.FixedSingle;
                formDatos.ShowDialog();
                string nombre = "";
                int edad = 0;
                foreach (var item in formDatos.Controls)
                {
                    if (item.GetType() == typeof(TextBox) && ((TextBox)item).Text != "" && ((TextBox)item).Text != null)
                    {
                        nombre = ((TextBox)item).Text;
                    }
                    else
                    {
                        MessageBox.Show("Ha habido un error en el nombre del usuario", "INTRODUZCA UN NOMBRE VÁLIDO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (item is ComboBox cbEdad)
                    {
                        edad = (int)cbEdad.SelectedItem;
                    }
                }
                Record nuevoRecord = new Record(nombre, edad, numerosGanadores[0]);

            }

        }
    }
}
//El formulario principal tendrá como título Lotería simple y además las siguientes
//características:

//-Dispondrá de 49 checkboxes distribuidas en 6 filas y 9 columnas (la última fila,
//lógicamente, estará incompleta). Cada una tendrá un número del 1 al 49 en su interior. Dichas
//checkbox serán creadas por código en el evento Load o en el constructor de formulario. Se
//recomienda colocar cada 40 píxeles uno y de tamaño 30x30. El primer componente estará
//colocado en la posición 30,30 del formulario. No se usarán paneles. Nota: Si no se sabe hacer
//esto, realízalo en tiempo de diseño pero solo con 10 Checkbox para poder continuar. OK

//- Además aparece un toolTip para cada CheckBox que indica Marcado o No Marcado (Al
//principio del programa los tooltips deben estar todos a No Marcado, luego lo cambiarás según
//los marque/desmarque el usuario). OK

//- Trabajando ya con el diseñador habrá un botón denominado Jugar (BtnJugar), un
//segundo botón denominado Reset (BtnReset) y otro botón denominado Salir (BtnSalir). OK

//- Estos tres botones serán de color Beige. Mediante un Timer se realizará el efecto de
//cambio de color secuencial a Yellow cada 300ms. Es decir, estará 300ms Jugar en amarillo,
//luego vuelve a Beige y pasa a amarillo el Reset finalmente hará lo mismo el Cancelar y vuelve
//a empezar. OK

//- Habrá también un ListBox de selección múltiple denominado LstNombres y un botón
//con el texto Eliminar (BtnEliminar). Se explica más abajo el funcionamiento de ambos. OK

//- Se diseñará un menú en cuya cabecera aparecerá la palabra ‘Acciones’ (ojo con el
//subrayado) y al desplegarse aparecerán las opciones ‘Jugar’, ‘Reset’, un separador y ‘Salir’.
//Además dichas opciones tendrán como atajo de teclado asociado F5, F6 y CTRL+S
//respectivamente. Compartirán código con los botones análogos. OK

//- El orden de tabulación será el adecuado para pasar por todos los elementos anteriores
//de forma ordenada de izquierda a derecha y de arriba a abajo saltándose los botones Eliminar
//y Salir. OK

//- Existirá también una etiqueta donde se visualizarán los números resultantes
//(LblResultados). Si no está en uso, aparece simplemente la palabra: Resultados. OK

//- Al presionar el botón Reset (o la opción del menú), se recorrerán todos los CheckBox
//y se desactivarán si estuviera alguno activado y se reinicia su color. También se restauran los
//tooltips y la etiqueta de resultados. OK

//- Se saldrá de la aplicación (por botón, menú o icono X) con confirmación mediante un
//MessageBox con el texto: “Se saldrá de la aplicación”, título el de la aplicación, icono
//Exclamation y los botondes OK y Cancel. Si se pulsa OK finaliza, si se pulsa Cancel se cancela
//el cierre. Esta pregunta se realizará solo si en LstNombre hay algún elemento, si no fuera así,
//sale sin preguntar nada. OK

//- Al presionar el botón u opción del menú Jugar sucederá lo siguiente:
//Se comprobará que el usuario ha marcado 6 CheckBox exactamente. Si hubiera
//menos o más se le informará del problema mediante un MessageBox. Evita
//hacer bucles para ver los marcados, trata de usar los eventos adecuados para
//hacer el contaje. OK (creo)

//Si el paso anterior es correcto, el ordenador sacará 6 números aleatorios
//distintos entre 1 y 49 (o entre 1 y 10 si lo hiciste en diseño) que guardará en
//un vector o colección. Además se mostrarán en la etiqueta de Resultados. OK

//Se comprobará los aciertos que haya tenido coloreando el fondo de los CheckBox
//acertados de color Gold. No deben marcarse los no acertados.

//Si hay uno o más aciertos, se sacará el formulario FrmDatos de tamaño fijo y sin
//iconos de minimizar ni maximizar de forma Modal para pedir al usuario los
//datos siguientes:
// Nombre: mediante etiqueta y un TextBox (TxtNombre).
// Edad: será un ComboBox (CboEdad) con los números del 18 al 100
//rellenado en tiempo de ejecución.
// Dispondrá de un botón Cancelar y otro Aceptar. Al pasar el ratón por
//encima de uno de estos botones habrá un cambio de color a Azul que se
//restaurará al salir del mismo. Debe usarse la misma función para ambos
//botones. Además el ratón al estar en alguno de los botones cambiará su
//aspecto al de una mano apuntando.
// Si pulsa el botón Cancelar se realiza un reset, es decir, se hace el efecto
//de pulsar BtnReset y queda preparado para un nuevo juego (se hará este
//código en el formulario principal como respuesta al diálogo y no en el
//secundario).
// Si se pulsa el botón Aceptar hará básicamente lo mismo que Cancelar,
//pero además añadirá a LstNombres del formulario principal una entrada
//con un objeto nuevo tipo Record que almacene el nombre, la edad y el
//número de aciertos en la propiedad Puntuacion.
//-El botón BtnEliminar elimina todos los elementos seleccionados de la LstNombres.
