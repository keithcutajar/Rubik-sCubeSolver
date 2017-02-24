using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CubeSolvingAssignment
{
    public partial class MiniCubeSolver : Form
    {
        double widthProportion = 0;
        double heightProportion = 0;
        Dictionary<string, double> xPositions = new Dictionary<string, double>();
        Dictionary<string, double> yPositions = new Dictionary<string, double>();
        public Cube cube;
        public List<Edge> solutionSteps;
             
        public MiniCubeSolver()
        {
            
            InitializeComponent();

             btnRotateSolve.Enabled = false;
            

            cube = new Cube();
            //Calculate Width Propotions
            widthProportion = Convert.ToDouble(pnl8.Width) / Convert.ToDouble(grpBoxCube.Width);
            heightProportion = Convert.ToDouble(pnl8.Height) / Convert.ToDouble(grpBoxCube.Height);
            //Calculate x proportions
            foreach (Control c in grpBoxCube.Controls)
            {
                double xProportion = Convert.ToDouble(c.Location.X) / Convert.ToDouble(grpBoxCube.Width);
                double yProportion = Convert.ToDouble(c.Location.Y) / Convert.ToDouble(grpBoxCube.Height);
                xPositions.Add(c.Name, xProportion);       
                yPositions.Add(c.Name, yProportion);
            }

        }

        private void ShowCube()
        {
            for (int i = 0; i<24; i++)
            {
                Panel p = (Panel)this.Controls.Find("pnl" + i.ToString(), true)[0];
                p.BackColor = cube.GridMap[i];
            }
        }

        private void populateDropDowns()
        {
            cmbSide.DataSource = Enum.GetValues(typeof(Faces));
            cmbDirection.DataSource = Enum.GetValues(typeof(Directions));
            cmbApproach.DataSource = Enum.GetValues(typeof(ShortestRoute));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowCube();
            populateDropDowns();

        }

        private void MiniCubeSolver_SizeChanged(object sender, EventArgs e)
        {
            //Calculate width proportion
            foreach(Control c in grpBoxCube.Controls)
            {
                double newWidth = widthProportion * Convert.ToDouble(grpBoxCube.Width);
                c.Width = Convert.ToInt32(newWidth);

                double newHeight = heightProportion * Convert.ToDouble(grpBoxCube.Height);
                c.Height = Convert.ToInt32(newHeight);
            }

            //Calculate x proportion
            foreach (Control c in grpBoxCube.Controls)
            {
                double xPropotion = xPositions[c.Name] * Convert.ToDouble(grpBoxCube.Width);
                double yPropotion = yPositions[c.Name] * Convert.ToDouble(grpBoxCube.Height);
                c.Location = new Point(Convert.ToInt32(xPropotion), Convert.ToInt32(yPropotion));
            }

        }

        private void btnRotate_Click(object sender, EventArgs e)
        {
            Faces face;
            Enum.TryParse<Faces>(cmbSide.SelectedValue.ToString(), out face);

            Directions direction;
            Enum.TryParse<Directions>(cmbDirection.SelectedValue.ToString(), out direction);

            cube = cube.RotateCube(face, direction);
            ShowCube();
            
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {

            Stopwatch st = new Stopwatch();

            st.Start();
            ShortestRoute shortestRoute;
            Enum.TryParse(cmbApproach.SelectedValue.ToString(), out shortestRoute);

            var node = new Node
            {
                CubeNode = cube,
                isVisited = false
            };

            var graph = new Graph(node);
            graph.CreateGraph();

         

            solutionSteps = graph.GetSolution(shortestRoute);
            PopulateListBox();
            st.Stop();
            TimeSpan ts = st.Elapsed;

            //parallel
        }

        private void PopulateListBox()
        {
            listBoxSolution.Items.Clear();
            foreach(var e in solutionSteps)
            {
                listBoxSolution.Items.Add(e);
            }

            if(listBoxSolution.Items.Count > 0)
            {
                listBoxSolution.SetSelected(0, true);
                btnRotateSolve.Enabled = true;
            }
            
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRotateSolve_Click(object sender, EventArgs e)
        {
            if (listBoxSolution.Items.Count > 0) {
                var edge = (Edge)listBoxSolution.Items[0];
                cube = cube.RotateCube(edge.face, edge.direction);
                solutionSteps.Remove(edge);
                ShowCube();
                PopulateListBox();
            }
            

            if(listBoxSolution.Items.Count == 0)
            {
                btnRotateSolve.Enabled = false;
            }
        }
    }
}
