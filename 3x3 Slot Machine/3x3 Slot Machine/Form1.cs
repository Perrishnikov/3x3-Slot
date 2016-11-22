using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3x3_Slot_Machine
{
    public partial class Slots3x3 : Form
    {
        static int ROW = 3, COL = 3;
        PictureBox[,] masterBoxes = new PictureBox[ROW, COL]; //array to hold all picboxes
        List<string> fruitsList = new List<string>(); //temp List to hold all fruits presently in panel. Reset on every spin. 
        //will only check fruit in here

        public Slots3x3()
        {
            InitializeComponent();
            makeBoxes();
        }

        private void btn_spin_Click(object sender, EventArgs e)
        {
            insertImages(); //void to insert images into DOM

            List<string> flatList = flattenArray(masterBoxes); //returns list of true if FRUIT == TAG

            bool result = isWin(flatList, fruitsList, win_ThreeInRow()); //compare Master, to win conditions

            if (result)
            {
                MessageBox.Show("Win");
            }
        }

        private bool isWin(List<string> flattenedList, List<string> fruits, int[][] WinValues)
        {
            //flattenedList is string of "cherries.bmp"
            //fruits is is string of "cherries.bmp"
            //WinValues is 8 length, 0-7ints; WinValues[row] is 3 length, 0-8 ints

            var flag = false; //change to true when combo is found
            foreach(var fruit in fruits) //grab a fruit...
            {
                for (int row = 0; row < WinValues.Length; row++) //grab a jagged array...
                {
                    List<int> locations = new List<int>(); //List to hold winning combos

                    for (int col = 0; col < WinValues[row].Length; col++) //grab the combo in the array...
                    {
                        
                        if (flattenedList[WinValues[row][col]] == fruit) //check each location; matching combo vs flattened array...
                        {
                            locations.Add(WinValues[row][col]); //add matching location to list

                            if (locations.Count == WinValues[row].Length) //Win if all 3 matched
                            {
                                Console.WriteLine("Win!"); //log winning combo
                                foreach (var i in locations) {
                                    Console.WriteLine(i.ToString());
                                }
                                flag = true;
                            }
                        }
                    }
                }
            }
            return flag;
        }

        private List<string> flattenArray(PictureBox[,] incoming) //return fruit string "cherries"
        {
            List<string> tempList = new List<string>(); //9
            foreach (var item in incoming) //make incoming into string "cherries"
            {
                tempList.Add(item.Tag.ToString());
            }
            return tempList;
        }

        private int[][] win_ThreeInRow()
        {
            int[][] combos = new int[8][];

            //Create each array that is an element of jagged array
            combos[0] = new int[3] { 0, 4, 8 };
            combos[1] = new int[3] { 1, 4, 7 };
            combos[2] = new int[3] { 2, 4, 6 };
            combos[3] = new int[3] { 3, 4, 5 };
            combos[4] = new int[3] { 0, 1, 2 }; //top
            combos[5] = new int[3] { 2, 5, 8 }; //right
            combos[6] = new int[3] { 6, 7, 8 }; //bottom
            combos[7] = new int[3] { 0, 3, 6 }; //left

            return combos;
        }

        private void insertImages()
        {
            Random rand = new Random();
            //Array.Clear(masterBoxes, 0, masterBoxes.Length);

            fruitsList.Clear();

            foreach (PictureBox picture in masterBoxes)
            {
                int nextRand = rand.Next(10);

                picture.Image = fruitList.Images[nextRand]; //assign random image to each picbox
                picture.Tag = fruitList.Images.Keys[nextRand].ToString(); //assign image name to each picbox
                fruitsList.Add(picture.Tag.ToString()); //add each tag(fruit) to the fruits List
                pnl_boxes.Controls.Add(picture); //render picture in the panel
                //Console.WriteLine(picture.Tag.ToString());
            }
        }

        private void makeBoxes()
        {
            int padding = 15; //padding in form

            for (int row = 0; row < ROW; row++)
            {
                for (int col = 0; col < COL; col++)
                {
                    //Console.WriteLine("row: " + row + " col: " + col);
                    PictureBox picture = new PictureBox
                    {
                        Name = "peanutButter" + row + col,
                        Size = new Size(128, 128),
                        Location = new Point((col * 128) + padding, (row * 128) + padding), //postion each picbox so dont overlap
                        BackColor = Color.FromArgb(255, 249, 189),
                        BorderStyle = BorderStyle.FixedSingle
                    };
                    //Console.WriteLine(picture.Tag);
                    masterBoxes[row, col] = picture; //push picture into masterBoxes array
                    pnl_boxes.Controls.Add(picture); //render backcolor in the panel
                };
            }
        }
    }
}
