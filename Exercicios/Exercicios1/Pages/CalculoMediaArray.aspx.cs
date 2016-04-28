using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exercicios1.Pages
{
    public partial class CalculoMediaArray : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CalcularMEdia(object sender, EventArgs e)
        {
            //calculo utilizando array de inteiros
            try
            {
                double[] notas = new double[3];
                notas[0] = double.Parse(Txtnota1.Text);
                notas[1] = double.Parse(Txtnota2.Text);
                notas[2] = double.Parse(Txtnota3.Text);



                double media = Businnes.CalcularMedia.CalculateWithArray(notas);

                LblMedia.Text = "A media dos Alunos calculada utilizando array é: " + Math.Round(media, 2).ToString();

            

            }
            catch (Exception )
            {

                LblMedia.Text = "Todos Os Campos devem ser Preenchidos com numeros!";
            }
            
            


        }

        protected void LkbCalculaLista_Click(object sender, EventArgs e)
        {
            //Calculo utilizando lista
            try
            {
                List<double> listanotas = new List<double>();
                listanotas.Add(double.Parse(Txtnota1.Text));
                listanotas.Add(double.Parse(Txtnota2.Text));
                listanotas.Add(double.Parse(Txtnota3.Text));




                double medialist;
                medialist = Businnes.CalcularMedia.CalculateWithList(listanotas);
                Math.Round(medialist, 2);
                LblMedia.Text = "A media dos alunos calculada utilizando lista é: " + Math.Round(medialist, 2);
            }
            catch (Exception )
            {

                LblMedia.Text = "Todos Os Campos devem ser Preenchidos com Numeros!";
            }
            
        }
    }
}