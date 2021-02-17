using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP13_Vision_Robot
{
    public partial class Form1 : Form
    {
        string AdresseImage;
        int Dx, Dy;
        int Ox, Oy;
        int Cx, Cy;
        int x, y;
        int NumColonneCercleMax = 0;
        int NumLigneCercleMax = 0;

        Bitmap ImagebmpSelectionnee;

        Color[,] TabPixelsCouleurs;
        float[,] TabPixelsFloat;

        public Form1()
        {
            InitializeComponent();

            cmbBoxFichierExistant.Enabled = false;
            cmdOuvreFichier.Enabled = false;
            cmdValiderImage.Enabled = false;
            cmdValiderVraiXY.Enabled = false;
            lblx.Text = "x";
            lbly.Text = "y";
        }

        /// <summary>
        /// ////////////////////////////////// PARTIE COMMANDE DU PROGRAMME /////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>

        private void radFichierExistant_CheckedChanged(object sender, EventArgs e)
        {
            cmbBoxFichierExistant.Enabled = true;
            cmdOuvreFichier.Enabled = false;
            cmdValiderImage.Enabled = true;
        }

        private void radFichierAutre_CheckedChanged(object sender, EventArgs e)
        {
            cmbBoxFichierExistant.Enabled = false;
            cmdOuvreFichier.Enabled = true;
            cmdValiderImage.Enabled = true;
        }

        private void cmdOuvreFichier_Click(object sender, EventArgs e)
        {
            OuvreFichier.ShowDialog();
        }

        private void cmdValiderImage_Click(object sender, EventArgs e)
        {
            try
            {
                if (radFichierExistant.Checked == true)
                {
                    AdresseImage = cmbBoxFichierExistant.SelectedItem.ToString();
                }
                else
                {
                    AdresseImage = OuvreFichier.FileName;
                }


                IntialiserImageSelectionnee();

                ScanImageSelectionneebmp(ImagebmpSelectionnee, TabPixelsCouleurs, TabPixelsFloat);

                FiltreMedian();
                FiltrePassebas();

                Calculxy();
                CalculDxDy();
                CalculCxCy();

                cmdValiderVraiXY.Enabled = true;
            }
            catch (Exception)
            {
                cmdValiderVraiXY.Enabled = false;
                MessageBox.Show("Sélectionnez un fichier valide. Une image au format bmp.");
            }

        }

        /// <summary>
        /// ////////////////////////////////// INITIALISATION IMAGE /////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>

        public void IntialiserImageSelectionnee()
        {
            ImagebmpSelectionnee = new Bitmap(AdresseImage);
            picImageSelectionnee.Image = ImagebmpSelectionnee;
            lblDimensionsImage.Text = "Dimensions : " + ImagebmpSelectionnee.Width + " x " + ImagebmpSelectionnee.Height;

            TabPixelsCouleurs = new Color[ImagebmpSelectionnee.Width, ImagebmpSelectionnee.Height];
            TabPixelsFloat = new float[ImagebmpSelectionnee.Width, ImagebmpSelectionnee.Height];//Fonctionne pas, ne différencie pas le noir et le blanc
        }

        static void ScanImageSelectionneebmp(Bitmap Imagebmp, Color[,] TabPixelsCouleurs, float[,] TabPixelsFloat)
        {
            for (int i = 0; i < Imagebmp.Width; i++)
            {
                for (int j = 0; j < Imagebmp.Height; j++)
                {
                    TabPixelsCouleurs[i, j] = Imagebmp.GetPixel(i, j);
                    TabPixelsFloat[i, j] = TabPixelsCouleurs[i, j].GetBrightness();
                }
            }
        }


        /// <summary>
        /// ////////////////////////////////// CALCUL DE x ET y /////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>

        void Calculxy()
        {
            //Calcul Ox et Oy

            //Ox

            float SommePixelsLigne = 0;

            bool DebutTrouve = false;
            bool FinTrouve = false;
            int DebutValeur = 0;
            int FinValeur = 0;

            float[] TabMoyenneOX = new float[ImagebmpSelectionnee.Width];

            for (int i = 1; i < ImagebmpSelectionnee.Height; i++)
            {
                for (int j = 1; j < 30; j++)
                {
                    SommePixelsLigne = SommePixelsLigne + TabPixelsFloat[i, j];
                }

                TabMoyenneOX[i] = SommePixelsLigne;
                SommePixelsLigne = 0;
            }

            for (int i = 1; i < TabMoyenneOX.Length; i++)
            {
                if (TabMoyenneOX[i] < 25 && DebutTrouve == false)
                {
                    DebutValeur = i;
                    DebutTrouve = true;
                }

                if (TabMoyenneOX[i] >= 25 && DebutTrouve == true && FinTrouve == false)
                {
                    FinValeur = i;
                    FinTrouve = true;
                }
            }

            Ox = Convert.ToInt32((DebutValeur + FinValeur) / 2);
            lblOx.Text = "Ox = " + Ox;

            //Oy

            SommePixelsLigne = 0;

            DebutTrouve = false;
            FinTrouve = false;
            DebutValeur = 0;
            FinValeur = 0;

            float[] TabMoyenneOY = new float[30];

            for (int j = 1; j < 30; j++)
            {
                for (int i = 1; i < ImagebmpSelectionnee.Height; i++)
                {
                    SommePixelsLigne = SommePixelsLigne + TabPixelsFloat[i, j];
                }

                TabMoyenneOY[j] = SommePixelsLigne;
                SommePixelsLigne = 0;
            }

            for (int j = 1; j < TabMoyenneOY.Length; j++)
            {
                if (TabMoyenneOY[j] < 575 && DebutTrouve == false)
                {
                    DebutValeur = j;
                    DebutTrouve = true;
                }

                if (TabMoyenneOY[j] >= 575 && DebutTrouve == true && FinTrouve == false)
                {
                    FinValeur = j;
                    FinTrouve = true;
                }
            }

            Oy = Convert.ToInt32((DebutValeur + FinValeur) / 2);
            lblOy.Text = "Oy = " + Oy;





            //Calcul x et y

            //x

            SommePixelsLigne = 0;

            DebutTrouve = false;
            FinTrouve = false;
            DebutValeur = 0;
            FinValeur = 0;

            float[] TabMoyenneX = new float[ImagebmpSelectionnee.Width];

            for (int i = 0; i < ImagebmpSelectionnee.Height; i++)
            {
                for (int j = ImagebmpSelectionnee.Width - 30; j < ImagebmpSelectionnee.Width; j++)
                {
                    SommePixelsLigne = SommePixelsLigne + TabPixelsFloat[i, j];
                }

                TabMoyenneX[i] = SommePixelsLigne;
                SommePixelsLigne = 0;
            }

            for (int i = 0; i < TabMoyenneX.Length; i++)
            {
                if (TabMoyenneX[i] < 25 && DebutTrouve == false)
                {
                    DebutValeur = i;
                    DebutTrouve = true;
                }

                if (TabMoyenneX[i] >= 25 && DebutTrouve == true && FinTrouve == false)
                {
                    FinValeur = i;
                    FinTrouve = true;
                }
            }

            x = Convert.ToInt32((DebutValeur + FinValeur) / 2);
            lblx.Text = "x = " + x;

            //y

            SommePixelsLigne = 0;

            DebutTrouve = false;
            FinTrouve = false;
            DebutValeur = 0;
            FinValeur = 0;

            float[] TabMoyenneY = new float[30];

            for (int j = ImagebmpSelectionnee.Width - 30; j < ImagebmpSelectionnee.Width; j++)
            {
                for (int i = 0; i < ImagebmpSelectionnee.Height; i++)
                {
                    SommePixelsLigne = SommePixelsLigne + TabPixelsFloat[i, j];
                }

                TabMoyenneY[j - ImagebmpSelectionnee.Width + 30] = SommePixelsLigne;
                SommePixelsLigne = 0;
            }

            for (int j = 0; j < TabMoyenneY.Length; j++)
            {
                if (TabMoyenneY[j] < 575 && DebutTrouve == false)
                {
                    DebutValeur = j;
                    DebutTrouve = true;
                }

                if (TabMoyenneY[j] >= 575 && DebutTrouve == true && FinTrouve == false)
                {
                    FinValeur = j;
                    FinTrouve = true;
                }
            }

            y = Convert.ToInt32((DebutValeur + FinValeur) / 2) + 570;
            lbly.Text = "y = " + y;

        }

        /// <summary>
        /// ////////////////////////////////// CALCUL DE Dx ET Dy /////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>

        void CalculDxDy()
        {
            //Calcul de Dx

            float SommePixelsLigne = 0;
            float Max = ImagebmpSelectionnee.Width;

            int NbPixelsNoirs = 0;

            for (int j = 0; j < ImagebmpSelectionnee.Width; j++)
            {
                for (int i = 0; i < ImagebmpSelectionnee.Width; i++)
                {
                    SommePixelsLigne = SommePixelsLigne + TabPixelsFloat[i, j];
                }

                if (SommePixelsLigne < Max)
                {
                    Max = SommePixelsLigne;
                    NumLigneCercleMax = j;
                }

                SommePixelsLigne = 0;
            }

            //Ici traiter la ligne de j avec la moyenne de point la plus grande pour obtenir Dx et Cx
            for (int i = 0; i < ImagebmpSelectionnee.Width; i++)
            {
                if (TabPixelsFloat[i, NumLigneCercleMax] < 0.5)
                    NbPixelsNoirs = NbPixelsNoirs + 1;
            }

            Dx = NbPixelsNoirs;
            lblDx.Text = "Dx = " + Dx;



            //Calcul de Dy

            float SommePixelsColonne = 0;
            Max = ImagebmpSelectionnee.Height;

            NbPixelsNoirs = 0;

            for (int i = 0; i < ImagebmpSelectionnee.Width; i++)
            {
                for (int j = 0; j < ImagebmpSelectionnee.Width; j++)
                {
                    SommePixelsColonne = SommePixelsColonne + TabPixelsFloat[i, j];
                }

                if (SommePixelsColonne < Max)
                {
                    Max = SommePixelsColonne;
                    NumColonneCercleMax = i;
                }

                SommePixelsColonne = 0;
            }

            for (int j = 0; j < ImagebmpSelectionnee.Width; j++)
            {
                if (TabPixelsFloat[NumColonneCercleMax, j] < 0.5)
                    NbPixelsNoirs = NbPixelsNoirs + 1;
            }

            Dy = NbPixelsNoirs;
            lblDy.Text = "Dy = " + Dy;
        }

        /// <summary>
        /// ////////////////////////////////// FILTRAGE PASSE-BAS /////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>

        void FiltrePassebas()
        {
            float[,] TabTempoPixels = TabPixelsFloat;

            for (int i = 1; i < ImagebmpSelectionnee.Width - 1; i++)
            {
                for (int j = 1; j < ImagebmpSelectionnee.Height - 1; j++)
                {
                    TabPixelsFloat[i, j] = TabTempoPixels[i - 1, j - 1] * 1 + TabTempoPixels[i, j - 1] * 2 + TabTempoPixels[i + 1, j - 1] * 1 + TabTempoPixels[i - 1, j] * 2 + TabTempoPixels[i, j] * 4 + TabTempoPixels[i + 1, j] * 2 + TabTempoPixels[i - 1, j + 1] * 1 + TabTempoPixels[i, j + 1] * 2 + TabTempoPixels[i + 1, j + 1] * 1;
                    TabPixelsFloat[i, j] = TabPixelsFloat[i, j] / 16;
                }
            }
        }

        /// <summary>
        /// ////////////////////////////////// FILTRAGE MEDIAN /////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>

        void FiltreMedian()
        {
            float[,] TabTempoPixels = TabPixelsFloat;

            float[] TabTempFiltreMedian = new float[9];

            for (int i = 1; i < ImagebmpSelectionnee.Width - 1; i++)
            {
                for (int j = 1; j < ImagebmpSelectionnee.Height - 1; j++)
                {
                    TabTempFiltreMedian[0] = TabTempoPixels[i - 1, j - 1];
                    TabTempFiltreMedian[1] = TabTempoPixels[i, j - 1];
                    TabTempFiltreMedian[2] = TabTempoPixels[i + 1, j - 1];
                    TabTempFiltreMedian[3] = TabTempoPixels[i - 1, j];
                    TabTempFiltreMedian[4] = TabTempoPixels[i, j];
                    TabTempFiltreMedian[5] = TabTempoPixels[i + 1, j];
                    TabTempFiltreMedian[6] = TabTempoPixels[i - 1, j + 1];
                    TabTempFiltreMedian[7] = TabTempoPixels[i, j + 1];
                    TabTempFiltreMedian[8] = TabTempoPixels[i + 1, j + 1];

                    TabPixelsFloat[i, j] = CalcValeurCentraleFiltreMedian(TabTempFiltreMedian);
                }
            }
        }

        static float CalcValeurCentraleFiltreMedian(float[] Tableau)
        {
            float ValeurCentrale;

            TriTab(ref Tableau);

            ValeurCentrale = Tableau[4];

            return ValeurCentrale;
        }

        private void grpResultats_Enter(object sender, EventArgs e)
        {

        }

        static void TriTab(ref float[] Tableau)
        {
            float ValeurTemporaire;

            for (int i = 0; i < Tableau.Length; i++)
            {
                for (int z = i + 1; z < Tableau.Length; z++)
                {
                    if (Tableau[i] < Tableau[z])
                    {
                        ValeurTemporaire = Tableau[i];
                        Tableau[i] = Tableau[z];
                        Tableau[z] = ValeurTemporaire;
                    }
                }
            }
        }

        /// <summary>
        /// ////////////////////////////////// CALCUL DE Cx ET Cy /////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>

        void CalculCxCy()
        {
            //Cx

            int DebutCx = 0, FinCx = 0;
            bool DebutTrouve = false;
            bool FinTrouve = false;
            int mediane;

            for (int i = 1; i < ImagebmpSelectionnee.Width; i++)
            {
                if (TabPixelsFloat[i, NumLigneCercleMax] < 0.5 && DebutTrouve == false)
                {
                    DebutCx = i;
                    DebutTrouve = true;
                }

                if (DebutTrouve == true && TabPixelsFloat[i, NumLigneCercleMax] > 0.5 && FinTrouve == false)
                {
                    FinCx = i;
                    FinTrouve = true;
                }
            }

            //Calcul Mediane entre DebutCx et FinCx

            mediane = Convert.ToInt32((DebutCx + FinCx) / 2);
            lblCx.Text = "Cx = " + mediane;
            Cx = mediane;



            //Cy

            DebutCx = 0;
            FinCx = 0;
            DebutTrouve = false;
            FinTrouve = false;

            for (int j = 1; j < ImagebmpSelectionnee.Height; j++)
            {
                if (TabPixelsFloat[NumColonneCercleMax, j] < 0.5 && DebutTrouve == false)
                {
                    DebutCx = j;
                    DebutTrouve = true;
                }

                if (DebutTrouve == true && TabPixelsFloat[NumColonneCercleMax, j] > 0.5 && FinTrouve == false)
                {
                    FinCx = j;
                    FinTrouve = true;
                }
            }

            //Calcul Mediane entre DebutCx et FinCx

            mediane = Convert.ToInt32((DebutCx + FinCx) / 2);
            lblCy.Text = "Cy = " + mediane;
            Cy = mediane;
        }

        /// <summary>
        /// ///////////////////////////////////// Calcul des valeurs réels ////////////////////////////////////////////////////////////////////////////////////////////////////// 
        /// </summary>
        /// 
        private void cmdValiderVraiXY_Click(object sender, EventArgs e)
        {
            try
            {
                double MultiX, MultiY;
                int DistanceOx_x, DistanceOy_y;

                if (Ox < x)
                    DistanceOx_x = x - Ox;
                else
                    DistanceOx_x = Ox - x;

                MultiX = Convert.ToDouble(txtReelX.Text);
                MultiX = MultiX / DistanceOx_x;


                if (Oy < y)
                    DistanceOy_y = y - Oy;
                else
                    DistanceOy_y = Oy - y;

                MultiY = Convert.ToDouble(txtReelY.Text);
                MultiY = MultiY / DistanceOy_y;

                lblReelDx.Text = "Dx = "+Convert.ToString(Math.Round(Dx * MultiX,3));
                lblReelDy.Text = "Dy = " + Convert.ToString(Math.Round(Dy * MultiY,3));

                lblReelCx.Text = "Cx = " + Convert.ToString(Math.Round(Cx * MultiX,3));
                lblReelCy.Text = "Cy = " + Convert.ToString(Math.Round(Cy * MultiY,3));
            }
            catch
            {
                MessageBox.Show("Choisir des valeurs valides de x et y.");
            }
        }

        /// <summary>
        /// ////////////////////////////////// Commande quitter ////////////////////////////////////////////////////////////////////////////////////////////////////// 
        /// </summary>
        
        private void cmdQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
