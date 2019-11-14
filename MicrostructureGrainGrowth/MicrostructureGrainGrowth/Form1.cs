using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MicrostructureGrainGrowth
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //MOORE AND ABSORBING BOUNDARY CONDITIONS

        //tables of grains and bitmap
        static Grain[,] matrix = new Grain[300, 300];
        Grain[,] matrixI = new Grain[300, 300];
        static Bitmap bitmap = new Bitmap(300, 300);
        static Bitmap bitmap2 = new Bitmap(300, 300);
        Grain[,] savedGrains = new Grain[300, 300];
        //random engine
        static Random rnd = new Random();
        Color color;
        //all grains
        List<Grain> allGrains = new List<Grain>(90000);
        //MC method states
        Color[] states;
        //saved between MC, CA
        Color[] savedColors = new Color[300];
        int numberSaved = 0;
        //MC method
        int numberOfSteps = 0;
        double J = 0.0;
        int numberOfStates = 0;
        int choosen = 0;
        //CA method
        int numberOfGrains = 0;
        //Energy colors
        Color[] energyColors = new Color[10];

        //flags
        bool first = true;
        bool saved = false;
        bool full = false;
        bool view1 = true;



        private void NucleateButton_Click(object sender, EventArgs e)
        {
            check_methodCheckboxes();

            // initialization of all stuff
            if (first) initialize_stuff();

            //CA method
            if (CAMethodCheckBox.Checked)
            {
                numberOfGrains = check_numberOfGrains();

                //randomly choosing grains and colors
                for (int k = 0; k < numberOfGrains; k++)
                {
                    int i = rnd.Next(0, 300);
                    int j = rnd.Next(0, 300);
                    color = Color.FromArgb(0, rnd.Next(256), rnd.Next(256));
                    if (matrix[i, j].color == Color.White)
                    {
                        matrix[i, j].color = color;
                    }
                }
            }

            //MC method
            if (MCMethodCheckBox.Checked)
            {
                numberOfStates = check_numberOfStates();
                J = check_J();
                numberOfSteps = check_numberOfSteps();

                //randomly choosing colors
                states = new Color[numberOfStates];
                for (int i = 0; i < numberOfStates; i++)
                {
                    states[i] = Color.FromArgb(0, rnd.Next(256), rnd.Next(256));
                }
                //setings all grains
                for (int i = 0; i < 300; i++)
                {
                    for (int j = 0; j < 300; j++)
                    {
                        if (matrix[i, j].color != savedColors[0])
                        {
                            choosen = rnd.Next(0, numberOfStates);
                            matrix[i, j].color = states[choosen];
                        }
                    }
                }
            }

            refresh_bitmap();
        }

        private void GrowthButton_Click(object sender, EventArgs e)
        {

            if (CAMethodCheckBox.Checked)
            {
                add_matrix_to_matrixI();

                while (!full)
                {

                    full = true;

                    int[] counter = new int[8];
                    Color[] colors = new Color[8];
                    for (int i = 0; i < 8; i++) colors[i] = Color.White;

                    for (int i = 0; i < 300; i++)
                    {
                        for (int j = 0; j < 300; j++)
                        {
                            if (matrix[i, j].color == Color.White || matrix[i,j].color == Color.FromArgb(0,0,0,0))
                            {
                                if (i + 1 < 300 && matrix[i + 1, j].color != Color.White && matrix[i + 1, j].color != savedColors[0])
                                {
                                    colors[0] = matrix[i + 1, j].color;
                                    counter[0]++;
                                    full = false;
                                }
                                if (i - 1 >= 0 && matrix[i - 1, j].color != Color.White && matrix[i - 1, j].color != savedColors[0])
                                {
                                    if (matrix[i - 1, j].color == colors[0]) counter[0]++;
                                    else
                                    {
                                        colors[1] = matrix[i - 1, j].color;
                                        counter[1]++;
                                    }
                                    full = false;
                                }
                                if (j + 1 < 300 && matrix[i, j + 1].color != Color.White && matrix[i, j + 1].color != savedColors[0])
                                {
                                    if (matrix[i, j + 1].color == colors[0]) counter[0]++;
                                    else if (matrix[i, j + 1].color == colors[1]) counter[1]++;
                                    else
                                    {
                                        colors[2] = matrix[i, j + 1].color;
                                        counter[2]++;
                                    }
                                    full = false;
                                }
                                if (j - 1 >= 0 && matrix[i, j - 1].color != Color.White && matrix[i, j - 1].color != savedColors[0])
                                {
                                    if (matrix[i, j - 1].color == colors[0]) counter[0]++;
                                    else if (matrix[i, j - 1].color == colors[1]) counter[1]++;
                                    else if (matrix[i, j - 1].color == colors[2]) counter[2]++;
                                    else
                                    {
                                        colors[3] = matrix[i, j - 1].color;
                                        counter[3]++;
                                    }
                                    full = false;
                                }
                                if (i + 1 < 300 && j + 1 < 300 && matrix[i + 1, j + 1].color != Color.White && matrix[i + 1, j + 1].color != savedColors[0])
                                {
                                    if (matrix[i + 1, j + 1].color == colors[0]) counter[0]++;
                                    else if (matrix[i + 1, j + 1].color == colors[1]) counter[1]++;
                                    else if (matrix[i + 1, j + 1].color == colors[2]) counter[2]++;
                                    else if (matrix[i + 1, j + 1].color == colors[3]) counter[3]++;
                                    else
                                    {
                                        colors[4] = matrix[i + 1, j + 1].color;
                                        counter[4]++;
                                    }
                                    full = false;
                                }
                                if (i + 1 < 300 && j - 1 >= 0 && matrix[i + 1, j - 1].color != Color.White && matrix[i + 1, j - 1].color != savedColors[0])
                                {
                                    if (matrix[i + 1, j - 1].color == colors[0]) counter[0]++;
                                    else if (matrix[i + 1, j - 1].color == colors[1]) counter[1]++;
                                    else if (matrix[i + 1, j - 1].color == colors[2]) counter[2]++;
                                    else if (matrix[i + 1, j - 1].color == colors[3]) counter[3]++;
                                    else if (matrix[i + 1, j - 1].color == colors[4]) counter[4]++;
                                    else
                                    {
                                        colors[5] = matrix[i + 1, j - 1].color;
                                        counter[5]++;
                                    }
                                    full = false;
                                }
                                if (i - 1 >= 0 && j - 1 >= 0 && matrix[i - 1, j - 1].color != Color.White && matrix[i - 1, j - 1].color != savedColors[0])
                                {
                                    if (matrix[i - 1, j - 1].color == colors[0]) counter[0]++;
                                    else if (matrix[i - 1, j - 1].color == colors[1]) counter[1]++;
                                    else if (matrix[i - 1, j - 1].color == colors[2]) counter[2]++;
                                    else if (matrix[i - 1, j - 1].color == colors[3]) counter[3]++;
                                    else if (matrix[i - 1, j - 1].color == colors[4]) counter[4]++;
                                    else if (matrix[i - 1, j - 1].color == colors[5]) counter[5]++;
                                    else
                                    {
                                        colors[6] = matrix[i - 1, j - 1].color;
                                        counter[6]++;
                                    }
                                    full = false;
                                }
                                if (i - 1 >= 0 && j + 1 < 300 && matrix[i - 1, j + 1].color != Color.White && matrix[i - 1, j + 1].color != savedColors[0])
                                {
                                    if (matrix[i - 1, j + 1].color == colors[0]) counter[0]++;
                                    else if (matrix[i - 1, j + 1].color == colors[1]) counter[1]++;
                                    else if (matrix[i - 1, j + 1].color == colors[2]) counter[2]++;
                                    else if (matrix[i - 1, j + 1].color == colors[3]) counter[3]++;
                                    else if (matrix[i - 1, j + 1].color == colors[4]) counter[4]++;
                                    else if (matrix[i - 1, j + 1].color == colors[5]) counter[5]++;
                                    else if (matrix[i - 1, j + 1].color == colors[6]) counter[6]++;
                                    else
                                    {
                                        colors[7] = matrix[i - 1, j + 1].color;
                                        counter[7]++;
                                    }
                                    full = false;
                                }

                                //add max color to grain
                                int maxValue = counter.Max();
                                int maxIndex = counter.ToList().IndexOf(maxValue);

                                if (maxIndex == 0) matrixI[i, j].color = colors[0];
                                if (maxIndex == 1) matrixI[i, j].color = colors[1];
                                if (maxIndex == 2) matrixI[i, j].color = colors[2];
                                if (maxIndex == 3) matrixI[i, j].color = colors[3];
                                if (maxIndex == 4) matrixI[i, j].color = colors[4];
                                if (maxIndex == 5) matrixI[i, j].color = colors[5];
                                if (maxIndex == 6) matrixI[i, j].color = colors[6];
                                if (maxIndex == 7) matrixI[i, j].color = colors[7];

                                for (int k = 0; k < 8; k++)
                                {
                                    colors[k] = Color.White;
                                    counter[k] = 0;
                                }
                            }
                        }
                    }
                    add_matrixI_to_matrix();
                    refresh_bitmap();
                }
            }

            if (MCMethodCheckBox.Checked)
            {
                numberOfStates = check_numberOfStates();
                J = check_J();
                numberOfSteps = check_numberOfSteps();

                for (int n = 0; n < numberOfSteps; n++)
                {
                    for (int i = 0; i < 300; i++)
                    {
                        for (int j = 0; j < 300; j++)
                        {
                            allGrains.Add(matrix[i, j]);
                        }
                    }
                    while (allGrains.Count > 0)
                    {
                        int counter = rnd.Next(allGrains.Count);
                        int i = allGrains[counter].x;
                        int j = allGrains[counter].y;
                        allGrains.RemoveAt(counter);
                        Dictionary<Color, int> neighborhood = new Dictionary<Color, int>();
                        double energyBefore = 0;
                        double energyAfter = 0;

                        if (matrix[i, j].color != savedColors[0])
                        {
                            // check all the naighbors
                            if (i - 1 > -1) { if (matrix[i - 1, j].color != savedColors[0]) { UpdateDictionary(ref neighborhood, i - 1, j); } }
                            if (i + 1 < 300) { if (matrix[i + 1, j].color != savedColors[0]) { UpdateDictionary(ref neighborhood, i + 1, j); } }
                            if (j - 1 > -1) { if (matrix[i, j - 1].color != savedColors[0]) { UpdateDictionary(ref neighborhood, i, j - 1); } }
                            if (j + 1 < 300) { if (matrix[i, j + 1].color != savedColors[0]) { UpdateDictionary(ref neighborhood, i, j + 1); } }
                            if (i - 1 > -1 && j - 1 > -1) { if (matrix[i - 1, j - 1].color != savedColors[0]) { UpdateDictionary(ref neighborhood, i - 1, j - 1); } }
                            if (i + 1 < 300 && j + 1 < 300) { if (matrix[i + 1, j + 1].color != savedColors[0]) { UpdateDictionary(ref neighborhood, i + 1, j + 1); } }
                            if (i - 1 > -1 && j + 1 < 300) { if (matrix[i - 1, j + 1].color != savedColors[0]) { UpdateDictionary(ref neighborhood, i - 1, j + 1); } }
                            if (i + 1 < 300 && j - 1 > -1) { if (matrix[i + 1, j - 1].color != savedColors[0]) { UpdateDictionary(ref neighborhood, i + 1, j - 1); } }

                            if (neighborhood.Count == 0) { continue; }
                            //calculate energy before
                            for (int k = 0; k < neighborhood.Count; k++)
                            {
                                if (neighborhood.ElementAt(k).Key == matrix[i, j].color) { continue; }
                                energyBefore += neighborhood.ElementAt(k).Value;
                            }
                            energyBefore *= J;
                            Color theColor = neighborhood.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;

                            // calculate energy after
                            for (int k = 0; k < neighborhood.Count; k++)
                            {
                                if (neighborhood.ElementAt(k).Key == theColor) { continue; }
                                energyAfter += neighborhood.ElementAt(k).Value;
                            }
                            energyAfter *= J;

                            //calculate delta and make change if it's nessesary (matrix and bitmap)
                            double delta = energyAfter - energyBefore;
                            if (delta <= 0) { matrix[i, j].color = theColor; }
                        }
                    }
                    refresh_bitmap();
                }
            }

            if (RecrystalizationCheckBox.Checked)
            {

                int numberOfRGrains = check_numberOfRgrains();
                int increaseOfGrains = check_increaseOfGrains();
                int increaseStepInterval = check_increaseStepInterval();
                int numberOfRSteps = check_numberOfRSteps();
                J = check_J();

                

                if (AtTheBeginingCheckBox.Checked)
                {
                    nucleateR(numberOfRGrains);
                    for (int n = 0; n < numberOfRSteps; n++)
                    {
                        growing_recrystallization();
                    }
                }

                if (ConstantCheckBox.Checked)
                {
                    int step = increaseStepInterval;
                    nucleateR(numberOfRGrains);
                    for (int n = 0; n < numberOfRSteps; n++)
                    {
                        if (step == 0)
                        {
                            nucleateR(numberOfRGrains);
                            step = increaseStepInterval;
                        }
                        growing_recrystallization();
                        step--;
                    }
                }

                if (IncreasingCheckBox.Checked)
                {
                    int step = increaseStepInterval;
                    int numberToAdd = numberOfRGrains;
                    nucleateR(numberToAdd);
                    for (int n = 0; n < numberOfRSteps; n++)
                    {
                        if (step == 0)
                        {
                            numberToAdd += increaseOfGrains;
                            nucleateR(numberToAdd);
                            step = increaseStepInterval;
                        }
                        growing_recrystallization();
                        step--;
                    }
                }
            }

            first = false;
            full = false;
        }

        private void growing_recrystallization()
        {
            for (int i = 0; i < 300; i++)
            {
                for (int j = 0; j < 300; j++)
                {
                    allGrains.Add(matrix[i, j]);
                }
            }
            while (allGrains.Count > 0)
            {
                int counter = rnd.Next(allGrains.Count);
                int i = allGrains[counter].x;
                int j = allGrains[counter].y;
                allGrains.RemoveAt(counter);

                Dictionary<Color, int> neighborhood = new Dictionary<Color, int>();
                double energyBefore = 0;
                double energyAfter = 0;

                if (matrix[i, j].energy == 0  ) { continue; }

                // check all the naighbors
                if (i - 1 > -1) {  UpdateDictionary(ref neighborhood, i - 1, j); } 
                if (i + 1 < 300) {  UpdateDictionary(ref neighborhood, i + 1, j); } 
                if (j - 1 > -1) {  UpdateDictionary(ref neighborhood, i, j - 1); } 
                if (j + 1 < 300) { UpdateDictionary(ref neighborhood, i, j + 1); } 
                if (i - 1 > -1 && j - 1 > -1) { UpdateDictionary(ref neighborhood, i - 1, j - 1); } 
                if (i + 1 < 300 && j + 1 < 300) { UpdateDictionary(ref neighborhood, i + 1, j + 1); } 
                if (i - 1 > -1 && j + 1 < 300) {  UpdateDictionary(ref neighborhood, i - 1, j + 1); } 
                if (i + 1 < 300 && j - 1 > -1) {  UpdateDictionary(ref neighborhood, i + 1, j - 1); } 

                //calculate energy before
                for (int k = 0; k < neighborhood.Count; k++)
                {
                    if (neighborhood.ElementAt(k).Key == matrix[i, j].color) { continue; }
                    energyBefore += neighborhood.ElementAt(k).Value;
                }
                energyBefore *= J;
                energyBefore += matrix[i, j].energy;

                Color theColor = neighborhood.ElementAt(rnd.Next(neighborhood.Count)).Key;
                if (theColor.G != 0 || theColor.B != 0 || theColor==Color.FromArgb(0,0,0,0)) { continue; }

                // calculate energy after
                for (int k = 0; k < neighborhood.Count; k++)
                {
                    if (neighborhood.ElementAt(k).Key == theColor) { continue; }
                    energyAfter += neighborhood.ElementAt(k).Value;
                }
                energyAfter *= J;

                //calculate delta and make change if it's nessesary
                double delta = energyAfter - energyBefore;
                if (delta < 0)
                {
                    matrix[i, j].color = theColor;
                    matrix[i, j].H = Color.Red;
                    matrix[i, j].energy = 0;
                }

            }
            refresh_bitmap();

        }



        private void nucleateR(int number)
        {
            int stop = 0;
            int boundaryEnergy = check_boundaryEnergy();
            for (int k = 0; k < number; k++)
            {
                if (stop >= 100) { return; }
                    int i = rnd.Next(0, 300);
                    int j = rnd.Next(0, 300);

                    if (EverywhereCheckBox.Checked)
                    {
                        color = Color.FromArgb(rnd.Next(5,250), 0, 0);
                        matrix[i, j].color = color;
                        matrix[i, j].H = Color.Red;
                        matrix[i, j].energy = 0;
                    }
                    if (OnlyOnBoundariesCheckBox.Checked)
                    {
                        if (matrix[i,j].energy == boundaryEnergy)
                        {
                            color = Color.FromArgb(rnd.Next(5,250), 0, 0);
                            matrix[i, j].color = color;
                            matrix[i, j].H = Color.Red;
                            matrix[i, j].energy = 0;
                        }
                        else
                        {
                            k--;
                            stop++;
                        }
                }

            }
            refresh_bitmap();
        }


        private void ClearButton_Click(object sender, EventArgs e)
        {
            // set matrix and bitmap to white
            for (int i = 0; i < 300; i++)
            {
                for (int j = 0; j < 300; j++)
                {
                    if (MCMethodCheckBox.Checked)
                    {
                        if (matrix[i, j].color == savedColors[0]) saved = true;
                        if (!saved)
                        {
                            matrix[i, j].color = Color.White;
                            bitmap.SetPixel(i, j, Color.White);
                        }
                        saved = false;
                    }
                    else
                    {
                        for (int k = 0; k < numberSaved; k++)
                        {
                            if (matrix[i, j].color == savedColors[k]) saved = true;
                        }
                        if (saved)
                        {
                            matrix[i, j].color = savedColors[0];
                            bitmap.SetPixel(i, j, savedColors[0]);
                        }
                        if (!saved)
                        {
                            matrix[i, j].color = Color.White;
                            bitmap.SetPixel(i, j, Color.White);
                        }
                        saved = false;
                    }
                }
            }
            refresh_bitmap();
        }

        private void ClearAllButton_Click(object sender, EventArgs e)
        {
            initialize_stuff();
            numberSaved = 0;
            numberOfSteps = 0;
            J = 0.0;
            numberOfStates = 0;
            choosen = 0;
            numberOfGrains = 0;
            first = true;
            saved = false;
            full = false;

            // set matrix and bitmap to white
            for (int i = 0; i < 300; i++)
            {
                for (int j = 0; j < 300; j++)
                {
                    if (MCMethodCheckBox.Checked)
                    {
                        if (matrix[i, j].color == savedColors[0]) saved = true;
                        if (!saved)
                        {
                            matrix[i, j].color = Color.White;
                            bitmap.SetPixel(i, j, Color.White);
                        }
                        saved = false;
                    }
                    else
                    {
                        for (int k = 0; k < numberSaved; k++)
                        {
                            if (matrix[i, j].color == savedColors[k]) saved = true;
                        }
                        if (saved)
                        {
                            matrix[i, j].color = savedColors[0];
                            bitmap.SetPixel(i, j, savedColors[0]);
                        }
                        if (!saved)
                        {
                            matrix[i, j].color = Color.White;
                            bitmap.SetPixel(i, j, Color.White);
                        }
                        saved = false;
                    }
                }
            }
            refresh_bitmap();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            savedGrains[e.X, e.Y].color = bmp.GetPixel(e.X, e.Y);
            savedColors[numberSaved] = savedGrains[e.X, e.Y].color;
            numberSaved++;
        }

        public void UpdateDictionary(ref Dictionary<Color, int> d, int i, int j)
        {
            d.TryGetValue(matrix[i, j].color, out int value);
            d[matrix[i, j].color] = value + 1;
        }

        private void addEnergyButton_Click(object sender, EventArgs e)
        {
            int grainEnergy = check_grainEnergy();
            int boundaryEnergy = check_boundaryEnergy();

            for (int i = 0; i < 300; i++)
            {
                for (int j = 0; j < 300; j++)
                {
                    if (HomogenousCheckBox.Checked)
                    {
                        matrix[i, j].H = energyColors[grainEnergy - 1];
                        matrix[i, j].energy = grainEnergy;
                    }
                    if (HeterogenousCheckBox.Checked)
                    {
                        if (i + 1 < 300 && matrix[i + 1, j].color != matrix[i, j].color || i - 1 >= 0 && matrix[i - 1, j].color != matrix[i, j].color
                            || j + 1 < 300 && matrix[i, j + 1].color != matrix[i, j].color || j - 1 >= 0 && matrix[i, j - 1].color != matrix[i, j].color
                            || i + 1 < 300 && j + 1 < 300 && matrix[i + 1, j + 1].color != matrix[i, j].color || i + 1 < 300 && j - 1 >= 0 && matrix[i + 1, j - 1].color != matrix[i, j].color
                            || i - 1 >= 0 && j - 1 >= 0 && matrix[i - 1, j - 1].color != matrix[i, j].color || i - 1 >= 0 && j + 1 < 300 && matrix[i - 1, j + 1].color != matrix[i, j].color)
                        {
                            matrix[i, j].H = energyColors[boundaryEnergy - 1];
                            matrix[i, j].energy = boundaryEnergy;
                        }
                        else
                        {
                            matrix[i, j].H = energyColors[grainEnergy - 1];
                            matrix[i, j].energy = grainEnergy;
                        }
                    }

                    bitmap2.SetPixel(i, j, matrix[i, j].H);
                }
            }
            refresh_bitmap();
        }

        private void refresh_bitmap()
        {
            // setting bitmap
            for (int i = 0; i < 300; i++)
            {
                for (int j = 0; j < 300; j++)
                {
                    bitmap.SetPixel(i, j, matrix[i, j].color);
                    bitmap2.SetPixel(i, j, matrix[i, j].H);
                }
            }

            pictureBox1.Image = bitmap;
            pictureBox1.Refresh();
        }

        private void initialize_stuff()
        {
            energyColors[0] = Color.PapayaWhip;
            energyColors[1] = Color.Yellow;
            energyColors[2] = Color.Salmon;
            energyColors[3] = Color.Orange;
            energyColors[4] = Color.LightSkyBlue;
            energyColors[5] = Color.DarkBlue;
            energyColors[6] = Color.MidnightBlue;
            energyColors[7] = Color.LimeGreen;
            energyColors[8] = Color.DarkGreen;
            energyColors[9] = Color.DarkSlateGray;

            for (int i = 0; i < 300; i++)
            {
                for (int j = 0; j < 300; j++)
                {

                    matrix[i, j] = new Grain();
                    matrix[i, j].color = Color.White;
                    matrix[i, j].x = i;
                    matrix[i, j].y = j;
                    matrix[i, j].H = Color.White;

                    matrixI[i, j] = new Grain();
                    matrixI[i, j].color = Color.White;
                    matrixI[i, j].H = Color.White;

                    savedGrains[i, j] = new Grain();
                    savedGrains[i, j].color = Color.White;
                    savedGrains[i, j].x = i;
                    savedGrains[i, j].y = j;
                    savedGrains[i, j].H = Color.White;


                }
            }
        }

        private void ChangeViewButton_Click(object sender, EventArgs e)
        {
            if (view1 == true)
            {
                pictureBox1.Image = bitmap2;
                pictureBox1.Refresh();
                view1 = false;
            }
            else
            {
                pictureBox1.Image = bitmap;
                pictureBox1.Refresh();
                view1 = true;
            }
        }

        private int check_numberOfStates()
        {
            if (!Int32.TryParse(NumberOfStatesTextBox.Text, out int tmp))
            {
                MessageBox.Show("Bad value. Please fix it.", "Number of states", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return (tmp);
        }

        private double check_J()
        {
            if (!Double.TryParse(JTextBox.Text, out double tmp))
            {
                MessageBox.Show("Bad value. Please fix it.", "J", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return (tmp);
        }

        private int check_numberOfSteps()
        {
            if (!Int32.TryParse(NumberOfStepsTextBox.Text, out int tmp))
            {
                MessageBox.Show("Bad value. Please fix it.", "Number of steps", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return (tmp);
        }

        private int check_numberOfGrains()
        {
            if (!Int32.TryParse(numberOfGrainsTextBox.Text, out int tmp))
            {
                MessageBox.Show("Bad value. Please fix it.", "Number of grains", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return (tmp);
        }

        private void check_methodCheckboxes()
        {
            if (!(CAMethodCheckBox.Checked || MCMethodCheckBox.Checked))
            {
                MessageBox.Show("Please select method type.", "Method type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void add_matrix_to_matrixI()
        {
            for (int k = 0; k < 300; k++)
            {
                for (int l = 0; l < 300; l++)
                {
                    matrixI[k, l].color = matrix[k, l].color;
                }
            }
        }

        private void add_matrixI_to_matrix()
        {
            for (int i = 0; i < 300; i++)
            {
                for (int j = 0; j < 300; j++)
                {
                    matrix[i, j].color = matrixI[i, j].color;
                }
            }
        }

        private int check_grainEnergy()
        {
            if (!Int32.TryParse(grainTextBox.Text, out int tmp))
            {
                MessageBox.Show("Bad value. Please fix it.", "Grain energy", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return (tmp);
        }

        private int check_boundaryEnergy()
        {
            if (!Int32.TryParse(boundaryTextBox.Text, out int tmp))
            {
                MessageBox.Show("Bad value. Please fix it.", "Boundary energy" +
                    "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return (tmp);
        }

        private int check_numberOfRgrains()
        {
            if (!Int32.TryParse(numberOfRGrainsTextBox.Text, out int tmp))
            {
                MessageBox.Show("Bad value. Please fix it.", "Number of recrystalization grains", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return (tmp);
        }

        private int check_increaseOfGrains()
        {
            if (!Int32.TryParse(increaseOfGrainsTextBox.Text, out int tmp))
            {
                MessageBox.Show("Bad value. Please fix it.", "Increase of recrystalization grains", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return (tmp);
        }

        private int check_increaseStepInterval()
        {
            if (!Int32.TryParse(increaseStepIntervalTextBox.Text, out int tmp))
            {
                MessageBox.Show("Bad value. Please fix it.", "Increase step interval", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return (tmp);
        }

        private int check_numberOfRSteps()
        {
            if (!Int32.TryParse(NumberOfRStepsTextBox.Text, out int tmp))
            {
                MessageBox.Show("Bad value. Please fix it.", "Number of recrystallization steps", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return (tmp);
        }

    }

    //Grain class
    public class Grain
    {
        public Color color;
        public int x;
        public int y;
        public Color H;
        public int energy;
    }


}
