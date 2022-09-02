using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Domino
{
    public partial class Form1 : Form
    {
        DatosNecesarios datos = new DatosNecesarios();
        int IA = 0;
        int Equipo = 0;
        GameRules<string> Rules;
        Player<string>[] Players;
        ProgramedRules<string> RulesImplentations;
        ProgramedPlayers<string> PlayersImplementations;
        public Form1()
        {
            InitializeComponent();
            RulesImplentations = GetGameRules<string>.BuildProgramedRules();
            PlayersImplementations = new ProgramedPlayers<string>();
        }
        private void Opciones(object sender,EventArgs e)
        {
            IDescribable des = RulesImplentations.Upper(((Button)sender).Name);
            ((Button)sender).Text = des.Name();
        }
        private void Siguiente_Click(object sender, EventArgs e)
        {
            datos.faces.Add(textBox1.Text);
            textBox1.Text = "";
        }
        private void Plus_Click(object sender, EventArgs e)
        {
            datos.FichasByPlayer += 1;
            textBox2.Text = Convert.ToString(datos.FichasByPlayer);
        }
        private void Less_Click(object sender, EventArgs e)
        {
            if (datos.FichasByPlayer == 0)
            {
                MessageBox.Show("La cantidad de fichas no puede ser negativa");
                return;
            }
            datos.FichasByPlayer -= 1;
            textBox2.Text = Convert.ToString(datos.FichasByPlayer);
        }
        private void Incluir_Click(object sender, EventArgs e)
        {
            datos.IAs.Add(IA);
            datos.Equipos.Add(Equipo);
            NumPlayers.Text = Convert.ToString(datos.IAs.Count);
        }
        private void PlusIA_Click(object sender, EventArgs e)
        {
            if (IA == PlayersImplementations.Types.Count - 1)
                IA = 0;
            else
                IA++;
            PlayerIA.Text = Convert.ToString(IA);
        }

        
        private void PlusTeam_Click(object sender, EventArgs e)
        {
            if (Equipo == datos.Equipos.Count + 1)
                Equipo = 0;
            else
                Equipo++;
            PlayerTeam.Text = Convert.ToString(Equipo);
        }
        public Label Informacion;
        GameRecord<string> record;
        Button Cara1;
        Button Cara2;
        Button FaceMuv1;
        Button FaceMuv2;
        Label PlayerIndicator;
        ListBox Tokens;
        Timer temporizador;
        bool TokenDirection = true;
        Form MyForm;
        private void Aceptar_Click(object sender, EventArgs e)
        {
            string Error;
            bool OK = Auxiliares<string>.ValidateSttings(datos.faces.ToArray(), datos.IAs.ToArray(), datos.Equipos.ToArray(),
                datos.FichasByPlayer, datos.IAs.Count,RulesImplentations , out Error, out Players, out Rules);
            if (!OK)
            {
                MessageBox.Show(Error);
                return;
            }

            MyForm = new Form();
            MyForm.Size = new System.Drawing.Size(800, 550);

            Informacion = new Label();
            Informacion.AutoSize = true;
            Informacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));





            Button Activate = new Button();
            Activate.Location = new System.Drawing.Point(400, 300);
            Activate.Click += new System.EventHandler(PlayPauseTimer);
            Activate.Text = "Cont./Parar";

            Button Return = new Button();
            Return.Location = new System.Drawing.Point(300, 300);
            Return.Click += new System.EventHandler(CloseForm);
            Return.Text = "Regresar";


            Cara1 = new Button();
            Cara1.Location = new System.Drawing.Point(310, 150);
            Cara1.Size = new System.Drawing.Size(89, 71);

            Cara2 = new Button();
            Cara2.Location = new System.Drawing.Point(395, 150);
            Cara2.Size = new System.Drawing.Size(89, 71);

            PlayerIndicator = new Label();
            PlayerIndicator.Text = "";
            PlayerIndicator.Location = new System.Drawing.Point(50, 300);

            Tokens = new ListBox();
            Tokens.Location = new System.Drawing.Point(50, 330);
            Tokens.FormattingEnabled = true;
            Tokens.Size = new System.Drawing.Size(120, 147);

            temporizador = new Timer();
            temporizador.Enabled = false;
            temporizador.Interval = 2;
            temporizador.Tick += new System.EventHandler(ModificateInformation);

            Game<string> game = new Game<string>();
            record = game.Single(Rules, Players);


            FaceMuv1 = new Button();
            FaceMuv1.Visible = false;
            FaceMuv1.Size = new System.Drawing.Size(89, 71);
            FaceMuv1.Location = new System.Drawing.Point(0, 135);

            FaceMuv2 = new Button();
            FaceMuv2.Visible = false;
            FaceMuv2.Size = new System.Drawing.Size(89, 71);
            FaceMuv2.Location = new System.Drawing.Point(0, 200);

            

            MyForm.Controls.Add(Informacion);
            MyForm.Controls.Add(Return);
            MyForm.Controls.Add(Activate);
            MyForm.Controls.Add(Cara1);
            MyForm.Controls.Add(Cara2);
            MyForm.Controls.Add(FaceMuv1);
            MyForm.Controls.Add(FaceMuv2);
            MyForm.Controls.Add(PlayerIndicator);
            MyForm.Controls.Add(Tokens);
            MyForm.Show();
           


        }
        private void UpdateTable()
        {
            int index = record.index < record.CarasDisponibles.Count - 1 ? record.index : record.CarasDisponibles.Count - 1;
        
            Cara1.Text = record.CarasDisponibles[index].Item1;
            Cara2.Text = record.CarasDisponibles[index].Item2;
        }
        
        private void CloseForm(object sender, EventArgs e)
        {
            Equipo = 0;
            temporizador.Enabled = false;
            datos.IAs.Clear();
            datos.Equipos.Clear();
            MyForm.Close();

        }
        private void PlayPauseTimer(object sender, EventArgs e)
        {
            ShowInformation();
            temporizador.Enabled = !temporizador.Enabled;
        }
        private void ModificateInformation(object sender, EventArgs e)
        {
            
            if (record.index == record.Registro.Count)
            {
                ((Timer)sender).Enabled = false;
                Informacion.Text = record.Mensajes[record.Mensajes.Count-1];
                record.index = 0;
                return;
            }
            

            if (record.Registro[record.index].Item2.Type != record.Registro[record.index].Item2.Pass)
            {
                FaceMuv1.Visible = true;
                FaceMuv2.Visible = true;
                FaceMuv1.Text = Convert.ToString(record.Registro[record.index].Item2.InHand.FirstFace);
                FaceMuv2.Text = Convert.ToString(record.Registro[record.index].Item2.InHand.SecondFace);
            }
            
            if (TokenDirection)
            {
                FaceMuv1.Left += 1;
                FaceMuv2.Left += 1;
            }
            else
            {
                FaceMuv1.Left -= 1;
                FaceMuv2.Left -= 1;
            }

            if (FaceMuv1.Left == 220 || FaceMuv1.Left == 480)
            {
                FaceMuv1.Visible = false;
                FaceMuv2.Visible = false;
                UpdateTable();
                record.index++;
                ShowInformation();

                if (record.index < record.Registro.Count)
                {
                    if (record.Registro[record.index].Item2.IndexOnTable == 0)
                    {
                        FaceMuv1.Location = new System.Drawing.Point(0, 135);
                        FaceMuv2.Location = new System.Drawing.Point(0, 200);
                        TokenDirection = true;
                    }
                    else
                    {
                        FaceMuv1.Location = new System.Drawing.Point(700, 135);
                        FaceMuv2.Location = new System.Drawing.Point(700, 200);
                        TokenDirection = false;
                    }
                }

            }


            
        }
        private void ShowInformation()
        {
            if (record.index == record.Registro.Count)
                return;   
            Informacion.Text = record.Mensajes[record.index];
            PlayerIndicator.Text = "Player " + record.Registro[record.index].Item1.name+": ";
            
            object[] TokensName = new object[record.Registro[record.index].Item1.Mano.Count];
            for (int i = 0; i < record.Registro[record.index].Item1.Mano.Count; i++)
            {
                TokensName[i] = record.Registro[record.index].Item1.Mano[i].ToString();
            }
            Tokens.Items.Clear();
            Tokens.Items.AddRange(TokensName);
        }

        private void DNine_Click(object sender, EventArgs e)
        {
            datos.faces.Clear();
            string[] l = { "0","1", "2", "3", "4", "5", "6", "7", "8","9" };
            datos.faces.AddRange(l.ToList());
        }

        private void DSix_Click(object sender, EventArgs e)
        {
            datos.faces.Clear();
            string[] l = { "0", "1", "2", "3", "4", "5", "6" };
            datos.faces.AddRange(l.ToList());
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (datos.IAs.Count != 0)
            {
                datos.IAs.RemoveAt(datos.IAs.Count - 1);
                datos.Equipos.RemoveAt(datos.Equipos.Count - 1);
                NumPlayers.Text = Convert.ToString(datos.IAs.Count);
            }
        }
        private void ShowInformation(object sender, EventArgs e)
        {
            switch(((Button)sender).Name)
            {
                case "Inf1":
                    ShowInformation(RulesImplentations.ValidateMove);
                    break;
                case "Inf2":
                    ShowInformation(RulesImplentations.Order);
                    break;
                case "Inf3":
                    ShowInformation(RulesImplentations.ValorateToken);
                    break;
                case "Inf4":
                    ShowInformation(RulesImplentations.GameFinisher);
                    break;
                case "Inf5":
                    ShowInformation(RulesImplentations.Result);
                    break;
                case "Inf6":
                    ShowInformation(PlayersImplementations.Types[IA]);
                    break;
            }
        }
        private void ShowInformation(IDescribable d)
        {
            MessageBox.Show(d.Description(), d.Name());
        }
    }
}
public class GameRecord<T>
{
    public List<string> Mensajes = new List<string>();
    public List<Tuple<T, T>> CarasDisponibles = new List<Tuple<T, T>>();
    public List<Tuple<Player<T>, Move<T>>> Registro = new List<Tuple<Player<T>, Move<T>>>();
    public int index = 0;
}

public class DatosNecesarios
{
    
    public List<string> faces = new List<string>();
    public int FichasByPlayer = 0;
    public List<int> IAs = new List<int>();
    public List<int> Equipos = new List<int>();
}

