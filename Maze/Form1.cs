/* Written by: Alec Turnbull
 * 2/10/16
 *
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ksu.Cis300.MazeLibrary;

namespace Maze
{
    public partial class Form1 : Form
    {
        int rows;
        int cols;
        bool cellCheck;
        bool stepCheck;
        Point firstPoint;
        Cell curCell = new Cell();

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method reacts to when the user presses the new maze button.
        /// It resizes the maze to fit the program, and randomizes a new maze.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxButton_Click(object sender, EventArgs e)
        {
            uxMazePicture.Generate();
        }
        /// <summary>
        /// This method solves the maze through reverse recursion.
        /// It goes through each direction and makes a decision.
        /// </summary>
        /// <param name="x">the cell containing a set of x and y coordinates</param>
        public void uxMaze(Cell x)
        {
            Stack<Direction> _direct = new Stack<Direction>();
            cols = uxMazePicture.MazeWidth;
            rows = uxMazePicture.MazeHeight;
            bool[,] _a = new bool[rows, cols];
            curCell = x;
            _a[curCell.Row, curCell.Column] = true;
            Direction n = new Direction();
            n = Direction.North;


            while (uxMazePicture.IsInMaze(curCell))
            {
                cellCheck = uxMazePicture.IsInMaze(curCell);
                if (n <= Direction.West)
                {
                    stepCheck = uxMazePicture.IsClear(curCell, n);
                    if (uxMazePicture.IsClear(curCell, n) && ((uxMazePicture.IsInMaze(uxMazePicture.Step(curCell, n)) == false || _a[uxMazePicture.Step(curCell, n).Row, uxMazePicture.Step(curCell, n).Column] == false)))
                    {
                        uxMazePicture.DrawPath(curCell, n);
                        _a[curCell.Row, curCell.Column] = true;
                        curCell = uxMazePicture.Step(curCell, n);
                        _direct.Push(n);
                        n = Direction.North;

                    }
                    else
                    {
                        if (n <= Direction.West)
                        {
                            n++;
                        }
                    }
                }
                if (n > Direction.West && _direct.Count != 0)
                {
                    n = _direct.Pop();
                    curCell = uxMazePicture.ReverseStep(curCell, n);
                    uxMazePicture.ErasePath(curCell, n);
                    n++;
                }

                if (n > Direction.West && _direct.Count == 0)
                {
                    MessageBox.Show("No path found.");
                    break;
                }
            }
        }
        /// <summary>
        /// This method collects the location of the mouse click, 
        /// sending it over to the maze solver.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxMazePicture_MouseClick(object sender, MouseEventArgs e)
        {
            firstPoint = e.Location;
            curCell = uxMazePicture.GetCellFromPixel(firstPoint);
            bool check = uxMazePicture.IsInMaze(curCell);
            if (check)
            {
                uxMazePicture.EraseAllPaths();
                uxMaze(curCell);
                uxMazePicture.Invalidate();
                check = false;
            }
        }
    }




    }

